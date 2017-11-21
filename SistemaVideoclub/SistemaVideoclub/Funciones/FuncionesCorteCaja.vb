Public Class FuncionesCorteCaja

    Public Sub insertar_caja(ByVal corteCaja As ClassCorteCaja)
        Dim consulta As String = "INSERT INTO corte_de_caja (fecha,balance) Values ( ' " & corteCaja.fecha & " ' ,  " & corteCaja.balance & ")"
        ejecutar(consulta)
    End Sub

    Public Sub mostrar_cortesCaja(ByRef datagrid As DataGridView)
        Dim consulta As String = "select id_corte_de_Caja as 'Numero de corte de caja', fecha as 'Fecha', balance as 'Balance Total' from corte_de_caja order by fecha desc"
        mostrar(consulta, datagrid)
    End Sub

    Public Sub buscar_cortesCaja(ByRef datagrid As DataGridView, ByRef fecha_in As String, ByRef fecha_fin As String)
        Dim consulta As String = "select id_corte_de_Caja as 'Numero de corte de caja', fecha as 'Fecha', balance as 'Balance Total' from corte_de_caja Where fecha between '" & fecha_in & "' and '" & fecha_fin & "'"
        mostrar(consulta, datagrid)
    End Sub

    Public Function getTotalRentas(ByRef fecha As String)

        Try
            Conectar()
            Dim consulta As String = "SELECT sum(total) from renta where fecha_renta = '" & fecha & "'"
            consultar_elemento(consulta)
            If dr.Read Then
                Return dr(0).ToString
                dr.Close()
            End If
        Catch ex As Exception
            Return 0
        Finally
            Desconectar()
        End Try

    End Function

    Public Function getTotalVentas(ByRef fecha As String)

        Try
            Conectar()
            Dim consulta As String = "SELECT sum(total) from venta where fecha_venta = '" & fecha & "'"
            consultar_elemento(consulta)
            If dr.Read Then
                Return dr(0).ToString
                dr.Close()
            End If
        Catch ex As Exception
            Return 0
        Finally
            Desconectar()
        End Try

    End Function

    Public Function getAdeudosPagados(ByRef fecha As String)

        Try
            Conectar()
            Dim consulta As String = "select sum(distinct a.total_adeudo) from devolucion_pelicula dp join socio s on dp.id_socio = s.id_socio join renta r on s.id_socio = r.id_socio join adeudo a on a.id_renta = r.id_renta where dp.fecha_devolucion = '" & fecha & "' and a.estatus = 'Pagado'"
            consultar_elemento(consulta)
            If dr.Read Then
                Return dr(0).ToString
                dr.Close()
            End If
        Catch ex As Exception
            Return 0
        Finally
            Desconectar()
        End Try

    End Function

    Public Function getTotalPeliculasCompradas(ByRef fecha As String)

        Try
            Conectar()
            Dim consulta As String = "select (cantidad_en_existencia * precio_compra) as 'total de peliculas' from  pelicula where fecha_adquicision = '" & fecha & "'"
            consultar_elemento(consulta)
            If dr.Read Then
                Return dr(0).ToString
                dr.Close()
            End If
        Catch ex As Exception
            Return 0
        Finally
            Desconectar()
        End Try

    End Function

    Public Function getTotalSueldo(ByRef fecha As String)

        Try
            Conectar()
            Dim consulta As String = "select sum(sueldo) from empleado"
            consultar_elemento(consulta)
            If dr.Read Then
                Return dr(0).ToString
                dr.Close()
            End If
        Catch ex As Exception
            Return 0
        Finally
            Desconectar()
        End Try

    End Function
End Class
