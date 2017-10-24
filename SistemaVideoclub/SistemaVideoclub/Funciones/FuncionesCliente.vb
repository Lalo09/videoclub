'Clase con metodos para realizar operaciones con la base de datos con sentencias SQL:
'insertar, actualizar, borrar clientes
Public Class FuncionesCliente

    'Metodo para insertar un cliente a la base de datos
    Public Sub insertar_cliente(ByVal cliente As ClassCliente)
        Dim consulta As String = "INSERT INTO cliente (nombre,apellido_paterno,apellido_materno) Values ('" & cliente.nombre & "','" & cliente.apellido_paterno & "','" & cliente.apellido_materno & "')"
        ejecutar(consulta)
    End Sub

    'Metodo para Actualizar un cliente a la base de datos
    Public Sub actualizar_cliente(ByVal cliente As ClassCliente)
        Dim consulta As String = "UPDATE cliente SET nombre='" & cliente.nombre & "',apellido_paterno='" & cliente.apellido_paterno & "',apellido_materno='" & cliente.apellido_materno & "' WHERE id_cliente = " & cliente.id
        ejecutar(consulta)
    End Sub

    'Metodo para Eliminar un cliente a la base de datos
    Public Sub eliminar_cliente(ByVal cliente As ClassCliente)
        Dim consulta As String = "DELETE FROM cliente WHERE id_cliente = " & cliente.id
        ejecutar(consulta)
    End Sub

    'Metodo para consultar datos y mostrarlos en un data grid view
    Public Sub mostrar_clientes(ByRef datagrid As DataGridView)
        Dim consulta As String = "SELECT id_cliente as 'Numero de cliente',nombre as 'Nombre',apellido_paterno as 'Apellido paterno',apellido_materno as 'Apellido matenrno' FROM cliente"
        mostrar(consulta, datagrid)
    End Sub

    'Metodo buscar clientes y mostrarlos en un data grid view
    Public Sub buscar_clientes(ByRef datagrid As DataGridView, ByRef nombre As String)
        Dim consulta As String = "SELECT id_cliente as 'Numero de cliente',nombre as 'Nombre',apellido_paterno as 'Apellido paterno',apellido_materno as 'Apellido matenrno' FROM cliente WHERE nombre Like '%" & nombre & "%'"
        mostrar(consulta, datagrid)
    End Sub

    'Metodo para consultar si existe un cliente
    Public Function existe_cliente(ByVal cliente As ClassCliente)
        Dim consulta As String = "SELECT count(*) FROM cliente WHERE id_cliente=" & cliente.id
        If (existe(consulta) = True) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
