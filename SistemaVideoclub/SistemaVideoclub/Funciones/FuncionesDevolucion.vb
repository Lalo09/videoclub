Public Class FuncionesDevolucion

    Public Sub insertar_devolucion(ByVal devolucion As ClassDevolucion)
        Dim consulta As String = "INSERT INTO devolucion_pelicula (id_pelicula,id_empleado,id_socio,fecha_devolucion,estado_pelicula) Values (" & devolucion.id_pelicula & "," & devolucion.id_empleado & "," & devolucion.id_socio & ",'" & devolucion.fecha_devolucion & "','" & devolucion.estado_pelicula & "')"
        ejecutar(consulta)
    End Sub

    Public Sub eliminar_devolucion(ByVal devolucion As ClassDevolucion)
        Dim consulta As String = "DELETE FROM devolucion_pelicula WHERE id_devolucion_pelicula = " & devolucion.id
        ejecutar(consulta)
    End Sub

    Public Sub mostrar_devolucion(ByRef datagrid As DataGridView)
        Dim consulta As String = "SELECT id_devolucion_pelicula as 'Numero de devolucion' , id_pelicula as 'Numero de pelicula', id_empleado as 'Numero de empleado', id_socio as 'Numero de socio', fecha_Devolucion as 'Fecha de devolucion', estado_pelicula as 'Estado de entrega' FROM devolucion_pelicula"
        mostrar(consulta, datagrid)
    End Sub

    Public Sub buscar_devolucion(ByRef datagrid As DataGridView, ByRef id As Integer)
        Dim consulta As String = "SELECT id_devolucion_pelicula as 'Numero de devolucion' , id_pelicula as 'Numero de pelicula', id_empleado as 'Numero de empleado', id_socio as 'Numero de socio', fecha_Devolucion as 'Fecha de devolucion', estado_pelicula as 'Estado de entrega' FROM devolucion_pelicula WHERE id_socio = " & id
        mostrar(consulta, datagrid)
    End Sub
End Class
