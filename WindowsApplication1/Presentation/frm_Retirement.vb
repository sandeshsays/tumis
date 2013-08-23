Public Class frm_Retirement

    Dim query As String
    Dim dt As DataTable

    Dim teacherid As Integer
    Dim dobnep As String
    Dim dobeng As String
    Dim retnep As String
    Dim reteng As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'common.NeptoEngDate(Me.TextBox1.Text, TextBox2, TextBox1)
        TextBox1.Text = common.engtonepalidate(TextBox2.Text)
    End Sub

    Private Sub frm_Retirement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        common.comboCollege(Me.ComboBox1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'If TypeOf (Me.ComboBox1.SelectedValue) Is System.Data.DataRowView Then Exit Sub
        Try
            'retirement date calculation
            'list all teachers' appointed date in BS
            'convert dates to AD
            'add 63 years to AD
            

           

            'retirement date calculation
            query = "select id,dob from teachers where status='1' " 'and collegeid = '"& ComboBox1.SelectedValue "'"
            dt = tudataDB.GetDataTable(query)
            If Not dt Is Nothing And dt.Rows.Count > 0 Then
                For Each row2 As DataRow In dt.Rows
                    Dim id As String = row2.Item("id")
                    Dim dob As String = row2.Item("dob")

                    If dob <> "/  /" Then
                        query = "SELECT DATEADD(yyyy,63,DOB)AS RETIREMENT_YEAR FROM teachers WHERE id='" & id & "'"
                        dt = tudataDB.GetDataTable(query)
                        If Not dt Is Nothing And dt.Rows.Count > 0 Then
                            For Each row3 As DataRow In dt.Rows
                                reteng = row3.Item("RETIREMENT_YEAR")
                                retnep = common.engtonepalidate(reteng)
                                'update DOB in database
                                query = "update teachers set retdate ='" & reteng & "', retdatenep='" & retnep & "' where id='" & teacherid & "'"
                                dt = tudataDB.GetDataTable(query)
                            Next
                        End If

                    End If

                  
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub

    'Private Sub age()

    'Dim strDOB As String
    'strDOB = txtDateOfBirth.TextDim intAge As Integer
    'intAge = Math.Floor(DateDiff(DateInterval.Month, DateValue(strDOB), Now()) / 12)
    'lblAge.Text = intAge

    'End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            query = "select id from teachers where status='1'" ' and collegeid='" & ComboBox1.SelectedValue & "'"
            dt = tudataDB.GetDataTable(query)
            If Not dt Is Nothing And dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    teacherid = row.Item("id")
                    query = "select dobnep from teachers where id = '" & teacherid & "'"
                    dt = tudataDB.GetDataTable(query)
                    If Not dt Is Nothing And dt.Rows.Count > 0 Then
                        For Each row1 As DataRow In dt.Rows
                            dobnep = row1.Item("dobnep")
                            If dobnep <> "/  /" Then
                                common.NeptoEngDate(dobnep, TextBox1, TextBox2) '
                                dobeng = TextBox1.Text
                            Else
                                dobeng = System.Data.SqlTypes.SqlDateTime.Null
                            End If
                            'update DOB in database
                            query = "update teachers set dob ='" & dobeng & "' where id='" & teacherid & "'"
                            dt = tudataDB.GetDataTable(query)
                        Next
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class