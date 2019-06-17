Public Class Core
    Private WithEvents client As LifxNet.LifxClient
    Private WithEvents mc As Morse

    Private repeatThread As Threading.Thread
    Private philipsApiUsername As String

    Private Sub Client_DeviceDiscovered(ByVal sender As Object, ByVal e As LifxNet.LifxClient.DeviceDiscoveryEventArgs) Handles client.DeviceDiscovered
        Dim bulb = TryCast(e.Device, LifxNet.LightBulb)
        client.SetDevicePowerStateAsync(bulb, False)
        If bulb IsNot Nothing Then discoveredLight_add(New LifxBulb With {.bulb = bulb})
    End Sub

    Private Delegate Sub discoveredLight_add_Delegate(ByVal item As Object)

    Private Sub discoveredLight_add(ByVal item As Object)
        If discoveredLightsLBX.InvokeRequired() Then
            discoveredLightsLBX.Invoke(New discoveredLight_add_Delegate(AddressOf discoveredLight_add), New Object() {item})
        Else
            discoveredLightsLBX.Items.Add(item)
        End If
    End Sub

    Private Sub AcceptAllCerts()
        'To allow communication with Philips Hue bridge

        System.Net.ServicePointManager.ServerCertificateValidationCallback =
  Function(se As Object,
  cert As System.Security.Cryptography.X509Certificates.X509Certificate,
  chain As System.Security.Cryptography.X509Certificates.X509Chain,
  sslerror As System.Net.Security.SslPolicyErrors) True
    End Sub

    Private Async Sub Core_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptAllCerts()

        mc = New Morse

        'Auto discover Lifx lights
        client = Await LifxNet.LifxClient.CreateAsync()
        client.StartDeviceDiscovery()
    End Sub

    Private Sub lightZeroBTN_Click(sender As Object, e As EventArgs)
        AddHandler mc.BeginTransmit, AddressOf mc_BeginTransmit
        AddHandler mc.EndTransmit, AddressOf mc_EndTransmit
        AddHandler mc.TransmissionTermination, AddressOf mc_TransmissionTermination

        Console.WriteLine(mc.Convert("Hello") & " will be transmitted.")
        mc.Transmit("Hello")
    End Sub

    Private Sub SendPowerState(ByVal State As Boolean)
        Dim lBulb As LifxBulb = TryCast(discoveredLightsLBX.Items(discoveredLightsLBX.SelectedIndex), LifxBulb)
        If lBulb IsNot Nothing Then
            client.SetDevicePowerStateAsync(lBulb.bulb, State)
        Else
            Dim pLight As PhilipsLight = discoveredLightsLBX.Items(discoveredLightsLBX.SelectedIndex)
            pLight.SetDevicePowerState(State)
        End If
    End Sub

    Private Sub mc_BeginTransmit()
        SendPowerState(True)

        Console.WriteLine("Sent power state ON.")
    End Sub

    Private Sub mc_EndTransmit()
        SendPowerState(False)

        Console.WriteLine("Sent power state OFF.")
    End Sub

    Private Sub mc_TransmissionTermination()
        RemoveHandler mc.BeginTransmit, AddressOf mc_BeginTransmit
        RemoveHandler mc.EndTransmit, AddressOf mc_EndTransmit

        Console.WriteLine("Transmission finished.")
    End Sub

    Private Sub lightZeroOnRBTN_CheckedChanged(sender As Object, e As EventArgs) Handles lightZeroOnRBTN.CheckedChanged
        SendPowerState(True)

        Console.WriteLine("Sent power state ON.")
    End Sub

    Private Sub lightZeroOffRBTN_CheckedChanged(sender As Object, e As EventArgs) Handles lightZeroOffRBTN.CheckedChanged
        SendPowerState(False)

        Console.WriteLine("Sent power state OFF.")
    End Sub

    Private Sub lightZeroRepeat()
        While repeatThread.ThreadState = Threading.ThreadState.Running
            client.SetDevicePowerStateAsync(discoveredLightsLBX.Items(discoveredLightsLBX.SelectedIndex).bulb, True)
            Threading.Thread.Sleep(lightZeroRepeatTXT.Text)
            client.SetDevicePowerStateAsync(discoveredLightsLBX.Items(discoveredLightsLBX.SelectedIndex).bulb, False)
            Threading.Thread.Sleep(lightZeroRepeatTXT.Text)
        End While

        client.SetDevicePowerStateAsync(discoveredLightsLBX.Items(discoveredLightsLBX.SelectedIndex), False)
    End Sub

    Private Sub lightZeroRepeatOnRBTN_CheckedChanged(sender As Object, e As EventArgs) Handles lightZeroRepeatOnRBTN.CheckedChanged
        If Integer.TryParse(lightZeroRepeatTXT.Text, Nothing) Then
            repeatThread = New Threading.Thread(AddressOf lightZeroRepeat)
            repeatThread.Start()

            lightZeroRepeatTXT.Enabled = False
        End If
    End Sub

    Private Sub lightZeroRepeatOffRBTN_CheckedChanged(sender As Object, e As EventArgs) Handles lightZeroRepeatOffRBTN.CheckedChanged
        repeatThread.Abort()

        lightZeroRepeatTXT.Enabled = True
    End Sub

    Private Sub sendBTN_Click(sender As Object, e As EventArgs) Handles sendBTN.Click
        AddHandler mc.BeginTransmit, AddressOf mc_BeginTransmit
        AddHandler mc.EndTransmit, AddressOf mc_EndTransmit
        AddHandler mc.TransmissionTermination, AddressOf mc_TransmissionTermination

        Console.WriteLine(mc.Convert(sendTXT.Text) & " will be transmitted.")
        mc.Transmit(sendTXT.Text)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Environment.Exit(0)
    End Sub

    Private Sub HelloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelloToolStripMenuItem.Click
        AddHandler mc.BeginTransmit, AddressOf mc_BeginTransmit
        AddHandler mc.EndTransmit, AddressOf mc_EndTransmit
        AddHandler mc.TransmissionTermination, AddressOf mc_TransmissionTermination

        Console.WriteLine(mc.Convert("Hello") & " will be transmitted.")
        mc.Transmit("Hello")
    End Sub

    Private Function PhilipsBridgeDiscovery(ByVal UseCloudDiscovery As Boolean) As Net.IPAddress
        Dim BridgeIP As Net.IPAddress = Net.IPAddress.None

        If UseCloudDiscovery Then
            Dim BridgeDiscoveryData As String = String.Empty
            Using wc As New Net.WebClient
                BridgeDiscoveryData = wc.DownloadString("https://discovery.meethue.com/").Trim()
            End Using
            Dim js As New Web.Script.Serialization.JavaScriptSerializer
            Dim DiscoveryDataResult As Boolean = Net.IPAddress.TryParse(js.DeserializeObject(BridgeDiscoveryData)(0)("internalipaddress"), BridgeIP)
            If DiscoveryDataResult Then Return BridgeIP
        End If

        'Use LAN fallback method here

        Return BridgeIP
    End Function

    Private Function PhilipsLightDiscovery(ByVal Username As String, Optional ByVal BridgeIP As Net.IPAddress = Nothing) As Dictionary(Of String, Object)
        If BridgeIP Is Nothing Then BridgeIP = PhilipsBridgeDiscovery(True)

        Dim LightURL As String = "https://" + BridgeIP.ToString() + "/api/" + Username + "/lights"
        Dim js As New Web.Script.Serialization.JavaScriptSerializer
        Using wc As New Net.WebClient
            Return js.DeserializeObject(wc.DownloadString(LightURL))
        End Using
    End Function

    Private Sub PhilipsUsernameTXT_Click(sender As Object, e As KeyEventArgs) Handles PhilipsUsernameTXT.KeyDown
        If e.KeyCode = Keys.Enter Then philipsApiUsername = PhilipsUsernameTXT.Text
    End Sub

    Private Async Sub RediscoverAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RediscoverAllToolStripMenuItem.Click
        discoveredLightsLBX.Items.Clear()
        client.StopDeviceDiscovery()
        client.Dispose()

        'Auto discover Lifx lights
        client = Await LifxNet.LifxClient.CreateAsync()
        client.StartDeviceDiscovery()

        'Auto discover Philips lights
        Try
            Dim PhilipsBridgeIP As Net.IPAddress = PhilipsBridgeDiscovery(True)
            Dim PhilipsLights As Dictionary(Of String, Object) = PhilipsLightDiscovery(philipsApiUsername, PhilipsBridgeIP)
            For i As Integer = 1 To PhilipsLights.Count
                discoveredLightsLBX.Items.Add(New PhilipsLight(philipsApiUsername, i.ToString(), PhilipsBridgeIP.ToString()) With {.LightData = PhilipsLights(i.ToString())})
            Next
        Catch ex As Exception
        End Try
    End Sub
End Class
