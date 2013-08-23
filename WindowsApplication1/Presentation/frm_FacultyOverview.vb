Public Class frm_FacultyOverview
    Dim query As String
    Dim dt As DataTable


    'Private Sub chkAllColleges_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    common.ClearTextBox(Me)
    '    common.ClearComboBox(Me)
    '    If chkAllColleges.Checked = True Then
    '        Me.tbTotalTeachers.Clear()
    '        Me.cbCollege.Enabled = False
    '        teacherscount1()
    '        staffcount1()
    '        common.comboSubjects(cbSubject)
    '        common.comboStaffDept(cbStaffDept)
    '    Else
    '        Me.tbTotalTeachers.Clear()
    '        Me.tbTotalStaff.Clear()
    '        Me.cbCollege.Enabled = True
    '        common.comboCollege(cbCollege)
    '        'teacherscount2()
    '    End If
    'End Sub

    Private Sub teacherscount1()
        query = "SELECT count(*) AS count FROM Teachers WHERE status='1'"
        dt = tudataDB.GetDataTable(query)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                Me.tbTotalTeachers.Text = row.Item("count")
                'Me.tbProfessor.Text = professor
            Next
        End If
    End Sub

    Private Sub staffcount1()
        query = "SELECT count(*) AS count FROM Staff WHERE status='1'"
        dt = tudataDB.GetDataTable(query)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                Me.tbTotalStaff.Text = row.Item("count")
                'Me.tbProfessor.Text = professor
            Next
        End If
    End Sub

    Private Sub teacherscount2()

        query = "SELECT count(*) AS count FROM Teachers WHERE status='1' and collegeid in(select id from colleges where faculty ='" & facultyid & "')"
        dt = tudataDB.GetDataTable(query)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                Me.tbTotalTeachers.Text = row.Item("count")
                'Me.tbProfessor.Text = professor
            Next
        End If
    End Sub


    Private Sub staffcount2()

        query = "SELECT count(*) AS count FROM staff WHERE status='1' and collegeid in(select id from colleges where faculty ='" & facultyid & "')"
        dt = tudataDB.GetDataTable(query)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                Me.tbTotalStaff.Text = row.Item("count")
                'Me.tbProfessor.Text = professor
            Next
        End If
    End Sub

    Private Sub cbCollege_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCollege.SelectedIndexChanged
        If TypeOf Me.cbCollege.SelectedValue Is System.Data.DataRowView Then Exit Sub
        'common.comboCollegeSubject(cbCollege.SelectedValue, cbSubject)
        'common.comboCollegeTeacherPost(cbCollege.SelectedValue, cbPost)
        facultyid = cbCollege.SelectedValue
        loadteacherpost()
        loadstaffpost()
        teacherscount2()
        staffcount2()
    End Sub

    Private Sub loadteacherpost()
        Dim dt As DataTable = tudataDB.GetDataTable("select distinct post from teachers where collegeid in(select id from colleges where faculty ='" & cbCollege.SelectedValue & "')")
        If Not dt Is Nothing Then
            For Each row As DataRow In dt.Rows
                Dim post As String = row.Item("post")
                Me.cbPost.Items.Add(post)
            Next
        End If
    End Sub

    Private Sub loadstaffpost()
        Dim dt As DataTable = tudataDB.GetDataTable("select distinct post from staff where collegeid in(select id from colleges where faculty ='" & cbCollege.SelectedValue & "')")
        If Not dt Is Nothing Then
            For Each row As DataRow In dt.Rows
                Dim post As String = row.Item("post")
                Me.cbStaffPost.Items.Add(post)
            Next
        End If
    End Sub

    Private Sub frm_overview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        common.comboFaculty(cbCollege)
        
        'common.comboSubject(cbCollege.SelectedValue, cbSubject)
        'common.comboTeacherPost(cbPost)
        'common.comboStaffPost(cbStaffPost)
    End Sub

    'Private Sub cbSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSubject.SelectedIndexChanged
    '    If TypeOf Me.cbSubject.SelectedValue Is System.Data.DataRowView Then Exit Sub
    '    If chkAllColleges.Checked = True Then
    '        getSubwiseTeacherCountAll()
    '    Else
    '        getSubwiseTeacherCount()
    '    End If
    'End Sub

    'Private Sub getSubwiseTeacherCount()

    '    query = "SELECT count(*) AS count FROM Teachers WHERE status='1' and collegeid='" & Me.cbCollege.SelectedValue & "' and teachingsubject='" & Me.cbSubject.Text & "'"
    '    dt = tudataDB.GetDataTable(query)
    '    If Not dt Is Nothing And dt.Rows.Count > 0 Then
    '        For Each row As DataRow In dt.Rows
    '            Me.tbTotSubject.Text = row.Item("count")
    '            'Me.tbProfessor.Text = professor
    '        Next
    '    End If
    'End Sub

    'Private Sub getSubwiseTeacherCountAll()

    '    query = "SELECT count(*) AS count FROM Teachers WHERE status='1' and teachingsubject='" & Me.cbSubject.Text & "'"
    '    dt = tudataDB.GetDataTable(query)
    '    If Not dt Is Nothing And dt.Rows.Count > 0 Then
    '        For Each row As DataRow In dt.Rows
    '            Me.tbTotSubject.Text = row.Item("count")
    '            'Me.tbProfessor.Text = professor
    '        Next
    '    End If
    'End Sub

    Private Sub cbPost_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPost.SelectedIndexChanged
        If TypeOf Me.cbPost.SelectedValue Is System.Data.DataRowView Then Exit Sub
        getPostwiseTeacherCount()
    End Sub

    Private Sub getPostwiseTeacherCount()

        query = "SELECT count(*) AS count FROM Teachers WHERE status='1' and collegeid in(select id from colleges where faculty ='" & facultyid & "') and post='" & Me.cbPost.Text & "'"
        dt = tudataDB.GetDataTable(query)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                Me.tbTotPost.Text = row.Item("count")
                'Me.tbProfessor.Text = professor
            Next
        End If
    End Sub

    'Private Sub getPostwiseTeacherCountAll()

    '    query = "SELECT count(*) AS count FROM Teachers WHERE status='1' and post='" & Me.cbPost.Text & "'"
    '    dt = tudataDB.GetDataTable(query)
    '    If Not dt Is Nothing And dt.Rows.Count > 0 Then
    '        For Each row As DataRow In dt.Rows
    '            Me.tbTotPost.Text = row.Item("count")
    '            'Me.tbProfessor.Text = professor
    '        Next
    '    End If
    'End Sub

    'Private Sub cbStaffDept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbStaffDept.SelectedIndexChanged
    '    If TypeOf Me.cbStaffDept.SelectedValue Is System.Data.DataRowView Then Exit Sub
    '    If chkAllColleges.Checked = True Then
    '        getDeptwiseStaffCountAll()
    '    Else
    '        getDeptwiseStaffCount()
    '    End If
    'End Sub

    'Private Sub getDeptwiseStaffCount()

    '    query = "SELECT count(*) AS count FROM staff WHERE status='1' and collegeid='" & Me.cbCollege.SelectedValue & "' and department='" & Me.cbPost.Text & "'"
    '    dt = tudataDB.GetDataTable(query)
    '    If Not dt Is Nothing And dt.Rows.Count > 0 Then
    '        For Each row As DataRow In dt.Rows
    '            Me.tbStaffDept.Text = row.Item("count")
    '            'Me.tbProfessor.Text = professor
    '        Next
    '    End If
    'End Sub

    'Private Sub getDeptwiseStaffCountAll()

    '    query = "SELECT count(*) AS count FROM Teachers WHERE status='1' and department='" & Me.cbPost.Text & "'"
    '    dt = tudataDB.GetDataTable(query)
    '    If Not dt Is Nothing And dt.Rows.Count > 0 Then
    '        For Each row As DataRow In dt.Rows
    '            Me.tbStaffDept.Text = row.Item("count")
    '            'Me.tbProfessor.Text = professor
    '        Next
    '    End If
    'End Sub

    Private Sub cbStaffPost_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbStaffPost.SelectedIndexChanged
        If TypeOf Me.cbStaffPost.SelectedValue Is System.Data.DataRowView Then Exit Sub
       getPostwiseStaffCount()
    End Sub

    Private Sub getPostwiseStaffCount()

        query = "SELECT count(*) AS count FROM staff WHERE status='1' and collegeid in(select id from colleges where faculty ='" & facultyid & "') and post='" & Me.cbStaffPost.Text & "'"
        dt = tudataDB.GetDataTable(query)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                Me.tbStaffPost.Text = row.Item("count")
                'Me.tbProfessor.Text = professor
            Next
        End If
    End Sub

    'Private Sub getPostwiseStaffCountAll()

    '    query = "SELECT count(*) AS count FROM staff WHERE status='1' and post='" & Me.cbStaffPost.Text & "'"
    '    dt = tudataDB.GetDataTable(query)
    '    If Not dt Is Nothing And dt.Rows.Count > 0 Then
    '        For Each row As DataRow In dt.Rows
    '            Me.tbStaffPost.Text = row.Item("count")
    '            'Me.tbProfessor.Text = professor
    '        Next
    '    End If
    'End Sub

    Private Sub chkRange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRange.CheckedChanged
        If chkRange.Checked = True Then
            Me.tbRetYear.Clear()
            Me.tbRetYear.Enabled = False
            Me.tbYearFrom.Clear()
            Me.tbYearFrom.Enabled = True
            Me.tbYearTo.Clear()
            Me.tbYearTo.Enabled = True
        Else
            Me.tbRetYear.Clear()
            Me.tbRetYear.Enabled = True
            Me.tbYearFrom.Clear()
            Me.tbYearFrom.Enabled = False
            Me.tbYearTo.Clear()
            Me.tbYearTo.Enabled = False
        End If
    End Sub

    

    Private Sub btnRetTeachersList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetTeachersList.Click
        retirelist = 0
        facultyid = cbCollege.SelectedValue
        If chkRange.Checked = False Then
            singleYear = 1
            year = tbRetYear.Text
        Else
            multiYear = 1
            year1 = tbYearFrom.Text
            year2 = tbYearTo.Text
        End If
        frm_RetireList.ShowDialog()
    End Sub

    Private Sub btnRetStaffList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetStaffList.Click
        retirelist = 1
        facultyid = cbCollege.SelectedValue

        If chkRange.Checked = False Then
            singleYear = 1
            year = tbRetYear.Text
        Else
            multiYear = 1
            year1 = tbYearFrom.Text
            year2 = tbYearTo.Text
        End If
        frm_RetireList.ShowDialog()
    End Sub

    
    
    Private Sub btnRetire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetire.Click
        If chkRange.Checked = True Then
            'year range
            If tbYearFrom.Text = Nothing Or tbYearTo.Text = Nothing Then
                MsgBox("Enter a range of years.", MsgBoxStyle.Information)
                tbYearFrom.Focus()
            Else
                Dim yearfrom As Integer = Me.tbYearFrom.Text
                Dim yearto As Integer = Me.tbYearTo.Text
                Dim year As Integer = yearfrom
                Dim yeardiff As Integer = yearto - yearfrom
                Dim teacherCount As Integer = 0
                Dim staffCount As Integer = 0

                If yeardiff > 0 Then
                    'show counts
                    Dim collegeid = Me.cbCollege.SelectedValue
                    For i As Integer = 0 To yeardiff
                        year = year + i
                        'show teacher count
                        Dim sql1 As String = "select count(*) as total from teachers where retdatenep like '%" & year & "' and status ='1' and collegeid in(select id from colleges where faculty ='" & facultyid & "')"
                        Dim dt1 As DataTable = tudataDB.GetDataTable(sql1)
                        If Not dt1 Is Nothing And dt1.Rows.Count > 0 Then
                            For Each row1 As DataRow In dt1.Rows
                                Dim total As Integer = row1.Item("total")
                                teacherCount = teacherCount + total
                            Next
                        End If
                        'show staff count
                        Dim sql2 As String = "select count(*) as total from staff where retdatenep like '%" & year & "' and status ='1' and collegeid in(select id from colleges where faculty ='" & facultyid & "')"
                        Dim dt2 As DataTable = tudataDB.GetDataTable(sql2)
                        If Not dt1 Is Nothing And dt1.Rows.Count > 0 Then
                            For Each row2 As DataRow In dt2.Rows
                                Dim total As Integer = row2.Item("total")
                                staffCount = staffCount + total
                            Next
                        End If
                    Next
                    tbRetTeachers.Text = teacherCount
                    tbRetStaff.Text = staffCount
                Else
                    'input error
                    MsgBox("Enter correct years.", MsgBoxStyle.Information)
                    Exit Sub
                End If

            End If
        Else
            'single year
            If tbRetYear.Text = Nothing Then
                MsgBox("Enter a year.", MsgBoxStyle.Information)
                tbRetYear.Focus()
                Exit Sub
            Else
                Dim collegeid As Integer = cbCollege.SelectedValue
                If collegeid = 0 Then
                    MsgBox("Select a faculty.", MsgBoxStyle.Information)
                    cbCollege.Focus()
                    Exit Sub
                End If
                'show teacher counts
                Dim sql1 As String = "select count(*) as total from teachers where retdatenep like '%" & tbRetYear.Text & "' and status ='1' and collegeid in(select id from colleges where faculty ='" & facultyid & "')"
                Dim dt1 As DataTable = tudataDB.GetDataTable(sql1)
                If Not dt1 Is Nothing And dt1.Rows.Count > 0 Then
                    For Each row1 As DataRow In dt1.Rows
                        Me.tbRetTeachers.Text = row1.Item("total")
                    Next
                End If
                'show staff counts
                Dim sql2 As String = "select count(*) as total from staff where retdatenep like '%" & tbRetYear.Text & "' and status ='1' and collegeid in(select id from colleges where faculty ='" & facultyid & "')"
                Dim dt2 As DataTable = tudataDB.GetDataTable(sql2)
                If Not dt2 Is Nothing And dt2.Rows.Count > 0 Then
                    For Each row2 As DataRow In dt2.Rows
                        Me.tbRetStaff.Text = row2.Item("total")
                    Next
                End If
            End If
        End If
    End Sub
End Class