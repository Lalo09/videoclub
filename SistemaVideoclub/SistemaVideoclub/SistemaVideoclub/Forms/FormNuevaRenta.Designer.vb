<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevaRenta
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
        Me.lbl_id_renta = New System.Windows.Forms.Label()
        Me.gb_head = New System.Windows.Forms.GroupBox()
        Me.dt_fecha_devolucion = New System.Windows.Forms.DateTimePicker()
        Me.lbl_fecha_entrega = New System.Windows.Forms.Label()
        Me.dt_fecha_renta = New System.Windows.Forms.DateTimePicker()
        Me.txt_nombre_socio = New System.Windows.Forms.TextBox()
        Me.txt_id_socio = New System.Windows.Forms.TextBox()
        Me.lbl_socio = New System.Windows.Forms.Label()
        Me.lbl_nombre_empleado = New System.Windows.Forms.Label()
        Me.lbl_le_atiende = New System.Windows.Forms.Label()
        Me.pc_logo = New System.Windows.Forms.PictureBox()
        Me.gb_datos_pelicula = New System.Windows.Forms.GroupBox()
        Me.txt_total_renta = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.dt_detalles_renta = New System.Windows.Forms.DataGridView()
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
        Me.gb_botones = New System.Windows.Forms.GroupBox()
        Me.btn_nueva_renta = New System.Windows.Forms.Button()
        Me.btn_realizar_renta = New System.Windows.Forms.Button()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_colocar = New System.Windows.Forms.Button()
        Me.gb_head.SuspendLayout()
        CType(Me.pc_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_datos_pelicula.SuspendLayout()
        CType(Me.dt_detalles_renta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(792, 486)
        Me.btn_salir.TabIndex = 14
        '
        'lbl_id_renta
        '
        Me.lbl_id_renta.AutoSize = True
        Me.lbl_id_renta.Location = New System.Drawing.Point(0, 0)
        Me.lbl_id_renta.Name = "lbl_id_renta"
        Me.lbl_id_renta.Size = New System.Drawing.Size(54, 15)
        Me.lbl_id_renta.TabIndex = 1
        Me.lbl_id_renta.Text = "id_renta"
        Me.lbl_id_renta.Visible = False
        '
        'gb_head
        '
        Me.gb_head.Controls.Add(Me.dt_fecha_devolucion)
        Me.gb_head.Controls.Add(Me.lbl_fecha_entrega)
        Me.gb_head.Controls.Add(Me.dt_fecha_renta)
        Me.gb_head.Controls.Add(Me.txt_nombre_socio)
        Me.gb_head.Controls.Add(Me.txt_id_socio)
        Me.gb_head.Controls.Add(Me.lbl_socio)
        Me.gb_head.Controls.Add(Me.lbl_nombre_empleado)
        Me.gb_head.Controls.Add(Me.lbl_le_atiende)
        Me.gb_head.Location = New System.Drawing.Point(15, 18)
        Me.gb_head.Name = "gb_head"
        Me.gb_head.Size = New System.Drawing.Size(677, 147)
        Me.gb_head.TabIndex = 2
        Me.gb_head.TabStop = False
        '
        'dt_fecha_devolucion
        '
        Me.dt_fecha_devolucion.Location = New System.Drawing.Point(147, 107)
        Me.dt_fecha_devolucion.Name = "dt_fecha_devolucion"
        Me.dt_fecha_devolucion.Size = New System.Drawing.Size(243, 21)
        Me.dt_fecha_devolucion.TabIndex = 3
        '
        'lbl_fecha_entrega
        '
        Me.lbl_fecha_entrega.AutoSize = True
        Me.lbl_fecha_entrega.Location = New System.Drawing.Point(11, 112)
        Me.lbl_fecha_entrega.Name = "lbl_fecha_entrega"
        Me.lbl_fecha_entrega.Size = New System.Drawing.Size(128, 15)
        Me.lbl_fecha_entrega.TabIndex = 6
        Me.lbl_fecha_entrega.Text = "Fecha de devolucion:"
        '
        'dt_fecha_renta
        '
        Me.dt_fecha_renta.Location = New System.Drawing.Point(244, 20)
        Me.dt_fecha_renta.Name = "dt_fecha_renta"
        Me.dt_fecha_renta.Size = New System.Drawing.Size(254, 21)
        Me.dt_fecha_renta.TabIndex = 2
        '
        'txt_nombre_socio
        '
        Me.txt_nombre_socio.Location = New System.Drawing.Point(147, 69)
        Me.txt_nombre_socio.Name = "txt_nombre_socio"
        Me.txt_nombre_socio.ReadOnly = True
        Me.txt_nombre_socio.Size = New System.Drawing.Size(351, 21)
        Me.txt_nombre_socio.TabIndex = 1
        '
        'txt_id_socio
        '
        Me.txt_id_socio.Location = New System.Drawing.Point(59, 69)
        Me.txt_id_socio.Name = "txt_id_socio"
        Me.txt_id_socio.Size = New System.Drawing.Size(71, 21)
        Me.txt_id_socio.TabIndex = 0
        '
        'lbl_socio
        '
        Me.lbl_socio.AutoSize = True
        Me.lbl_socio.Location = New System.Drawing.Point(10, 72)
        Me.lbl_socio.Name = "lbl_socio"
        Me.lbl_socio.Size = New System.Drawing.Size(43, 15)
        Me.lbl_socio.TabIndex = 2
        Me.lbl_socio.Text = "Socio:"
        '
        'lbl_nombre_empleado
        '
        Me.lbl_nombre_empleado.AutoSize = True
        Me.lbl_nombre_empleado.Location = New System.Drawing.Point(88, 21)
        Me.lbl_nombre_empleado.Name = "lbl_nombre_empleado"
        Me.lbl_nombre_empleado.Size = New System.Drawing.Size(114, 15)
        Me.lbl_nombre_empleado.TabIndex = 1
        Me.lbl_nombre_empleado.Text = "NombreEMPLEADO"
        '
        'lbl_le_atiende
        '
        Me.lbl_le_atiende.AutoSize = True
        Me.lbl_le_atiende.Location = New System.Drawing.Point(11, 21)
        Me.lbl_le_atiende.Name = "lbl_le_atiende"
        Me.lbl_le_atiende.Size = New System.Drawing.Size(71, 15)
        Me.lbl_le_atiende.TabIndex = 0
        Me.lbl_le_atiende.Text = "Le atiende:"
        '
        'pc_logo
        '
        Me.pc_logo.Image = Global.SistemaVideoclub.My.Resources.Resources.logo
        Me.pc_logo.Location = New System.Drawing.Point(714, 27)
        Me.pc_logo.Name = "pc_logo"
        Me.pc_logo.Size = New System.Drawing.Size(235, 138)
        Me.pc_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pc_logo.TabIndex = 3
        Me.pc_logo.TabStop = False
        '
        'gb_datos_pelicula
        '
        Me.gb_datos_pelicula.Controls.Add(Me.txt_total_renta)
        Me.gb_datos_pelicula.Controls.Add(Me.lbl_total)
        Me.gb_datos_pelicula.Controls.Add(Me.dt_detalles_renta)
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
        Me.gb_datos_pelicula.Location = New System.Drawing.Point(15, 181)
        Me.gb_datos_pelicula.Name = "gb_datos_pelicula"
        Me.gb_datos_pelicula.Size = New System.Drawing.Size(677, 337)
        Me.gb_datos_pelicula.TabIndex = 4
        Me.gb_datos_pelicula.TabStop = False
        Me.gb_datos_pelicula.Text = "Detalles de renta"
        '
        'txt_total_renta
        '
        Me.txt_total_renta.Location = New System.Drawing.Point(577, 302)
        Me.txt_total_renta.Name = "txt_total_renta"
        Me.txt_total_renta.ReadOnly = True
        Me.txt_total_renta.Size = New System.Drawing.Size(84, 21)
        Me.txt_total_renta.TabIndex = 9
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(531, 305)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(40, 15)
        Me.lbl_total.TabIndex = 11
        Me.lbl_total.Text = "Total:"
        '
        'dt_detalles_renta
        '
        Me.dt_detalles_renta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_detalles_renta.Location = New System.Drawing.Point(13, 92)
        Me.dt_detalles_renta.Name = "dt_detalles_renta"
        Me.dt_detalles_renta.Size = New System.Drawing.Size(648, 196)
        Me.dt_detalles_renta.TabIndex = 10
        '
        'lbl_importe
        '
        Me.lbl_importe.AutoSize = True
        Me.lbl_importe.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_importe.Location = New System.Drawing.Point(590, 65)
        Me.lbl_importe.Name = "lbl_importe"
        Me.lbl_importe.Size = New System.Drawing.Size(60, 15)
        Me.lbl_importe.TabIndex = 9
        Me.lbl_importe.Text = "Importe"
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cantidad.Location = New System.Drawing.Point(476, 65)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(66, 15)
        Me.lbl_cantidad.TabIndex = 8
        Me.lbl_cantidad.Text = "Cantidad"
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio.Location = New System.Drawing.Point(372, 65)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(48, 15)
        Me.lbl_precio.TabIndex = 7
        Me.lbl_precio.Text = "Precio"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(220, 65)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(58, 15)
        Me.lbl_nombre.TabIndex = 6
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.Location = New System.Drawing.Point(40, 65)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(53, 15)
        Me.lbl_codigo.TabIndex = 5
        Me.lbl_codigo.Text = "Codigo"
        '
        'txt_importe
        '
        Me.txt_importe.Location = New System.Drawing.Point(577, 31)
        Me.txt_importe.Name = "txt_importe"
        Me.txt_importe.ReadOnly = True
        Me.txt_importe.Size = New System.Drawing.Size(84, 21)
        Me.txt_importe.TabIndex = 8
        '
        'txt_cantidad_pelicula
        '
        Me.txt_cantidad_pelicula.Location = New System.Drawing.Point(467, 31)
        Me.txt_cantidad_pelicula.Name = "txt_cantidad_pelicula"
        Me.txt_cantidad_pelicula.Size = New System.Drawing.Size(84, 21)
        Me.txt_cantidad_pelicula.TabIndex = 7
        '
        'txt_precio_pelicula
        '
        Me.txt_precio_pelicula.Location = New System.Drawing.Point(356, 31)
        Me.txt_precio_pelicula.Name = "txt_precio_pelicula"
        Me.txt_precio_pelicula.ReadOnly = True
        Me.txt_precio_pelicula.Size = New System.Drawing.Size(84, 21)
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
        'gb_botones
        '
        Me.gb_botones.Controls.Add(Me.btn_nueva_renta)
        Me.gb_botones.Controls.Add(Me.btn_realizar_renta)
        Me.gb_botones.Controls.Add(Me.btn_quitar)
        Me.gb_botones.Controls.Add(Me.btn_colocar)
        Me.gb_botones.Location = New System.Drawing.Point(714, 181)
        Me.gb_botones.Name = "gb_botones"
        Me.gb_botones.Size = New System.Drawing.Size(235, 288)
        Me.gb_botones.TabIndex = 5
        Me.gb_botones.TabStop = False
        '
        'btn_nueva_renta
        '
        Me.btn_nueva_renta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_nueva_renta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nueva_renta.ForeColor = System.Drawing.Color.White
        Me.btn_nueva_renta.Location = New System.Drawing.Point(78, 231)
        Me.btn_nueva_renta.Name = "btn_nueva_renta"
        Me.btn_nueva_renta.Size = New System.Drawing.Size(99, 31)
        Me.btn_nueva_renta.TabIndex = 13
        Me.btn_nueva_renta.Text = "Nueva Renta"
        Me.btn_nueva_renta.UseVisualStyleBackColor = False
        '
        'btn_realizar_renta
        '
        Me.btn_realizar_renta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_realizar_renta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_realizar_renta.ForeColor = System.Drawing.Color.White
        Me.btn_realizar_renta.Location = New System.Drawing.Point(54, 150)
        Me.btn_realizar_renta.Name = "btn_realizar_renta"
        Me.btn_realizar_renta.Size = New System.Drawing.Size(151, 48)
        Me.btn_realizar_renta.TabIndex = 12
        Me.btn_realizar_renta.Text = "Realizar Renta"
        Me.btn_realizar_renta.UseVisualStyleBackColor = False
        '
        'btn_quitar
        '
        Me.btn_quitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_quitar.ForeColor = System.Drawing.Color.White
        Me.btn_quitar.Location = New System.Drawing.Point(78, 92)
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
        Me.btn_colocar.Location = New System.Drawing.Point(78, 31)
        Me.btn_colocar.Name = "btn_colocar"
        Me.btn_colocar.Size = New System.Drawing.Size(99, 31)
        Me.btn_colocar.TabIndex = 10
        Me.btn_colocar.Text = "Colocar"
        Me.btn_colocar.UseVisualStyleBackColor = False
        '
        'FormNuevaRenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 530)
        Me.Controls.Add(Me.gb_botones)
        Me.Controls.Add(Me.gb_datos_pelicula)
        Me.Controls.Add(Me.pc_logo)
        Me.Controls.Add(Me.gb_head)
        Me.Controls.Add(Me.lbl_id_renta)
        Me.Name = "FormNuevaRenta"
        Me.Text = "Realizar renta"
        Me.Controls.SetChildIndex(Me.lbl_id_renta, 0)
        Me.Controls.SetChildIndex(Me.gb_head, 0)
        Me.Controls.SetChildIndex(Me.pc_logo, 0)
        Me.Controls.SetChildIndex(Me.btn_salir, 0)
        Me.Controls.SetChildIndex(Me.gb_datos_pelicula, 0)
        Me.Controls.SetChildIndex(Me.gb_botones, 0)
        Me.gb_head.ResumeLayout(False)
        Me.gb_head.PerformLayout()
        CType(Me.pc_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_datos_pelicula.ResumeLayout(False)
        Me.gb_datos_pelicula.PerformLayout()
        CType(Me.dt_detalles_renta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_botones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_id_renta As Label
    Friend WithEvents gb_head As GroupBox
    Friend WithEvents pc_logo As PictureBox
    Friend WithEvents dt_fecha_devolucion As DateTimePicker
    Friend WithEvents lbl_fecha_entrega As Label
    Friend WithEvents dt_fecha_renta As DateTimePicker
    Friend WithEvents txt_nombre_socio As TextBox
    Friend WithEvents txt_id_socio As TextBox
    Friend WithEvents lbl_socio As Label
    Friend WithEvents lbl_nombre_empleado As Label
    Friend WithEvents lbl_le_atiende As Label
    Friend WithEvents gb_datos_pelicula As GroupBox
    Friend WithEvents txt_total_renta As TextBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents dt_detalles_renta As DataGridView
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
    Friend WithEvents gb_botones As GroupBox
    Friend WithEvents btn_nueva_renta As Button
    Friend WithEvents btn_realizar_renta As Button
    Friend WithEvents btn_quitar As Button
    Friend WithEvents btn_colocar As Button
End Class
