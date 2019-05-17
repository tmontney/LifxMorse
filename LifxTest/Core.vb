Public Class Core
    Private WithEvents client As LifxNet.LifxClient
    Private WithEvents mc As Morse

    Private repeatThread As Threading.Thread

    Private Sub Client_DeviceDiscovered(ByVal sender As Object, ByVal e As LifxNet.LifxClient.DeviceDiscoveryEventArgs) Handles client.DeviceDiscovered
        Dim bulb = TryCast(e.Device, LifxNet.LightBulb)
        client.SetDevicePowerStateAsync(bulb, False)
        If bulb IsNot Nothing Then discoveredLight_add(New Bulb With {.bulb = bulb})
    End Sub

    Private Delegate Sub discoveredLight_add_Delegate(ByVal item As Object)


    Private Sub discoveredLight_add(ByVal item As Object)
        If discoveredLightsLBX.InvokeRequired() Then
            discoveredLightsLBX.Invoke(New discoveredLight_add_Delegate(AddressOf discoveredLight_add), New Object() {item})
        Else
            discoveredLightsLBX.Items.Add(item)
        End If
    End Sub

    Private Async Sub Core_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mc = New Morse

        client = Await LifxNet.LifxClient.CreateAsync()
        client.StartDeviceDiscovery()
    End Sub

    Private Sub lightZeroBTN_Click(sender As Object, e As EventArgs) Handles lightZeroBTN.Click
        AddHandler mc.BeginTransmit, AddressOf mc_BeginTransmit
        AddHandler mc.EndTransmit, AddressOf mc_EndTransmit
        AddHandler mc.TransmissionTermination, AddressOf mc_TransmissionTermination

        Console.WriteLine(mc.Convert("Hello") & " will be transmitted.")
        mc.Transmit("Hello")
    End Sub

    Private Sub mc_BeginTransmit()
        client.SetDevicePowerStateAsync(discoveredLightsLBX.Items(discoveredLightsLBX.SelectedIndex).bulb, True)
        Console.WriteLine("Sent power state ON.")
    End Sub

    Private Sub mc_EndTransmit()
        client.SetDevicePowerStateAsync(discoveredLightsLBX.Items(discoveredLightsLBX.SelectedIndex).bulb, False)
        Console.WriteLine("Sent power state OFF.")
    End Sub

    Private Sub mc_TransmissionTermination()
        RemoveHandler mc.BeginTransmit, AddressOf mc_BeginTransmit
        RemoveHandler mc.EndTransmit, AddressOf mc_EndTransmit

        Console.WriteLine("Transmission finished.")
    End Sub

    Private Sub lightZeroOnRBTN_CheckedChanged(sender As Object, e As EventArgs) Handles lightZeroOnRBTN.CheckedChanged
        client.SetDevicePowerStateAsync(discoveredLightsLBX.Items(discoveredLightsLBX.SelectedIndex).bulb, True)
    End Sub

    Private Sub lightZeroOffRBTN_CheckedChanged(sender As Object, e As EventArgs) Handles lightZeroOffRBTN.CheckedChanged
        client.SetDevicePowerStateAsync(discoveredLightsLBX.Items(discoveredLightsLBX.SelectedIndex).bulb, False)
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
End Class
