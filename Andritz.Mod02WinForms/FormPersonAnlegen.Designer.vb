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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVorname = New System.Windows.Forms.TextBox()
        Me.txtNachname = New System.Windows.Forms.TextBox()
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'txtVorname
        '
        Me.txtVorname.Location = New System.Drawing.Point(91, 14)
        Me.txtVorname.Name = "txtVorname"
        Me.txtVorname.Size = New System.Drawing.Size(100, 20)
        Me.txtVorname.TabIndex = 2
        '
        'txtNachname
        '
        Me.txtNachname.Location = New System.Drawing.Point(91, 41)
        Me.txtNachname.Name = "txtNachname"
        Me.txtNachname.Size = New System.Drawing.Size(100, 20)
        Me.txtNachname.TabIndex = 3
        '
        'btnSpeichern
        '
        Me.btnSpeichern.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSpeichern.Location = New System.Drawing.Point(13, 92)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(75, 23)
        Me.btnSpeichern.TabIndex = 4
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAbbrechen.Location = New System.Drawing.Point(129, 92)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(75, 23)
        Me.btnAbbrechen.TabIndex = 5
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'FormPersonAnlegen
        '
        Me.AcceptButton = Me.btnSpeichern
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAbbrechen
        Me.ClientSize = New System.Drawing.Size(265, 140)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.txtNachname)
        Me.Controls.Add(Me.txtVorname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPersonAnlegen"
        Me.Text = "FormPersonAnlegen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVorname As TextBox
    Friend WithEvents txtNachname As TextBox
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents btnAbbrechen As Button
End Class
