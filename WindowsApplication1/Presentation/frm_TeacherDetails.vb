Public Class frm_TeacherDetails

    Dim flag_save As Boolean = True

    Dim Dbo_Teachers As Dbo_Teachers

    'save button
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If flag_save = False Then Exit Sub

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
        chk = common.validcheck(Me.cbPost, "Post")
        If chk = True Then
            Me.cbPost.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.cbEmpType, "Employee Type")
        If chk = True Then
            Me.cbEmpType.Focus()
            Exit Sub
        End If
        'service type
        If Me.chkNonTech.Checked = False And Me.chkTechnical.Checked = False Then
            MsgBox("Select one service type.", MsgBoxStyle.Information)
            Exit Sub
        End If
        'chk = common.NumericCheck(Me.tbServDuration, "Service Duration")
        'If chk = True Then
        '    Me.tbServDuration.Focus()
        '    Exit Sub
        'End If
        '//end of validation

        '//Save
        Dbo_Teachers = New Dbo_Teachers
        PutDbo_TeachersData(Dbo_Teachers)
        Try
            If Not Dbo_TeachersDB.Add(Dbo_Teachers) Then
                MessageBox.Show(msgNotAdded)
            Else
                MessageBox.Show(msgAdded)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            clearfields()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try


    End Sub

    Private Sub PutDbo_TeachersData(ByVal dboTeachers As Dbo_Teachers)
        Dbo_Teachers.Mid = teacherid
        Dbo_Teachers.MName = Trim(Me.tbName.Text).ToString
        Dbo_Teachers.MAddress = Trim(Me.tbAddress.Text).ToString
        If Me.rbMale.Checked = True Then
            Dbo_Teachers.MGender = "MALE"
        Else
            Dbo_Teachers.MGender = "FEMALE"
        End If
        'Dbo_Teachers.MDob = Trim(Me.dobAD.Text).ToString

        'If Me.dobAD.Text = "  /  /" Then
        '    Dbo_Teachers.MDob = System.Data.SqlTypes.SqlDateTime.Null
        'Else
        '    Dbo_Teachers.MDob = Trim(Me.dobAD.Text).ToString
        'End If

        'If Me.dobBS.Text = "  /  /" Then
        '    Dbo_Teachers.MDobnep = "N/A"
        'Else
        '    Dbo_Teachers.MDobnep = Trim(Me.dobBS.Text).ToString
        'End If

        Dbo_Teachers.MPost = Trim(Me.cbPost.Text).ToString
        Dbo_Teachers.MEmptype = Trim(Me.cbEmpType.Text).ToString
        'Dbo_Teachers.MSertype = Trim(Me.cbSerType.Text).ToString
        If Me.chkTechnical.Checked = True And Me.chkNonTech.Checked = True Then
            Dbo_Teachers.MSertype = Me.chkTechnical.Text + "," + Me.chkNonTech.Text
        ElseIf Me.chkTechnical.Checked = True And Me.chkNonTech.Checked = False Then
            Dbo_Teachers.MSertype = Me.chkTechnical.Text
        ElseIf Me.chkTechnical.Checked = False And Me.chkNonTech.Checked = True Then
            Dbo_Teachers.MSertype = Me.chkNonTech.Text

        End If
        'Dbo_Teachers.MAppdate = Trim(Me.appdateAD.Text).ToString
        'If Me.appdateAD.Text = "  /  /" Then
        '    Dbo_Teachers.MAppdate = System.Data.SqlTypes.SqlDateTime.Null '"01/01/1753"
        'Else
        '    Dbo_Teachers.MAppdate = Trim(Me.appdateAD.Text).ToString
        'End If

        'If Me.appdateBS.Text = "  /  /" Then
        '    Dbo_Teachers.MAppdatenep = "N/A"
        'Else
        '    Dbo_Teachers.MAppdatenep = Trim(Me.appdateBS.Text).ToString
        'End If
        'Dbo_Teachers.MAppdatenep = Trim(Me.appdateBS.Text).ToString

        'Dbo_Teachers.MRetdate = Trim(Me.retdateAD.Text).ToString
        'If Me.retdateAD.Text = "  /  /" Then
        '    Dbo_Teachers.MRetdate = System.Data.SqlTypes.SqlDateTime.Null '"01/01/1753"
        'Else
        '    Dbo_Teachers.MRetdate = Trim(Me.retdateAD.Text).ToString
        'End If

        'Dbo_Teachers.MRetdatenep = Trim(Me.retdateBS.Text).ToString
        'If Me.retdateBS.Text = "  /  /" Then
        '    Dbo_Teachers.MRetdatenep = "N/A" '"01/01/1753"
        'Else
        '    Dbo_Teachers.MRetdatenep = Trim(Me.retdateBS.Text).ToString
        'End If

        Dbo_Teachers.MSerduration = IIf(Me.tbServDuration.Text = "", 0, Me.tbServDuration.Text) 'Trim(Me.tbServDuration.Text).ToString

        Dbo_Teachers.MDob = IIf(Me.dobAD.Text = "  /  /", System.Data.SqlTypes.SqlDateTime.Null, Me.dobAD.Text)
        Dbo_Teachers.MDobnep = IIf(Me.dobBS.Text = "  /  /", "N/A", Me.dobBS.Text)
        Dbo_Teachers.MAppdate = IIf(Me.appdateAD.Text = "  /  /", System.Data.SqlTypes.SqlDateTime.Null, Me.appdateAD.Text)
        Dbo_Teachers.MAppdatenep = IIf(Me.appdateBS.Text = "  /  /", "N/A", Me.appdateBS.Text)
        Dbo_Teachers.MRetdate = IIf(Me.retdateAD.Text = "  /  /", System.Data.SqlTypes.SqlDateTime.Null, Me.retdateAD.Text)
        Dbo_Teachers.MRetdatenep = IIf(Me.retdateBS.Text = "  /  /", "N/A", Me.retdateBS.Text)


        Dbo_Teachers.MLeavetype = IIf(Me.cbLeaveType.Text = "", "N/A", Me.cbLeaveType.Text) 'Trim(Me.cbLeaveType.Text).ToString

        ''''''''''''''''''''''''''''''''''
        Dbo_Teachers.MDepartment = IIf(Me.tbDept.Text = "", "N/A", Me.tbDept.Text) 'Trim(Me.tbDept.Text).ToString
        Dbo_Teachers.MTraining = IIf(Me.tbTraining.Text = "", "N/A", Me.tbTraining.Text) 'Trim(Me.tbTraining.Text).ToString
        Dbo_Teachers.MStatus = True
        Dbo_Teachers.MCollegeid = Trim(Me.cbCollege.SelectedValue).ToString
        Dbo_Teachers.MFieldofstudy = IIf(Me.tbFieldOfStudy.Text = "", "N/A", Me.tbFieldOfStudy.Text) 'Trim(Me.tbFieldOfStudy.Text).ToString
        'Dbo_Teachers.MMonthlywtg = Trim(Me.tbWeeklyWtg.Text).ToString
        Dbo_Teachers.MMonthlywtgextra = IIf(Me.tbExtraClass.Text = "", "0", Me.tbExtraClass.Text)
        Dbo_Teachers.MQualification = IIf(Me.tbQualification.Text = "", "N/A", Me.tbQualification.Text) 'Trim(Me.tbQualification.Text).ToString
        Dbo_Teachers.MTeachinglevel = IIf(Me.tbTeachingLevel.Text = "", "N/A", Me.tbTeachingLevel.Text) 'Trim(Me.tbTeachingLevel.Text).ToString
        Dbo_Teachers.MTeachingsubject = IIf(Me.tbTeachingSubject.Text = "", "N/A", Me.tbTeachingSubject.Text) ' Trim(Me.tbTeachingSubject.Text).ToString
        Dbo_Teachers.MWages = IIf(Me.tbWages.Text = "", "0", Me.tbWages.Text)
        Dbo_Teachers.MWeeklywtg = IIf(Me.tbWeeklyWtg.Text = "", "0", Me.tbWeeklyWtg.Text)
        Dbo_Teachers.MSpecialization = IIf(Me.tbSpecialization.Text = "", "N/A", Me.tbSpecialization.Text) 'Trim(Me.tbSpecialization.Text).ToString
    End Sub

    Private Sub clearfields()
        common.ClearTextBox(Me)
        common.ClearComboBox(Me)
        common.ClearCheckBox(Me)
        common.ClearRadioButton(Me)
        common.ClearMaskedTextBox(Me)
        Me.cbCollege.Focus()
    End Sub

    Private Sub frm_TeacherDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        common.comboCollege(Me.cbCollege)
        common.comboTeacherPost(Me.cbPost)
        common.comboLeaveType(Me.cbLeaveType)
        'common.comboNepYear(Me.cbYear)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
        'clearfields()
    End Sub

    Private Sub dobBS_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dobBS.Leave
        'common.datecheck(Me.dobBS, "DOB ")
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

    'Private Sub retdateAD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles retdateAD.TextChanged
    'common.engtonepalidate(Me.retdateAD.Text)
    'End Sub

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

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frm_ListOfTeachers.ShowDialog()
        If teacherid = "0" Then
            flag_save = True
            Exit Sub
        Else
            flag_save = False
            loadTeachers()
        End If
    End Sub
    Private Sub loadTeachers()
        Try
            Dim sql2 As String = "SELECT * FROM teachers WHERE id='" & teacherid & "' " 'and collegeid='" & Me.cbCollege.SelectedValue & "'"
            Dim dt2 As DataTable = tudataDB.GetDataTable(sql2)
            If Not dt2 Is Nothing And dt2.Rows.Count > 0 Then
                For Each row2 As DataRow In dt2.Rows
                    Me.tbAddress.Text = IIf(row2.Item("address") Is DBNull.Value, "N/A", row2.Item("address"))
                    Me.tbDept.Text = IIf(row2.Item("department") Is DBNull.Value, "N/A", row2.Item("department")) ' row2.Item("department")
                    Me.tbExtraClass.Text = IIf(row2.Item("MonthlyWtgExtra") Is DBNull.Value, "", row2.Item("MonthlyWtgExtra")) 'row2.Item("MonthlyWtgExtra")
                    Me.tbFieldOfStudy.Text = IIf(row2.Item("FieldOfStudy") Is DBNull.Value, "N/A", row2.Item("FieldOfStudy")) 'row2.Item("FieldOfStudy")
                    Me.tbName.Text = IIf(row2.Item("Name") Is DBNull.Value, "N/A", row2.Item("Name")) 'row2.Item("Name")
                    Me.cbPost.Text = IIf(row2.Item("Post") Is DBNull.Value, "N/A", row2.Item("Post")) 'row2.Item("Post")
                    Me.tbQualification.Text = IIf(row2.Item("Qualification") Is DBNull.Value, "N/A", row2.Item("Qualification")) 'row2.Item("Qualification")
                    Me.tbServDuration.Text = IIf(row2.Item("SerDuration") Is DBNull.Value, "N/A", row2.Item("SerDuration")) 'row2.Item("SerDuration")
                    Me.tbSpecialization.Text = IIf(row2.Item("Specialization") Is DBNull.Value, "N/A", row2.Item("Specialization")) 'row2.Item("Specialization")
                    Me.tbTeachingLevel.Text = IIf(row2.Item("TeachingLevel") Is DBNull.Value, "N/A", row2.Item("TeachingLevel")) 'row2.Item("TeachingLevel")
                    Me.tbTeachingSubject.Text = IIf(row2.Item("TeachingSubject") Is DBNull.Value, "N/A", row2.Item("TeachingSubject")) 'row2.Item("TeachingSubject")
                    Me.tbTraining.Text = IIf(row2.Item("Training") Is DBNull.Value, "N/A", row2.Item("Training")) 'row2.Item("Training")
                    Me.tbWages.Text = IIf(row2.Item("Wages") Is DBNull.Value, "", row2.Item("Wages")) 'row2.Item("Wages")
                    Me.tbWeeklyWtg.Text = IIf(row2.Item("WeeklyWtg") Is DBNull.Value, "", row2.Item("WeeklyWtg")) 'row2.Item("WeeklyWtg")
                    Me.cbCollege.SelectedValue = IIf(row2.Item("Collegeid") Is DBNull.Value, "N/A", row2.Item("Collegeid")) 'row2.Item("Collegeid")
                    Me.cbEmpType.Text = IIf(row2.Item("EmpType") Is DBNull.Value, "N/A", row2.Item("EmpType")) 'row2.Item("EmpType")
                    Me.cbLeaveType.Text = IIf(row2.Item("LeaveType") Is DBNull.Value, "N/A", row2.Item("LeaveType")) 'row2.Item("LeaveType")
                    'Me.cbSerType.Text = IIf(row2.Item("SerType") Is DBNull.Value, "N/A", row2.Item("address")) 'row2.Item("SerType")
                    If row2.Item("SerType") = "Technical" Then
                        Me.chkTechnical.Checked = True
                        Me.chkNonTech.Checked = False
                    ElseIf row2.Item("SerType") = "Non Technical" Then
                        Me.chkNonTech.Checked = True
                        Me.chkTechnical.Checked = False
                    ElseIf row2.Item("SerType") = "Technical,Non Technical" Then
                        Me.chkTechnical.Checked = True
                        Me.chkNonTech.Checked = True
                    End If

                    'Dim a As String = row2.Item("dob")
                    'If a = "01/01/1900" Then
                    'If row2.Item("dob").ToString = System.Data.SqlTypes.SqlDateTime.Null.ToString() Then
                    'Me.dobAD.Text = "  /  /"
                    ' Else
                    'Me.dobAD.Text = row2.Item("dob")
                    'End If
                    'Me.dobAD.Text = IIf(row2.Item("dob") = System.Data.SqlTypes.SqlDateTime.Null, "  /  /", row2.Item("dob"))

                    Me.dobBS.Text = IIf(row2.Item("dobnep") = "N/A", "  /  /", row2.Item("dobnep"))

                    'a = row2.Item("AppDate")
                    'If a = "01/01/1900" Then

                    'End If

                    'If row2.Item("AppDate").ToString = System.Data.SqlTypes.SqlDateTime.Null.ToString() Then
                    'Me.appdateAD.Text = "  /  /"
                    'Else
                    'Me.appdateAD.Text = row2.Item("AppDate")
                    'End If
                    'Me.appdateAD.Text = IIf(row2.Item("AppDate") = System.Data.SqlTypes.SqlDateTime.Null, "  /  /", row2.Item("AppDate"))

                    Me.appdateBS.Text = IIf(row2.Item("AppDateNep") = "N/A", "  /  /", row2.Item("AppDateNep"))

                    'a = row2.Item("RetDate")
                    'If a = "01/01/1900" Then
                    'If row2.Item("RetDate").ToString = System.Data.SqlTypes.SqlDateTime.Null.ToString() Then
                    'Me.retdateAD.Text = "  /  /"
                    'Else
                    ' Me.retdateAD.Text = row2.Item("RetDate")
                    'End If

                    'Me.retdateAD.Text = IIf(row2.Item("RetDate") = System.Data.SqlTypes.SqlDateTime.Null, "  /  /", row2.Item("RetDate"))

                    Me.retdateBS.Text = IIf(row2.Item("RetDateNep") = "N/A", "  /  /", row2.Item("RetDateNep"))


                    'Me.appdateAD.Text = IIf(row2.Item("AppDate") = System.Data.SqlTypes.SqlDateTime.Null, "  /  /", row2.Item("AppDate"))
                    'Dim a As String = row2.Item("AppDate")
                    'Me.appdateBS.Text = row2.Item("AppDateNep")

                    'Me.retdateAD.Text = IIf(row2.Item("RetDate") = System.Data.SqlTypes.SqlDateTime.Null, "  /  /", row2.Item("RetDate"))
                    'Me.retdateBS.Text = row2.Item("RetDateNep")
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub

    'update
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If flag_save = True Then Exit Sub
        Dim gender As String = ""
        If Me.rbMale.Checked = True Then
            gender = "MALE"
        ElseIf Me.rbFemale.Checked = True Then
            gender = "FEMALE"
        End If


        Dim dob As Date
        Dim appdate As Date
        Dim retdate As Date
        Dim a As String = Me.dobAD.Text
        If a = "  /  /" Then
            Me.dobAD.Text = System.Data.SqlTypes.SqlDateTime.Null
        Else
            dob = Me.dobAD.Text
        End If
        a = Me.appdateAD.Text
        If a = "  /  /" Then
            Me.appdateAD.Text = System.Data.SqlTypes.SqlDateTime.Null
        Else
            appdate = Me.appdateAD.Text
        End If
        a = Me.retdateAD.Text
        If a = "  /  /" Then
            Me.retdateAD.Text = System.Data.SqlTypes.SqlDateTime.Null
        Else
            retdate = Me.retdateAD.Text
        End If

        'dob = a 'IIf(Me.dobAD.Text = "  /  /", System.Data.SqlTypes.SqlDateTime.Null, Me.dobAD.Text)
        'appdate = IIf(Me.appdateAD.Text = "  /  /", System.Data.SqlTypes.SqlDateTime.Null, Me.appdateAD.Text)
        'retdate = IIf(Me.retdateAD.Text = "  /  /", System.Data.SqlTypes.SqlDateTime.Null, Me.retdateAD.Text)

        'Dim dobAD As Date
        'If Me.dobAD.Text = "  /  /" Then
        '    dobAD = System.Data.SqlTypes.SqlDateTime.Null
        'Else
        '    dobAD = Trim(Me.dobAD.Text).ToString
        'End If

        'Dim appdateAD As Date
        'If Me.appdateAD.Text = "  /  /" Then
        '    appdateAD = System.Data.SqlTypes.SqlDateTime.Null
        'Else
        '    appdateAD = Trim(Me.appdateAD.Text).ToString
        'End If

        'Dim retdateAD As Date
        'If Me.retdateAD.Text = "  /  /" Then
        '    retdateAD = System.Data.SqlTypes.SqlDateTime.Null
        'Else
        '    retdateAD = Trim(Me.retdateAD.Text).ToString
        'End If

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
         "Update [dbo].[Teachers] " & _
         "SET [Name] = '" & Me.tbName.Text & "' " & _
         ",[Address] = '" & Me.tbAddress.Text & "' " & _
         ",[Gender] = '" & gender & "' " & _
         ",[dob] = '" & dob & "' " & _
         ",[dobNep] = '" & Me.dobBS.Text & "' " & _
         ",[post] = '" & Me.cbPost.Text & "' " & _
         ",[EmpType] = '" & Me.cbEmpType.Text & "' " & _
         ",[SerType] = '" & sertype & "' " & _
         ",[AppDate] = '" & appdate & "' " & _
         ",[AppDateNep] = '" & Me.appdateBS.Text & "' " & _
         ",[SerDuration] = '" & Me.tbServDuration.Text & "' " & _
         ",[RetDate] = '" & retdate & "' " & _
         ",[RetDateNep] = '" & Me.retdateBS.Text & "' " & _
         ",[FieldOfStudy] = '" & Me.tbFieldOfStudy.Text & "' " & _
         ",[TeachingSubject] = '" & Me.tbTeachingSubject.Text & "' " & _
         ",[TeachingLevel] = '" & Me.tbTeachingLevel.Text & "' " & _
         ",[Specialization] = '" & Me.tbSpecialization.Text & "' " & _
         ",[Qualification] = '" & Me.tbQualification.Text & "' " & _
         ",[LeaveType] = '" & Me.cbLeaveType.Text & "' " & _
         ",[Wages] = '" & Me.tbWages.Text & "' " & _
         ",[WeeklyWtg] = '" & Me.tbWeeklyWtg.Text & "' " & _
         ",[MonthlyWtg] = '' " & _
         ",[MonthlyWtgExtra] = '" & Me.tbExtraClass.Text & "' " & _
         ",[Department] = '" & Me.tbDept.Text & "' " & _
         ",[Training] = '" & Me.tbTraining.Text & "' " & _
         ",[Status] = '1' " & _
         ",[CollegeId] = '" & Me.cbCollege.SelectedValue & "' " & _
         "WHERE id='" & teacherid & "'"
            Dim dt As DataTable = tudataDB.GetDataTable(sql)
            MsgBox("Teacher details updated.", MsgBoxStyle.Information)
            clearfields()
            flag_save = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tbServDuration_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbServDuration.KeyPress
        common.validation(e)
    End Sub

    'delete
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Me.tbName.Text = "" Then Exit Sub 'no teacher selected.

        '---DELETE 
        Dim result As DialogResult = MessageBox.Show(msgDelete, msgCaptionEntry, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Try
                Dim query As String = "DELETE FROM teachers WHERE id = '" & teacherid & "'"
                Dim dt As DataTable = tudataDB.GetDataTable(query)
                MsgBox("Teacher deleted successfully.", MsgBoxStyle.Information)
            Catch ex As Exception
                MessageBox.Show("Can not delete.")
            End Try
           
        End If
    End Sub


End Class