<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
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
        Me.gb_head = New System.Windows.Forms.GroupBox()
        Me.cmb_metodo_pago = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_buscar_cliente = New System.Windows.Forms.Button()
        Me.dt_fecha_venta = New System.Windows.Forms.DateTimePicker()
        Me.txt_nombre_cliente = New System.Windows.Forms.TextBox()
        Me.txt_id_cliente = New System.Windows.Forms.TextBox()
        Me.lbl_socio = New System.Windows.Forms.Label()
        Me.lbl_nombre_empleado = New System.Windows.Forms.Label()
        Me.lbl_le_atiende = New System.Windows.Forms.Label()
        Me.gb_datos_pelicula = New System.Windows.Forms.GroupBox()
        Me.txt_total_venta = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.dt_detalles_venta = New System.Windows.Forms.DataGridView()
        Me.ColCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_importe = New System.Windows.Forms.Label()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.txt_importe = New System.Windows.Forms.TextBox()
        Me.txt_cantidad_pelicula = New System.Windows.Forms.TextBox()
        Me.txt_precio_pelicula = New System.Windows.Forms.TextBox()
        Me.txt_nombre_pelicula = New System.Windows.Forms.TextBox()
        Me.txt_codigo_pelicula = New System.Windows.Forms.TextBox()
        Me.pc_logo = New System.Windows.Forms.PictureBox()
        Me.gb_botones = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_realizar_renta = New System.Windows.Forms.Button()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_colocar = New System.Windows.Forms.Button()
        Me.gb_head.SuspendLayout()
        Me.gb_datos_pelicula.SuspendLayout()
        CType(Me.dt_detalles_venta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pc_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(799, 474)
        '
        'gb_head
        '
        Me.gb_head.Controls.Add(Me.cmb_metodo_pago)
        Me.gb_head.Controls.Add(Me.Label1)
        Me.gb_head.Controls.Add(Me.btn_buscar_cliente)
        Me.gb_head.Controls.Add(Me.dt_fecha_venta)
        Me.gb_head.Controls.Add(Me.txt_nombre_cliente)
        Me.gb_head.Controls.Add(Me.txt_id_cliente)
        Me.gb_head.Controls.Add(Me.lbl_socio)
        Me.gb_head.Controls.Add(Me.lbl_nombre_empleado)
        Me.gb_head.Controls.Add(Me.lbl_le_atiende)
        Me.gb_head.Location = New System.Drawing.Point(12, 12)
        Me.gb_head.Name = "gb_head"
        Me.gb_head.Size = New System.Drawing.Size(677, 160)
        Me.gb_head.TabIndex = 3
        Me.gb_head.TabStop = False
        '
        'cmb_metodo_pago
        '
        Me.cmb_metodo_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_metodo_pago.FormattingEnabled = True
        Me.cmb_metodo_pago.Items.AddRange(New Object() {"Efectivo", "Tarjeta"})
        Me.cmb_metodo_pago.Location = New System.Drawing.Point(147, 125)
        Me.cmb_metodo_pago.Name = "cmb_metodo_pago"
        Me.cmb_metodo_pago.Size = New System.Drawing.Size(192, 23)
        Me.cmb_metodo_pago.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Metodo de pago:"
        '
        'btn_buscar_cliente
        '
        Me.btn_buscar_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_buscar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar_cliente.ForeColor = System.Drawing.Color.White
        Me.btn_buscar_cliente.Location = New System.Drawing.Point(466, 81)
        Me.btn_buscar_cliente.Name = "btn_buscar_cliente"
        Me.btn_buscar_cliente.Size = New System.Drawing.Size(184, 31)
        Me.btn_buscar_cliente.TabIndex = 14
        Me.btn_buscar_cliente.Text = "Buscar cliente"
        Me.btn_buscar_cliente.UseVisualStyleBackColor = False
        '
        'dt_fecha_venta
        '
        Me.dt_fecha_venta.CustomFormat = "dd MM yyyy"
        Me.dt_fecha_venta.Enabled = False
        Me.dt_fecha_venta.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_fecha_venta.Location = New System.Drawing.Point(389, 26)
        Me.dt_fecha_venta.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dt_fecha_venta.Name = "dt_fecha_venta"
        Me.dt_fecha_venta.Size = New System.Drawing.Size(272, 21)
        Me.dt_fecha_venta.TabIndex = 2
        '
        'txt_nombre_cliente
        '
        Me.txt_nombre_cliente.Location = New System.Drawing.Point(147, 86)
        Me.txt_nombre_cliente.Name = "txt_nombre_cliente"
        Me.txt_nombre_cliente.ReadOnly = True
        Me.txt_nombre_cliente.Size = New System.Drawing.Size(303, 21)
        Me.txt_nombre_cliente.TabIndex = 1
        '
        'txt_id_cliente
        '
        Me.txt_id_cliente.Location = New System.Drawing.Point(70, 86)
        Me.txt_id_cliente.Name = "txt_id_cliente"
        Me.txt_id_cliente.Size = New System.Drawing.Size(60, 21)
        Me.txt_id_cliente.TabIndex = 0
        '
        'lbl_socio
        '
        Me.lbl_socio.AutoSize = True
        Me.lbl_socio.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_socio.Location = New System.Drawing.Point(10, 89)
        Me.lbl_socio.Name = "lbl_socio"
        Me.lbl_socio.Size = New System.Drawing.Size(60, 15)
        Me.lbl_socio.TabIndex = 2
        Me.lbl_socio.Text = "Cliente:"
        '
        'lbl_nombre_empleado
        '
        Me.lbl_nombre_empleado.AutoSize = True
        Me.lbl_nombre_empleado.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_empleado.Location = New System.Drawing.Point(99, 32)
        Me.lbl_nombre_empleado.Name = "lbl_nombre_empleado"
        Me.lbl_nombre_empleado.Size = New System.Drawing.Size(128, 15)
        Me.lbl_nombre_empleado.TabIndex = 1
        Me.lbl_nombre_empleado.Text = "NombreEMPLEADO"
        '
        'lbl_le_atiende
        '
        Me.lbl_le_atiende.AutoSize = True
        Me.lbl_le_atiende.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_le_atiende.Location = New System.Drawing.Point(11, 32)
        Me.lbl_le_atiende.Name = "lbl_le_atiende"
        Me.lbl_le_atiende.Size = New System.Drawing.Size(82, 15)
        Me.lbl_le_atiende.TabIndex = 0
        Me.lbl_le_atiende.Text = "Le atiende:"
        '
        'gb_datos_pelicula
        '
        Me.gb_datos_pelicula.Controls.Add(Me.txt_total_venta)
        Me.gb_datos_pelicula.Controls.Add(Me.lbl_total)
        Me.gb_datos_pelicula.Controls.Add(Me.dt_detalles_venta)
        Me.gb_datos_pelicula.Controls.Add(Me.lbl_importe)
        Me.gb_datos_pelicula.Controls.Add(Me.lbl_cantidad)
        Me.gb_datos_pelicula.Controls.Add(Me.lbl_precio)
        Me.gb_datos_pelicula.Controls.Add(Me.lbl_nombre)
        Me.gb_datos_pelicula.Controls.Add(Me.lbl_codigo)
        Me.gb_datos_pelicula.Controls.Add(Me.txt_importe)
        Me.gb_datos_pelicula.Controls.Add(Me.txt_cantidad_pelicula)
        Me.gb_datos_pelicula.Controls.Add(Me.txt_precio_pelicula)
        Me.gb_datos_pelicula.Controls.Add(Me.txt_nombre_pelicula)
        Me.gb_datos_pelicula.Controls.Add(Me.txt_codigo_pelicula)
        Me.gb_datos_pelicula.Location = New System.Drawing.Point(12, 178)
        Me.gb_datos_pelicula.Name = "gb_datos_pelicula"
        Me.gb_datos_pelicula.Size = New System.Drawing.Size(677, 337)
        Me.gb_datos_pelicula.TabIndex = 5
        Me.gb_datos_pelicula.TabStop = False
        Me.gb_datos_pelicula.Text = "Detalles de venta"
        '
        'txt_total_venta
        '
        Me.txt_total_venta.Location = New System.Drawing.Point(566, 302)
        Me.txt_total_venta.Name = "txt_total_venta"
        Me.txt_total_venta.ReadOnly = True
        Me.txt_total_venta.Size = New System.Drawing.Size(84, 21)
        Me.txt_total_venta.TabIndex = 9
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(520, 305)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(40, 15)
        Me.lbl_total.TabIndex = 11
        Me.lbl_total.Text = "Total:"
        '
        'dt_detalles_venta
        '
        Me.dt_detalles_venta.AllowUserToAddRows = False
        Me.dt_detalles_venta.AllowUserToDeleteRows = False
        Me.dt_detalles_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_detalles_venta.ColumnHeadersVisible = False
        Me.dt_detalles_venta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColCodigo, Me.ColNombre, Me.ColPrecio, Me.ColCantidad, Me.ColImporte})
        Me.dt_detalles_venta.Location = New System.Drawing.Point(13, 92)
        Me.dt_detalles_venta.Name = "dt_detalles_venta"
        Me.dt_detalles_venta.ReadOnly = True
        Me.dt_detalles_venta.RowHeadersVisible = False
        Me.dt_detalles_venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt_detalles_venta.Size = New System.Drawing.Size(648, 196)
        Me.dt_detalles_venta.TabIndex = 10
        '
        'ColCodigo
        '
        Me.ColCodigo.HeaderText = "Nombre"
        Me.ColCodigo.Name = "ColCodigo"
        Me.ColCodigo.ReadOnly = True
        Me.ColCodigo.Width = 120
        '
        'ColNombre
        '
        Me.ColNombre.HeaderText = "Nombre"
        Me.ColNombre.Name = "ColNombre"
        Me.ColNombre.ReadOnly = True
        Me.ColNombre.Width = 215
        '
        'ColPrecio
        '
        Me.ColPrecio.HeaderText = "Precio"
        Me.ColPrecio.Name = "ColPrecio"
        Me.ColPrecio.ReadOnly = True
        Me.ColPrecio.Width = 104
        '
        'ColCantidad
        '
        Me.ColCantidad.HeaderText = "Cantidad"
        Me.ColCantidad.Name = "ColCantidad"
        Me.ColCantidad.ReadOnly = True
        Me.ColCantidad.Width = 104
        '
        'ColImporte
        '
        Me.ColImporte.HeaderText = "Importe"
        Me.ColImporte.Name = "ColImporte"
        Me.ColImporte.ReadOnly = True
        Me.ColImporte.Width = 104
        '
        'lbl_importe
        '
        Me.lbl_importe.AutoSize = True
        Me.lbl_importe.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_importe.Location = New System.Drawing.Point(574, 65)
        Me.lbl_importe.Name = "lbl_importe"
        Me.lbl_importe.Size = New System.Drawing.Size(66, 16)
        Me.lbl_importe.TabIndex = 9
        Me.lbl_importe.Text = "Importe"
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cantidad.Location = New System.Drawing.Point(474, 65)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(74, 16)
        Me.lbl_cantidad.TabIndex = 8
        Me.lbl_cantidad.Text = "Cantidad"
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio.Location = New System.Drawing.Point(376, 65)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(54, 16)
        Me.lbl_precio.TabIndex = 7
        Me.lbl_precio.Text = "Precio"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(215, 65)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(63, 16)
        Me.lbl_nombre.TabIndex = 6
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.Location = New System.Drawing.Point(40, 65)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(58, 16)
        Me.lbl_codigo.TabIndex = 5
        Me.lbl_codigo.Text = "Codigo"
        '
        'txt_importe
        '
        Me.txt_importe.Location = New System.Drawing.Point(566, 31)
        Me.txt_importe.Name = "txt_importe"
        Me.txt_importe.Size = New System.Drawing.Size(84, 21)
        Me.txt_importe.TabIndex = 8
        '
        'txt_cantidad_pelicula
        '
        Me.txt_cantidad_pelicula.Location = New System.Drawing.Point(466, 31)
        Me.txt_cantidad_pelicula.Name = "txt_cantidad_pelicula"
        Me.txt_cantidad_pelicula.Size = New System.Drawing.Size(84, 21)
        Me.txt_cantidad_pelicula.TabIndex = 7
        '
        'txt_precio_pelicula
        '
        Me.txt_precio_pelicula.Location = New System.Drawing.Point(356, 31)
        Me.txt_precio_pelicula.Name = "txt_precio_pelicula"
        Me.txt_precio_pelicula.ReadOnly = True
        Me.txt_precio_pelicula.Size = New System.Drawing.Size(94, 21)
        Me.txt_precio_pelicula.TabIndex = 6
        '
        'txt_nombre_pelicula
        '
        Me.txt_nombre_pelicula.Location = New System.Drawing.Point(147, 31)
        Me.txt_nombre_pelicula.Name = "txt_nombre_pelicula"
        Me.txt_nombre_pelicula.ReadOnly = True
        Me.txt_nombre_pelicula.Size = New System.Drawing.Size(192, 21)
        Me.txt_nombre_pelicula.TabIndex = 5
        '
        'txt_codigo_pelicula
        '
        Me.txt_codigo_pelicula.Location = New System.Drawing.Point(14, 31)
        Me.txt_codigo_pelicula.Name = "txt_codigo_pelicula"
        Me.txt_codigo_pelicula.Size = New System.Drawing.Size(116, 21)
        Me.txt_codigo_pelicula.TabIndex = 4
        '
        'pc_logo
        '
        Me.pc_logo.Image = Global.SistemaVideoclub.My.Resources.Resources.logo
        Me.pc_logo.Location = New System.Drawing.Point(721, 22)
        Me.pc_logo.Name = "pc_logo"
        Me.pc_logo.Size = New System.Drawing.Size(235, 150)
        Me.pc_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pc_logo.TabIndex = 6
        Me.pc_logo.TabStop = False
        '
        'gb_botones
        '
        Me.gb_botones.Controls.Add(Me.btn_cancelar)
        Me.gb_botones.Controls.Add(Me.btn_realizar_renta)
        Me.gb_botones.Controls.Add(Me.btn_quitar)
        Me.gb_botones.Controls.Add(Me.btn_colocar)
        Me.gb_botones.Location = New System.Drawing.Point(721, 178)
        Me.gb_botones.Name = "gb_botones"
        Me.gb_botones.Size = New System.Drawing.Size(235, 288)
        Me.gb_botones.TabIndex = 7
        Me.gb_botones.TabStop = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.Location = New System.Drawing.Point(78, 232)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(99, 31)
        Me.btn_cancelar.TabIndex = 13
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_realizar_renta
        '
        Me.btn_realizar_renta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_realizar_renta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_realizar_renta.ForeColor = System.Drawing.Color.White
        Me.btn_realizar_renta.Location = New System.Drawing.Point(54, 145)
        Me.btn_realizar_renta.Name = "btn_realizar_renta"
        Me.btn_realizar_renta.Size = New System.Drawing.Size(151, 48)
        Me.btn_realizar_renta.TabIndex = 12
        Me.btn_realizar_renta.Text = "Realizar Venta"
        Me.btn_realizar_renta.UseVisualStyleBackColor = False
        '
        'btn_quitar
        '
        Me.btn_quitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_quitar.ForeColor = System.Drawing.Color.White
        Me.btn_quitar.Location = New System.Drawing.Point(78, 81)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(99, 31)
        Me.btn_quitar.TabIndex = 11
        Me.btn_quitar.Text = "Quitar"
        Me.btn_quitar.UseVisualStyleBackColor = False
        '
        'btn_colocar
        '
        Me.btn_colocar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_colocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_colocar.ForeColor = System.Drawing.Color.White
        Me.btn_colocar.Location = New System.Drawing.Point(78, 26)
        Me.btn_colocar.Name = "btn_colocar"
        Me.btn_colocar.Size = New System.Drawing.Size(99, 31)
        Me.btn_colocar.TabIndex = 10
        Me.btn_colocar.Text = "Colocar"
        Me.btn_colocar.UseVisualStyleBackColor = False
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 530)
        Me.Controls.Add(Me.gb_botones)
        Me.Controls.Add(Me.pc_logo)
        Me.Controls.Add(Me.gb_datos_pelicula)
        Me.Controls.Add(Me.gb_head)
        Me.Name = "FormVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Venta"
        Me.TopMost = True
        Me.Controls.SetChildIndex(Me.btn_salir, 0)
        Me.Controls.SetChildIndex(Me.gb_head, 0)
        Me.Controls.SetChildIndex(Me.gb_datos_pelicula, 0)
        Me.Controls.SetChildIndex(Me.pc_logo, 0)
        Me.Controls.SetChildIndex(Me.gb_botones, 0)
        Me.gb_head.ResumeLayout(False)
        Me.gb_head.PerformLayout()
        Me.gb_datos_pelicula.ResumeLayout(False)
        Me.gb_datos_pelicula.PerformLayout()
        CType(Me.dt_detalles_venta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pc_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_head As GroupBox
    Friend WithEvents dt_fecha_venta As DateTimePicker
    Friend WithEvents txt_nombre_cliente As TextBox
    Friend WithEvents txt_id_cliente As TextBox
    Friend WithEvents lbl_socio As Label
    Friend WithEvents lbl_nombre_empleado As Label
    Friend WithEvents lbl_le_atiende As Label
    Friend WithEvents gb_datos_pelicula As GroupBox
    Friend WithEvents txt_total_venta As TextBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents dt_detalles_venta As DataGridView
    Friend WithEvents lbl_importe As Label
    Friend WithEvents lbl_cantidad As Label
    Friend WithEvents lbl_precio As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_codigo As Label
    Friend WithEvents txt_importe As TextBox
    Friend WithEvents txt_cantidad_pelicula As TextBox
    Friend WithEvents txt_precio_pelicula As TextBox
    Friend WithEvents txt_nombre_pelicula As TextBox
    Friend WithEvents txt_codigo_pelicula As TextBox
    Friend WithEvents pc_logo As PictureBox
    Friend WithEvents gb_botones As GroupBox
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_realizar_renta As Button
    Friend WithEvents btn_quitar As Button
    Friend WithEvents btn_colocar As Button
    Friend WithEvents btn_buscar_cliente As Button
    Friend WithEvents ColCodigo As DataGridViewTextBoxColumn
    Friend WithEvents ColNombre As DataGridViewTextBoxColumn
    Friend WithEvents ColPrecio As DataGridViewTextBoxColumn
    Friend WithEvents ColCantidad As DataGridViewTextBoxColumn
    Friend WithEvents ColImporte As DataGridViewTextBoxColumn
    Friend WithEvents cmb_metodo_pago As ComboBox
    Friend WithEvents Label1 As Label
End Class
