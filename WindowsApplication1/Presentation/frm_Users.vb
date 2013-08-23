Public Class frm_Users

    Dim flag As Boolean = True


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'form validation
        Dim chk As Boolean
        chk = common.validcheck(Me.tbUsername, "Username")
        If chk = True Then
            Me.tbUsername.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbPassword, "Password")
        If chk = True Then
            Me.tbPassword.Focus()
            Exit Sub
        End If

        chk = common.validcheck(Me.tbConfirm, "Confirm Password")
        If chk = True Then
            Me.tbConfirm.Focus()
            Exit Sub
        End If
        If tbPassword.Text <> tbConfirm.Text Then
            MessageBox.Show(PasswordMismatch)
            Me.tbConfirm.Clear()
            Me.tbConfirm.Focus()
            Exit Sub
        End If
        'save record
        If flag = True Then
            'save
            Try
                Dim sql1 As String = "INSERT INTO Users VALUES ('" & Me.tbUsername.Text & "','" & Me.tbPassword.Text & "')"
                Dim dt1 As DataTable = tudataDB.GetDataTable(sql1)
                MessageBox.Show(msgAdded)
                common.ClearTextBox(Me) 'clear all textboxes
                common.ClearComboBox(Me) 'clear all comboboxes
                Me.tbUsername.Focus() 'select first textbox
            Catch ex As Exception
                MessageBox.Show(msgNotAdded)
            End Try
        Else
            'update
            Try
                Dim sql1 As String = "UPDATE Users SET [username]='" & Me.tbUsername.Text & "',[password]='" & Me.tbPassword.Text & "' WHERE Id='" & userid & "'"
                Dim dt1 As DataTable = tudataDB.GetDataTable(sql1)
                MessageBox.Show(msgUpdated)
                common.ClearTextBox(Me) 'clear all textboxes
                common.ClearComboBox(Me) 'clear all comboboxes
                Me.tbUsername.Focus() 'select first textbox
            Catch ex As Exception
                MessageBox.Show(msgConcurrencyError)
            End Try

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'form validation
        Dim chk As Boolean
        chk = common.validcheck(Me.tbUsername1, "Username")
        If chk = True Then
            Me.tbUsername1.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbOldPassword, "Old Password")
        If chk = True Then
            Me.tbOldPassword.Focus()
            Exit Sub
        End If
        GetValidUsernamePassword()
        chk = common.validcheck(Me.tbNewPassword, "New Password")
        If chk = True Then
            Me.tbNewPassword.Focus()
            Exit Sub
        End If
        GetUserid()
        'update
        Try
            Dim sql1 As String = "UPDATE Users SET [username]='" & Me.tbUsername1.Text & "',[password]='" & Me.tbNewPassword.Text & "' WHERE Id='" & userid & "'"
            Dim dt1 As DataTable = tudataDB.GetDataTable(sql1)
            MessageBox.Show(msgUpdated)
            common.ClearTextBox(Me) 'clear all textboxes
            common.ClearComboBox(Me) 'clear all comboboxes
            Me.tbUsername.Focus() 'select first textbox
        Catch ex As Exception
            MessageBox.Show(msgConcurrencyError)
        End Try

    End Sub

    Private Sub GetUserid()
        Dim dt3 As DataTable = tudataDB.GetDataTable("select id from users where username = '" & tbUsername1.Text & "'")
        If Not dt3 Is Nothing And dt3.Rows.Count > 0 Then
            For Each row As DataRow In dt3.Rows
                userid = row.Item("id")
            Next
        Else
            MessageBox.Show(msgUserNotFound)
            Exit Sub
        End If
    End Sub

    Private Sub GetValidUsernamePassword()
        Dim dt3 As DataTable = tudataDB.GetDataTable("select id from users where username = '" & tbUsername1.Text & "' and password='" & tbOldPassword.Text & "'")
        If Not dt3 Is Nothing And dt3.Rows.Count > 0 Then
            For Each row As DataRow In dt3.Rows
                userid = row.Item("id")
            Next
        Else
            MessageBox.Show(PasswordMismatch)
            Exit Sub
        End If
    End Sub
End Class