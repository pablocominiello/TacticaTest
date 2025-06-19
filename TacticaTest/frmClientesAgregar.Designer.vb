<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientesAgregar
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
        Label1 = New Label()
        txtCliente = New TextBox()
        Label2 = New Label()
        txtTelefono = New TextBox()
        Label3 = New Label()
        txtCorreo = New TextBox()
        btnVolver = New Button()
        btnAgregarCliente = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(30, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 5
        Label1.Text = "cliente"
        ' 
        ' txtCliente
        ' 
        txtCliente.Location = New Point(133, 27)
        txtCliente.Margin = New Padding(3, 2, 3, 2)
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(110, 23)
        txtCliente.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(30, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 7
        Label2.Text = "Telefono"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(133, 72)
        txtTelefono.Margin = New Padding(3, 2, 3, 2)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(110, 23)
        txtTelefono.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(30, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 15)
        Label3.TabIndex = 9
        Label3.Text = "correo"
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(133, 118)
        txtCorreo.Margin = New Padding(3, 2, 3, 2)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(110, 23)
        txtCorreo.TabIndex = 3
        ' 
        ' btnVolver
        ' 
        btnVolver.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnVolver.Location = New Point(170, 168)
        btnVolver.Margin = New Padding(3, 2, 3, 2)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(113, 30)
        btnVolver.TabIndex = 5
        btnVolver.Text = "Cerrar"
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarCliente
        ' 
        btnAgregarCliente.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnAgregarCliente.Location = New Point(25, 168)
        btnAgregarCliente.Margin = New Padding(3, 2, 3, 2)
        btnAgregarCliente.Name = "btnAgregarCliente"
        btnAgregarCliente.Size = New Size(113, 30)
        btnAgregarCliente.TabIndex = 4
        btnAgregarCliente.Text = "Agregar Cliente"
        btnAgregarCliente.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' frmClientesAgregar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(317, 216)
        Controls.Add(btnVolver)
        Controls.Add(btnAgregarCliente)
        Controls.Add(Label3)
        Controls.Add(txtCorreo)
        Controls.Add(Label2)
        Controls.Add(txtTelefono)
        Controls.Add(Label1)
        Controls.Add(txtCliente)
        Name = "frmClientesAgregar"
        Text = "Alta de Clientes"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
