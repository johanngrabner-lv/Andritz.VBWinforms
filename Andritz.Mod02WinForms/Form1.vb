Public Class Form1
    Private Sub NeuePersonAnlegenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuePersonAnlegenToolStripMenuItem.Click
        Dim fNeu As New FormPersonAnlegen
        Dim dr As DialogResult

        dr = fNeu.ShowDialog

        If dr = DialogResult.OK Then

            lstPersonen.Items.Add(fNeu.txtVorname.Text)
            cmbPersonen.Items.Add(fNeu.txtVorname.Text)
            txtMeinePersonen.Text += "Vorname: " & fNeu.txtVorname.Text &
                "Nachname: " & fNeu.txtNachname.Text
            If fNeu.chkGewerkschaft.Checked = True Then
                txtMeinePersonen.Text += "Ja"
            Else
                txtMeinePersonen.Text += "nein"
            End If

            If fNeu.optGraz.Checked = True Then
                txtMeinePersonen.Text += " Graz"
            Else
                txtMeinePersonen.Text += " Wien"
            End If
        Else
            txtMeinePersonen.Text += "Abgebrochen"
        End If



        txtMeinePersonen.Text += vbCrLf

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 0 To 1000000
            ' unterbrechen und anstehende Ereignisse aus dem Puffer holen 
            Application.DoEvents()

            txtMeinePersonen.Text = i.ToString()

        Next
    End Sub

    Private Sub lstPersonen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPersonen.SelectedIndexChanged
        Me.Text = lstPersonen.SelectedItem
    End Sub
End Class
