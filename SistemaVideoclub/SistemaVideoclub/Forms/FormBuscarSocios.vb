Public Class FormBuscarSocios

    Dim socio As New ClassSocio
    Dim funcionesSocio As New FuncionesSocio

    Private Sub FormBuscarSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            funcionesSocio.mostrar_socios(dg_socios)
        Catch ex As Exception
            MsgBox("No se han podido cargar los datos: " + ex.Message)
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If rb_id_cliente.Checked Then
            Try
                funcionesSocio.buscar_socio(dg_socios, txt_buscar.Text)
            Catch ex As Exception
                MsgBox("No se encontro el socio")
            End Try
        ElseIf rb_nombre_cliente.Checked Then
            Try
                funcionesSocio.buscar_socio_por_nombre(dg_socios, txt_buscar.Text)
            Catch ex As Exception
                MsgBox("No se encontro el socio")
            End Try
        Else
            MsgBox("Seleccione una opcion para buscar")
        End If
    End Sub

    Private Sub btn_deshacer_Click(sender As Object, e As EventArgs) Handles btn_deshacer.Click
        Try
            funcionesSocio.mostrar_socios(dg_socios)
        Catch ex As Exception
            MsgBox("No se han podido cargar los datos: " + ex.Message)
        End Try
    End Sub

    Private Sub dg_socios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_socios.CellClick
        Dim i As Integer
        i = dg_socios.CurrentRow.Index
        lbl_id_socio.Text = dg_socios.Item(0, i).Value
    End Sub

    Private Sub btn_seleccionar_cliente_Click(sender As Object, e As EventArgs) Handles btn_seleccionar_cliente.Click

        If lbl_id_socio.Text <> Nothing Then
            socio_seleccionado = lbl_id_socio.Text
            Dim formSocios As New FormSocios
            formSocios.Show()
            Me.Close()
        Else
            MsgBox("Seleccione un socio")
        End If

    End Sub
End Class