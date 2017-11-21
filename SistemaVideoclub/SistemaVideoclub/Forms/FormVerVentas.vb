Public Class FormVerVentas

    Dim funcionesVenta As New FuncionesVenta
    Dim venta As New ClassVenta

    Private Sub FormVerVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            funcionesVenta.mostrar_ventas(dg_ventas)
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos")
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        If cb_solofechas.Checked = True Then
            funcionesVenta.buscar_ventas(dg_ventas, dt_inicio.Value.ToString("MM/dd/yyyy"), dt_fin.Value.ToString("MM/dd/yyyy"))
        Else
            If rb_por_cliente.Checked = True Then
                funcionesVenta.buscar_ventas_idCliente(dg_ventas, dt_inicio.Value.ToString("MM/dd/yyyy"), dt_fin.Value.ToString("MM/dd/yyyy"), txt_buscar.Text)
            ElseIf rb_por_venta.Checked = True Then
                funcionesVenta.buscar_ventas_idVenta(dg_ventas, dt_inicio.Value.ToString("MM/dd/yyyy"), dt_fin.Value.ToString("MM/dd/yyyy"), txt_buscar.Text)
            Else
                MsgBox("Seleccione una opcion")
            End If
        End If

    End Sub

    Private Sub dg_ventas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_ventas.CellClick
        Dim i As Integer
        i = dg_ventas.CurrentRow.Index
        lbl_id_venta.Text = dg_ventas.Item(0, i).Value
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            venta.id = lbl_id_venta.Text
            funcionesVenta.eliminar_venta(venta)
            MsgBox("Venta eliminado exitosamente")
            funcionesVenta.mostrar_ventas(dg_ventas)
        Catch ex As Exception
            MsgBox("No se puede eliminar venta")
        End Try
    End Sub

    Private Sub btn_deshacer_Click(sender As Object, e As EventArgs) Handles btn_deshacer.Click
        Try
            funcionesVenta.mostrar_ventas(dg_ventas)
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos")
        End Try
    End Sub
End Class