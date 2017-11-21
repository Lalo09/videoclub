Public Class ClassDevolucion

    Private _ID As Integer
    Private _IDPELICULA As Integer
    Private _IDEMPLEADO As Integer
    Private _IDSOCIO As Integer
    Private _FECHADEVOLUCION As String
    Private _ESTADOPELICULA As String

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

    Public Property id_empleado As Integer
        Get
            Return _IDEMPLEADO
        End Get
        Set(value As Integer)
            _IDEMPLEADO = value
        End Set
    End Property

    Public Property id_socio As Integer
        Get
            Return _IDSOCIO
        End Get
        Set(value As Integer)
            _IDSOCIO = value
        End Set
    End Property

    Public Property fecha_devolucion As String
        Get
            Return _FECHADEVOLUCION
        End Get
        Set(value As String)
            _FECHADEVOLUCION = value
        End Set
    End Property

    Public Property estado_pelicula As String
        Get
            Return _ESTADOPELICULA
        End Get
        Set(value As String)
            _ESTADOPELICULA = value
        End Set
    End Property
End Class
