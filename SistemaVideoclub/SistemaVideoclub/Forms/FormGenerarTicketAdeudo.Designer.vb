﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGenerarTicketAdeudo
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet1 = New SistemaVideoclub.DataSet1()
        Me.generar_adeudoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.generar_adeudoTableAdapter = New SistemaVideoclub.DataSet1TableAdapters.generar_adeudoTableAdapter()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.generar_adeudoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.generar_adeudoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaVideoclub.TicketAdeudo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(610, 441)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'generar_adeudoBindingSource
        '
        Me.generar_adeudoBindingSource.DataMember = "generar_adeudo"
        Me.generar_adeudoBindingSource.DataSource = Me.DataSet1
        '
        'generar_adeudoTableAdapter
        '
        Me.generar_adeudoTableAdapter.ClearBeforeFill = True
        '
        'FormGenerarTicketAdeudo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 441)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(626, 480)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(626, 480)
        Me.Name = "FormGenerarTicketAdeudo"
        Me.ShowIcon = False
        Me.Text = "Recibo adeudo"
        Me.TopMost = True
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.generar_adeudoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents generar_adeudoBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents generar_adeudoTableAdapter As DataSet1TableAdapters.generar_adeudoTableAdapter
End Class
