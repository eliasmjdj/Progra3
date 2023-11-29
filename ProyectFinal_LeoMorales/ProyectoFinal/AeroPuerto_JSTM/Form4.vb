Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox5.Image = My.Resources.airport
        PictureBox1.Image = My.Resources.Icon4
        PictureBox2.Image = My.Resources.Icon1
        PictureBox3.Image = My.Resources.icon3
        PictureBox4.Image = My.Resources.icon2
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Ventanilla.Visible = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Ventanilla.Visible = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Ventanilla.Visible = True
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Ventanilla.Visible = True
    End Sub
End Class