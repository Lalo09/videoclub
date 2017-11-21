Public Class FormPeliculas

    Private ruta_foto As String
    Dim pelicula As New ClassPelicula
    Dim funcionesPelicula As New FuncionesPelicula

    Private Sub FormPeliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conectar()
            funcionesPelicula.llenarCombo(cmb_distribuidores)
            Desconectar()
            funcionesPelicula.mostrar_pelicula(dg_peliculas)
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

            If txt_nombre.Text <> Nothing And txt_duracion.Text <> Nothing And cmb_genero.SelectedItem <> Nothing And cmb_clasificacion.SelectedItem <> Nothing And txt_pais.Text <> Nothing And txt_director.Text <> Nothing And cmb_distribuidores.Text <> Nothing And rtxt_sinopsis.Text <> Nothing And txt_precio_compra.Text <> Nothing And txt_precio_renta.Text <> Nothing And txt_precio_venta.Text <> Nothing Then

                pelicula.nombre = txt_nombre.Text
                pelicula.id_distribuidor = funcionesPelicula.getId_distribuidor(cmb_distribuidores.SelectedItem.ToString)
                'pelicula.nombre = txt_nombre.Text
                pelicula.duracion = txt_duracion.Text
                pelicula.genero = cmb_genero.Text
                pelicula.clasificacion = cmb_clasificacion.Text
                pelicula.pais_origen = txt_pais.Text
                pelicula.director = txt_director.Text
                pelicula.cantidad_existencia = nud_cant_existencia.Value
                pelicula.sinopsis = rtxt_sinopsis.Text
                pelicula.fecha_adquicision = dt_fecha_adquicision.Value.Date.ToString("MM/dd/yyyy")
                pelicula.precio_venta = txt_precio_venta.Text
                pelicula.precio_renta = txt_precio_renta.Text
                pelicula.precio_compra = txt_precio_compra.Text
                pelicula.foto_caratula = ruta_foto

                Try
                    funcionesPelicula.actualizar_pelicula(pelicula)
                    MsgBox("Pelicula actualizada correctamente")
                    funcionesPelicula.mostrar_pelicula(dg_peliculas)
                Catch ex As Exception
                    MsgBox("Error: " + ex.Message)
                End Try
                Limpiar(lbl_id, txt_nombre, txt_duracion, txt_pais, txt_director, rtxt_sinopsis, txt_precio_venta, txt_precio_renta, txt_precio_compra)
            Else
                MsgBox("inserte los datos completos de la pelicula")
            End If

        Else

            If txt_nombre.Text <> Nothing And txt_duracion.Text <> Nothing And cmb_genero.SelectedItem <> Nothing And cmb_clasificacion.SelectedItem <> Nothing And txt_pais.Text <> Nothing And txt_director.Text <> Nothing And cmb_distribuidores.Text <> Nothing And rtxt_sinopsis.Text <> Nothing And txt_precio_compra.Text <> Nothing And txt_precio_renta.Text <> Nothing And txt_precio_venta.Text <> Nothing Then

                pelicula.nombre = txt_nombre.Text
                pelicula.id_distribuidor = funcionesPelicula.getId_distribuidor(cmb_distribuidores.SelectedItem.ToString)
                'pelicula.nombre = txt_nombre.Text
                pelicula.duracion = txt_duracion.Text
                pelicula.genero = cmb_genero.Text
                pelicula.clasificacion = cmb_clasificacion.Text
                pelicula.pais_origen = txt_pais.Text
                pelicula.director = txt_director.Text
                pelicula.cantidad_existencia = nud_cant_existencia.Value
                pelicula.sinopsis = rtxt_sinopsis.Text
                pelicula.fecha_adquicision = dt_fecha_adquicision.Value.Date.ToString("MM/dd/yyyy")
                pelicula.precio_venta = txt_precio_venta.Text
                pelicula.precio_renta = txt_precio_renta.Text
                pelicula.precio_compra = txt_precio_compra.Text
                pelicula.foto_caratula = ruta_foto

                Try
                    funcionesPelicula.insertar_pelicula(pelicula)
                    MsgBox("Pelicula agregada correctamente")
                    funcionesPelicula.mostrar_pelicula(dg_peliculas)
                Catch ex As Exception
                    MsgBox("Error: " + ex.Message)
                End Try
                Limpiar(lbl_id, txt_nombre, txt_duracion, txt_pais, txt_director, rtxt_sinopsis, txt_precio_venta, txt_precio_renta, txt_precio_compra)
                cmb_genero.Text = Nothing
                cmb_clasificacion.Text = Nothing
                cmb_distribuidores.Text = Nothing
                pb_foto.ImageLocation = ""
                nud_cant_existencia.Value = 0
                lbl_id.Visible = False
                lbl_pelicula.Visible = False
            Else
                MsgBox("inserte los datos completos de la pelicula")
            End If

        End If

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

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            If lbl_id.Text >= 1 Then
                pelicula.id = lbl_id.Text
                funcionesPelicula.eliminar_pelicula(pelicula)
                MsgBox("Pelicula eliminada correctamente")
                funcionesPelicula.mostrar_pelicula(dg_peliculas)
                Limpiar(lbl_id, txt_nombre, txt_duracion, txt_pais, txt_director, rtxt_sinopsis, txt_precio_venta, txt_precio_renta, txt_precio_compra)
                cmb_genero.Text = Nothing
                cmb_clasificacion.Text = Nothing
                cmb_distribuidores.Text = Nothing
                pb_foto.ImageLocation = ""
                nud_cant_existencia.Value = 0
                lbl_id.Visible = False
                lbl_pelicula.Visible = False
            Else
                MsgBox("Seleccione una pelicula para eliminar")
            End If
        Catch ex As Exception
            MsgBox("Seleccione una pelicula para eliminar")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Limpiar(lbl_id, txt_nombre, txt_duracion, txt_pais, txt_director, rtxt_sinopsis, txt_precio_venta, txt_precio_renta, txt_precio_compra)
        lbl_id.Visible = False
        lbl_pelicula.Visible = False
        cmb_genero.Text = Nothing
        cmb_clasificacion.Text = Nothing
        cmb_distribuidores.Text = Nothing
        pb_foto.ImageLocation = ""
        nud_cant_existencia.Value = 0
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        funcionesPelicula.buscar_pelicula(dg_peliculas, txt_nombre_buscar.Text)
    End Sub

    Private Sub btn_deshacer_busqueda_Click(sender As Object, e As EventArgs) Handles btn_deshacer_busqueda.Click
        funcionesPelicula.mostrar_pelicula(dg_peliculas)
    End Sub

    Private Sub dg_peliculas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_peliculas.CellClick
        Dim i As Integer
        i = dg_peliculas.CurrentRow.Index
        lbl_id.Text = dg_peliculas.Item(0, i).Value
        cmb_distribuidores.Text = funcionesPelicula.getNombre_distribuidor(dg_peliculas.Item(1, i).Value)
        txt_nombre.Text = dg_peliculas.Item(2, i).Value
        txt_duracion.Text = dg_peliculas.Item(3, i).Value
        cmb_genero.Text = dg_peliculas.Item(4, i).Value
        cmb_clasificacion.Text = dg_peliculas.Item(5, i).Value
        txt_pais.Text = dg_peliculas.Item(6, i).Value
        txt_director.Text = dg_peliculas.Item(7, i).Value
        nud_cant_existencia.Value = dg_peliculas.Item(8, i).Value
        rtxt_sinopsis.Text = dg_peliculas.Item(9, i).Value
        dt_fecha_adquicision.Value = dg_peliculas.Item(10, i).Value
        txt_precio_venta.Text = dg_peliculas.Item(11, i).Value
        txt_precio_renta.Text = dg_peliculas.Item(12, i).Value
        txt_precio_compra.Text = dg_peliculas.Item(13, i).Value
        pb_foto.ImageLocation = dg_peliculas.Item(14, i).Value
        ruta_foto = dg_peliculas.Item(14, i).Value

        lbl_id.Visible = True
        lbl_pelicula.Visible = True
    End Sub
End Class