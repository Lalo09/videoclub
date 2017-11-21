Public Class FormVerBalance

    Dim funcionesCorteCaja As New FuncionesCorteCaja

    Private Sub FormVerBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_balance.Text = balance_diario
        Try
            funcionesCorteCaja.mostrar_cortesCaja(dg_balances)
        Catch ex As Exception
            MsgBox("no se pudo mostrar el balance total")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            funcionesCorteCaja.buscar_cortesCaja(dg_balances, dt_fecha_in.Value.Date.ToString("MM/dd/yyyy"), dt_fecha_fin.Value.Date.ToString("MM/dd/yyyy"))
        Catch ex As Exception
            MsgBox("no se pudo mostrar el balance total")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            funcionesCorteCaja.mostrar_cortesCaja(dg_balances)
        Catch ex As Exception
            MsgBox("no se pudo mostrar el balance total")
        End Try
    End Sub
End Class