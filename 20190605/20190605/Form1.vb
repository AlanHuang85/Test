Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A() As Integer = {45, 23, 34, 55, 15, 67, 37, 89, 44, 28}
        For i As Integer = 0 To 8
            For j As Integer = i + 1 To 9
                If A(i) > A(j) Then
                    Dim temp As Integer = A(i)
                    A(i) = A(j)
                    A(j) = temp
                End If
            Next
        Next
        For i As Integer = 0 To 9
            txtOutput.Text &= A(i) & " "
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
