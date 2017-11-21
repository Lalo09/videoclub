<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSocios
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
        Me.lbl_idSocio = New System.Windows.Forms.Label()
        Me.lbl_idCliente = New System.Windows.Forms.Label()
        Me.gb_datos_del_cliente = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.rb_masculino = New System.Windows.Forms.RadioButton()
        Me.rb_femenino = New System.Windows.Forms.RadioButton()
        Me.lbl_sexo = New System.Windows.Forms.Label()
        Me.txt_ap_materno = New System.Windows.Forms.TextBox()
        Me.txt_ap_paterno = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_ap_materno = New System.Windows.Forms.Label()
        Me.lbl_ap_paterno = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.gb_datosContacto = New System.Windows.Forms.GroupBox()
        Me.txt_pais = New System.Windows.Forms.TextBox()
        Me.lbl_pais = New System.Windows.Forms.Label()
        Me.txt_ciudad = New System.Windows.Forms.TextBox()
        Me.lbl_ciudad = New System.Windows.Forms.Label()
        Me.txt_colonia = New System.Windows.Forms.TextBox()
        Me.lbl_colonia = New System.Windows.Forms.Label()
        Me.txt_numInt = New System.Windows.Forms.TextBox()
        Me.lbl_num_int = New System.Windows.Forms.Label()
        Me.txt_num_ext = New System.Windows.Forms.TextBox()
        Me.lbl_num_ext = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.gb_fechas = New System.Windows.Forms.GroupBox()
        Me.btn_dar_de_baja = New System.Windows.Forms.Button()
        Me.dt_ven = New System.Windows.Forms.DateTimePicker()
        Me.lbl_fecha_ven = New System.Windows.Forms.Label()
        Me.dt_exp = New System.Windows.Forms.DateTimePicker()
        Me.lbl_fecha_ex = New System.Windows.Forms.Label()
        Me.gb_foto = New System.Windows.Forms.GroupBox()
        Me.btn_eliminar_foto = New System.Windows.Forms.Button()
        Me.btn_cargar_foto = New System.Windows.Forms.Button()
        Me.pb_foto_cliente = New System.Windows.Forms.PictureBox()
        Me.gb_acciones = New System.Windows.Forms.GroupBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_generar_credencial = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.ofd_foto = New System.Windows.Forms.OpenFileDialog()
        Me.gb_datos_del_cliente.SuspendLayout()
        Me.gb_datosContacto.SuspendLayout()
        Me.gb_fechas.SuspendLayout()
        Me.gb_foto.SuspendLayout()
        CType(Me.pb_foto_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_acciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_salir.Location = New System.Drawing.Point(851, 484)
        Me.btn_salir.Size = New System.Drawing.Size(103, 32)
        Me.btn_salir.TabIndex = 22
        '
        'lbl_idSocio
        '
        Me.lbl_idSocio.AutoSize = True
        Me.lbl_idSocio.Location = New System.Drawing.Point(173, 27)
        Me.lbl_idSocio.Name = "lbl_idSocio"
        Me.lbl_idSocio.Size = New System.Drawing.Size(0, 15)
        Me.lbl_idSocio.TabIndex = 1
        '
        'lbl_idCliente
        '
        Me.lbl_idCliente.AutoSize = True
        Me.lbl_idCliente.Location = New System.Drawing.Point(496, 27)
        Me.lbl_idCliente.Name = "lbl_idCliente"
        Me.lbl_idCliente.Size = New System.Drawing.Size(61, 15)
        Me.lbl_idCliente.TabIndex = 2
        Me.lbl_idCliente.Text = "id_cliente"
        '
        'gb_datos_del_cliente
        '
        Me.gb_datos_del_cliente.Controls.Add(Me.Label2)
        Me.gb_datos_del_cliente.Controls.Add(Me.Label1)
        Me.gb_datos_del_cliente.Controls.Add(Me.txt_email)
        Me.gb_datos_del_cliente.Controls.Add(Me.lbl_email)
        Me.gb_datos_del_cliente.Controls.Add(Me.txt_telefono)
        Me.gb_datos_del_cliente.Controls.Add(Me.lbl_telefono)
        Me.gb_datos_del_cliente.Controls.Add(Me.rb_masculino)
        Me.gb_datos_del_cliente.Controls.Add(Me.lbl_idCliente)
        Me.gb_datos_del_cliente.Controls.Add(Me.rb_femenino)
        Me.gb_datos_del_cliente.Controls.Add(Me.lbl_idSocio)
        Me.gb_datos_del_cliente.Controls.Add(Me.lbl_sexo)
        Me.gb_datos_del_cliente.Controls.Add(Me.txt_ap_materno)
        Me.gb_datos_del_cliente.Controls.Add(Me.txt_ap_paterno)
        Me.gb_datos_del_cliente.Controls.Add(Me.txt_nombre)
        Me.gb_datos_del_cliente.Controls.Add(Me.lbl_ap_materno)
        Me.gb_datos_del_cliente.Controls.Add(Me.lbl_ap_paterno)
        Me.gb_datos_del_cliente.Controls.Add(Me.lbl_nombre)
        Me.gb_datos_del_cliente.Location = New System.Drawing.Point(21, 27)
        Me.gb_datos_del_cliente.Name = "gb_datos_del_cliente"
        Me.gb_datos_del_cliente.Size = New System.Drawing.Size(738, 220)
        Me.gb_datos_del_cliente.TabIndex = 3
        Me.gb_datos_del_cliente.TabStop = False
        Me.gb_datos_del_cliente.Text = "Datos de cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(374, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Numero de cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 15)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Numero de socio:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(482, 170)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(169, 21)
        Me.txt_email.TabIndex = 7
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(362, 173)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(118, 15)
        Me.lbl_email.TabIndex = 25
        Me.lbl_email.Text = "Correo electronico:"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(460, 116)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(191, 21)
        Me.txt_telefono.TabIndex = 6
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(393, 119)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(61, 15)
        Me.lbl_telefono.TabIndex = 23
        Me.lbl_telefono.Text = "Telefono:"
        '
        'rb_masculino
        '
        Me.rb_masculino.AutoSize = True
        Me.rb_masculino.Location = New System.Drawing.Point(571, 74)
        Me.rb_masculino.Name = "rb_masculino"
        Me.rb_masculino.Size = New System.Drawing.Size(80, 19)
        Me.rb_masculino.TabIndex = 5
        Me.rb_masculino.TabStop = True
        Me.rb_masculino.Text = "Masculino"
        Me.rb_masculino.UseVisualStyleBackColor = True
        '
        'rb_femenino
        '
        Me.rb_femenino.AutoSize = True
        Me.rb_femenino.Location = New System.Drawing.Point(470, 74)
        Me.rb_femenino.Name = "rb_femenino"
        Me.rb_femenino.Size = New System.Drawing.Size(80, 19)
        Me.rb_femenino.TabIndex = 4
        Me.rb_femenino.TabStop = True
        Me.rb_femenino.Text = "Femenino"
        Me.rb_femenino.UseVisualStyleBackColor = True
        '
        'lbl_sexo
        '
        Me.lbl_sexo.AutoSize = True
        Me.lbl_sexo.Location = New System.Drawing.Point(413, 74)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(41, 15)
        Me.lbl_sexo.TabIndex = 20
        Me.lbl_sexo.Text = "Sexo:"
        '
        'txt_ap_materno
        '
        Me.txt_ap_materno.Location = New System.Drawing.Point(176, 170)
        Me.txt_ap_materno.Name = "txt_ap_materno"
        Me.txt_ap_materno.ReadOnly = True
        Me.txt_ap_materno.Size = New System.Drawing.Size(155, 21)
        Me.txt_ap_materno.TabIndex = 3
        '
        'txt_ap_paterno
        '
        Me.txt_ap_paterno.Location = New System.Drawing.Point(176, 119)
        Me.txt_ap_paterno.Name = "txt_ap_paterno"
        Me.txt_ap_paterno.ReadOnly = True
        Me.txt_ap_paterno.Size = New System.Drawing.Size(155, 21)
        Me.txt_ap_paterno.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(143, 72)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.ReadOnly = True
        Me.txt_nombre.Size = New System.Drawing.Size(188, 21)
        Me.txt_nombre.TabIndex = 1
        '
        'lbl_ap_materno
        '
        Me.lbl_ap_materno.AutoSize = True
        Me.lbl_ap_materno.Location = New System.Drawing.Point(63, 173)
        Me.lbl_ap_materno.Name = "lbl_ap_materno"
        Me.lbl_ap_materno.Size = New System.Drawing.Size(109, 15)
        Me.lbl_ap_materno.TabIndex = 19
        Me.lbl_ap_materno.Text = "Apellido materno:"
        '
        'lbl_ap_paterno
        '
        Me.lbl_ap_paterno.AutoSize = True
        Me.lbl_ap_paterno.Location = New System.Drawing.Point(63, 122)
        Me.lbl_ap_paterno.Name = "lbl_ap_paterno"
        Me.lbl_ap_paterno.Size = New System.Drawing.Size(105, 15)
        Me.lbl_ap_paterno.TabIndex = 18
        Me.lbl_ap_paterno.Text = "Apellido paterno:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(62, 74)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(75, 15)
        Me.lbl_nombre.TabIndex = 17
        Me.lbl_nombre.Text = "Nombre(S):"
        '
        'gb_datosContacto
        '
        Me.gb_datosContacto.Controls.Add(Me.txt_pais)
        Me.gb_datosContacto.Controls.Add(Me.lbl_pais)
        Me.gb_datosContacto.Controls.Add(Me.txt_ciudad)
        Me.gb_datosContacto.Controls.Add(Me.lbl_ciudad)
        Me.gb_datosContacto.Controls.Add(Me.txt_colonia)
        Me.gb_datosContacto.Controls.Add(Me.lbl_colonia)
        Me.gb_datosContacto.Controls.Add(Me.txt_numInt)
        Me.gb_datosContacto.Controls.Add(Me.lbl_num_int)
        Me.gb_datosContacto.Controls.Add(Me.txt_num_ext)
        Me.gb_datosContacto.Controls.Add(Me.lbl_num_ext)
        Me.gb_datosContacto.Controls.Add(Me.txt_calle)
        Me.gb_datosContacto.Controls.Add(Me.lbl_calle)
        Me.gb_datosContacto.Location = New System.Drawing.Point(21, 253)
        Me.gb_datosContacto.Name = "gb_datosContacto"
        Me.gb_datosContacto.Size = New System.Drawing.Size(738, 117)
        Me.gb_datosContacto.TabIndex = 4
        Me.gb_datosContacto.TabStop = False
        Me.gb_datosContacto.Text = "Datos de contacto"
        '
        'txt_pais
        '
        Me.txt_pais.Location = New System.Drawing.Point(551, 77)
        Me.txt_pais.Name = "txt_pais"
        Me.txt_pais.Size = New System.Drawing.Size(100, 21)
        Me.txt_pais.TabIndex = 13
        '
        'lbl_pais
        '
        Me.lbl_pais.AutoSize = True
        Me.lbl_pais.Location = New System.Drawing.Point(510, 80)
        Me.lbl_pais.Name = "lbl_pais"
        Me.lbl_pais.Size = New System.Drawing.Size(35, 15)
        Me.lbl_pais.TabIndex = 10
        Me.lbl_pais.Text = "Pais:"
        '
        'txt_ciudad
        '
        Me.txt_ciudad.Location = New System.Drawing.Point(377, 77)
        Me.txt_ciudad.Name = "txt_ciudad"
        Me.txt_ciudad.Size = New System.Drawing.Size(100, 21)
        Me.txt_ciudad.TabIndex = 12
        '
        'lbl_ciudad
        '
        Me.lbl_ciudad.AutoSize = True
        Me.lbl_ciudad.Location = New System.Drawing.Point(319, 80)
        Me.lbl_ciudad.Name = "lbl_ciudad"
        Me.lbl_ciudad.Size = New System.Drawing.Size(52, 15)
        Me.lbl_ciudad.TabIndex = 8
        Me.lbl_ciudad.Text = "Ciudad:"
        '
        'txt_colonia
        '
        Me.txt_colonia.Location = New System.Drawing.Point(72, 77)
        Me.txt_colonia.Name = "txt_colonia"
        Me.txt_colonia.Size = New System.Drawing.Size(200, 21)
        Me.txt_colonia.TabIndex = 11
        '
        'lbl_colonia
        '
        Me.lbl_colonia.AutoSize = True
        Me.lbl_colonia.Location = New System.Drawing.Point(11, 80)
        Me.lbl_colonia.Name = "lbl_colonia"
        Me.lbl_colonia.Size = New System.Drawing.Size(55, 15)
        Me.lbl_colonia.TabIndex = 6
        Me.lbl_colonia.Text = "Colonia:"
        '
        'txt_numInt
        '
        Me.txt_numInt.Location = New System.Drawing.Point(590, 31)
        Me.txt_numInt.Name = "txt_numInt"
        Me.txt_numInt.Size = New System.Drawing.Size(61, 21)
        Me.txt_numInt.TabIndex = 10
        '
        'lbl_num_int
        '
        Me.lbl_num_int.AutoSize = True
        Me.lbl_num_int.Location = New System.Drawing.Point(482, 34)
        Me.lbl_num_int.Name = "lbl_num_int"
        Me.lbl_num_int.Size = New System.Drawing.Size(102, 15)
        Me.lbl_num_int.TabIndex = 4
        Me.lbl_num_int.Text = "Numero interior:"
        '
        'txt_num_ext
        '
        Me.txt_num_ext.Location = New System.Drawing.Point(416, 31)
        Me.txt_num_ext.Name = "txt_num_ext"
        Me.txt_num_ext.Size = New System.Drawing.Size(61, 21)
        Me.txt_num_ext.TabIndex = 9
        '
        'lbl_num_ext
        '
        Me.lbl_num_ext.AutoSize = True
        Me.lbl_num_ext.Location = New System.Drawing.Point(304, 34)
        Me.lbl_num_ext.Name = "lbl_num_ext"
        Me.lbl_num_ext.Size = New System.Drawing.Size(106, 15)
        Me.lbl_num_ext.TabIndex = 2
        Me.lbl_num_ext.Text = "Numero exterior:"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(58, 31)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(214, 21)
        Me.txt_calle.TabIndex = 8
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(11, 34)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(41, 15)
        Me.lbl_calle.TabIndex = 0
        Me.lbl_calle.Text = "Calle:"
        '
        'gb_fechas
        '
        Me.gb_fechas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_fechas.Controls.Add(Me.btn_dar_de_baja)
        Me.gb_fechas.Controls.Add(Me.dt_ven)
        Me.gb_fechas.Controls.Add(Me.lbl_fecha_ven)
        Me.gb_fechas.Controls.Add(Me.dt_exp)
        Me.gb_fechas.Controls.Add(Me.lbl_fecha_ex)
        Me.gb_fechas.Location = New System.Drawing.Point(15, 376)
        Me.gb_fechas.Name = "gb_fechas"
        Me.gb_fechas.Size = New System.Drawing.Size(983, 80)
        Me.gb_fechas.TabIndex = 5
        Me.gb_fechas.TabStop = False
        '
        'btn_dar_de_baja
        '
        Me.btn_dar_de_baja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_dar_de_baja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dar_de_baja.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_dar_de_baja.Location = New System.Drawing.Point(836, 34)
        Me.btn_dar_de_baja.Name = "btn_dar_de_baja"
        Me.btn_dar_de_baja.Size = New System.Drawing.Size(99, 25)
        Me.btn_dar_de_baja.TabIndex = 18
        Me.btn_dar_de_baja.Text = "Dar de Baja"
        Me.btn_dar_de_baja.UseVisualStyleBackColor = False
        '
        'dt_ven
        '
        Me.dt_ven.CustomFormat = "dd MM yyyy"
        Me.dt_ven.Location = New System.Drawing.Point(552, 34)
        Me.dt_ven.Name = "dt_ven"
        Me.dt_ven.Size = New System.Drawing.Size(253, 21)
        Me.dt_ven.TabIndex = 17
        '
        'lbl_fecha_ven
        '
        Me.lbl_fecha_ven.AutoSize = True
        Me.lbl_fecha_ven.Location = New System.Drawing.Point(410, 35)
        Me.lbl_fecha_ven.Name = "lbl_fecha_ven"
        Me.lbl_fecha_ven.Size = New System.Drawing.Size(136, 15)
        Me.lbl_fecha_ven.TabIndex = 2
        Me.lbl_fecha_ven.Text = "Fecha de vencimiento:"
        '
        'dt_exp
        '
        Me.dt_exp.CustomFormat = "dd MM yyyy"
        Me.dt_exp.Location = New System.Drawing.Point(140, 34)
        Me.dt_exp.Name = "dt_exp"
        Me.dt_exp.Size = New System.Drawing.Size(252, 21)
        Me.dt_exp.TabIndex = 16
        '
        'lbl_fecha_ex
        '
        Me.lbl_fecha_ex.AutoSize = True
        Me.lbl_fecha_ex.Location = New System.Drawing.Point(6, 35)
        Me.lbl_fecha_ex.Name = "lbl_fecha_ex"
        Me.lbl_fecha_ex.Size = New System.Drawing.Size(128, 15)
        Me.lbl_fecha_ex.TabIndex = 0
        Me.lbl_fecha_ex.Text = "Fecha de expedicion:"
        '
        'gb_foto
        '
        Me.gb_foto.Controls.Add(Me.btn_eliminar_foto)
        Me.gb_foto.Controls.Add(Me.btn_cargar_foto)
        Me.gb_foto.Controls.Add(Me.pb_foto_cliente)
        Me.gb_foto.Location = New System.Drawing.Point(779, 27)
        Me.gb_foto.Name = "gb_foto"
        Me.gb_foto.Size = New System.Drawing.Size(219, 343)
        Me.gb_foto.TabIndex = 6
        Me.gb_foto.TabStop = False
        Me.gb_foto.Text = "Fotografia socio"
        '
        'btn_eliminar_foto
        '
        Me.btn_eliminar_foto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_eliminar_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar_foto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_eliminar_foto.Location = New System.Drawing.Point(72, 301)
        Me.btn_eliminar_foto.Name = "btn_eliminar_foto"
        Me.btn_eliminar_foto.Size = New System.Drawing.Size(99, 25)
        Me.btn_eliminar_foto.TabIndex = 15
        Me.btn_eliminar_foto.Text = "Eliminar"
        Me.btn_eliminar_foto.UseVisualStyleBackColor = False
        '
        'btn_cargar_foto
        '
        Me.btn_cargar_foto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_cargar_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cargar_foto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_cargar_foto.Location = New System.Drawing.Point(72, 250)
        Me.btn_cargar_foto.Name = "btn_cargar_foto"
        Me.btn_cargar_foto.Size = New System.Drawing.Size(99, 25)
        Me.btn_cargar_foto.TabIndex = 14
        Me.btn_cargar_foto.Text = "Cargar "
        Me.btn_cargar_foto.UseVisualStyleBackColor = False
        '
        'pb_foto_cliente
        '
        Me.pb_foto_cliente.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pb_foto_cliente.Location = New System.Drawing.Point(20, 27)
        Me.pb_foto_cliente.Name = "pb_foto_cliente"
        Me.pb_foto_cliente.Size = New System.Drawing.Size(183, 193)
        Me.pb_foto_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_foto_cliente.TabIndex = 0
        Me.pb_foto_cliente.TabStop = False
        '
        'gb_acciones
        '
        Me.gb_acciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_acciones.Controls.Add(Me.btn_limpiar)
        Me.gb_acciones.Controls.Add(Me.btn_generar_credencial)
        Me.gb_acciones.Controls.Add(Me.btn_eliminar)
        Me.gb_acciones.Controls.Add(Me.btn_grabar)
        Me.gb_acciones.Location = New System.Drawing.Point(15, 462)
        Me.gb_acciones.Name = "gb_acciones"
        Me.gb_acciones.Size = New System.Drawing.Size(805, 72)
        Me.gb_acciones.TabIndex = 7
        Me.gb_acciones.TabStop = False
        Me.gb_acciones.Text = "Acciones"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_limpiar.Location = New System.Drawing.Point(660, 23)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(99, 31)
        Me.btn_limpiar.TabIndex = 21
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'btn_generar_credencial
        '
        Me.btn_generar_credencial.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_generar_credencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_generar_credencial.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_generar_credencial.Location = New System.Drawing.Point(282, 24)
        Me.btn_generar_credencial.Name = "btn_generar_credencial"
        Me.btn_generar_credencial.Size = New System.Drawing.Size(338, 31)
        Me.btn_generar_credencial.TabIndex = 20
        Me.btn_generar_credencial.Text = "Generar credencial"
        Me.btn_generar_credencial.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_eliminar.Location = New System.Drawing.Point(149, 24)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(99, 31)
        Me.btn_eliminar.TabIndex = 19
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_grabar
        '
        Me.btn_grabar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_grabar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_grabar.Location = New System.Drawing.Point(20, 23)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(99, 32)
        Me.btn_grabar.TabIndex = 18
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.UseVisualStyleBackColor = False
        '
        'ofd_foto
        '
        Me.ofd_foto.FileName = "OpenFileDialog1"
        '
        'FormSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 546)
        Me.Controls.Add(Me.gb_acciones)
        Me.Controls.Add(Me.gb_foto)
        Me.Controls.Add(Me.gb_fechas)
        Me.Controls.Add(Me.gb_datosContacto)
        Me.Controls.Add(Me.gb_datos_del_cliente)
        Me.Name = "FormSocios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Socios"
        Me.TopMost = True
        Me.Controls.SetChildIndex(Me.btn_salir, 0)
        Me.Controls.SetChildIndex(Me.gb_datos_del_cliente, 0)
        Me.Controls.SetChildIndex(Me.gb_datosContacto, 0)
        Me.Controls.SetChildIndex(Me.gb_fechas, 0)
        Me.Controls.SetChildIndex(Me.gb_foto, 0)
        Me.Controls.SetChildIndex(Me.gb_acciones, 0)
        Me.gb_datos_del_cliente.ResumeLayout(False)
        Me.gb_datos_del_cliente.PerformLayout()
        Me.gb_datosContacto.ResumeLayout(False)
        Me.gb_datosContacto.PerformLayout()
        Me.gb_fechas.ResumeLayout(False)
        Me.gb_fechas.PerformLayout()
        Me.gb_foto.ResumeLayout(False)
        CType(Me.pb_foto_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_acciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_idSocio As Label
    Friend WithEvents lbl_idCliente As Label
    Friend WithEvents gb_datos_del_cliente As GroupBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents rb_masculino As RadioButton
    Friend WithEvents rb_femenino As RadioButton
    Friend WithEvents lbl_sexo As Label
    Friend WithEvents txt_ap_materno As TextBox
    Friend WithEvents txt_ap_paterno As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl_ap_materno As Label
    Friend WithEvents lbl_ap_paterno As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents gb_datosContacto As GroupBox
    Friend WithEvents txt_pais As TextBox
    Friend WithEvents lbl_pais As Label
    Friend WithEvents txt_ciudad As TextBox
    Friend WithEvents lbl_ciudad As Label
    Friend WithEvents txt_colonia As TextBox
    Friend WithEvents lbl_colonia As Label
    Friend WithEvents txt_numInt As TextBox
    Friend WithEvents lbl_num_int As Label
    Friend WithEvents txt_num_ext As TextBox
    Friend WithEvents lbl_num_ext As Label
    Friend WithEvents txt_calle As TextBox
    Friend WithEvents lbl_calle As Label
    Friend WithEvents gb_fechas As GroupBox
    Friend WithEvents dt_ven As DateTimePicker
    Friend WithEvents lbl_fecha_ven As Label
    Friend WithEvents dt_exp As DateTimePicker
    Friend WithEvents lbl_fecha_ex As Label
    Friend WithEvents gb_foto As GroupBox
    Friend WithEvents btn_cargar_foto As Button
    Friend WithEvents pb_foto_cliente As PictureBox
    Friend WithEvents gb_acciones As GroupBox
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_generar_credencial As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents btn_eliminar_foto As Button
    Friend WithEvents ofd_foto As OpenFileDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_dar_de_baja As Button
End Class
