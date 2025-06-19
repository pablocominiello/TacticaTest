<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductoAgregar
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
        components = New ComponentModel.Container()
        txtNombre = New TextBox()
        txtCategoria = New TextBox()
        Label1 = New Label()
        fltPrecio = New NumericUpDown()
        Label2 = New Label()
        Label3 = New Label()
        btnProductoAgregar = New Button()
        btnCancelar = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        CType(fltPrecio, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(128, 25)
        txtNombre.Margin = New Padding(3, 2, 3, 2)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(110, 23)
        txtNombre.TabIndex = 0
        ' 
        ' txtCategoria
        ' 
        txtCategoria.Location = New Point(128, 109)
        txtCategoria.Margin = New Padding(3, 2, 3, 2)
        txtCategoria.Name = "txtCategoria"
        txtCategoria.Size = New Size(110, 23)
        txtCategoria.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(25, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 15)
        Label1.TabIndex = 3
        Label1.Text = "Nombre"
        ' 
        ' fltPrecio
        ' 
        fltPrecio.DecimalPlaces = 2
        fltPrecio.Location = New Point(128, 66)
        fltPrecio.Margin = New Padding(3, 2, 3, 2)
        fltPrecio.Name = "fltPrecio"
        fltPrecio.Size = New Size(110, 23)
        fltPrecio.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(25, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 5
        Label2.Text = "Precio"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(25, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 6
        Label3.Text = "Categoria"
        ' 
        ' btnProductoAgregar
        ' 
        btnProductoAgregar.Location = New Point(32, 163)
        btnProductoAgregar.Margin = New Padding(3, 2, 3, 2)
        btnProductoAgregar.Name = "btnProductoAgregar"
        btnProductoAgregar.Size = New Size(82, 22)
        btnProductoAgregar.TabIndex = 3
        btnProductoAgregar.Text = "Agregar"
        btnProductoAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(146, 163)
        btnCancelar.Margin = New Padding(3, 2, 3, 2)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(82, 22)
        btnCancelar.TabIndex = 4
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' frmProductoAgregar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(309, 199)
        Controls.Add(btnCancelar)
        Controls.Add(btnProductoAgregar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(fltPrecio)
        Controls.Add(Label1)
        Controls.Add(txtCategoria)
        Controls.Add(txtNombre)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmProductoAgregar"
        Text = "Agregar Producto"
        CType(fltPrecio, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents fltPrecio As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnProductoAgregar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
