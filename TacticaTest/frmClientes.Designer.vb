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
        btnClienteEliminar = New Button()
        lblID = New Label()
        btnClienteModificar = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        btnBuscar = New Button()
        Panel2 = New Panel()
        txtCorreoFiltrar = New TextBox()
        txtTelefonoFiltrar = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        txtClienteFiltrar = New TextBox()
        Label4 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        btnClienteVenta = New Button()
        btnVentaEliminar = New Button()
        btnVentaModificar = New Button()
        DataGridVentas = New DataGridView()
        Label8 = New Label()
        CType(DataGridClientes, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(DataGridVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridClientes
        ' 
        DataGridClientes.AllowUserToAddRows = False
        DataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridClientes.Location = New Point(14, 154)
        DataGridClientes.MultiSelect = False
        DataGridClientes.Name = "DataGridClientes"
        DataGridClientes.ReadOnly = True
        DataGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridClientes.Size = New Size(563, 264)
        DataGridClientes.TabIndex = 0
        ' 
        ' btnVolver
        ' 
        btnVolver.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnVolver.Location = New Point(162, 14)
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
        btnAgregarCliente.Location = New Point(8, 168)
        btnAgregarCliente.Margin = New Padding(3, 2, 3, 2)
        btnAgregarCliente.Name = "btnAgregarCliente"
        btnAgregarCliente.Size = New Size(129, 30)
        btnAgregarCliente.TabIndex = 3
        btnAgregarCliente.Text = "Agregar Cliente"
        btnAgregarCliente.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(14, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 15)
        Label3.TabIndex = 15
        Label3.Text = "correo"
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(81, 131)
        txtCorreo.Margin = New Padding(3, 2, 3, 2)
        txtCorreo.MaxLength = 250
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(396, 23)
        txtCorreo.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(14, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 14
        Label2.Text = "Telefono"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(81, 85)
        txtTelefono.Margin = New Padding(3, 2, 3, 2)
        txtTelefono.MaxLength = 250
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(396, 23)
        txtTelefono.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(14, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 13
        Label1.Text = "cliente"
        ' 
        ' txtCliente
        ' 
        txtCliente.Location = New Point(81, 40)
        txtCliente.Margin = New Padding(3, 2, 3, 2)
        txtCliente.MaxLength = 250
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(396, 23)
        txtCliente.TabIndex = 10
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(btnAgregarCliente)
        Panel1.Controls.Add(btnClienteEliminar)
        Panel1.Controls.Add(lblID)
        Panel1.Controls.Add(btnClienteModificar)
        Panel1.Controls.Add(txtCliente)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtCorreo)
        Panel1.Controls.Add(txtTelefono)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(16, 453)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(591, 219)
        Panel1.TabIndex = 16
        ' 
        ' btnClienteEliminar
        ' 
        btnClienteEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnClienteEliminar.Location = New Point(430, 168)
        btnClienteEliminar.Margin = New Padding(3, 2, 3, 2)
        btnClienteEliminar.Name = "btnClienteEliminar"
        btnClienteEliminar.Size = New Size(123, 30)
        btnClienteEliminar.TabIndex = 19
        btnClienteEliminar.Text = "Eliminar Clente"
        btnClienteEliminar.UseVisualStyleBackColor = True
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblID.Location = New Point(14, 14)
        lblID.Name = "lblID"
        lblID.Size = New Size(20, 15)
        lblID.TabIndex = 18
        lblID.Text = "ID"
        ' 
        ' btnClienteModificar
        ' 
        btnClienteModificar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnClienteModificar.Location = New Point(217, 168)
        btnClienteModificar.Margin = New Padding(3, 2, 3, 2)
        btnClienteModificar.Name = "btnClienteModificar"
        btnClienteModificar.Size = New Size(123, 30)
        btnClienteModificar.TabIndex = 17
        btnClienteModificar.Text = "Modificar Clente"
        btnClienteModificar.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnBuscar.Location = New Point(472, 109)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(105, 27)
        btnBuscar.TabIndex = 17
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(txtCorreoFiltrar)
        Panel2.Controls.Add(txtTelefonoFiltrar)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(DataGridClientes)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(txtClienteFiltrar)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(btnBuscar)
        Panel2.ForeColor = Color.Black
        Panel2.Location = New Point(16, 13)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(591, 434)
        Panel2.TabIndex = 18
        ' 
        ' txtCorreoFiltrar
        ' 
        txtCorreoFiltrar.Location = New Point(79, 112)
        txtCorreoFiltrar.Margin = New Padding(3, 2, 3, 2)
        txtCorreoFiltrar.MaxLength = 250
        txtCorreoFiltrar.Name = "txtCorreoFiltrar"
        txtCorreoFiltrar.Size = New Size(387, 23)
        txtCorreoFiltrar.TabIndex = 24
        ' 
        ' txtTelefonoFiltrar
        ' 
        txtTelefonoFiltrar.Location = New Point(79, 77)
        txtTelefonoFiltrar.Margin = New Padding(3, 2, 3, 2)
        txtTelefonoFiltrar.MaxLength = 250
        txtTelefonoFiltrar.Name = "txtTelefonoFiltrar"
        txtTelefonoFiltrar.Size = New Size(387, 23)
        txtTelefonoFiltrar.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(9, 115)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 15)
        Label6.TabIndex = 22
        Label6.Text = "correo"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(9, 80)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 15)
        Label7.TabIndex = 21
        Label7.Text = "Telefono"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(8, 42)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 20
        Label5.Text = "cliente"
        ' 
        ' txtClienteFiltrar
        ' 
        txtClienteFiltrar.Location = New Point(79, 39)
        txtClienteFiltrar.Margin = New Padding(3, 2, 3, 2)
        txtClienteFiltrar.MaxLength = 250
        txtClienteFiltrar.Name = "txtClienteFiltrar"
        txtClienteFiltrar.Size = New Size(387, 23)
        txtClienteFiltrar.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(3, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 18
        Label4.Text = "Filtros"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btnVolver)
        Panel3.Location = New Point(613, 612)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(436, 60)
        Panel3.TabIndex = 19
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(btnClienteVenta)
        Panel4.Controls.Add(btnVentaEliminar)
        Panel4.Controls.Add(btnVentaModificar)
        Panel4.Controls.Add(DataGridVentas)
        Panel4.Controls.Add(Label8)
        Panel4.Location = New Point(613, 13)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(438, 590)
        Panel4.TabIndex = 20
        ' 
        ' btnClienteVenta
        ' 
        btnClienteVenta.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnClienteVenta.Location = New Point(14, 544)
        btnClienteVenta.Margin = New Padding(3, 2, 3, 2)
        btnClienteVenta.Name = "btnClienteVenta"
        btnClienteVenta.Size = New Size(129, 30)
        btnClienteVenta.TabIndex = 23
        btnClienteVenta.Text = "Ingresar Venta"
        btnClienteVenta.UseVisualStyleBackColor = True
        ' 
        ' btnVentaEliminar
        ' 
        btnVentaEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnVentaEliminar.Location = New Point(297, 544)
        btnVentaEliminar.Margin = New Padding(3, 2, 3, 2)
        btnVentaEliminar.Name = "btnVentaEliminar"
        btnVentaEliminar.Size = New Size(129, 30)
        btnVentaEliminar.TabIndex = 22
        btnVentaEliminar.Text = "Eliminar Venta"
        btnVentaEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnVentaModificar
        ' 
        btnVentaModificar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnVentaModificar.Location = New Point(162, 544)
        btnVentaModificar.Margin = New Padding(3, 2, 3, 2)
        btnVentaModificar.Name = "btnVentaModificar"
        btnVentaModificar.Size = New Size(129, 30)
        btnVentaModificar.TabIndex = 21
        btnVentaModificar.Text = "Modificar Venta"
        btnVentaModificar.UseVisualStyleBackColor = True
        ' 
        ' DataGridVentas
        ' 
        DataGridVentas.AllowUserToAddRows = False
        DataGridVentas.AllowUserToDeleteRows = False
        DataGridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridVentas.Location = New Point(14, 39)
        DataGridVentas.MultiSelect = False
        DataGridVentas.Name = "DataGridVentas"
        DataGridVentas.ReadOnly = True
        DataGridVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridVentas.Size = New Size(412, 500)
        DataGridVentas.TabIndex = 20
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(8, 18)
        Label8.Name = "Label8"
        Label8.Size = New Size(104, 15)
        Label8.TabIndex = 19
        Label8.Text = "Ventas Realizadas"
        ' 
        ' frmClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1052, 719)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "frmClientes"
        Text = "Clientes"
        CType(DataGridClientes, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(DataGridVentas, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnClienteEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtClienteFiltrar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTelefonoFiltrar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCorreoFiltrar As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridVentas As DataGridView
    Friend WithEvents btnVentaModificar As Button
    Friend WithEvents btnVentaEliminar As Button
    Friend WithEvents btnClienteVenta As Button
End Class
