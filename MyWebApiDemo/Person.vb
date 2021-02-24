Public Class Person
    Public vorname As String 'Eigenschaf

    Private nachname As String

    'Constructor 
    Public Sub New()
        nachname = "unbekannt"
    End Sub

    Public Sub New(v As String, n As String)
        nachname = n
        vorname = v
    End Sub

    'Funktionalität
    Public Sub SayHello()
        Console.WriteLine("Hello {0}", vorname)
    End Sub

    Public Sub setVorname(v As String)
        vorname = v
    End Sub

    Public Sub setNachname(n As String)
        nachname = n
    End Sub

    Public Function getNachname() As String
        Return nachname
    End Function
End Class
