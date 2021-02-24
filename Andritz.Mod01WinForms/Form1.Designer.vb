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

    Private Sub InitializeComponent()
        Me.btnSayHello = New System.Windows.Forms.Button()
        Me.txtBegruessung = New System.Windows.Forms.TextBox()
        Me.btnShowTime = New System.Windows.Forms.Button()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpGender = New System.Windows.Forms.GroupBox()
        Me.btnGender = New System.Windows.Forms.Button()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.RechnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstOpenforms = New System.Windows.Forms.ListBox()
        Me.OffeneFormulareAnzeigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSayHello
        '
        Me.btnSayHello.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSayHello.Location = New System.Drawing.Point(43, 47)
        Me.btnSayHello.Name = "btnSayHello"
        Me.btnSayHello.Size = New System.Drawing.Size(328, 39)
        Me.btnSayHello.TabIndex = 2
        Me.btnSayHello.Text = "Sag Hallo!"
        Me.btnSayHello.UseVisualStyleBackColor = False
        '
        'txtBegruessung
        '
        Me.txtBegruessung.Location = New System.Drawing.Point(43, 102)
        Me.txtBegruessung.Name = "txtBegruessung"
        Me.txtBegruessung.Size = New System.Drawing.Size(328, 20)
        Me.txtBegruessung.TabIndex = 1
        '
        'btnShowTime
        '
        Me.btnShowTime.Location = New System.Drawing.Point(49, 137)
        Me.btnShowTime.Name = "btnShowTime"
        Me.btnShowTime.Size = New System.Drawing.Size(310, 26)
        Me.btnShowTime.TabIndex = 2
        Me.btnShowTime.Text = "Zeit anzeigen"
        Me.btnShowTime.UseVisualStyleBackColor = True
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(49, 170)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(310, 20)
        Me.txtTime.TabIndex = 1
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.Color.Red
        Me.btnCopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopy.Location = New System.Drawing.Point(49, 197)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(233, 97)
        Me.btnCopy.TabIndex = 0
        Me.btnCopy.Text = "Kopieren"
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(723, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.BeendenToolStripMenuItem, Me.RechnenToolStripMenuItem, Me.OffeneFormulareAnzeigenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.NeuToolStripMenuItem.Text = "Neu"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'grpGender
        '
        Me.grpGender.Location = New System.Drawing.Point(409, 57)
        Me.grpGender.Name = "grpGender"
        Me.grpGender.Size = New System.Drawing.Size(70, 174)
        Me.grpGender.TabIndex = 7
        Me.grpGender.TabStop = False
        Me.grpGender.Text = "Geschlecht"
        '
        'btnGender
        '
        Me.btnGender.Location = New System.Drawing.Point(404, 252)
        Me.btnGender.Name = "btnGender"
        Me.btnGender.Size = New System.Drawing.Size(75, 23)
        Me.btnGender.TabIndex = 4
        Me.btnGender.Text = "Gender Hinzufügen"
        Me.btnGender.UseVisualStyleBackColor = True
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(486, 256)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(100, 20)
        Me.txtGender.TabIndex = 5
        '
        'RechnenToolStripMenuItem
        '
        Me.RechnenToolStripMenuItem.Name = "RechnenToolStripMenuItem"
        Me.RechnenToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.RechnenToolStripMenuItem.Text = "Rechnen"
        '
        'lstOpenforms
        '
        Me.lstOpenforms.FormattingEnabled = True
        Me.lstOpenforms.Location = New System.Drawing.Point(535, 102)
        Me.lstOpenforms.Name = "lstOpenforms"
        Me.lstOpenforms.Size = New System.Drawing.Size(120, 95)
        Me.lstOpenforms.TabIndex = 8
        '
        'OffeneFormulareAnzeigenToolStripMenuItem
        '
        Me.OffeneFormulareAnzeigenToolStripMenuItem.Name = "OffeneFormulareAnzeigenToolStripMenuItem"
        Me.OffeneFormulareAnzeigenToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.OffeneFormulareAnzeigenToolStripMenuItem.Text = "offene Formulare anzeigen"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(723, 354)
        Me.Controls.Add(Me.lstOpenforms)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.btnGender)
        Me.Controls.Add(Me.grpGender)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.btnShowTime)
        Me.Controls.Add(Me.txtBegruessung)
        Me.Controls.Add(Me.btnSayHello)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Hello Andritz"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSayHello As Button
    Friend WithEvents txtBegruessung As TextBox
    Friend WithEvents btnShowTime As Button
    Friend WithEvents txtTime As TextBox
    Friend WithEvents btnCopy As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpGender As GroupBox
    Friend WithEvents btnGender As Button
    Friend WithEvents txtGender As TextBox
    Friend WithEvents RechnenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OffeneFormulareAnzeigenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstOpenforms As ListBox
End Class
