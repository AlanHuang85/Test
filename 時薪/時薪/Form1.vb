Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hr As Double
        hr = Val(InputBox("工作時數", "薪水派發"))
        If (hr > 50) Then
            MsgBox("薪資" & 100 * 50 + 100 * (hr - 50) * 1.1)
        ElseIf (hr < 50) Then
            MsgBox("薪資" & 100 * hr - 300)
        ElseIf (hr = 50) Then
            MsgBox("薪資" & 100 * hr)
        End If
    End Sub
End Class
