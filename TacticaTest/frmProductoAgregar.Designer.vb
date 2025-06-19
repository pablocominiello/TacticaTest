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
        txtNombre = New TextBox()
        txtCategoria = New TextBox()
        Label1 = New Label()
        fltPrecio = New NumericUpDown()
        Label2 = New Label()
        Label3 = New Label()
        btnAgregar = New Button()
        btnCancelar = New Button()
        CType(fltPrecio, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(29, 39)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(125, 27)
        txtNombre.TabIndex = 0
        ' 
        ' txtCategoria
        ' 
        txtCategoria.Location = New Point(176, 138)
        txtCategoria.Name = "txtCategoria"
        txtCategoria.Size = New Size(125, 27)
        txtCategoria.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(33, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 3
        Label1.Text = "Nombre"
        ' 
        ' fltPrecio
        ' 
        fltPrecio.DecimalPlaces = 2
        fltPrecio.Location = New Point(176, 98)
        fltPrecio.Name = "fltPrecio"
        fltPrecio.Size = New Size(150, 27)
        fltPrecio.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(29, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 20)
        Label2.TabIndex = 5
        Label2.Text = "Precio"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(33, 138)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 20)
        Label3.TabIndex = 6
        Label3.Text = "Categoria"
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(37, 217)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(94, 29)
        btnAgregar.TabIndex = 7
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(167, 217)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(94, 29)
        btnCancelar.TabIndex = 8
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' frmProductoAgregar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(353, 265)
        Controls.Add(btnCancelar)
        Controls.Add(btnAgregar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(fltPrecio)
        Controls.Add(Label1)
        Controls.Add(txtCategoria)
        Controls.Add(txtNombre)
        Name = "frmProductoAgregar"
        Text = "Agregar Producto"
        CType(fltPrecio, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents fltPrecio As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCancelar As Button
End Class
