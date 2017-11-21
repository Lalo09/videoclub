Public Class FuncionesRenta
    Public Sub insertar_renta(ByVal renta As ClassRenta)
        Dim consulta As String = "INSERT INTO renta(id_empleado,id_socio,fecha_renta,fecha_devolucion,total) VALUES (" & renta.id_empleado & "," & renta.id_socio & ",'" & renta.fecha_renta & "','" & renta.fecha_devolucion & "'," & renta.total & ")"
        ejecutar(consulta)
    End Sub

    Public Sub modificar_precio_renta(ByVal renta As ClassRenta)
        Dim consulta As String = "UPDATE renta SET total = " & renta.total & "WHERE id_renta = " & renta.id
        ejecutar(consulta)
    End Sub

    Public Sub eliminar_renta(ByVal renta As ClassRenta)
        Dim consulta As String = "DELETE FROM renta WHERE id_renta = " & renta.id
    End Sub

    Public Sub mostrar_rentas(ByRef datagrid As DataGridView)
        Dim consulta As String = "SELECT id_renta as 'Numero de renta', id_socio as 'Numero de socio', fecha_renta as 'Fecha de renta', fecha_devolucion as 'Fecha de devolucion', total as 'Total' FROM renta "
        mostrar(consulta, datagrid)
    End Sub

    Public Sub buscar_rentas_idSocio(ByRef datagrid As DataGridView, ByRef fecha_in As String, ByRef fecha_fin As String, ByRef id_socio As Integer)
        Dim consulta As String = "SELECT id_renta as 'Numero de renta', id_socio as 'Numero de socio', fecha_renta as 'Fecha de renta', fecha_devolucion as 'Fecha de devolucion', total as 'Total' FROM renta WHERE fecha_renta BETWEEN '" & fecha_in & "' AND '" & fecha_fin & "' AND id_socio = " & id_socio
        mostrar(consulta, datagrid)
    End Sub

    Public Sub buscar_rentas_idrenta(ByRef datagrid As DataGridView, ByRef fecha_in As String, ByRef fecha_fin As String, ByRef id_renta As Integer)
        Dim consulta As String = "SELECT id_renta as 'Numero de renta', id_socio as 'Numero de socio', fecha_renta as 'Fecha de renta', fecha_devolucion as 'Fecha de devolucion', total as 'Total' FROM renta WHERE fecha_renta BETWEEN '" & fecha_in & "' AND '" & fecha_fin & "' AND id_renta = " & id_renta
        mostrar(consulta, datagrid)
    End Sub

    Public Function getUltima_renta()

        Try
            Conectar()
            Dim consulta As String = "SELECT TOP 1 id_renta FROM renta Order by id_renta desc"
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
