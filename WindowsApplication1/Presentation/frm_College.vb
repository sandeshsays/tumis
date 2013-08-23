Public Class frm_College

    Dim flag As Boolean = True
    Dim CollegeType As String
    Dim InsideTU As String
    Dim Faculty As String
    Dim Institute As String
    Dim Centre As String


    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        'form validation
        Dim chk As Boolean
        chk = common.validcheck(Me.tbName, "College Name")
        If chk = True Then
            Me.tbName.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.tbAddress, "Address")
        If chk = True Then
            Me.tbAddress.Focus()
            Exit Sub
        End If
        chk = common.validcheck(Me.cbDistrict, "District")
        If chk = True Then
            Me.cbDistrict.Focus()
            Exit Sub
        End If
       
        chk = common.IsItemExists(Me.tbName.Text, "[name]", "Colleges")
        If chk = True Then
            MsgBox("Please enter a different name.", MsgBoxStyle.Information)
        End If

        'college type
        If Me.rbAffiliated.Checked = True Then
            CollegeType = "Affiliated"
        ElseIf Me.rbConstituent.Checked = True Then
            CollegeType = "Constituent"
        Else
            MsgBox("Please select one.", MsgBoxStyle.Information)
            Exit Sub
        End If

        'Inside TU
        If Me.chkIsTU.Checked = True Then
            InsideTU = 1
        Else
            InsideTU = 0
        End If

        'faculties selected
        For i As Integer = 0 To chkFaculty.Items.Count - 1
            If chkFaculty.Items.Item(i).checked = True Then
                Faculty = Faculty + "," + i
            Else
                'do nothing
            End If
            i += 1
        Next



        'save record
        If flag = True Then
            'save
            Try
                Dim sql1 As String = "INSERT INTO Colleges VALUES ('" & Me.tbName.Text & "','" & Me.tbAddress.Text & "','" & Me.cbDistrict.Text & "','" & CollegeType & "','" & faculty & "','" & InsideTU & "')"
                Dim dt1 As DataTable = tudataDB.GetDataTable(sql1)
                MessageBox.Show(msgAdded)
                common.ClearTextBox(Me) 'clear all textboxes
                common.ClearComboBox(Me) 'clear all comboboxes
                Me.tbName.Focus() 'select first textbox
            Catch ex As Exception
                MessageBox.Show(msgNotAdded)
            End Try
        Else
            'update record
            Try
                Dim sql1 As String = "UPDATE Colleges SET [Name]='" & Me.tbName.Text & "',[Address]='" & Me.tbAddress.Text & "',District='" & Me.cbDistrict.Text & "',Affiliated='" & CollegeType & "',faculty='faculty',tu='" & InsideTU & "' WHERE Id='" & collegeid & "'"
                Dim dt1 As DataTable = tudataDB.GetDataTable(sql1)
                MessageBox.Show(msgUpdated)
                common.ClearTextBox(Me) 'clear all textboxes
                common.ClearComboBox(Me) 'clear all comboboxes
                Me.tbName.Focus() 'select first textbox
            Catch ex As Exception
                MessageBox.Show(msgConcurrencyError)
            End Try

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm_ListColleges.ShowDialog()
        If collegeid = "0" Then
            flag = True
            Exit Sub
        Else
            flag = False
            loadCollege()
        End If
    End Sub

    Private Sub loadCollege()
        Try
            Dim sql2 As String = "SELECT * FROM Colleges WHERE id='" & collegeid & "' "
            Dim dt2 As DataTable = tudataDB.GetDataTable(sql2)
            If Not dt2 Is Nothing And dt2.Rows.Count > 0 Then
                For Each row2 As DataRow In dt2.Rows
                    Me.tbName.Text = row2.Item("name")
                    Me.tbAddress.Text = row2.Item("address")
                    Me.cbDistrict.Text = row2.Item("district")
                    'Me.cbCollegeType.Text = row2.Item("affiliated")
                    'Me.cbFaculty.SelectedValue = row2.Item("faculty")
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If Me.tbName.Text = "" Then Exit Sub 'no college selected.

        '---DELETE 
        Dim result As DialogResult = MessageBox.Show(msgDelete, msgCaptionEntry, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Try
                Dim query As String = "DELETE FROM Colleges WHERE id = '" & collegeid & "'"
                Dim dt As DataTable = tudataDB.GetDataTable(query)
                MsgBox("College deleted successfully.", MsgBoxStyle.Information)
            Catch ex As Exception
                MessageBox.Show("Can not delete.")
            End Try

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub frm_College_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        common.chkInstitute(chkInstitute)
        common.chkFaculty(chkFaculty)
        common.chkOthers(chkCentres)
        common.comboDistrict(cbDistrict)
        If edit = True Then
            Me.Text = "Edit College"
        Else
            Me.Text = "Add New College"
        End If
    End Sub

    Private Sub frm_College_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        edit = False
    End Sub
End Class