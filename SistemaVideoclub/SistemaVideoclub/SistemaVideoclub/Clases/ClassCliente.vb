Public Class ClassCliente
    'Atributos
    Private _ID As Integer
    Private _NOMBRE As String
    Private _APELLIDO_PATERNO As String
    Private _APELLIDO_MATERNO As String

    'Metodos get y set
    Public Property id As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _NOMBRE
        End Get
        Set(value As String)
            _NOMBRE = value
        End Set
    End Property

    Public Property apellido_paterno As String
        Get
            Return _APELLIDO_PATERNO
        End Get
        Set(value As String)
            _APELLIDO_PATERNO = value
        End Set
    End Property

    Public Property apellido_materno As String
        Get
            Return _APELLIDO_MATERNO
        End Get
        Set(value As String)
            _APELLIDO_MATERNO = value
        End Set
    End Property
End Class
