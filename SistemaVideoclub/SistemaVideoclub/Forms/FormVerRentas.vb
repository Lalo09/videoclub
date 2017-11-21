Public Class FormVerRentas

    Dim funcionesRenta As New FuncionesRenta

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If rb_por_socio.Checked = True Then
            funcionesRenta.buscar_rentas_idSocio(dg_rentas, dt_desde.Value.ToString("MM/dd/yyyy"), dt_hasta.Value.Date.ToString("MM/dd/yyyy"), txt_buscar.Text)
        ElseIf rb_por_renta.Checked = True Then
            funcionesRenta.buscar_rentas_idrenta(dg_rentas, dt_desde.Value.ToString("MM/dd/yyyy"), dt_hasta.Value.Date.ToString("MM/dd/yyyy"), txt_buscar.Text)
        Else
            MsgBox("Seleccione una opcion")
        End If
    End Sub

    Private Sub FormVerRentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            funcionesRenta.mostrar_rentas(dg_rentas)
        Catch ex As Exception
            MsgBox("no se pudieron cargar los datos")
        End Try
    End Sub
End Class