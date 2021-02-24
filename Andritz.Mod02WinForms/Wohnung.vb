Public Class Wohnung
    Private flaeche As Double
    Private preis As Single
    Private zimmeranzahl As Integer
    Public Sub New(flaeche As Double, preis As Single, anzahl As Integer)
        Me.flaeche = flaeche
        Me.preis = preis
        zimmeranzahl = anzahl
    End Sub

    Public ReadOnly Property Wohnflaeche() As Double
        Get
            Return flaeche
        End Get
    End Property

    Public ReadOnly Property Miete() As Single
        Get
            Return preis
        End Get
    End Property

    Public ReadOnly Property Bezeichnung() As String
        Get
            Return zimmeranzahl.ToString() & "-Zimmer-Wohnung"
        End Get
    End Property
End Class
