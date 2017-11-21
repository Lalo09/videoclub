Public Class ClassRenta

    Private _ID As Integer
    Private _IDEMPLEADO As Integer
    Private _IDSOCIO As Integer
    Private _FECHARENTA As String
    Private _FECHADEVOLUCION As String
    Private _TOTAL As Double

    Public Property id As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
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

    Public Property fecha_renta As String
        Get
            Return _FECHARENTA
        End Get
        Set(value As String)
            _FECHARENTA = value
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

    Public Property total As Double
        Get
            Return _TOTAL
        End Get
        Set(value As Double)
            _TOTAL = value
        End Set
    End Property
End Class
