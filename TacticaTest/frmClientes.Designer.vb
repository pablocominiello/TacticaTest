<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        DataGridClientes = New DataGridView()
        btnVolver = New Button()
        btnAgregarCliente = New Button()
        Label3 = New Label()
        txtCorreo = New TextBox()
        Label2 = New Label()
        txtTelefono = New TextBox()
        Label1 = New Label()
        txtCliente = New TextBox()
        Panel1 = New Panel()
        lblID = New Label()
        btnClienteModificar = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        CType(DataGridClientes, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridClientes
        ' 
        DataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridClientes.Location = New Point(12, 62)
        DataGridClientes.Name = "DataGridClientes"
        DataGridClientes.ReadOnly = True
        DataGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridClientes.Size = New Size(623, 293)
        DataGridClientes.TabIndex = 0
        ' 
        ' btnVolver
        ' 
        btnVolver.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnVolver.Location = New Point(506, 570)
        btnVolver.Margin = New Padding(3, 2, 3, 2)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(129, 30)
        btnVolver.TabIndex = 4
        btnVolver.Text = "Cerrar"
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarCliente
        ' 
        btnAgregarCliente.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnAgregarCliente.Location = New Point(12, 11)
        btnAgregarCliente.Margin = New Padding(3, 2, 3, 2)
        btnAgregarCliente.Name = "btnAgregarCliente"
        btnAgregarCliente.Size = New Size(130, 36)
        btnAgregarCliente.TabIndex = 3
        btnAgregarCliente.Text = "Agregar Cliente"
        btnAgregarCliente.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(26, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 15)
        Label3.TabIndex = 15
        Label3.Text = "correo"
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(129, 131)
        txtCorreo.Margin = New Padding(3, 2, 3, 2)
        txtCorreo.MaxLength = 250
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(110, 23)
        txtCorreo.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label2.Location = New Point(26, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 14
        Label2.Text = "Telefono"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(129, 85)
        txtTelefono.Margin = New Padding(3, 2, 3, 2)
        txtTelefono.MaxLength = 250
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(110, 23)
        txtTelefono.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label1.Location = New Point(26, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 13
        Label1.Text = "cliente"
        ' 
        ' txtCliente
        ' 
        txtCliente.Location = New Point(129, 40)
        txtCliente.Margin = New Padding(3, 2, 3, 2)
        txtCliente.MaxLength = 250
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(110, 23)
        txtCliente.TabIndex = 10
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblID)
        Panel1.Controls.Add(btnClienteModificar)
        Panel1.Controls.Add(txtCliente)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtCorreo)
        Panel1.Controls.Add(txtTelefono)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(16, 381)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(286, 219)
        Panel1.TabIndex = 16
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblID.Location = New Point(26, 14)
        lblID.Name = "lblID"
        lblID.Size = New Size(20, 15)
        lblID.TabIndex = 18
        lblID.Text = "ID"
        ' 
        ' btnClienteModificar
        ' 
        btnClienteModificar.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnClienteModificar.Location = New Point(63, 172)
        btnClienteModificar.Margin = New Padding(3, 2, 3, 2)
        btnClienteModificar.Name = "btnClienteModificar"
        btnClienteModificar.Size = New Size(130, 36)
        btnClienteModificar.TabIndex = 17
        btnClienteModificar.Text = "Modificar Clente"
        btnClienteModificar.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' frmClientes
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(648, 616)
        Controls.Add(Panel1)
        Controls.Add(btnVolver)
        Controls.Add(btnAgregarCliente)
        Controls.Add(DataGridClientes)
        Name = "frmClientes"
        Text = "Clientes"
        CType(DataGridClientes, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridClientes As DataGridView
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClienteModificar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents lblID As Label
End Class
