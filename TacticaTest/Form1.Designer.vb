﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        SuspendLayout()
        ' 
        ' btnVerProductos
        ' 
        btnVerProductos.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnVerProductos.Location = New Point(62, 192)
        btnVerProductos.Name = "btnVerProductos"
        btnVerProductos.Size = New Size(175, 66)
        btnVerProductos.TabIndex = 0
        btnVerProductos.Text = "ver productos"
        btnVerProductos.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnVerProductos)
        Name = "Form1"
        Text = "TACTICA DEMO"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnVerProductos As Button
End Class
