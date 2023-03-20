Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Data
Partial Class Customer_Order
    Inherits System.Web.UI.Page
    Dim Obj As New MyConnection
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim da As New SqlDataAdapter

    Sub fillListOfCustomerOrders()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New SqlCommand("select 0 customerid,'----Select cusomerfname----' as cusomerfname from Customer union select customerid, cusomerfname from Customer", conn)
            da = New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            ddlcusomerfname.DataSource = dt
            ddlcusomerfname.DataTextField = "cusomerfname"
            ddlcusomerfname.DataValueField = "customerid"
            ddlcusomerfname.DataBind()
        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True

        End Try
    End Sub

    Protected Sub btnAction_Click(sender As Object, e As EventArgs) Handles btnAction.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()


            End If
            Response.Redirect("Food.aspx", False)
        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True
            lblMessage.ForeColor = Color.Red


        End Try
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            conn = Obj.getConnection()
            If Not IsPostBack Then
                fillListOfCustomerOrders()
            End If

        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True

        End Try
    End Sub
    Protected Sub ddlcusomerfname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlcusomerfname.SelectedIndexChanged
        If ddlcusomerfname.SelectedIndex > 0 Then
            Session("customerid") = ddlcusomerfname.SelectedValue
        End If
    End Sub
End Class

