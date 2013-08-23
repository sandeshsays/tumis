Public Class frm_PassedStudents

    Dim flag As Boolean = True
    Dim Dbo_PassedStudents As Dbo_PassedStudents


    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        '//Validation
        Dim chk As Boolean
        chk = common.validcheck(Me.tbYear, "Year")
        If chk = True Then
            Me.tbYear.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbLevel, "Name")
        If chk = True Then
            Me.tbLevel.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbPart, "Part")
        If chk = True Then
            Me.tbPart.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbPart, "Part")
        If chk = True Then
            Me.tbPart.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbMale, "Male")
        If chk = True Then
            Me.tbMale.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbFemale, "Female")
        If chk = True Then
            Me.tbFemale.Focus()
            Exit Sub
        End If
        If flag = False Then
            '//update record
            Dim newDbo_PassedStudents = New Dbo_PassedStudents
            Me.PutDbo_PassedStudentsData(newDbo_PassedStudents)
            Try
                If Not Dbo_PassedStudentsDB.Update(Dbo_PassedStudents, newDbo_PassedStudents) Then
                    MessageBox.Show(msgConcurrencyError, msgCaptionDBError, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.DialogResult = Windows.Forms.DialogResult.Retry
                Else
                    Dbo_PassedStudents = newDbo_PassedStudents
                    MessageBox.Show(msgUpdated, msgCaptionEntry, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
                '//reset form
                'common.ClearTextBox(Me)
                Me.tbMale.Text = 0
                Me.tbFemale.Text = 0
                Me.tbTotal.Text = 0
                '//load data
                loadgrid()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.GetType.ToString)
            End Try
        ElseIf flag = True Then
            '//Save
            Dbo_PassedStudents = New Dbo_PassedStudents
            PutDbo_PassedStudentsData(Dbo_PassedStudents)
            Try
                If Not Dbo_PassedStudentsDB.Add(Dbo_PassedStudents) Then
                    MessageBox.Show(msgNotAdded)
                Else
                    MessageBox.Show(msgAdded)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
                '//reset form
                'common.ClearTextBox(Me)
                Me.tbMale.Text = 0
                Me.tbFemale.Text = 0
                Me.tbTotal.Text = 0
                '//load data
                loadgrid()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.GetType.ToString)
            End Try
        End If
    End Sub

    Private Sub loadgrid()
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.Rows.Clear()
        Dim sql As String = "SELECT * FROM PassedStudents ORDER BY [year],[level],[part]"
        Dim dt As DataTable = tudataDB.GetDataTable(sql)
        If Not dt Is Nothing And dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                Me.DataGridView1.DataSource = dt
            Next
        End If
        '//count rows
        Me.tot_rec.Text = Me.DataGridView1.Rows.Count
    End Sub

    Private Sub PutDbo_PassedStudentsData(ByVal dboPassedStudents As Dbo_PassedStudents)
        dboPassedStudents.MYear = Me.tbYear.Text
        dboPassedStudents.MLevel = Me.tbLevel.Text
        dboPassedStudents.MPart = Me.tbPart.Text
        dboPassedStudents.MMale = Me.tbMale.Text
        dboPassedStudents.MFemale = Me.tbFemale.Text
        dboPassedStudents.MTotal = Me.tbTotal.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        common.ClearTextBox(Me)
    End Sub

    Private Sub tbMale_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbMale.KeyPress
        common.validation(e)
    End Sub

    Private Sub tbFemale_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbFemale.KeyPress
        common.validation(e)
    End Sub

    Private Sub tbYear_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbYear.KeyPress
        common.validation(e)
    End Sub

    Private Sub tbMale_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbMale.Leave
        CalculateTotal()
    End Sub

    Private Sub CalculateTotal()
        Me.tbTotal.Text = System.Convert.ToDouble(Me.tbMale.Text) + System.Convert.ToDouble(Me.tbFemale.Text)
    End Sub

    Private Sub tbFemale_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbFemale.TextChanged
        CalculateTotal()
    End Sub

    Private Sub tbPart_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbPart.KeyPress
        common.validation(e)
    End Sub

    Private Sub frm_PassedStudents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadgrid()
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        flag = False
        Me.tbYear.Text = Me.DataGridView1.CurrentRow.Cells(0).Value
        Me.tbLevel.Text = Me.DataGridView1.CurrentRow.Cells(1).Value
        Me.tbPart.Text = Me.DataGridView1.CurrentRow.Cells(2).Value
        Me.tbMale.Text = Me.DataGridView1.CurrentRow.Cells(3).Value
        Me.tbFemale.Text = Me.DataGridView1.CurrentRow.Cells(4).Value
        Me.tbTotal.Text = Me.DataGridView1.CurrentRow.Cells(5).Value
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Me.DataGridView1.Rows.Count = 0 Then
            MsgBox("No records to print!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        '//Export to Excel
        Dim wapp As Microsoft.Office.Interop.Excel.Application
        Dim wsheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim wbook As Microsoft.Office.Interop.Excel.Workbook
        'Dim dt As DataTable = tudataDB.GetDataTable("SELECT * FROM exam_termresult WHERE gcode='" & MarksLedger.Lgroup & "' AND termid ='" & MarksLedger.Lterm & "' AND acayear='" & MarksLedger.Lyear & "' ")
        'If Not dt Is Nothing And dt.Rows.Count > 0 Then
        wapp = New Microsoft.Office.Interop.Excel.Application
        wapp.Visible = True
        wbook = wapp.Workbooks.Add()

        wsheet = wbook.ActiveSheet
        Dim iX As Integer
        Dim iY As Integer
        Dim iC As Integer
        Dim X As Integer = 1
        For iC = 0 To DataGridView1.Columns.Count - 1
            wsheet.Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText
            wsheet.Cells(1, iC + 1).font.bold = True
            wsheet.Cells(1, iC + 1).font.italic = True
            wsheet.Cells(1, iC + 1).font.color = 500
        Next
        For iX = 0 To DataGridView1.Rows.Count - 1
            For iY = 0 To DataGridView1.Columns.Count - 1
                wsheet.Cells(X + 1, iY + 1).value = DataGridView1(iY, iX).Value.ToString
            Next
            X = X + 1
        Next
    End Sub
End Class