Public Class Maschine
    Private _Id As Int32
    Public Property Id() As Int32
        Get
            Return _Id
        End Get
        Set(ByVal value As Int32)
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
