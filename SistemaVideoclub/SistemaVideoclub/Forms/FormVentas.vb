Public Class FormVentas

    Dim cliente As New ClassCliente
    Dim funcionesEmpleado As New FuncionesEmpleado
    Dim funcionesCliente As New FuncionesCliente
    Dim pelicula As New ClassPelicula
    Dim funcionesPelicula As New FuncionesPelicula
    Dim venta As New ClassVenta
    Dim funcionesVenta As New FuncionesVenta
    Dim detalle_venta As New ClassDetalleVenta
    Dim funcionesDetalleVenta As New FuncionesDetalleVenta

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nombre_empleado.Text = funcionesEmpleado.getNombre_empleado(numero_de_empleado)
    End Sub

    Private Sub txt_id_socio_Leave(sender As Object, e As EventArgs) Handles txt_id_cliente.Leave
        If txt_id_cliente.Text <> Nothing Then
            Try
                cliente.id = txt_id_cliente.Text
                If funcionesCliente.existe_cliente(cliente) Then
                    txt_nombre_cliente.Text = funcionesCliente.getNombre_cliente(txt_id_cliente.Text)
                Else
                    MsgBox("El cliente no existe")
                    txt_id_cliente.Focus()
                End If

            Catch ex As Exception
                MsgBox("El cliente no existe")
            End Try
        End If
    End Sub

    Private Sub btn_buscar_cliente_Click(sender As Object, e As EventArgs) Handles btn_buscar_cliente.Click
        Dim formclientes As New FormClientes()
        formclientes.MdiParent = FormMDI.ActiveForm
        formclientes.Show()
    End Sub

    Private Sub txt_codigo_pelicula_Leave(sender As Object, e As EventArgs) Handles txt_codigo_pelicula.Leave
        If txt_codigo_pelicula.Text <> Nothing Then
            pelicula.id = txt_codigo_pelicula.Text
            If funcionesPelicula.existe_pelicula(pelicula) = True Then
                txt_nombre_pelicula.Text = funcionesPelicula.getNombre_pelicula(txt_codigo_pelicula.Text)
                txt_precio_pelicula.Text = funcionesPelicula.getPrecio_pelicula(txt_codigo_pelicula.Text)
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
                If dt_detalles_venta.RowCount < 1 Then
                    Agregar_pelicula()
                Else

                    For fila = 0 To dt_detalles_venta.RowCount - 1

                        If cod_pelicula = dt_detalles_venta.Item(0, fila).Value Then

                            dt_detalles_venta.Rows.RemoveAt(dt_detalles_venta.CurrentRow.Index)
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

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click
        If dt_detalles_venta.RowCount > 0 Then
            dt_detalles_venta.Rows.RemoveAt(dt_detalles_venta.CurrentRow.Index)
            txt_total_venta.Text = Calcular_importe()
        End If

    End Sub

    Public Function Calcular_importe()
        Dim x As Double
        For fila = 0 To dt_detalles_venta.RowCount - 1
            On Error Resume Next
            x = x + dt_detalles_venta.Item(4, fila).Value
        Next
        Return x
    End Function

    Public Function Agregar_pelicula()
        dt_detalles_venta.Rows.Add(txt_codigo_pelicula.Text, txt_nombre_pelicula.Text, txt_precio_pelicula.Text, txt_cantidad_pelicula.Text, txt_importe.Text)
        txt_total_venta.Text = Calcular_importe()
        Limpiar(txt_codigo_pelicula, txt_nombre_pelicula, txt_precio_pelicula, txt_cantidad_pelicula, txt_importe)
    End Function

    Private Sub btn_realizar_renta_Click(sender As Object, e As EventArgs) Handles btn_realizar_renta.Click
        'Realizar venta
        venta.id_empleado = numero_de_empleado
        venta.id_cliente = txt_id_cliente.Text
        venta.fecha = dt_fecha_venta.Value.Date.ToString("MM/dd/yyyy")
        venta.total = txt_total_venta.Text
        'venta.metodo_pago = "Efectivo"
        venta.metodo_pago = cmb_metodo_pago.Text

        Try
            funcionesVenta.insertar_venta(venta)
        Catch ex As Exception

        End Try

        Dim num_venta As Integer = funcionesVenta.getUltima_venta()

        For fila = 0 To dt_detalles_venta.RowCount - 1
            detalle_venta.id_pelicula = dt_detalles_venta.Item(0, fila).Value
            detalle_venta.id_venta = num_venta
            detalle_venta.cantidad = dt_detalles_venta.Item(3, fila).Value
            detalle_venta.total = dt_detalles_venta.Item(4, fila).Value

            Try
                funcionesDetalleVenta.insertar_detalle_venta(detalle_venta)
            Catch ex As Exception

            End Try
            'MsgBox(dt_detalles_venta.Item(0, fila).Value + dt_detalles_venta.Item(3, fila).Value + " " + dt_detalles_venta.Item(4, fila).Value)
        Next

        MsgBox("Venta realizada")
        Limpiar(txt_id_cliente, txt_nombre_cliente, txt_codigo_pelicula, txt_nombre_cliente, txt_precio_pelicula, txt_cantidad_pelicula, txt_importe, txt_total_venta)
        dt_detalles_venta.Rows.Clear()

        numero_de_venta = num_venta

        Dim formGenerarTicketVenta As New FormGenerarReciboVenta
        formGenerarTicketVenta.Show()

    End Sub

    Private Sub dt_detalles_venta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_detalles_venta.CellClick
        Dim i As Integer
        i = dt_detalles_venta.CurrentRow.Index
        txt_codigo_pelicula.Text = dt_detalles_venta.Item(0, i).Value
        txt_nombre_pelicula.Text = dt_detalles_venta.Item(1, i).Value
        txt_precio_pelicula.Text = dt_detalles_venta.Item(2, i).Value
        txt_cantidad_pelicula.Text = dt_detalles_venta.Item(3, i).Value
        txt_importe.Text = dt_detalles_venta.Item(4, i).Value
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Limpiar(txt_id_cliente, txt_nombre_cliente, txt_codigo_pelicula, txt_nombre_cliente, txt_precio_pelicula, txt_cantidad_pelicula, txt_importe, txt_total_venta)
        dt_detalles_venta.Rows.Clear()
    End Sub
End Class