<<<<<<< HEAD
﻿Public Class FormEmpleados

    Dim empleado As New ClassEmpleado
    Dim funcionesEmpleado As New FuncionesEmpleado
    Dim sexo As Char
    Dim ruta_foto2 As String


    Private Sub btn_cargar_foto_Click(sender As Object, e As EventArgs) Handles btn_cargar_foto.Click
        If Open_F2.ShowDialog = DialogResult.OK Then
            ruta_foto2 = Open_F2.FileName
        End If

        pb_foto_empleado.ImageLocation = ruta_foto2
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If lblEmpleado.Text <> Nothing Then
            empleado.id = lblEmpleado.Text
        Else
            empleado.id = -1
        End If

        If funcionesEmpleado.existe_empleado(empleado) Then
            If txt_nombre.Text <> Nothing And txt_ap_paterno.Text <> Nothing And txt_ap_materno.Text <> Nothing And txt_telefono.Text <> Nothing And txt_email.Text <> Nothing And txt_calle.Text <> Nothing And txt_num_ext.Text <> Nothing And txt_colonia.Text <> Nothing And txt_ciudad.Text <> Nothing And txt_pais.Text <> Nothing And pb_foto_empleado.ImageLocation <> Nothing And txtSueldo.Text <> Nothing Then
                empleado.nombre = txt_nombre.Text
                empleado.apellido_paterno = txt_ap_paterno.Text
                empleado.apellido_materno = txt_ap_materno.Text
                empleado.sexo = Data_fav()
                empleado.telefono = txt_telefono.Text
                empleado.correo_electronico = txt_email.Text
                empleado.calle = txt_calle.Text
                empleado.numero_exterior = txt_num_ext.Text
                empleado.numero_interior = txt_numInt.Text
                empleado.colonia = txt_colonia.Text
                empleado.ciudad = txt_ciudad.Text
                empleado.pais = txt_pais.Text
                empleado.fotografia = ruta_foto2
                empleado.sueldo = txtSueldo.Text
                empleado.fecha_nacimiento = DateTimePicker1.Value.Date.ToString("MM/dd/yyyy")


                Try
                    funcionesEmpleado.actualizar_empleado(empleado)
                    MsgBox("Empleado actualizado correctamente")
                    funcionesEmpleado.mostrar_empleados(dg_empleado)

                Catch ex As Exception
                    MsgBox("Inserte datos completos del empleado " + ex.Message)
                End Try

                Limpiar(txt_nombre, txt_ap_materno, txt_ap_paterno, txt_telefono, txt_email, txt_calle, txt_ciudad, txt_colonia, txt_pais, txt_num_ext, txt_numInt, txtSueldo, lblEmpleado)
                pb_foto_empleado.ImageLocation = Nothing
                limpiarCheckbox()
            Else
                MsgBox("Faltan datos por insertar!")
            End If
        Else


            If txt_nombre.Text <> Nothing And txt_ap_paterno.Text <> Nothing And txt_ap_materno.Text <> Nothing And txt_telefono.Text <> Nothing And txt_email.Text <> Nothing And txt_calle.Text <> Nothing And txt_num_ext.Text <> Nothing And txt_colonia.Text <> Nothing And txt_ciudad.Text <> Nothing And txt_pais.Text <> Nothing And pb_foto_empleado.ImageLocation <> Nothing And txtSueldo.Text <> Nothing Then

                empleado.nombre = txt_nombre.Text
                empleado.apellido_paterno = txt_ap_paterno.Text
                empleado.apellido_materno = txt_ap_materno.Text
                empleado.sexo = Data_fav()
                empleado.telefono = txt_telefono.Text
                empleado.correo_electronico = txt_email.Text
                empleado.calle = txt_calle.Text
                empleado.numero_exterior = txt_num_ext.Text
                empleado.numero_interior = txt_numInt.Text
                empleado.colonia = txt_colonia.Text
                empleado.ciudad = txt_ciudad.Text
                empleado.pais = txt_pais.Text
                empleado.fotografia = ruta_foto2
                empleado.sueldo = txtSueldo.Text
                empleado.fecha_nacimiento = DateTimePicker1.Value.Date.ToString("MM/dd/yyyy")

                Try
                    funcionesEmpleado.insertar_empleado(empleado)
                    MsgBox("Empleado insertado correctamente")
                    funcionesEmpleado.mostrar_empleados(dg_empleado)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Limpiar(txt_nombre, txt_ap_materno, txt_ap_paterno, txt_telefono, txt_email, txt_calle, txt_ciudad, txt_colonia, txt_pais, txt_num_ext, txt_numInt, txtSueldo, lblEmpleado)
                pb_foto_empleado.ImageLocation = Nothing
                limpiarCheckbox()
            Else
                MsgBox("Inserte datos completos del empleado!")
            End If
        End If
    End Sub

    Public Function Data_fav() As String
        If rb_femenino.Checked Then
            sexo = "F"
        ElseIf rb_masculino.Checked Then
            sexo = "M"
        End If

        Return sexo

    End Function

    Private Sub FormEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            funcionesEmpleado.mostrar_empleados(dg_empleado)
        Catch ex As Exception
            MsgBox("No se han podido cargar los datos: " + ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_foto_Click(sender As Object, e As EventArgs) Handles btn_eliminar_foto.Click
        pb_foto_empleado.ImageLocation = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If lblEmpleado.Text >= 1 Then
                empleado.id = lblEmpleado.Text

                funcionesEmpleado.eliminar_empleado(empleado.id)
                funcionesEmpleado.mostrar_empleados(dg_empleado)
                MsgBox("Empleado eliminado correctamente")
                Limpiar(txt_nombre, txt_ap_materno, txt_ap_paterno, txt_telefono, txt_email, txt_calle, txt_ciudad, txt_colonia, txt_pais, txt_num_ext, txt_numInt, txtSueldo, lblEmpleado)
                pb_foto_empleado.ImageLocation = Nothing
                limpiarCheckbox()
            Else
                MsgBox("Seleccione un empleado para eliminar")
            End If
        Catch ex As Exception
            MsgBox("Seleccione un empleado para eliminar")
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar(txt_nombre, txt_ap_materno, txt_ap_paterno, txt_telefono, txt_email, txt_calle, txt_ciudad, txt_colonia, txt_pais, txt_num_ext, txt_numInt, txtSueldo, lblEmpleado)
        pb_foto_empleado.ImageLocation = Nothing
        limpiarCheckbox()
    End Sub

    Private Sub btnBuscarEmp_Click(sender As Object, e As EventArgs) Handles btnBuscarEmp.Click
        Dim empleado_a_buscar As String = Txt_buscar_empleado.Text
        funcionesEmpleado.buscar_empleado(dg_empleado, empleado_a_buscar)
    End Sub

    Private Sub gb_datos_del_cliente_Enter(sender As Object, e As EventArgs) Handles gb_datos_del_cliente.Enter

    End Sub

    Private Sub dg_empleado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_empleado.CellClick
        Dim i As Integer
        i = dg_empleado.CurrentRow.Index
        lblEmpleado.Text = dg_empleado.Item(0, i).Value
        txt_nombre.Text = dg_empleado.Item(1, i).Value
        txt_ap_paterno.Text = dg_empleado.Item(2, i).Value
        txt_ap_materno.Text = dg_empleado.Item(3, i).Value
        'Data_fav.radio = dg_empleado.Item(4, i).Value
        txt_telefono.Text = dg_empleado.Item(5, i).Value
        txt_email.Text = dg_empleado.Item(6, i).Value
        txt_calle.Text = dg_empleado.Item(7, i).Value
        txt_num_ext.Text = dg_empleado.Item(8, i).Value
        txt_numInt.Text = dg_empleado.Item(9, i).Value
        txt_colonia.Text = dg_empleado.Item(10, i).Value
        txt_ciudad.Text = dg_empleado.Item(11, i).Value
        txt_pais.Text = dg_empleado.Item(12, i).Value
        pb_foto_empleado.ImageLocation = dg_empleado.Item(13, i).Value
        txtSueldo.Text = dg_empleado.Item(14, i).Value
        DateTimePicker1.Value = dg_empleado.Item(15, i).Value
        If dg_empleado.Item(4, i).Value = "F" Then
            rb_femenino.Checked = True
        ElseIf dg_empleado.Item(4, i).Value = "M" Then
            rb_masculino.Checked = True
        End If
        ruta_foto2 = dg_empleado.Item(13, i).Value

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            funcionesEmpleado.mostrar_empleados(dg_empleado)
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub limpiarCheckbox()
        rb_femenino.Checked = False
        rb_masculino.Checked = False
    End Sub
=======
﻿Public Class FormEmpleados

    Dim empleado As New ClassEmpleado
    Dim funcionesEmpleado As New FuncionesEmpleado
    Dim sexo As Char
    Dim ruta_foto2 As String


    Private Sub btn_cargar_foto_Click(sender As Object, e As EventArgs) Handles btn_cargar_foto.Click
        If Open_F2.ShowDialog = DialogResult.OK Then
            ruta_foto2 = Open_F2.FileName
        End If

        pb_foto_empleado.ImageLocation = ruta_foto2
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If lblEmpleado.Text <> Nothing Then
            empleado.id = lblEmpleado.Text
        Else
            empleado.id = -1
        End If

        If funcionesEmpleado.existe_empleado(empleado) Then
            If txt_nombre.Text <> Nothing And txt_ap_paterno.Text <> Nothing And txt_ap_materno.Text <> Nothing And txt_telefono.Text <> Nothing And txt_email.Text <> Nothing And txt_calle.Text <> Nothing And txt_numInt.Text <> Nothing And txt_num_ext.Text <> Nothing And txt_colonia.Text <> Nothing And txt_ciudad.Text <> Nothing And txt_pais.Text <> Nothing And pb_foto_empleado.ImageLocation <> Nothing And txtSueldo.Text <> Nothing Then
                empleado.nombre = txt_nombre.Text
                empleado.apellido_paterno = txt_ap_paterno.Text
                empleado.apellido_materno = txt_ap_materno.Text
                empleado.sexo = Data_fav()
                empleado.telefono = txt_telefono.Text
                empleado.correo_electronico = txt_email.Text
                empleado.calle = txt_calle.Text
                empleado.numero_exterior = txt_num_ext.Text
                empleado.numero_interior = txt_numInt.Text
                empleado.colonia = txt_colonia.Text
                empleado.ciudad = txt_ciudad.Text
                empleado.pais = txt_pais.Text
                empleado.fotografia = ruta_foto2
                empleado.sueldo = txtSueldo.Text
                empleado.fecha_nacimiento = DateTimePicker1.Value.Date.ToString("MM/dd/yyyy")


                Try
                    funcionesEmpleado.actualizar_empleado(empleado)
                    MsgBox("Empleado actualizado correctamente")
                    funcionesEmpleado.mostrar_empleados(dg_empleado)

                Catch ex As Exception
                    MsgBox("Inserte datos completos del empleado " + ex.Message)
                End Try

                Limpiar(txt_nombre, txt_ap_materno, txt_ap_paterno, txt_telefono, txt_email, txt_calle, txt_ciudad, txt_colonia, txt_pais, txt_num_ext, txt_numInt, txtSueldo, lblEmpleado)
            Else
                MsgBox("Faltan datos por insertar!")
            End If
        Else


            If txt_nombre.Text <> Nothing And txt_ap_paterno.Text <> Nothing And txt_ap_materno.Text <> Nothing And txt_telefono.Text <> Nothing And txt_email.Text <> Nothing And txt_calle.Text <> Nothing And txt_numInt.Text <> Nothing And txt_num_ext.Text <> Nothing And txt_colonia.Text <> Nothing And txt_ciudad.Text <> Nothing And txt_pais.Text <> Nothing And pb_foto_empleado.ImageLocation <> Nothing And txtSueldo.Text <> Nothing Then

                empleado.nombre = txt_nombre.Text
                empleado.apellido_paterno = txt_ap_paterno.Text
                empleado.apellido_materno = txt_ap_materno.Text
                empleado.sexo = Data_fav()
                empleado.telefono = txt_telefono.Text
                empleado.correo_electronico = txt_email.Text
                empleado.calle = txt_calle.Text
                empleado.numero_exterior = txt_num_ext.Text
                empleado.numero_interior = txt_numInt.Text
                empleado.colonia = txt_colonia.Text
                empleado.ciudad = txt_ciudad.Text
                empleado.pais = txt_pais.Text
                empleado.fotografia = ruta_foto2
                empleado.sueldo = txtSueldo.Text
                empleado.fecha_nacimiento = DateTimePicker1.Value.Date.ToString("MM/dd/yyyy")

                Try
                    funcionesEmpleado.insertar_empleado(empleado)
                    MsgBox("Empleado insertado correctamente")
                    funcionesEmpleado.mostrar_empleados(dg_empleado)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Limpiar(txt_nombre, txt_ap_materno, txt_ap_paterno, txt_telefono, txt_email, txt_calle, txt_ciudad, txt_colonia, txt_pais, txt_num_ext, txt_numInt, txtSueldo, lblEmpleado)
            Else
                MsgBox("Inserte datos completos del empleado!")
            End If
        End If
    End Sub

    Public Function Data_fav() As String
        If rb_femenino.Checked Then
            sexo = "F"
        ElseIf rb_masculino.Checked Then
            sexo = "M"
        End If

        Return sexo

    End Function

    Private Sub FormEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            funcionesEmpleado.mostrar_empleados(dg_empleado)
        Catch ex As Exception
            MsgBox("No se han podido cargar los datos: " + ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_foto_Click(sender As Object, e As EventArgs) Handles btn_eliminar_foto.Click
        pb_foto_empleado.ImageLocation = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If lblEmpleado.Text >= 1 Then
                empleado.id = lblEmpleado.Text

                funcionesEmpleado.eliminar_empleado(empleado.id)
                funcionesEmpleado.mostrar_empleados(dg_empleado)
                MsgBox("Empleado eliminado correctamente")
                Limpiar(txt_nombre, txt_ap_materno, txt_ap_paterno, txt_telefono, txt_email, txt_calle, txt_ciudad, txt_colonia, txt_pais, txt_num_ext, txt_numInt, txtSueldo, lblEmpleado)
            Else
                MsgBox("Seleccione un empleado para eliminar")
            End If
        Catch ex As Exception
            MsgBox("Seleccione un empleado para eliminar")
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar(txt_nombre, txt_ap_materno, txt_ap_paterno, txt_telefono, txt_email, txt_calle, txt_ciudad, txt_colonia, txt_pais, txt_num_ext, txt_numInt, txtSueldo, lblEmpleado)
    End Sub

    Private Sub btnBuscarEmp_Click(sender As Object, e As EventArgs) Handles btnBuscarEmp.Click
        Dim empleado_a_buscar As String = Txt_buscar_empleado.Text
        funcionesEmpleado.buscar_empleado(dg_empleado, empleado_a_buscar)
    End Sub

    Private Sub gb_datos_del_cliente_Enter(sender As Object, e As EventArgs) Handles gb_datos_del_cliente.Enter

    End Sub

    Private Sub dg_empleado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_empleado.CellClick
        Dim i As Integer
        i = dg_empleado.CurrentRow.Index
        lblEmpleado.Text = dg_empleado.Item(0, i).Value
        txt_nombre.Text = dg_empleado.Item(1, i).Value
        txt_ap_paterno = dg_empleado.Item(2, i).Value
        txt_ap_materno = dg_empleado.Item(3, i).Value
        'Data_fav.radio = dg_empleado.Item(4, i).Value
        txt_telefono = dg_empleado.Item(5, i).Value
        txt_email = dg_empleado.Item(6, i).Value
        txt_calle = dg_empleado.Item(7, i).Value
        txt_num_ext = dg_empleado.Item(8, i).Value
        txt_numInt = dg_empleado.Item(9, i).Value
        txt_colonia = dg_empleado.Item(10, i).Value
        txt_ciudad = dg_empleado.Item(11, i).Value
        txt_pais = dg_empleado.Item(12, i).Value
        ruta_foto2 = dg_empleado.Item(13, i).Value
        txtSueldo = dg_empleado.Item(14, i).Value
        DateTimePicker1 = dg_empleado.Item(15, i).Value
    End Sub
>>>>>>> 87bdf6dce42926ef8be23b415285e936c9a62b4d
End Class