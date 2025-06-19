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
        CType(dataGridProductos, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(fltPrecio, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dataGridProductos
        ' 
        dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridProductos.Location = New Point(12, 54)
        dataGridProductos.Name = "dataGridProductos"
        dataGridProductos.ReadOnly = True
        dataGridProductos.RowHeadersWidth = 51
        dataGridProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dataGridProductos.Size = New Size(757, 362)
        dataGridProductos.TabIndex = 0
        ' 
        ' btnAgregarProducto
        ' 
        btnAgregarProducto.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnAgregarProducto.Location = New Point(12, 11)
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
        btnVolver.Location = New Point(624, 625)
        btnVolver.Margin = New Padding(3, 2, 3, 2)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(145, 39)
        btnVolver.TabIndex = 2
        btnVolver.Text = "Cerrar"
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnProductosEliminar)
        Panel1.Controls.Add(fltPrecio)
        Panel1.Controls.Add(lblID)
        Panel1.Controls.Add(btnProductoModificar)
        Panel1.Controls.Add(txtNombre)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtCategoria)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(12, 441)
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
        ' frmProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(780, 675)
        Controls.Add(Panel1)
        Controls.Add(btnVolver)
        Controls.Add(btnAgregarProducto)
        Controls.Add(dataGridProductos)
        Name = "frmProductos"
        Text = "Productos"
        CType(dataGridProductos, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(fltPrecio, ComponentModel.ISupportInitialize).EndInit()
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

End Class
