Public Class ClassCorteCaja

    Private _ID As Integer
    Private _FECHA As String
    Private _BALANCE As Double

    Public Property id As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
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

    Public Property balance As Double
        Get
            Return _BALANCE
        End Get
        Set(value As Double)
            _BALANCE = value
        End Set
    End Property

End Class
