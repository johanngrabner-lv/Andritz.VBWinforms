<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChild
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.MyTextbox2 = New Andritz.MDIDemo.MyTextbox()
        Me.MyTextbox1 = New Andritz.MDIDemo.MyTextbox()
        Me.MyConverter1 = New Andritz.MDIDemo.MyConverter()
        Me.VerticalLabel1 = New Andritz.MDIDemo.VerticalLabel()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(77, 42)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 0
        '
        'MyTextbox2
        '
        Me.MyTextbox2.Location = New System.Drawing.Point(298, 87)
        Me.MyTextbox2.Name = "MyTextbox2"
        Me.MyTextbox2.Size = New System.Drawing.Size(100, 20)
        Me.MyTextbox2.TabIndex = 3
        Me.MyTextbox2.Wert = "50"
        '
        'MyTextbox1
        '
        Me.MyTextbox1.Location = New System.Drawing.Point(298, 42)
        Me.MyTextbox1.Name = "MyTextbox1"
        Me.MyTextbox1.Size = New System.Drawing.Size(100, 20)
        Me.MyTextbox1.TabIndex = 2
        Me.MyTextbox1.Wert = "10"
        '
        'MyConverter1
        '
        Me.MyConverter1.Begruessung = Nothing
        Me.MyConverter1.Hoehe = CType(0, Short)
        Me.MyConverter1.Location = New System.Drawing.Point(123, 146)
        Me.MyConverter1.Name = "MyConverter1"
        Me.MyConverter1.Size = New System.Drawing.Size(343, 173)
        Me.MyConverter1.TabIndex = 1
        '
        'VerticalLabel1
        '
        Me.VerticalLabel1.Location = New System.Drawing.Point(515, 87)
        Me.VerticalLabel1.Name = "VerticalLabel1"
        Me.VerticalLabel1.Size = New System.Drawing.Size(25, 100)
        Me.VerticalLabel1.TabIndex = 4
        Me.VerticalLabel1.Text = "VerticalLabel1"
        '
        'frmChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 342)
        Me.Controls.Add(Me.VerticalLabel1)
        Me.Controls.Add(Me.MyTextbox2)
        Me.Controls.Add(Me.MyTextbox1)
        Me.Controls.Add(Me.MyConverter1)
        Me.Controls.Add(Me.txtName)
        Me.Name = "frmChild"
        Me.Text = "frmChild"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents MyConverter1 As MyConverter
    Friend WithEvents MyTextbox1 As MyTextbox
    Friend WithEvents MyTextbox2 As MyTextbox
    Friend WithEvents VerticalLabel1 As VerticalLabel
End Class
