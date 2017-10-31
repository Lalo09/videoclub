Public Class FuncionesEmpleado

    Public Sub insertar_empleado(ByVal empleado As ClassEmpleado)
        Dim consulta As String = "INSERT INTO empleado(nombre,apellido_paterno,apellido_materno,sexo,telefono,correo_electronico,calle,numero_exterior,numero_interior,colonia,ciudad,pais,fotografia,sueldo,fecha_nacimiento) Values ( '" & empleado.nombre & "','" & empleado.apellido_paterno & "','" & empleado.apellido_materno & "','" & empleado.sexo & "','" & empleado.telefono & "','" & empleado.correo_electronico & "','" & empleado.calle & "','" & empleado.numero_exterior & "','" & empleado.numero_interior & "','" & empleado.colonia & "','" & empleado.ciudad & "','" & empleado.pais & "','" & empleado.fotografia & "','" & empleado.sueldo & "','" & empleado.fecha_nacimiento & "')"
        ejecutar(consulta)
    End Sub

    Public Sub actualizar_empleado(ByVal empleado As ClassEmpleado)
        Dim consulta As String = "UPDATE empleado SET nombre='" & empleado.nombre & "', apellido_paterno='" & empleado.apellido_paterno & "', apellido_materno='" & empleado.apellido_materno & "',sexo='" & empleado.sexo & "',telefono='" & empleado.telefono & "',correo_electronico='" & empleado.correo_electronico & "',calle='" & empleado.calle & "',numero_exterior='" & empleado.numero_exterior & "',numero_interior='" & empleado.numero_interior & "',colonia='" & empleado.colonia & "',ciudad='" & empleado.ciudad & "',pais='" & empleado.pais & "',fotografia='" & empleado.fotografia & "',sueldo='" & empleado.sueldo & "',fecha_nacimiento='" & empleado.fecha_nacimiento & "'  WHERE id_empleado = " & empleado.id
        ejecutar(consulta)
    End Sub

    Public Sub eliminar_empleado(ByRef id_empleado As String)
        Dim consulta As String = "DELETE FROM empleado WHERE id_empleado = " & id_empleado
        ejecutar(consulta)
    End Sub

    Public Sub mostrar_empleados(ByRef data As DataGridView)
        Dim consulta As String = "SELECT id_empleado as 'Numero de Empleado',nombre as 'Nombre',apellido_paterno as 'Apellido PAT',apellido_materno as 'Apellido Mat',sexo as 'Sexo',telefono as 'Telefono',correo_electronico as 'Email',calle as 'Calle',numero_exterior as 'Num Ext',numero_interior as 'Num Int',colonia as 'Colonia',ciudad as 'Ciudad',pais as 'Pais',fotografia as 'Fotografia',sueldo as 'Sueldo',fecha_nacimiento as 'Fecha Nacimiento' FROM empleado"
        mostrar(consulta, data)
    End Sub

    Public Sub buscar_empleado(ByRef datagrid As DataGridView, ByRef numero As Integer)
        Dim consulta As String = "SELECT id_empleado as 'Numero de Empleado',nombre as 'Nombre',apellido_paterno as 'Apellido PAT',apellido_materno as 'Apellido Mat',sexo as 'Sexo',telefono as 'Telefono',correo_electronico as 'Email',calle as 'Calle',numero_exterior as 'Num Ext',numero_interior as 'Num Int',colonia as 'Colonia',ciudad as 'Ciudad',pais as 'Pais',fotografia as 'Fotografia',sueldo as 'Sueldo',fecha_nacimiento as 'Fecha Nacimiento' FROM empleado WHERE id_empleado = '" & numero & "'"
        mostrar(consulta, datagrid)
    End Sub

    Public Function existe_empleado(ByVal empleado As ClassEmpleado)
        Dim consulta As String = "SELECT count(*) FROM empleado WHERE id_empleado=" & empleado.id
        If (existe(consulta) = True) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class