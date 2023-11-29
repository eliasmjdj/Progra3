Imports System.Data.SqlClient
Imports System.Data
Public Class Form3
    'Juan
    '123ghjK456
    Public conexion As Co_DB = New Co_DB
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Cmbx_Ventanilla.DropDownStyle = ComboBoxStyle.DropDownList
        vis()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Btn_Ejecutar.Enabled = True
        Select Case ComboBox1.SelectedIndex
            Case 0
                LabelResultado.Text = ComboBox1.SelectedItem.ToString
                LabelVentanilla.Visible = True
                Cmbx_Ventanilla.Visible = True
                LabelHora.Visible = True
                TxtHorario.Visible = True
                LabelVuelo.Visible = False
                TxtVuelo.Visible = False
                LabelEscala.Visible = False
                TxtEscala.Visible = False
                LabelDestino.Visible = False
                TxtDestino.Visible = False
            Case 1
                LabelResultado.Text = ComboBox1.SelectedItem.ToString
                LabelVentanilla.Visible = True
                Cmbx_Ventanilla.Visible = True
                LabelHora.Visible = True
                TxtHorario.Visible = True
                LabelVuelo.Visible = True
                TxtVuelo.Visible = True
                LabelEscala.Visible = False
                TxtEscala.Visible = False
                LabelDestino.Visible = False
                TxtDestino.Visible = False
            Case 2
                LabelResultado.Text = ComboBox1.SelectedItem.ToString
                LabelVentanilla.Visible = True
                Cmbx_Ventanilla.Visible = True
                LabelHora.Visible = True
                TxtHorario.Visible = True
                LabelVuelo.Visible = True
                TxtVuelo.Visible = True
                LabelEscala.Visible = False
                TxtEscala.Visible = False
                LabelDestino.Visible = False
                TxtDestino.Visible = False
            Case 3
                LabelResultado.Text = ComboBox1.SelectedItem.ToString
                LabelVentanilla.Visible = False
                Cmbx_Ventanilla.Visible = False
                LabelHora.Visible = False
                TxtHorario.Visible = False
                LabelVuelo.Visible = True
                TxtVuelo.Visible = True
                'CargarDatosVuelo(Integer.Parse(TxtVuelo.Text))
                LabelEscala.Visible = False
                TxtEscala.Visible = False
                LabelDestino.Visible = False
                TxtDestino.Visible = False
            Case 4
                LabelResultado.Text = ComboBox1.SelectedItem.ToString
                LabelVentanilla.Visible = False
                Cmbx_Ventanilla.Visible = False
                LabelHora.Visible = False
                TxtHorario.Visible = False
                LabelVuelo.Visible = False
                TxtVuelo.Visible = False
                LabelDestino.Visible = False
                TxtDestino.Visible = False
                LabelEscala.Visible = True
                TxtEscala.Visible = True


            Case 5
                LabelResultado.Text = ComboBox1.SelectedItem.ToString
                LabelVentanilla.Visible = False
                Cmbx_Ventanilla.Visible = False
                LabelHora.Visible = False
                TxtHorario.Visible = False
                LabelVuelo.Visible = False
                TxtVuelo.Visible = False
                LabelEscala.Visible = False
                TxtEscala.Visible = False
                LabelDestino.Visible = True
                TxtDestino.Visible = True
        End Select
    End Sub

    Public Function CargarDatosVuelo(NumVuelo As Integer) As DataTable

        Try
            Dim consulta As String = "SELECT * FROM ObtenerInfoPasajerosVuelo(@NumeroVuelo)"
            Dim cmd As SqlCommand = New SqlCommand(consulta, conexion.conectar())
            cmd.Parameters.AddWithValue("@NumeroVuelo", NumVuelo)
            cmd.ExecuteNonQuery()
            Dim dataSet As New DataSet()
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dataSet, "Resultados")
            ' Llenar el DataGridView con los datos
            DataGridView1.DataSource = dataSet.Tables("Resultados")
            conexion.cerrar()
        Catch ex As Exception
            MessageBox.Show("Error al extraer los datos" & ex.Message)
        End Try
    End Function
    Public Function CargarDatosEscala(Escala As String) As DataTable

        Try
            Dim consulta As String = "SELECT * FROM ObtenerPasajerosEnEscala(@CiudadEscala)"
            Dim cmd As SqlCommand = New SqlCommand(consulta, conexion.conectar())
            cmd.Parameters.AddWithValue("@CiudadEscala", Escala)
            cmd.ExecuteNonQuery()
            Dim dataSet As New DataSet()
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dataSet, "Resultados")
            ' Llenar el DataGridView con los datos
            DataGridView1.DataSource = dataSet.Tables("Resultados")
            conexion.cerrar()
        Catch ex As Exception
            MessageBox.Show("Error al extraer los datos" & ex.Message)
        End Try
    End Function
    Public Function CargarDatosDestino(Destino As String) As DataTable

        Try
            Dim consulta As String = "SELECT * FROM ObtenerPasajerosEnEscala(@CiudadDestino)"
            Dim cmd As SqlCommand = New SqlCommand(consulta, conexion.conectar())
            cmd.Parameters.AddWithValue("@CiudadDestino", Destino)
            cmd.ExecuteNonQuery()
            Dim dataSet As New DataSet()
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dataSet, "Resultados")
            ' Llenar el DataGridView con los datos
            DataGridView1.DataSource = dataSet.Tables("Resultados")
            conexion.cerrar()
        Catch ex As Exception
            MessageBox.Show("Error al extraer los datos" & ex.Message)
        End Try
    End Function
    Public Function cargarDatosCortes(Ventanilla As Integer, NumVueloP As Integer, Hora As TimeSpan) As DataTable
        Try
            Dim consulta As String = "SELECT * FROM ObtenerCortes(@VentanillaID,@NumeroVuelo,@HoraLimite)"
            Dim cmd As SqlCommand = New SqlCommand(consulta, conexion.conectar())
            cmd.Parameters.AddWithValue("@VentanillaID", Ventanilla)
            cmd.Parameters.AddWithValue("@NumeroVuelo", NumVueloP)
            cmd.Parameters.AddWithValue("@HoraLimite", Hora)
            cmd.ExecuteNonQuery()
            Dim dataSet As New DataSet()
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dataSet, "Resultados")
            ' Llenar el DataGridView con los datos
            DataGridView1.DataSource = dataSet.Tables("Resultados")
            conexion.cerrar()
        Catch ex As Exception
            MessageBox.Show("Error al extraer los datos" & ex.Message)
        End Try
    End Function

    Public Sub vis()
        Btn_Ejecutar.Enabled = False
        Cmbx_Ventanilla.Visible = False
        TxtHorario.Visible = False
        TxtVuelo.Visible = False
        TxtEscala.Visible = False
        TxtDestino.Visible = False
        LabelVentanilla.Visible = False
        LabelVuelo.Visible = False
        LabelHora.Visible = False
        LabelEscala.Visible = False
        LabelDestino.Visible = False
    End Sub

    Private Sub Btn_Ejecutar_Click(sender As Object, e As EventArgs) Handles Btn_Ejecutar.Click

        Dim opcionSeleccionada As String = ComboBox1.SelectedItem.ToString()
        Select Case opcionSeleccionada
            Case "Info Vuelo Y Destino"
                Dim ventanillaID As Integer = Cmbx_Ventanilla.SelectedItem.ToString
                Dim horaLimite As TimeSpan = TimeSpan.Parse(TxtHorario.Text)
                cargarDatosVueloDestino(ventanillaID, horaLimite)

            Case "Recoleccion Monetario"
                ' Obtén los valores de los controles de tu formulario (por ejemplo, ComboBox y TextBox)
                Dim ventanillaID As Integer = Cmbx_Ventanilla.SelectedItem.ToString
                Dim numeroVuelo As Integer = Integer.Parse(TxtVuelo.Text)
                Dim horaLimite As TimeSpan = TimeSpan.Parse(TxtHorario.Text)
                cargarDatosMonetario(ventanillaID, numeroVuelo, horaLimite)

            Case "Corte Vuelo"
                Dim IdVen As Integer = Cmbx_Ventanilla.SelectedItem.ToString()
                Dim numvueloP As Integer = Integer.Parse(TxtVuelo.Text)
                Dim horaSeleccionada As TimeSpan = TimeSpan.Parse(TxtHorario.Text)
                cargarDatosCortes(IdVen, numvueloP, horaSeleccionada)

            Case "Pasajero Vuelo"
                Dim numeroVuelo As Integer = Integer.Parse(TxtVuelo.Text.Trim())
                CargarDatosVuelo(numeroVuelo)

            Case "Pasajero Escala"
                Dim escala As String = TxtEscala.Text
                CargarDatosEscala(escala)

            Case "Total Pasajero Destino"
                Dim ciudadDestino As String = TxtDestino.Text
                CargarDatosDestino(ciudadDestino)

            Case Else
                MessageBox.Show("Error debe Selecionar algo de la lista")
        End Select
    End Sub

    Public Function cargarDatosMonetario(Ventanilla As Integer, NumVueloP As Integer, Hora As TimeSpan) As DataTable

        Try
            ' Configura el comando SQL para ejecutar la función
            Dim consulta As String = "SELECT dbo.ObtenerRecaudacionMonetaria(@VentanillaID, @NumeroVuelo, @HoraLimite) AS Recaudacion"
            Dim cmd As New SqlCommand(consulta, conexion.conectar())
            ' Configura los parámetros para la función
            cmd.Parameters.AddWithValue("@VentanillaID", Ventanilla)
            cmd.Parameters.AddWithValue("@NumeroVuelo", NumVueloP)
            cmd.Parameters.AddWithValue("@HoraLimite", Hora)
            cmd.ExecuteNonQuery()
            ' Ejecuta la consulta y obtiene los resultados
            Dim dataSet As New DataSet()
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dataSet, "Resultados")
            ' Llenar el DataGridView con los datos
            DataGridView1.DataSource = dataSet.Tables("Resultados")
            conexion.cerrar()
        Catch ex As Exception
            ' Maneja cualquier error que pueda ocurrir durante la operación de la base de datos
            MsgBox("Error al obtener la recaudación: " & ex.Message)
        End Try
    End Function

    Public Function cargarDatosVueloDestino(Ventanilla As Integer, Hora As TimeSpan)
        Try
            ' Configura el comando SQL para ejecutar la función
            Dim consulta As String = "SELECT * FROM ObtenerInfoVuelosDestinos(@VentanillaID, @HoraLimite)"
            Dim cmd As New SqlCommand(consulta, conexion.conectar())
            ' Configura los parámetros para la función
            cmd.Parameters.AddWithValue("@VentanillaID", Ventanilla)
            cmd.Parameters.AddWithValue("@HoraLimite", Hora)
            cmd.ExecuteNonQuery()
            ' Ejecuta la consulta y obtiene los resultados
            Dim dataSet As New DataSet()
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dataSet, "Resultados")
            ' Llenar el DataGridView con los datos
            DataGridView1.DataSource = dataSet.Tables("Resultados")
            conexion.cerrar()
        Catch ex As Exception
            ' Maneja cualquier error que pueda ocurrir durante la operación de la base de datos
            MsgBox("Error al obtener la recaudación: " & ex.Message)
        End Try
    End Function
End Class