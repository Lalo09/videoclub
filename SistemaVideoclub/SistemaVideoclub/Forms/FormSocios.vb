Public Class FormSocios

    Public ruta_foto As String

    Private Sub btn_cargar_foto_Click(sender As Object, e As EventArgs) Handles btn_cargar_foto.Click

        If ofd_foto.ShowDialog = DialogResult.OK Then
            ruta_foto = ofd_foto.FileName
        End If

        pb_foto_cliente.ImageLocation = ruta_foto
    End Sub

    Private Sub btn_eliminar_foto_Click(sender As Object, e As EventArgs) Handles btn_eliminar_foto.Click
        pb_foto_cliente.ImageLocation = ""
    End Sub
End Class