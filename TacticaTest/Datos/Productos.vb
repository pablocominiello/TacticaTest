Imports System.Configuration
Imports System.Data.SqlClient

Friend Class Productos
    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString

    ' Metodo para obtener los productos
    Public Function ObtenerProductos() As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT * FROM productos", conn)
            conn.Open()
            dt.Load(cmd.ExecuteReader())
        End Using
        Return dt
    End Function

    ' Método para dar de alta un producto
    Public Function AltaProducto(nombre As String, precio As Decimal, categoria As String) As Integer
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("INSERT INTO productos (nombre, precio, categoria) VALUES (@nombre, @precio, @categoria)", conn)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@precio", precio)
            cmd.Parameters.AddWithValue("@categoria", categoria)
            conn.Open()
            AltaProducto = cmd.ExecuteNonQuery()
        End Using
    End Function
    Public Function ModificacionProducto(id As Integer, nombre As String, precio As Decimal, categoria As String) As Integer
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("UPDATE productos SET nombre = @nombre, precio = @precio, categoria = @categoria WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@precio", precio)
            cmd.Parameters.AddWithValue("@categoria", categoria)
            conn.Open()
            Return cmd.ExecuteNonQuery()
        End Using
    End Function
    Public Function EliminarProducto(id As Integer) As Integer
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("DELETE FROM productos WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            conn.Open()
            Return cmd.ExecuteNonQuery()
        End Using
    End Function
End Class