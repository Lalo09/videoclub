Imports System.Data
Imports System.Data.SqlClient

'Modulo que contiene metodos para la conexion de la base de datos
Module ModuloConexion

    'Variables de conexion
    Public conn As New SqlConnection(My.Settings.Conexion)
    Public cmd As New SqlCommand
    Public dr As SqlDataReader

    'Funcion para conectarse a la base de datos
    Public Sub Conectar()
        Try
            conn.Open()
            'MsgBox("Conexion exitosa a la base de datos")
        Catch ex As Exception
            MsgBox("Error al conectarse " + ex.Message)
        End Try
    End Sub

    'Funcion para desconectarse de la base de datos
    Public Sub Desconectar()
        Try
            conn.Close()
            'MsgBox("Se ha desconectado de la base de datos)
        Catch ex As Exception
            MsgBox("Error al desconectarse " + ex.Message)
        End Try
    End Sub

    'Funcion para ejecutar un comando sql (insertar,actualizar,borrar)
    Public Sub ejecutar(ByRef sql As String)
        Try
            conn.Open()
            cmd.CommandText = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            'MsgBox("Transaccion exitosa")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    'Funcion para mostrar los datos en un formulario
    Public Sub mostrar(ByRef sql As String, ByRef datagridview As DataGridView)
        Try
            conn.Open()
            cmd.CommandText = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            datagridview.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    'Funcion para revisar si ya existe un registro en la base de datos
    Public Function existe(ByVal sql As String)
        Try
            conn.Open()
            cmd.CommandText = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = sql

            cmd.ExecuteNonQuery()
            Dim count As Integer = Convert.ToInt16(cmd.ExecuteScalar)
            If count = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Return False
    End Function

    'MEtodo para extraer informacion especifica de un elemento
    Public Function consultar_elemento(ByRef sql As String)
        cmd.CommandText = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = sql

        Try
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

End Module