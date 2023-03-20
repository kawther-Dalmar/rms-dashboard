Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Data
Partial Class Store_Food
    Inherits System.Web.UI.Page
    Dim Obj As New MyConnection
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim da As New SqlDataAdapter

    Sub clear()
        txtfoodname.Text = " "
        ddlfood.SelectedIndex = 0
        txtprice.Text = " "
    End Sub

    Sub FillFoodGridView()
        Try
            If conn.State = Data.ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New SqlCommand("Select *from food", conn)
            da = New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvFood.DataSource = dt
            dgvFood.DataBind()

        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True
            lblMessage.ForeColor = Color.Red

        End Try
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            conn = Obj.getConnection()
            FillFoodGridView()
        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True

        End Try
    End Sub
    Protected Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If conn.State = Data.ConnectionState.Closed Then
                conn.Open()
            End If

            If btnSave.Text = "Save" Then

                'cheking username
                cmd = New SqlCommand("select foodN from food where foodN='" & txtfoodname.Text & "' ", conn)
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    lblMessage.Text = "This User Name has Already been exist"
                    lblMessage.Visible = True
                    lblMessage.ForeColor = Color.Red
                    dr.Close()
                    txtfoodname.Text = ""
                    Return

                End If
                dr.Close()
                cmd = New SqlCommand("select ISNULL (max(fid),100) +1 from food", conn)
                Dim id As Integer = cmd.ExecuteScalar()
                cmd = New SqlCommand("insert into food values('" & id & "', '" & txtfoodname.Text & "','" & ddlfood.Text & "','" & txtprice.Text & "')", conn)

                If cmd.ExecuteNonQuery() > 0 Then
                    Response.Write("<script>alert('" & "Food information has been Saved" & "')</script")

                End If


            End If

            FillFoodGridView()
            clear()
        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True
            lblMessage.ForeColor = Color.Red
        End Try
    End Sub
    Protected Sub dgvFood_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgvFood.SelectedIndexChanged
        Try
            txtfoodname.Text = dgvFood.SelectedRow.Cells(2).Text
            ddlfood.Text = dgvFood.SelectedRow.Cells(3).Text
            txtprice.Text = dgvFood.SelectedRow.Cells(4).Text



        Catch ex As Exception
            lblMessage.Text = ex.Message
            lblMessage.Visible = True
            lblMessage.ForeColor = Color.Red
        End Try
    End Sub
End Class

