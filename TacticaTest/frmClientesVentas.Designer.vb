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
        txtClienteFiltrar = New TextBox()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(12, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 23
        Label5.Text = "cliente"
        ' 
        ' txtClienteFiltrar
        ' 
        txtClienteFiltrar.BackColor = Color.LightGray
        txtClienteFiltrar.Location = New Point(12, 26)
        txtClienteFiltrar.Margin = New Padding(3, 2, 3, 2)
        txtClienteFiltrar.MaxLength = 250
        txtClienteFiltrar.Name = "txtClienteFiltrar"
        txtClienteFiltrar.ReadOnly = True
        txtClienteFiltrar.Size = New Size(535, 23)
        txtClienteFiltrar.TabIndex = 22
        ' 
        ' frmClientesVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(txtClienteFiltrar)
        Name = "frmClientesVentas"
        Text = "Ventas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txtClienteFiltrar As TextBox
End Class
