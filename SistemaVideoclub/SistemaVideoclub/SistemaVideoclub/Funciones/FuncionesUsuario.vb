Public Class FuncionesUsuario

    Public Sub insertar_usuario(ByVal usuario As ClassUsuario)
        Dim consulta As String = "INSERT INTO usuario (id_empleado,contrasena,tipo_usuario,estatus) VALUES (" & usuario.id_empleado & ",'" & usuario.contrasena & "','" & usuario.tipo_usuario & "','" & usuario.estatus & "')"
        ejecutar(consulta)
    End Sub

    Public Sub actualizar_usuario(ByVal usuario As ClassUsuario)
        Dim consulta As String = "UPDATE usuario SET contrasena = '" & usuario.contrasena & "', tipo_usuario = '" & usuario.tipo_usuario & "', estatus = '" & usuario.estatus & "' WHERE id_empleado = " & usuario.id_empleado
        ejecutar(consulta)
    End Sub

    Public Sub eliminar_usuario(ByVal usuario As ClassUsuario)
        Dim consulta As String = "DELETE FROM usuario FROM id_empleado = " & usuario.id_empleado
        ejecutar(consulta)
    End Sub

    Public Sub mostrar_usuario(ByRef datagrid As DataGridView)
        Dim consulta As String = "SELECT id_empleado as 'Numero de empleado', tipo_usuario as 'Tipo de usuario', estatus as 'Estatus ' FROM usuario"
        mostrar(consulta, datagrid)
    End Sub

    Public Sub buscar_usuario(ByRef datagrid As DataGridView, ByRef id_empleado As String)
        Dim consulta As String = "SELECT id_empleado as 'Numero de empleado', tipo_usuario as 'Tipo de usuario', estatus as 'Estatus ' FROM usuario WHERE id_empleado = " & id_empleado
        mostrar(consulta, datagrid)
    End Sub

    Public Function existe_usuario(ByVal usuario As ClassUsuario)
        Dim consulta As String = "SELECT id_empleado,contrasena FROM usuario WHERE id_empleado =" & usuario.id_empleado & " AND contrasena = '" & usuario.contrasena & "' AND estatus = 'Activo'"
        If (existe(consulta) = True) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function es_editable_usario(ByVal usuario As ClassUsuario)
        Dim consulta As String = "SELECT id_empleado FROM usuario WHERE id_empleado=" & usuario.id_empleado
        If (existe(consulta) = True) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function es_admin(ByVal num_empl As String)
        Dim consulta As String = "SELECT id_empleado FROM usuario WHERE id_empleado=" & num_empl & " AND tipo_usuario = 'admin' AND estatus = 'Activo' "
        If (existe(consulta) = True) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class