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

    Public Function VentasConsultarCliente(idCliente As Integer) As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT ID, Fecha, Total FROM ventas WHERE IDCliente = @IDCliente", conn)
            cmd.Parameters.AddWithValue("@IDCliente", idCliente)
            dt.Load(cmd.ExecuteReader())
        End Using
        Return dt
    End Function

    Public Function VentasConsultarItems(idVenta As Integer) As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT ID = IDProducto, Nombre, Precio = PrecioUnitario, Cantidad, Total = PrecioTotal FROM ventasitems inner join productos p on p.id = IDProducto WHERE IDVenta = @IDVenta Order by IDProducto", conn)
            cmd.Parameters.AddWithValue("@IDVenta", idVenta)
            dt.Load(cmd.ExecuteReader())
        End Using
        Return dt
    End Function

    Public Function VentasEliminar(idVenta As Integer) As Integer

        Using conn1 As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("DELETE FROM ventasitems WHERE IDVenta = @id", conn1)
            cmd.Parameters.AddWithValue("@id", idVenta)
            conn1.Open()
            cmd.ExecuteNonQuery()
        End Using

        Using conn2 As New SqlConnection(connectionString)
            Dim cmd2 As New SqlCommand("DELETE FROM ventas WHERE id = @id", conn2)
            cmd2.Parameters.AddWithValue("@id", idVenta)
            conn2.Open()
            Return cmd2.ExecuteNonQuery()
        End Using
    End Function

    Public Function VentaModificar(idVenta As Integer, idCliente As Integer, total As Decimal, items As List(Of VentaItem)) As Integer


        Using connheader As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("UPDATE ventas SET total = @total,Fecha = GETDATE() WHERE id = @id", connheader)
            cmd.Parameters.AddWithValue("@id", idVenta)
            cmd.Parameters.AddWithValue("@total", total)
            connheader.Open()
            cmd.ExecuteNonQuery()
        End Using


        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim trans As SqlTransaction = conn.BeginTransaction()

            Try
                ' Insertar la venta y obtener el ID generado
                'Dim cmdVenta As New SqlCommand("INSERT INTO ventas (IDCliente, Fecha, Total) VALUES (@IDCliente, GETDATE(), @Total); SELECT SCOPE_IDENTITY();", conn, trans)
                'cmdVenta.Parameters.AddWithValue("@IDCliente", idCliente)
                'cmdVenta.Parameters.AddWithValue("@Total", total)
                'idVenta = Convert.ToInt32(cmdVenta.ExecuteScalar())

                Dim conn2 As New SqlConnection(connectionString)
                Dim cmdEliminarItems As New SqlCommand("DELETE ventasitems WHERE IDVenta = @idVenta", conn2)

                cmdEliminarItems.Parameters.AddWithValue("@idVenta", idVenta)
                conn2.Open()
                cmdEliminarItems.ExecuteNonQuery()


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
