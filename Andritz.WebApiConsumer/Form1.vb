Imports System.Net.Http

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'http GET https://localhost:44363/api/Maschinen
        'JSON-Array -- Cast List Maschinen
        Using client As HttpClient = New HttpClient()
            client.BaseAddress = New Uri("https://localhost:44363/api/")
            Dim response = client.GetAsync("Maschinen").Result
            Dim readTastk = response.Content.ReadAsAsync(Of List(Of Maschine))
            Dim maschins = readTastk.Result
            For Each m As Maschine In maschins
                ListBox1.Items.Add(m.Bezeichnung)
            Next

        End Using
    End Sub

    Private Sub btnHinzufügen_Click(sender As Object, e As EventArgs) Handles btnHinzufügen.Click
        Dim m As New Maschine
        m.Bezeichnung = txtBezeichnung.Text
        Using client As HttpClient = New HttpClient()
            client.BaseAddress = New Uri("https://localhost:44363/api/")
            Dim response = client.PostAsJsonAsync(Of Maschine)("Maschinen", m).Result

        End Using
    End Sub
End Class
