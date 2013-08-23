Imports System.Data.SqlClient

Public Class Dbo_CollegeDB

    Public Shared Function Add(ByVal Dbo_College As Dbo_College) As Boolean
        Dim connection As SqlConnection = tudataDB.GetConnection
        Dim insertProcedure As String = "[dbo].[sproc_CollegeInsert]"
        Dim insertCommand As New SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Name", Dbo_College.MName)
        insertCommand.Parameters.AddWithValue("@Address", Dbo_College.MAddress)
        insertCommand.Parameters.AddWithValue("@Affiliation", Dbo_College.MAffiliation)
        insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            connection.Open()
            insertCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As SqlException
            Throw ex
        Finally
            connection.Close()
        End Try
    End Function
End Class
