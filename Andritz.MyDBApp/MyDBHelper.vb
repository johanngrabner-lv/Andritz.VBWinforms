Imports System.Data.Common
Imports System.Data.SqlClient

Public Class MyDBHelper
    Public Shared Function UpdateMaschine(id As Integer, bezeichnung As String) As Integer
        Dim conString As String = My.Settings.andritzDB
        Dim con As DbConnection
        con = New SqlConnection(conString)
        con.Open()
        Dim cmd As SqlCommand = con.CreateCommand()
        'cmd.CommandText = "Update Maschienen SET Maschienenname=@m WHERE ID = @id"
        cmd.CommandText = "UpdateMachine"
        cmd.CommandType = CommandType.StoredProcedure


        'cmd.Parameters.Add(New SqlParameter("@Machinename", bezeichnung))
        cmd.Parameters.AddWithValue("@Machinename", bezeichnung)
        cmd.Parameters.Add(New SqlParameter("@id", id))
        cmd.Parameters.Add(New SqlParameter("@Preis", 250))
        cmd.Parameters.Add(New SqlParameter("@Archiviert", False))

        Dim affected As Integer = cmd.ExecuteNonQuery()
        Return affected
    End Function

    Public Shared Function GetMaschinen() As List(Of Maschine)
        Dim maschinenListe As New List(Of Maschine)
        Dim conString As String

        conString = My.Settings.andritzDB


        Dim con As SqlConnection
        con = New SqlConnection(conString)

        con.Open()

        Dim cmd As SqlCommand = con.CreateCommand()
        cmd.CommandText = "SELECT * FROM v_AlleMaschinen"


        Dim myReader As SqlDataReader = cmd.ExecuteReader()
        While (myReader.Read())
            Dim m As New Maschine()
            m.Id = myReader("Id")
            m.Bezeichnung = myReader("Maschienenname")
            maschinenListe.Add(m)
        End While
        myReader.Close()
        Return maschinenListe
    End Function

End Class
