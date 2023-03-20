Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Data
Partial Class Customer
    Inherits System.Web.UI.Page
    Dim Obj As New MyConnection
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim da As New SqlDataAdapter

    Sub clear()
        txtfname.Text = ""

        txtaddress.Text = ""
        txtphone.Text = ""
        ddlG.SelectedIndex = 0
        txtDor.Text = ""
        btnAction.Text = "Save"

    End Sub

    Sub FillCustomerGridView()
        Try
            If conn.State = Data.ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New SqlCommand("Select *from Customer", conn)
            da = New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvCustomer.DataSource = dt
            dgvCustomer.DataBind()

        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True
            lblMessage.ForeColor = Color.Red

        End Try

    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            conn = Obj.getConnection()
            FillCustomerGridView()

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

            If btnAction.Text = "Save" Then


                dr = cmd.ExecuteReader()

                dr.Close()
                cmd = New SqlCommand("select ISNULL (max(customerid),0) +1 from Customer", conn)
                Dim id As Integer = cmd.ExecuteScalar()
                cmd = New SqlCommand("insert into Customer values('" & id & "', '" & txtfname.Text & "','" & txtaddress.Text & "', '" & txtphone.Text & "','" & ddlG.Text & "','" & txtDor.Text & "')", conn)

                If cmd.ExecuteNonQuery() > 0 Then
                    Response.Write("<script>alert('" & "Customer information has been Saved" & "')</script")
                End If

            ElseIf btnAction.Text = "Update" Then

                cmd = New SqlCommand("Update Customer set cusomerfname='" & txtfname.Text & "', customerAddress= '" & txtaddress.Text & "',customerphone='" & txtphone.Text & "' where customerid='" & Session("CID") & "' ", conn)
                If cmd.ExecuteNonQuery() > 0 Then
                    Response.Write("<script>alert('" & "Customer information has been Updated" & "')</script")
                End If
            End If

            FillCustomerGridView()
            clear()
        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True
            lblMessage.ForeColor = Color.Red
        End Try
    End Sub
    Protected Sub dgvCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgvCustomer.SelectedIndexChanged
        Try
            Session("CID") = dgvCustomer.SelectedRow.Cells(1).Text
            txtfname.Text = dgvCustomer.SelectedRow.Cells(2).Text
            txtaddress.Text = dgvCustomer.SelectedRow.Cells(3).Text
            txtphone.Text = dgvCustomer.SelectedRow.Cells(4).Text
            ddlG.Text = dgvCustomer.SelectedRow.Cells(5).Text


            btnAction.Text = "Update"


        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True
            lblMessage.ForeColor = Color.Red
        End Try
    End Sub

End Class

