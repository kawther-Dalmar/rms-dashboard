Imports System.Drawing
Imports System.Data.SqlClient
Partial Class Dashboard
    Inherits System.Web.UI.Page
    Dim Obj As New MyConnection
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim da As New SqlDataAdapter
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Session("username") = "" Then
            Response.Redirect("login.aspx", False)
        End If
        conn = Obj.getConnection()
        lbluserName.Text = Session("username")
        Dim userid As Integer = Session("userid")
        imgUsers.ImageUrl = "~/ShowImage.ashx?id=" & userid
    End Sub
End Class

