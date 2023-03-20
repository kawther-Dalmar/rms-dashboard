Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Data
Partial Class Changing_Password
    Inherits System.Web.UI.Page
    Dim Obj As New MyConnection
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim da As New SqlDataAdapter
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            conn = Obj.getConnection()
            txtusername.Text = Session("username")

        Catch ex As Exception

            lblMessage.Text = ex.Message
            lblMessage.Visible = True
            lblMessage.ForeColor = Color.Red
            lblMessage.BackColor = Color.Red

        End Try
    End Sub
    Protected Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Try

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New SqlCommand("select * from Users where Username='" & txtusername.Text & "' and password='" & txtOldPassword.Text & "' ", conn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                dr.Close()
                cmd = New SqlCommand("Update users set password='" & txtNewPassword.Text & "' where Username='" & txtusername.Text & "'", conn)
                cmd.ExecuteNonQuery()
                Response.Write("<script>alert('" & txtusername.Text & " Your password Has Been Changed')</script>")


            Else
                dr.Close()
                Response.Write("<script>alert('INVALID Old Password')</script>")


            End If
        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True

        End Try
    End Sub
End Class

