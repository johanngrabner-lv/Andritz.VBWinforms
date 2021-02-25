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
            cmd.CommandText = "INSERT INTO Maschienen VALUES('from ADO.NET V', 0, 1)"

            Dim affectd As Integer = cmd.ExecuteNonQuery() 'insert, update, delete, create 

            cmd.CommandText = "DELETE Maschienen where id=8"
            affectd = cmd.ExecuteNonQuery() 'insert, update, delete, create 

            Debug.WriteLine("Es wurden n Element gelöscht " & affectd)

            cmd.CommandText = "SELECT COUNT(*) FROM Maschienen"

            Dim anzahl As Integer = CInt(cmd.ExecuteScalar())

            Debug.WriteLine("Es gibt " & anzahl & " Datensätze")

            cmd.CommandText = "SELECT ID, Maschienenname, Preis FROM Maschienen where id > 25; select * from Maschienen" 'MARS
            cmd.CommandText = "SELECT ID, Maschienenname, Preis FROM Maschienen where id > 25"

            Dim myReader As SqlDataReader = cmd.ExecuteReader()

            Dim nochEinDatensatzVorhanden As Boolean
            'nochEinDatensatzVorhanden = myReader.Read() 'erste Zeile
            'nochEinDatensatzVorhanden = myReader.Read() 'nächste Zeile


            While (myReader.Read())
                Debug.WriteLine("ID: " & myReader("ID") & " Name: " & myReader("Maschienenname") & " Preis: " & myReader("Preis"))
            End While
            'myReader.NextResult() 'MARS
            myReader.Close()

            Dim mName As String = "Donnerstag"
            'Gefährlich für SQL Injection
            cmd.CommandText = "INSERT INTO Maschienen VALUES('" & mName & "', 0, 1)"
            cmd.ExecuteNonQuery()

            mName = "Donnerstag als Parameter"
            cmd.CommandText = "INSERT INTO Maschienen VALUES(@productname, 0, 1)"
            'Prameterwert für @productname vergeben - verhindert SQL Injection
            cmd.Parameters.Add(New SqlParameter("@productname", mName))
            cmd.ExecuteNonQuery()


            'Aufruf von Proc
            cmd.CommandText = "AddMachine"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@Machinename", SqlDbType.VarChar))
            cmd.Parameters.Add(New SqlParameter("@Preis", SqlDbType.Decimal))
            cmd.Parameters.Add(New SqlParameter("@Archiviert", SqlDbType.Bit))

            ' Dim p1 As New SqlParameter("Machinename", "Ein TExt")
            ' cmd.Parameters.Add(p1)

            cmd.Parameters("@Machinename").Value = "von Proc"
            cmd.Parameters("@Preis").Value = 345
            cmd.Parameters("@Archiviert").Value = 0

            Dim affected As Integer = cmd.ExecuteNonQuery()
            Debug.WriteLine("Es gibt " & anzahl & " Datensätze")
        Catch ex As Exception
            Debug.WriteLine(ex)
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


    Private Sub btnLesen_Click(sender As Object, e As EventArgs) Handles btnLesen.Click

        Dim maschinenListe As List(Of Maschine) = MyDBHelper.GetMaschinen()
        lstProdukte.DataSource = maschinenListe
        lstProdukte.DisplayMember = "Bezeichnung"
        lstProdukte.ValueMember = "ID"


    End Sub

    Private Sub lstProdukte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProdukte.SelectedIndexChanged

        Dim ausgewaehlteMaschine As Maschine = lstProdukte.SelectedItem
        'Dim ausgewId As Int32 = CInt(lstProdukte.SelectedValue)
        txtId.Text = ausgewaehlteMaschine.Id
        txtBez.Text = ausgewaehlteMaschine.Bezeichnung


    End Sub

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        Dim bezeichnung As String = txtBez.Text
        Dim id As Integer = txtId.Text

        MyDBHelper.UpdateMaschine(id, txtBez.Text)

    End Sub


End Class
