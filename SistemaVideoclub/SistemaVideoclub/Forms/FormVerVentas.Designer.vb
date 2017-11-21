<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVerVentas
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
        Me.cb_solofechas = New System.Windows.Forms.CheckBox()
        Me.dt_fin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.rb_por_cliente = New System.Windows.Forms.RadioButton()
        Me.rb_por_venta = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg_ventas = New System.Windows.Forms.DataGridView()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_deshacer = New System.Windows.Forms.Button()
        Me.lbl_id_venta = New System.Windows.Forms.Label()
        Me.gb_cabecera.SuspendLayout()
        CType(Me.dg_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(644, 416)
        '
        'gb_cabecera
        '
        Me.gb_cabecera.Controls.Add(Me.cb_solofechas)
        Me.gb_cabecera.Controls.Add(Me.dt_fin)
        Me.gb_cabecera.Controls.Add(Me.Label3)
        Me.gb_cabecera.Controls.Add(Me.dt_inicio)
        Me.gb_cabecera.Controls.Add(Me.Label2)
        Me.gb_cabecera.Controls.Add(Me.btn_buscar)
        Me.gb_cabecera.Controls.Add(Me.txt_buscar)
        Me.gb_cabecera.Controls.Add(Me.rb_por_cliente)
        Me.gb_cabecera.Controls.Add(Me.rb_por_venta)
        Me.gb_cabecera.Controls.Add(Me.Label1)
        Me.gb_cabecera.Location = New System.Drawing.Point(12, 12)
        Me.gb_cabecera.Name = "gb_cabecera"
        Me.gb_cabecera.Size = New System.Drawing.Size(731, 156)
        Me.gb_cabecera.TabIndex = 2
        Me.gb_cabecera.TabStop = False
        '
        'cb_solofechas
        '
        Me.cb_solofechas.AutoSize = True
        Me.cb_solofechas.Location = New System.Drawing.Point(536, 87)
        Me.cb_solofechas.Name = "cb_solofechas"
        Me.cb_solofechas.Size = New System.Drawing.Size(156, 19)
        Me.cb_solofechas.TabIndex = 8
        Me.cb_solofechas.Text = "Buscar solo por fechas"
        Me.cb_solofechas.UseVisualStyleBackColor = True
        '
        'dt_fin
        '
        Me.dt_fin.CustomFormat = "dd MM yyyy"
        Me.dt_fin.Location = New System.Drawing.Point(288, 117)
        Me.dt_fin.Name = "dt_fin"
        Me.dt_fin.Size = New System.Drawing.Size(200, 21)
        Me.dt_fin.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(250, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "A"
        '
        'dt_inicio
        '
        Me.dt_inicio.CustomFormat = "dd MM yyyy"
        Me.dt_inicio.Location = New System.Drawing.Point(25, 118)
        Me.dt_inicio.Name = "dt_inicio"
        Me.dt_inicio.Size = New System.Drawing.Size(200, 21)
        Me.dt_inicio.TabIndex = 5
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
        Me.btn_buscar.Location = New System.Drawing.Point(560, 112)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(99, 32)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(288, 45)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(203, 21)
        Me.txt_buscar.TabIndex = 3
        '
        'rb_por_cliente
        '
        Me.rb_por_cliente.AutoSize = True
        Me.rb_por_cliente.Location = New System.Drawing.Point(150, 45)
        Me.rb_por_cliente.Name = "rb_por_cliente"
        Me.rb_por_cliente.Size = New System.Drawing.Size(132, 19)
        Me.rb_por_cliente.TabIndex = 2
        Me.rb_por_cliente.TabStop = True
        Me.rb_por_cliente.Text = "Numero de Cliente"
        Me.rb_por_cliente.UseVisualStyleBackColor = True
        '
        'rb_por_venta
        '
        Me.rb_por_venta.AutoSize = True
        Me.rb_por_venta.Location = New System.Drawing.Point(22, 45)
        Me.rb_por_venta.Name = "rb_por_venta"
        Me.rb_por_venta.Size = New System.Drawing.Size(125, 19)
        Me.rb_por_venta.TabIndex = 1
        Me.rb_por_venta.TabStop = True
        Me.rb_por_venta.Text = "Numero de Venta"
        Me.rb_por_venta.UseVisualStyleBackColor = True
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
        'dg_ventas
        '
        Me.dg_ventas.AllowUserToAddRows = False
        Me.dg_ventas.AllowUserToDeleteRows = False
        Me.dg_ventas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_ventas.Location = New System.Drawing.Point(12, 174)
        Me.dg_ventas.Name = "dg_ventas"
        Me.dg_ventas.ReadOnly = True
        Me.dg_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_ventas.Size = New System.Drawing.Size(731, 216)
        Me.dg_ventas.TabIndex = 3
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_eliminar.Location = New System.Drawing.Point(138, 410)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(120, 45)
        Me.btn_eliminar.TabIndex = 9
        Me.btn_eliminar.Text = "Eliminar Venta"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_deshacer
        '
        Me.btn_deshacer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_deshacer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_deshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deshacer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_deshacer.Location = New System.Drawing.Point(12, 410)
        Me.btn_deshacer.Name = "btn_deshacer"
        Me.btn_deshacer.Size = New System.Drawing.Size(120, 45)
        Me.btn_deshacer.TabIndex = 8
        Me.btn_deshacer.Text = "Deshacer busqueda"
        Me.btn_deshacer.UseVisualStyleBackColor = False
        '
        'lbl_id_venta
        '
        Me.lbl_id_venta.AutoSize = True
        Me.lbl_id_venta.Location = New System.Drawing.Point(12, -1)
        Me.lbl_id_venta.Name = "lbl_id_venta"
        Me.lbl_id_venta.Size = New System.Drawing.Size(44, 15)
        Me.lbl_id_venta.TabIndex = 10
        Me.lbl_id_venta.Text = "Label4"
        '
        'FormVerVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 475)
        Me.Controls.Add(Me.lbl_id_venta)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_deshacer)
        Me.Controls.Add(Me.dg_ventas)
        Me.Controls.Add(Me.gb_cabecera)
        Me.MaximizeBox = True
        Me.Name = "FormVerVentas"
        Me.Text = "Ver Ventas"
        Me.TopMost = True
        Me.Controls.SetChildIndex(Me.btn_salir, 0)
        Me.Controls.SetChildIndex(Me.gb_cabecera, 0)
        Me.Controls.SetChildIndex(Me.dg_ventas, 0)
        Me.Controls.SetChildIndex(Me.btn_deshacer, 0)
        Me.Controls.SetChildIndex(Me.btn_eliminar, 0)
        Me.Controls.SetChildIndex(Me.lbl_id_venta, 0)
        Me.gb_cabecera.ResumeLayout(False)
        Me.gb_cabecera.PerformLayout()
        CType(Me.dg_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gb_cabecera As GroupBox
    Friend WithEvents dt_fin As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dt_inicio As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents rb_por_cliente As RadioButton
    Friend WithEvents rb_por_venta As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents dg_ventas As DataGridView
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_deshacer As Button
    Friend WithEvents lbl_id_venta As Label
    Friend WithEvents cb_solofechas As CheckBox
End Class
