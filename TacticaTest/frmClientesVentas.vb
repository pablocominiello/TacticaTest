Imports TacticaTest.NegocioTransacciones

Public Class frmClientesVentas
    Private negocio As New NegocioParametros.Parametros()
    Private IDCliente As Integer
    Private Cliente As String
    Private IDVenta As Integer

    Private Const colProductoID As Integer = 0
    Private Const colNombre As Integer = 1
    Private Const colPrecio As Integer = 2
    Private Const colCantidad As Integer = 3
    Private Const colTotal As Integer = 4


    Public Sub IdClienteSet(intIDCliente As Integer)
        IDCliente = intIDCliente
    End Sub
    Public Sub ClienteSet(intCliente As String)
        Cliente = intCliente
    End Sub
    Public Sub IdVentaSet(intIDVenta As Integer)
        IDVenta = intIDVenta
    End Sub

    Private Sub frmClientesVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClienteDatosMostrar()
        BuscarProductos()
        VentasItemsBuscar()
    End Sub

    Private Sub ClienteDatosMostrar()
        ' Aquí se mostrarían los datos del cliente en el formulario
        lblIDCliente.Text = IDCliente.ToString()
        txtCliente.Text = Cliente
    End Sub
    Private Sub BuscarProductos()
        Dim nombre As String = txtFiltroNombre.Text.Trim()
        Dim categoria As String = txtFiltroCategoria.Text.Trim()
        Dim precioMin As Decimal? = If(numPrecioMinimo.Value > 0, numPrecioMinimo.Value, Nothing)
        Dim precioMax As Decimal? = If(numPrecioMaximo.Value > 0, numPrecioMaximo.Value, Nothing)

        dataGridProductos.DataSource = negocio.ListarProductosFiltrando(nombre, precioMin, precioMax, categoria)
        dataGridProductos.Columns("Precio").DefaultCellStyle.Format = "C2" ' Formato de moneda
        dataGridProductos.Columns("Precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub ProductosSeleccionadosAgregar()
        ' Aquí se agregarían los productos seleccionados a la venta
        Dim selectedRows = dataGridProductos.SelectedRows
        If selectedRows.Count > 0 Then
            For Each row As DataGridViewRow In selectedRows
                Dim productoId As Integer = Convert.ToInt32(row.Cells("ID").Value)
                Dim productoNombre As String = row.Cells("Nombre").Value.ToString()
                Dim productoPrecio As Decimal = Convert.ToDecimal(row.Cells("Precio").Value)

                ProductoAgregar(productoId, productoNombre, productoPrecio)
                ' Aquí se podría agregar el producto a una lista de venta o realizar alguna acción
                'MessageBox.Show($"Producto agregado: {productoNombre} - Precio: {productoPrecio}", "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Next
        Else
            MessageBox.Show("Por favor, seleccione al menos un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub ProductoAgregar(productoId As Integer, productoNombre As String, productoPrecio As Decimal)
        ' Validar que el producto no exista ya en la grilla
        For Each row As DataGridViewRow In dataGridVentasItems.Rows
            If Not row.IsNewRow AndAlso Convert.ToInt32(row.Cells("ID").Value) = productoId Then
                'MessageBox.Show("El producto ya fue agregado a la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Next
        dataGridVentasItems.Rows.Add(productoId, productoNombre, productoPrecio, 0)
    End Sub

    Private Sub btnProductosAgregar_Click(sender As Object, e As EventArgs) Handles btnProductosAgregar.Click
        ProductosSeleccionadosAgregar()
    End Sub

    Private Sub dataGridVentasItems_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridVentasItems.CellEndEdit
        If e.ColumnIndex = colCantidad Then
            Dim cantidad As Integer
            If Integer.TryParse(dataGridVentasItems.Rows(e.RowIndex).Cells(colCantidad).Value.ToString(), cantidad) AndAlso cantidad >= 0 Then
                Dim precio As Decimal = Convert.ToDecimal(dataGridVentasItems.Rows(e.RowIndex).Cells(colPrecio).Value)
                dataGridVentasItems.Rows(e.RowIndex).Cells(colTotal).Value = cantidad * precio
            Else
                MessageBox.Show("Por favor, ingrese una cantidad válida (entero mayor o igual a 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dataGridVentasItems.Rows(e.RowIndex).Cells(colCantidad).Value = 1 ' Restablecer a 1 si la entrada es inválida
                Dim precio As Decimal = Convert.ToDecimal(dataGridVentasItems.Rows(e.RowIndex).Cells(colPrecio).Value)
                dataGridVentasItems.Rows(e.RowIndex).Cells(colTotal).Value = 1 * precio
            End If
            SumarTotalVenta()
        End If
    End Sub

    Private Sub SumarTotalVenta()
        Dim suma As Decimal = 0
        For Each row As DataGridViewRow In dataGridVentasItems.Rows
            If Not row.IsNewRow AndAlso row.Cells(colTotal).Value IsNot Nothing Then
                Dim valor As Decimal
                If Decimal.TryParse(row.Cells(colTotal).Value.ToString(), valor) Then
                    suma += valor
                End If
            End If
        Next
        lblTotalVenta.Text = suma.ToString("C2") ' Formato moneda
    End Sub

    Private Sub btnVentaIngresar_Click(sender As Object, e As EventArgs) Handles btnVentaIngresar.Click
        ' Validar que la grilla tenga registros
        If dataGridVentasItems.Rows.Count = 0 Then
            MessageBox.Show("Debe agregar al menos un ítem a la venta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validar que todas las filas tengan Cantidad > 0
        For Each row As DataGridViewRow In dataGridVentasItems.Rows
            ' Ignorar la fila nueva para ingreso rápido si está habilitada
            If Not row.IsNewRow Then
                Dim cantidadObj = row.Cells("Cantidad").Value
                Dim cantidad As Integer
                If cantidadObj Is Nothing OrElse Not Integer.TryParse(cantidadObj.ToString(), cantidad) OrElse cantidad <= 0 Then
                    MessageBox.Show("Todas las filas deben tener una cantidad mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End If
        Next

        ' Crear la lista de ítems
        Dim items As New List(Of VentasItem.VentaItem)
        For Each row As DataGridViewRow In dataGridVentasItems.Rows
            If Not row.IsNewRow Then
                items.Add(New VentasItem.VentaItem With {
                    .IDProducto = Convert.ToInt32(row.Cells(colProductoID).Value),
                    .PrecioUnitario = Convert.ToDecimal(row.Cells(colPrecio).Value),
                    .Cantidad = Convert.ToInt32(row.Cells(colCantidad).Value),
                    .PrecioTotal = Convert.ToDecimal(row.Cells(colTotal).Value)
                })
            End If
        Next

        ' Grabar la venta
        Dim ventasDatos As New NegocioTransacciones.Transacciones
        Dim idVenta As Integer = ventasDatos.GrabarVenta(
            Convert.ToInt32(lblIDCliente.Text),
            Convert.ToDecimal(lblTotalVenta.Text.Replace("$", "")),  ' Quita el símbolo si es necesario
            items
        )

        MessageBox.Show("Venta grabada correctamente. ID Venta: " & idVenta)

        Me.Close()
    End Sub

    Private Sub VentasItemsBuscar()
        Dim Transacciones As New NegocioTransacciones.Transacciones()

        dataGridVentasItems.DataSource = Nothing
        dataGridVentasItems.Columns.Clear()
        dataGridVentasItems.Columns.Add("ID", "ID")
        dataGridVentasItems.Columns.Add("Nombre", "Nombre")
        dataGridVentasItems.Columns.Add("Precio", "Precio")
        dataGridVentasItems.Columns.Add("Cantidad", "Cantidad")
        dataGridVentasItems.Columns.Add("Total", "Total")

        If IDVenta > 0 Then
            Dim VentasActuales As DataTable = Transacciones.VentasConsultarItems(IDVenta)
            For Each row As DataRow In VentasActuales.Rows
                dataGridVentasItems.Rows.Add(
                    row("ID"),
                    row("Nombre"),
                    row("Precio"),
                    row("Cantidad"),
                    row("Total")
                )
            Next
            lblVentaID.Text = IDVenta.ToString()
            btnVentaIngresar.Visible = False
            btnVentaModificar.Visible = True
        Else
            btnVentaIngresar.Visible = True
            btnVentaModificar.Visible = False
            lblVentaID.Text = "0"
        End If

        dataGridVentasItems.Columns("Precio").DefaultCellStyle.Format = "C2" ' Formato de moneda
        dataGridVentasItems.Columns("Total").DefaultCellStyle.Format = "C2" ' Formato de moneda
        dataGridVentasItems.Columns("Precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dataGridVentasItems.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        ' Hacer las columnas ID y Nombre solo lectura
        dataGridVentasItems.Columns("ID").ReadOnly = True
        dataGridVentasItems.Columns("Nombre").ReadOnly = True
        dataGridVentasItems.Columns("Precio").ReadOnly = True

        ' Fondo amarillo para la columna Cantidad
        dataGridVentasItems.Columns("Cantidad").DefaultCellStyle.BackColor = Color.Yellow

        SumarTotalVenta()
    End Sub

    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        If dataGridVentasItems.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        For Each row As DataGridViewRow In dataGridVentasItems.SelectedRows
            If Not row.IsNewRow Then
                dataGridVentasItems.Rows.Remove(row)
            End If
        Next

        SumarTotalVenta()

    End Sub

    Private Sub btnVentaModificar_Click(sender As Object, e As EventArgs) Handles btnVentaModificar.Click
        ' Validar que la grilla tenga registros
        If dataGridVentasItems.Rows.Count = 0 Then
            MessageBox.Show("Debe agregar al menos un ítem a la venta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validar que todas las filas tengan Cantidad > 0
        For Each row As DataGridViewRow In dataGridVentasItems.Rows
            ' Ignorar la fila nueva para ingreso rápido si está habilitada
            If Not row.IsNewRow Then
                Dim cantidadObj = row.Cells("Cantidad").Value
                Dim cantidad As Integer
                If cantidadObj Is Nothing OrElse Not Integer.TryParse(cantidadObj.ToString(), cantidad) OrElse cantidad <= 0 Then
                    MessageBox.Show("Todas las filas deben tener una cantidad mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End If
        Next

        ' Crear la lista de ítems
        Dim items As New List(Of VentasItem.VentaItem)
        For Each row As DataGridViewRow In dataGridVentasItems.Rows
            If Not row.IsNewRow Then
                items.Add(New VentasItem.VentaItem With {
                    .IDProducto = Convert.ToInt32(row.Cells(colProductoID).Value),
                    .PrecioUnitario = Convert.ToDecimal(row.Cells(colPrecio).Value),
                    .Cantidad = Convert.ToInt32(row.Cells(colCantidad).Value),
                    .PrecioTotal = Convert.ToDecimal(row.Cells(colTotal).Value)
                })
            End If
        Next

        ' Grabar la venta
        Dim ventasDatos As New NegocioTransacciones.Transacciones
        Dim idVenta As Integer = ventasDatos.ModificarVenta(CInt(lblVentaID.Text),
            Convert.ToInt32(lblIDCliente.Text),
            Convert.ToDecimal(lblTotalVenta.Text.Replace("$", "")),  ' Quita el símbolo si es necesario
            items
        )

        MessageBox.Show("Venta modificada correctamente. ID Venta: " & lblVentaID.Text)

        Me.Close()

    End Sub

End Class

