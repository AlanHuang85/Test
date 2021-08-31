Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim score(5) As Integer
        score(0) = 90
        score(1) = 91
        score(2) = 92
        score(3) = 93
        score(4) = 94
        score(5) = 95
        For i As Integer = 0 To 5
            Debug.Print(score(i))
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
