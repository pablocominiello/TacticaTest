Namespace Negocio
    Public Class ClienteNegocio
        Private datos As New ClienteDatos()

        Public Function ListarClientes() As DataTable
            Return datos.ObtenerClientes()
        End Function
    End Class
End Namespace