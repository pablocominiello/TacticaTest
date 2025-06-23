<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientesVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label5 = New Label()
        txtCliente = New TextBox()
        lblIDCliente = New Label()
        Panel2 = New Panel()
        Label3 = New Label()
        btnProductosAgregar = New Button()
        btnBuscar = New Button()
        Label8 = New Label()
        Label7 = New Label()
        dataGridProductos = New DataGridView()
        numPrecioMaximo = New NumericUpDown()
        txtFiltroNombre = New TextBox()
        Label4 = New Label()
        txtFiltroCategoria = New TextBox()
        Label1 = New Label()
        Label6 = New Label()
        numPrecioMinimo = New NumericUpDown()
        btnVolver = New Button()
        Panel1 = New Panel()
        btnEliminarProducto = New Button()
        lblTotalVenta = New Label()
        Label2 = New Label()
        dataGridVentasItems = New DataGridView()
        lbltitulo = New Label()
        btnVentaIngresar = New Button()
        lblVentaID = New Label()
        Label9 = New Label()
        Panel3 = New Panel()
        btnVentaModificar = New Button()
        Panel2.SuspendLayout()
        CType(dataGridProductos, ComponentModel.ISupportInitialize).BeginInit()
        CType(numPrecioMaximo, ComponentModel.ISupportInitialize).BeginInit()
        CType(numPrecioMinimo, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(dataGridVentasItems, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(10, 7)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 15)
        Label5.TabIndex = 23
        Label5.Text = "Cliente"
        ' 
        ' txtCliente
        ' 
        txtCliente.BackColor = Color.LightGray
        txtCliente.Location = New Point(4, 23)
        txtCliente.Margin = New Padding(3, 2, 3, 2)
        txtCliente.MaxLength = 250
        txtCliente.Name = "txtCliente"
        txtCliente.ReadOnly = True
        txtCliente.Size = New Size(535, 23)
        txtCliente.TabIndex = 22
        ' 
        ' lblIDCliente
        ' 
        lblIDCliente.AutoSize = True
        lblIDCliente.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblIDCliente.Location = New Point(62, 7)
        lblIDCliente.Name = "lblIDCliente"
        lblIDCliente.Size = New Size(20, 15)
        lblIDCliente.TabIndex = 24
        lblIDCliente.Text = "ID"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(btnProductosAgregar)
        Panel2.Controls.Add(btnBuscar)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(dataGridProductos)
        Panel2.Controls.Add(numPrecioMaximo)
        Panel2.Controls.Add(txtFiltroNombre)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(txtFiltroCategoria)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(numPrecioMinimo)
        Panel2.Location = New Point(12, 69)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(877, 403)
        Panel2.TabIndex = 26
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(10, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 15)
        Label3.TabIndex = 30
        Label3.Text = "Seleccion de Productos"
        ' 
        ' btnProductosAgregar
        ' 
        btnProductosAgregar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnProductosAgregar.Location = New Point(10, 369)
        btnProductosAgregar.Name = "btnProductosAgregar"
        btnProductosAgregar.Size = New Size(105, 27)
        btnProductosAgregar.TabIndex = 28
        btnProductosAgregar.Text = "Selecionar Productos"
        btnProductosAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnBuscar.Location = New Point(747, 99)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(105, 27)
        btnBuscar.TabIndex = 27
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(10, 5)
        Label8.Name = "Label8"
        Label8.Size = New Size(114, 15)
        Label8.TabIndex = 26
        Label8.Text = "Seleccion de Filtros"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(265, 74)
        Label7.Name = "Label7"
        Label7.Size = New Size(52, 15)
        Label7.TabIndex = 25
        Label7.Text = "maximo"
        ' 
        ' dataGridProductos
        ' 
        dataGridProductos.AllowUserToAddRows = False
        dataGridProductos.AllowUserToDeleteRows = False
        dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridProductos.Location = New Point(10, 155)
        dataGridProductos.Name = "dataGridProductos"
        dataGridProductos.ReadOnly = True
        dataGridProductos.RowHeadersWidth = 51
        dataGridProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataGridProductos.Size = New Size(842, 208)
        dataGridProductos.TabIndex = 0
        ' 
        ' numPrecioMaximo
        ' 
        numPrecioMaximo.DecimalPlaces = 2
        numPrecioMaximo.Location = New Point(323, 66)
        numPrecioMaximo.Margin = New Padding(3, 2, 3, 2)
        numPrecioMaximo.Maximum = New Decimal(New Integer() {9000000, 0, 0, 0})
        numPrecioMaximo.Name = "numPrecioMaximo"
        numPrecioMaximo.Size = New Size(110, 23)
        numPrecioMaximo.TabIndex = 24
        ' 
        ' txtFiltroNombre
        ' 
        txtFiltroNombre.Location = New Point(113, 35)
        txtFiltroNombre.Margin = New Padding(3, 2, 3, 2)
        txtFiltroNombre.Name = "txtFiltroNombre"
        txtFiltroNombre.Size = New Size(110, 23)
        txtFiltroNombre.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(10, 105)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 23
        Label4.Text = "Categoria"
        ' 
        ' txtFiltroCategoria
        ' 
        txtFiltroCategoria.Location = New Point(113, 102)
        txtFiltroCategoria.Margin = New Padding(3, 2, 3, 2)
        txtFiltroCategoria.Name = "txtFiltroCategoria"
        txtFiltroCategoria.Size = New Size(110, 23)
        txtFiltroCategoria.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(10, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 15)
        Label1.TabIndex = 22
        Label1.Text = "Precio minimo"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(10, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 15)
        Label6.TabIndex = 21
        Label6.Text = "Nombre"
        ' 
        ' numPrecioMinimo
        ' 
        numPrecioMinimo.DecimalPlaces = 2
        numPrecioMinimo.Location = New Point(113, 66)
        numPrecioMinimo.Margin = New Padding(3, 2, 3, 2)
        numPrecioMinimo.Maximum = New Decimal(New Integer() {9000000, 0, 0, 0})
        numPrecioMinimo.Name = "numPrecioMinimo"
        numPrecioMinimo.Size = New Size(110, 23)
        numPrecioMinimo.TabIndex = 19
        ' 
        ' btnVolver
        ' 
        btnVolver.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnVolver.Location = New Point(895, 686)
        btnVolver.Margin = New Padding(3, 2, 3, 2)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(129, 30)
        btnVolver.TabIndex = 27
        btnVolver.Text = "Cerrar"
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(btnEliminarProducto)
        Panel1.Controls.Add(lblTotalVenta)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(dataGridVentasItems)
        Panel1.Location = New Point(12, 504)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(877, 212)
        Panel1.TabIndex = 28
        ' 
        ' btnEliminarProducto
        ' 
        btnEliminarProducto.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnEliminarProducto.Location = New Point(672, 165)
        btnEliminarProducto.Margin = New Padding(3, 2, 3, 2)
        btnEliminarProducto.Name = "btnEliminarProducto"
        btnEliminarProducto.Size = New Size(129, 30)
        btnEliminarProducto.TabIndex = 31
        btnEliminarProducto.Text = "Eliminar Producto"
        btnEliminarProducto.UseVisualStyleBackColor = True
        ' 
        ' lblTotalVenta
        ' 
        lblTotalVenta.AutoSize = True
        lblTotalVenta.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTotalVenta.Location = New Point(672, 46)
        lblTotalVenta.Name = "lblTotalVenta"
        lblTotalVenta.Size = New Size(58, 30)
        lblTotalVenta.TabIndex = 2
        lblTotalVenta.Text = "0,00"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(666, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 1
        Label2.Text = "Total"
        ' 
        ' dataGridVentasItems
        ' 
        dataGridVentasItems.AllowUserToAddRows = False
        dataGridVentasItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridVentasItems.Location = New Point(14, 14)
        dataGridVentasItems.MultiSelect = False
        dataGridVentasItems.Name = "dataGridVentasItems"
        dataGridVentasItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataGridVentasItems.Size = New Size(628, 181)
        dataGridVentasItems.TabIndex = 0
        ' 
        ' lbltitulo
        ' 
        lbltitulo.AutoSize = True
        lbltitulo.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbltitulo.Location = New Point(12, 486)
        lbltitulo.Name = "lbltitulo"
        lbltitulo.Size = New Size(115, 15)
        lbltitulo.TabIndex = 29
        lbltitulo.Text = "Productos a Vender"
        ' 
        ' btnVentaIngresar
        ' 
        btnVentaIngresar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnVentaIngresar.Location = New Point(895, 640)
        btnVentaIngresar.Margin = New Padding(3, 2, 3, 2)
        btnVentaIngresar.Name = "btnVentaIngresar"
        btnVentaIngresar.Size = New Size(129, 30)
        btnVentaIngresar.TabIndex = 30
        btnVentaIngresar.Text = "Ingresar Venta"
        btnVentaIngresar.UseVisualStyleBackColor = True
        ' 
        ' lblVentaID
        ' 
        lblVentaID.AutoSize = True
        lblVentaID.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblVentaID.Location = New Point(779, 7)
        lblVentaID.Name = "lblVentaID"
        lblVentaID.Size = New Size(14, 15)
        lblVentaID.TabIndex = 32
        lblVentaID.Text = "0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label9.Location = New Point(716, 7)
        Label9.Name = "Label9"
        Label9.Size = New Size(52, 15)
        Label9.TabIndex = 31
        Label9.Text = "VentaID"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(txtCliente)
        Panel3.Controls.Add(lblVentaID)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(lblIDCliente)
        Panel3.Location = New Point(12, 6)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(916, 57)
        Panel3.TabIndex = 33
        ' 
        ' btnVentaModificar
        ' 
        btnVentaModificar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnVentaModificar.Location = New Point(895, 589)
        btnVentaModificar.Margin = New Padding(3, 2, 3, 2)
        btnVentaModificar.Name = "btnVentaModificar"
        btnVentaModificar.Size = New Size(129, 30)
        btnVentaModificar.TabIndex = 34
        btnVentaModificar.Text = "Modificar Venta"
        btnVentaModificar.UseVisualStyleBackColor = True
        ' 
        ' frmClientesVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1035, 725)
        Controls.Add(btnVentaModificar)
        Controls.Add(Panel3)
        Controls.Add(btnVentaIngresar)
        Controls.Add(lbltitulo)
        Controls.Add(Panel1)
        Controls.Add(btnVolver)
        Controls.Add(Panel2)
        Name = "frmClientesVentas"
        Text = "Ventas"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dataGridProductos, ComponentModel.ISupportInitialize).EndInit()
        CType(numPrecioMaximo, ComponentModel.ISupportInitialize).EndInit()
        CType(numPrecioMinimo, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dataGridVentasItems, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lblIDCliente As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dataGridProductos As DataGridView
    Friend WithEvents numPrecioMaximo As NumericUpDown
    Friend WithEvents txtFiltroNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFiltroCategoria As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents numPrecioMinimo As NumericUpDown
    Friend WithEvents btnVolver As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbltitulo As Label
    Friend WithEvents btnProductosAgregar As Button
    Friend WithEvents dataGridVentasItems As DataGridView
    Friend WithEvents lblTotalVenta As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVentaIngresar As Button
    Friend WithEvents lblVentaID As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnVentaModificar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEliminarProducto As Button
End Class
