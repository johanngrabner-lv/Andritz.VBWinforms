<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPersonAnlegen
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVorname = New System.Windows.Forms.TextBox()
        Me.txtNachname = New System.Windows.Forms.TextBox()
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.txtGeschlecht = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.chkGewerkschaft = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optWien = New System.Windows.Forms.RadioButton()
        Me.optGraz = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optMann = New System.Windows.Forms.RadioButton()
        Me.optFrau = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'txtVorname
        '
        Me.txtVorname.Location = New System.Drawing.Point(106, 18)
        Me.txtVorname.Name = "txtVorname"
        Me.txtVorname.Size = New System.Drawing.Size(100, 20)
        Me.txtVorname.TabIndex = 2
        '
        'txtNachname
        '
        Me.txtNachname.Location = New System.Drawing.Point(106, 45)
        Me.txtNachname.Name = "txtNachname"
        Me.txtNachname.Size = New System.Drawing.Size(100, 20)
        Me.txtNachname.TabIndex = 3
        '
        'btnSpeichern
        '
        Me.btnSpeichern.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSpeichern.Location = New System.Drawing.Point(15, 298)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(75, 23)
        Me.btnSpeichern.TabIndex = 4
        Me.btnSpeichern.Text = "Speichern"
        Me.ToolTip1.SetToolTip(Me.btnSpeichern, "Person wird angelegt und Dialog geschlossen")
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(131, 298)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(75, 23)
        Me.btnAbbrechen.TabIndex = 5
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'txtGeschlecht
        '
        Me.txtGeschlecht.AutoCompleteCustomSource.AddRange(New String() {"Mann", "Frau"})
        Me.txtGeschlecht.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtGeschlecht.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtGeschlecht.Location = New System.Drawing.Point(106, 72)
        Me.txtGeschlecht.Name = "txtGeschlecht"
        Me.txtGeschlecht.Size = New System.Drawing.Size(100, 20)
        Me.txtGeschlecht.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Geschlecht"
        Me.ToolTip1.SetToolTip(Me.Label3, "bitte mann oder frau")
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'chkGewerkschaft
        '
        Me.chkGewerkschaft.AutoSize = True
        Me.chkGewerkschaft.Location = New System.Drawing.Point(106, 99)
        Me.chkGewerkschaft.Name = "chkGewerkschaft"
        Me.chkGewerkschaft.Size = New System.Drawing.Size(92, 17)
        Me.chkGewerkschaft.TabIndex = 8
        Me.chkGewerkschaft.Text = "Gewerkschaft"
        Me.chkGewerkschaft.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optGraz)
        Me.GroupBox1.Controls.Add(Me.optWien)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 70)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Arbeitsort"
        Me.ToolTip1.SetToolTip(Me.GroupBox1, "Geben Sie bitte Ihren primären Arbeitsort an")
        '
        'optWien
        '
        Me.optWien.AutoSize = True
        Me.optWien.Location = New System.Drawing.Point(27, 19)
        Me.optWien.Name = "optWien"
        Me.optWien.Size = New System.Drawing.Size(50, 17)
        Me.optWien.TabIndex = 0
        Me.optWien.TabStop = True
        Me.optWien.Text = "Wien"
        Me.optWien.UseVisualStyleBackColor = True
        '
        'optGraz
        '
        Me.optGraz.AutoSize = True
        Me.optGraz.Location = New System.Drawing.Point(27, 47)
        Me.optGraz.Name = "optGraz"
        Me.optGraz.Size = New System.Drawing.Size(47, 17)
        Me.optGraz.TabIndex = 1
        Me.optGraz.TabStop = True
        Me.optGraz.Text = "Graz"
        Me.optGraz.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optMann)
        Me.GroupBox2.Controls.Add(Me.optFrau)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 215)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(169, 70)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Geschlecht"
        '
        'optMann
        '
        Me.optMann.AutoSize = True
        Me.optMann.Location = New System.Drawing.Point(27, 47)
        Me.optMann.Name = "optMann"
        Me.optMann.Size = New System.Drawing.Size(52, 17)
        Me.optMann.TabIndex = 1
        Me.optMann.TabStop = True
        Me.optMann.Text = "Mann"
        Me.optMann.UseVisualStyleBackColor = True
        '
        'optFrau
        '
        Me.optFrau.AutoSize = True
        Me.optFrau.Location = New System.Drawing.Point(27, 19)
        Me.optFrau.Name = "optFrau"
        Me.optFrau.Size = New System.Drawing.Size(46, 17)
        Me.optFrau.TabIndex = 0
        Me.optFrau.TabStop = True
        Me.optFrau.Text = "Frau"
        Me.optFrau.UseVisualStyleBackColor = True
        '
        'FormPersonAnlegen
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(265, 437)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkGewerkschaft)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGeschlecht)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.txtNachname)
        Me.Controls.Add(Me.txtVorname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPersonAnlegen"
        Me.Text = "FormPersonAnlegen"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVorname As TextBox
    Friend WithEvents txtNachname As TextBox
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents txtGeschlecht As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents chkGewerkschaft As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optMann As RadioButton
    Friend WithEvents optFrau As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optGraz As RadioButton
    Friend WithEvents optWien As RadioButton
    Friend WithEvents ToolTip1 As ToolTip
End Class
