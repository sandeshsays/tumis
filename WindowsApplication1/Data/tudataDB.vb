Imports System.Data.SqlClient

Public Class tudataDB
    Public Shared Function GetConnection() As SqlConnection
        Dim connectionString As String = common.ReadFile("Sms@.@")
        '"Data Source=SANDESH-PC\SQLEXPRESS;Initial Catalog=tudata;Integrated Security=SSPI;" 'User ID=sa; Password=root;" '

        '"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=tudata;Integrated Security=SSPI;" 'User ID=sa; Password=root;" '
        Return New SqlConnection(connectionString)
    End Function

    Public Shared Sub CloseSqlConnection()
        Try
            GetConnection.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Shared Function GetDataTable(ByVal sqlQuery As String) As DataTable
        Try
            Dim sAdapter As New SqlDataAdapter(sqlQuery, GetConnection())
            Dim ds As New DataSet
            sAdapter.Fill(ds, "table1")
            sAdapter = Nothing
            CloseSqlConnection()
            Return ds.Tables("table1")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
