<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdeudos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lbl_estatus = New System.Windows.Forms.Label()
        Me.txt_total_adeudo = New System.Windows.Forms.TextBox()
        Me.lbl_total_adeudo = New System.Windows.Forms.Label()
        Me.txt_id_renta = New System.Windows.Forms.TextBox()
        Me.lbl_id_renta = New System.Windows.Forms.Label()
        Me.lbl_adeudo = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.gb_botones = New System.Windows.Forms.GroupBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.gb_buscar = New System.Windows.Forms.GroupBox()
        Me.btn_deshacer = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lbl_socio = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_botones.SuspendLayout()
        Me.gb_buscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(591, 339)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.lbl_estatus)
        Me.GroupBox1.Controls.Add(Me.txt_total_adeudo)
        Me.GroupBox1.Controls.Add(Me.lbl_total_adeudo)
        Me.GroupBox1.Controls.Add(Me.txt_id_renta)
        Me.GroupBox1.Controls.Add(Me.lbl_id_renta)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(517, 134)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(135, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 21)
        Me.TextBox1.TabIndex = 7
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
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(135, 96)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(123, 23)
        Me.ComboBox1.TabIndex = 5
        '
        'lbl_estatus
        '
        Me.lbl_estatus.AutoSize = True
        Me.lbl_estatus.Location = New System.Drawing.Point(72, 99)
        Me.lbl_estatus.Name = "lbl_estatus"
        Me.lbl_estatus.Size = New System.Drawing.Size(53, 15)
        Me.lbl_estatus.TabIndex = 4
        Me.lbl_estatus.Text = "Estatus:"
        '
        'txt_total_adeudo
        '
        Me.txt_total_adeudo.Location = New System.Drawing.Point(388, 59)
        Me.txt_total_adeudo.Name = "txt_total_adeudo"
        Me.txt_total_adeudo.Size = New System.Drawing.Size(112, 21)
        Me.txt_total_adeudo.TabIndex = 3
        '
        'lbl_total_adeudo
        '
        Me.lbl_total_adeudo.AutoSize = True
        Me.lbl_total_adeudo.Location = New System.Drawing.Point(278, 62)
        Me.lbl_total_adeudo.Name = "lbl_total_adeudo"
        Me.lbl_total_adeudo.Size = New System.Drawing.Size(104, 15)
        Me.lbl_total_adeudo.TabIndex = 2
        Me.lbl_total_adeudo.Text = "Total de adeudo:"
        '
        'txt_id_renta
        '
        Me.txt_id_renta.Location = New System.Drawing.Point(133, 59)
        Me.txt_id_renta.Name = "txt_id_renta"
        Me.txt_id_renta.Size = New System.Drawing.Size(125, 21)
        Me.txt_id_renta.TabIndex = 1
        '
        'lbl_id_renta
        '
        Me.lbl_id_renta.AutoSize = True
        Me.lbl_id_renta.Location = New System.Drawing.Point(15, 62)
        Me.lbl_id_renta.Name = "lbl_id_renta"
        Me.lbl_id_renta.Size = New System.Drawing.Size(112, 15)
        Me.lbl_id_renta.TabIndex = 0
        Me.lbl_id_renta.Text = "Numero de Renta:"
        '
        'lbl_adeudo
        '
        Me.lbl_adeudo.AutoSize = True
        Me.lbl_adeudo.Location = New System.Drawing.Point(2, 4)
        Me.lbl_adeudo.Name = "lbl_adeudo"
        Me.lbl_adeudo.Size = New System.Drawing.Size(66, 15)
        Me.lbl_adeudo.TabIndex = 0
        Me.lbl_adeudo.Text = "id_adeudo"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(698, 148)
        Me.DataGridView1.TabIndex = 2
        '
        'gb_botones
        '
        Me.gb_botones.Controls.Add(Me.Button1)
        Me.gb_botones.Controls.Add(Me.btn_guardar)
        Me.gb_botones.Controls.Add(Me.btn_eliminar)
        Me.gb_botones.Location = New System.Drawing.Point(547, 22)
        Me.gb_botones.Name = "gb_botones"
        Me.gb_botones.Size = New System.Drawing.Size(187, 134)
        Me.gb_botones.TabIndex = 3
        Me.gb_botones.TabStop = False
        Me.gb_botones.Text = "Acciones"
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_guardar.Location = New System.Drawing.Point(44, 20)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(99, 32)
        Me.btn_guardar.TabIndex = 4
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_eliminar.Location = New System.Drawing.Point(44, 58)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(99, 32)
        Me.btn_eliminar.TabIndex = 5
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'gb_buscar
        '
        Me.gb_buscar.Controls.Add(Me.btn_deshacer)
        Me.gb_buscar.Controls.Add(Me.btn_buscar)
        Me.gb_buscar.Controls.Add(Me.TextBox3)
        Me.gb_buscar.Controls.Add(Me.lbl_socio)
        Me.gb_buscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gb_buscar.Location = New System.Drawing.Point(23, 317)
        Me.gb_buscar.Name = "gb_buscar"
        Me.gb_buscar.Size = New System.Drawing.Size(517, 66)
        Me.gb_buscar.TabIndex = 4
        Me.gb_buscar.TabStop = False
        Me.gb_buscar.Text = "Buscar Adeudos"
        '
        'btn_deshacer
        '
        Me.btn_deshacer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_deshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deshacer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_deshacer.Location = New System.Drawing.Point(401, 20)
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
        Me.btn_buscar.Location = New System.Drawing.Point(281, 20)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(99, 32)
        Me.btn_buscar.TabIndex = 6
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(135, 28)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(110, 21)
        Me.TextBox3.TabIndex = 9
        '
        'lbl_socio
        '
        Me.lbl_socio.AutoSize = True
        Me.lbl_socio.Location = New System.Drawing.Point(21, 31)
        Me.lbl_socio.Name = "lbl_socio"
        Me.lbl_socio.Size = New System.Drawing.Size(108, 15)
        Me.lbl_socio.TabIndex = 0
        Me.lbl_socio.Text = "Numero de socio:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(44, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = " "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormAdeudos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 395)
        Me.Controls.Add(Me.gb_buscar)
        Me.Controls.Add(Me.gb_botones)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl_adeudo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormAdeudos"
        Me.Text = "id_adeudo"
        Me.Controls.SetChildIndex(Me.btn_salir, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.lbl_adeudo, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        Me.Controls.SetChildIndex(Me.gb_botones, 0)
        Me.Controls.SetChildIndex(Me.gb_buscar, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_botones.ResumeLayout(False)
        Me.gb_buscar.ResumeLayout(False)
        Me.gb_buscar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_adeudo As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lbl_estatus As Label
    Friend WithEvents txt_total_adeudo As TextBox
    Friend WithEvents lbl_total_adeudo As Label
    Friend WithEvents txt_id_renta As TextBox
    Friend WithEvents lbl_id_renta As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents gb_botones As GroupBox
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents gb_buscar As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lbl_socio As Label
    Friend WithEvents btn_deshacer As Button
    Friend WithEvents btn_buscar As Button
    Friend WithEvents Button1 As Button
End Class
