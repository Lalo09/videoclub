<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGenerarReciboRenta
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
        Me.generar_rentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New SistemaVideoclub.DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.generar_rentaTableAdapter = New SistemaVideoclub.DataSet1TableAdapters.generar_rentaTableAdapter()
        CType(Me.generar_rentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'generar_rentaBindingSource
        '
        Me.generar_rentaBindingSource.DataMember = "generar_renta"
        Me.generar_rentaBindingSource.DataSource = Me.DataSet1
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
        ReportDataSource1.Value = Me.generar_rentaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaVideoclub.TicketRenta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(649, 441)
        Me.ReportViewer1.TabIndex = 0
        '
        'generar_rentaTableAdapter
        '
        Me.generar_rentaTableAdapter.ClearBeforeFill = True
        '
        'FormGenerarReciboRenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 441)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(665, 480)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(665, 480)
        Me.Name = "FormGenerarReciboRenta"
        Me.ShowIcon = False
        Me.Text = "Recibo de renta"
        Me.TopMost = True
        CType(Me.generar_rentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents generar_rentaBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents generar_rentaTableAdapter As DataSet1TableAdapters.generar_rentaTableAdapter
End Class
