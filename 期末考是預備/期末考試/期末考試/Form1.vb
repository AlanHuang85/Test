﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer
        x = (Rnd() * 40) + 60
        y = (Rnd() * 40) + 60
        z = (Rnd() * 40) + 60
        TextBox1.Text = x
        TextBox2.Text = y
        TextBox3.Text = z
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox4.Text = 65
        TextBox5.Text = 69
        TextBox6.Text = 84
        TextBox7.Text = 77
        TextBox8.Text = 67
        TextBox9.Text = 89
        TextBox10.Text = 77
        TextBox11.Text = 67
        TextBox12.Text = 99
        TextBox13.Text = 98
        TextBox14.Text = 88
        TextBox15.Text = 88
        TextBox16.Text = 100
        TextBox17.Text = 88
        TextBox18.Text = 65
        TextBox19.Text = 63
        TextBox20.Text = 89
        TextBox21.Text = 64
        TextBox22.Text = 84
        TextBox23.Text = 96
        TextBox24.Text = 64
        TextBox25.Text = 100
        TextBox26.Text = 76
        TextBox27.Text = 88
        TextBox28.Text = 73
        TextBox29.Text = 100
        TextBox30.Text = 95
        TextBox.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text)
        TextBox31.Text = Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text)
        TextBox32.Text = Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox9.Text)
        TextBox33.Text = Val(TextBox10.Text) + Val(TextBox11.Text) + Val(TextBox12.Text)
        TextBox34.Text = Val(TextBox13.Text) + Val(TextBox14.Text) + Val(TextBox15.Text)
        TextBox35.Text = Val(TextBox16.Text) + Val(TextBox17.Text) + Val(TextBox18.Text)
        TextBox36.Text = Val(TextBox19.Text) + Val(TextBox20.Text) + Val(TextBox21.Text)
        TextBox37.Text = Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text)
        TextBox38.Text = Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text)
        TextBox39.Text = Val(TextBox28.Text) + Val(TextBox29.Text) + Val(TextBox30.Text)




    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim A() As Integer = {Val(TextBox31.Text), Val(TextBox32.Text), Val(TextBox33.Text), Val(TextBox34.Text), Val(TextBox35.Text), Val(TextBox36.Text), Val(TextBox37.Text), Val(TextBox38.Text), Val(TextBox39.Text), Val(TextBox.Text)}
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
            TextBox41.Text &= A(i) & " < "
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim A() As Integer = {Val(TextBox31.Text), Val(TextBox32.Text), Val(TextBox33.Text), Val(TextBox34.Text), Val(TextBox35.Text), Val(TextBox36.Text), Val(TextBox37.Text), Val(TextBox38.Text), Val(TextBox39.Text), Val(TextBox.Text)}
        For i As Integer = 8 To 0 Step -1
            For j As Integer = 0 To i
                If A(j) > A(j + 1) Then
                    Dim temp As Integer = A(j)
                    A(j) = A(j + 1)
                    A(j + 1) = temp
                End If
            Next
        Next
        For i As Integer = 0 To 9
            TextBox40.Text &= A(i) & " < "
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim A() As Integer = {Val(TextBox31.Text), Val(TextBox32.Text), Val(TextBox33.Text), Val(TextBox34.Text), Val(TextBox35.Text), Val(TextBox36.Text), Val(TextBox37.Text), Val(TextBox38.Text), Val(TextBox39.Text), Val(TextBox.Text)}
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
            TextBox42.Text = A(Val(TextBox43.Text))
        Next
    End Sub



End Class
