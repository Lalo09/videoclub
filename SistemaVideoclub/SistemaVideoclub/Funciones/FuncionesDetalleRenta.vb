Public Class FuncionesDetalleRenta

    Public Sub insertar_detalle_renta(ByVal detalle_renta As ClassDetalleRenta)
        Dim consulta As String = "INSERT INTO detalle_renta (id_pelicula,id_renta,cantidad,total) VALUES ( " & detalle_renta.id_pelicula & "," & detalle_renta.id_renta & "," & detalle_renta.cantidad & "," & detalle_renta.total & ")"
        ejecutar(consulta)
    End Sub

    Public Sub mostrar_renta(ByRef datagrid As DataGridView, ByRef id As Integer)
        Dim consulta As String = "select pelicula.id_pelicula as 'Numero de pelicula', pelicula.nombre as 'Nombre' from pelicula,detalle_renta where pelicula.id_pelicula = detalle_renta.id_pelicula and id_renta = (select top 1 id_renta from renta where id_socio = " & id & " order by id_renta desc)"
        mostrar(consulta, datagrid)
    End Sub
End Class
