Public Class ArchivoTexto
    Private _nombre As String
    Private _apellido As String
    Private _cedula As String
    Private _fechaNacimiento As String
    Private _nacionalidad As String
    Private _provinciaCanton As String
    Private _correo As String
    Private _coberturaSeguro As String
    Private _fechaInicioSeguro As String
    Private _mensualidad As String

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property Cedula As String
        Get
            Return _cedula
        End Get
        Set(value As String)
            _cedula = value
        End Set
    End Property

    Public Property FechaNacimiento As String
        Get
            Return _fechaNacimiento
        End Get
        Set(value As String)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property Nacionalidad As String
        Get
            Return _nacionalidad
        End Get
        Set(value As String)
            _nacionalidad = value
        End Set
    End Property

    Public Property ProvinciaCanton As String
        Get
            Return _provinciaCanton
        End Get
        Set(value As String)
            _provinciaCanton = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property CoberturaSeguro As String
        Get
            Return _coberturaSeguro
        End Get
        Set(value As String)
            _coberturaSeguro = value
        End Set
    End Property

    Public Property FechaInicioSeguro As String
        Get
            Return _fechaInicioSeguro
        End Get
        Set(value As String)
            _fechaInicioSeguro = value
        End Set
    End Property

    Public Property Mensualidad As String
        Get
            Return _mensualidad
        End Get
        Set(value As String)
            _mensualidad = value
        End Set
    End Property
End Class
