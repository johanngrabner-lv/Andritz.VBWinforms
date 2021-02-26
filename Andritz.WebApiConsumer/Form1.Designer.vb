<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBezeichnung = New System.Windows.Forms.TextBox()
        Me.btnHinzufügen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(33, 61)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(129, 173)
        Me.ListBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtBezeichnung
        '
        Me.txtBezeichnung.Location = New System.Drawing.Point(290, 61)
        Me.txtBezeichnung.Name = "txtBezeichnung"
        Me.txtBezeichnung.Size = New System.Drawing.Size(100, 20)
        Me.txtBezeichnung.TabIndex = 2
        '
        'btnHinzufügen
        '
        Me.btnHinzufügen.Location = New System.Drawing.Point(290, 88)
        Me.btnHinzufügen.Name = "btnHinzufügen"
        Me.btnHinzufügen.Size = New System.Drawing.Size(75, 23)
        Me.btnHinzufügen.TabIndex = 3
        Me.btnHinzufügen.Text = "Button2"
        Me.btnHinzufügen.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnHinzufügen)
        Me.Controls.Add(Me.txtBezeichnung)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtBezeichnung As TextBox
    Friend WithEvents btnHinzufügen As Button
End Class
