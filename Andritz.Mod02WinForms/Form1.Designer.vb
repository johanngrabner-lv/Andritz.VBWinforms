<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuePersonAnlegenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lstWohnungen = New System.Windows.Forms.ListBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmbPersonen = New System.Windows.Forms.ComboBox()
        Me.lstPersonen = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtMeinePersonen = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1105, 24)
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lstWohnungen)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1105, 751)
        Me.SplitContainer1.SplitterDistance = 172
        Me.SplitContainer1.TabIndex = 1
        '
        'lstWohnungen
        '
        Me.lstWohnungen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstWohnungen.FormattingEnabled = True
        Me.lstWohnungen.Location = New System.Drawing.Point(0, 0)
        Me.lstWohnungen.Name = "lstWohnungen"
        Me.lstWohnungen.Size = New System.Drawing.Size(172, 751)
        Me.lstWohnungen.TabIndex = 12
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cmbPersonen)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lstPersonen)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtMeinePersonen)
        Me.SplitContainer2.Size = New System.Drawing.Size(929, 751)
        Me.SplitContainer2.SplitterDistance = 393
        Me.SplitContainer2.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(44, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(429, 344)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmbPersonen
        '
        Me.cmbPersonen.FormattingEnabled = True
        Me.cmbPersonen.Location = New System.Drawing.Point(537, 30)
        Me.cmbPersonen.Name = "cmbPersonen"
        Me.cmbPersonen.Size = New System.Drawing.Size(157, 21)
        Me.cmbPersonen.TabIndex = 16
        '
        'lstPersonen
        '
        Me.lstPersonen.FormattingEnabled = True
        Me.lstPersonen.Location = New System.Drawing.Point(395, 25)
        Me.lstPersonen.Name = "lstPersonen"
        Me.lstPersonen.Size = New System.Drawing.Size(120, 95)
        Me.lstPersonen.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(258, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 31)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtMeinePersonen
        '
        Me.txtMeinePersonen.Location = New System.Drawing.Point(234, 117)
        Me.txtMeinePersonen.Multiline = True
        Me.txtMeinePersonen.Name = "txtMeinePersonen"
        Me.txtMeinePersonen.Size = New System.Drawing.Size(206, 184)
        Me.txtMeinePersonen.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 775)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeuePersonAnlegenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lstWohnungen As ListBox
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Button2 As Button
    Friend WithEvents cmbPersonen As ComboBox
    Friend WithEvents lstPersonen As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtMeinePersonen As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
