Imports System.Configuration
Imports System.Data.SqlClient

Friend Class Clientes
    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString
    ' Metodo para obtener los clientes
    Public Function ObtenerClientes() As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT * FROM clientes", conn)
            conn.Open()
            dt.Load(cmd.ExecuteReader())
        End Using
        Return dt
    End Function
    ' Método para dar de alta un cliente
    Public Function AltaCliente(cliente As String, correo As String, telefono As String) As Integer
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("INSERT INTO clientes (cliente, correo, telefono) VALUES (@cliente, @correo, @telefono)", conn)
            cmd.Parameters.AddWithValue("@cliente", cliente)
            cmd.Parameters.AddWithValue("@correo", correo)
            cmd.Parameters.AddWithValue("@telefono", telefono)
            conn.Open()
            Return cmd.ExecuteNonQuery()
        End Using
    End Function

    Public Function ModificacionCliente(id As Integer, cliente As String, correo As String, telefono As String) As Integer
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("UPDATE clientes SET cliente = @cliente, correo = @correo, telefono = @telefono WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@cliente", cliente)
            cmd.Parameters.AddWithValue("@correo", correo)
            cmd.Parameters.AddWithValue("@telefono", telefono)
            conn.Open()
            Return cmd.ExecuteNonQuery()
        End Using
    End Function

    Public Function EliminarCliente(id As Integer) As Integer
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("DELETE FROM clientes WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            conn.Open()
            Return cmd.ExecuteNonQuery()
        End Using
    End Function
End Class
