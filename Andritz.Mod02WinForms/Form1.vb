Public Class Form1
    Private Sub NeuePersonAnlegenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuePersonAnlegenToolStripMenuItem.Click
        Dim fNeu As New FormPersonAnlegen
        Dim dr As DialogResult

        dr = fNeu.ShowDialog

        If dr = DialogResult.OK Then
            txtMeinePersonen.Text = " eine neue Person wurde angelegt"
        Else
            txtMeinePersonen.Text = "Abgebrochen"
        End If

    End Sub
End Class
