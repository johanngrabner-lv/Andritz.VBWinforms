<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyConverter
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtEingabe = New System.Windows.Forms.TextBox()
        Me.txtLower = New System.Windows.Forms.TextBox()
        Me.txtUpper = New System.Windows.Forms.TextBox()
        Me.btnHello = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEingabe
        '
        Me.txtEingabe.Location = New System.Drawing.Point(31, 19)
        Me.txtEingabe.Name = "txtEingabe"
        Me.txtEingabe.Size = New System.Drawing.Size(151, 20)
        Me.txtEingabe.TabIndex = 0
        '
        'txtLower
        '
        Me.txtLower.Location = New System.Drawing.Point(31, 45)
        Me.txtLower.Name = "txtLower"
        Me.txtLower.Size = New System.Drawing.Size(151, 20)
        Me.txtLower.TabIndex = 1
        '
        'txtUpper
        '
        Me.txtUpper.Location = New System.Drawing.Point(31, 74)
        Me.txtUpper.Name = "txtUpper"
        Me.txtUpper.Size = New System.Drawing.Size(151, 20)
        Me.txtUpper.TabIndex = 2
        '
        'btnHello
        '
        Me.btnHello.Location = New System.Drawing.Point(213, 45)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(118, 23)
        Me.btnHello.TabIndex = 3
        Me.btnHello.Text = "Say Hello"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(34, 107)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(147, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(213, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'MyConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnHello)
        Me.Controls.Add(Me.txtUpper)
        Me.Controls.Add(Me.txtLower)
        Me.Controls.Add(Me.txtEingabe)
        Me.Name = "MyConverter"
        Me.Size = New System.Drawing.Size(343, 173)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEingabe As TextBox
    Friend WithEvents txtLower As TextBox
    Friend WithEvents txtUpper As TextBox
    Friend WithEvents btnHello As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
