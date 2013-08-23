Imports System.Data.SqlClient

Public Class Dbo_AppointmentsDB
    Public Shared Function Add(ByVal Dbo_Appointments As Dbo_Appointments) As Boolean
        Dim connection As SqlConnection = tudataDB.GetConnection
        Dim insertProcedure As String = "[dbo].[sproc_AppointmentsInsert]"
        Dim insertCommand As New SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure

        insertCommand.Parameters.AddWithValue("@CollegeId", Dbo_Appointments.MCollegeId)
        insertCommand.Parameters.AddWithValue("@Fyear", Dbo_Appointments.MFyear)
        insertCommand.Parameters.AddWithValue("@Category", Dbo_Appointments.MCategory)
        insertCommand.Parameters.AddWithValue("@SubCategory", Dbo_Appointments.MSubCat)
        insertCommand.Parameters.AddWithValue("@Post", Dbo_Appointments.MPost)
        insertCommand.Parameters.AddWithValue("@Subject", Dbo_Appointments.MSubject)
        insertCommand.Parameters.AddWithValue("@Number", Dbo_Appointments.MNumber)
        
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
