<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDevoluciones
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
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmb_estado_pelicula = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombre_pelicula = New System.Windows.Forms.TextBox()
        Me.txt_id_pelicula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nombre_socio = New System.Windows.Forms.TextBox()
        Me.txt_id_socio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_terminar_devolucion = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dg_devoluciones = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_deshacer = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dg__detalle_renta = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_devoluciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dg__detalle_renta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(657, 453)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_agregar)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.cmb_estado_pelicula)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_pelicula)
        Me.GroupBox1.Controls.Add(Me.txt_id_pelicula)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 174)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de devolucion"
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_agregar.Location = New System.Drawing.Point(151, 126)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(99, 32)
        Me.btn_agregar.TabIndex = 3
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(290, 126)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cmb_estado_pelicula
        '
        Me.cmb_estado_pelicula.FormattingEnabled = True
        Me.cmb_estado_pelicula.Items.AddRange(New Object() {"Buen estado", "Mal estado"})
        Me.cmb_estado_pelicula.Location = New System.Drawing.Point(151, 76)
        Me.cmb_estado_pelicula.Name = "cmb_estado_pelicula"
        Me.cmb_estado_pelicula.Size = New System.Drawing.Size(157, 23)
        Me.cmb_estado_pelicula.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Estado de la pelicula:"
        '
        'txt_nombre_pelicula
        '
        Me.txt_nombre_pelicula.Enabled = False
        Me.txt_nombre_pelicula.Location = New System.Drawing.Point(151, 36)
        Me.txt_nombre_pelicula.Name = "txt_nombre_pelicula"
        Me.txt_nombre_pelicula.Size = New System.Drawing.Size(238, 21)
        Me.txt_nombre_pelicula.TabIndex = 2
        '
        'txt_id_pelicula
        '
        Me.txt_id_pelicula.Location = New System.Drawing.Point(79, 36)
        Me.txt_id_pelicula.Name = "txt_id_pelicula"
        Me.txt_id_pelicula.Size = New System.Drawing.Size(66, 21)
        Me.txt_id_pelicula.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pelicula:"
        '
        'txt_nombre_socio
        '
        Me.txt_nombre_socio.Enabled = False
        Me.txt_nombre_socio.Location = New System.Drawing.Point(151, 21)
        Me.txt_nombre_socio.Name = "txt_nombre_socio"
        Me.txt_nombre_socio.Size = New System.Drawing.Size(238, 21)
        Me.txt_nombre_socio.TabIndex = 5
        '
        'txt_id_socio
        '
        Me.txt_id_socio.Location = New System.Drawing.Point(92, 34)
        Me.txt_id_socio.Name = "txt_id_socio"
        Me.txt_id_socio.Size = New System.Drawing.Size(66, 21)
        Me.txt_id_socio.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Socio:"
        '
        'btn_terminar_devolucion
        '
        Me.btn_terminar_devolucion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_terminar_devolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_terminar_devolucion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_terminar_devolucion.Location = New System.Drawing.Point(6, 20)
        Me.btn_terminar_devolucion.Name = "btn_terminar_devolucion"
        Me.btn_terminar_devolucion.Size = New System.Drawing.Size(244, 32)
        Me.btn_terminar_devolucion.TabIndex = 0
        Me.btn_terminar_devolucion.Text = "Guardar devolucion"
        Me.btn_terminar_devolucion.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(290, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Nuevo"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'dg_devoluciones
        '
        Me.dg_devoluciones.AllowUserToAddRows = False
        Me.dg_devoluciones.AllowUserToDeleteRows = False
        Me.dg_devoluciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_devoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_devoluciones.Location = New System.Drawing.Point(13, 322)
        Me.dg_devoluciones.Name = "dg_devoluciones"
        Me.dg_devoluciones.ReadOnly = True
        Me.dg_devoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_devoluciones.Size = New System.Drawing.Size(777, 105)
        Me.dg_devoluciones.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaVideoclub.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(471, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.btn_terminar_devolucion)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 62)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acciones"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_nombre_socio)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(409, 55)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de socio"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(468, 34)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(0, 15)
        Me.lbl_id.TabIndex = 7
        Me.lbl_id.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_deshacer)
        Me.GroupBox4.Controls.Add(Me.btn_buscar)
        Me.GroupBox4.Controls.Add(Me.txt_buscar)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 433)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(619, 61)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buscar:"
        '
        'btn_deshacer
        '
        Me.btn_deshacer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_deshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deshacer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_deshacer.Location = New System.Drawing.Point(407, 20)
        Me.btn_deshacer.Name = "btn_deshacer"
        Me.btn_deshacer.Size = New System.Drawing.Size(134, 32)
        Me.btn_deshacer.TabIndex = 4
        Me.btn_deshacer.Text = "Deshacer busqueda"
        Me.btn_deshacer.UseVisualStyleBackColor = False
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_buscar.Location = New System.Drawing.Point(284, 20)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(99, 32)
        Me.btn_buscar.TabIndex = 3
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(138, 26)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(106, 21)
        Me.txt_buscar.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Numero de socio:"
        '
        'dg__detalle_renta
        '
        Me.dg__detalle_renta.AllowUserToAddRows = False
        Me.dg__detalle_renta.AllowUserToDeleteRows = False
        Me.dg__detalle_renta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg__detalle_renta.Location = New System.Drawing.Point(471, 209)
        Me.dg__detalle_renta.Name = "dg__detalle_renta"
        Me.dg__detalle_renta.ReadOnly = True
        Me.dg__detalle_renta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg__detalle_renta.Size = New System.Drawing.Size(319, 107)
        Me.dg__detalle_renta.TabIndex = 9
        '
        'FormDevoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 506)
        Me.Controls.Add(Me.dg__detalle_renta)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dg_devoluciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_id_socio)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "FormDevoluciones"
        Me.Text = "Devoluciones"
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.txt_id_socio, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.dg_devoluciones, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.lbl_id, 0)
        Me.Controls.SetChildIndex(Me.btn_salir, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.dg__detalle_renta, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg_devoluciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dg__detalle_renta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_estado_pelicula As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nombre_socio As TextBox
    Friend WithEvents txt_id_socio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nombre_pelicula As TextBox
    Friend WithEvents txt_id_pelicula As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_terminar_devolucion As Button
    Friend WithEvents dg_devoluciones As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents lbl_id As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_deshacer As Button
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dg__detalle_renta As DataGridView
End Class
