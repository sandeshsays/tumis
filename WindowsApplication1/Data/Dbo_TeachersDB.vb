Imports System.Data.SqlClient

Public Class Dbo_TeachersDB
    Public Shared Function Add(ByVal Dbo_Teachers As Dbo_Teachers) As Boolean
        Dim connection As SqlConnection = tudataDB.GetConnection
        Dim insertProcedure As String = "[dbo].[sproc_TeacherInsert]"
        Dim insertCommand As New SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure

        insertCommand.Parameters.AddWithValue("@Name", Dbo_Teachers.MName)
        insertCommand.Parameters.AddWithValue("@Address", Dbo_Teachers.MAddress)
        insertCommand.Parameters.AddWithValue("@Gender", Dbo_Teachers.MGender)
        insertCommand.Parameters.AddWithValue("@Dob", Dbo_Teachers.MDob)
        insertCommand.Parameters.AddWithValue("@Dobnep", Dbo_Teachers.MDobnep)
        insertCommand.Parameters.AddWithValue("@Post", Dbo_Teachers.MPost)
        insertCommand.Parameters.AddWithValue("@Emptype", Dbo_Teachers.MEmptype)
        insertCommand.Parameters.AddWithValue("@Sertype", Dbo_Teachers.MSertype)
        insertCommand.Parameters.AddWithValue("@Appdate", Dbo_Teachers.MAppdate)
        insertCommand.Parameters.AddWithValue("@Appdatenep", Dbo_Teachers.MAppdatenep)
        insertCommand.Parameters.AddWithValue("@Serduration", Dbo_Teachers.MSerduration)
        insertCommand.Parameters.AddWithValue("@Retdate", Dbo_Teachers.MRetdate)
        insertCommand.Parameters.AddWithValue("@Retdatenep", Dbo_Teachers.MRetdatenep)
        insertCommand.Parameters.AddWithValue("@Leavetype", Dbo_Teachers.MLeavetype)
        insertCommand.Parameters.AddWithValue("@Department", Dbo_Teachers.MDepartment)
        insertCommand.Parameters.AddWithValue("@Training", Dbo_Teachers.MTraining)
        insertCommand.Parameters.AddWithValue("@Status", Dbo_Teachers.MStatus)
        insertCommand.Parameters.AddWithValue("@Collegeid", Dbo_Teachers.MCollegeid)
        insertCommand.Parameters.AddWithValue("@Fieldofstudy", Dbo_Teachers.MFieldofstudy)
        'insertCommand.Parameters.AddWithValue("@Monthlywtg", Dbo_Teachers.MMonthlywtg)
        insertCommand.Parameters.AddWithValue("@Monthlywtgextra", Dbo_Teachers.MMonthlywtgextra)
        insertCommand.Parameters.AddWithValue("@Qualification", Dbo_Teachers.MQualification)
        insertCommand.Parameters.AddWithValue("@Specialization", Dbo_Teachers.MSpecialization)
        insertCommand.Parameters.AddWithValue("@Teachinglevel", Dbo_Teachers.MTeachinglevel)
        insertCommand.Parameters.AddWithValue("@Teachingsubject", Dbo_Teachers.MTeachingsubject)
        insertCommand.Parameters.AddWithValue("@Wages", Dbo_Teachers.MWages)
        insertCommand.Parameters.AddWithValue("@Weeklywtg", Dbo_Teachers.MWeeklywtg)

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

    Public Shared Function Update(ByVal oldDbo_Teachers As Dbo_Teachers, _
          ByVal newDbo_Teachers As Dbo_Teachers) As Boolean
        Dim connection As SqlConnection = tudataDB.GetConnection
        Dim updateProcedure As String = "[dbo].[sproc_TeacherUpdate]"
        Dim updateCommand As New SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure

        updateCommand.Parameters.AddWithValue("@Name", newDbo_Teachers.MName)
        updateCommand.Parameters.AddWithValue("@Address", newDbo_Teachers.MAddress)
        updateCommand.Parameters.AddWithValue("@Gender", newDbo_Teachers.MGender)
        updateCommand.Parameters.AddWithValue("@Dob", newDbo_Teachers.MDob)
        updateCommand.Parameters.AddWithValue("@Dobnep", newDbo_Teachers.MDobnep)
        updateCommand.Parameters.AddWithValue("@Post", newDbo_Teachers.MPost)
        updateCommand.Parameters.AddWithValue("@Emptype", newDbo_Teachers.MEmptype)
        updateCommand.Parameters.AddWithValue("@Sertype", newDbo_Teachers.MSertype)
        updateCommand.Parameters.AddWithValue("@Appdate", newDbo_Teachers.MAppdate)
        updateCommand.Parameters.AddWithValue("@Appdatenep", newDbo_Teachers.MAppdatenep)
        updateCommand.Parameters.AddWithValue("@Serduration", newDbo_Teachers.MSerduration)
        updateCommand.Parameters.AddWithValue("@Retdate", newDbo_Teachers.MRetdate)
        updateCommand.Parameters.AddWithValue("@Retdatenep", newDbo_Teachers.MRetdatenep)
        updateCommand.Parameters.AddWithValue("@Leavetype", newDbo_Teachers.MLeavetype)
        updateCommand.Parameters.AddWithValue("@Department", newDbo_Teachers.MDepartment)
        updateCommand.Parameters.AddWithValue("@Training", newDbo_Teachers.MTraining)
        updateCommand.Parameters.AddWithValue("@Status", newDbo_Teachers.MStatus)
        updateCommand.Parameters.AddWithValue("@Collegeid", newDbo_Teachers.MCollegeid)
        updateCommand.Parameters.AddWithValue("@Fieldofstudy", newDbo_Teachers.MFieldofstudy)
        'updateCommand.Parameters.AddWithValue("@Monthlywtg", Dbo_Teachers.MMonthlywtg)
        updateCommand.Parameters.AddWithValue("@Monthlywtgextra", newDbo_Teachers.MMonthlywtgextra)
        updateCommand.Parameters.AddWithValue("@Qualification", newDbo_Teachers.MQualification)
        updateCommand.Parameters.AddWithValue("@Specialization", newDbo_Teachers.MSpecialization)
        updateCommand.Parameters.AddWithValue("@Teachinglevel", newDbo_Teachers.MTeachinglevel)
        updateCommand.Parameters.AddWithValue("@Teachingsubject", newDbo_Teachers.MTeachingsubject)
        updateCommand.Parameters.AddWithValue("@Wages", newDbo_Teachers.MWages)
        updateCommand.Parameters.AddWithValue("@Weeklywtg", newDbo_Teachers.MWeeklywtg)


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
