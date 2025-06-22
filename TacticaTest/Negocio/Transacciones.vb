Imports TacticaTest.VentasItem

Namespace NegocioTransacciones

    Public Class Transacciones
        Private ventas As New Ventas()
        Public Function GrabarVenta(idCliente As Integer, total As Decimal, items As List(Of VentaItem)) As Integer
            Return Ventas.GrabarVenta(idCliente, total, items)
        End Function
    End Class
End Namespace