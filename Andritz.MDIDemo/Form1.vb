Public Class Form1
    Private Sub NeuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuToolStripMenuItem.Click
        Dim f As New frmChild
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub AnzeigenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnzeigenToolStripMenuItem.Click
        Dim f As frmChild = CType(Me.ActiveMdiChild, frmChild)
        MsgBox(f.txtName.Text)
    End Sub

    Private Sub V1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles V1ToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub V2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles V2ToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
End Class
