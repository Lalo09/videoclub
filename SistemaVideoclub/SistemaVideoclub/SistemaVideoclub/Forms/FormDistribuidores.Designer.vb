<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDistribuidores
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
        Me.gb_datos = New System.Windows.Forms.GroupBox()
        Me.txt_pais = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_sitio_web = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.dg_distribuidores = New System.Windows.Forms.DataGridView()
        Me.gb_buscar = New System.Windows.Forms.GroupBox()
        Me.btn_deshacer = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_nombreBuscar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.gb_datos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg_distribuidores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_buscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(625, 399)
        Me.btn_salir.TabIndex = 15
        '
        'gb_datos
        '
        Me.gb_datos.Controls.Add(Me.txt_pais)
        Me.gb_datos.Controls.Add(Me.Label9)
        Me.gb_datos.Controls.Add(Me.LinkLabel2)
        Me.gb_datos.Controls.Add(Me.LinkLabel1)
        Me.gb_datos.Controls.Add(Me.Label7)
        Me.gb_datos.Controls.Add(Me.txt_telefono)
        Me.gb_datos.Controls.Add(Me.Label6)
        Me.gb_datos.Controls.Add(Me.txt_sitio_web)
        Me.gb_datos.Controls.Add(Me.Label5)
        Me.gb_datos.Controls.Add(Me.txt_email)
        Me.gb_datos.Controls.Add(Me.Label4)
        Me.gb_datos.Controls.Add(Me.txt_direccion)
        Me.gb_datos.Controls.Add(Me.Label3)
        Me.gb_datos.Controls.Add(Me.txt_nombre)
        Me.gb_datos.Controls.Add(Me.Label2)
        Me.gb_datos.Controls.Add(Me.Label1)
        Me.gb_datos.Location = New System.Drawing.Point(13, 13)
        Me.gb_datos.Name = "gb_datos"
        Me.gb_datos.Size = New System.Drawing.Size(724, 148)
        Me.gb_datos.TabIndex = 1
        Me.gb_datos.TabStop = False
        Me.gb_datos.Text = "Datos de distribuidor"
        '
        'txt_pais
        '
        Me.txt_pais.Location = New System.Drawing.Point(77, 69)
        Me.txt_pais.Name = "txt_pais"
        Me.txt_pais.Size = New System.Drawing.Size(209, 21)
        Me.txt_pais.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Pais:"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(643, 69)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(55, 15)
        Me.LinkLabel2.TabIndex = 14
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Ir a web"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(631, 34)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(84, 15)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Enviar correo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(631, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 15)
        Me.Label7.TabIndex = 11
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(395, 105)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(215, 21)
        Me.txt_telefono.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(325, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Telefono:"
        '
        'txt_sitio_web
        '
        Me.txt_sitio_web.Location = New System.Drawing.Point(397, 69)
        Me.txt_sitio_web.Name = "txt_sitio_web"
        Me.txt_sitio_web.Size = New System.Drawing.Size(215, 21)
        Me.txt_sitio_web.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(325, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Sitio web:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(444, 31)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(166, 21)
        Me.txt_email.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(317, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Correo Electronico:"
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(77, 105)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(209, 21)
        Me.txt_direccion.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Direccion:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(77, 31)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(209, 21)
        Me.txt_nombre.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, -18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_distribuidor"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_nuevo)
        Me.GroupBox2.Controls.Add(Me.btn_eliminar)
        Me.GroupBox2.Controls.Add(Me.btn_grabar)
        Me.GroupBox2.Location = New System.Drawing.Point(204, 161)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 61)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_nuevo.Location = New System.Drawing.Point(243, 16)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(99, 32)
        Me.btn_nuevo.TabIndex = 8
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_eliminar.Location = New System.Drawing.Point(125, 16)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(99, 32)
        Me.btn_eliminar.TabIndex = 7
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_grabar
        '
        Me.btn_grabar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_grabar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_grabar.Location = New System.Drawing.Point(6, 16)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(99, 32)
        Me.btn_grabar.TabIndex = 6
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.UseVisualStyleBackColor = False
        '
        'dg_distribuidores
        '
        Me.dg_distribuidores.AllowUserToAddRows = False
        Me.dg_distribuidores.AllowUserToDeleteRows = False
        Me.dg_distribuidores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_distribuidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_distribuidores.Location = New System.Drawing.Point(13, 228)
        Me.dg_distribuidores.Name = "dg_distribuidores"
        Me.dg_distribuidores.ReadOnly = True
        Me.dg_distribuidores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_distribuidores.Size = New System.Drawing.Size(724, 150)
        Me.dg_distribuidores.TabIndex = 9
        '
        'gb_buscar
        '
        Me.gb_buscar.Controls.Add(Me.btn_deshacer)
        Me.gb_buscar.Controls.Add(Me.btn_buscar)
        Me.gb_buscar.Controls.Add(Me.txt_nombreBuscar)
        Me.gb_buscar.Controls.Add(Me.Label8)
        Me.gb_buscar.Location = New System.Drawing.Point(13, 384)
        Me.gb_buscar.Name = "gb_buscar"
        Me.gb_buscar.Size = New System.Drawing.Size(592, 56)
        Me.gb_buscar.TabIndex = 4
        Me.gb_buscar.TabStop = False
        Me.gb_buscar.Text = "Buscar"
        '
        'btn_deshacer
        '
        Me.btn_deshacer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_deshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deshacer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_deshacer.Location = New System.Drawing.Point(470, 15)
        Me.btn_deshacer.Name = "btn_deshacer"
        Me.btn_deshacer.Size = New System.Drawing.Size(99, 32)
        Me.btn_deshacer.TabIndex = 12
        Me.btn_deshacer.Text = "Deshacer"
        Me.btn_deshacer.UseVisualStyleBackColor = False
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_buscar.Location = New System.Drawing.Point(316, 15)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(138, 32)
        Me.btn_buscar.TabIndex = 11
        Me.btn_buscar.Text = "Buscar distribuidor"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_nombreBuscar
        '
        Me.txt_nombreBuscar.Location = New System.Drawing.Point(73, 21)
        Me.txt_nombreBuscar.Name = "txt_nombreBuscar"
        Me.txt_nombreBuscar.Size = New System.Drawing.Size(209, 21)
        Me.txt_nombreBuscar.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Nombre:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(13, 1)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(0, 15)
        Me.lbl_id.TabIndex = 5
        Me.lbl_id.Visible = False
        '
        'FormDistribuidores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 452)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.gb_buscar)
        Me.Controls.Add(Me.dg_distribuidores)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gb_datos)
        Me.Name = "FormDistribuidores"
        Me.Text = "Datos de distribuidores"
        Me.Controls.SetChildIndex(Me.btn_salir, 0)
        Me.Controls.SetChildIndex(Me.gb_datos, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.dg_distribuidores, 0)
        Me.Controls.SetChildIndex(Me.gb_buscar, 0)
        Me.Controls.SetChildIndex(Me.lbl_id, 0)
        Me.gb_datos.ResumeLayout(False)
        Me.gb_datos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dg_distribuidores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_buscar.ResumeLayout(False)
        Me.gb_buscar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gb_datos As GroupBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_sitio_web As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents dg_distribuidores As DataGridView
    Friend WithEvents gb_buscar As GroupBox
    Friend WithEvents btn_deshacer As Button
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_nombreBuscar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_pais As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_id As Label
End Class
