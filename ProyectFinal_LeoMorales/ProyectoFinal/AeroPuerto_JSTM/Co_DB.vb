Imports System.Data.SqlClient
Imports System.Data
Public Class Co_DB
    Private cn As New SqlConnection("Data source=LEONARDOMORALES; Initial Catalog=AeroPuerto_JSTM;Integrated Security=true")

    Public Function conectar() As SqlConnection
        Try
            cn.Open()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return cn
    End Function

    Public Function cerrar() As SqlConnection
        Try
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return cn
    End Function
End Class
