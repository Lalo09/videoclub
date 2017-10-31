<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVerBalance
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
        Me.gb_balance = New System.Windows.Forms.GroupBox()
        Me.gb_historial = New System.Windows.Forms.GroupBox()
        Me.lbl_texto = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dg_balance = New System.Windows.Forms.DataGridView()
        Me.gb_ver_por_fecha = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_a = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gb_balance.SuspendLayout()
        Me.gb_historial.SuspendLayout()
        CType(Me.dg_balance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_ver_por_fecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(587, 384)
        '
        'gb_balance
        '
        Me.gb_balance.Controls.Add(Me.TextBox1)
        Me.gb_balance.Controls.Add(Me.lbl_texto)
        Me.gb_balance.Location = New System.Drawing.Point(12, 12)
        Me.gb_balance.Name = "gb_balance"
        Me.gb_balance.Size = New System.Drawing.Size(680, 58)
        Me.gb_balance.TabIndex = 1
        Me.gb_balance.TabStop = False
        '
        'gb_historial
        '
        Me.gb_historial.Controls.Add(Me.dg_balance)
        Me.gb_historial.Location = New System.Drawing.Point(12, 90)
        Me.gb_historial.Name = "gb_historial"
        Me.gb_historial.Size = New System.Drawing.Size(680, 206)
        Me.gb_historial.TabIndex = 2
        Me.gb_historial.TabStop = False
        Me.gb_historial.Text = "Historial"
        '
        'lbl_texto
        '
        Me.lbl_texto.AutoSize = True
        Me.lbl_texto.Location = New System.Drawing.Point(18, 26)
        Me.lbl_texto.Name = "lbl_texto"
        Me.lbl_texto.Size = New System.Drawing.Size(172, 15)
        Me.lbl_texto.TabIndex = 0
        Me.lbl_texto.Text = "El balance del dia de hoy es:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(196, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(299, 21)
        Me.TextBox1.TabIndex = 1
        '
        'dg_balance
        '
        Me.dg_balance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_balance.Location = New System.Drawing.Point(7, 30)
        Me.dg_balance.Name = "dg_balance"
        Me.dg_balance.Size = New System.Drawing.Size(667, 170)
        Me.dg_balance.TabIndex = 0
        '
        'gb_ver_por_fecha
        '
        Me.gb_ver_por_fecha.Controls.Add(Me.lbl_a)
        Me.gb_ver_por_fecha.Controls.Add(Me.DateTimePicker2)
        Me.gb_ver_por_fecha.Controls.Add(Me.DateTimePicker1)
        Me.gb_ver_por_fecha.Location = New System.Drawing.Point(13, 303)
        Me.gb_ver_por_fecha.Name = "gb_ver_por_fecha"
        Me.gb_ver_por_fecha.Size = New System.Drawing.Size(679, 75)
        Me.gb_ver_por_fecha.TabIndex = 3
        Me.gb_ver_por_fecha.TabStop = False
        Me.gb_ver_por_fecha.Text = "Ver por fecha"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 31)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(252, 21)
        Me.DateTimePicker1.TabIndex = 0
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(285, 31)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(252, 21)
        Me.DateTimePicker2.TabIndex = 1
        '
        'lbl_a
        '
        Me.lbl_a.AutoSize = True
        Me.lbl_a.Location = New System.Drawing.Point(264, 36)
        Me.lbl_a.Name = "lbl_a"
        Me.lbl_a.Size = New System.Drawing.Size(15, 15)
        Me.lbl_a.TabIndex = 2
        Me.lbl_a.Text = "A"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(19, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Ver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(135, 384)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 32)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Deshacer"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FormVerBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 425)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gb_ver_por_fecha)
        Me.Controls.Add(Me.gb_historial)
        Me.Controls.Add(Me.gb_balance)
        Me.Name = "FormVerBalance"
        Me.Text = "FormVerBalance"
        Me.Controls.SetChildIndex(Me.btn_salir, 0)
        Me.Controls.SetChildIndex(Me.gb_balance, 0)
        Me.Controls.SetChildIndex(Me.gb_historial, 0)
        Me.Controls.SetChildIndex(Me.gb_ver_por_fecha, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.gb_balance.ResumeLayout(False)
        Me.gb_balance.PerformLayout()
        Me.gb_historial.ResumeLayout(False)
        CType(Me.dg_balance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_ver_por_fecha.ResumeLayout(False)
        Me.gb_ver_por_fecha.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_balance As GroupBox
    Friend WithEvents gb_historial As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbl_texto As Label
    Friend WithEvents dg_balance As DataGridView
    Friend WithEvents gb_ver_por_fecha As GroupBox
    Friend WithEvents lbl_a As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
