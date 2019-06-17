Public Class LifxBulb
    Public Property bulb As LifxNet.LightBulb

    Public Overrides Function ToString() As String
        Return Me.bulb.HostName
    End Function
End Class
