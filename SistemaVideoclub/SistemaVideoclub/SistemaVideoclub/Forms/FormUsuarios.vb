Public Class FormUsuarios

    Dim empleado As New ClassEmpleado
    Dim funcionesEmpleado As New FuncionesEmpleado
    Dim usuario As New ClassUsuario
    Dim funcionesUsuario As New FuncionesUsuario

    Private Sub txt_id_empleado_Leave(sender As Object, e As EventArgs) Handles txt_id_empleado.Leave

        Try
            empleado.id = txt_id_empleado.Text
            If funcionesEmpleado.existe_empleado(empleado) = False Then
                MsgBox("El empleado no existe")
                txt_id_empleado.Text = Nothing
                txt_id_empleado.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try

    End Sub

    Private Sub btn_crear_usuario_Click(sender As Object, e As EventArgs) Handles btn_crear_usuario.Click

        If txt_id_empleado.Text <> Nothing And txt_pass.Text <> Nothing And txt_repass.Text <> Nothing Then

            If txt_pass.Text = txt_repass.Text Then
                usuario.id_empleado = txt_id_empleado.Text
                usuario.contrasena = txt_pass.Text
                If ValorRadio() = True Then
                    usuario.tipo_usuario = "admin"
                Else
                    usuario.tipo_usuario = "normal"
                End If
                usuario.estatus = "Activo"
                Try
                    funcionesUsuario.insertar_usuario(usuario)
                    MsgBox("Usuario dado de alta exitosamente")
                    Limpiar(txt_id_empleado, txt_pass, txt_repass)
                    rb_hacer_admin.Checked = False
                    refrescar_datos()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Las contrasñas no coinciden")
            End If
        Else
            MsgBox("Escriba los datos completos del usuario")
        End If

    End Sub

    Private Function ValorRadio()
        If (rb_hacer_admin.Checked = True) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescar_datos()
    End Sub

    Public Sub refrescar_datos()
        Try
            funcionesUsuario.mostrar_usuario(dg_usuario)
        Catch ex As Exception
            MsgBox("No se han podido cargar los datos " + ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim numero_empleado As String = txt_buscar_por_numero.Text
            funcionesUsuario.buscar_usuario(dg_usuario, numero_empleado)
        Catch ex As Exception
            MsgBox("No se encontro el usuario")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        refrescar_datos()
    End Sub

    Private Sub txt_empleado_editar_Leave(sender As Object, e As EventArgs) Handles txt_empleado_editar.Leave
        Try
            usuario.id_empleado = txt_empleado_editar.Text
            If funcionesUsuario.es_editable_usario(usuario) = False Then
                MsgBox("No se encontro el usuario")
                txt_empleado_editar.Text = Nothing
                txt_empleado_editar.Focus()
            End If
        Catch ex As Exception
            MsgBox("No se encontro el usuario")
        End Try

    End Sub

    Private Sub btn_guardar_cambios_Click(sender As Object, e As EventArgs) Handles btn_guardar_cambios.Click
        If txt_empleado_editar.Text <> Nothing And txt_editar_pass.Text <> Nothing And txt_editar_repass.Text <> Nothing Then

            If txt_editar_pass.Text = txt_editar_repass.Text Then
                usuario.id_empleado = txt_empleado_editar.Text
                usuario.contrasena = txt_editar_pass.Text
                If rb_editar_hacer_adm.Checked = True Then
                    usuario.tipo_usuario = "admin"
                ElseIf rb_editar_hacer_adm.Checked = False Then
                    usuario.tipo_usuario = "normal"
                End If
                usuario.estatus = "Activo"
                Try
                    funcionesUsuario.actualizar_usuario(usuario)
                    MsgBox("Usuario actualizado exitosamente")
                    Limpiar(txt_empleado_editar, txt_editar_pass, txt_editar_repass)
                    rb_editar_hacer_adm.Checked = False
                    refrescar_datos()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Las contrasñas no coinciden")
            End If
        Else
            MsgBox("Escriba los datos completos del usuario")
        End If
    End Sub
End Class