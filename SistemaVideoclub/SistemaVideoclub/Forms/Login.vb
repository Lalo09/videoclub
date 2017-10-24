Public Class FormLogin

    'Entrar al sistema al dar clic al boton ingresar
    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        Dim formPrincipal As New FormMDI
        formPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_user.Focus()
    End Sub
End Class