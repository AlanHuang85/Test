Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Double
        A = InputBox("輸入一個值", "判斷成績是否及格")
        If (A >= 0 And A < 60) Then
            MsgBox("成績為不及格")
        ElseIf (A >= 60) Then
            MsgBox("成績為及格")
        End If
    End Sub
End Class
