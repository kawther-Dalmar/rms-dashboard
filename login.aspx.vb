Imports System.Drawing
Imports System.Data.SqlClient
Partial Class login
    Inherits System.Web.UI.Page
    Dim Obj As New MyConnection
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim da As New SqlDataAdapter
    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            If conn.State = Data.ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New SqlCommand("Select * from Users where username = '" & txtusername.Text & "' and password= '" & txtpassword.Text & "'", conn)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Session("userid") = dr.GetValue(0)
                'Session("username") = dr.GetValue(1)
                Dim status As String = dr.GetValue(5)
                dr.Close()
                If status = "Block" Then
                    Response.Write("<script>alert('Your account has been blocked')</script>")
                    Return
                End If
                Session("username") = txtusername.Text
                Response.Redirect("Dashboard.aspx", False)
            Else
                dr.Close()
                lblMessage.Text = "Invalid user Name or Password"
                lblMessage.Visible = True
                lblMessage.ForeColor = Color.Red
            End If

        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True

        End Try
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            conn = Obj.getConnection()


        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True

        End Try
    End Sub

End Class

