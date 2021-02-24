
Imports System.ComponentModel

Public Class MyTextbox : Inherits TextBox
    Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
        ' registrierte Ereignishandler aufrufen 
        MyBase.OnKeyPress(e)

        Dim input As Integer = Convert.ToInt32(e.KeyChar)
        If (input >= 47 AndAlso input <= 57) OrElse (input = 8) Then Return
        e.Handled = True
    End Sub

    Protected Overrides Sub OnLeave(e As EventArgs)
        MsgBox(Me.Text & " Wert " & Wert)
    End Sub



    Private _MaxWert As String
    <Description("Textbox mit zahlen")>
    Public Property Wert() As String
        Get
            Return _MaxWert
        End Get
        Set(ByVal value As String)
            _MaxWert = value
        End Set
    End Property

End Class

