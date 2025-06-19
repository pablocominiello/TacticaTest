Public Class frmProductos
    Private negocio As New Negocio.NegocioParametros()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductosCargar()
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim frmProductoAgregar As New frmProductoAgregar()
        frmProductoAgregar.ShowDialog()
        ProductosCargar()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
    Private Sub ProductosCargar()
        dataGridProductos.DataSource = negocio.ListarProductos()
    End Sub

    Private Sub dataGridProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridProductos.CellContentClick

    End Sub

    Private Sub dataGridProductos_SelectionChanged(sender As Object, e As EventArgs) Handles dataGridProductos.SelectionChanged
        If dataGridProductos.CurrentRow IsNot Nothing AndAlso dataGridProductos.CurrentRow.Index >= 0 Then
            Dim valorID As Object = dataGridProductos.CurrentRow.Cells(0).Value
            Dim valorNombre As Object = dataGridProductos.CurrentRow.Cells(1).Value
            Dim valorPrecio As Object = dataGridProductos.CurrentRow.Cells(2).Value
            Dim valorCategoria As Object = dataGridProductos.CurrentRow.Cells(3).Value
            lblID.Text = If(valorID IsNot Nothing, valorID.ToString(), "")
            txtNombre.Text = If(valorNombre IsNot Nothing, valorNombre.ToString(), "")
            fltPrecio.Value = If(valorPrecio IsNot Nothing, Val(valorPrecio.ToString()), "")
            txtCategoria.Text = If(valorCategoria IsNot Nothing, valorCategoria.ToString(), "")
        Else
            lblID.Text = ""
        End If
    End Sub

    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("El nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If fltPrecio.Value <= 0 Then
            MessageBox.Show("El precio debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtCategoria.Text) Then
            MessageBox.Show("La categoría es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub btnProductoModificar_Click(sender As Object, e As EventArgs) Handles btnProductoModificar.Click
        If ValidarCampos() Then
            Dim id As Integer
            If Integer.TryParse(lblID.Text, id) Then
                negocio.ModificacionProducto(id, txtNombre.Text, fltPrecio.Value, txtCategoria.Text)
                MessageBox.Show("Producto modificado correctamente.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ProductosCargar()
            Else
                MessageBox.Show("ID no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnProductosEliminar_Click(sender As Object, e As EventArgs) Handles btnProductosEliminar.Click
        Dim msg As String = "Esta seguro que desea eliminar el producto?"
        If MessageBox.Show(msg, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim id As Integer
            If Integer.TryParse(lblID.Text, id) Then
                negocio.EliminarProducto(id)
                MessageBox.Show("Producto eliminado correctamente.", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ProductosCargar()
            Else
                MessageBox.Show("ID no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class
