Public Class FormNuevaRenta

    Dim funcionesEmpleado As New FuncionesEmpleado
    Dim socio As New ClassSocio
    Dim funcionesSocio As New FuncionesSocio
    Dim pelicula As New ClassPelicula
    Dim funcionesPelicula As New FuncionesPelicula
    Dim renta As New ClassRenta
    Dim funcionesRenta As New FuncionesRenta
    Dim adeudo As New ClassAdeudo
    Dim funcionesAdeudo As New FuncionesAdeudo
    Dim detalle_renta As New ClassDetalleRenta
    Dim funcionesDetalleRenta As New FuncionesDetalleRenta

    Private Sub dt_fecha_devolucion_ValueChanged(sender As Object, e As EventArgs) Handles dt_fecha_devolucion.ValueChanged
        'MsgBox("El valor de este dt es " + dt_fecha_devolucion.Value)
    End Sub

    Private Sub FormNuevaRenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nombre_empleado.Text = funcionesEmpleado.getNombre_empleado(numero_de_empleado)
    End Sub

    Private Sub txt_id_socio_Leave(sender As Object, e As EventArgs) Handles txt_id_socio.Leave
        If txt_id_socio.Text <> Nothing Then
            Try
                socio.id = txt_id_socio.Text
                If funcionesSocio.existe_socio(socio) Then
                    txt_nombre_socio.Text = funcionesSocio.getNombre_socio(txt_id_socio.Text)

                Else
                    MsgBox("El socio no existe")
                End If
            Catch ex As Exception
                MsgBox("El socio no existe")
            End Try
        End If
    End Sub

    Private Sub txt_codigo_pelicula_Leave(sender As Object, e As EventArgs) Handles txt_codigo_pelicula.Leave

        If txt_codigo_pelicula.Text <> Nothing Then
            pelicula.id = txt_codigo_pelicula.Text

            If funcionesPelicula.existe_pelicula(pelicula) Then
                txt_nombre_pelicula.Text = funcionesPelicula.getNombre_pelicula(txt_codigo_pelicula.Text)
                txt_precio_pelicula.Text = funcionesPelicula.getPrecioRenta_pelicula(txt_codigo_pelicula.Text)
                txt_cantidad_pelicula.Text = 1
                If txt_cantidad_pelicula.Text <> 0 Then
                    txt_importe.Text = Convert.ToDecimal(txt_cantidad_pelicula.Text) * Convert.ToDecimal(txt_precio_pelicula.Text)
                End If
            Else
                MsgBox("La pelicula no existe")
                txt_codigo_pelicula.Text = Nothing
            End If

        End If

    End Sub

    Private Sub txt_cantidad_pelicula_Leave(sender As Object, e As EventArgs) Handles txt_cantidad_pelicula.Leave
        Try
            If txt_cantidad_pelicula.Text <> 0 Or txt_cantidad_pelicula.Text <> Nothing Then
                txt_importe.Text = Convert.ToDecimal(txt_cantidad_pelicula.Text) * Convert.ToDecimal(txt_precio_pelicula.Text)
            Else
                MsgBox("Ingrese una cantidad valido")
                txt_cantidad_pelicula.Text = 1
            End If
        Catch ex As Exception
            MsgBox("Ingrese una cantidad valido")
            txt_cantidad_pelicula.Text = 1
        End Try
    End Sub

    Private Sub btn_colocar_Click(sender As Object, e As EventArgs) Handles btn_colocar.Click
        If txt_codigo_pelicula.Text <> Nothing And txt_nombre_pelicula.Text <> Nothing And txt_precio_pelicula.Text <> Nothing And txt_importe.Text <> Nothing Then
            Dim cod_pelicula As Integer = txt_codigo_pelicula.Text

            If txt_cantidad_pelicula.Text > 0 Then
                If dt_detalles_renta.RowCount < 1 Then
                    Agregar_pelicula()
                Else

                    For fila = 0 To dt_detalles_renta.RowCount - 1

                        If cod_pelicula = dt_detalles_renta.Item(0, fila).Value Then

                            dt_detalles_renta.Rows.RemoveAt(dt_detalles_renta.CurrentRow.Index)
                            Exit For

                        End If
                    Next
                    Agregar_pelicula()
                End If
            Else
                MsgBox("ingrese una cantidad mayor a 0")
            End If
        Else
            MsgBox("El codigo de la pelicula no existe")
            Limpiar(txt_codigo_pelicula, txt_nombre_pelicula, txt_precio_pelicula, txt_cantidad_pelicula, txt_importe)
        End If
    End Sub

    Public Function Agregar_pelicula()
        dt_detalles_renta.Rows.Add(txt_codigo_pelicula.Text, txt_nombre_pelicula.Text, txt_precio_pelicula.Text, txt_cantidad_pelicula.Text, txt_importe.Text)
        txt_total_renta.Text = Calcular_importe()
        Limpiar(txt_codigo_pelicula, txt_nombre_pelicula, txt_precio_pelicula, txt_cantidad_pelicula, txt_importe)
    End Function

    Public Function Calcular_importe()
        Dim x As Double
        For fila = 0 To dt_detalles_renta.RowCount - 1
            On Error Resume Next
            x = x + dt_detalles_renta.Item(4, fila).Value
        Next
        Return x
    End Function

    Private Sub dt_detalles_renta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_detalles_renta.CellClick
        Dim i As Integer
        i = dt_detalles_renta.CurrentRow.Index
        txt_codigo_pelicula.Text = dt_detalles_renta.Item(0, i).Value
        txt_nombre_pelicula.Text = dt_detalles_renta.Item(1, i).Value
        txt_precio_pelicula.Text = dt_detalles_renta.Item(2, i).Value
        txt_cantidad_pelicula.Text = dt_detalles_renta.Item(3, i).Value
        txt_importe.Text = dt_detalles_renta.Item(4, i).Value
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        If dt_detalles_renta.RowCount > 0 Then
            dt_detalles_renta.Rows.RemoveAt(dt_detalles_renta.CurrentRow.Index)
            txt_total_renta.Text = Calcular_importe()
        End If

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Limpiar(txt_id_socio, txt_nombre_socio, txt_codigo_pelicula, txt_nombre_socio, txt_precio_pelicula, txt_cantidad_pelicula, txt_importe, txt_total_renta)
        dt_detalles_renta.Rows.Clear()
    End Sub

    Private Sub btn_realizar_renta_Click(sender As Object, e As EventArgs) Handles btn_realizar_renta.Click
        If (funcionesSocio.getFechaVencimiento(txt_id_socio.Text) < DateTime.Now.Date) Then
            MsgBox("Vencio la fecha de vigencia de socio")
        Else
            If funcionesSocio.getEstatus_Adeudo(txt_id_socio.Text) <> "No pagado" Or funcionesSocio.getEstatus_Vigente(txt_id_socio.Text) = "Baja" Then
                'Realizar renta
                renta.id_empleado = numero_de_empleado
                renta.id_socio = txt_id_socio.Text
                renta.fecha_renta = dt_fecha_renta.Value.Date.ToString("MM/dd/yyyy")
                renta.fecha_devolucion = dt_fecha_devolucion.Value.Date.ToString("MM/dd/yyyy")
                renta.total = txt_total_renta.Text

                Try
                    funcionesRenta.insertar_renta(renta)
                Catch ex As Exception

                End Try

                Dim num_renta As Integer = funcionesRenta.getUltima_renta()

                For fila = 0 To dt_detalles_renta.RowCount - 1
                    detalle_renta.id_pelicula = dt_detalles_renta.Item(0, fila).Value
                    detalle_renta.id_renta = num_renta
                    detalle_renta.cantidad = dt_detalles_renta.Item(3, fila).Value
                    detalle_renta.total = dt_detalles_renta.Item(4, fila).Value

                    Try
                        funcionesDetalleRenta.insertar_detalle_renta(detalle_renta)
                    Catch ex As Exception

                    End Try

                Next

                MsgBox("Renta Realizada!")
                Limpiar(txt_id_socio, txt_nombre_socio, txt_codigo_pelicula, txt_nombre_socio, txt_precio_pelicula, txt_cantidad_pelicula, txt_importe, txt_total_renta)
                dt_detalles_renta.Rows.Clear()

                'Insertar el adeudo de la renta
                Try
                    adeudo.id_renta = num_renta
                    adeudo.total_adeudo = 0
                    adeudo.estatus = "No pagado"
                    funcionesAdeudo.insertar_adeudo(adeudo)
                Catch ex As Exception

                End Try

                'Codigo para realizar factura
                numero_de_renta = num_renta
                Dim formGenerarTicketRenta As New FormGenerarReciboRenta
                formGenerarTicketRenta.Show()
            Else
                MsgBox("El socio tiene un adeudo pendiente por lo que no se puede realizar rentas hasta que cubra los adeudos correspondientes")
            End If
        End If
    End Sub

End Class