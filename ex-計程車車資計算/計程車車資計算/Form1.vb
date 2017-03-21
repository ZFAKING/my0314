Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dblX As Double
        Dim intM As Integer
        dblX = Val(TextBox1.Text)
        intM = (Int((dblX - 1.25) / 0.25)) * 5 + 70
        TextBox2.Text = intM
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
