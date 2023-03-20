<%@ WebHandler Language="VB" Class="ShowImage" %>

Imports System
Imports System.Web
Imports System.Configuration

Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class ShowImage : Implements IHttpHandler

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Dim userid As Integer
        If Not context.Request.QueryString("id") Is Nothing Then
            userid = Convert.ToInt32(context.Request.QueryString("id"))
        Else
            Throw New ArgumentException("No parameter specified")
        End If

        context.Response.ContentType = "image/jpeg"
        Dim strm As Stream = ShowUserImage(userid)
        Dim buffer As Byte() = New Byte(4095) {}
        Dim byteSeq As Integer = strm.Read(buffer, 0, 4096)

        Do While byteSeq > 0
            context.Response.OutputStream.Write(buffer, 0, byteSeq)
            byteSeq = strm.Read(buffer, 0, 4096)
        Loop
        'context.Response.BinaryWrite(buffer);
    End Sub
    Public Function ShowUserImage(ByVal userid As Integer) As Stream
        Dim con As New SqlConnection
        Dim objcon As New MyConnection
        con = objcon.getConnection()
        Dim sql As String = "Select photo from Users where Userid = @ID"
        Dim cmd As SqlCommand = New SqlCommand(sql, con)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@ID", userid)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim img As Object = cmd.ExecuteScalar()
        Try
            Return New MemoryStream(CType(img, Byte()))
        Catch
            Return Nothing

        End Try
    End Function


    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property


End Class