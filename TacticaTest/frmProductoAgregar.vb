Public Class frmProductoAgregar

    Private negocio As New Negocio.NegocioParametros()

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnProductoAgregar_Click(sender As Object, e As EventArgs) Handles btnProductoAgregar.Click
        If ValidarCampos() Then
            negocio.AltaProducto(txtNombre.Text, fltPrecio.Value, txtCategoria.Text)
            MessageBox.Show("Producto agregado correctamente.")
            Me.Close()
        End If
    End Sub

    Private Function ValidarCampos() As Boolean
        Dim valido As Boolean = True
        ErrorProvider1.Clear()

        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            ErrorProvider1.SetError(txtNombre, "Debe ingresar un nombre.")
            valido = False
            Exit Function
        End If

        If fltPrecio.Value <= 0 Then
            ErrorProvider1.SetError(fltPrecio, "Debe ingresar un precio mayor a cero.")
            valido = False
            Exit Function
        End If

        If String.IsNullOrWhiteSpace(txtCategoria.Text) Then
            ErrorProvider1.SetError(txtCategoria, "Debe ingresar una categoría.")
            valido = False
            Exit Function
        End If

        Return valido
    End Function
End Class