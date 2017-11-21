Public Class FormGenerarReciboRenta
    Private Sub FormGenerarReciboRenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.generar_renta' Puede moverla o quitarla según sea necesario.
        Me.generar_rentaTableAdapter.Fill(Me.DataSet1.generar_renta, numero_de_renta)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class