Public Class FormAdeudos

    Dim socio As New ClassSocio
    Dim funcionesSocio As New FuncionesSocio
    Dim funcionesAdeudo As New FuncionesAdeudo
    Dim id_adeudo As Integer

    Private Sub txt_socio_Leave(sender As Object, e As EventArgs) Handles txt_socio.Leave
        If txt_socio.Text <> Nothing Then
            Try
                socio.id = txt_socio.Text
                If funcionesSocio.existe_socio(socio) Then
                    id_adeudo = funcionesAdeudo.getUltimo_adeudo(txt_socio.Text)
                Else
                    MsgBox("No existe el socio")
                End If

            Catch ex As Exception
                MsgBox("No existe el socio")
            End Try
        End If
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Try
            funcionesAdeudo.actualizar_adeudo(txt_total_adeudo.Text, cb_estatus.Text, id_adeudo)
            funcionesAdeudo.mostrar_adeudos(dg_adeudos)
            MsgBox("Adeudo actualizado")
        Catch ex As Exception
            MsgBox("No se puede actualizar estatus")
        End Try
        If txt_total_adeudo.Text > 0 Then
            'Generar ticket
            numero_adeudo = id_adeudo
            Dim formTicketAdeudo As New FormGenerarTicketAdeudo
            formTicketAdeudo.Show()
        End If
    End Sub

    Private Sub FormAdeudos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_total_adeudo.Text = total_de_adeudo
        Try
            funcionesAdeudo.mostrar_adeudos(dg_adeudos)
        Catch ex As Exception
            MsgBox("No se pudieron cargar los datos")
        End Try
    End Sub

    Private Sub dg_adeudos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_adeudos.CellClick
        Dim i As Integer
        i = dg_adeudos.CurrentRow.Index
        id_adeudo = dg_adeudos.Item(0, i).Value
        txt_total_adeudo.Text = dg_adeudos.Item(2, i).Value
        cb_estatus.Text = dg_adeudos.Item(3, i).Value
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            funcionesAdeudo.buscar_adeudos(dg_adeudos, txt_buscar.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_deshacer_Click(sender As Object, e As EventArgs) Handles btn_deshacer.Click
        funcionesAdeudo.mostrar_adeudos(dg_adeudos)
    End Sub

    Private Sub FormAdeudos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        numero_adeudo = 0
    End Sub
End Class