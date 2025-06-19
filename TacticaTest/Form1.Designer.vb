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
        SuspendLayout()
        ' 
        ' btnVerProductos
        ' 
        btnVerProductos.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnVerProductos.Location = New Point(359, 144)
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
        btnClientes.Location = New Point(35, 144)
        btnClientes.Margin = New Padding(3, 2, 3, 2)
        btnClientes.Name = "btnClientes"
        btnClientes.Size = New Size(153, 50)
        btnClientes.TabIndex = 1
        btnClientes.Text = "ver clientes"
        btnClientes.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        Controls.Add(btnClientes)
        Controls.Add(btnVerProductos)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "TACTICA DEMO"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnVerProductos As Button
    Friend WithEvents btnClientes As Button
End Class
