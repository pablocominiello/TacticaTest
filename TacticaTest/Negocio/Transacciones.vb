Imports TacticaTest.VentasItem

Namespace NegocioTransacciones

    Public Class Transacciones
        Private ventas As New Ventas()
        Public Function GrabarVenta(idCliente As Integer, total As Decimal, items As List(Of VentaItem)) As Integer
            Return ventas.GrabarVenta(idCliente, total, items)
        End Function
        Public Function ConsultarVentasPorCliente(idCliente As Integer) As DataTable
            Return ventas.VentasConsultarCliente(idCliente)
        End Function
        Public Function VentasConsultarItems(idVenta As Integer) As DataTable
            Return ventas.VentasConsultarItems(idVenta)
        End Function

        Public Function EliminarVenta(idVenta As Integer) As Boolean
            Return ventas.VentasEliminar(idVenta)
        End Function
        Public Function ModificarVenta(idVenta As Integer, idCliente As Integer, total As Decimal, items As List(Of VentaItem)) As Boolean
            Return ventas.VentaModificar(idVenta, idCliente, total, items)
        End Function
    End Class
End Namespace