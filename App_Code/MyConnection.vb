Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class MyConnection
    Public Function getConnection() As SqlConnection
        Dim conn As New SqlConnection("server=DESKTOP-C7IHP4O\KAUTAHAR;database=MYdb;integrated security=true")
        Return conn
    End Function

End Class
