Public Class ClassDetalleVenta
    'Atributos
    Private _ID As Integer
    Private _IDPELICULA As Integer
    Private _IDVENTA As Integer
    Private _CANTIDAD As Integer
    Private _TOTAL As Double

    Public Property id As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property id_pelicula As Integer
        Get
            Return _IDPELICULA
        End Get
        Set(value As Integer)
            _IDPELICULA = value
        End Set
    End Property

    Public Property id_venta As Integer
        Get
            Return _IDVENTA
        End Get
        Set(value As Integer)
            _IDVENTA = value
        End Set
    End Property

    Public Property cantidad As Integer
        Get
            Return _CANTIDAD
        End Get
        Set(value As Integer)
            _CANTIDAD = value
        End Set
    End Property

    Public Property total As Double
        Get
            Return _TOTAL
        End Get
        Set(value As Double)
            _TOTAL = value
        End Set
    End Property



End Class
