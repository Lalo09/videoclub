Public Class FormClientes

    Dim cliente As New ClassCliente
    Dim funcionesCliente As New FuncionesCliente

    'Accion realizada al momento de dar clic al boton de grabar
    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        If lbl_id.Text <> Nothing Then
            cliente.id = lbl_id.Text
        Else
            cliente.id = -1
        End If

        If funcionesCliente.existe_cliente(cliente) Then
            If txt_nombre.Text <> Nothing And txt_ap_paterno.Text <> Nothing Then
                cliente.nombre = txt_nombre.Text
                cliente.apellido_paterno = txt_ap_paterno.Text
                cliente.apellido_materno = txt_ap_materno.Text
                Try
                    funcionesCliente.actualizar_cliente(cliente)
                    MsgBox("Cliente actualizado correctamente")
                    funcionesCliente.mostrar_clientes(dg_clientes)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Limpiar(txt_nombre, txt_ap_materno, txt_ap_paterno, txt_buscarCliente, lbl_id)
            Else
                MsgBox("Inserte nombre y apellidos del cliente!")
            End If
        Else
            If txt_nombre.Text <> Nothing And txt_ap_paterno.Text <> Nothing Then
                cliente.nombre = txt_nombre.Text
                cliente.apellido_paterno = txt_ap_paterno.Text
                cliente.apellido_materno = txt_ap_materno.Text
                Try
                    funcionesCliente.insertar_cliente(cliente)
                    MsgBox("Cliente insertado correctamente")
                    funcionesCliente.mostrar_clientes(dg_clientes)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Limpiar(txt_nombre, txt_ap_materno, txt_ap_paterno, txt_buscarCliente, lbl_id)
            Else
                MsgBox("Inserte nombre y apellidos del cliente!")
            End If
        End If
    End Sub

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            funcionesCliente.mostrar_clientes(dg_clientes)
        Catch ex As Exception
            MsgBox("No se han podido cargar los datos: " + ex.Message)
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        'Probar funcionamiento de busqueda
        'cliente.id = 12
        'funciones.existe_cliente(cliente)
        Dim cliente_a_buscar As String = txt_buscarCliente.Text
        funcionesCliente.buscar_clientes(dg_clientes, cliente_a_buscar)
    End Sub

    Private Sub dg_clientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_clientes.CellClick
        Dim i As Integer
        i = dg_clientes.CurrentRow.Index
        lbl_id.Text = dg_clientes.Item(0, i).Value
        txt_nombre.Text = dg_clientes.Item(1, i).Value
        txt_ap_paterno.Text = dg_clientes.Item(2, i).Value
        txt_ap_materno.Text = dg_clientes.Item(3, i).Value
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Limpiar(txt_nombre, txt_ap_materno, txt_ap_paterno, txt_buscarCliente, lbl_id)
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            If lbl_id.Text >= 1 Then
                cliente.id = lbl_id.Text
                funcionesCliente.eliminar_cliente(cliente)
                funcionesCliente.mostrar_clientes(dg_clientes)
                MsgBox("Cliente eliminado correctamente")
                Limpiar(txt_nombre, txt_ap_materno, txt_ap_paterno, txt_buscarCliente, lbl_id)
            Else
                MsgBox("Seleccione un cliente para eliminar")
            End If
        Catch ex As Exception
            MsgBox("Seleccione un cliente para eliminar")
        End Try
    End Sub

    Private Sub btn_deshacerBusqueda_Click(sender As Object, e As EventArgs) Handles btn_deshacerBusqueda.Click
        Try
            funcionesCliente.mostrar_clientes(dg_clientes)
        Catch ex As Exception
            MsgBox("No se han podido cargar los datos: " + ex.Message)
        End Try
    End Sub
End Class