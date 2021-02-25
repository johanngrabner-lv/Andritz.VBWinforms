Public Class Zustandsbewertung

    Public Shared Function GetBewertung(zustand As String) As String
        If zustand = "Gut" Then
            Return "Alles OK"
        Else
            Return "Take care"
        End If
    End Function


End Class
