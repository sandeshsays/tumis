Public Class frm_StdCountYear

    Dim boys As Double = 0
    Dim girls As Double = 0
    Dim total As Double = 0

    Private Sub frm_StdCountYear_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        common.comboCollege(Me.cbCollege)
        common.comboStdLevel(Me.cbLevel)
    End Sub

    Private Sub btCancel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel1.Click
        Me.Close()
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
        chk = common.validcheck(Me.cbLevel, "Level")
        If chk = True Then
            Me.cbLevel.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.cbYear, "Year")
        If chk = True Then
            Me.cbYear.Focus()
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
        Dim id As Integer = 0
        Dim sql1 As String = _
        "SELECT id FROM YearWiseStdCnt WHERE College='" & Me.cbCollege.SelectedValue & "' " & _
        "AND Ayear='" & Me.tbAyear.Text & "' AND [Level]='" & Me.cbLevel.Text & "' AND [Year]='" & Me.cbYear.Text & "' AND Subject='" & Me.tbSubject.Text & "'"
        Dim dt As DataTable = tudataDB.GetDataTable(sql1)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                id = row.Item("id")
            Next
            Dim ans As DialogResult = MsgBox("Record exists. Do you want to update it?", MsgBoxStyle.YesNo)
            If ans = Windows.Forms.DialogResult.Yes Then
                'update
                Dim sql2 As String = _
                "UPDATE YearWiseStdCnt SET Boys='" & boys & "',Girls='" & girls & "',total='" & total & "' WHERE Id='" & id & "'"
                Dim dt2 As DataTable = tudataDB.GetDataTable(sql2)
                MsgBox("Records updated successfully!", MsgBoxStyle.Information)
            Else
                Exit Sub
            End If
        Else
            'save only
            Dim college_ As Integer = Me.cbCollege.SelectedValue
            Dim ayear As String = Me.tbAyear.Text
            Dim level_ As String = Me.cbLevel.Text
            Dim year_ As String = Me.cbYear.Text
            Dim subject As String = Me.tbSubject.Text

            Try
                Dim sql As String = _
               "INSERT INTO YearWiseStdCnt(YearWiseStdCnt.College,YearWiseStdCnt.Ayear,YearWiseStdCnt.[Level],YearWiseStdCnt.[Year],YearWiseStdCnt.Subject,YearWiseStdCnt.Boys,YearWiseStdCnt.Girls,YearWiseStdCnt.Total) " & _
               "VALUES('" & college_ & "','" & ayear & "','" & level_ & "','" & year_ & "','" & subject & "','" & boys & "', '" & girls & "', '" & total & "')"
                Dim dt3 As DataTable = tudataDB.GetDataTable(sql)
                MsgBox("Records added successfully!", MsgBoxStyle.Information)
            Catch ex As Exception

            End Try
        End If
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

    Private Sub cbLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLevel.SelectedIndexChanged
        If TypeOf (Me.cbLevel.SelectedValue) Is System.Data.DataRowView Then Exit Sub
        common.combolevelwiseyear(Me.cbLevel.SelectedValue, Me.cbyear)
    End Sub

    Private Sub tbBoys_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbBoys.KeyPress
        common.validation(e)
    End Sub

    Private Sub tbGirls_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbGirls.KeyPress
        common.validation(e)
    End Sub
End Class