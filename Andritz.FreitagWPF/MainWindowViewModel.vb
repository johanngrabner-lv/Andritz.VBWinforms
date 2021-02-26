Imports System.Collections.ObjectModel
Imports Andritz.DTOsDataTransferObject
Imports Andritz.FreitagDBZugriff

Public Class MainWindowViewModel
    Private _Maschinen As ObservableCollection(Of Maschine)
    Public Property Maschinen() As ObservableCollection(Of Maschine)
        Get
            Return _Maschinen
        End Get
        Set(ByVal value As ObservableCollection(Of Maschine))
            _Maschinen = value
        End Set
    End Property

    Private _AusgewaehlteMaschine As Maschine
    Public Property AusgewaehlteMaschine() As Maschine
        Get
            Return _AusgewaehlteMaschine
        End Get
        Set(ByVal value As Maschine)
            _AusgewaehlteMaschine = value
        End Set
    End Property


    Public ReadOnly Property Anzahl() As Integer
        Get
            Return Maschinen.Count
        End Get
    End Property

    Sub Init()
        Maschinen = New ObservableCollection(Of Maschine)
        Dim colMaschinen As List(Of Maschine) = MyDBHelper.GetMaschinen
        For Each m As Maschine In colMaschinen
            Maschinen.Add(m)
        Next
        AusgewaehlteMaschine = colMaschinen(0)


    End Sub

    'GuiToModel    {Binding ... - CustomConvert
    'ModelToGui -- {Binding ...

    Sub Save()
        MyDBHelper.UpdateMaschine(AusgewaehlteMaschine.Id, AusgewaehlteMaschine.Bezeichnung, AusgewaehlteMaschine.UrspruenglicheBezeichnung)
    End Sub
End Class
