Imports System.Windows.Forms

Public Class FormMDI

    Dim usuario As New ClassUsuario
    Dim funcionesUsuario As New FuncionesUsuario

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles SubmenuCliente1.Click, NewToolStripButton.Click
        '' Cree una nueva instancia del formulario secundario.
        'Dim ChildForm As New System.Windows.Forms.Form
        '' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        'ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Ventana " & m_ChildFormNumber

        'ChildForm.Show()
        Dim formClientes As New FormClientes

        formClientes.MdiParent = Me
        'm_ChildFormNumber += 1
        'If m_ChildFormNumber = 1 Then
        formClientes.Show()
        'End If

    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripButton.Click
        ''''
        Dim formNuevaRenta As New FormNuevaRenta
        formNuevaRenta.MdiParent = Me
        formNuevaRenta.Show()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        Dim formDevoluciones As New FormDevoluciones
        formDevoluciones.MdiParent = Me
        formDevoluciones.Show()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub FormMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        'Me.WindowState = FormWindowState.Maximized
        'Me.TopMost = True
        ToolStripStatusLabel.Text = "Empleado: " + numero_de_empleado
        If funcionesUsuario.es_admin(numero_de_empleado) = False Then
            MantenimientoToolStripMenuItem.Visible = False 'Pestana mantenimiento
            RedoToolStripMenuItem.Visible = False 'Pestana rentas
            CorteDeCajaToolStripMenuItem.Visible = False 'Pestana corte de caja
            VentasToolStripMenuItem.Visible = False 'Pestana ventas
        End If
    End Sub

    Private Sub FormMDI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub BuscarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarClienteToolStripMenuItem.Click
        Dim formBuscarSocios As New FormBuscarSocios
        formBuscarSocios.MdiParent = Me
        formBuscarSocios.Show()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        Dim formNuevaRenta As New FormNuevaRenta
        formNuevaRenta.MdiParent = Me
        formNuevaRenta.Show()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        Dim formVerRentas As New FormVerRentas
        formVerRentas.MdiParent = Me
        formVerRentas.Show()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Dim formPeliculas As New FormPeliculas
        formPeliculas.MdiParent = Me
        formPeliculas.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim formUsuarios As New FormUsuarios
        formUsuarios.MdiParent = Me
        formUsuarios.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim formEmpleados As New FormEmpleados
        formEmpleados.MdiParent = Me
        formEmpleados.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim formAcercaDe As New FormAcercaDe
        formAcercaDe.MdiParent = Me
        formAcercaDe.Show()
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContentsToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Dim formNuevaVenta As New FormVentas
        formNuevaVenta.MdiParent = Me
        formNuevaVenta.Show()
    End Sub

    Private Sub PrintToolStripButton_Click(sender As Object, e As EventArgs) Handles PrintToolStripButton.Click
        Dim formDevoluciones As New FormDevoluciones
        formDevoluciones.MdiParent = Me
        formDevoluciones.Show()
    End Sub

    Private Sub MenuClientes_Click(sender As Object, e As EventArgs) Handles MenuClientes.Click

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim formAcercaDe As New FormAcercaDe
        formAcercaDe.MdiParent = Me
        formAcercaDe.Show()
    End Sub

    Private Sub AltasBajasYCambiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltasBajasYCambiosToolStripMenuItem.Click
        Dim formDistribuidores As New FormDistribuidores
        formDistribuidores.MdiParent = Me
        formDistribuidores.Show()
    End Sub

    Private Sub SociosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SociosToolStripMenuItem.Click
        If socio_seleccionado <> Nothing Or identificador_cliente <> Nothing Then
            Dim formSocios As New FormSocios
            formSocios.MdiParent = Me
            formSocios.Show()
        Else
            MsgBox("Debe seleccionar un cliente")
        End If

    End Sub

    Private Sub RealizarCorteDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealizarCorteDeCajaToolStripMenuItem.Click
        Dim formRealizarCorte As New FormCorteCaja
        formRealizarCorte.MdiParent = Me
        formRealizarCorte.Show()
    End Sub

    Private Sub VerBalanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerBalanceToolStripMenuItem.Click
        Dim formBalance As New FormVerBalance
        formBalance.MdiParent = Me
        formBalance.Show()
    End Sub

    Private Sub RealizarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealizarVentaToolStripMenuItem.Click
        Dim formNuevaVenta As New FormVentas
        formNuevaVenta.MdiParent = Me
        formNuevaVenta.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Dim formVerVentas As New FormVerVentas
        formVerVentas.MdiParent = Me
        formVerVentas.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'lbl_fecha.Text = String.Format("M/d/yy", DateTime.Now)
        Dim TestDateTime As Date = DateTime.Now
        lbl_fecha.Text = Format(TestDateTime, "dddd, MMM d yyyy")
        lbl_hora.Text = Format(TestDateTime, "hh:mm tt")
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        Dim formAdeudos As New FormAdeudos
        formAdeudos.MdiParent = Me
        formAdeudos.Show()
    End Sub
End Class
