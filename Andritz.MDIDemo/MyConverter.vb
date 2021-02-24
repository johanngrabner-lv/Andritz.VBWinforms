Imports System.ComponentModel

Public Class MyConverter
    Private Sub txtEingabe_TextChanged(sender As Object, e As EventArgs) Handles txtEingabe.TextChanged
        txtLower.Text = txtEingabe.Text.ToLower()
        txtUpper.Text = txtEingabe.Text.ToUpper()
    End Sub

    Private _begr As String
    <Description("Legt die Begruessung fest")>
    <Category("Andritz")>
    Public Property Begruessung() As String
        Get
            Return _begr
        End Get
        Set(ByVal value As String)
            _begr = value
        End Set
    End Property

    Private _hoehe As Int16
    <Description("...test")>
    <Category("Grabner")>
    Public Property Hoehe() As Int16
        Get
            Return _hoehe
        End Get
        Set(ByVal value As Int16)
            _hoehe = value
        End Set
    End Property

    Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click
        MsgBox(Begruessung)
    End Sub
End Class
