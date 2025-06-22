Public Class frmClientes
    Private Const PromptClienteliminar As String = "Esta seguro que desea eliminar el cliente ?"
    Private Negocio As New Negocio.NegocioParametros()
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
        Else
            lblID.Text = ""
        End If
    End Sub

    Private Sub DataGridClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridClientes.CellContentClick

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
End Class