Public Class frm_TeacherMF

    Private Sub frm_TeacherMF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        common.comboCollege(Me.ComboBox1)
        common.ClearTextBox(Me)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If TypeOf (Me.ComboBox1.SelectedValue) Is System.Data.DataRowView Then Exit Sub
        loadteachers()
        loadstaff()
    End Sub
    Private Sub loadteachers()

        Dim TOTAL As Integer = 0
        Dim MALE As Integer = 0
        Dim FEMALE As Integer = 0
        Dim MPER As Double = 0
        Dim FPER As Double = 0

        Dim sql1 As String = "SELECT count(*) AS TOTAL FROM Teachers WHERE CollegeId ='" & Me.ComboBox1.SelectedValue & "'"
        Dim sql2 As String = "SELECT count(*) AS MALE FROM Teachers WHERE CollegeId ='" & Me.ComboBox1.SelectedValue & "' AND Gender='MALE'"
        Dim sql3 As String = "SELECT count(*) AS FEMALE FROM Teachers WHERE CollegeId ='" & Me.ComboBox1.SelectedValue & "' AND Gender='FEMALE'"

        Dim dt1 As DataTable = tudataDB.GetDataTable(sql1)
        Dim dt2 As DataTable = tudataDB.GetDataTable(sql2)
        Dim dt3 As DataTable = tudataDB.GetDataTable(sql3)

        If Not dt1 Is Nothing And dt1.Rows.Count > 0 Then
            For Each row1 As DataRow In dt1.Rows
                TOTAL = row1.Item("TOTAL")
                Me.TBT.Text = TOTAL
            Next
        End If

        If Not dt2 Is Nothing And dt2.Rows.Count > 0 Then
            For Each row2 As DataRow In dt2.Rows
                MALE = row2.Item("MALE")
                Me.TBM.Text = MALE
            Next
        End If

        If Not dt3 Is Nothing And dt3.Rows.Count > 0 Then
            For Each row3 As DataRow In dt3.Rows
                FEMALE = row3.Item("FEMALE")
                Me.TBF.Text = FEMALE
            Next
        End If

        MPER = (MALE / TOTAL) * 100
        Me.tbMper.Text = Math.Round(MPER, 2)
        FPER = (FEMALE / TOTAL) * 100
        Me.tbFper.Text = Math.Round(FPER, 2)
        Me.tbTper.Text = MPER + FPER

    End Sub

    Private Sub loadstaff()

        Dim STOTAL As Integer = 0
        Dim SMALE As Integer = 0
        Dim SFEMALE As Integer = 0
        Dim SMPER As Double = 0
        Dim SFPER As Double = 0

        Dim sql1 As String = "SELECT count(*) AS TOTAL FROM staff WHERE CollegeId ='" & Me.ComboBox1.SelectedValue & "'"
        Dim sql2 As String = "SELECT count(*) AS MALE FROM staff WHERE CollegeId ='" & Me.ComboBox1.SelectedValue & "' AND Gender='MALE'"
        Dim sql3 As String = "SELECT count(*) AS FEMALE FROM staff WHERE CollegeId ='" & Me.ComboBox1.SelectedValue & "' AND Gender='FEMALE'"

        Dim dt1 As DataTable = tudataDB.GetDataTable(sql1)
        Dim dt2 As DataTable = tudataDB.GetDataTable(sql2)
        Dim dt3 As DataTable = tudataDB.GetDataTable(sql3)

        If Not dt1 Is Nothing And dt1.Rows.Count > 0 Then
            For Each row1 As DataRow In dt1.Rows
                STOTAL = row1.Item("TOTAL")
                Me.tbST.Text = STOTAL
            Next
        End If

        If Not dt2 Is Nothing And dt2.Rows.Count > 0 Then
            For Each row2 As DataRow In dt2.Rows
                SMALE = row2.Item("MALE")
                Me.tbSM.Text = SMALE
            Next
        End If

        If Not dt3 Is Nothing And dt3.Rows.Count > 0 Then
            For Each row3 As DataRow In dt3.Rows
                SFEMALE = row3.Item("FEMALE")
                Me.tbSF.Text = SFEMALE
            Next
        End If

        SMPER = (SMALE / STOTAL) * 100
        Me.tbSMP.Text = Math.Round(SMPER, 2)
        SFPER = (SFEMALE / STOTAL) * 100
        Me.tbSFP.Text = Math.Round(SFPER, 2)
        Me.tbSTP.Text = SMPER + SFPER

    End Sub
End Class