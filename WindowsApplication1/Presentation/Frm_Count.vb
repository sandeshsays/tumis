Public Class Frm_Count

    Dim sql As String = Nothing
    Dim dt As DataTable = Nothing
    Dim professor As Double = 0
    Dim a_professor As Double = 0
    Dim lecturer As Double = 0
    Dim a_lecturer As Double = 0
    Dim instructor As Double = 0
    Dim t_others As Double = 0
    Dim chiefadmin As Double = 0
    Dim admin As Double = 0
    Dim d_admin As Double = 0
    Dim a_d_admin As Double = 0
    Dim a_admin As Double = 0
    Dim h_assistant As Double = 0
    Dim s_others As Double = 0
    Dim p_professor As Double = 0
    Dim p_a_professor As Double = 0
    Dim p_lecturer As Double = 0
    Dim p_a_lecturer As Double = 0
    Dim p_instructor As Double = 0
    Dim p_t_others As Double = 0
    Dim p_chiefadmin As Double = 0
    Dim p_admin As Double = 0
    Dim p_d_admin As Double = 0
    Dim p_a_d_admin As Double = 0
    Dim p_a_admin As Double = 0
    Dim p_h_assistant As Double = 0
    Dim p_s_others As Double = 0
    Dim teachers As Double = 0
    Dim staff As Double = 0
    Dim per As Double = 0


    Private Sub cbCollege_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCollege.SelectedIndexChanged
        If TypeOf (Me.cbCollege.SelectedValue) Is System.Data.DataRowView Then Exit Sub
        loadTeacherCount()
        loadStaffCount()
        stratio()
    End Sub

    Private Sub stratio()
        Me.tbRatio.Text = Math.Round(staff / teachers, 2)
    End Sub

    Private Sub loadTeacherCount()
        sql = "SELECT count(*) AS count FROM Teachers WHERE post='Professor' AND CollegeId = '" & Me.cbCollege.SelectedValue & "'"
        dt = tudataDB.GetDataTable(sql)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                professor = row.Item("count")
                Me.tbProfessor.Text = professor
            Next
        End If
        sql = "SELECT count(*) AS count FROM Teachers WHERE post='Associate Professor' AND CollegeId = '" & Me.cbCollege.SelectedValue & "'"
        dt = tudataDB.GetDataTable(sql)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                a_professor = row.Item("count")
                Me.tbAssociateProfessor.Text = a_professor
            Next
        End If
        sql = "SELECT count(*) AS count FROM Teachers WHERE post='Lecturer' AND CollegeId = '" & Me.cbCollege.SelectedValue & "'"
        dt = tudataDB.GetDataTable(sql)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                lecturer = row.Item("count")
                Me.tbLecturer.Text = lecturer
            Next
        End If
        sql = "SELECT count(*) AS count FROM Teachers WHERE post='Assistant Lecturer' AND CollegeId = '" & Me.cbCollege.SelectedValue & "'"
        dt = tudataDB.GetDataTable(sql)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                a_lecturer = row.Item("count")
                Me.tbAssistantLecturer.Text = a_lecturer
            Next
        End If
        sql = "SELECT count(*) AS count FROM Teachers WHERE post='Instructor' AND CollegeId = '" & Me.cbCollege.SelectedValue & "'"
        dt = tudataDB.GetDataTable(sql)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                instructor = row.Item("count")
                Me.tbInstructor.Text = instructor
            Next
        End If
        sql = "SELECT count(*) AS count FROM Teachers WHERE post='Others' AND CollegeId = '" & Me.cbCollege.SelectedValue & "'"
        dt = tudataDB.GetDataTable(sql)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                t_others = row.Item("count")
                Me.tbOthers.Text = t_others
            Next
        End If
        teachers = professor + a_professor + lecturer + a_lecturer + instructor + t_others
        Me.tbTotalTeachers.Text = teachers

        '//Calculate Percentages
        Dim percent1 As Double = 0

        per = (professor / teachers) * 100
        Me.tbPProfessor.Text = Math.Round(per, 2)
        percent1 = percent1 + per

        per = (a_professor / teachers) * 100
        Me.tbPAssociateProfessor.Text = Math.Round(per, 2)
        percent1 = percent1 + per

        per = (lecturer / teachers) * 100
        Me.tbPLecturer.Text = Math.Round(per, 2)
        percent1 = percent1 + per

        per = (a_lecturer / teachers) * 100
        Me.tbPAssistantLecturer.Text = Math.Round(per, 2)
        percent1 = percent1 + per

        per = (instructor / teachers) * 100
        Me.tbPInstructor.Text = Math.Round(per, 2)
        percent1 = percent1 + per

        per = (t_others / teachers) * 100
        Me.tbPOthers.Text = Math.Round(per, 2)
        percent1 = percent1 + per

        Me.tbPTotal.Text = Math.Round(percent1, 0)
    End Sub

    Private Sub loadStaffCount()
        sql = "SELECT count(*) AS count FROM Staff WHERE post='Chief Administrator' AND CollegeId = '" & Me.cbCollege.SelectedValue & "'"
        dt = tudataDB.GetDataTable(sql)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                chiefadmin = row.Item("count")
                Me.tbChiefAdmin.Text = chiefadmin
            Next
        End If
        sql = "SELECT count(*) AS count FROM Staff WHERE post='Administrator' AND CollegeId = '" & Me.cbCollege.SelectedValue & "'"
        dt = tudataDB.GetDataTable(sql)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                admin = row.Item("count")
                Me.tbAdmin.Text = admin
            Next
        End If
        sql = "SELECT count(*) AS count FROM Staff WHERE post='Deputy Administrator' AND CollegeId = '" & Me.cbCollege.SelectedValue & "'"
        dt = tudataDB.GetDataTable(sql)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                d_admin = row.Item("count")
                Me.tbDAdmin.Text = d_admin
            Next
        End If
        sql = "SELECT count(*) AS count FROM Staff WHERE post='Assistant Deputy Administrator' AND CollegeId = '" & Me.cbCollege.SelectedValue & "'"
        dt = tudataDB.GetDataTable(sql)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                a_d_admin = row.Item("count")
                Me.tbADAdmin.Text = a_d_admin
            Next
        End If
        sql = "SELECT count(*) AS count FROM Staff WHERE post='Assistant Administrator' AND CollegeId = '" & Me.cbCollege.SelectedValue & "'"
        dt = tudataDB.GetDataTable(sql)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                a_admin = row.Item("count")
                Me.tbAAdmin.Text = a_admin
            Next
        End If
        sql = "SELECT count(*) AS count FROM Staff WHERE post='Head Assistant' AND CollegeId = '" & Me.cbCollege.SelectedValue & "'"
        dt = tudataDB.GetDataTable(sql)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                h_assistant = row.Item("count")
                Me.tbHeadAssistant.Text = h_assistant
            Next
        End If
        sql = "SELECT count(*) AS count FROM Staff WHERE post='Others' AND CollegeId = '" & Me.cbCollege.SelectedValue & "'"
        dt = tudataDB.GetDataTable(sql)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                s_others = row.Item("count")
                Me.tbOthers2.Text = s_others
            Next
        End If
        staff = chiefadmin + admin + d_admin + a_d_admin + a_admin + h_assistant + s_others
        Me.tbTotal2.Text = staff

        '//Calculate Percentages

        Dim percent2 As Double = 0

        per = (chiefadmin / staff) * 100
        Me.tbPChiefAdmin.Text = Math.Round(per, 2)
        percent2 = percent2 + per

        per = (admin / staff) * 100
        Me.tbPAdmin.Text = Math.Round(per, 2)
        percent2 = percent2 + per

        per = (d_admin / staff) * 100
        Me.tbPDeputyAdmin.Text = Math.Round(per, 2)
        percent2 = percent2 + per

        per = (a_d_admin / staff) * 100
        Me.tbPADAdmin.Text = Math.Round(per, 2)
        percent2 = percent2 + per

        per = (a_admin / staff) * 100
        Me.tbAssistantAdmin.Text = Math.Round(per, 2)
        percent2 = percent2 + per

        per = (h_assistant / staff) * 100
        Me.tbPHeadAssistant.Text = Math.Round(per, 2)
        percent2 = percent2 + per

        per = (s_others / staff) * 100
        Me.tbPOthers2.Text = Math.Round(per, 2)
        percent2 = percent2 + per

        Me.tbPTotal2.Text = Math.Round(percent2, 0)

    End Sub

    Private Sub Frm_Count_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        common.comboCollege(Me.cbCollege)
        common.ClearTextBox(Me)
    End Sub

    'Public Sub ClearTextBox(ByVal root As Control)
    '    For Each ctrl As Control In root.Controls
    '        ClearTextBox(ctrl)
    '        If TypeOf ctrl Is TextBox Then
    '            CType(ctrl, TextBox).Text = String.Empty
    '        End If
    '    Next ctrl
    'End Sub
    
End Class