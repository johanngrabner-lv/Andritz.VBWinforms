﻿Imports System.Net
Imports System.Web.Http

Public Class PersonController
    Inherits ApiController

    ' GET api/<controller>
    Public Function GetValues() As IEnumerable(Of Person)

        Dim p As New List(Of Person)
        Dim p1 As New Person
        p1.vorname = "Helmut"
        p1.setNachname("Gruber")
        p.Add(p1)
        Return p
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As Integer) As String
        Return "value"
    End Function

    ' POST api/<controller>
    Public Sub PostValue(<FromBody()> ByVal value As String)

    End Sub

    ' PUT api/<controller>/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
