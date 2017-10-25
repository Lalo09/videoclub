<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.gb_datosCliente = New System.Windows.Forms.GroupBox()
        Me.txt_ap_materno = New System.Windows.Forms.TextBox()
        Me.txt_ap_paterno = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_ap_materno = New System.Windows.Forms.Label()
        Me.lbl_ap_paterno = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.gb_acciones = New System.Windows.Forms.GroupBox()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.bnt_hacer_socio = New System.Windows.Forms.Button()
        Me.dg_clientes = New System.Windows.Forms.DataGridView()
        Me.gb_buscar = New System.Windows.Forms.GroupBox()
        Me.btn_deshacerBusqueda = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_buscarCliente = New System.Windows.Forms.TextBox()
        Me.lbl_nombre_cliente = New System.Windows.Forms.Label()
        Me.gb_datosCliente.SuspendLayout()
        Me.gb_acciones.SuspendLayout()
        CType(Me.dg_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_buscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(606, 370)
        Me.btn_salir.TabIndex = 10
        '
        'btn_grabar
        '
        Me.btn_grabar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_grabar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_grabar.Location = New System.Drawing.Point(29, 44)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(99, 32)
        Me.btn_grabar.TabIndex = 3
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_eliminar.Location = New System.Drawing.Point(29, 112)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(99, 32)
        Me.btn_eliminar.TabIndex = 4
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'gb_datosCliente
        '
        Me.gb_datosCliente.BackColor = System.Drawing.Color.White
        Me.gb_datosCliente.Controls.Add(Me.txt_ap_materno)
        Me.gb_datosCliente.Controls.Add(Me.txt_ap_paterno)
        Me.gb_datosCliente.Controls.Add(Me.txt_nombre)
        Me.gb_datosCliente.Controls.Add(Me.lbl_ap_materno)
        Me.gb_datosCliente.Controls.Add(Me.lbl_ap_paterno)
        Me.gb_datosCliente.Controls.Add(Me.lbl_nombre)
        Me.gb_datosCliente.Controls.Add(Me.lbl_id)
        Me.gb_datosCliente.Location = New System.Drawing.Point(12, 12)
        Me.gb_datosCliente.Name = "gb_datosCliente"
        Me.gb_datosCliente.Size = New System.Drawing.Size(429, 183)
        Me.gb_datosCliente.TabIndex = 3
        Me.gb_datosCliente.TabStop = False
        Me.gb_datosCliente.Text = "Datos del cliente"
        '
        'txt_ap_materno
        '
        Me.txt_ap_materno.Location = New System.Drawing.Point(141, 126)
        Me.txt_ap_materno.Name = "txt_ap_materno"
        Me.txt_ap_materno.Size = New System.Drawing.Size(203, 21)
        Me.txt_ap_materno.TabIndex = 2
        '
        'txt_ap_paterno
        '
        Me.txt_ap_paterno.Location = New System.Drawing.Point(141, 83)
        Me.txt_ap_paterno.Name = "txt_ap_paterno"
        Me.txt_ap_paterno.Size = New System.Drawing.Size(203, 21)
        Me.txt_ap_paterno.TabIndex = 1
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(141, 42)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(155, 21)
        Me.txt_nombre.TabIndex = 0
        '
        'lbl_ap_materno
        '
        Me.lbl_ap_materno.AutoSize = True
        Me.lbl_ap_materno.Location = New System.Drawing.Point(23, 129)
        Me.lbl_ap_materno.Name = "lbl_ap_materno"
        Me.lbl_ap_materno.Size = New System.Drawing.Size(112, 15)
        Me.lbl_ap_materno.TabIndex = 13
        Me.lbl_ap_materno.Text = "Apellido_materno:"
        '
        'lbl_ap_paterno
        '
        Me.lbl_ap_paterno.AutoSize = True
        Me.lbl_ap_paterno.Location = New System.Drawing.Point(30, 86)
        Me.lbl_ap_paterno.Name = "lbl_ap_paterno"
        Me.lbl_ap_paterno.Size = New System.Drawing.Size(105, 15)
        Me.lbl_ap_paterno.TabIndex = 12
        Me.lbl_ap_paterno.Text = "Apellido paterno:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(60, 44)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(75, 15)
        Me.lbl_nombre.TabIndex = 11
        Me.lbl_nombre.Text = "Nombre(S):"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(16, 17)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(0, 15)
        Me.lbl_id.TabIndex = 10
        Me.lbl_id.Visible = False

        '
        'gb_acciones
        '
        Me.gb_acciones.Controls.Add(Me.btn_nuevo)
        Me.gb_acciones.Controls.Add(Me.bnt_hacer_socio)
        Me.gb_acciones.Controls.Add(Me.btn_eliminar)
        Me.gb_acciones.Controls.Add(Me.btn_grabar)
        Me.gb_acciones.Location = New System.Drawing.Point(454, 12)
        Me.gb_acciones.Name = "gb_acciones"
        Me.gb_acciones.Size = New System.Drawing.Size(277, 183)
        Me.gb_acciones.TabIndex = 4
        Me.gb_acciones.TabStop = False
        Me.gb_acciones.Text = "Acciones"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_nuevo.Location = New System.Drawing.Point(152, 112)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(99, 32)
        Me.btn_nuevo.TabIndex = 6
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'bnt_hacer_socio
        '
        Me.bnt_hacer_socio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bnt_hacer_socio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnt_hacer_socio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bnt_hacer_socio.Location = New System.Drawing.Point(152, 44)
        Me.bnt_hacer_socio.Name = "bnt_hacer_socio"
        Me.bnt_hacer_socio.Size = New System.Drawing.Size(99, 32)
        Me.bnt_hacer_socio.TabIndex = 5
        Me.bnt_hacer_socio.Text = "Hacer socio"
        Me.bnt_hacer_socio.UseVisualStyleBackColor = False
        '
        'dg_clientes
        '
        Me.dg_clientes.AllowUserToAddRows = False
        Me.dg_clientes.AllowUserToDeleteRows = False
        Me.dg_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_clientes.BackgroundColor = System.Drawing.Color.Silver
        Me.dg_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_clientes.Location = New System.Drawing.Point(12, 201)
        Me.dg_clientes.Name = "dg_clientes"
        Me.dg_clientes.ReadOnly = True
        Me.dg_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_clientes.Size = New System.Drawing.Size(719, 132)
        Me.dg_clientes.TabIndex = 11
        '
        'gb_buscar
        '
        Me.gb_buscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_buscar.Controls.Add(Me.btn_deshacerBusqueda)
        Me.gb_buscar.Controls.Add(Me.btn_buscar)
        Me.gb_buscar.Controls.Add(Me.txt_buscarCliente)
        Me.gb_buscar.Controls.Add(Me.lbl_nombre_cliente)
        Me.gb_buscar.Location = New System.Drawing.Point(12, 345)
        Me.gb_buscar.Name = "gb_buscar"
        Me.gb_buscar.Size = New System.Drawing.Size(570, 77)
        Me.gb_buscar.TabIndex = 6
        Me.gb_buscar.TabStop = False
        Me.gb_buscar.Text = "Buscar"
        '
        'btn_deshacerBusqueda
        '
        Me.btn_deshacerBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_deshacerBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deshacerBusqueda.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_deshacerBusqueda.Location = New System.Drawing.Point(490, 25)
        Me.btn_deshacerBusqueda.Name = "btn_deshacerBusqueda"
        Me.btn_deshacerBusqueda.Size = New System.Drawing.Size(46, 32)
        Me.btn_deshacerBusqueda.TabIndex = 9
        Me.btn_deshacerBusqueda.Text = "Des"
        Me.btn_deshacerBusqueda.UseVisualStyleBackColor = False
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_buscar.Location = New System.Drawing.Point(360, 25)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(99, 32)
        Me.btn_buscar.TabIndex = 8
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_buscarCliente
        '
        Me.txt_buscarCliente.Location = New System.Drawing.Point(141, 31)
        Me.txt_buscarCliente.Name = "txt_buscarCliente"
        Me.txt_buscarCliente.Size = New System.Drawing.Size(203, 21)
        Me.txt_buscarCliente.TabIndex = 7
        '
        'lbl_nombre_cliente
        '
        Me.lbl_nombre_cliente.AutoSize = True
        Me.lbl_nombre_cliente.Location = New System.Drawing.Point(17, 34)
        Me.lbl_nombre_cliente.Name = "lbl_nombre_cliente"
        Me.lbl_nombre_cliente.Size = New System.Drawing.Size(119, 15)
        Me.lbl_nombre_cliente.TabIndex = 0
        Me.lbl_nombre_cliente.Text = "Nombre del cliente:"
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 434)
        Me.Controls.Add(Me.gb_buscar)
        Me.Controls.Add(Me.dg_clientes)
        Me.Controls.Add(Me.gb_datosCliente)
        Me.Controls.Add(Me.gb_acciones)
        Me.Name = "FormClientes"
        Me.Text = "Clientes"
        Me.Controls.SetChildIndex(Me.gb_acciones, 0)
        Me.Controls.SetChildIndex(Me.gb_datosCliente, 0)
        Me.Controls.SetChildIndex(Me.dg_clientes, 0)
        Me.Controls.SetChildIndex(Me.gb_buscar, 0)
        Me.Controls.SetChildIndex(Me.btn_salir, 0)
        Me.gb_datosCliente.ResumeLayout(False)
        Me.gb_datosCliente.PerformLayout()
        Me.gb_acciones.ResumeLayout(False)
        CType(Me.dg_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_buscar.ResumeLayout(False)
        Me.gb_buscar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_grabar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents gb_datosCliente As GroupBox
    Friend WithEvents txt_ap_materno As TextBox
    Friend WithEvents txt_ap_paterno As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl_ap_materno As Label
    Friend WithEvents lbl_ap_paterno As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents gb_acciones As GroupBox
    Friend WithEvents bnt_hacer_socio As Button
    Friend WithEvents dg_clientes As DataGridView
    Friend WithEvents gb_buscar As GroupBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_buscarCliente As TextBox
    Friend WithEvents lbl_nombre_cliente As Label
    Friend WithEvents btn_deshacerBusqueda As Button
    Friend WithEvents btn_nuevo As Button
End Class
