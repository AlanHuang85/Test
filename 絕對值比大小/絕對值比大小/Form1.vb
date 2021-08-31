Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Double
        A = InputBox("請輸入A值")
        Dim B As Double
        B = InputBox("請輸入B值")
        If A > B Then
            MsgBox("A較大")
        Else
            MsgBox("B較大")
        End If
        If A < 0 Then
            MsgBox("A=-A")
        End If
        If B < 0 Then
            MsgBox("B=-B")
        End If
    End Sub
End Class
