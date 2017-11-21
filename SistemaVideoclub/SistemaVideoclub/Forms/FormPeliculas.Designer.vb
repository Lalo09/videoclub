<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPeliculas
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
        Me.gb_datos_pelicula = New System.Windows.Forms.GroupBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.cmb_distribuidores = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_precio_compra = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_precio_venta = New System.Windows.Forms.TextBox()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_cargar = New System.Windows.Forms.Button()
        Me.pb_foto = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_precio_renta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dt_fecha_adquicision = New System.Windows.Forms.DateTimePicker()
        Me.rtxt_sinopsis = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nud_cant_existencia = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_director = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_pais = New System.Windows.Forms.TextBox()
        Me.cmb_clasificacion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_genero = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_duracion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_pelicula = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.dg_peliculas = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_deshacer_busqueda = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_nombre_buscar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ofd_foto = New System.Windows.Forms.OpenFileDialog()
        Me.gb_datos_pelicula.SuspendLayout()
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_cant_existencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg_peliculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salir.Location = New System.Drawing.Point(871, 497)
        '
        'gb_datos_pelicula
        '
        Me.gb_datos_pelicula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_datos_pelicula.Controls.Add(Me.lbl_id)
        Me.gb_datos_pelicula.Controls.Add(Me.cmb_distribuidores)
        Me.gb_datos_pelicula.Controls.Add(Me.Label14)
        Me.gb_datos_pelicula.Controls.Add(Me.txt_precio_compra)
        Me.gb_datos_pelicula.Controls.Add(Me.Label13)
        Me.gb_datos_pelicula.Controls.Add(Me.txt_precio_venta)
        Me.gb_datos_pelicula.Controls.Add(Me.btn_borrar)
        Me.gb_datos_pelicula.Controls.Add(Me.btn_cargar)
        Me.gb_datos_pelicula.Controls.Add(Me.pb_foto)
        Me.gb_datos_pelicula.Controls.Add(Me.Label11)
        Me.gb_datos_pelicula.Controls.Add(Me.txt_precio_renta)
        Me.gb_datos_pelicula.Controls.Add(Me.Label10)
        Me.gb_datos_pelicula.Controls.Add(Me.Label9)
        Me.gb_datos_pelicula.Controls.Add(Me.dt_fecha_adquicision)
        Me.gb_datos_pelicula.Controls.Add(Me.rtxt_sinopsis)
        Me.gb_datos_pelicula.Controls.Add(Me.Label8)
        Me.gb_datos_pelicula.Controls.Add(Me.nud_cant_existencia)
        Me.gb_datos_pelicula.Controls.Add(Me.Label7)
        Me.gb_datos_pelicula.Controls.Add(Me.txt_director)
        Me.gb_datos_pelicula.Controls.Add(Me.Label6)
        Me.gb_datos_pelicula.Controls.Add(Me.txt_pais)
        Me.gb_datos_pelicula.Controls.Add(Me.cmb_clasificacion)
        Me.gb_datos_pelicula.Controls.Add(Me.Label4)
        Me.gb_datos_pelicula.Controls.Add(Me.cmb_genero)
        Me.gb_datos_pelicula.Controls.Add(Me.Label3)
        Me.gb_datos_pelicula.Controls.Add(Me.txt_duracion)
        Me.gb_datos_pelicula.Controls.Add(Me.Label2)
        Me.gb_datos_pelicula.Controls.Add(Me.Label1)
        Me.gb_datos_pelicula.Controls.Add(Me.txt_nombre)
        Me.gb_datos_pelicula.Controls.Add(Me.lbl_pelicula)
        Me.gb_datos_pelicula.Controls.Add(Me.Label5)
        Me.gb_datos_pelicula.Location = New System.Drawing.Point(13, 13)
        Me.gb_datos_pelicula.Name = "gb_datos_pelicula"
        Me.gb_datos_pelicula.Size = New System.Drawing.Size(1019, 261)
        Me.gb_datos_pelicula.TabIndex = 1
        Me.gb_datos_pelicula.TabStop = False
        Me.gb_datos_pelicula.Text = "Datos de pelicula"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(243, 13)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(0, 15)
        Me.lbl_id.TabIndex = 31
        Me.lbl_id.Visible = False
        '
        'cmb_distribuidores
        '
        Me.cmb_distribuidores.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_distribuidores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_distribuidores.FormattingEnabled = True
        Me.cmb_distribuidores.Items.AddRange(New Object() {"AA", "A", "B", "B15", "C", "D"})
        Me.cmb_distribuidores.Location = New System.Drawing.Point(443, 41)
        Me.cmb_distribuidores.Name = "cmb_distribuidores"
        Me.cmb_distribuidores.Size = New System.Drawing.Size(190, 23)
        Me.cmb_distribuidores.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(359, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 15)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Distribuidor:"
        '
        'txt_precio_compra
        '
        Me.txt_precio_compra.Location = New System.Drawing.Point(738, 232)
        Me.txt_precio_compra.Name = "txt_precio_compra"
        Me.txt_precio_compra.Size = New System.Drawing.Size(52, 21)
        Me.txt_precio_compra.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(639, 235)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 15)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Precio compra:"
        '
        'txt_precio_venta
        '
        Me.txt_precio_venta.Location = New System.Drawing.Point(581, 232)
        Me.txt_precio_venta.Name = "txt_precio_venta"
        Me.txt_precio_venta.Size = New System.Drawing.Size(52, 21)
        Me.txt_precio_venta.TabIndex = 25
        '
        'btn_borrar
        '
        Me.btn_borrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_borrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_borrar.Location = New System.Drawing.Point(867, 229)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(90, 27)
        Me.btn_borrar.TabIndex = 24
        Me.btn_borrar.Text = "Borrar"
        Me.btn_borrar.UseVisualStyleBackColor = False
        '
        'btn_cargar
        '
        Me.btn_cargar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cargar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_cargar.Location = New System.Drawing.Point(867, 191)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(90, 27)
        Me.btn_cargar.TabIndex = 7
        Me.btn_cargar.Text = "Cargar"
        Me.btn_cargar.UseVisualStyleBackColor = False
        '
        'pb_foto
        '
        Me.pb_foto.Location = New System.Drawing.Point(839, 13)
        Me.pb_foto.Name = "pb_foto"
        Me.pb_foto.Size = New System.Drawing.Size(142, 164)
        Me.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_foto.TabIndex = 23
        Me.pb_foto.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(498, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 15)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Precio venta:"
        '
        'txt_precio_renta
        '
        Me.txt_precio_renta.Location = New System.Drawing.Point(439, 232)
        Me.txt_precio_renta.Name = "txt_precio_renta"
        Me.txt_precio_renta.Size = New System.Drawing.Size(52, 21)
        Me.txt_precio_renta.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(359, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 15)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Precio renta:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(359, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Fecha de adquisicion:"
        '
        'dt_fecha_adquicision
        '
        Me.dt_fecha_adquicision.CustomFormat = "dd MM yyyy"
        Me.dt_fecha_adquicision.Location = New System.Drawing.Point(501, 191)
        Me.dt_fecha_adquicision.Name = "dt_fecha_adquicision"
        Me.dt_fecha_adquicision.Size = New System.Drawing.Size(275, 21)
        Me.dt_fecha_adquicision.TabIndex = 17
        '
        'rtxt_sinopsis
        '
        Me.rtxt_sinopsis.Location = New System.Drawing.Point(418, 79)
        Me.rtxt_sinopsis.Name = "rtxt_sinopsis"
        Me.rtxt_sinopsis.Size = New System.Drawing.Size(358, 96)
        Me.rtxt_sinopsis.TabIndex = 16
        Me.rtxt_sinopsis.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(359, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Sinopsis:"
        '
        'nud_cant_existencia
        '
        Me.nud_cant_existencia.Location = New System.Drawing.Point(507, 11)
        Me.nud_cant_existencia.Name = "nud_cant_existencia"
        Me.nud_cant_existencia.Size = New System.Drawing.Size(71, 21)
        Me.nud_cant_existencia.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(359, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cantidad en existencia:"
        '
        'txt_director
        '
        Me.txt_director.Location = New System.Drawing.Point(114, 229)
        Me.txt_director.Name = "txt_director"
        Me.txt_director.Size = New System.Drawing.Size(159, 21)
        Me.txt_director.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Director:"
        '
        'txt_pais
        '
        Me.txt_pais.Location = New System.Drawing.Point(143, 188)
        Me.txt_pais.Name = "txt_pais"
        Me.txt_pais.Size = New System.Drawing.Size(130, 21)
        Me.txt_pais.TabIndex = 9
        '
        'cmb_clasificacion
        '
        Me.cmb_clasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_clasificacion.FormattingEnabled = True
        Me.cmb_clasificacion.Items.AddRange(New Object() {"AA", "A", "B", "B15", "C", "D"})
        Me.cmb_clasificacion.Location = New System.Drawing.Point(143, 148)
        Me.cmb_clasificacion.Name = "cmb_clasificacion"
        Me.cmb_clasificacion.Size = New System.Drawing.Size(130, 23)
        Me.cmb_clasificacion.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Clasificacion:"
        '
        'cmb_genero
        '
        Me.cmb_genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_genero.FormattingEnabled = True
        Me.cmb_genero.Items.AddRange(New Object() {"Drama", "Comedia", "Accion", "Ciencia Ficcion", "Fantasia", "Terror", "Romance", "Musical", "Melodrama", "Suspenso", "XXX"})
        Me.cmb_genero.Location = New System.Drawing.Point(114, 110)
        Me.cmb_genero.Name = "cmb_genero"
        Me.cmb_genero.Size = New System.Drawing.Size(159, 23)
        Me.cmb_genero.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Genero:"
        '
        'txt_duracion
        '
        Me.txt_duracion.Location = New System.Drawing.Point(114, 76)
        Me.txt_duracion.Name = "txt_duracion"
        Me.txt_duracion.Size = New System.Drawing.Size(159, 21)
        Me.txt_duracion.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Duracion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(114, 41)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(159, 21)
        Me.txt_nombre.TabIndex = 1
        '
        'lbl_pelicula
        '
        Me.lbl_pelicula.AutoSize = True
        Me.lbl_pelicula.Location = New System.Drawing.Point(111, 13)
        Me.lbl_pelicula.Name = "lbl_pelicula"
        Me.lbl_pelicula.Size = New System.Drawing.Size(126, 15)
        Me.lbl_pelicula.TabIndex = 0
        Me.lbl_pelicula.Text = "Numero de pelicula :"
        Me.lbl_pelicula.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Pais de origen:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.btn_eliminar)
        Me.GroupBox2.Controls.Add(Me.btn_grabar)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 282)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1019, 65)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(667, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 32)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Nuevo"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_eliminar.Location = New System.Drawing.Point(513, 20)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(99, 32)
        Me.btn_eliminar.TabIndex = 5
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_grabar
        '
        Me.btn_grabar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_grabar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_grabar.Location = New System.Drawing.Point(362, 20)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(99, 32)
        Me.btn_grabar.TabIndex = 4
        Me.btn_grabar.Text = "Guardar"
        Me.btn_grabar.UseVisualStyleBackColor = False
        '
        'dg_peliculas
        '
        Me.dg_peliculas.AllowUserToAddRows = False
        Me.dg_peliculas.AllowUserToDeleteRows = False
        Me.dg_peliculas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_peliculas.Location = New System.Drawing.Point(13, 353)
        Me.dg_peliculas.Name = "dg_peliculas"
        Me.dg_peliculas.ReadOnly = True
        Me.dg_peliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_peliculas.Size = New System.Drawing.Size(1019, 123)
        Me.dg_peliculas.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btn_deshacer_busqueda)
        Me.GroupBox3.Controls.Add(Me.btn_buscar)
        Me.GroupBox3.Controls.Add(Me.txt_nombre_buscar)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 482)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(808, 57)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar:"
        '
        'btn_deshacer_busqueda
        '
        Me.btn_deshacer_busqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_deshacer_busqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_deshacer_busqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deshacer_busqueda.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_deshacer_busqueda.Location = New System.Drawing.Point(651, 15)
        Me.btn_deshacer_busqueda.Name = "btn_deshacer_busqueda"
        Me.btn_deshacer_busqueda.Size = New System.Drawing.Size(139, 32)
        Me.btn_deshacer_busqueda.TabIndex = 8
        Me.btn_deshacer_busqueda.Text = "Deshacer busqueda"
        Me.btn_deshacer_busqueda.UseVisualStyleBackColor = False
        '
        'btn_buscar
        '
        Me.btn_buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_buscar.Location = New System.Drawing.Point(486, 15)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(139, 32)
        Me.btn_buscar.TabIndex = 7
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_nombre_buscar
        '
        Me.txt_nombre_buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombre_buscar.Location = New System.Drawing.Point(79, 21)
        Me.txt_nombre_buscar.Name = "txt_nombre_buscar"
        Me.txt_nombre_buscar.Size = New System.Drawing.Size(381, 21)
        Me.txt_nombre_buscar.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Nombre:"
        '
        'ofd_foto
        '
        Me.ofd_foto.FileName = "OpenFileDialog1"
        '
        'FormPeliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 551)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dg_peliculas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gb_datos_pelicula)
        Me.Name = "FormPeliculas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peliculas"
        Me.Controls.SetChildIndex(Me.btn_salir, 0)
        Me.Controls.SetChildIndex(Me.gb_datos_pelicula, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.dg_peliculas, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.gb_datos_pelicula.ResumeLayout(False)
        Me.gb_datos_pelicula.PerformLayout()
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_cant_existencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dg_peliculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_datos_pelicula As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_precio_renta As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dt_fecha_adquicision As DateTimePicker
    Friend WithEvents rtxt_sinopsis As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents nud_cant_existencia As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_director As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_pais As TextBox
    Friend WithEvents cmb_clasificacion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_genero As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_duracion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl_pelicula As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents dg_peliculas As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_deshacer_busqueda As Button
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_nombre_buscar As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_borrar As Button
    Friend WithEvents btn_cargar As Button
    Friend WithEvents pb_foto As PictureBox
    Friend WithEvents txt_precio_compra As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_precio_venta As TextBox
    Friend WithEvents cmb_distribuidores As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents ofd_foto As OpenFileDialog
End Class
