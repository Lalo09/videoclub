Public Class ClassUsuario

    'Atributos
    Private _IDEMPLEADO As Integer
    Private _CONTRASENA As String
    Private _TIPOUSUARIO As String
    Private _ESTATUS As String

    Public Property id_empleado As Integer
        Get
            Return _IDEMPLEADO
        End Get
        Set(value As Integer)
            _IDEMPLEADO = value
        End Set
    End Property

    Public Property contrasena As String
        Get
            Return _CONTRASENA
        End Get
        Set(value As String)
            _CONTRASENA = value
        End Set
    End Property

    Public Property tipo_usuario As String
        Get
            Return _TIPOUSUARIO
        End Get
        Set(value As String)
            _TIPOUSUARIO = value
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
