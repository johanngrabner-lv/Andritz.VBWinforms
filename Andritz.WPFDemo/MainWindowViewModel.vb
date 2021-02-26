Imports System.Collections.ObjectModel

Public Class MainWindowViewModel

    Private _hintergrundFarbe As String
    Public Property Hintergrundfarbe() As String
        Get
            Return _hintergrundFarbe
        End Get
        Set(ByVal value As String)
            _hintergrundFarbe = value
        End Set
    End Property

    Private _anzahlMaschinen As Int16
    Public Property AnzahlMaschinen() As Int16
        Get
            Return _anzahlMaschinen
        End Get
        Set(ByVal value As Int16)
            _anzahlMaschinen = value
        End Set
    End Property

    Private _Logo As String
    Public Property Logo() As String
        Get
            Return _Logo
        End Get
        Set(ByVal value As String)
            _Logo = value
        End Set
    End Property

    Private _Maschinen As ObservableCollection(Of Maschine)
    Public Property Maschinen() As ObservableCollection(Of Maschine)
        Get
            Return _Maschinen
        End Get
        Set(ByVal value As ObservableCollection(Of Maschine))
            _Maschinen = value
        End Set
    End Property

End Class
