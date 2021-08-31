Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Book As Double
        Book = Val(InputBox("你今天買了多少書", "書籍購買調查"))

        If (Book >= 0 And Book <= 5) Then
            MsgBox("打折後總價為" & 480 * Book)
        ElseIf (Book >= 6 And Book <= 10) Then
            MsgBox("打折後總價為" & 480 * Book * 0.9)
        ElseIf (Book >= 11 And Book <= 30) Then
            MsgBox("打折後總價為" & 480 * Book * 0.85)
        ElseIf (Book >= 31 And Book <= 60) Then
            MsgBox("打折後總價為" & 480 * Book * 0.8)
        ElseIf (Book > 50) Then
            MsgBox("打折後總價為" & 480 * Book * 0.7)
        Else
            MsgBox("請輸入正數或歸零")
        End If


    End Sub
End Class
