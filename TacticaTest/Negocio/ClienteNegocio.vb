Namespace Negocio
    Public Class ClienteNegocio
        Private datos As New ClienteProductos()

        Public Function ListarProductos() As DataTable
            Return datos.ObtenerProductos()
        End Function
    End Class
End Namespace