Public Class FormGenerarTicketAdeudo
    Private Sub FormGenerarTicketAdeudo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.generar_adeudo' Puede moverla o quitarla según sea necesario.
        Me.generar_adeudoTableAdapter.Fill(Me.DataSet1.generar_adeudo, numero_adeudo)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class