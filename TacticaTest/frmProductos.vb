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
        DataGridView1.DataSource = negocio.ListarProductos()
    End Sub
End Class
