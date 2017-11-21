Public Class FormGenerarReciboVenta
    Private Sub FormGenerarReciboVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.generar_venta' Puede moverla o quitarla según sea necesario.
        Me.generar_ventaTableAdapter.Fill(Me.DataSet1.generar_venta, numero_de_venta)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class