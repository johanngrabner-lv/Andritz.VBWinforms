Imports System.Data.Common
Imports System.Data.SqlClient

Public Class Form1
    Private Sub btnADO_Click(sender As Object, e As EventArgs) Handles btnADO.Click
        Dim conString As String
        'Server=. Server=(local), Server=ms1020, Server=192.186.10.11
        '1433
        conString = "server=.;initial catalog=dbAndritz2021;integrated security=true" ' aktuell angemeldeter Benutzer - Studen6
        conString = My.Settings.andritzDB


        Dim con As DbConnection
        con = New SqlConnection(conString)
        Try
            con.Open()
            ' Anweisungen 
            'Statements abschicken

            Dim cmd As DbCommand = con.CreateCommand()
            cmd.CommandText = "INSERT INTO Maschienen VALUES('from ADO.NET', 0, 1)"

            Dim affectd As Integer = cmd.ExecuteNonQuery() 'insert, update, delete, create 

        Catch ex As Exception
            ' Anweisungen 
        Finally
            ' wenn offen, Verbindung schließen 
            con.Close()
            con.Dispose()
        End Try

        'temp-ressource-usage-pattern
        Using conNeu As DbConnection = New SqlConnection()
            Try
                conNeu.ConnectionString = "Data Source=(local);" &
                  "Initial Catalog=Northwind;Integrated Security=sspi"
                ' Arbeiten mit der Datenbank 
                conNeu.Open()
            Catch ex As Exception
                Console.WriteLine("Datenbankfehler: {0}", ex.Message)
            Finally
                If (conNeu.State And ConnectionState.Open) > 0 Then con.Close()
            End Try
        End Using 'automatisches Dispose--Close



    End Sub
End Class
