Public Class FormSocios

    Private ruta_foto As String
    Private sexo As Char
    Dim socio As New ClassSocio
    Dim funcionesSocio As New FuncionesSocio

    Private Sub btn_cargar_foto_Click(sender As Object, e As EventArgs) Handles btn_cargar_foto.Click

        If ofd_foto.ShowDialog = DialogResult.OK Then
            ruta_foto = ofd_foto.FileName
        End If

        pb_foto_cliente.ImageLocation = ruta_foto
    End Sub

    Private Sub btn_eliminar_foto_Click(sender As Object, e As EventArgs) Handles btn_eliminar_foto.Click
        pb_foto_cliente.ImageLocation = ""
    End Sub

    Private Sub FormSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If identificador_cliente <> Nothing Then
            Conectar()
            Dim consulta As String = "SELECT nombre,apellido_paterno,apellido_materno FROM cliente WHERE id_cliente =" & identificador_cliente
            lbl_idCliente.Text = identificador_cliente

            consultar_elemento(consulta)
            Try
                If dr.Read Then
                    txt_nombre.Text = dr(0).ToString
                    txt_ap_paterno.Text = dr(1).ToString
                    txt_ap_materno.Text = dr(2).ToString
                    dr.Close()
                End If

            Catch ex As Exception
                MsgBox("Aqui hay error" + ex.Message)
            Finally
                Desconectar()
            End Try
        ElseIf socio_seleccionado <> Nothing Then
            'MsgBox("variable:" + socio_seleccionado)
            lbl_idSocio.Text = socio_seleccionado

            Conectar()
            Dim consulta As String = "select cliente.id_cliente,cliente.nombre,cliente.apellido_paterno,cliente.apellido_materno from cliente, socio where socio.id_cliente = cliente.id_cliente and socio.id_socio = " & socio_seleccionado


            consultar_elemento(consulta)
            Try
                If dr.Read Then
                    lbl_idCliente.Text = dr(0).ToString
                    txt_nombre.Text = dr(1).ToString
                    txt_ap_paterno.Text = dr(2).ToString
                    txt_ap_materno.Text = dr(3).ToString
                    dr.Close()
                End If

            Catch ex As Exception
                MsgBox("Aqui hay error" + ex.Message)
            Finally
                Desconectar()
            End Try

            Conectar()
            Dim consulta2 As String = "SELECT * FROM socio WHERE id_socio = " & lbl_idSocio.Text

            consultar_elemento(consulta2)
            Try
                If dr.Read Then
                    If dr(2).ToString = "F" Then
                        rb_femenino.Checked = True
                    ElseIf dr(2).ToString = "M" Then
                        rb_masculino.Checked = True
                    End If
                    txt_telefono.Text = dr(3).ToString
                    txt_email.Text = dr(4).ToString
                    txt_calle.Text = dr(5).ToString
                    txt_num_ext.Text = dr(6).ToString
                    txt_numInt.Text = dr(7).ToString
                    txt_colonia.Text = dr(8).ToString
                    txt_ciudad.Text = dr(9).ToString
                    txt_pais.Text = dr(10).ToString
                    pb_foto_cliente.ImageLocation = dr(11).ToString
                    dt_exp.Value = dr(12).ToString
                    dt_ven.Value = dr(13).ToString
                    ruta_foto = dr(11).ToString
                End If

            Catch ex As Exception
                MsgBox("Aqui hay error" + ex.Message)
            Finally
                Desconectar()
            End Try

        End If

    End Sub

    Public Function Data_fav() As String
        If rb_femenino.Checked Then
            sexo = "F"
        ElseIf rb_masculino.Checked Then
            sexo = "M"
        End If

        Return sexo

    End Function

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click

        If lbl_idSocio.Text <> Nothing Then
            socio.id = lbl_idSocio.Text
        Else
            socio.id = -1
        End If
        'MsgBox(socio.id)
        If funcionesSocio.existe_socio(socio) Then

            If txt_telefono.Text <> Nothing And txt_calle.Text <> Nothing And txt_num_ext.Text <> Nothing And txt_colonia.Text <> Nothing And txt_ciudad.Text <> Nothing And txt_pais.Text <> Nothing And pb_foto_cliente.ImageLocation <> Nothing Then

                socio.id_cliente = lbl_idCliente.Text
                socio.sexo = Data_fav()
                socio.telefono = txt_telefono.Text
                socio.correo = txt_email.Text
                socio.calle = txt_calle.Text
                socio.numeroExt = txt_num_ext.Text
                socio.numeroInt = txt_numInt.Text
                socio.colonia = txt_colonia.Text
                socio.ciudad = txt_ciudad.Text
                socio.pais = txt_pais.Text
                socio.fotografia = ruta_foto
                socio.fechaExp = dt_exp.Value.Date.ToString("MM/dd/yyyy")
                socio.fechaVig = dt_ven.Value.Date.ToString("MM/dd/yyyy")
                socio.estatus = "Vigente"

                Try
                    funcionesSocio.actualizar_socio(socio)
                    MsgBox("Socio actualizado correctamente")
                    Dim formbuscarSocio As New FormBuscarSocios
                    formbuscarSocio.Show()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Inserte datos completos del socio " + ex.Message)
                End Try
            Else
                MsgBox("Inserte datos completos del socio")
            End If

        Else

            If txt_telefono.Text <> Nothing And txt_calle.Text <> Nothing And txt_num_ext.Text <> Nothing And txt_colonia.Text <> Nothing And txt_ciudad.Text <> Nothing And txt_pais.Text <> Nothing And pb_foto_cliente.ImageLocation <> Nothing Then

                socio.id_cliente = lbl_idCliente.Text
                socio.sexo = Data_fav()
                socio.telefono = txt_telefono.Text
                socio.correo = txt_email.Text
                socio.calle = txt_calle.Text
                socio.numeroExt = txt_num_ext.Text
                socio.numeroInt = txt_numInt.Text
                socio.colonia = txt_colonia.Text
                socio.ciudad = txt_ciudad.Text
                socio.pais = txt_pais.Text
                socio.fotografia = ruta_foto
                socio.fechaExp = dt_exp.Value.Date.ToString("MM/dd/yyyy")
                socio.fechaVig = dt_ven.Value.Date.ToString("MM/dd/yyyy")
                socio.estatus = "Vigente"

                Try
                    funcionesSocio.insertar_socio(socio)
                    MsgBox("Socio insertado correctamente")
                    Dim formbuscarSocio As New FormBuscarSocios
                    formbuscarSocio.Show()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Inserte datos completos del socio " + ex.Message)
                End Try
            Else
                MsgBox("Inserte datos completos del socio")
            End If


        End If

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            If lbl_idSocio.Text >= 1 Then
                socio.id = lbl_idSocio.Text
                funcionesSocio.eliminar_socio(socio)
                MsgBox("socio eliminado correctamente")
            Else
                MsgBox("Seleccione un socio para eliminar")
            End If
        Catch ex As Exception
            MsgBox("Seleccione un socio para eliminar ")
        End Try

        Dim formbuscarSocio As New FormBuscarSocios
        formbuscarSocio.Show()
        Me.Close()
    End Sub

    Private Sub FormSocios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        identificador_cliente = ""
        socio_seleccionado = ""
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Limpiar(txt_telefono, txt_email, txt_calle, txt_colonia, txt_ciudad, txt_pais, txt_numInt, txt_num_ext)
    End Sub
End Class