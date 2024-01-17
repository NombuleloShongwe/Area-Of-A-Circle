Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Double
        Const pi As Double = 3.14
        Dim r As Double

        r = Val(TextBox1.Text)
        A = pi * r ^ 2

        TextBox2.Text = A
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
