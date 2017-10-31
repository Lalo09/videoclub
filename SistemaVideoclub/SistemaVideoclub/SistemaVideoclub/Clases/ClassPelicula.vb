Public Class ClassPelicula

    'Atributos
    Private _ID As Integer
    Private _IDDISTRIBUIDOR As Integer
    Private _NOMBRE As String
    Private _DURACION As String
    Private _GENERO As String
    Private _CLASIFICACION As String
    Private _PAISORIGEN As String
    Private _DIRECTOR As String
    Private _EXISTENCIA As Integer
    Private _SINOPSIS As String
    Private _FECHAADQUISICION As String
    Private _PRECIOVENTA As Double
    Private _PRECIORENTA As Double
    Private _PRECIOCOMPRA As Double
    Private _FOTO As String

    Public Property id As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property id_distribuidor As Integer
        Get
            Return _IDDISTRIBUIDOR
        End Get
        Set(value As Integer)
            _IDDISTRIBUIDOR = value
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

    Public Property duracion As String
        Get
            Return _DURACION
        End Get
        Set(value As String)
            _DURACION = value
        End Set
    End Property

    Public Property genero As String
        Get
            Return _GENERO
        End Get
        Set(value As String)
            _GENERO = value
        End Set
    End Property

    Public Property clasificacion As String
        Get
            Return _CLASIFICACION
        End Get
        Set(value As String)
            _CLASIFICACION = value
        End Set
    End Property

    Public Property pais_origen As String
        Get
            Return _PAISORIGEN
        End Get
        Set(value As String)
            _PAISORIGEN = value
        End Set
    End Property

    Public Property director As String
        Get
            Return _DIRECTOR
        End Get
        Set(value As String)
            _DIRECTOR = value
        End Set
    End Property

    Public Property cantidad_existencia As Integer
        Get
            Return _EXISTENCIA
        End Get
        Set(value As Integer)
            _EXISTENCIA = value
        End Set
    End Property

    Public Property sinopsis As String
        Get
            Return _SINOPSIS
        End Get
        Set(value As String)
            _SINOPSIS = value
        End Set
    End Property

    Public Property fecha_adquicision As String
        Get
            Return _FECHAADQUISICION
        End Get
        Set(value As String)
            _FECHAADQUISICION = value
        End Set
    End Property

    Public Property precio_venta As Double
        Get
            Return _PRECIOVENTA
        End Get
        Set(value As Double)
            _PRECIOVENTA = value
        End Set
    End Property

    Public Property precio_renta As Double
        Get
            Return _PRECIORENTA
        End Get
        Set(value As Double)
            _PRECIORENTA = value
        End Set
    End Property

    Public Property precio_compra As Double
        Get
            Return _PRECIOCOMPRA
        End Get
        Set(value As Double)
            _PRECIOCOMPRA = value
        End Set
    End Property

    Public Property foto_caratula As String
        Get
            Return _FOTO
        End Get
        Set(value As String)
            _FOTO = value
        End Set
    End Property

End Class