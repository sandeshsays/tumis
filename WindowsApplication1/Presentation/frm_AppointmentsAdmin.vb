Public Class frm_AppointmentsAdmin

    Dim Dbo_Appointments As Dbo_Appointments

    'Approved
    Private Sub btSave1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave1.Click
        '//validation
        Dim chk As Boolean
        chk = common.validcheck(Me.cbCollege, "College")
        If chk = True Then
            Me.cbCollege.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbYear, "Year")
        If chk = True Then
            Me.tbYear.Focus()
            Exit Sub
        End If
        '//end of validation

        '//Save
        Dbo_Appointments = New Dbo_Appointments
        PutDbo_AppointmentsData1(Dbo_Appointments)
        Try
            If Not Dbo_AppointmentsDB.Add(Dbo_Appointments) Then
                MessageBox.Show("Error.")
            Else
                MessageBox.Show("Success.")
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            clearfields1()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub clearfields1()
        Me.tbPost1.Clear()
        Me.tbTotal1.Clear()
    End Sub

    Private Sub PutDbo_AppointmentsData1(ByVal dboStaff As Dbo_Appointments)
        Dbo_Appointments.MCollegeId = Me.cbCollege.SelectedValue
        Dbo_Appointments.MFyear = Trim(Me.tbYear.Text).ToString
        Dbo_Appointments.MCategory = "Admin"
        Dbo_Appointments.MSubCat = "Approved"
        Dbo_Appointments.MPost = Trim(Me.tbPost1.Text).ToString
        Dbo_Appointments.MSubject = ""
        Dbo_Appointments.MNumber = Trim(Me.tbTotal1.Text).ToString
    End Sub

    'Filling
    Private Sub btSave2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave2.Click
        '//validation
        Dim chk As Boolean
        chk = common.validcheck(Me.cbCollege, "College")
        If chk = True Then
            Me.cbCollege.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbYear, "Year")
        If chk = True Then
            Me.tbYear.Focus()
            Exit Sub
        End If
        '//end of validation

        '//Save
        Dbo_Appointments = New Dbo_Appointments
        PutDbo_AppointmentsData2(Dbo_Appointments)
        Try
            If Not Dbo_AppointmentsDB.Add(Dbo_Appointments) Then
                MessageBox.Show("Error.")
            Else
                MessageBox.Show("Success.")
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            clearfields2()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub clearfields2()
        Me.tbPost2.Clear()
        Me.tbTotal2.Clear()
    End Sub

    Private Sub PutDbo_AppointmentsData2(ByVal dboStaff As Dbo_Appointments)
        Dbo_Appointments.MCollegeId = Me.cbCollege.SelectedValue
        Dbo_Appointments.MFyear = Trim(Me.tbYear.Text).ToString
        Dbo_Appointments.MCategory = "Admin"
        Dbo_Appointments.MSubCat = "Filling"
        Dbo_Appointments.MPost = Trim(Me.tbPost2.Text).ToString
        Dbo_Appointments.MSubject = ""
        Dbo_Appointments.MNumber = Trim(Me.tbTotal2.Text).ToString
    End Sub

    'Additional
    Private Sub btSave3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave3.Click
        '//validation
        Dim chk As Boolean
        chk = common.validcheck(Me.cbCollege, "College")
        If chk = True Then
            Me.cbCollege.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbYear, "Year")
        If chk = True Then
            Me.tbYear.Focus()
            Exit Sub
        End If
        '//end of validation

        '//Save
        Dbo_Appointments = New Dbo_Appointments
        PutDbo_AppointmentsData3(Dbo_Appointments)
        Try
            If Not Dbo_AppointmentsDB.Add(Dbo_Appointments) Then
                MessageBox.Show("Error.")
            Else
                MessageBox.Show("Success.")
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            clearfields3()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub clearfields3()
        Me.tbPost3.Clear()
        Me.tbTotal3.Clear()
    End Sub

    Private Sub PutDbo_AppointmentsData3(ByVal dboStaff As Dbo_Appointments)
        Dbo_Appointments.MCollegeId = Me.cbCollege.SelectedValue
        Dbo_Appointments.MFyear = Trim(Me.tbYear.Text).ToString
        Dbo_Appointments.MCategory = "Admin"
        Dbo_Appointments.MSubCat = "Additional"
        Dbo_Appointments.MPost = Trim(Me.tbPost3.Text).ToString
        Dbo_Appointments.MSubject = ""
        Dbo_Appointments.MNumber = Trim(Me.tbTotal3.Text).ToString
    End Sub

    Private Sub frm_AppointmentsAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        common.comboCollege(Me.cbCollege)
    End Sub

    Private Sub btCancel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel1.Click
        clearfields1()
    End Sub

    Private Sub btCancel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel2.Click
        clearfields2()
    End Sub

    Private Sub btCancel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel3.Click
        clearfields3()
    End Sub
End Class