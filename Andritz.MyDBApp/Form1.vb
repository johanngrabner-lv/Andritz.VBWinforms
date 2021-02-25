Imports System.Data.SqlClient

Public Class Form1
    Private Sub btnADO_Click(sender As Object, e As EventArgs) Handles btnADO.Click
        Dim conString As String
        conString = "server=.;initial catalog=dbAndritz2021;integrated security=true" ' aktuell angemeldeter Benutzer - Studen6
        Dim con As New SqlConnection(conString)
        con.Open()



    End Sub
End Class
