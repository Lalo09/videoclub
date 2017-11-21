Public Class ClassAdeudo

    Private _ID As Integer
    Private _IDRENTA As Integer
    Private _TOTALADEUDO As Double
    Private _ESTATUS As String

    Public Property id As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property id_renta As Integer
        Get
            Return _IDRENTA
        End Get
        Set(value As Integer)
            _IDRENTA = value
        End Set
    End Property

    Public Property total_adeudo As Double
        Get
            Return _TOTALADEUDO
        End Get
        Set(value As Double)
            _TOTALADEUDO = value
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
