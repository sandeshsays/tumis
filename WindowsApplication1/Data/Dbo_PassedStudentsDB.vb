Imports System.Data.SqlClient

Public Class Dbo_PassedStudentsDB
    Public Shared Function Add(ByVal Dbo_PassedStudents As Dbo_PassedStudents) As Boolean
        Dim connection As SqlConnection = tudataDB.GetConnection
        Dim insertProcedure As String = "[dbo].[sproc_PassedStudentsInsert]"
        Dim insertCommand As New SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure

        insertCommand.Parameters.AddWithValue("@year", Dbo_PassedStudents.MYear)
        insertCommand.Parameters.AddWithValue("@level", Dbo_PassedStudents.MLevel)
        insertCommand.Parameters.AddWithValue("@part", Dbo_PassedStudents.MPart)
        insertCommand.Parameters.AddWithValue("@male", Dbo_PassedStudents.MMale)
        insertCommand.Parameters.AddWithValue("@female", Dbo_PassedStudents.MFemale)
        insertCommand.Parameters.AddWithValue("@total", Dbo_PassedStudents.MTotal)

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

    Public Shared Function Update(ByVal oldDbo_PassedStudents As Dbo_PassedStudents, _
          ByVal newDbo_PassedStudents As Dbo_PassedStudents) As Boolean
        Dim connection As SqlConnection = tudataDB.GetConnection
        Dim updateProcedure As String = "[dbo].[sproc_PassedStudentsUpdate]"
        Dim updateCommand As New SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure

        updateCommand.Parameters.AddWithValue("@year", newDbo_PassedStudents.MYear)
        updateCommand.Parameters.AddWithValue("@level", newDbo_PassedStudents.MLevel)
        updateCommand.Parameters.AddWithValue("@part", newDbo_PassedStudents.MPart)
        updateCommand.Parameters.AddWithValue("@male", newDbo_PassedStudents.MMale)
        updateCommand.Parameters.AddWithValue("@female", newDbo_PassedStudents.MFemale)
        updateCommand.Parameters.AddWithValue("@total", newDbo_PassedStudents.MTotal)

        updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            connection.Open()
            updateCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(updateCommand.Parameters("@ReturnValue").Value)
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
