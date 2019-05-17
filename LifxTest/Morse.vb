Public Class Morse
    Public Event BeginTransmit()
    Public Event EndTransmit()

    Public Event TransmissionCreation()
    Public Event TransmissionTermination()

    Private Const DotLength As Integer = 200
    Private Const DashLength As Integer = 3 * DotLength
    Private Const WordLength As Integer = 7 * DotLength

    Public Sub Transmit(ByVal Output As String)
        RaiseEvent TransmissionCreation()

        For i As Integer = 0 To Output.Length - 1
            If String.IsNullOrWhiteSpace(Output(i)) Then
                RaiseEvent BeginTransmit()
                Threading.Thread.Sleep(WordLength)
                RaiseEvent EndTransmit()
            Else
                Dim CharacterUpper As String = Output(i).ToString().ToUpper
                Dim MorseComparable As String = CStr(GetType(Alphabet).GetField(CharacterUpper).GetValue(Nothing))
                For j As Integer = 0 To MorseComparable.Length - 1
                    Dim MorseCharacter As String = MorseComparable(j).ToString()

                    RaiseEvent BeginTransmit()
                    If MorseCharacter = "." Then
                        Threading.Thread.Sleep(DotLength)
                    Else
                        Threading.Thread.Sleep(DashLength)
                    End If
                    RaiseEvent EndTransmit()

                    Threading.Thread.Sleep(DotLength)
                Next
            End If
        Next

        RaiseEvent TransmissionTermination()
    End Sub

    Public Function Convert(ByVal Output As String) As String
        Dim MorseSB As New Text.StringBuilder()

        For i As Integer = 0 To Output.Length - 1
            If String.IsNullOrWhiteSpace(Output(i)) Then
                MorseSB.Append("  ")
            Else
                Dim CharacterUpper As String = Output(i).ToString().ToUpper
                Dim MorseComparable As String = CStr(GetType(Alphabet).GetField(CharacterUpper).GetValue(Nothing))
                MorseSB.Append(MorseComparable)
            End If
        Next

        Return MorseSB.ToString()
    End Function

    Public Class Alphabet
        Public Const A As String = ".-"
        Public Const B As String = "-..."
        Public Const C As String = "-.-."
        Public Const D As String = "-.."
        Public Const E As String = "."
        Public Const F As String = "..-."
        Public Const G As String = "--."
        Public Const H As String = "...."
        Public Const I As String = ".."
        Public Const J As String = ".----"
        Public Const K As String = "-.-"
        Public Const L As String = ".-.."
        Public Const M As String = "--"
        Public Const N As String = "-."
        Public Const O As String = "---"
        Public Const P As String = ".--."
        Public Const Q As String = "--.-"
        Public Const R As String = ".-."
        Public Const S As String = "..."
        Public Const T As String = "-"
        Public Const U As String = "..-"
        Public Const V As String = "...-"
        Public Const W As String = ".--"
        Public Const X As String = "-..-"
        Public Const Y As String = "-.--"
        Public Const Z As String = "--.."

        Public Const _0 As String = "-----"
        Public Const _1 As String = ".----"
        Public Const _2 As String = "..---"
        Public Const _3 As String = "...--"
        Public Const _4 As String = "....-"
        Public Const _5 As String = "....."
        Public Const _6 As String = "-...."
        Public Const _7 As String = "--..."
        Public Const _8 As String = "---.."
        Public Const _9 As String = "----."
    End Class
End Class
