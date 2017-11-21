Public Class ClassEmpleado

    'Atributos
    Private _IDEMPLEADO As Integer
    Private _NOMBRE As String
    Private _APELLIDOPAT As String
    Private _APELLIDOMAT As String
    Private _SEXO As Char
    Private _TELEFONO As String
    Private _CORREO As String
    Private _CALLE As String
    Private _NUMEXT As String
    Private _NUMINT As String
    Private _COLONIA As String
    Private _CIUDAD As String
    Private _PAIS As String
    Private _FOTOGRAFIA As String
    Private _SUELDO As Double
    Private _FECHANAC As String

    'Metodos get y set
    Public Property id As Integer
        Get
            Return _IDEMPLEADO
        End Get
        Set(value As Integer)
            _IDEMPLEADO = value
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
            Return _APELLIDOPAT
        End Get
        Set(value As String)
            _APELLIDOPAT = value
        End Set
    End Property

    Public Property apellido_materno As String
        Get
            Return _APELLIDOMAT
        End Get
        Set(value As String)
            _APELLIDOMAT = value
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

    Public Property correo_electronico As String
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

    Public Property numero_exterior As String
        Get
            Return _NUMEXT
        End Get
        Set(value As String)
            _NUMEXT = value
        End Set
    End Property

    Public Property numero_interior As String
        Get
            Return _NUMINT
        End Get
        Set(value As String)
            _NUMINT = value
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

    Public Property sueldo As Double
        Get
            Return _SUELDO
        End Get
        Set(value As Double)
            _SUELDO = value
        End Set
    End Property

    Public Property fecha_nacimiento As String
        Get
            Return _FECHANAC
        End Get
        Set(value As String)
            _FECHANAC = value
        End Set
    End Property


End Class