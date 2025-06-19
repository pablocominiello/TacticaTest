Imports System.Configuration
Imports System.Data.SqlClient

Public Class Productos
    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString

    Public Function ObtenerProductos() As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT * FROM productos", conn)
            conn.Open()
            dt.Load(cmd.ExecuteReader())
        End Using
        Return dt
    End Function
End Class