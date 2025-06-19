Public Class frmClientesAgregar
    Private negocio As New Negocio.NegocioParametros()

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        If ValidarCampos() Then
            negocio.AltaCliente(txtCliente.Text, txtCorreo.Text, txtTelefono.Text)
            MessageBox.Show("Producto agregado correctamente.")
            Me.Close()
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

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
End Class