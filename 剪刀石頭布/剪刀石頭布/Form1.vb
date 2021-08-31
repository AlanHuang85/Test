Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim X As Double
        X = InputBox("請輸入數值0-3")
        If X = 1 Then
            MsgBox("剪刀")
        ElseIf X = 2 Then
            MsgBox("石頭")
        ElseIf X = 3 Then
            MsgBox("布")
        End If
    End Sub
End Class
