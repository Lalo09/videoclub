<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscarSocios
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
        Me.gb_opciones_buscar = New System.Windows.Forms.GroupBox()
        Me.lbl_id_socio = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.rb_nombre_cliente = New System.Windows.Forms.RadioButton()
        Me.rb_id_cliente = New System.Windows.Forms.RadioButton()
        Me.lbl_buscar_por = New System.Windows.Forms.Label()
        Me.dg_socios = New System.Windows.Forms.DataGridView()
        Me.gb_botones = New System.Windows.Forms.GroupBox()
        Me.btn_deshacer = New System.Windows.Forms.Button()
        Me.btn_seleccionar_cliente = New System.Windows.Forms.Button()
        Me.gb_opciones_buscar.SuspendLayout()
        CType(Me.dg_socios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salir.Location = New System.Drawing.Point(1052, 475)
        Me.btn_salir.TabIndex = 6
        '
        'gb_opciones_buscar
        '
        Me.gb_opciones_buscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_opciones_buscar.Controls.Add(Me.lbl_id_socio)
        Me.gb_opciones_buscar.Controls.Add(Me.btn_buscar)
        Me.gb_opciones_buscar.Controls.Add(Me.txt_buscar)
        Me.gb_opciones_buscar.Controls.Add(Me.rb_nombre_cliente)
        Me.gb_opciones_buscar.Controls.Add(Me.rb_id_cliente)
        Me.gb_opciones_buscar.Controls.Add(Me.lbl_buscar_por)
        Me.gb_opciones_buscar.Location = New System.Drawing.Point(21, 12)
        Me.gb_opciones_buscar.Name = "gb_opciones_buscar"
        Me.gb_opciones_buscar.Size = New System.Drawing.Size(1195, 103)
        Me.gb_opciones_buscar.TabIndex = 1
        Me.gb_opciones_buscar.TabStop = False
        '
        'lbl_id_socio
        '
        Me.lbl_id_socio.AutoSize = True
        Me.lbl_id_socio.Location = New System.Drawing.Point(98, 27)
        Me.lbl_id_socio.Name = "lbl_id_socio"
        Me.lbl_id_socio.Size = New System.Drawing.Size(0, 15)
        Me.lbl_id_socio.TabIndex = 5
        Me.lbl_id_socio.Visible = False
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_buscar.Location = New System.Drawing.Point(536, 48)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(99, 32)
        Me.btn_buscar.TabIndex = 3
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(324, 54)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(188, 21)
        Me.txt_buscar.TabIndex = 2
        '
        'rb_nombre_cliente
        '
        Me.rb_nombre_cliente.AutoSize = True
        Me.rb_nombre_cliente.Location = New System.Drawing.Point(181, 54)
        Me.rb_nombre_cliente.Name = "rb_nombre_cliente"
        Me.rb_nombre_cliente.Size = New System.Drawing.Size(137, 19)
        Me.rb_nombre_cliente.TabIndex = 1
        Me.rb_nombre_cliente.TabStop = True
        Me.rb_nombre_cliente.Text = "Nombre del cliente:"
        Me.rb_nombre_cliente.UseVisualStyleBackColor = True
        '
        'rb_id_cliente
        '
        Me.rb_id_cliente.AutoSize = True
        Me.rb_id_cliente.Location = New System.Drawing.Point(24, 54)
        Me.rb_id_cliente.Name = "rb_id_cliente"
        Me.rb_id_cliente.Size = New System.Drawing.Size(126, 19)
        Me.rb_id_cliente.TabIndex = 0
        Me.rb_id_cliente.TabStop = True
        Me.rb_id_cliente.Text = "Numero de socio:"
        Me.rb_id_cliente.UseVisualStyleBackColor = True
        '
        'lbl_buscar_por
        '
        Me.lbl_buscar_por.AutoSize = True
        Me.lbl_buscar_por.Location = New System.Drawing.Point(18, 27)
        Me.lbl_buscar_por.Name = "lbl_buscar_por"
        Me.lbl_buscar_por.Size = New System.Drawing.Size(74, 15)
        Me.lbl_buscar_por.TabIndex = 0
        Me.lbl_buscar_por.Text = "Buscar por:"
        '
        'dg_socios
        '
        Me.dg_socios.AllowUserToAddRows = False
        Me.dg_socios.AllowUserToDeleteRows = False
        Me.dg_socios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_socios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_socios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_socios.Location = New System.Drawing.Point(21, 131)
        Me.dg_socios.Name = "dg_socios"
        Me.dg_socios.ReadOnly = True
        Me.dg_socios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_socios.Size = New System.Drawing.Size(1195, 312)
        Me.dg_socios.TabIndex = 7
        '
        'gb_botones
        '
        Me.gb_botones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_botones.Controls.Add(Me.btn_deshacer)
        Me.gb_botones.Controls.Add(Me.btn_seleccionar_cliente)
        Me.gb_botones.Location = New System.Drawing.Point(516, 449)
        Me.gb_botones.Name = "gb_botones"
        Me.gb_botones.Size = New System.Drawing.Size(261, 65)
        Me.gb_botones.TabIndex = 3
        Me.gb_botones.TabStop = False
        '
        'btn_deshacer
        '
        Me.btn_deshacer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_deshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deshacer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_deshacer.Location = New System.Drawing.Point(132, 13)
        Me.btn_deshacer.Name = "btn_deshacer"
        Me.btn_deshacer.Size = New System.Drawing.Size(120, 45)
        Me.btn_deshacer.TabIndex = 5
        Me.btn_deshacer.Text = "Deshacer busqueda"
        Me.btn_deshacer.UseVisualStyleBackColor = False
        '
        'btn_seleccionar_cliente
        '
        Me.btn_seleccionar_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_seleccionar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_seleccionar_cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_seleccionar_cliente.Location = New System.Drawing.Point(6, 13)
        Me.btn_seleccionar_cliente.Name = "btn_seleccionar_cliente"
        Me.btn_seleccionar_cliente.Size = New System.Drawing.Size(120, 45)
        Me.btn_seleccionar_cliente.TabIndex = 4
        Me.btn_seleccionar_cliente.Text = "Seleccionar socio"
        Me.btn_seleccionar_cliente.UseVisualStyleBackColor = False
        '
        'FormBuscarSocios
        '
        Me.AcceptButton = Me.btn_buscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 526)
        Me.Controls.Add(Me.gb_botones)
        Me.Controls.Add(Me.dg_socios)
        Me.Controls.Add(Me.gb_opciones_buscar)
        Me.MaximizeBox = True
        Me.Name = "FormBuscarSocios"
        Me.Text = "Buscar socio"
        Me.TopMost = True
        Me.Controls.SetChildIndex(Me.gb_opciones_buscar, 0)
        Me.Controls.SetChildIndex(Me.dg_socios, 0)
        Me.Controls.SetChildIndex(Me.btn_salir, 0)
        Me.Controls.SetChildIndex(Me.gb_botones, 0)
        Me.gb_opciones_buscar.ResumeLayout(False)
        Me.gb_opciones_buscar.PerformLayout()
        CType(Me.dg_socios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_opciones_buscar As GroupBox
    Friend WithEvents lbl_id_socio As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents rb_nombre_cliente As RadioButton
    Friend WithEvents rb_id_cliente As RadioButton
    Friend WithEvents lbl_buscar_por As Label
    Friend WithEvents dg_socios As DataGridView
    Friend WithEvents gb_botones As GroupBox
    Friend WithEvents btn_deshacer As Button
    Friend WithEvents btn_seleccionar_cliente As Button
End Class
