Imports System.Data.SqlClient

Public Class rpt_TeachersList

    Private Sub rpt_TeachersList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rpt As New TeacherList() 'TermResult2() 'The report you created.
        Dim myConnection As SqlConnection
        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Dim myDS As New tudataDataSet() 'schoolDataSet_ResultReport() 'The DataSet you created.
        Try
            myConnection = New SqlConnection(tudataDB.GetConnection.ConnectionString)
            MyCommand.Connection = myConnection
            ''''''''''''''''''''
            MyCommand.CommandText = "SELECT * FROM Teachers;"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "Teachers")
            ''''''''''''''''''''
            rpt.SetDataSource(myDS)
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception

        End Try
    End Sub
End Class