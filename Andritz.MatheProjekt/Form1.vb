Imports System.ComponentModel
Imports Andritz.MyLib

Public Class Form1
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

    End Sub

    Private Sub txtZahl1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtZahl1.Validating, txtZahl2.Validating
        Dim aTextBox As TextBox

        aTextBox = CType(sender, TextBox)

        'CheckValid(txtZahl1)
        CheckValid(aTextBox)
    End Sub

    Sub CheckValid(zahlenTextbox As TextBox)
        Dim zahl As Int16

        Dim success As Boolean = Int32.TryParse(zahlenTextbox.Text, zahl)
        If success = False Then
            ErrorProvider1.SetError(zahlenTextbox, "Zahl ist ungültig")
        Else
            ErrorProvider1.SetError(zahlenTextbox, "")
        End If

    End Sub

    Private Sub cmdCalcVariante1MitList_Click(sender As Object, e As EventArgs) Handles cmdCalcVariante1MitList.Click
        Dim z1 As Int16 = CInt(txtZahl1.Text)
        Dim z2 As Int16 = CInt(txtZahl2.Text)

        Dim erg = MyLogic.Calc(z1, z2, lstOperatoren.SelectedItem)
        lblResult1.Text = erg

    End Sub



    Private Sub cmdCalcVariante2MitOpt_Click(sender As Object, e As EventArgs) Handles cmdCalcVariante2MitOpt.Click
        Dim z1 As Int16 = CInt(txtZahl1.Text)
        Dim z2 As Int16 = CInt(txtZahl2.Text)

        Dim op As String
        If optMinus.Checked = True Then
            op = "-"
        Else
            op = "+"
        End If

        Dim erg = MyLogic.Calc(z1, z2, op)
        lblResult2.Text = erg
    End Sub
End Class
