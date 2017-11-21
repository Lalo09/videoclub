Public Class FuncionesDetalleVenta

    Public Sub insertar_detalle_venta(ByVal detalle_venta As ClassDetalleVenta)
        Dim consulta As String = "INSERT INTO detalle_venta (id_pelicula,id_venta,cantidad,total) VALUES ( " & detalle_venta.id_pelicula & "," & detalle_venta.id_venta & "," & detalle_venta.cantidad & "," & detalle_venta.total & ")"
        ejecutar(consulta)
    End Sub

End Class
