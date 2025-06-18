Imports System.Data.SqlClient

Public Class ClienteDatos
    Private connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=pruebademo;Integrated Security=True"

    Public Function ObtenerClientes() As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT * FROM productos", conn)
            conn.Open()
            dt.Load(cmd.ExecuteReader())
        End Using
        Return dt
    End Function
End Class