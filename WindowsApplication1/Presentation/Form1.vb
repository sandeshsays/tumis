Public Class Form1

    Dim constring As String

    Private Sub EntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryToolStripMenuItem.Click
        Dim frm As New frm_StaffDetails
        If (common.IsMdiChildExists(Me, frm.Name) = True) Then
            MessageBox.Show("The form is already opened.")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim test_file As String = common.ReadFile("SMS.dat")
        'If test_file = "False" Then
        '    DBConfig.ShowDialog()
        'ElseIf test_file = "True" Then
        '    Exit Sub
        'End If
    End Sub

    Private Sub EntryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryToolStripMenuItem1.Click
        Dim frm As New frm_TeacherDetails
        If (common.IsMdiChildExists(Me, frm.Name) = True) Then
            MessageBox.Show("The form is already opened.")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AcademicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcademicToolStripMenuItem.Click
        Dim frm As New frm_Appointments
        If (common.IsMdiChildExists(Me, frm.Name) = True) Then
            MessageBox.Show("The form is already opened.")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AdministrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministrationToolStripMenuItem.Click
        Dim frm As New frm_AppointmentsAdmin
        If (common.IsMdiChildExists(Me, frm.Name) = True) Then
            MessageBox.Show("The form is already opened.")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub YearWiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearWiseToolStripMenuItem.Click
        Dim frm As New frm_StdCountYear
        If (common.IsMdiChildExists(Me, frm.Name) = True) Then
            MessageBox.Show("The form is already opened.")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SemesterWiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemesterWiseToolStripMenuItem.Click
        Dim frm As New frm_StdCountSem
        If (common.IsMdiChildExists(Me, frm.Name) = True) Then
            MessageBox.Show("The form is already opened.")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AddNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewToolStripMenuItem.Click
        Dim frm As New frm_College
        If (common.IsMdiChildExists(Me, frm.Name) = True) Then
            MessageBox.Show("The form is already opened.")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub FindTeacherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindTeacherToolStripMenuItem.Click
        Dim frm As New frm_ListOfTeachers
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub FindStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindStaffToolStripMenuItem.Click
        Dim frm As New frm_ListStaff
        If (common.IsMdiChildExists(Me, frm.Name) = True) Then
            MessageBox.Show("The form is already opened.")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TeacherRatioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeacherRatioToolStripMenuItem.Click
        Dim frm As New frm_TeacherMF
        If (common.IsMdiChildExists(Me, frm.Name) = True) Then
            MessageBox.Show("The form is already opened.")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ViewAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllToolStripMenuItem.Click
        Dim frm As New frm_ViewAll
        If (common.IsMdiChildExists(Me, frm.Name) = True) Then
            MessageBox.Show("The form is already opened.")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TeachersToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeachersToolStripMenuItem1.Click
        'rpt_TeachersList()
        'Dim frm As New rpt_TeachersList
        'If (common.IsMdiChildExists(Me, frm.Name) = True) Then
        '    MessageBox.Show("The form is already opened.")
        '    Exit Sub
        'End If
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub CountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountToolStripMenuItem.Click
        Dim frm As New Frm_Count
        If (common.IsMdiChildExists(Me, frm.Name) = True) Then
            MessageBox.Show("The form is already opened.")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    'Private Sub PassedStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassedStudentsToolStripMenuItem.Click
    '    Dim frm As New frm_PassedStudents
    '    If (common.IsMdiChildExists(Me, frm.Name) = True) Then
    '        MessageBox.Show("The form is already opened.")
    '        Exit Sub
    '    End If
    '    frm.MdiParent = Me
    '    frm.Show()
    'End Sub

    Private Sub CollegesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollegesToolStripMenuItem1.Click
        Dim frm As New frm_ListColleges
        If (common.IsMdiChildExists(Me, frm.Name) = True) Then
            MessageBox.Show("The form is already opened.")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersToolStripMenuItem.Click
        Dim frm As New frm_Users
        If (common.IsMdiChildExists(Me, frm.Name) = True) Then
            MessageBox.Show("The form is already opened.")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

  
    Private Sub PassedStudentsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassedStudentsToolStripMenuItem1.Click
        Dim frm As New frm_PassedStudents
        If (common.IsMdiChildExists(Me, frm.Name) = True) Then
            MessageBox.Show("The form is already opened.")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub RetirementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetirementToolStripMenuItem.Click
        Dim frm As New frm_Retirement

        If (common.IsMdiChildExists(Me, frm.Name) = True) Then
            MessageBox.Show("The form is already opened.")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub FacultyWiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyWiseToolStripMenuItem.Click
        Dim frm As New frm_FacultyOverview
        If (common.IsMdiChildExists(Me, frm.Name) = True) Then
            MessageBox.Show("The form is already opened.")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CollegeWiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollegeWiseToolStripMenuItem.Click
        Dim frm As New frm_CollegeOverview
        If (common.IsMdiChildExists(Me, frm.Name) = True) Then
            MessageBox.Show("The form is already opened.")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
