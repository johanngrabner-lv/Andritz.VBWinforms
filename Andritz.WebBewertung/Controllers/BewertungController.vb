Imports System.Net
Imports System.Web.Http
Imports Andritz.BewertungZustand

Namespace Controllers
    Public Class BewertungController
        Inherits ApiController

        Public Function GetBewertung(zustand As String) As String
            Return Zustandsbewertung.GetBewertung(zustand)
        End Function
    End Class
End Namespace