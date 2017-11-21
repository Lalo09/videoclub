Public Class FormDistribuidores

    Dim distribuidor As New ClassDistribuidor
    Dim funcionesDistribuidor As New FuncionesDistribuidor

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If lbl_id.Text <> Nothing Then
            distribuidor.id = lbl_id.Text
        Else
            distribuidor.id = -1
        End If

        If funcionesDistribuidor.existe_distribuidor(distribuidor) Then
            If txt_nombre.Text <> Nothing And txt_pais.Text <> Nothing And txt_direccion.Text <> Nothing And txt_telefono.Text <> Nothing Then
                distribuidor.nombre = txt_nombre.Text
                distribuidor.pais = txt_pais.Text
                distribuidor.direccion = txt_direccion.Text
                distribuidor.correo = txt_email.Text
                distribuidor.sitioWeb = txt_sitio_web.Text
                distribuidor.telefono = txt_telefono.Text
                Try
                    funcionesDistribuidor.actualizar_distribuidor(distribuidor)
                    MsgBox("Distribuidor actualizado correctamente")
                    funcionesDistribuidor.mostrar_distribuidores(dg_distribuidores)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Limpiar(txt_nombre, txt_pais, txt_direccion, txt_email, txt_sitio_web, txt_telefono, lbl_id)
            Else
                MsgBox("Inserte datos completos del distribuidor!")
            End If
        Else
            If txt_nombre.Text <> Nothing And txt_pais.Text <> Nothing And txt_direccion.Text <> Nothing And txt_telefono.Text <> Nothing Then
                distribuidor.nombre = txt_nombre.Text
                distribuidor.pais = txt_pais.Text
                distribuidor.direccion = txt_direccion.Text
                distribuidor.correo = txt_email.Text
                distribuidor.sitioWeb = txt_sitio_web.Text
                distribuidor.telefono = txt_telefono.Text
                Try
                    funcionesDistribuidor.insertar_distribuidor(distribuidor)
                    MsgBox("Distribuidor insertado correctamente")
                    funcionesDistribuidor.mostrar_distribuidores(dg_distribuidores)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Limpiar(txt_nombre, txt_pais, txt_direccion, txt_email, txt_sitio_web, txt_telefono, lbl_id)
            Else
                MsgBox("Inserte datos completos del distribuidor!")
            End If
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            If lbl_id.Text >= 1 Then
                distribuidor.id = lbl_id.Text
                funcionesDistribuidor.eliminar_distribuidor(distribuidor.id)
                funcionesDistribuidor.mostrar_distribuidores(dg_distribuidores)
                MsgBox("distribuidor eliminado correctamente")
                Limpiar(txt_nombre, txt_pais, txt_direccion, txt_email, txt_sitio_web, txt_telefono, lbl_id)
            Else
                MsgBox("Seleccione un distribuidor para eliminar")
            End If
        Catch ex As Exception
            MsgBox("Seleccione un distribuidor para eliminar ")
        End Try
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Limpiar(txt_nombre, txt_pais, txt_direccion, txt_email, txt_sitio_web, txt_telefono, lbl_id)
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim distribuidor_a_buscar As String = txt_nombreBuscar.Text
        funcionesDistribuidor.buscar_distribuidor(dg_distribuidores, distribuidor_a_buscar)
    End Sub

    Private Sub btn_deshacer_Click(sender As Object, e As EventArgs) Handles btn_deshacer.Click
        Try
            funcionesDistribuidor.mostrar_distribuidores(dg_distribuidores)
        Catch ex As Exception
            MsgBox("No se han podido cargar los datos: " + ex.Message)
        End Try
    End Sub

    Private Sub FormDistribuidores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            funcionesDistribuidor.mostrar_distribuidores(dg_distribuidores)
        Catch ex As Exception
            MsgBox("No se han podido cargar los datos: " + ex.Message)
        End Try
    End Sub

    Private Sub dg_distribuidores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_distribuidores.CellClick
        Dim i As Integer
        i = dg_distribuidores.CurrentRow.Index
        lbl_id.Text = dg_distribuidores.Item(0, i).Value
        txt_nombre.Text = dg_distribuidores.Item(1, i).Value
        txt_pais.Text = dg_distribuidores.Item(2, i).Value
        txt_direccion.Text = dg_distribuidores.Item(3, i).Value
        txt_email.Text = dg_distribuidores.Item(4, i).Value
        txt_sitio_web.Text = dg_distribuidores.Item(5, i).Value
        txt_telefono.Text = dg_distribuidores.Item(6, i).Value
    End Sub
End Class