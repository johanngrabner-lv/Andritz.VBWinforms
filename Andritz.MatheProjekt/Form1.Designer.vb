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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtZahl1 = New System.Windows.Forms.TextBox()
        Me.txtZahl2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lstOperatoren = New System.Windows.Forms.ListBox()
        Me.cmdCalcVariante1MitList = New System.Windows.Forms.Button()
        Me.lblResult1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optMinus = New System.Windows.Forms.RadioButton()
        Me.optPlus = New System.Windows.Forms.RadioButton()
        Me.cmdCalcVariante2MitOpt = New System.Windows.Forms.Button()
        Me.lblResult2 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtZahl1
        '
        Me.txtZahl1.Location = New System.Drawing.Point(18, 36)
        Me.txtZahl1.Name = "txtZahl1"
        Me.txtZahl1.Size = New System.Drawing.Size(112, 20)
        Me.txtZahl1.TabIndex = 0
        Me.txtZahl1.Text = "0"
        '
        'txtZahl2
        '
        Me.txtZahl2.Location = New System.Drawing.Point(151, 37)
        Me.txtZahl2.Name = "txtZahl2"
        Me.txtZahl2.Size = New System.Drawing.Size(107, 20)
        Me.txtZahl2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(45, 240)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(425, 171)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = resources.GetString("TextBox3.Text")
        '
        'lstOperatoren
        '
        Me.lstOperatoren.FormattingEnabled = True
        Me.lstOperatoren.Items.AddRange(New Object() {"+", "-"})
        Me.lstOperatoren.Location = New System.Drawing.Point(18, 74)
        Me.lstOperatoren.Name = "lstOperatoren"
        Me.lstOperatoren.Size = New System.Drawing.Size(55, 43)
        Me.lstOperatoren.TabIndex = 3
        '
        'cmdCalcVariante1MitList
        '
        Me.cmdCalcVariante1MitList.Location = New System.Drawing.Point(85, 73)
        Me.cmdCalcVariante1MitList.Name = "cmdCalcVariante1MitList"
        Me.cmdCalcVariante1MitList.Size = New System.Drawing.Size(89, 43)
        Me.cmdCalcVariante1MitList.TabIndex = 4
        Me.cmdCalcVariante1MitList.Text = "Berechnen"
        Me.cmdCalcVariante1MitList.UseVisualStyleBackColor = True
        '
        'lblResult1
        '
        Me.lblResult1.AutoSize = True
        Me.lblResult1.Location = New System.Drawing.Point(197, 88)
        Me.lblResult1.Name = "lblResult1"
        Me.lblResult1.Size = New System.Drawing.Size(106, 13)
        Me.lblResult1.TabIndex = 5
        Me.lblResult1.Text = "Eregebnis mit Listbox"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optMinus)
        Me.GroupBox1.Controls.Add(Me.optPlus)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 78)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Addition or Sub"
        '
        'optMinus
        '
        Me.optMinus.AutoSize = True
        Me.optMinus.Location = New System.Drawing.Point(14, 45)
        Me.optMinus.Name = "optMinus"
        Me.optMinus.Size = New System.Drawing.Size(28, 17)
        Me.optMinus.TabIndex = 1
        Me.optMinus.TabStop = True
        Me.optMinus.Text = "-"
        Me.optMinus.UseVisualStyleBackColor = True
        '
        'optPlus
        '
        Me.optPlus.AutoSize = True
        Me.optPlus.Location = New System.Drawing.Point(14, 22)
        Me.optPlus.Name = "optPlus"
        Me.optPlus.Size = New System.Drawing.Size(31, 17)
        Me.optPlus.TabIndex = 0
        Me.optPlus.TabStop = True
        Me.optPlus.Text = "+"
        Me.optPlus.UseVisualStyleBackColor = True
        '
        'cmdCalcVariante2MitOpt
        '
        Me.cmdCalcVariante2MitOpt.Location = New System.Drawing.Point(151, 154)
        Me.cmdCalcVariante2MitOpt.Name = "cmdCalcVariante2MitOpt"
        Me.cmdCalcVariante2MitOpt.Size = New System.Drawing.Size(89, 43)
        Me.cmdCalcVariante2MitOpt.TabIndex = 7
        Me.cmdCalcVariante2MitOpt.Text = "Berechnen"
        Me.cmdCalcVariante2MitOpt.UseVisualStyleBackColor = True
        '
        'lblResult2
        '
        Me.lblResult2.AutoSize = True
        Me.lblResult2.Location = New System.Drawing.Point(268, 180)
        Me.lblResult2.Name = "lblResult2"
        Me.lblResult2.Size = New System.Drawing.Size(106, 13)
        Me.lblResult2.TabIndex = 8
        Me.lblResult2.Text = "Eregebnis mit Listbox"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResult2)
        Me.Controls.Add(Me.cmdCalcVariante2MitOpt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblResult1)
        Me.Controls.Add(Me.cmdCalcVariante1MitList)
        Me.Controls.Add(Me.lstOperatoren)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtZahl2)
        Me.Controls.Add(Me.txtZahl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtZahl1 As TextBox
    Friend WithEvents txtZahl2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lstOperatoren As ListBox
    Friend WithEvents cmdCalcVariante1MitList As Button
    Friend WithEvents lblResult1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optMinus As RadioButton
    Friend WithEvents optPlus As RadioButton
    Friend WithEvents cmdCalcVariante2MitOpt As Button
    Friend WithEvents lblResult2 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
