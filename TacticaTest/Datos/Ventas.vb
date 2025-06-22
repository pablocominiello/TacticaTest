Imports System.Configuration
Imports System.Data.SqlClient
Imports TacticaTest.VentasItem

Friend Class Ventas
    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString

    Public Function GrabarVenta(idCliente As Integer, total As Decimal, items As List(Of VentaItem)) As Integer
        Dim idVenta As Integer = 0

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim trans As SqlTransaction = conn.BeginTransaction()

            Try
                ' Insertar la venta y obtener el ID generado
                Dim cmdVenta As New SqlCommand("INSERT INTO ventas (IDCliente, Fecha, Total) VALUES (@IDCliente, GETDATE(), @Total); SELECT SCOPE_IDENTITY();", conn, trans)
                cmdVenta.Parameters.AddWithValue("@IDCliente", idCliente)
                cmdVenta.Parameters.AddWithValue("@Total", total)
                idVenta = Convert.ToInt32(cmdVenta.ExecuteScalar())

                ' Insertar los ítems
                For Each item In items
                    Dim cmdItem As New SqlCommand("INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)", conn, trans)
                    cmdItem.Parameters.AddWithValue("@IDVenta", idVenta)
                    cmdItem.Parameters.AddWithValue("@IDProducto", item.IDProducto)
                    cmdItem.Parameters.AddWithValue("@PrecioUnitario", item.PrecioUnitario)
                    cmdItem.Parameters.AddWithValue("@Cantidad", item.Cantidad)
                    cmdItem.Parameters.AddWithValue("@PrecioTotal", item.PrecioTotal)
                    cmdItem.ExecuteNonQuery()
                Next

                trans.Commit()
            Catch ex As Exception
                trans.Rollback()
                Throw
            End Try
        End Using

        Return idVenta
    End Function
End Class
