Public Class FormLogin

    Dim usuario As New ClassUsuario
    Dim funcionesUsuario As New FuncionesUsuario

    'Entrar al sistema al dar clic al boton ingresar
    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click

        Try
            usuario.id_empleado = txt_user.Text
            usuario.contrasena = txt_pass.Text

            If funcionesUsuario.existe_usuario(usuario) = True Then
                numero_de_empleado = txt_user.Text
                Dim formPrincipal As New FormMDI
                formPrincipal.Show()
                Me.Close()
            Else
                MsgBox("Error en usuario y/o contraseña")
                Limpiar(txt_pass, txt_user)
            End If

        Catch ex As Exception
            MsgBox("Error en usuario y/o contraseña")
            Limpiar(txt_pass, txt_user)
        End Try

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_user.Focus()
    End Sub
End Class