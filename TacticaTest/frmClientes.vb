Public Class frmClientes
    Private Const PromptClienteliminar As String = "Esta seguro que desea eliminar el cliente ?"
    Private Negocio As New NegocioParametros.Parametros()
    Private Transacciones As New NegocioTransacciones.Transacciones()

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Dim frmClientesAgregar As New frmClientesAgregar()
        frmClientesAgregar.ShowDialog()
        MostrarClientes()

    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarClientes()
    End Sub

    Private Sub MostrarClientes()
        'DataGridClientes.DataSource = Negocio.ListarClientes()
        DataGridClientes.DataSource = Negocio.ListarClientesFiltrado(
            txtClienteFiltrar.Text,
            txtTelefonoFiltrar.Text,
            txtCorreoFiltrar.Text
        )

    End Sub

    Private Sub btnClienteModificar_Click(sender As Object, e As EventArgs) Handles btnClienteModificar.Click
        If ValidarCampos() Then
            Dim id As Integer
            If Integer.TryParse(lblID.Text, id) Then
                Negocio.ModificacionCliente(id, txtCliente.Text, txtCorreo.Text, txtTelefono.Text)
                MessageBox.Show("Cliente modificado correctamente.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                MostrarClientes()
            Else
                MessageBox.Show("ID no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub DataGridClientes_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridClientes.SelectionChanged
        If DataGridClientes.CurrentRow IsNot Nothing AndAlso DataGridClientes.CurrentRow.Index >= 0 Then
            Dim valorID As Object = DataGridClientes.CurrentRow.Cells(0).Value
            Dim valorCliente As Object = DataGridClientes.CurrentRow.Cells(1).Value
            Dim valorTelefono As Object = DataGridClientes.CurrentRow.Cells(2).Value
            Dim valorCorreo As Object = DataGridClientes.CurrentRow.Cells(3).Value

            lblID.Text = If(valorID IsNot Nothing, valorID.ToString(), "")
            txtCliente.Text = If(valorCliente IsNot Nothing, valorCliente.ToString(), "")
            txtCorreo.Text = If(valorCorreo IsNot Nothing, valorCorreo.ToString(), "")
            txtTelefono.Text = If(valorTelefono IsNot Nothing, valorTelefono.ToString(), "")
            VentasClienteConsultar(valorID)
        Else
            lblID.Text = ""
        End If

    End Sub

    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(txtCliente.Text) Then
            MessageBox.Show("El nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtCorreo.Text) OrElse Not txtCorreo.Text.Contains("@") Then
            MessageBox.Show("El email es obligatorio y debe ser válido(@).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtTelefono.Text) Then
            MessageBox.Show("El teléfono es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub btnClienteEliminar_Click(sender As Object, e As EventArgs) Handles btnClienteEliminar.Click
        Dim msgBoxResult = MsgBox(PromptClienteliminar, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If msgBoxResult = vbOK Then
            If Not String.IsNullOrWhiteSpace(lblID.Text) Then
                Dim id As Integer
                If Integer.TryParse(lblID.Text, id) Then
                    Negocio.EliminarCliente(id)
                    MessageBox.Show("Cliente eliminado correctamente.", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    MostrarClientes()
                Else
                    MessageBox.Show("ID no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Seleccione un cliente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        MostrarClientes()
    End Sub


    Private Sub VentasClienteConsultar(intIdClient As Integer)

        If intIdClient > 0 Then
            DataGridVentas.DataSource = Transacciones.ConsultarVentasPorCliente(intIdClient)
            DataGridVentas.Columns("Total").DefaultCellStyle.Format = "C2" ' Formato de moneda
            DataGridVentas.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Else
            MessageBox.Show("Seleccione un cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnVentaEliminar_Click(sender As Object, e As EventArgs) Handles btnVentaEliminar.Click
        If DataGridVentas.CurrentRow IsNot Nothing AndAlso DataGridVentas.CurrentRow.Index >= 0 Then
            Dim idVenta As Integer
            Dim valorID As Object = DataGridVentas.CurrentRow.Cells(0).Value
            If valorID IsNot Nothing AndAlso Integer.TryParse(valorID.ToString(), idVenta) Then
                Dim resultado = MessageBox.Show("¿Está seguro que desea eliminar la venta seleccionada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If resultado = DialogResult.Yes Then
                    Dim transacciones As New NegocioTransacciones.Transacciones()
                    If transacciones.EliminarVenta(idVenta) Then
                        MessageBox.Show("Venta eliminada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        VentasClienteConsultar(CType(lblID.Text, Integer))
                    Else
                        MessageBox.Show("No se pudo eliminar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("No se pudo obtener el ID de la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Seleccione una venta para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnClienteVenta_Click(sender As Object, e As EventArgs) Handles btnClienteVenta.Click
        With frmClientesVentas
            .IdClienteSet(Integer.Parse(lblID.Text))
            .ClienteSet(txtCliente.Text)
            .IdVentaSet(0)
            .ShowDialog()
            VentasClienteConsultar(Integer.Parse(lblID.Text))
        End With

    End Sub

    Private Sub btnVentaModificar_Click(sender As Object, e As EventArgs) Handles btnVentaModificar.Click

        If DataGridVentas.CurrentRow IsNot Nothing AndAlso DataGridVentas.CurrentRow.Index >= 0 Then
            Dim IDVenta As Object = DataGridVentas.CurrentRow.Cells(0).Value
            With frmClientesVentas
                .IdClienteSet(Integer.Parse(lblID.Text))
                .ClienteSet(txtCliente.Text)
                .IdVentaSet(IDVenta)
                .ShowDialog()
                VentasClienteConsultar(Integer.Parse(lblID.Text))
            End With
        Else
            MessageBox.Show("Seleccione una venta para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub LimpiarControles()
        For Each ctrl As Control In Me.Controls
            LimpiarControl(ctrl)
        Next
    End Sub

    Private Sub LimpiarControl(ctrl As Control)
        If TypeOf ctrl Is TextBox Then
            CType(ctrl, TextBox).Clear()
        ElseIf TypeOf ctrl Is ComboBox Then
            CType(ctrl, ComboBox).SelectedIndex = -1
        ElseIf TypeOf ctrl Is DataGridView Then
            CType(ctrl, DataGridView).Rows.Clear()
        ElseIf TypeOf ctrl Is CheckBox Then
            CType(ctrl, CheckBox).Checked = False
        ElseIf TypeOf ctrl Is RadioButton Then
            CType(ctrl, RadioButton).Checked = False
        ElseIf ctrl.HasChildren Then
            For Each child As Control In ctrl.Controls
                LimpiarControl(child)
            Next
        End If
    End Sub
End Class