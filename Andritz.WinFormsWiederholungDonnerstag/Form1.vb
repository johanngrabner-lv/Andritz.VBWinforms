Imports Andritz.BewertungZustand

Public Class Form1

    'Eventhandling-Code 
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim zustand As String
        zustand = InputBox("Wie geht es Ihnen")
        Dim bewert As String
        bewert = Zustandsbewertung.GetBewertung(zustand)
        MsgBox("Ihre Eingabe war " & zustand & " Bewertung " & bewert)
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub ShowEnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowEnglishToolStripMenuItem.Click
        Dim wk As String
       ' wk = lstWeekdays.SelectedItem

        Dim wkEnglish As String

        If wk = "Montag" Then
            wkEnglish = "Monday"
        ElseIf wk = "Dienstag" Then
            wkEnglish = "Tuesday"
        Else
            wkEnglish = "Wensday"
        End If
        MsgBox(wkEnglish)
    End Sub

    Private Sub TreeviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TreeviewToolStripMenuItem.Click
        Dim f As New TreeviewSample()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub

    Private Sub Button1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button1.KeyPress
        If e.KeyChar = "N"c Then
            Me.WindowState = FormWindowState.Normal
        ElseIf e.KeyChar = "M"c Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf e.KeyChar = "I"c Then
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub
End Class
