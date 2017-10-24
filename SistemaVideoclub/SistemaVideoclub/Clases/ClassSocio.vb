Public Class ClassSocio

    'Atributos
    Private _ID As Integer
    Private _IDCLIENTE As Integer
    Private _SEXO As Char
    Private _TELEFONO As String
    Private _CORREO As String
    Private _CALLE As String
    Private _NUMINT As String
    Private _NUMEXT As String
    Private _COLONIA As String
    Private _CIUDAD As String
    Private _PAIS As String
    Private _FOTOGRAFIA As String
    Private _FECHAEXP As Date
    Private _FECHAVIG As Date
    Private _ESTATUS As String

    'Metodos get y set
    Public Property id As Integer
        Get
            Return _IDCLIENTE
        End Get
        Set(value As Integer)
            _IDCLIENTE = value
        End Set
    End Property

    Public Property id_cliente As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property sexo As Char
        Get
            Return _SEXO
        End Get
        Set(value As Char)
            _SEXO = value
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

    Public Property correo As String
        Get
            Return _CORREO
        End Get
        Set(value As String)
            _CORREO = value
        End Set
    End Property

    Public Property calle As String
        Get
            Return _CALLE
        End Get
        Set(value As String)
            _CALLE = value
        End Set
    End Property

    Public Property numeroInt As String
        Get
            Return _NUMINT
        End Get
        Set(value As String)
            _NUMINT = value
        End Set
    End Property

    Public Property numeroExt As String
        Get
            Return _NUMEXT
        End Get
        Set(value As String)
            _NUMEXT = value
        End Set
    End Property

    Public Property colonia As String
        Get
            Return _COLONIA
        End Get
        Set(value As String)
            _COLONIA = value
        End Set
    End Property

    Public Property ciudad As String
        Get
            Return _CIUDAD
        End Get
        Set(value As String)
            _CIUDAD = value
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

    Public Property fotografia As String
        Get
            Return _FOTOGRAFIA
        End Get
        Set(value As String)
            _FOTOGRAFIA = value
        End Set
    End Property

    Public Property fechaExp As Date
        Get
            Return _FECHAEXP
        End Get
        Set(value As Date)
            _FECHAEXP = value
        End Set
    End Property

    Public Property fechaVig As Date
        Get
            Return _FECHAVIG
        End Get
        Set(value As Date)
            _FECHAVIG = value
        End Set
    End Property

    Public Property estatus As String
        Get
            Return _ESTATUS
        End Get
        Set(value As String)
            _ESTATUS = value
        End Set
    End Property


End Class
