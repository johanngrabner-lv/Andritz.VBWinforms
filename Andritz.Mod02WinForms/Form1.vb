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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        For i As Integer = 0 To 1000000
            ' unterbrechen und anstehende Ereignisse aus dem Puffer holen 
            Application.DoEvents()

            txtMeinePersonen.Text = i.ToString()

        Next
    End Sub

    Private Sub lstPersonen_SelectedIndexChanged(sender As Object, e As EventArgs)
        Me.Text = lstPersonen.SelectedItem
    End Sub
    Private Wohnungen As New ArrayList()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Wohnungen.Add(New Wohnung(25, 300, 1))
        Wohnungen.Add(New Wohnung(54, 470, 2))
        Wohnungen.Add(New Wohnung(87, 729, 4))
        Wohnungen.Add(New Wohnung(60, 650, 2))
        Wohnungen.Add(New Wohnung(75, 680, 3))
        lstWohnungen.DataSource = Wohnungen
        lstWohnungen.DisplayMember = "Bezeichnung"
        lstWohnungen.ValueMember = "Miete"
        lstWohnungen.SelectedIndex = 1
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Dim miete As String = lstWohnungen.SelectedValue

        Dim ausgewaehlteWohnung As Wohnung = CType(lstWohnungen.SelectedItem, Wohnung)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Me.Text = "Code: " & e.KeyCode & " Value: " & e.KeyValue

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim i As Int16
        e.Handled = True

    End Sub

    Private Sub SplitContainer2_Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles SplitContainer2.Panel1.MouseMove
        Me.Text = "X: " & e.X & " y:" & e.Y
    End Sub
End Class
