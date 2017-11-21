<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCredencial
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.generar_credencialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New SistemaVideoclub.DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.generar_credencialTableAdapter = New SistemaVideoclub.DataSet1TableAdapters.generar_credencialTableAdapter()
        Me.pb_foto_socio = New System.Windows.Forms.PictureBox()
        CType(Me.generar_credencialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_foto_socio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'generar_credencialBindingSource
        '
        Me.generar_credencialBindingSource.DataMember = "generar_credencial"
        Me.generar_credencialBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.generar_credencialBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaVideoclub.Credencial.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowContextMenu = False
        Me.ReportViewer1.ShowCredentialPrompts = False
        Me.ReportViewer1.ShowDocumentMapButton = False
        Me.ReportViewer1.ShowExportButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowParameterPrompts = False
        Me.ReportViewer1.ShowProgress = False
        Me.ReportViewer1.ShowPromptAreaButton = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.ShowZoomControl = False
        Me.ReportViewer1.Size = New System.Drawing.Size(366, 212)
        Me.ReportViewer1.TabIndex = 0
        '
        'generar_credencialTableAdapter
        '
        Me.generar_credencialTableAdapter.ClearBeforeFill = True
        '
        'pb_foto_socio
        '
        Me.pb_foto_socio.Location = New System.Drawing.Point(65, 63)
        Me.pb_foto_socio.Name = "pb_foto_socio"
        Me.pb_foto_socio.Size = New System.Drawing.Size(86, 94)
        Me.pb_foto_socio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_foto_socio.TabIndex = 1
        Me.pb_foto_socio.TabStop = False
        '
        'FormCredencial
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(366, 212)
        Me.Controls.Add(Me.pb_foto_socio)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(382, 251)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(382, 251)
        Me.Name = "FormCredencial"
        Me.ShowIcon = False
        Me.Text = "Credencial de Socio"
        Me.TopMost = True
        CType(Me.generar_credencialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_foto_socio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents generar_credencialBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents generar_credencialTableAdapter As DataSet1TableAdapters.generar_credencialTableAdapter
    Public WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pb_foto_socio As PictureBox
End Class
