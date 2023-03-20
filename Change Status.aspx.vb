Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Data
Partial Class Change_Status
    Inherits System.Web.UI.Page
    Dim Obj As New MyConnection
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim status As String
    Sub fillListOfUserNames()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                cmd = New SqlCommand("Select 0 as Userid, '-----Select User Name------'as username from Users union select userid, username from Users where username<>'" & Session("username") & "'", conn)
                da = New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                ddlUserNames.DataSource = dt
                ddlUserNames.DataTextField = dt.Columns("username").ColumnName
                ddlUserNames.DataValueField = dt.Columns("userid").ColumnName
                ddlUserNames.DataBind()

            End If


        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True
            lblMessage.ForeColor = Color.Red
            lblMessage.BackColor = Color.LightBlue
        End Try
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            conn = Obj.getConnection()
            If Not IsPostBack Then
                fillListOfUserNames()
            End If

        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True
            lblMessage.ForeColor = Color.Red
            lblMessage.BackColor = Color.LightBlue
        End Try
    End Sub


    Protected Sub btnChangeStatus_Click(sender As Object, e As EventArgs) Handles btnChangeStatus.Click
        Try
            If ddlUserNames.Text = "" Then
                lblMessage.Text = "Select  Name"
                lblMessage.Visible = True
                lblMessage.ForeColor = Color.Wheat
                lblMessage.BackColor = Color.Blue
                ddlUserNames.Focus()
                Return
            End If

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            If rbtnActive.Checked = True Then
                status = rbtnActive.Text

            End If
            If rbtnBlock.Checked = True Then
                status = rbtnBlock.Text

            End If
            cmd = New SqlCommand("Update users set Status ='" & status & "' where username='" & ddlUserNames.SelectedItem.Text & "'", conn)
            If cmd.ExecuteNonQuery() > 0 Then

                Response.Write(<script>alert("User Status has been Blocked Successfully")</script>)
                lblMessage.Visible = True
                lblMessage.ForeColor = Color.Green
                lblMessage.BackColor = Color.LightBlue
            End If

        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True
            lblMessage.ForeColor = Color.Red
            lblMessage.BackColor = Color.LightBlue
        End Try
    End Sub
End Class

