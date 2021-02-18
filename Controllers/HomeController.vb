Public Class HomeController
    Inherits System.Web.Mvc.Controller

    'test comment.
    'test comment -JD
    'test comment - Justin Ng
    'lasdkfjalskdjf;laksdjf;laksjdf;aksdjf;ka

    Function Index() As ActionResult
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
