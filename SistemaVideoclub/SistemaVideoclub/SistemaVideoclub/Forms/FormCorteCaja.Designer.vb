<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCorteCaja
    Inherits FromBase

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
        Me.lbl_id_corte_caja = New System.Windows.Forms.Label()
        Me.gb_datos = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gb_acciones = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gb_datos.SuspendLayout()
        Me.gb_acciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(297, 133)
        '
        'lbl_id_corte_caja
        '
        Me.lbl_id_corte_caja.AutoSize = True
        Me.lbl_id_corte_caja.Location = New System.Drawing.Point(-1, 0)
        Me.lbl_id_corte_caja.Name = "lbl_id_corte_caja"
        Me.lbl_id_corte_caja.Size = New System.Drawing.Size(84, 15)
        Me.lbl_id_corte_caja.TabIndex = 1
        Me.lbl_id_corte_caja.Text = "id_corte_caja"
        Me.lbl_id_corte_caja.Visible = False
        '
        'gb_datos
        '
        Me.gb_datos.Controls.Add(Me.Label1)
        Me.gb_datos.Controls.Add(Me.DateTimePicker1)
        Me.gb_datos.Controls.Add(Me.lbl_id_corte_caja)
        Me.gb_datos.Location = New System.Drawing.Point(13, 13)
        Me.gb_datos.Name = "gb_datos"
        Me.gb_datos.Size = New System.Drawing.Size(394, 89)
        Me.gb_datos.TabIndex = 2
        Me.gb_datos.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(112, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(271, 21)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha de hoy:"
        '
        'gb_acciones
        '
        Me.gb_acciones.Controls.Add(Me.Button2)
        Me.gb_acciones.Controls.Add(Me.Button1)
        Me.gb_acciones.Location = New System.Drawing.Point(13, 109)
        Me.gb_acciones.Name = "gb_acciones"
        Me.gb_acciones.Size = New System.Drawing.Size(266, 71)
        Me.gb_acciones.TabIndex = 3
        Me.gb_acciones.TabStop = False
        Me.gb_acciones.Text = "Acciones"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(19, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cerrar caja"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(145, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Ver Balance"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FormCorteCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 192)
        Me.Controls.Add(Me.gb_acciones)
        Me.Controls.Add(Me.gb_datos)
        Me.Name = "FormCorteCaja"
        Me.Text = "Realizar corte de caja"
        Me.Controls.SetChildIndex(Me.btn_salir, 0)
        Me.Controls.SetChildIndex(Me.gb_datos, 0)
        Me.Controls.SetChildIndex(Me.gb_acciones, 0)
        Me.gb_datos.ResumeLayout(False)
        Me.gb_datos.PerformLayout()
        Me.gb_acciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_id_corte_caja As Label
    Friend WithEvents gb_datos As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents gb_acciones As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
