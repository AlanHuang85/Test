Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim student(,) = {{93001, "john", 89, 90, 77},
                          {93002, "mary", 76, 95, 97},
                          {93003, "tony", 88, 71, 68}}
        Dim total_score(2), avg_score(2)
        For i As Integer = 0 To 2
            For j As Integer = 2 To 4
                total_score(i) += student(i, j)
            Next
        Next
        For i As Integer = 0 To 2
            avg_score(i) = Math.Round(total_score(i) / 3, 2)
        Next
        TextBox1.Text &= "學號 姓名 數學 國文 英文 總分 平均" & vbCrLf
        For i As Integer = 0 To 2
            For j As Integer = 0 To 4
                TextBox1.Text &= student(i, j) & " "
            Next
            TextBox1.Text &= total_score(i) & " "
            TextBox1.Text &= avg_score(i) & vbCrLf
        Next
    End Sub
End Class
