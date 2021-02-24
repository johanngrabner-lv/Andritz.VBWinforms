Imports Andritz.MyLib

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Dim erg As Int32 = MyLogic.Calc(12, 20, "+")

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
