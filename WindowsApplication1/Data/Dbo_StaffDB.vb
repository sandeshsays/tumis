Imports System.Data.SqlClient

Public Class Dbo_StaffDB
    Public Shared Function Add(ByVal Dbo_Staff As Dbo_Staff) As Boolean
        Dim connection As SqlConnection = tudataDB.GetConnection
        Dim insertProcedure As String = "[dbo].[sproc_StaffInsert]"
        Dim insertCommand As New SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Name", Dbo_Staff.MName)
        insertCommand.Parameters.AddWithValue("@Address", Dbo_Staff.MAddress)
        insertCommand.Parameters.AddWithValue("@Gender", Dbo_Staff.MGender)
        insertCommand.Parameters.AddWithValue("@Dob", Dbo_Staff.MDob)
        insertCommand.Parameters.AddWithValue("@Dobnep", Dbo_Staff.MDobnep)
        insertCommand.Parameters.AddWithValue("@Post", Dbo_Staff.MPost)
        insertCommand.Parameters.AddWithValue("@Emptype", Dbo_Staff.MEmptype)
        insertCommand.Parameters.AddWithValue("@Sertype", Dbo_Staff.MSertype)
        insertCommand.Parameters.AddWithValue("@Appdate", Dbo_Staff.MAppdate)
        insertCommand.Parameters.AddWithValue("@Appdatenep", Dbo_Staff.MAppdatenep)
        insertCommand.Parameters.AddWithValue("@Serduration", Dbo_Staff.MSerduration)
        insertCommand.Parameters.AddWithValue("@Retdate", Dbo_Staff.MRetdate)
        insertCommand.Parameters.AddWithValue("@Retdatenep", Dbo_Staff.MRetdatenep)
        insertCommand.Parameters.AddWithValue("@Leavetype", Dbo_Staff.MLeavetype)
        insertCommand.Parameters.AddWithValue("@Department", Dbo_Staff.MDepartment)
        insertCommand.Parameters.AddWithValue("@Training", Dbo_Staff.MTraining)
        insertCommand.Parameters.AddWithValue("@Status", Dbo_Staff.MStatus)
        insertCommand.Parameters.AddWithValue("@Collegeid", Dbo_Staff.MCollegeid)
        insertCommand.Parameters.AddWithValue("@Promotion", Dbo_Staff.MPromotion)
        insertCommand.Parameters.AddWithValue("@Qualification", Dbo_Staff.MQualification)

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
