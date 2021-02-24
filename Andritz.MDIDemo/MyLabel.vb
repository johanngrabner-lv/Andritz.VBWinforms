Public Class VerticalLabel : Inherits Control

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.Size = New Size(25, 100) ' Festlegen der Standardgröße im Designer 
    End Sub

    Private Sub Neu(sender As Object, e As EventArgs) Handles Me.Resize
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim lblColor As Color = Color.Empty
        Dim txtColor As Color = MyBase.ForeColor
        MyBase.OnPaint(e)

        ' Rahmen zeichnen 
        e.Graphics.FillRectangle(New SolidBrush(lblColor), 0, 0, Width, Height)

        ' Ursprungspunkt versetzen und drehen 
        e.Graphics.TranslateTransform(0, Height)
        e.Graphics.RotateTransform(270)

        ' Text in das Steuerelement zeichnen 
        e.Graphics.DrawString(lblText, Me.Font, New SolidBrush(txtColor), 0, 0)
    End Sub

    ' Veröffentlichen der Eigenschaft 'Text' 
    Dim lblText As String
    Public Overrides Property Text() As String
        Get
            Return lblText
        End Get
        Set(ByVal value As String)
            lblText = value
            Invalidate()
        End Set
    End Property
End Class
