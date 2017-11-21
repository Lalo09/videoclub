Public Class FuncionesVenta

    Public Sub insertar_venta(ByVal venta As ClassVenta)
        Dim consulta As String = "INSERT INTO venta(id_empleado,id_cliente,fecha_venta,total,metodo_pago) VALUES (" & venta.id_empleado & "," & venta.id_cliente & ",'" & venta.fecha & "'," & venta.total & ",'" & venta.metodo_pago & "')"
        ejecutar(consulta)
    End Sub

    Public Sub modificar_precio_venta(ByVal venta As ClassVenta)
        Dim consulta As String = "UPDATE venta SET total = " & venta.total & "WHERE id_venta = " & venta.id
        ejecutar(consulta)
    End Sub

    Public Sub eliminar_venta(ByVal venta As ClassVenta)
        Dim consulta As String = "DELETE FROM venta WHERE id_venta = " & venta.id
    End Sub

    Public Sub mostrar_ventas(ByRef datagrid As DataGridView)
        Dim consulta As String = "SELECT id_venta as 'Numero de venta', id_cliente as 'Numero de cliente', fecha_venta as 'Fecha', total as 'Total', metodo_pago as 'Metodo de pago' FROM venta "
        mostrar(consulta, datagrid)
    End Sub

    Public Sub buscar_ventas_idCliente(ByRef datagrid As DataGridView, ByRef fecha_in As String, ByRef fecha_fin As String, ByRef id_cliente As Integer)
        Dim consulta As String = "SELECT id_venta as 'Numero de venta', id_empleado as 'Numero de empleado', id_cliente as 'Numero de cliente', fecha_venta as 'Fecha', total as 'Total', metodo_pago as 'Metodo de pago' FROM venta WHERE fecha_venta BETWEEN '" & fecha_in & "' AND '" & fecha_fin & "' AND id_cliente = " & id_cliente
        mostrar(consulta, datagrid)
    End Sub

    Public Sub buscar_ventas_idVenta(ByRef datagrid As DataGridView, ByRef fecha_in As String, ByRef fecha_fin As String, ByRef id_venta As Integer)
        Dim consulta As String = "SELECT id_venta as 'Numero de venta', id_empleado as 'Numero de empleado', id_cliente as 'Numero de cliente', fecha_venta as 'Fecha', total as 'Total', metodo_pago as 'Metodo de pago' FROM venta WHERE fecha_venta BETWEEN '" & fecha_in & "' AND '" & fecha_fin & "' AND id_venta = " & id_venta
        mostrar(consulta, datagrid)
    End Sub


    Public Sub buscar_ventas(ByRef datagrid As DataGridView, ByRef fecha_in As String, ByRef fecha_fin As String)
        Dim consulta As String = "SELECT id_venta as 'Numero de venta', id_empleado as 'Numero de empleado', id_cliente as 'Numero de cliente', fecha_venta as 'Fecha', total as 'Total', metodo_pago as 'Metodo de pago' FROM venta WHERE fecha_venta BETWEEN '" & fecha_in & "' AND '" & fecha_fin & "'"
        mostrar(consulta, datagrid)
    End Sub

    Public Function getUltima_venta()

        Try
            Conectar()
            Dim consulta As String = "SELECT TOP 1 id_venta FROM venta Order by id_venta desc"
            consultar_elemento(consulta)
            If dr.Read Then
                Return dr(0).ToString
                dr.Close()
            End If
        Catch ex As Exception

        Finally
            Desconectar()
        End Try

    End Function

End Class
