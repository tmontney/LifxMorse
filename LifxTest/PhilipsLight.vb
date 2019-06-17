Public Class PhilipsLight
    Public Property LightData As Dictionary(Of String, Object)
    Public ReadOnly Property Username As String
    Public ReadOnly Property Index As String
    Public ReadOnly Property BridgeIP As String

    Public Sub New(ByVal Username As String, ByVal Index As String, ByVal BridgeIP As String)
        _Username = Username
        _Index = Index
        _BridgeIP = BridgeIP
    End Sub

    Public Overrides Function ToString() As String
        Return LightData("name").ToString()
    End Function

    Public Sub SetDevicePowerState(ByVal State As Boolean)
        Dim LightURL As String = "https://" + BridgeIP + "/api/" + Username + "/lights/" + Index + "/state"
        Dim Data As New Dictionary(Of String, Object) From {{"on", State}}
        Dim js As New Web.Script.Serialization.JavaScriptSerializer
        Using wc As New Net.WebClient
            Dim Response As String = System.Text.ASCIIEncoding.ASCII.GetString(wc.UploadData(LightURL, "PUT", System.Text.ASCIIEncoding.ASCII.GetBytes(js.Serialize(Data))))
        End Using
    End Sub
End Class
