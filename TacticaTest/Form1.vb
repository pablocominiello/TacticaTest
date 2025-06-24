Public Class Form1
    Private Sub btnVerProductos_Click(sender As Object, e As EventArgs) Handles btnVerProductos.Click
        Dim frmProductos As New frmProductos()
        frmProductos.Show()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        ClientesMostrar()
    End Sub

    Private Sub ClientesMostrar()
        Dim frmClientes As New frmClientes()
        frmClientes.Show()
    End Sub
End Class