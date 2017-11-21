Public Class ClassVenta

    'Atributos
    Private _ID As Integer
    Private _IDEMPLEADO As Integer
    Private _IDCLIENTE As Integer
    Private _FECHA As String
    Private _TOTAL As Double
    Private _METODOPAGO As String

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

    Public Property id_cliente As Integer
        Get
            Return _IDCLIENTE
        End Get
        Set(value As Integer)
            _IDCLIENTE = value
        End Set
    End Property

    Public Property fecha As String
        Get
            Return _FECHA
        End Get
        Set(value As String)
            _FECHA = value
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

    Public Property metodo_pago As String
        Get
            Return _METODOPAGO
        End Get
        Set(value As String)
            _METODOPAGO = value
        End Set
    End Property
End Class
