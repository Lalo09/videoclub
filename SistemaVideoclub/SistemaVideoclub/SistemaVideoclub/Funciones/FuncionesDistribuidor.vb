'Clase con metodos para realizar operaciones con la base de datos con sentencias SQL:
'insertar, actualizar, borrar distribuidores
Public Class FuncionesDistribuidor

    Public Sub insertar_distribuidor(ByVal distribuidor As ClassDistribuidor)
        Dim consulta As String = "INSERT INTO distribuidor(nombre,pais,direccion,correo_electronico,sitio_web,telefono) Values ( '" & distribuidor.nombre & "','" & distribuidor.pais & "','" & distribuidor.direccion & "','" & distribuidor.correo & "','" & distribuidor.sitioWeb & "','" & distribuidor.telefono & "')"
        ejecutar(consulta)
    End Sub

    Public Sub actualizar_distribuidor(ByVal distribuidor As ClassDistribuidor)
        Dim consulta As String = "UPDATE distribuidor SET nombre='" & distribuidor.nombre & "', pais='" & distribuidor.pais & "', direccion='" & distribuidor.direccion & "',correo_electronico='" & distribuidor.correo & "',sitio_web='" & distribuidor.sitioWeb & "' ,telefono='" & distribuidor.telefono & "' WHERE id_distribuidor = " & distribuidor.id
        ejecutar(consulta)
    End Sub

    Public Sub eliminar_distribuidor(ByRef id_distribuidpr As String)
        Dim consulta As String = "DELETE FROM distribuidor WHERE id_distribuidor = " & id_distribuidpr
        ejecutar(consulta)
    End Sub

    Public Sub mostrar_distribuidores(ByRef data As DataGridView)
        Dim consulta As String = "SELECT id_distribuidor as 'Numero de distribuidor', nombre as 'Nombre', pais as 'Pais', direccion as 'Direccion', correo_electronico as 'Correo electronico', sitio_web as 'Sitio web', telefono as 'Telefono' FROM distribuidor"
        mostrar(consulta, data)
    End Sub

    Public Sub buscar_distribuidor(ByRef datagrid As DataGridView, ByRef nombre As String)
        Dim consulta As String = "SELECT id_distribuidor as 'Numero de distribuidor', nombre as 'Nombre', pais as Pais, direccion as Direccion, correo_electronico as 'Correo electronico', sitio_web as 'Sitio web', telefono as 'Telefono' FROM distribuidor WHERE nombre = '" & nombre & "'"
        mostrar(consulta, datagrid)
    End Sub

    Public Function existe_distribuidor(ByVal distribuidor As ClassDistribuidor)
        Dim consulta As String = "SELECT count(*) FROM distribuidor WHERE id_distribuidor=" & distribuidor.id
        If (existe(consulta) = True) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
