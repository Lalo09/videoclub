Public Class ClassDistribuidor

    'Atributos
    Private _ID As Integer
    Private _NOMBRE As String
    Private _PAIS As String
    Private _DIRECCION As String
    Private _CORREO As String
    Private _SITIOWEB As String
    Private _TELEFONO As String

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

    Public Property pais As String
        Get
            Return _PAIS
        End Get
        Set(value As String)
            _PAIS = value
        End Set
    End Property

    Public Property direccion As String
        Get
            Return _DIRECCION
        End Get
        Set(value As String)
            _DIRECCION = value
        End Set
    End Property

    Public Property correo As String
        Get
            Return _CORREO
        End Get
        Set(value As String)
            _CORREO = value
        End Set
    End Property

    Public Property sitioWeb As String
        Get
            Return _SITIOWEB
        End Get
        Set(value As String)
            _SITIOWEB = value
        End Set
    End Property

    Public Property telefono As String
        Get
            Return _TELEFONO
        End Get
        Set(value As String)
            _TELEFONO = value
        End Set
    End Property
End Class
