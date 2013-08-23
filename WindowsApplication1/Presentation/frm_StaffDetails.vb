Public Class frm_StaffDetails

    Dim Dbo_Staff As Dbo_Staff
    Dim flag As Boolean = True

    'save
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If flag = False Then Exit Sub
        '//validation
        Dim chk As Boolean
        chk = common.validcheck(Me.cbCollege, "College")
        If chk = True Then
            Me.cbCollege.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbName, "Name")
        If chk = True Then
            Me.tbName.Focus()
            Exit Sub
        End If
        'chk = common.NumericCheck(Me.tbServDuration, "Service Duration")
        'If chk = True Then
        '    Me.tbServDuration.Focus()
        '    Exit Sub
        'End If
        '//end of validation

        '//Save
        Dbo_Staff = New Dbo_Staff
        PutDbo_StaffData(Dbo_Staff)
        Try
            If Not Dbo_StaffDB.Add(Dbo_Staff) Then
                MessageBox.Show(msgNotAdded)
            Else
                MessageBox.Show(msgAdded)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            clearfields()
            'flag = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub clearfields()
        ''common.ClearTextBox(Me)
        ''common.ClearComboBox(Me)
        'Me.tbName.Clear()
        'Me.tbAddress.Clear()
        'Me.tbDept.Clear()
        'Me.cbPost.SelectedIndex = -1
        'Me.tbServDuration.Clear()
        'Me.tbTraining.Clear()
        ''Me.cbCollege.SelectedIndex = 0
        'Me.cbEmpType.SelectedIndex = -1
        'Me.cbLeaveType.SelectedIndex = -1
        ''Me.cbSerType.SelectedIndex = -1
        'Me.dobAD.Clear()
        'Me.dobBS.Clear()
        'Me.appdateAD.Clear()
        'Me.appdateBS.Clear()
        'Me.retdateAD.Clear()
        'Me.retdateBS.Clear()
        'Me.tbPromotion.Clear()
        'Me.tbQualification.Clear()
        'Me.rbMale.Checked = True
        'Me.appdateAD.Text = "  /  /"
        'Me.appdateBS.Text = "  /  /"
        'Me.dobAD.Text = "  /  /"
        'Me.dobBS.Text = "  /  /"
        'Me.retdateAD.Text = "  /  /"
        'Me.retdateBS.Text = "  /  /"
        common.ClearTextBox(Me)
        common.ClearComboBox(Me)
        common.ClearCheckBox(Me)
        common.ClearRadioButton(Me)
        Me.cbCollege.Focus()
    End Sub

    Private Sub PutDbo_StaffData(ByVal dboStaff As Dbo_Staff)
        Dbo_Staff.MName = Trim(Me.tbName.Text).ToString
        Dbo_Staff.MAddress = Trim(Me.tbAddress.Text).ToString
        If Me.rbMale.Checked = True Then
            Dbo_Staff.MGender = "MALE"
        Else
            Dbo_Staff.MGender = "FEMALE"
        End If
        'Dbo_Staff.MDob = Trim(Me.dobAD.Text).ToString
        'If Me.dobAD.Text = "  /  /" Then
        '    Dbo_Staff.MDob = "01/01/1753"
        'Else
        '    Dbo_Staff.MDob = Trim(Me.dobAD.Text).ToString
        'End If
        Dbo_Staff.MDobnep = Trim(Me.dobBS.Text).ToString
        Dbo_Staff.MPost = Trim(Me.cbPost.Text).ToString
        Dbo_Staff.MEmptype = Trim(Me.cbEmpType.Text).ToString
        'Dbo_Staff.MSertype = Trim(Me.cbSerType.Text).ToString
        If Me.chkTechnical.Checked = True And Me.chkNonTech.Checked = True Then
            Dbo_Staff.MSertype = Me.chkTechnical.Text + "," + Me.chkNonTech.Text
        ElseIf Me.chkTechnical.Checked = True And Me.chkNonTech.Checked = False Then
            Dbo_Staff.MSertype = Me.chkTechnical.Text
        ElseIf Me.chkTechnical.Checked = False And Me.chkNonTech.Checked = True Then
            Dbo_Staff.MSertype = Me.chkNonTech.Text

        End If
        'Dbo_Staff.MAppdate = Trim(Me.appdateAD.Text).ToString
        'If Me.appdateAD.Text = "  /  /" Then
        '    Dbo_Staff.MAppdate = "01/01/1753"
        'Else
        '    Dbo_Staff.MAppdate = Trim(Me.appdateAD.Text).ToString
        'End If
        Dbo_Staff.MAppdatenep = Trim(Me.appdateBS.Text).ToString
        Dbo_Staff.MSerduration = IIf(Trim(Me.tbServDuration.Text).ToString = "", "0", Trim(Me.tbServDuration.Text).ToString)
        'Dbo_Staff.MRetdate = Trim(Me.retdateAD.Text).ToString
        'If Me.retdateAD.Text = "  /  /" Then
        '    Dbo_Staff.MRetdate = "01/01/1753"
        'Else
        '    Dbo_Staff.MRetdate = Trim(Me.retdateAD.Text).ToString
        'End If
        Dbo_Staff.MRetdatenep = Trim(Me.retdateBS.Text).ToString
        Dbo_Staff.MLeavetype = "" 'Trim(Me.cbLeaveType.Text).ToString
        Dbo_Staff.MDepartment = Trim(Me.tbDept.Text).ToString
        Dbo_Staff.MTraining = Trim(Me.tbTraining.Text).ToString
        Dbo_Staff.MStatus = True
        Dbo_Staff.MCollegeid = Trim(Me.cbCollege.SelectedValue).ToString
        Dbo_Staff.MPromotion = Trim(Me.tbPromotion.Text).ToString
        Dbo_Staff.MQualification = Trim(Me.tbQualification.Text).ToString
    End Sub

    Private Sub frm_StaffDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        common.comboCollege(Me.cbCollege)
        common.comboStaffPost(Me.cbPost)
        'common.comboLeaveType(Me.cbLeaveType)
    End Sub

    'update
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If flag = True Then Exit Sub
        '//Update
        Dim chk As Boolean
        chk = common.validcheck(Me.cbCollege, "College")
        If chk = True Then
            Me.cbCollege.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbName, "Name")
        If chk = True Then
            Me.tbName.Focus()
            Exit Sub
        End If
        Dim gender As String = ""
        If Me.rbMale.Checked = True Then
            gender = "MALE"
        ElseIf Me.rbFemale.Checked = True Then
            gender = "FEMALE"
        End If

        'Dim dobAD As Date
        'If Me.dobAD.Text = "  /  /" Then
        '    dobAD = "01/01/1753"
        'Else
        '    dobAD = Trim(Me.dobAD.Text).ToString
        'End If

        'Dim appdateAD As Date
        'If Me.appdateAD.Text = "  /  /" Then
        '    appdateAD = "01/01/1753"
        'Else
        '    appdateAD = Trim(Me.appdateAD.Text).ToString
        'End If

        'Dim retdateAD As Date
        'If Me.retdateAD.Text = "  /  /" Then
        '    retdateAD = "01/01/1753"
        'Else
        '    retdateAD = Trim(Me.retdateAD.Text).ToString
        'End If

        '//service type
        Dim sertype As String = ""
        If Me.chkTechnical.Checked = True And Me.chkNonTech.Checked = True Then
            sertype = Me.chkTechnical.Text + "," + Me.chkNonTech.Text
        ElseIf Me.chkTechnical.Checked = True And Me.chkNonTech.Checked = False Then
            sertype = Me.chkTechnical.Text
        ElseIf Me.chkTechnical.Checked = False And Me.chkNonTech.Checked = True Then
            sertype = Me.chkNonTech.Text

        End If

        Try
            Dim sql As String = _
            "Update [dbo].[Staff] " & _
            "SET [Name] = '" & Me.tbName.Text & "' " & _
      ",[Address] = '" & Me.tbAddress.Text & "' " & _
      ",[Gender] = '" & gender & "' " & _
      ",[dob] = '" & Me.dobAD.Text & "' " & _
      ",[dobNep] = '" & Me.dobBS.Text & "' " & _
      ",[post] = '" & Me.cbPost.Text & "' " & _
      ",[EmpType] = '" & Me.cbEmpType.Text & "' " & _
      ",[SerType] = '" & sertype & "' " & _
      ",[AppDate] = '" & Me.appdateAD.Text & "' " & _
      ",[AppDateNep] = '" & Me.appdateBS.Text & "' " & _
      ",[SerDuration] = '" & Me.tbServDuration.Text & "' " & _
      ",[RetDate] = '" & Me.retdateAD.Text & "' " & _
      ",[RetDateNep] = '" & Me.retdateBS.Text & "' " & _
      ",[LeaveType] = '' " & _
      ",[Department] = '" & Me.tbDept.Text & "' " & _
      ",[Training] = '" & Me.tbTraining.Text & "' " & _
      ",[Status] = '1' " & _
      ",[CollegeId] = '" & Me.cbCollege.SelectedValue & "' " & _
      ",[Promotion] = '" & Me.tbPromotion.Text & "' " & _
      ",[Qualification] = '" & Me.tbQualification.Text & "' " & _
      "WHERE id = '" & staffid & "'"
            Dim dt As DataTable = tudataDB.GetDataTable(sql)
            MsgBox("Staff details updated.", MsgBoxStyle.Information)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If Me.tbName.Text = "" Then Exit Sub 'no teacher selected.

        '---DELETE 
        Dim result As DialogResult = MessageBox.Show(msgDelete, msgCaptionEntry, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Try
                Dim query As String = "DELETE FROM staff WHERE id = '" & staffid & "'"
                Dim dt As DataTable = tudataDB.GetDataTable(query)
                MsgBox("Staff deleted successfully.", MsgBoxStyle.Information)
            Catch ex As Exception
                MessageBox.Show("Can not delete.")
            End Try

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        '//Clear
        'clearfields()
        frm_ListStaff.ShowDialog()
        If staffid = "0" Then
            flag = True
            Exit Sub
        Else
            flag = False
            loadTeachers()
        End If
    End Sub
    Private Sub loadTeachers()
        Try
            Dim sql2 As String = "SELECT * FROM staff WHERE id='" & staffid & "' "
            Dim dt2 As DataTable = tudataDB.GetDataTable(sql2)
            If Not dt2 Is Nothing And dt2.Rows.Count > 0 Then
                For Each row2 As DataRow In dt2.Rows
                    Me.tbAddress.Text = IIf(row2.Item("address") Is DBNull.Value, "N/A", row2.Item("address"))
                    Me.tbDept.Text = IIf(row2.Item("department") Is DBNull.Value, "N/A", row2.Item("department"))
                    Me.tbName.Text = row2.Item("name")
                    Me.cbPost.Text = row2.Item("post")
                    Me.tbPromotion.Text = IIf(row2.Item("promotion") Is DBNull.Value, "N/A", row2.Item("promotion"))
                    Me.tbServDuration.Text = IIf(row2.Item("serduration") Is DBNull.Value, "N/A", row2.Item("serduration"))
                    Me.tbTraining.Text = IIf(row2.Item("training") Is DBNull.Value, "N/A", row2.Item("training"))
                    Me.cbCollege.SelectedValue = row2.Item("collegeid")
                    Me.cbEmpType.Text = IIf(row2.Item("emptype") Is DBNull.Value, "N/A", row2.Item("emptype"))
                    'Me.cbLeaveType.Text = row2.Item("leavetype")
                    ' Me.cbSerType.Text = row2.Item("sertype")
                    If row2.Item("gender") = "MALE" Then
                        Me.rbMale.Checked = True
                    Else
                        Me.rbFemale.Checked = True
                    End If
                    'Me.dobAD.Text = IIf(row2.Item("dob") = "01/01/1753", "  /  /", row2.Item("dob"))
                    Me.dobBS.Text = row2.Item("dobNep")
                    'Me.appdateAD.Text = IIf(row2.Item("appdate") = "01/01/1753", "  /  /", row2.Item("appdate"))
                    Me.appdateBS.Text = row2.Item("AppDateNep")
                    'Me.retdateAD.Text = IIf(row2.Item("retdate") = "01/01/1753", "  /  /", row2.Item("retdate"))
                    Me.retdateBS.Text = row2.Item("RetDateNep")
                    Me.tbQualification.Text = IIf(row2.Item("qualification") Is DBNull.Value, "N/A", row2.Item("qualification")) ' row2.Item("qualification")
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        '//Close
        Me.Close()
    End Sub

    Private Sub tbServDuration_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbServDuration.KeyPress
        common.validation(e)
    End Sub

    Private Sub dobBS_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dobBS.Leave
        'get retirement date
        If Me.dobBS.Text = " / /" Then Exit Sub
        common.NeptoEngDate(Me.dobBS.Text, dobAD, dobBS)
        'retirement date
        'add 63 years to the dob
        Dim dob As String = dobBS.Text
        Dim dobYear As Integer = Mid(dob, 7, 4)
        Dim retYear As Integer = dobYear + 63
        Dim retdate As String = Mid(dob, 1, 6) & "/" & retYear
        Me.retdateBS.Text = retdate

        'Retire date in AD
        If Me.retdateBS.Text = " / /" Then Exit Sub
        common.NeptoEngDate(Me.retdateBS.Text, retdateAD, retdateBS)
    End Sub

    Private Sub appdateBS_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles appdateBS.Leave
        If Me.appdateBS.Text = " / /" Then Exit Sub
        'get date in AD
        common.NeptoEngDate(Me.appdateBS.Text, appdateAD, appdateBS)
        'get service duration
        getserviceduration()
    End Sub

    Private Sub getserviceduration()
        Try
            If appdateAD.Text = "  /  /" Then Exit Sub
            Dim check = common.datecheck(appdateAD, appdateAD.Text)
            If check = True Then
                Exit Sub
            End If
            Dim nepdate As String = common.engtonepalidate(appdateAD.Text)
            Me.appdateBS.Text = nepdate

            'service duration
            Dim appointedDate As DateTime = Me.appdateAD.Text
            Dim ts As TimeSpan = DateTime.Now.Subtract(appointedDate)
            Dim years As Integer, months As Integer, days As Integer, hours As Integer, minutes As Integer, seconds As Integer

            ' compute difference in total months
            months = 12 * (DateTime.Now.Year - appointedDate.Year) + (DateTime.Now.Month - appointedDate.Month)

            ' based upon the 'days',
            ' adjust months & compute actual days difference
            If DateTime.Now.Day < appointedDate.Day Then
                months -= 1
                days = DateTime.DaysInMonth(appointedDate.Year, appointedDate.Month) - appointedDate.Day + DateTime.Now.Day
            Else
                days = DateTime.Now.Day - appointedDate.Day
            End If
            ' compute years & actual months
            years = Math.Floor(months / 12)
            months -= years * 12

            hours = ts.Hours
            minutes = ts.Minutes
            seconds = ts.Seconds

            Me.tbServDuration.Text = years & " years " & months & " months " & days & " days"
        Catch ex As Exception

        End Try
    End Sub
End Class