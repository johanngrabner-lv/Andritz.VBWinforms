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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuePersonAnlegenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtMeinePersonen = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstPersonen = New System.Windows.Forms.ListBox()
        Me.cmbPersonen = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuePersonAnlegenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'NeuePersonAnlegenToolStripMenuItem
        '
        Me.NeuePersonAnlegenToolStripMenuItem.Name = "NeuePersonAnlegenToolStripMenuItem"
        Me.NeuePersonAnlegenToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.NeuePersonAnlegenToolStripMenuItem.Text = "Neue Person anlegen"
        '
        'txtMeinePersonen
        '
        Me.txtMeinePersonen.Location = New System.Drawing.Point(29, 27)
        Me.txtMeinePersonen.Multiline = True
        Me.txtMeinePersonen.Name = "txtMeinePersonen"
        Me.txtMeinePersonen.Size = New System.Drawing.Size(206, 184)
        Me.txtMeinePersonen.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(29, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstPersonen
        '
        Me.lstPersonen.FormattingEnabled = True
        Me.lstPersonen.Location = New System.Drawing.Point(242, 28)
        Me.lstPersonen.Name = "lstPersonen"
        Me.lstPersonen.Size = New System.Drawing.Size(120, 95)
        Me.lstPersonen.TabIndex = 3
        '
        'cmbPersonen
        '
        Me.cmbPersonen.FormattingEnabled = True
        Me.cmbPersonen.Location = New System.Drawing.Point(384, 33)
        Me.cmbPersonen.Name = "cmbPersonen"
        Me.cmbPersonen.Size = New System.Drawing.Size(157, 21)
        Me.cmbPersonen.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbPersonen)
        Me.Controls.Add(Me.lstPersonen)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMeinePersonen)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeuePersonAnlegenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtMeinePersonen As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lstPersonen As ListBox
    Friend WithEvents cmbPersonen As ComboBox
End Class
