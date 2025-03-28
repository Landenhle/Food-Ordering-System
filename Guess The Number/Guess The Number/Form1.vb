Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim correct As Integer = 8
        If Textbox1.Text = correct Then
            PictureBox1.Image = My.Resources.tick
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        ElseIf TextBox1.Text < correct Then
            PictureBox1.Image = My.Resources.uparrow
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            PictureBox1.Image = My.Resources.downarrow
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
End Class
