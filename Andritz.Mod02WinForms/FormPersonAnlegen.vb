Imports System.ComponentModel

Public Class FormPersonAnlegen
    Private Sub FormPersonAnlegen_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim m As DialogResult

        m = MsgBox("Wollen Sie wirklich beenden ")
    End Sub

    Private Sub txtGeschlecht_Validating(sender As Object, e As CancelEventArgs) Handles txtGeschlecht.Validating
        If txtGeschlecht.Text <> "Mann" And txtGeschlecht.Text <> "Frau" Then
            'Me.Text = "Geschlecht ist ungültig"
            ErrorProvider1.SetError(txtGeschlecht, "Geschlecht ist ungültig")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(txtGeschlecht, "")
        End If
    End Sub
End Class