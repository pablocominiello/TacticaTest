Namespace Negocio
    Public Class ClienteNegocio
        Private datos As New Productos()

        Public Function ListarProductos() As DataTable
            Return datos.ObtenerProductos()
        End Function
    End Class
End Namespace