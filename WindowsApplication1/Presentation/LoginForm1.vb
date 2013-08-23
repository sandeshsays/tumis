Imports System.Threading

Public Class LoginForm1

    Dim secret As String
    Private th As Thread


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Me.Close()
        Dim chk = common.validcheck(Me.UsernameTextBox, "Username")
        If chk = True Then
            Exit Sub
        End If
        chk = common.validcheck(Me.PasswordTextBox, "Password")
        If chk = True Then
            Exit Sub
        End If
        'secret = common.getMD5Hash(Me.PasswordTextBox.Text)
        secret = Me.PasswordTextBox.Text

        Try
            Dim sql As String = "select * from users where username='" & UsernameTextBox.Text & "' and password='" & secret & "'"
            Dim dt As DataTable = tudataDB.GetDataTable(sql)

            If (dt.Rows.Count <= 0) Then
                MessageBox.Show("Invalid username or password !")
                Exit Sub
            End If

            Me.Close()

            OpenMainForm()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub OpenMainForm()
        th = New Thread(AddressOf OpenForm)
        th.SetApartmentState(ApartmentState.STA)
        Application.Exit()
        th.Start()
    End Sub

    Private Sub OpenForm()
        Dim frm As New Form1
        frm.ShowDialog()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
