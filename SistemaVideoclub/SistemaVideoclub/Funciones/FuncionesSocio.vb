'Clase con metodos para realizar operaciones con la base de datos con sentencias SQL:
'insertar, actualizar, borrar socios
Public Class FuncionesSocio

    Public Sub insertar_socio(ByVal socio As ClassSocio)
        Dim consulta As String = "INSERT INTO socio (id_cliente,sexo,telefono,correo_electronico,calle,numero_exterior,numero_interior,colonia,ciudad,pais,fotografia,fecha_expedicion,fecha_vigencia,estatus) Values ( " & socio.id_cliente & ",'" & socio.sexo & "','" & socio.telefono & "','" & socio.correo & "','" & socio.calle & "','" & socio.numeroExt & "','" & socio.numeroInt & "','" & socio.colonia & "','" & socio.ciudad & "','" & socio.pais & "','" & socio.fotografia & "','" & socio.fechaExp & "','" & socio.fechaVig & "','" & socio.estatus & "')"
        ejecutar(consulta)
    End Sub

    Public Sub actualizar_socio(ByVal socio As ClassSocio)
        Dim consulta As String = "UPDATE socio SET sexo='" & socio.sexo & "',telefono='" & socio.telefono & "',correo_electronico='" & socio.correo & "',calle='" & socio.calle & "',numero_exterior='" & socio.numeroExt & "' ,numero_interior='" & socio.numeroInt & "',colonia='" & socio.colonia & "',ciudad='" & socio.ciudad & "',pais='" & socio.pais & "',fotografia='" & socio.fotografia & "',fecha_expedicion='" & socio.fechaExp & "',fecha_vigencia='" & socio.fechaVig & "',estatus='" & socio.estatus & "' WHERE id_socio = " & socio.id
        ejecutar(consulta)
    End Sub

    Public Sub eliminar_socio(ByVal socio As ClassSocio)
        Dim consulta As String = "DELETE FROM socio WHERE id_socio = " & socio.id
        ejecutar(consulta)
    End Sub

    Public Sub mostrar_socios(ByRef datagrid As DataGridView)
        Dim consulta As String = "SELECT id_socio as 'Numero de socio',id_cliente as 'Numero de cliente', sexo as 'Sexo', telefono as 'Telefono', correo_electronico as 'Correo Electronico', calle as 'Calle', numero_exterior as 'Numero exterior', numero_interior as 'Numero interior', colonia as 'Colonia', ciudad as 'Ciudad', pais as 'Pais', fotografia as 'Fotografia', fecha_expedicion as 'Fecha de expedicion', fecha_vigencia as 'Fecha de vigencia', estatus as 'Estatus' FROM socio"
        mostrar(consulta, datagrid)
    End Sub

    Public Sub buscar_socio(ByRef datagrid As DataGridView, ByRef id_socio As Integer)
        Dim consulta As String = "SELECT id_socio as 'Numero de socio', sexo as 'Sexo', telefono as 'Telefono', correo_electronico as 'Correo Electronico', calle as 'Calle', numero_exterior as 'Numero exterior', numero_interior as 'Numero interior', colonia as 'Colonia', ciudad as 'Ciudad', pais as 'Pais', fecha_expedicion as 'Fecha de expedicion', fecha_vigencia as 'Fecha de vigencia', estatus as 'Estatus' FROM socio WHERE id_socio =" & id_socio
        mostrar(consulta, datagrid)
    End Sub

    Public Sub buscar_socio_por_nombre(ByRef datagrid As DataGridView, ByRef nombre As String)
        Dim consulta As String = "SELECT socio.id_socio as 'Numero de socio', socio.sexo as 'Sexo', socio.telefono as 'Telefono', socio.correo_electronico as 'Correo Electronico', socio.calle as 'Calle', socio.numero_exterior as 'Numero exterior', socio.numero_interior as 'Numero interior', socio.colonia as 'Colonia', socio.ciudad as 'Ciudad', socio.pais as 'Pais', socio.fecha_expedicion as 'Fecha de expedicion', socio.fecha_vigencia as 'Fecha de vigencia', socio.estatus as 'Estatus' FROM socio,cliente WHERE cliente.id_cliente = socio.id_cliente and cliente.nombre  Like '%" & nombre & "%'"
        mostrar(consulta, datagrid)
    End Sub

    Public Function existe_socio(ByVal socio As ClassSocio)
        Dim consulta As String = "SELECT count(*) FROM socio where id_socio = " & socio.id
        If (existe(consulta) = True) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
