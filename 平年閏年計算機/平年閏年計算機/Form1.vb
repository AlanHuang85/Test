Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim years As Double
        years = InputBox("請輸入西元年分")
        If years Mod 4 = 0 Or years Mod 400 = 0 Then
            MsgBox("閏年")
        Else
            MsgBox("平年")
        End If
    End Sub
End Class
