<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEmpleados
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
        Me.gb_datos_del_cliente = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEmpleado = New System.Windows.Forms.Label()
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
        Me.gb_foto = New System.Windows.Forms.GroupBox()
        Me.btn_eliminar_foto = New System.Windows.Forms.Button()
        Me.btn_cargar_foto = New System.Windows.Forms.Button()
        Me.pb_foto_empleado = New System.Windows.Forms.PictureBox()
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
        Me.gb_sueldo = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dg_empleado = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnBuscarEmp = New System.Windows.Forms.Button()
        Me.Txt_buscar_empleado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Open_F2 = New System.Windows.Forms.OpenFileDialog()
        Me.gb_datos_del_cliente.SuspendLayout()
        Me.gb_foto.SuspendLayout()
        CType(Me.pb_foto_empleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_datosContacto.SuspendLayout()
        Me.gb_sueldo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_empleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(828, 510)
        '
        'gb_datos_del_cliente
        '
        Me.gb_datos_del_cliente.Controls.Add(Me.DateTimePicker1)
        Me.gb_datos_del_cliente.Controls.Add(Me.Label3)
        Me.gb_datos_del_cliente.Controls.Add(Me.lblEmpleado)
        Me.gb_datos_del_cliente.Controls.Add(Me.Label1)
        Me.gb_datos_del_cliente.Controls.Add(Me.txt_email)
        Me.gb_datos_del_cliente.Controls.Add(Me.lbl_email)
        Me.gb_datos_del_cliente.Controls.Add(Me.txt_telefono)
        Me.gb_datos_del_cliente.Controls.Add(Me.lbl_telefono)
        Me.gb_datos_del_cliente.Controls.Add(Me.rb_masculino)
        Me.gb_datos_del_cliente.Controls.Add(Me.rb_femenino)
        Me.gb_datos_del_cliente.Controls.Add(Me.lbl_sexo)
        Me.gb_datos_del_cliente.Controls.Add(Me.txt_ap_materno)
        Me.gb_datos_del_cliente.Controls.Add(Me.txt_ap_paterno)
        Me.gb_datos_del_cliente.Controls.Add(Me.txt_nombre)
        Me.gb_datos_del_cliente.Controls.Add(Me.lbl_ap_materno)
        Me.gb_datos_del_cliente.Controls.Add(Me.lbl_ap_paterno)
        Me.gb_datos_del_cliente.Controls.Add(Me.lbl_nombre)
        Me.gb_datos_del_cliente.Location = New System.Drawing.Point(22, 12)
        Me.gb_datos_del_cliente.Name = "gb_datos_del_cliente"
        Me.gb_datos_del_cliente.Size = New System.Drawing.Size(720, 180)
        Me.gb_datos_del_cliente.TabIndex = 4
        Me.gb_datos_del_cliente.TabStop = False
        Me.gb_datos_del_cliente.Text = "Datos del empleado"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd MM yyyy"
        Me.DateTimePicker1.Location = New System.Drawing.Point(485, 141)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(165, 21)
        Me.DateTimePicker1.TabIndex = 29
        Me.DateTimePicker1.Value = New Date(2017, 7, 10, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(353, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Fecha de nacimiento:"
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Location = New System.Drawing.Point(199, 27)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(14, 15)
        Me.lblEmpleado.TabIndex = 27
        Me.lblEmpleado.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 15)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Numero de empleado:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(486, 97)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(165, 21)
        Me.txt_email.TabIndex = 7
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(362, 100)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(118, 15)
        Me.lbl_email.TabIndex = 25
        Me.lbl_email.Text = "Correo electronico:"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(460, 58)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(191, 21)
        Me.txt_telefono.TabIndex = 6
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(393, 61)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(61, 15)
        Me.lbl_telefono.TabIndex = 23
        Me.lbl_telefono.Text = "Telefono:"
        '
        'rb_masculino
        '
        Me.rb_masculino.AutoSize = True
        Me.rb_masculino.Location = New System.Drawing.Point(570, 25)
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
        Me.rb_femenino.Location = New System.Drawing.Point(465, 27)
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
        Me.lbl_sexo.Location = New System.Drawing.Point(408, 27)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(41, 15)
        Me.lbl_sexo.TabIndex = 20
        Me.lbl_sexo.Text = "Sexo:"
        '
        'txt_ap_materno
        '
        Me.txt_ap_materno.Location = New System.Drawing.Point(171, 141)
        Me.txt_ap_materno.Name = "txt_ap_materno"
        Me.txt_ap_materno.Size = New System.Drawing.Size(155, 21)
        Me.txt_ap_materno.TabIndex = 3
        '
        'txt_ap_paterno
        '
        Me.txt_ap_paterno.Location = New System.Drawing.Point(171, 97)
        Me.txt_ap_paterno.Name = "txt_ap_paterno"
        Me.txt_ap_paterno.Size = New System.Drawing.Size(155, 21)
        Me.txt_ap_paterno.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(138, 58)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(188, 21)
        Me.txt_nombre.TabIndex = 1
        '
        'lbl_ap_materno
        '
        Me.lbl_ap_materno.AutoSize = True
        Me.lbl_ap_materno.Location = New System.Drawing.Point(58, 144)
        Me.lbl_ap_materno.Name = "lbl_ap_materno"
        Me.lbl_ap_materno.Size = New System.Drawing.Size(109, 15)
        Me.lbl_ap_materno.TabIndex = 19
        Me.lbl_ap_materno.Text = "Apellido materno:"
        '
        'lbl_ap_paterno
        '
        Me.lbl_ap_paterno.AutoSize = True
        Me.lbl_ap_paterno.Location = New System.Drawing.Point(57, 100)
        Me.lbl_ap_paterno.Name = "lbl_ap_paterno"
        Me.lbl_ap_paterno.Size = New System.Drawing.Size(105, 15)
        Me.lbl_ap_paterno.TabIndex = 18
        Me.lbl_ap_paterno.Text = "Apellido paterno:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(57, 60)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(75, 15)
        Me.lbl_nombre.TabIndex = 17
        Me.lbl_nombre.Text = "Nombre(S):"
        '
        'gb_foto
        '
        Me.gb_foto.Controls.Add(Me.btn_eliminar_foto)
        Me.gb_foto.Controls.Add(Me.btn_cargar_foto)
        Me.gb_foto.Controls.Add(Me.pb_foto_empleado)
        Me.gb_foto.Location = New System.Drawing.Point(748, 12)
        Me.gb_foto.Name = "gb_foto"
        Me.gb_foto.Size = New System.Drawing.Size(250, 303)
        Me.gb_foto.TabIndex = 7
        Me.gb_foto.TabStop = False
        Me.gb_foto.Text = "Fotografia socio"
        '
        'btn_eliminar_foto
        '
        Me.btn_eliminar_foto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_eliminar_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar_foto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_eliminar_foto.Location = New System.Drawing.Point(80, 256)
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
        Me.btn_cargar_foto.Location = New System.Drawing.Point(80, 210)
        Me.btn_cargar_foto.Name = "btn_cargar_foto"
        Me.btn_cargar_foto.Size = New System.Drawing.Size(99, 25)
        Me.btn_cargar_foto.TabIndex = 14
        Me.btn_cargar_foto.Text = "Cargar "
        Me.btn_cargar_foto.UseVisualStyleBackColor = False
        '
        'pb_foto_empleado
        '
        Me.pb_foto_empleado.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pb_foto_empleado.Location = New System.Drawing.Point(39, 27)
        Me.pb_foto_empleado.Name = "pb_foto_empleado"
        Me.pb_foto_empleado.Size = New System.Drawing.Size(183, 163)
        Me.pb_foto_empleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_foto_empleado.TabIndex = 0
        Me.pb_foto_empleado.TabStop = False
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
        Me.gb_datosContacto.Location = New System.Drawing.Point(22, 198)
        Me.gb_datosContacto.Name = "gb_datosContacto"
        Me.gb_datosContacto.Size = New System.Drawing.Size(720, 117)
        Me.gb_datosContacto.TabIndex = 8
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
        'gb_sueldo
        '
        Me.gb_sueldo.Controls.Add(Me.Button1)
        Me.gb_sueldo.Controls.Add(Me.txtSueldo)
        Me.gb_sueldo.Controls.Add(Me.Label4)
        Me.gb_sueldo.Location = New System.Drawing.Point(22, 321)
        Me.gb_sueldo.Name = "gb_sueldo"
        Me.gb_sueldo.Size = New System.Drawing.Size(720, 49)
        Me.gb_sueldo.TabIndex = 9
        Me.gb_sueldo.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(455, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Dar de baja"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(72, 16)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(200, 21)
        Me.txtSueldo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sueldo:"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGuardar.Location = New System.Drawing.Point(80, 18)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(99, 32)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminar.Location = New System.Drawing.Point(80, 70)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(99, 32)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLimpiar.Location = New System.Drawing.Point(80, 127)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(99, 32)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Location = New System.Drawing.Point(748, 321)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 165)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'dg_empleado
        '
        Me.dg_empleado.AllowUserToAddRows = False
        Me.dg_empleado.AllowUserToDeleteRows = False
        Me.dg_empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_empleado.Location = New System.Drawing.Point(22, 377)
        Me.dg_empleado.Name = "dg_empleado"
        Me.dg_empleado.ReadOnly = True
        Me.dg_empleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_empleado.Size = New System.Drawing.Size(720, 109)
        Me.dg_empleado.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.btnBuscarEmp)
        Me.GroupBox2.Controls.Add(Me.Txt_buscar_empleado)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 492)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(720, 58)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.Location = New System.Drawing.Point(529, 20)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(149, 23)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "Deshacer busqueda"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btnBuscarEmp
        '
        Me.btnBuscarEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscarEmp.Location = New System.Drawing.Point(342, 20)
        Me.btnBuscarEmp.Name = "btnBuscarEmp"
        Me.btnBuscarEmp.Size = New System.Drawing.Size(149, 23)
        Me.btnBuscarEmp.TabIndex = 3
        Me.btnBuscarEmp.Text = "Buscar"
        Me.btnBuscarEmp.UseVisualStyleBackColor = False
        '
        'Txt_buscar_empleado
        '
        Me.Txt_buscar_empleado.Location = New System.Drawing.Point(187, 20)
        Me.Txt_buscar_empleado.Name = "Txt_buscar_empleado"
        Me.Txt_buscar_empleado.Size = New System.Drawing.Size(139, 21)
        Me.Txt_buscar_empleado.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Numero de empleado:"
        '
        'Open_F2
        '
        Me.Open_F2.FileName = "OpenFileDialog1"
        '
        'FormEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 554)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dg_empleado)
        Me.Controls.Add(Me.gb_sueldo)
        Me.Controls.Add(Me.gb_datosContacto)
        Me.Controls.Add(Me.gb_foto)
        Me.Controls.Add(Me.gb_datos_del_cliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormEmpleados"
        Me.Text = "FormEmpleados"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btn_salir, 0)
        Me.Controls.SetChildIndex(Me.gb_datos_del_cliente, 0)
        Me.Controls.SetChildIndex(Me.gb_foto, 0)
        Me.Controls.SetChildIndex(Me.gb_datosContacto, 0)
        Me.Controls.SetChildIndex(Me.gb_sueldo, 0)
        Me.Controls.SetChildIndex(Me.dg_empleado, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.gb_datos_del_cliente.ResumeLayout(False)
        Me.gb_datos_del_cliente.PerformLayout()
        Me.gb_foto.ResumeLayout(False)
        CType(Me.pb_foto_empleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_datosContacto.ResumeLayout(False)
        Me.gb_datosContacto.PerformLayout()
        Me.gb_sueldo.ResumeLayout(False)
        Me.gb_sueldo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dg_empleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

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
    Friend WithEvents gb_foto As GroupBox
    Friend WithEvents btn_eliminar_foto As Button
    Friend WithEvents btn_cargar_foto As Button
    Friend WithEvents pb_foto_empleado As PictureBox
    Friend WithEvents lblEmpleado As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
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
    Friend WithEvents gb_sueldo As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dg_empleado As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents btnBuscarEmp As Button
    Friend WithEvents Txt_buscar_empleado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Open_F2 As OpenFileDialog
End Class
