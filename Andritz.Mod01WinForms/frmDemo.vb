Public Class frmDemo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim z As Int16
        z = CInt(TextBox1.Text) * 2
        TextBox1.Text = z
    End Sub
End Class