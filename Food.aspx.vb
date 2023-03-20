Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Data
Partial Class food
    Inherits System.Web.UI.Page
    Dim Obj As New MyConnection
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim da As New SqlDataAdapter

    Sub Counter()
        If Session("count") <> 0 Then
            lblCounter.Text = Session("count")
        Else
            lblCounter.Text = "0"
        End If

    End Sub

    Protected Sub btnSave1_Click(sender As Object, e As EventArgs) Handles btnSave1.Click
        If conn.State = Data.ConnectionState.Closed Then
            conn.Open()
        End If
        cmd = New SqlCommand("Select fid from food where foodN='" & lblFoodName1.Text & "' ", conn)
        Dim fid As Integer = cmd.ExecuteScalar
        cmd = New SqlCommand("Select fprice from food where foodN='" & lblFoodName1.Text & "' ", conn)
        Dim price As Decimal = cmd.ExecuteScalar

        cmd = New SqlCommand("insert into orders values('" & Session("customerid") & "','" & fid & "','" & 1 & "','" & price & "','" & System.DateTime.Today.ToShortDateString() & "','" & "Order" & "')", conn)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("Select Count(Customerid) from Orders where Customerid='" & Session("customerid") & "' and Orderdate='" & System.DateTime.Today.ToShortDateString() & "' and Orderstatus='" & "Order" & "' ", conn)
        Session("count") = cmd.ExecuteScalar()
        Counter()
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            conn = Obj.getConnection()
            'Session("customerid") = 2

            lblCounter.Text = "0"
            Session("count") = "0"
            'If Not IsPostBack Then
            '    Counter()
            'Else
            '    lblCounter.Text = "0"
            '    Session("count") = "0"
            'End If
        Catch ex As Exception
            'lblMessage.Text = ex.Message
            'lblMessage.Visible = True

        End Try
    End Sub
    Protected Sub btnSave2_Click(sender As Object, e As EventArgs) Handles btnSave2.Click
        If conn.State = Data.ConnectionState.Closed Then
            conn.Open()
        End If
        cmd = New SqlCommand("Select fid from food where foodN='" & lblFoodName2.Text & "' ", conn)
        Dim fid As Integer = cmd.ExecuteScalar
        cmd = New SqlCommand("Select fprice from food where foodN='" & lblFoodName2.Text & "' ", conn)
        Dim price As Decimal = cmd.ExecuteScalar
        cmd = New SqlCommand("insert into orders values('" & Session("customerid") & "','" & fid & "','" & 1 & "','" & price & "','" & System.DateTime.Today.ToShortDateString() & "','" & "Order" & "')", conn)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("Select Count(Customerid) from Orders where Customerid='" & Session("customerid") & "' and Orderdate='" & System.DateTime.Today.ToShortDateString() & "' and Orderstatus='" & "Order" & "' ", conn)
        Session("count") = cmd.ExecuteScalar()
        Counter()
    End Sub

    Protected Sub btnSave3_Click(sender As Object, e As EventArgs) Handles btnSave3.Click
        If conn.State = Data.ConnectionState.Closed Then
            conn.Open()
        End If

        cmd = New SqlCommand("insert into orders values('" & Session("customerid") & "','" & 101 & "','" & 1 & "','" & 10 & "','" & System.DateTime.Today.ToShortDateString() & "','" & "Order" & "')", conn)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("Select Count(Customerid) from Orders where Customerid='" & Session("customerid") & "' and Orderdate='" & System.DateTime.Today.ToShortDateString() & "' and Orderstatus='" & "Order" & "' ", conn)
        Session("count") = cmd.ExecuteScalar()
        Counter()
    End Sub
    Protected Sub btnSave4_Click(sender As Object, e As EventArgs) Handles btnSave4.Click
        If conn.State = Data.ConnectionState.Closed Then
            conn.Open()
        End If

        cmd = New SqlCommand("insert into orders values('" & Session("customerid") & "','" & 101 & "','" & 1 & "','" & 10 & "','" & System.DateTime.Today.ToShortDateString() & "','" & "Order" & "')", conn)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("Select Count(Customerid) from Orders where Customerid='" & Session("customerid") & "' and Orderdate='" & System.DateTime.Today.ToShortDateString() & "' and Orderstatus='" & "Order" & "' ", conn)
        Session("count") = cmd.ExecuteScalar()
        Counter()
    End Sub


    Protected Sub btnSave9_Click(sender As Object, e As EventArgs) Handles btnSave9.Click
        If conn.State = Data.ConnectionState.Closed Then
            conn.Open()
        End If

        cmd = New SqlCommand("insert into orders values('" & Session("customerid") & "','" & 101 & "','" & 1 & "','" & 10 & "','" & System.DateTime.Today.ToShortDateString() & "','" & "Order" & "')", conn)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("Select Count(Customerid) from Orders where Customerid='" & Session("customerid") & "' and Orderdate='" & System.DateTime.Today.ToShortDateString() & "' and Orderstatus='" & "Order" & "' ", conn)
        Session("count") = cmd.ExecuteScalar()
        Counter()
    End Sub
    Protected Sub btnSave5_Click(sender As Object, e As EventArgs) Handles btnSave5.Click
        If conn.State = Data.ConnectionState.Closed Then
            conn.Open()
        End If

        cmd = New SqlCommand("insert into orders values('" & Session("customerid") & "','" & 101 & "','" & 1 & "','" & 10 & "','" & System.DateTime.Today.ToShortDateString() & "','" & "Order" & "')", conn)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("Select Count(Customerid) from Orders where Customerid='" & Session("customerid") & "' and Orderdate='" & System.DateTime.Today.ToShortDateString() & "' and Orderstatus='" & "Order" & "' ", conn)
        Session("count") = cmd.ExecuteScalar()
        Counter()
    End Sub
    Protected Sub btnSave6_Click(sender As Object, e As EventArgs) Handles btnSave6.Click
        If conn.State = Data.ConnectionState.Closed Then
            conn.Open()
        End If

        cmd = New SqlCommand("insert into orders values('" & Session("customerid") & "','" & 101 & "','" & 1 & "','" & 10 & "','" & System.DateTime.Today.ToShortDateString() & "','" & "Order" & "')", conn)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("Select Count(Customerid) from Orders where Customerid='" & Session("customerid") & "' and Orderdate='" & System.DateTime.Today.ToShortDateString() & "' and Orderstatus='" & "Order" & "' ", conn)
        Session("count") = cmd.ExecuteScalar()
        Counter()
    End Sub
    Protected Sub btnSave7_Click(sender As Object, e As EventArgs) Handles btnSave7.Click
        If conn.State = Data.ConnectionState.Closed Then
            conn.Open()
        End If

        cmd = New SqlCommand("insert into orders values('" & Session("customerid") & "','" & 101 & "','" & 1 & "','" & 10 & "','" & System.DateTime.Today.ToShortDateString() & "','" & "Order" & "')", conn)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("Select Count(Customerid) from Orders where Customerid='" & Session("customerid") & "' and Orderdate='" & System.DateTime.Today.ToShortDateString() & "' and Orderstatus='" & "Order" & "' ", conn)
        Session("count") = cmd.ExecuteScalar()
        Counter()
    End Sub
    Protected Sub btnSave8_Click(sender As Object, e As EventArgs) Handles btnSave8.Click
        If conn.State = Data.ConnectionState.Closed Then
            conn.Open()
        End If

        cmd = New SqlCommand("insert into orders values('" & Session("customerid") & "','" & 101 & "','" & 1 & "','" & 10 & "','" & System.DateTime.Today.ToShortDateString() & "','" & "Order" & "')", conn)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("Select Count(Customerid) from Orders where Customerid='" & Session("customerid") & "' and Orderdate='" & System.DateTime.Today.ToShortDateString() & "' and Orderstatus='" & "Order" & "' ", conn)
        Session("count") = cmd.ExecuteScalar()
        Counter()
    End Sub
End Class

