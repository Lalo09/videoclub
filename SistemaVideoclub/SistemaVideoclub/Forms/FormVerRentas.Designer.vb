<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVerRentas
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
        Me.gb_cabecera = New System.Windows.Forms.GroupBox()
        Me.dt_hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_desde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.rb_por_socio = New System.Windows.Forms.RadioButton()
        Me.rb_por_renta = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg_rentas = New System.Windows.Forms.DataGridView()
        Me.btn_deshacer = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gb_cabecera.SuspendLayout()
        CType(Me.dg_rentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salir.Location = New System.Drawing.Point(633, 422)
        '
        'gb_cabecera
        '
        Me.gb_cabecera.Controls.Add(Me.dt_hasta)
        Me.gb_cabecera.Controls.Add(Me.Label3)
        Me.gb_cabecera.Controls.Add(Me.dt_desde)
        Me.gb_cabecera.Controls.Add(Me.Label2)
        Me.gb_cabecera.Controls.Add(Me.btn_buscar)
        Me.gb_cabecera.Controls.Add(Me.txt_buscar)
        Me.gb_cabecera.Controls.Add(Me.rb_por_socio)
        Me.gb_cabecera.Controls.Add(Me.rb_por_renta)
        Me.gb_cabecera.Controls.Add(Me.Label1)
        Me.gb_cabecera.Location = New System.Drawing.Point(12, 12)
        Me.gb_cabecera.Name = "gb_cabecera"
        Me.gb_cabecera.Size = New System.Drawing.Size(731, 156)
        Me.gb_cabecera.TabIndex = 1
        Me.gb_cabecera.TabStop = False
        '
        'dt_hasta
        '
        Me.dt_hasta.CustomFormat = "dd MM yyyy"
        Me.dt_hasta.Location = New System.Drawing.Point(281, 118)
        Me.dt_hasta.Name = "dt_hasta"
        Me.dt_hasta.Size = New System.Drawing.Size(200, 21)
        Me.dt_hasta.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "a"
        '
        'dt_desde
        '
        Me.dt_desde.CustomFormat = "dd MM yyyy"
        Me.dt_desde.Location = New System.Drawing.Point(25, 118)
        Me.dt_desde.Name = "dt_desde"
        Me.dt_desde.Size = New System.Drawing.Size(200, 21)
        Me.dt_desde.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Entre las fechas:"
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_buscar.Location = New System.Drawing.Point(510, 114)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(99, 32)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(278, 45)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(203, 21)
        Me.txt_buscar.TabIndex = 3
        '
        'rb_por_socio
        '
        Me.rb_por_socio.AutoSize = True
        Me.rb_por_socio.Location = New System.Drawing.Point(150, 45)
        Me.rb_por_socio.Name = "rb_por_socio"
        Me.rb_por_socio.Size = New System.Drawing.Size(121, 19)
        Me.rb_por_socio.TabIndex = 2
        Me.rb_por_socio.TabStop = True
        Me.rb_por_socio.Text = "Numero de socio"
        Me.rb_por_socio.UseVisualStyleBackColor = True
        '
        'rb_por_renta
        '
        Me.rb_por_renta.AutoSize = True
        Me.rb_por_renta.Location = New System.Drawing.Point(22, 45)
        Me.rb_por_renta.Name = "rb_por_renta"
        Me.rb_por_renta.Size = New System.Drawing.Size(122, 19)
        Me.rb_por_renta.TabIndex = 1
        Me.rb_por_renta.TabStop = True
        Me.rb_por_renta.Text = "Numero de renta"
        Me.rb_por_renta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar por:"
        '
        'dg_rentas
        '
        Me.dg_rentas.AllowUserToAddRows = False
        Me.dg_rentas.AllowUserToDeleteRows = False
        Me.dg_rentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_rentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_rentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_rentas.Location = New System.Drawing.Point(13, 185)
        Me.dg_rentas.Name = "dg_rentas"
        Me.dg_rentas.ReadOnly = True
        Me.dg_rentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_rentas.Size = New System.Drawing.Size(730, 216)
        Me.dg_rentas.TabIndex = 2
        '
        'btn_deshacer
        '
        Me.btn_deshacer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_deshacer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_deshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deshacer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_deshacer.Location = New System.Drawing.Point(17, 416)
        Me.btn_deshacer.Name = "btn_deshacer"
        Me.btn_deshacer.Size = New System.Drawing.Size(120, 45)
        Me.btn_deshacer.TabIndex = 6
        Me.btn_deshacer.Text = "Deshacer busqueda"
        Me.btn_deshacer.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(143, 416)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 45)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Eliminar Renta"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FormVerRentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 475)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_deshacer)
        Me.Controls.Add(Me.dg_rentas)
        Me.Controls.Add(Me.gb_cabecera)
        Me.MaximizeBox = True
        Me.Name = "FormVerRentas"
        Me.Text = "FormVerRentas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.btn_salir, 0)
        Me.Controls.SetChildIndex(Me.gb_cabecera, 0)
        Me.Controls.SetChildIndex(Me.dg_rentas, 0)
        Me.Controls.SetChildIndex(Me.btn_deshacer, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.gb_cabecera.ResumeLayout(False)
        Me.gb_cabecera.PerformLayout()
        CType(Me.dg_rentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_cabecera As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rb_por_socio As RadioButton
    Friend WithEvents rb_por_renta As RadioButton
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents dt_hasta As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dt_desde As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents dg_rentas As DataGridView
    Friend WithEvents btn_deshacer As Button
    Friend WithEvents Button2 As Button
End Class
