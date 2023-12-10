Imports System.Data.SqlClient
Imports System.Data
Public Class Ventanilla
    Public conexion As Co_DB = New Co_DB
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.Boleto
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Btn_Registro_Click(sender As Object, e As EventArgs) Handles Btn_Registro.Click
        Dim ventanilla As Integer = ComboBox1.SelectedItem.ToString
        Dim horaApertura As TimeSpan = TimeSpan.Parse(TxtHorario.Text)
        Dim num As Integer = Integer.Parse(TxtNumVuelo.Text)
        Try
            Dim insert As String = "RegistrarVentanilla"
            Dim cmd As SqlCommand = New SqlCommand(insert, conexion.conectar())
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IDVentanilla", ventanilla)
            cmd.Parameters.AddWithValue("@EmpleadoNombre", TxtNombre.Text)
            cmd.Parameters.AddWithValue("@NumeroCedula", TxtDNI.Text)
            cmd.Parameters.AddWithValue("@HoraApertura", horaApertura)
            cmd.Parameters.AddWithValue("@LineaAerea", TxtLinea.Text)
            cmd.Parameters.AddWithValue("@DestinoVuelo", TxtDestino.Text)
            cmd.Parameters.AddWithValue("@NumeroVuelo", num)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Registro Exitoso")
            Visibletext()
        Catch ex As Exception
            MessageBox.Show("Error al registrar" & ex.Message)
        End Try
    End Sub
    Public Sub Visibletext()
        TxtDNI.Enabled = False
        TxtDestino.Enabled = False
        TxtHorario.Enabled = False
        TxtLinea.Enabled = False
        TxtNombre.Enabled = False
        TxtNumVuelo.Enabled = False
        ComboBox1.Enabled = False
    End Sub

    Private Sub TxtHorario_TextChanged(sender As Object, e As EventArgs) Handles TxtHorario.TextChanged
        Dim numero As Integer

        If Integer.TryParse(ComboBox1.Text, numero) Then
            Console.WriteLine("La entrada es un número.")
        Else
            Console.WriteLine("La entrada no es un número.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class