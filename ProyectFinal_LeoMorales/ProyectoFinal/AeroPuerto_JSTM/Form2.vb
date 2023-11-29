Imports System.Data.SqlClient
Imports System.Data
Public Class Form2
    Public conexion As Co_DB = New Co_DB
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.Login
        PictureBox2.Image = My.Resources.Users_Pass
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim login As String = "LoginAdminist"
        Try
            If TxtUsuario.Text = "" Or TextPass.Text = "" Then
                MessageBox.Show("Llenar los campos correspondiente")
            Else
                Dim cmd As SqlCommand = New SqlCommand(login, conexion.conectar())
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("NombreUsuario", TxtUsuario.Text)
                cmd.Parameters.AddWithValue("Contraseña", TextPass.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Ingreso exitoso")
                Form3.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show("Datos incorrectos o -> " & ex.Message)
        End Try
    End Sub
End Class