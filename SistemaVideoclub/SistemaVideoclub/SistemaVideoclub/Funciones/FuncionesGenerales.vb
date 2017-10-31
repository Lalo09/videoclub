Module FuncionesGenerales
    'Fucion para limpiar un formulario completo
    Public Function Limpiar(ByVal ParamArray componente() As Object)
        Dim x As Integer = 0
        For x = 0 To componente.Length() - 1
            componente(x).Text = ""
        Next
    End Function
End Module
