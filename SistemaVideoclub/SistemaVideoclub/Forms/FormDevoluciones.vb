Public Class FormDevoluciones

    Dim socio As New ClassSocio
    Dim funcionesSocio As New FuncionesSocio
    Dim fecha_devolucion As String
    Dim total_adeudo As Double
    Dim pelicula As New ClassPelicula
    Dim funcionesPelicula As New FuncionesPelicula
    Dim atraso As Integer = 0
    Dim devolucion As New ClassDevolucion
    Dim funcionesDevolucion As New FuncionesDevolucion
    Dim adeudo As New ClassAdeudo
    Dim funcionesAdeudo As New FuncionesAdeudo
    Dim funcionesDetalleRenta As New FuncionesDetalleRenta
    Dim mal_estado As Integer = 0
    ' Dim devolucion As New 

    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles txt_id_socio.Leave
        If txt_id_socio.Text <> Nothing Then
            Try
                socio.id = txt_id_socio.Text
                If funcionesSocio.existe_socio(socio) Then
                    txt_nombre_socio.Text = funcionesSocio.getNombre_socio(txt_id_socio.Text)
                    fecha_devolucion = funcionesSocio.getUltima_renta(socio.id)
                    funcionesDetalleRenta.mostrar_renta(dg__detalle_renta, txt_id_socio.Text)
                Else
                    MsgBox("El socio no existe")
                End If
            Catch ex As Exception
                MsgBox("El socio no existe")
            End Try
        End If
    End Sub

    Private Sub txt_id_pelicula_Leave(sender As Object, e As EventArgs) Handles txt_id_pelicula.Leave
        If txt_id_pelicula.Text <> Nothing Then
            pelicula.id = txt_id_pelicula.Text
            If funcionesPelicula.existe_pelicula(pelicula) = True Then
                txt_nombre_pelicula.Text = funcionesPelicula.getNombre_pelicula(txt_id_pelicula.Text)
                ''Mostrar renta
                'funcionesDetalleRenta.
            Else
                MsgBox("La pelicula no existe")
                txt_id_pelicula.Text = Nothing
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        'MsgBox(Convert.ToDateTime(fecha_devolucion) + " " + DateTime.Now.ToString("dd/MM/yyyy"))
        If cmb_estado_pelicula.Text = "Mal estado" Then
            mal_estado = +1

        ElseIf Convert.ToDateTime(fecha_devolucion) < DateTime.Now.Date.ToString("dd/MM/yyyy") Then
            Dim days As Long = DateDiff(DateInterval.Day, Convert.ToDateTime(fecha_devolucion), DateTime.Now)
            total_adeudo = days * 10.0
            atraso = +1
            'guardar()
        End If

        guardar()
        Limpiar(txt_id_pelicula, txt_nombre_pelicula, cmb_estado_pelicula, lbl_id)
    End Sub

    Private Sub FormDevoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            funcionesDevolucion.mostrar_devolucion(dg_devoluciones)
        Catch ex As Exception
            MsgBox("No se puede guardar la devolucion")
        End Try
    End Sub

    Private Sub btn_deshacer_Click(sender As Object, e As EventArgs) Handles btn_deshacer.Click
        Try
            funcionesDevolucion.mostrar_devolucion(dg_devoluciones)
        Catch ex As Exception
            MsgBox("No se puede guardar la devolucion")
        End Try
    End Sub

    Private Function guardar()
        Try
            devolucion.id_pelicula = txt_id_pelicula.Text
            devolucion.id_empleado = numero_de_empleado
            devolucion.id_socio = txt_id_socio.Text
            devolucion.fecha_devolucion = DateTime.Now.Date.ToString("MM/dd/yyyy")
            devolucion.estado_pelicula = cmb_estado_pelicula.Text
            funcionesDevolucion.insertar_devolucion(devolucion)
            MsgBox("Ok!")
            funcionesDevolucion.mostrar_devolucion(dg_devoluciones)
        Catch ex As Exception
            MsgBox("No se puede guardar")
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            'Eliminar
            If lbl_id.Text <> Nothing Then
                devolucion.id = lbl_id.Text
                funcionesDevolucion.eliminar_devolucion(devolucion)
                funcionesDevolucion.mostrar_devolucion(dg_devoluciones)
                lbl_id.Text = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            funcionesDevolucion.buscar_devolucion(dg_devoluciones, txt_buscar.Text)
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        atraso = 0
        Limpiar(txt_id_socio, txt_nombre_socio, txt_id_pelicula, txt_nombre_pelicula, cmb_estado_pelicula, lbl_id)
    End Sub

    Private Sub btn_terminar_devolucion_Click(sender As Object, e As EventArgs) Handles btn_terminar_devolucion.Click
        If atraso > 0 Then
            MsgBox("La fecha limite de la entrega era " + fecha_devolucion + "Por lo que se cobrara 10 pesos adicional por cada dia de atraso")
            total_de_adeudo = total_adeudo
            Dim formadeudo As New FormAdeudos()
            formadeudo.MdiParent = FormMDI.ActiveForm
            formadeudo.Show()
            Me.Close()
        ElseIf mal_estado > 0 Then
            Dim formVentas As New FormVentas()
            formVentas.MdiParent = FormMDI.ActiveForm
            formVentas.Show()

        Else
            adeudo.total_adeudo = 0
            adeudo.estatus = "Pagado"
            funcionesAdeudo.actualizar_adeudo(0, "Pagado", funcionesSocio.getnumeroUltimo_adeudo(txt_id_socio.Text))
            MsgBox("Devolucion completa")
        End If
    End Sub
End Class