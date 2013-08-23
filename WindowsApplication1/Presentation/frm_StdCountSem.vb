Public Class frm_StdCountSem

    Dim boys As Double = 0
    Dim girls As Double = 0
    Dim total As Double = 0

    Private Sub btCancel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel1.Click
        Me.Close()
    End Sub

    Private Sub frm_StdCountSem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        common.comboCollege(Me.cbCollege)
        common.comboStdLevel(Me.cbLevel)
    End Sub

    Private Sub btSave1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave1.Click

        'form validation
        Dim chk As Boolean
        chk = common.validcheck(Me.cbCollege, "College")
        If chk = True Then
            Me.cbCollege.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbAyear, "Academic Year")
        If chk = True Then
            Me.tbAyear.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbShift, "Shift")
        If chk = True Then
            Me.cbLevel.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbProgram, "Program")
        If chk = True Then
            Me.tbProgram.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.cbLevel, "Level")
        If chk = True Then
            Me.cbLevel.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbSemester, "Semester")
        If chk = True Then
            Me.tbSemester.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbBoys, "No. of male students")
        If chk = True Then
            Me.tbBoys.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbGirls, "No. of female students")
        If chk = True Then
            Me.tbGirls.Focus()
            Exit Sub
        End If
        'end validation

        Dim college_ As Integer = Me.cbCollege.SelectedValue
        Dim ayear As String = Me.tbAyear.Text
        Dim shift As String = Me.tbShift.Text
        Dim program As String = Me.tbProgram.Text
        Dim level_ As String = Me.cbLevel.Text
        Dim year_ As String = Me.tbSemester.Text 'semester
        Dim subject As String = Me.tbSubject.Text
       
        Try
            'total = System.Convert.ToInt32(Me.tbBoys.Text) + System.Convert.ToInt32(Me.tbGirls.Text)
            Dim sql As String = _
           "INSERT INTO SemWiseStdCnt(SemWiseStdCnt.College,SemWiseStdCnt.Ayear,SemWiseStdCnt.Shift,SemWiseStdCnt.Program,SemWiseStdCnt.[Level],SemWiseStdCnt.[Year],SemWiseStdCnt.Subject,SemWiseStdCnt.Boys,SemWiseStdCnt.Girls,SemWiseStdCnt.Total) " & _
           "VALUES('" & college_ & "','" & ayear & "','" & shift & "','" & program & "','" & level_ & "','" & year_ & "','" & subject & "','" & boys & "', '" & girls & "', '" & total & "')"
            Dim dt As DataTable = tudataDB.GetDataTable(sql)
            MsgBox("Records added successfully!", MsgBoxStyle.Information)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub totalstd()
        boys = IIf(Me.tbBoys.Text = "", 0, Me.tbBoys.Text)
        girls = IIf(Me.tbGirls.Text = "", 0, Me.tbGirls.Text)
        total = boys + girls
        Me.tbTotal.Text = total
    End Sub

    Private Sub tbBoys_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBoys.Leave
        totalstd()
    End Sub

    Private Sub tbGirls_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbGirls.Leave
        totalstd()
    End Sub

    Private Sub tbBoys_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbBoys.KeyPress
        common.validation(e)
    End Sub

    Private Sub tbGirls_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbGirls.TextChanged
        common.validation(e)
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click, Label16.Click, Label15.Click

    End Sub
End Class