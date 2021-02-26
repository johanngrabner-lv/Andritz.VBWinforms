Public Class Maschine

    Private _Id As Integer
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property

    Private _Bezeichnung As String
    Public Property Bezeichnung() As String
        Get
            Return _Bezeichnung
        End Get
        Set(ByVal value As String)
            _Bezeichnung = value
        End Set
    End Property
End Class
