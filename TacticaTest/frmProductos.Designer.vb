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
        DataGridView1 = New DataGridView()
        btnAgregarProducto = New Button()
        btnVolver = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(18, 10)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(757, 362)
        DataGridView1.TabIndex = 0
        ' 
        ' btnAgregarProducto
        ' 
        btnAgregarProducto.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnAgregarProducto.Location = New Point(18, 389)
        btnAgregarProducto.Margin = New Padding(3, 2, 3, 2)
        btnAgregarProducto.Name = "btnAgregarProducto"
        btnAgregarProducto.Size = New Size(178, 50)
        btnAgregarProducto.TabIndex = 1
        btnAgregarProducto.Text = "Agregar Producto"
        btnAgregarProducto.UseVisualStyleBackColor = True
        ' 
        ' btnVolver
        ' 
        btnVolver.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnVolver.Location = New Point(587, 389)
        btnVolver.Margin = New Padding(3, 2, 3, 2)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(178, 50)
        btnVolver.TabIndex = 2
        btnVolver.Text = "Cerrar"
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' frmProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnVolver)
        Controls.Add(btnAgregarProducto)
        Controls.Add(DataGridView1)
        Name = "frmProductos"
        Text = "Productos"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents btnVolver As Button

End Class
