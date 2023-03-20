Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Data
Partial Class viewordered
    Inherits System.Web.UI.Page
    Dim Obj As New MyConnection
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim da As New SqlDataAdapter
    Sub FillOrders()
        Try
            If conn.State = Data.ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New SqlCommand("Select Orderid, cusomerfname, Foodn, qty,Price,Qty* price as Total,Orderdate from (Orders join Customer on Orders.customerid=Customer.customerid) join Food on Orders.fid=food.fid where Orders.customerid='" & Session("customerid") & "' and Orderstatus='Order' and Orderdate='" & System.DateTime.Today.ToShortDateString() & "'", conn)
            da = New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            gvOrderView.DataSource = dt
            gvOrderView.DataBind()

        Catch ex As Exception
            'lblMessage.Text = ex.Message
            'lblMessage.Visible = True
            'lblMessage.ForeColor = Color.Red

        End Try
    End Sub
    Protected Sub gvOrderView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvOrderView.SelectedIndexChanged
        Dim orderid As Integer = gvOrderView.SelectedRow.Cells(2).Text
        Dim qty As Single = gvOrderView.SelectedRow.Cells(5).Text
        If conn.State = Data.ConnectionState.Closed Then
            conn.Open()
        End If
        'qty += 1
        cmd = New SqlCommand("Update Orders set qty='" & qty + 1 & "'  where orderid='" & orderid & "'", conn)
        cmd.ExecuteNonQuery()
        FillOrders()
    End Sub
    Protected Sub gvOrderView_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs) Handles gvOrderView.SelectedIndexChanging

    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            conn = Obj.getConnection()
            FillOrders()
        Catch ex As Exception
            'lblMessage.Text = ex.Message
            'lblMessage.Visible = True

        End Try
    End Sub
End Class

