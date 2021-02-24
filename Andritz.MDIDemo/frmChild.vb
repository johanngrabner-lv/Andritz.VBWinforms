Imports System.Drawing.Drawing2D

Public Class frmChild
    Private Sub frmChild_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim p As New Pen(Color.Red)
        p.DashStyle = DashStyle.Dash

        Dim gr As Graphics = e.Graphics
        Dim w As Integer = Me.ClientSize.Width, h = Me.ClientSize.Height
        For i As Integer = 0 To 4
            gr.DrawEllipse(New Pen(Brushes.Black), i * w \ 10, i * h \ 10, w, h)
        Next

        Dim str As String = "Hallo Welt"
        Dim ft As New Font("Arial", 20)

        Dim we As Integer = ClientSize.Width, he As Integer = ClientSize.Height
        gr.DrawString(str, ft, Brushes.Black, 0, 0)
        gr.DrawLine(New Pen(Brushes.Blue), 0, he \ 2, we, he \ 2)
        gr.DrawLine(New Pen(Brushes.Blue), we \ 2, 0, we \ 2, he)
        gr.DrawString(str, ft, Brushes.Black, we / 2, he / 2)

    End Sub
End Class