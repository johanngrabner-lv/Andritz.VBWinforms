Public Class TreeviewSample
    Private Sub TreeviewSample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tr As New TreeView()
        Dim kn As String()
        tr.Dock = DockStyle.Fill
        tr.Nodes.Add("Erde")
        tr.Nodes(0).Tag = "ein Test"
        kn = New String() {"Amerika", "Asien", "Afrika", "Australien", "Europa"}
        For Each k As String In kn
            tr.Nodes(0).Nodes.Add(k)
        Next
        Me.Controls.Add(tr)
    End Sub
End Class