<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdeudos
    Inherits FromBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txt_socio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_estatus = New System.Windows.Forms.ComboBox()
        Me.lbl_estatus = New System.Windows.Forms.Label()
        Me.txt_total_adeudo = New System.Windows.Forms.TextBox()
        Me.lbl_total_adeudo = New System.Windows.Forms.Label()
        Me.dg_adeudos = New System.Windows.Forms.DataGridView()
        Me.gb_buscar = New System.Windows.Forms.GroupBox()
        Me.btn_deshacer = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.lbl_socio = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_adeudos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_buscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(468, 339)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Controls.Add(Me.txt_socio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cb_estatus)
        Me.GroupBox1.Controls.Add(Me.lbl_estatus)
        Me.GroupBox1.Controls.Add(Me.txt_total_adeudo)
        Me.GroupBox1.Controls.Add(Me.lbl_total_adeudo)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 134)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles "
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_guardar.Location = New System.Drawing.Point(390, 54)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(154, 37)
        Me.btn_guardar.TabIndex = 4
        Me.btn_guardar.Text = "Pagar Adeudo"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'txt_socio
        '
        Me.txt_socio.Location = New System.Drawing.Point(141, 25)
        Me.txt_socio.Name = "txt_socio"
        Me.txt_socio.Size = New System.Drawing.Size(104, 21)
        Me.txt_socio.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Socio:"
        '
        'cb_estatus
        '
        Me.cb_estatus.FormattingEnabled = True
        Me.cb_estatus.Items.AddRange(New Object() {"Pagado", "No pagado"})
        Me.cb_estatus.Location = New System.Drawing.Point(141, 62)
        Me.cb_estatus.Name = "cb_estatus"
        Me.cb_estatus.Size = New System.Drawing.Size(163, 23)
        Me.cb_estatus.TabIndex = 5
        '
        'lbl_estatus
        '
        Me.lbl_estatus.AutoSize = True
        Me.lbl_estatus.Location = New System.Drawing.Point(82, 65)
        Me.lbl_estatus.Name = "lbl_estatus"
        Me.lbl_estatus.Size = New System.Drawing.Size(53, 15)
        Me.lbl_estatus.TabIndex = 4
        Me.lbl_estatus.Text = "Estatus:"
        '
        'txt_total_adeudo
        '
        Me.txt_total_adeudo.Location = New System.Drawing.Point(192, 98)
        Me.txt_total_adeudo.Name = "txt_total_adeudo"
        Me.txt_total_adeudo.Size = New System.Drawing.Size(112, 21)
        Me.txt_total_adeudo.TabIndex = 3
        '
        'lbl_total_adeudo
        '
        Me.lbl_total_adeudo.AutoSize = True
        Me.lbl_total_adeudo.Location = New System.Drawing.Point(82, 101)
        Me.lbl_total_adeudo.Name = "lbl_total_adeudo"
        Me.lbl_total_adeudo.Size = New System.Drawing.Size(104, 15)
        Me.lbl_total_adeudo.TabIndex = 2
        Me.lbl_total_adeudo.Text = "Total de adeudo:"
        '
        'dg_adeudos
        '
        Me.dg_adeudos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_adeudos.Location = New System.Drawing.Point(23, 163)
        Me.dg_adeudos.Name = "dg_adeudos"
        Me.dg_adeudos.Size = New System.Drawing.Size(588, 148)
        Me.dg_adeudos.TabIndex = 2
        '
        'gb_buscar
        '
        Me.gb_buscar.Controls.Add(Me.btn_deshacer)
        Me.gb_buscar.Controls.Add(Me.btn_buscar)
        Me.gb_buscar.Controls.Add(Me.txt_buscar)
        Me.gb_buscar.Controls.Add(Me.lbl_socio)
        Me.gb_buscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gb_buscar.Location = New System.Drawing.Point(23, 317)
        Me.gb_buscar.Name = "gb_buscar"
        Me.gb_buscar.Size = New System.Drawing.Size(410, 66)
        Me.gb_buscar.TabIndex = 4
        Me.gb_buscar.TabStop = False
        Me.gb_buscar.Text = "Buscar Adeudos"
        '
        'btn_deshacer
        '
        Me.btn_deshacer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_deshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deshacer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_deshacer.Location = New System.Drawing.Point(296, 22)
        Me.btn_deshacer.Name = "btn_deshacer"
        Me.btn_deshacer.Size = New System.Drawing.Size(99, 32)
        Me.btn_deshacer.TabIndex = 10
        Me.btn_deshacer.Text = "Deshacer"
        Me.btn_deshacer.UseVisualStyleBackColor = False
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_buscar.Location = New System.Drawing.Point(191, 22)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(99, 32)
        Me.btn_buscar.TabIndex = 6
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(116, 28)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(65, 21)
        Me.txt_buscar.TabIndex = 9
        '
        'lbl_socio
        '
        Me.lbl_socio.AutoSize = True
        Me.lbl_socio.Location = New System.Drawing.Point(6, 31)
        Me.lbl_socio.Name = "lbl_socio"
        Me.lbl_socio.Size = New System.Drawing.Size(108, 15)
        Me.lbl_socio.TabIndex = 0
        Me.lbl_socio.Text = "Numero de socio:"
        '
        'FormAdeudos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 395)
        Me.Controls.Add(Me.gb_buscar)
        Me.Controls.Add(Me.dg_adeudos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormAdeudos"
        Me.Text = "Cubrir Adeudo"
        Me.TopMost = True
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.dg_adeudos, 0)
        Me.Controls.SetChildIndex(Me.gb_buscar, 0)
        Me.Controls.SetChildIndex(Me.btn_salir, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg_adeudos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_buscar.ResumeLayout(False)
        Me.gb_buscar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_socio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_estatus As ComboBox
    Friend WithEvents lbl_estatus As Label
    Friend WithEvents txt_total_adeudo As TextBox
    Friend WithEvents lbl_total_adeudo As Label
    Friend WithEvents dg_adeudos As DataGridView
    Friend WithEvents gb_buscar As GroupBox
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents lbl_socio As Label
    Friend WithEvents btn_deshacer As Button
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_guardar As Button
End Class
