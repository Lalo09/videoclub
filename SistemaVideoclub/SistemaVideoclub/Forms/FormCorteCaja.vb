Public Class FormCorteCaja

    Dim corteCaja As New ClassCorteCaja
    Dim funcionesCorteCaja As New FuncionesCorteCaja
    Dim total_rentas As Double
    Dim total_ventas As Double
    Dim total_adeudos As Double
    Dim compras As Double
    Dim sueldos As Double
    Dim corteRealizado As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_cerrar_caja.Click
        Dim oldDate As Date
        Dim oldDay As Integer
        oldDate = Date.Now.Date.ToString("dd/MM/yyyy")
        oldDay = Microsoft.VisualBasic.DateAndTime.Day(oldDate)

        Dim someTime As Date
        Dim someHour As Integer
        someTime = DateTime.Now.ToShortTimeString()
        someHour = Hour(someTime)

        If someHour >= 22 And corteRealizado = False Then

            Dim balance As Double
            Dim fecha As String
            corteRealizado = True
            fecha = DateTime.Now.Date.ToString("MM/dd/yyyy")

            total_rentas = Convert.ToDouble(funcionesCorteCaja.getTotalRentas(fecha))
            total_ventas = Convert.ToDouble(funcionesCorteCaja.getTotalVentas(fecha))
            total_adeudos = Convert.ToDouble(funcionesCorteCaja.getAdeudosPagados(fecha))

            compras = Convert.ToDouble(funcionesCorteCaja.getTotalPeliculasCompradas(fecha))

            If oldDay = 15 Or oldDay = 30 Then
                sueldos = Convert.ToDouble(funcionesCorteCaja.getTotalSueldo(fecha))
            Else
                sueldos = 0
            End If

            balance = total_rentas + total_ventas + total_adeudos - compras - sueldos
            balance_diario = balance

            Try
                corteCaja.fecha = DateTime.Now.Date.ToString("MM/dd/yyyy")
                corteCaja.balance = balance
                funcionesCorteCaja.insertar_caja(corteCaja)
                MsgBox("Corte de caja realizado")
            Catch ex As Exception
                MsgBox("Error: " + ex.Message)
            End Try

        Else
            MsgBox("Aun no se puede realizar el corte de caja")
        End If

    End Sub

    Private Sub btn_ver_balance_Click(sender As Object, e As EventArgs) Handles btn_ver_balance.Click
        Dim formBalance As New FormVerBalance
        formBalance.Show()
        Me.Close()
    End Sub
End Class