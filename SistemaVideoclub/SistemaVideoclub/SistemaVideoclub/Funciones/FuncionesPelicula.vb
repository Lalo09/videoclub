Public Class FuncionesPelicula

    Public Sub insertar_pelicula(ByVal pelicula As ClassPelicula)
        Dim consulta As String = "INSERT INTO pelicula (id_distribuidor,nombre,duracion,genero,clasificacion,pais_origen,director,cantidad_en_existencia,sinopsis,fecha,adquicision,precio_venta,precio_renta,precio_compra,foto_caratula) VALUES ( " & pelicula.id_distribuidor & ",'" & pelicula.nombre & "','" & pelicula.duracion & "','" & pelicula.genero & "','" & pelicula.clasificacion & "','" & pelicula.pais_origen & "','" & pelicula.director & "'," & pelicula.cantidad_existencia & ",'" & pelicula.sinopsis & "','" & pelicula.fecha_adquicision & "'," & pelicula.precio_venta & "," & pelicula.precio_renta & "," & pelicula.precio_compra & ",'" & pelicula.foto_caratula & "')"
        ejecutar(consulta)
    End Sub

    Public Sub actualizar_pelicula(ByVal pelicula As ClassPelicula)
        Dim consulta As String = "UPDATE pelicula SET id_distribuidor = " & pelicula.id_distribuidor & ", nombre = '" & pelicula.nombre & "', duracion ='" & pelicula.duracion & "',genero='" & pelicula.genero & "',clasificacion='" & pelicula.clasificacion & "',pais_origen='" & pelicula.pais_origen & "',director='" & pelicula.director & "', cantidad_en_existencia = " & pelicula.cantidad_existencia & ", sinposis = '" & pelicula.sinopsis & "', fecha_adquicision = '" & pelicula.fecha_adquicision & "', precio_venta = " & pelicula.precio_venta & ", precio_renta = " & pelicula.precio_renta & ", precio_compra = " & pelicula.precio_compra & ", foto_caratula = '" & pelicula.foto_caratula & "' WHERE id_pelicula = " & pelicula.id
        ejecutar(consulta)
    End Sub

    Public Sub eliminar_pelicula(ByVal pelicula As ClassPelicula)
        Dim consulta As String = "DELETE FROM pelicula WHERE id_pelicula = " & pelicula.id
        ejecutar(consulta)
    End Sub

    Public Sub mostrar_pelicula(ByRef datagrid As DataGridView)
        Dim consulta As String = "SELECT id_pelicula as 'Numero de pelicula', id_distribuidor as 'Numero de distribuidor', nombre as 'Nombre', duracion as 'Duracion', genero as 'Genero', clasificacion as 'Clasificacion', pais_origen as 'Pais', director as 'Director', cantidad_en_existencia as 'Cantidad en stock', sinopsis as 'Sinopsis', fecha_adquicision as 'Fecha de adquicision', precio_venta as 'Precio de venta', precio_renta as 'Precio renta', precio_compra as 'Precio compra', foto_caratula as 'Portada' FROM pelicula"
        mostrar(consulta, datagrid)
    End Sub

    Public Sub buscar_pelicula(ByRef datagrid As DataGridView, ByRef nombre As String)
        Dim consulta As String = "SELECT id_pelicula as 'Numero de pelicula', id_distribuidor as 'Numero de distribuidor', nombre as 'Nombre', duracion as 'Duracion', genero as 'Genero', clasificacion as 'Clasificacion', pais_origen as 'Pais', director as 'Director', cantidad_en_existencia as 'Cantidad en stock', sinopsis as 'Sinopsis', fecha_adquicision as 'Fecha de adquicision', precio_venta as 'Precio de venta', precio_renta as 'Precio renta', precio_compra as 'Precio compra', foto_caratula as 'Portada' FROM pelicula WHERE nombre Like '%" & nombre & "%'"
        mostrar(consulta, datagrid)
    End Sub

    Public Function existe_pelicula(ByVal pelicula As ClassPelicula)
        Dim consulta As String = "SELECT count(*) FROM pelicula WHERE id_pelicula=" & pelicula.id
        If (existe(consulta) = True) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function getId_distribuidor(ByRef nombre As String)

        Try
            Conectar()
            Dim consulta As String = "SELECT id_distribuidor FROM distribuidor WHERE nombre = '" & nombre & "'"
            consultar_elemento(consulta)
            If dr.Read Then
                Return dr(0).ToString
                dr.Close()
            End If
        Catch ex As Exception

        Finally
            Desconectar()
        End Try

    End Function

    Public Function getNombre_distribuidor(ByRef id As Integer)

        Try
            Conectar()
            Dim consulta As String = "SELECT nombre FROM distribuidor WHERE id_distribuidor = '" & id & "'"
            consultar_elemento(consulta)
            If dr.Read Then
                Return dr(0).ToString
                dr.Close()
            End If
        Catch ex As Exception

        Finally
            Desconectar()
        End Try

    End Function

    'Metodo para llenar un combobox de datos
    Public Function llenarCombo(ByVal combobox As ComboBox)
        combobox.Items.Clear()
        cmd.CommandText = CommandType.Text
        cmd.Connection = conn

        cmd.CommandText = "SELECT nombre FROM distribuidor"

        dr = cmd.ExecuteReader

        If dr.HasRows = True Then
            'Meter informacion al combobox
            While dr.Read()
                combobox.Items.Add(dr.GetValue(0))
            End While
        End If
        dr.Close()
    End Function
End Class
