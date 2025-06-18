Public Class Form1
    Private negocio As New Negocio.ClienteNegocio()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = negocio.ListarClientes()
    End Sub
End Class
