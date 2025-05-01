Public Class ClasePersona

    Private cmpApellido As String
    Private cmpdireccion As String
    Private cmpCiudad As String
    Private cmpNombre As String

    Public Property Nombre As String
        Get
            Return cmpNombre
        End Get
        Set(value As String)
            cmpNombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return cmpApellido
        End Get
        Set(value As String)
            cmpApellido = value
        End Set
    End Property
End Class
