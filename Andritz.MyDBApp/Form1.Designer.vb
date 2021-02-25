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
        Me.btnADO = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtBez = New System.Windows.Forms.TextBox()
        Me.btnLesen = New System.Windows.Forms.Button()
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.lstProdukte = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnADO
        '
        Me.btnADO.Location = New System.Drawing.Point(48, 13)
        Me.btnADO.Name = "btnADO"
        Me.btnADO.Size = New System.Drawing.Size(145, 31)
        Me.btnADO.TabIndex = 0
        Me.btnADO.Text = "ADO Demo"
        Me.btnADO.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(321, 102)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 2
        '
        'txtBez
        '
        Me.txtBez.Location = New System.Drawing.Point(321, 129)
        Me.txtBez.Name = "txtBez"
        Me.txtBez.Size = New System.Drawing.Size(100, 20)
        Me.txtBez.TabIndex = 3
        '
        'btnLesen
        '
        Me.btnLesen.Location = New System.Drawing.Point(199, 99)
        Me.btnLesen.Name = "btnLesen"
        Me.btnLesen.Size = New System.Drawing.Size(75, 23)
        Me.btnLesen.TabIndex = 4
        Me.btnLesen.Text = "Lesen"
        Me.btnLesen.UseVisualStyleBackColor = True
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Location = New System.Drawing.Point(438, 99)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(75, 23)
        Me.btnSpeichern.TabIndex = 5
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'lstProdukte
        '
        Me.lstProdukte.FormattingEnabled = True
        Me.lstProdukte.Location = New System.Drawing.Point(48, 88)
        Me.lstProdukte.Name = "lstProdukte"
        Me.lstProdukte.Size = New System.Drawing.Size(120, 95)
        Me.lstProdukte.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstProdukte)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.btnLesen)
        Me.Controls.Add(Me.txtBez)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnADO)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnADO As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtBez As TextBox
    Friend WithEvents btnLesen As Button
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents lstProdukte As ListBox
End Class
