<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.pb_main = New System.Windows.Forms.PictureBox()
        Me.pb_user = New System.Windows.Forms.PictureBox()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        CType(Me.pb_main, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(231, 291)
        Me.btn_salir.TabIndex = 3
        '
        'pb_main
        '
        Me.pb_main.Image = Global.SistemaVideoclub.My.Resources.Resources.logo
        Me.pb_main.Location = New System.Drawing.Point(95, 22)
        Me.pb_main.Name = "pb_main"
        Me.pb_main.Size = New System.Drawing.Size(207, 105)
        Me.pb_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_main.TabIndex = 2
        Me.pb_main.TabStop = False
        '
        'pb_user
        '
        Me.pb_user.Image = Global.SistemaVideoclub.My.Resources.Resources.user
        Me.pb_user.Location = New System.Drawing.Point(31, 165)
        Me.pb_user.Name = "pb_user"
        Me.pb_user.Size = New System.Drawing.Size(86, 81)
        Me.pb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_user.TabIndex = 1
        Me.pb_user.TabStop = False
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Location = New System.Drawing.Point(151, 188)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(55, 15)
        Me.lbl_user.TabIndex = 4
        Me.lbl_user.Text = "Usuario:"
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Location = New System.Drawing.Point(128, 216)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(78, 15)
        Me.lbl_pass.TabIndex = 5
        Me.lbl_pass.Text = "Contraseña:"
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(212, 185)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(118, 21)
        Me.txt_user.TabIndex = 0
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(212, 213)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(118, 21)
        Me.txt_pass.TabIndex = 1
        '
        'btn_ingresar
        '
        Me.btn_ingresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ingresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_ingresar.Location = New System.Drawing.Point(119, 291)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(99, 32)
        Me.btn_ingresar.TabIndex = 2
        Me.btn_ingresar.Text = "Ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = False
        '
        'FormLogin
        '
        Me.AcceptButton = Me.btn_ingresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 352)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.pb_main)
        Me.Controls.Add(Me.pb_user)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.ShowIcon = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Controls.SetChildIndex(Me.btn_salir, 0)
        Me.Controls.SetChildIndex(Me.pb_user, 0)
        Me.Controls.SetChildIndex(Me.pb_main, 0)
        Me.Controls.SetChildIndex(Me.lbl_user, 0)
        Me.Controls.SetChildIndex(Me.lbl_pass, 0)
        Me.Controls.SetChildIndex(Me.txt_user, 0)
        Me.Controls.SetChildIndex(Me.txt_pass, 0)
        Me.Controls.SetChildIndex(Me.btn_ingresar, 0)
        CType(Me.pb_main, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_user As PictureBox
    Friend WithEvents pb_main As PictureBox
    Friend WithEvents lbl_user As Label
    Friend WithEvents lbl_pass As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents btn_ingresar As Button
End Class
