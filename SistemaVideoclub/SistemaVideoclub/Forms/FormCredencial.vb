Public Class FormCredencial
    Private Sub FormCredencial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.generar_credencial' Puede moverla o quitarla según sea necesario.
        Me.generar_credencialTableAdapter.Fill(Me.DataSet1.generar_credencial, num_socio_credencia)

        Me.ReportViewer1.RefreshReport()
        pb_foto_socio.ImageLocation = imagen_socio
    End Sub
End Class