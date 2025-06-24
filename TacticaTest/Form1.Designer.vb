<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        btnVerProductos = New Button()
        btnClientes = New Button()
        MenuStrip1 = New MenuStrip()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        VerProductosToolStripMenuItem = New ToolStripMenuItem()
        ClientesAMBToolStripMenuItem = New ToolStripMenuItem()
        VentasToolStripMenuItem = New ToolStripMenuItem()
        OperacionesDeVentasToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnVerProductos
        ' 
        btnVerProductos.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnVerProductos.Location = New Point(746, 191)
        btnVerProductos.Margin = New Padding(3, 2, 3, 2)
        btnVerProductos.Name = "btnVerProductos"
        btnVerProductos.Size = New Size(153, 50)
        btnVerProductos.TabIndex = 0
        btnVerProductos.Text = "ver productos"
        btnVerProductos.UseVisualStyleBackColor = True
        ' 
        ' btnClientes
        ' 
        btnClientes.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnClientes.Location = New Point(746, 46)
        btnClientes.Margin = New Padding(3, 2, 3, 2)
        btnClientes.Name = "btnClientes"
        btnClientes.Size = New Size(153, 50)
        btnClientes.TabIndex = 1
        btnClientes.Text = "ver clientes"
        btnClientes.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ClientesToolStripMenuItem, ProductosToolStripMenuItem, VentasToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(955, 24)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClientesAMBToolStripMenuItem})
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(61, 20)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VerProductosToolStripMenuItem})
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(73, 20)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' VerProductosToolStripMenuItem
        ' 
        VerProductosToolStripMenuItem.Name = "VerProductosToolStripMenuItem"
        VerProductosToolStripMenuItem.Size = New Size(180, 22)
        VerProductosToolStripMenuItem.Text = "Productos ABM"
        ' 
        ' ClientesAMBToolStripMenuItem
        ' 
        ClientesAMBToolStripMenuItem.Name = "ClientesAMBToolStripMenuItem"
        ClientesAMBToolStripMenuItem.Size = New Size(180, 22)
        ClientesAMBToolStripMenuItem.Text = "Clientes AMB"
        ' 
        ' VentasToolStripMenuItem
        ' 
        VentasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OperacionesDeVentasToolStripMenuItem})
        VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        VentasToolStripMenuItem.Size = New Size(53, 20)
        VentasToolStripMenuItem.Text = "Ventas"
        ' 
        ' OperacionesDeVentasToolStripMenuItem
        ' 
        OperacionesDeVentasToolStripMenuItem.Name = "OperacionesDeVentasToolStripMenuItem"
        OperacionesDeVentasToolStripMenuItem.Size = New Size(193, 22)
        OperacionesDeVentasToolStripMenuItem.Text = "Operaciones de Ventas"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(955, 600)
        Controls.Add(btnClientes)
        Controls.Add(btnVerProductos)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "TACTICA DEMO"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnVerProductos As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesAMBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperacionesDeVentasToolStripMenuItem As ToolStripMenuItem
End Class
