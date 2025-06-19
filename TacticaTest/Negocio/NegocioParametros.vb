Namespace Negocio
    Public Class NegocioParametros
        Private productos As New Productos()
        Private clientes As New Clientes()

        Public Function ListarProductos() As DataTable
            Return productos.ObtenerProductos()
        End Function

        Public Function AltaProducto(nombre As String, precio As Decimal, categoria As String) As Integer
            Return productos.AltaProducto(nombre, precio, categoria)
        End Function

        Public Function ListarClientes() As DataTable
            Return clientes.ObtenerClientes()
        End Function
        Public Function AltaCliente(nombre As String, email As String, telefono As String) As Integer
            Return clientes.AltaCliente(nombre, email, telefono)
        End Function
        Public Function ModificacionCliente(id As Integer, nombre As String, email As String, telefono As String) As Integer
            Return clientes.ModificacionCliente(id, nombre, email, telefono)
        End Function
    End Class
End Namespace