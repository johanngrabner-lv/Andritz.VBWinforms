Public Class MyLogic
    Shared Function Calc(z1 As Integer, z2 As Integer, op As String) As Integer
        If (op = "+") Then
            Return z1 + z2
        Else
            Return z1 - z2
        End If

    End Function
End Class
