Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Data

Partial Class users
    Inherits System.Web.UI.Page
    Dim Obj As New MyConnection
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim da As New SqlDataAdapter
    Sub clear()
        txtusername.Text = " "
        txtphone.Text = " "
        ddltype.SelectedIndex = 0
        txtDor.Text = " "
        btnAction.Text = "Save"

    End Sub
    Sub FillUsersGridView()
        Try
            If conn.State = Data.ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New SqlCommand("Select *from Users", conn)
            da = New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvUsers.DataSource = dt
            dgvUsers.DataBind()

        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True
            lblMessage.ForeColor = Color.Red

        End Try
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If Session("username") = "" Then
                Response.Redirect("login.aspx", False)
            End If
            conn = Obj.getConnection()
            FillUsersGridView()
            lbluserName.Text = Session("username")
            Dim userid As Integer = Session("userid")
            imgUsers.ImageUrl = "~/ShowImage.ashx?id=" & userid
        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True

        End Try
    End Sub
    Protected Sub btnAction_Click(sender As Object, e As EventArgs) Handles btnAction.Click
        Try
            If conn.State = Data.ConnectionState.Closed Then
                conn.Open()
            End If

            'Image Upload
            Dim img As FileUpload = CType(imgUpload, FileUpload)
            Dim imgByte As Byte() = Nothing
            If img.HasFile AndAlso Not img.PostedFile Is Nothing Then
                'To create a PostedFile
                Dim File As HttpPostedFile = imgUpload.PostedFile
                'Create byte Array with file len
                imgByte = New Byte(File.ContentLength - 1) {}
                'force the control to load data in array
                File.InputStream.Read(imgByte, 0, File.ContentLength)
            End If


            If btnAction.Text = "Save" Then

                'cheking username
                cmd = New SqlCommand("select userName from Users where userName='" & txtusername.Text & "' ", conn)
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    lblMessage.Text = "This User Name has Already been exist"
                    lblMessage.Visible = True
                    lblMessage.ForeColor = Color.Red
                    dr.Close()
                    txtusername.Text = ""
                    Return

                End If
                dr.Close()
                cmd = New SqlCommand("select ISNULL (max(userid),100) +1 from Users", conn)
                Dim id As Integer = cmd.ExecuteScalar()
                cmd = New SqlCommand("insert into Users values('" & id & "', '" & txtusername.Text & "','" & txtpassword.Text & "','" & txtphone.Text & "', '" & ddltype.Text & "','" & "Active" & "','" & txtDor.Text & "', @img)", conn)
                cmd.Parameters.AddWithValue("@img", imgByte)
                If cmd.ExecuteNonQuery() > 0 Then
                    Response.Write("<script>alert('" & "User information has been Saved" & "')</script")

                End If

            ElseIf btnAction.Text = "Update" Then

                cmd = New SqlCommand("Update Users set password='" & txtpassword.Text & "',phone= '" & txtphone.Text & "', type= '" & ddltype.Text & "', Dor= '" & txtDor.Text & "'  where userName= '" & txtusername.Text & "'", conn)
                If cmd.ExecuteNonQuery() > 0 Then
                    Response.Write("<script>alert('" & "User information has been Updated" & "')</script")
                End If
            End If

            FillUsersGridView()
            clear()
        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True
            lblMessage.ForeColor = Color.Red
        End Try
    End Sub
    Protected Sub dgvUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgvUsers.SelectedIndexChanged
        Try
            txtusername.Text = dgvUsers.SelectedRow.Cells(2).Text
            txtpassword.Text = dgvUsers.SelectedRow.Cells(3).Text
            txtphone.Text = dgvUsers.SelectedRow.Cells(4).Text
            ddltype.Text = dgvUsers.SelectedRow.Cells(5).Text
            txtDor.Text = dgvUsers.SelectedRow.Cells(7).Text
            btnAction.Text = "Update"
            txtusername.ReadOnly = True

        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True
            lblMessage.ForeColor = Color.Red
        End Try
    End Sub
End Class

