Public Class FormPeliculas

    Private ruta_foto As String
    Dim pelicula As New ClassPelicula
    Dim funcionesPelicula As New FuncionesPelicula

    Private Sub FormPeliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conectar()
            funcionesPelicula.llenarCombo(cmb_distribuidores)
            Desconectar()
        Catch ex As Exception
            MsgBox("No se pudieron cargar los datos")
        End Try
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If lbl_id.Text <> Nothing Then
            pelicula.id = lbl_id.Text
        Else
            pelicula.id = -1
        End If

        If funcionesPelicula.existe_pelicula(pelicula) Then



        End If

    End Sub

    Private Sub cmb_distribuidores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_distribuidores.SelectedIndexChanged
        'MsgBox(funcionesPelicula.getId_distribuidor(cmb_distribuidores.SelectedItem.ToString)) 'Revisar si trae el id dado el nombre de un distribuidor
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        'MsgBox(funcionesPelicula.getNombre_distribuidor(TextBox1.Text))
        'cmb_distribuidores.Text = funcionesPelicula.getNombre_distribuidor(TextBox1.Text)
    End Sub

    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click
        If ofd_foto.ShowDialog = DialogResult.OK Then
            ruta_foto = ofd_foto.FileName
        End If

        pb_foto.ImageLocation = ruta_foto
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        pb_foto.ImageLocation = ""
    End Sub
End Class