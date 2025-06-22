<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dataGridProductos = New DataGridView()
        btnAgregarProducto = New Button()
        btnVolver = New Button()
        Panel1 = New Panel()
        btnProductosEliminar = New Button()
        fltPrecio = New NumericUpDown()
        lblID = New Label()
        btnProductoModificar = New Button()
        txtNombre = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        txtCategoria = New TextBox()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        numPrecioMinimo = New NumericUpDown()
        Label6 = New Label()
        txtFiltroCategoria = New TextBox()
        txtFiltroNombre = New TextBox()
        numPrecioMaximo = New NumericUpDown()
        Panel2 = New Panel()
        btnBuscar = New Button()
        Label8 = New Label()
        Label7 = New Label()
        Panel3 = New Panel()
        CType(dataGridProductos, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(fltPrecio, ComponentModel.ISupportInitialize).BeginInit()
        CType(numPrecioMinimo, ComponentModel.ISupportInitialize).BeginInit()
        CType(numPrecioMaximo, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' dataGridProductos
        ' 
        dataGridProductos.AllowUserToAddRows = False
        dataGridProductos.AllowUserToDeleteRows = False
        dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridProductos.Location = New Point(10, 143)
        dataGridProductos.Name = "dataGridProductos"
        dataGridProductos.ReadOnly = True
        dataGridProductos.RowHeadersWidth = 51
        dataGridProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataGridProductos.Size = New Size(757, 252)
        dataGridProductos.TabIndex = 0
        ' 
        ' btnAgregarProducto
        ' 
        btnAgregarProducto.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnAgregarProducto.Location = New Point(14, 14)
        btnAgregarProducto.Margin = New Padding(3, 2, 3, 2)
        btnAgregarProducto.Name = "btnAgregarProducto"
        btnAgregarProducto.Size = New Size(145, 38)
        btnAgregarProducto.TabIndex = 1
        btnAgregarProducto.Text = "Agregar Producto"
        btnAgregarProducto.UseVisualStyleBackColor = True
        ' 
        ' btnVolver
        ' 
        btnVolver.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnVolver.Location = New Point(14, 172)
        btnVolver.Margin = New Padding(3, 2, 3, 2)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(145, 39)
        btnVolver.TabIndex = 2
        btnVolver.Text = "Cerrar"
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(btnProductosEliminar)
        Panel1.Controls.Add(fltPrecio)
        Panel1.Controls.Add(lblID)
        Panel1.Controls.Add(btnProductoModificar)
        Panel1.Controls.Add(txtNombre)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtCategoria)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(10, 434)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(606, 222)
        Panel1.TabIndex = 17
        ' 
        ' btnProductosEliminar
        ' 
        btnProductosEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnProductosEliminar.Location = New Point(340, 173)
        btnProductosEliminar.Margin = New Padding(3, 2, 3, 2)
        btnProductosEliminar.Name = "btnProductosEliminar"
        btnProductosEliminar.Size = New Size(130, 36)
        btnProductosEliminar.TabIndex = 20
        btnProductosEliminar.Text = "Eliminar Producto"
        btnProductosEliminar.UseVisualStyleBackColor = True
        ' 
        ' fltPrecio
        ' 
        fltPrecio.DecimalPlaces = 2
        fltPrecio.Location = New Point(129, 85)
        fltPrecio.Margin = New Padding(3, 2, 3, 2)
        fltPrecio.Maximum = New Decimal(New Integer() {9000000, 0, 0, 0})
        fltPrecio.Name = "fltPrecio"
        fltPrecio.Size = New Size(110, 23)
        fltPrecio.TabIndex = 19
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblID.Location = New Point(26, 14)
        lblID.Name = "lblID"
        lblID.Size = New Size(20, 15)
        lblID.TabIndex = 18
        lblID.Text = "ID"
        ' 
        ' btnProductoModificar
        ' 
        btnProductoModificar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnProductoModificar.Location = New Point(129, 173)
        btnProductoModificar.Margin = New Padding(3, 2, 3, 2)
        btnProductoModificar.Name = "btnProductoModificar"
        btnProductoModificar.Size = New Size(130, 36)
        btnProductoModificar.TabIndex = 17
        btnProductoModificar.Text = "Modificar Producto"
        btnProductoModificar.UseVisualStyleBackColor = True
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(129, 40)
        txtNombre.Margin = New Padding(3, 2, 3, 2)
        txtNombre.MaxLength = 250
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(453, 23)
        txtNombre.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(26, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 15
        Label3.Text = "Categoria"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(26, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 15)
        Label1.TabIndex = 13
        Label1.Text = "Nombre"
        ' 
        ' txtCategoria
        ' 
        txtCategoria.Location = New Point(129, 131)
        txtCategoria.Margin = New Padding(3, 2, 3, 2)
        txtCategoria.MaxLength = 250
        txtCategoria.Name = "txtCategoria"
        txtCategoria.Size = New Size(453, 23)
        txtCategoria.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(26, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 14
        Label2.Text = "Precio"
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(10, 74)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 15)
        Label5.TabIndex = 22
        Label5.Text = "Precio minimo"
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
        ' txtFiltroCategoria
        ' 
        txtFiltroCategoria.Location = New Point(113, 102)
        txtFiltroCategoria.Margin = New Padding(3, 2, 3, 2)
        txtFiltroCategoria.Name = "txtFiltroCategoria"
        txtFiltroCategoria.Size = New Size(110, 23)
        txtFiltroCategoria.TabIndex = 20
        ' 
        ' txtFiltroNombre
        ' 
        txtFiltroNombre.Location = New Point(113, 35)
        txtFiltroNombre.Margin = New Padding(3, 2, 3, 2)
        txtFiltroNombre.Name = "txtFiltroNombre"
        txtFiltroNombre.Size = New Size(110, 23)
        txtFiltroNombre.TabIndex = 18
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
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btnBuscar)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(dataGridProductos)
        Panel2.Controls.Add(numPrecioMaximo)
        Panel2.Controls.Add(txtFiltroNombre)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(txtFiltroCategoria)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(numPrecioMinimo)
        Panel2.Location = New Point(7, 10)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(789, 412)
        Panel2.TabIndex = 25
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnBuscar.Location = New Point(662, 99)
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
        Label8.Size = New Size(41, 15)
        Label8.TabIndex = 26
        Label8.Text = "Filtros"
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
        ' Panel3
        ' 
        Panel3.Controls.Add(btnAgregarProducto)
        Panel3.Controls.Add(btnVolver)
        Panel3.Location = New Point(629, 435)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(167, 221)
        Panel3.TabIndex = 26
        ' 
        ' frmProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 675)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "frmProductos"
        Text = "Productos"
        CType(dataGridProductos, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(fltPrecio, ComponentModel.ISupportInitialize).EndInit()
        CType(numPrecioMinimo, ComponentModel.ISupportInitialize).EndInit()
        CType(numPrecioMaximo, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dataGridProductos As DataGridView
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblID As Label
    Friend WithEvents btnProductoModificar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents fltPrecio As NumericUpDown
    Friend WithEvents btnProductosEliminar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents numPrecioMinimo As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFiltroCategoria As TextBox
    Friend WithEvents txtFiltroNombre As TextBox
    Friend WithEvents numPrecioMaximo As NumericUpDown
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBuscar As Button

End Class
