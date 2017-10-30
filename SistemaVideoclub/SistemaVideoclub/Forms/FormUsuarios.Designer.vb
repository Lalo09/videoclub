<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarios
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_buscar_por_numero = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dg_usuario = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_nuevo_usuario = New System.Windows.Forms.Button()
        Me.btn_crear_usuario = New System.Windows.Forms.Button()
        Me.rb_hacer_admin = New System.Windows.Forms.RadioButton()
        Me.txt_repass = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_id_empleado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.rb_editar_hacer_adm = New System.Windows.Forms.RadioButton()
        Me.txt_editar_repass = New System.Windows.Forms.TextBox()
        Me.txt_editar_pass = New System.Windows.Forms.TextBox()
        Me.txt_empleado_editar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_guardar_cambios = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage2.SuspendLayout()
        CType(Me.dg_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(449, 331)
        Me.btn_salir.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.txt_buscar_por_numero)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.dg_usuario)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(528, 285)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ver usuarios"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(362, 215)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Deshacer"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(271, 215)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Buscar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txt_buscar_por_numero
        '
        Me.txt_buscar_por_numero.Location = New System.Drawing.Point(76, 216)
        Me.txt_buscar_por_numero.Name = "txt_buscar_por_numero"
        Me.txt_buscar_por_numero.Size = New System.Drawing.Size(180, 21)
        Me.txt_buscar_por_numero.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Buscar:"
        '
        'dg_usuario
        '
        Me.dg_usuario.AllowUserToAddRows = False
        Me.dg_usuario.AllowUserToDeleteRows = False
        Me.dg_usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_usuario.Location = New System.Drawing.Point(19, 28)
        Me.dg_usuario.Name = "dg_usuario"
        Me.dg_usuario.ReadOnly = True
        Me.dg_usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_usuario.Size = New System.Drawing.Size(488, 150)
        Me.dg_usuario.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.btn_nuevo_usuario)
        Me.TabPage1.Controls.Add(Me.btn_crear_usuario)
        Me.TabPage1.Controls.Add(Me.rb_hacer_admin)
        Me.TabPage1.Controls.Add(Me.txt_repass)
        Me.TabPage1.Controls.Add(Me.txt_pass)
        Me.TabPage1.Controls.Add(Me.txt_id_empleado)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(528, 285)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Agregar usuario"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_nuevo_usuario
        '
        Me.btn_nuevo_usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_nuevo_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo_usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_nuevo_usuario.Location = New System.Drawing.Point(276, 221)
        Me.btn_nuevo_usuario.Name = "btn_nuevo_usuario"
        Me.btn_nuevo_usuario.Size = New System.Drawing.Size(99, 32)
        Me.btn_nuevo_usuario.TabIndex = 5
        Me.btn_nuevo_usuario.Text = "Nuevo usuario"
        Me.btn_nuevo_usuario.UseVisualStyleBackColor = False
        '
        'btn_crear_usuario
        '
        Me.btn_crear_usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_crear_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_crear_usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_crear_usuario.Location = New System.Drawing.Point(154, 221)
        Me.btn_crear_usuario.Name = "btn_crear_usuario"
        Me.btn_crear_usuario.Size = New System.Drawing.Size(99, 32)
        Me.btn_crear_usuario.TabIndex = 4
        Me.btn_crear_usuario.Text = "Crear usuario"
        Me.btn_crear_usuario.UseVisualStyleBackColor = False
        '
        'rb_hacer_admin
        '
        Me.rb_hacer_admin.AutoSize = True
        Me.rb_hacer_admin.Location = New System.Drawing.Point(152, 173)
        Me.rb_hacer_admin.Name = "rb_hacer_admin"
        Me.rb_hacer_admin.Size = New System.Drawing.Size(141, 19)
        Me.rb_hacer_admin.TabIndex = 3
        Me.rb_hacer_admin.TabStop = True
        Me.rb_hacer_admin.Text = "Hacer administrador"
        Me.rb_hacer_admin.UseVisualStyleBackColor = True
        '
        'txt_repass
        '
        Me.txt_repass.Location = New System.Drawing.Point(156, 128)
        Me.txt_repass.Name = "txt_repass"
        Me.txt_repass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_repass.Size = New System.Drawing.Size(180, 21)
        Me.txt_repass.TabIndex = 2
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(156, 84)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(180, 21)
        Me.txt_pass.TabIndex = 1
        '
        'txt_id_empleado
        '
        Me.txt_id_empleado.Location = New System.Drawing.Point(156, 39)
        Me.txt_id_empleado.Name = "txt_id_empleado"
        Me.txt_id_empleado.Size = New System.Drawing.Size(97, 21)
        Me.txt_id_empleado.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Repetir contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nueva Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero de empleado:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(536, 313)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PictureBox2)
        Me.TabPage3.Controls.Add(Me.rb_editar_hacer_adm)
        Me.TabPage3.Controls.Add(Me.txt_editar_repass)
        Me.TabPage3.Controls.Add(Me.txt_editar_pass)
        Me.TabPage3.Controls.Add(Me.txt_empleado_editar)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.btn_guardar_cambios)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(528, 285)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Editar usuario"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SistemaVideoclub.My.Resources.Resources.user
        Me.PictureBox2.Location = New System.Drawing.Point(379, 36)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 113)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'rb_editar_hacer_adm
        '
        Me.rb_editar_hacer_adm.AutoSize = True
        Me.rb_editar_hacer_adm.Location = New System.Drawing.Point(156, 177)
        Me.rb_editar_hacer_adm.Name = "rb_editar_hacer_adm"
        Me.rb_editar_hacer_adm.Size = New System.Drawing.Size(141, 19)
        Me.rb_editar_hacer_adm.TabIndex = 21
        Me.rb_editar_hacer_adm.TabStop = True
        Me.rb_editar_hacer_adm.Text = "Hacer administrador"
        Me.rb_editar_hacer_adm.UseVisualStyleBackColor = True
        '
        'txt_editar_repass
        '
        Me.txt_editar_repass.Location = New System.Drawing.Point(156, 128)
        Me.txt_editar_repass.Name = "txt_editar_repass"
        Me.txt_editar_repass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_editar_repass.Size = New System.Drawing.Size(180, 21)
        Me.txt_editar_repass.TabIndex = 20
        '
        'txt_editar_pass
        '
        Me.txt_editar_pass.Location = New System.Drawing.Point(156, 81)
        Me.txt_editar_pass.Name = "txt_editar_pass"
        Me.txt_editar_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_editar_pass.Size = New System.Drawing.Size(180, 21)
        Me.txt_editar_pass.TabIndex = 18
        '
        'txt_empleado_editar
        '
        Me.txt_empleado_editar.Location = New System.Drawing.Point(156, 36)
        Me.txt_empleado_editar.Name = "txt_empleado_editar"
        Me.txt_empleado_editar.Size = New System.Drawing.Size(97, 21)
        Me.txt_empleado_editar.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Repetir contraseña:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Contraseña:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Numero de empleado:"
        '
        'btn_guardar_cambios
        '
        Me.btn_guardar_cambios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_guardar_cambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar_cambios.Font = New System.Drawing.Font("MS Reference Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar_cambios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_guardar_cambios.Location = New System.Drawing.Point(157, 224)
        Me.btn_guardar_cambios.Name = "btn_guardar_cambios"
        Me.btn_guardar_cambios.Size = New System.Drawing.Size(99, 46)
        Me.btn_guardar_cambios.TabIndex = 14
        Me.btn_guardar_cambios.Text = "Guardar cambios"
        Me.btn_guardar_cambios.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaVideoclub.My.Resources.Resources.user
        Me.PictureBox1.Location = New System.Drawing.Point(375, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 375)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormUsuarios"
        Me.Text = "Usuarios"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.btn_salir, 0)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dg_usuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txt_buscar_por_numero As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dg_usuario As DataGridView
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_nuevo_usuario As Button
    Friend WithEvents btn_crear_usuario As Button
    Friend WithEvents rb_hacer_admin As RadioButton
    Friend WithEvents txt_repass As TextBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents txt_id_empleado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btn_guardar_cambios As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents rb_editar_hacer_adm As RadioButton
    Friend WithEvents txt_editar_repass As TextBox
    Friend WithEvents txt_editar_pass As TextBox
    Friend WithEvents txt_empleado_editar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
