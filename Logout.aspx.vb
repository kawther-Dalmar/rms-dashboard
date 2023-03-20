
Partial Class Logout
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Session("username") = ""
        Response.Redirect("login.aspx", False)

    End Sub
End Class
