Imports System.ComponentModel

Public Class Form1
    Private Sub btnSayHello_Click(sender As Object, e As EventArgs) Handles btnSayHello.Click
        'Event-Handler
        txtBegruessung.Text = "Heute ist der " & System.DateTime.Now.ToShortDateString

    End Sub

    Private Sub btnShowTime_Click(sender As Object, e As EventArgs) Handles btnShowTime.Click
        txtTime.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        txtTime.Text = txtBegruessung.Text

    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Dim top As Int16 = 10
    Private Sub btnGender_Click(sender As Object, e As EventArgs) Handles btnGender.Click
        Dim t1 As New TextBox

        t1.Text = txtGender.Text
        t1.Top = top

        grpGender.Controls.Add(t1)

        top += 20

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Dim dr As DialogResult = MessageBox.Show(
      "Wollen Sie die Anwendung beenden?", "Anwendungsmeldung",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question,
      MessageBoxDefaultButton.Button2)
        ' wird im Meldungsfenster 'Nein' geklickt, 
        ' wird der Schließvorgang abgebrochen 
        If (dr = DialogResult.No) Then e.Cancel = True
    End Sub

    Dim counter As Int16 = 1
    Private Sub RechnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RechnenToolStripMenuItem.Click
        Dim f As New frmDemo
        f.Text = "Rechner " & counter
        'frmDemo.Show()
        counter += 1


        Dim dr As DialogResult = f.ShowDialog()

        If dr = DialogResult.OK Then
            MsgBox("Sie haben OK geklick")
        Else
            MsgBox("Sie haben Cancel geklick")
        End If
    End Sub

    Private Sub OffeneFormulareAnzeigenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OffeneFormulareAnzeigenToolStripMenuItem.Click
        For Each fm As Form In Application.OpenForms
            lstOpenforms.Items.Add(fm.Text)
        Next
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint


    End Sub
End Class
