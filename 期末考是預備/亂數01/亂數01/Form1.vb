Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer
        x = (Rnd() * 40) + 60
        y = (Rnd() * 100)
        z = (Rnd() * 100)
        TextBox1.Text = x & vbCrLf
        TextBox2.Text = y & vbCrLf
        TextBox3.Text = z

    End Sub

End Class
