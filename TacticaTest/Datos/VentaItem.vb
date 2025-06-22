Namespace VentasItem
    Public Class VentaItem
        Public Property IDProducto As Integer
        Public Property PrecioUnitario As Decimal
        Public Property Cantidad As Integer
        Public Property PrecioTotal As Decimal

        Public Shared Function ObtenerItemsDesdeGrid(dataGridVentasItems As DataGridView, colProductoID As String, colPrecio As String, colCantidad As String, colTotal As String) As List(Of VentaItem)
            Dim items As New List(Of VentaItem)
            For Each row As DataGridViewRow In dataGridVentasItems.Rows
                If Not row.IsNewRow Then
                    items.Add(New VentaItem With {
                        .IDProducto = Convert.ToInt32(row.Cells(colProductoID).Value),
                        .PrecioUnitario = Convert.ToDecimal(row.Cells(colPrecio).Value),
                        .Cantidad = Convert.ToInt32(row.Cells(colCantidad).Value),
                        .PrecioTotal = Convert.ToDecimal(row.Cells(colTotal).Value)
                    })
                End If
            Next
            Return items
        End Function
    End Class
End Namespace