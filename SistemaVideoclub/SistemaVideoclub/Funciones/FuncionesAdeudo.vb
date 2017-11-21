Public Class FuncionesAdeudo

    Public Sub insertar_adeudo(ByVal adeudo As ClassAdeudo)
        Dim consulta As String = "INSERT INTO adeudo (id_renta,total_adeudo,estatus) Values (" & adeudo.id_renta & "," & adeudo.total_adeudo & ",'" & adeudo.estatus & "')"
        ejecutar(consulta)
    End Sub

    Public Sub actualizar_adeudo(ByRef total As Double, ByRef estatus As String, ByRef id As Integer)
        Dim consulta As String = "UPDATE adeudo SET total_adeudo=" & total & ", estatus ='" & estatus & "' WHERE id_adeudo = " & id
        ejecutar(consulta)
    End Sub

    Public Function getUltimo_adeudo(ByRef id As Integer)

        Try
            Conectar()
            Dim consulta As String = "select id_adeudo from adeudo where id_renta = (SELECT top 1 id_renta FROM renta where id_socio = " & id & " order by id_renta desc  )"
            consultar_elemento(consulta)
            If dr.Read Then
                Return dr(0)
                dr.Close()
            End If
        Catch ex As Exception

        Finally
            Desconectar()
        End Try

    End Function

    Public Sub mostrar_adeudos(ByRef datagrid As DataGridView)
        Dim consulta As String = "select id_adeudo as 'Numero de adeudo', id_renta as 'Numero de renta', total_adeudo as 'Total', estatus as 'Estatus' from adeudo"
        mostrar(consulta, datagrid)
    End Sub


    Public Sub buscar_adeudos(ByRef datagrid As DataGridView, ByRef id As Integer)
        Dim consulta As String = "select adeudo.id_adeudo as 'Numero de adeudo', adeudo.id_renta as 'Numero de renta', adeudo.total_adeudo as 'Total', adeudo.estatus as 'Estatus' from adeudo,renta where adeudo.id_renta = renta.id_renta and id_socio = " & id
        mostrar(consulta, datagrid)
    End Sub
    'Public Sub mostrar_clientes(ByRef datagrid As DataGridView)
    '    Dim consulta As String = "SELECT id_cliente as 'Numero de cliente',nombre as 'Nombre',apellido_paterno as 'Apellido paterno',apellido_materno as 'Apellido matenrno' FROM cliente"
    '    mostrar(consulta, datagrid)
    'End Sub

    'Public Sub buscar_clientes(ByRef datagrid As DataGridView, ByRef id_socio As Integer)
    '    Dim consulta As String = "SELECT id_cliente as 'Numero de cliente',nombre as 'Nombre',apellido_paterno as 'Apellido paterno',apellido_materno as 'Apellido matenrno' FROM cliente WHERE nombre Like '%" & nombre & "%'"
    '    mostrar(consulta, datagrid)
    'End Sub
End Class
