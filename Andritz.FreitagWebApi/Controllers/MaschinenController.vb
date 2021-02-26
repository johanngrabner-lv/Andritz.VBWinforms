Imports System.Net
Imports System.Web.Http
Imports Andritz.DTOsDataTransferObject
Imports Andritz.FreitagDBZugriff

Public Class MaschinenController
    Inherits ApiController

    ' GET api/values
    Public Function GetValues() As IEnumerable(Of Maschine)
        Return MyDBHelper.GetMaschinen()
    End Function

    ' GET api/values/5
    Public Function GetValue(ByVal id As Integer) As Maschine
        Return MyDBHelper.GetMaschine(id)
    End Function

    ' POST api/values
    Public Sub PostValue(<FromBody()> ByVal newMachine As Maschine)
        MyDBHelper.InsertMaschine(newMachine)
    End Sub

    ' PUT api/values/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/values/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
