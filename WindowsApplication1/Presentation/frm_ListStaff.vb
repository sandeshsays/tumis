Public Class frm_ListStaff

    Private Sub frm_ListStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        common.comboCollege(Me.cbCollege)
        With Me.DataGridView1
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        End With
    End Sub

    Private Sub loadgrid()
        Try
            Me.DataGridView1.Rows.Clear()
            Dim sql As String = "SELECT * FROM staff WHERE CollegeId='" & Me.cbCollege.SelectedValue & "' Order BY name "
            Dim datatoken As DataTable = tudataDB.GetDataTable(sql)
            If Not datatoken Is Nothing And datatoken.Rows.Count > 0 Then
                For Each row As DataRow In datatoken.Rows
                    Dim grow() As Object = {row.Item("id"), row.Item("name")} ', row.Item("address"), row.Item("district"), row.Item("affiliated")}
                    Me.DataGridView1.Rows.Add(grow)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tbCollege_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCollege.TextChanged
        If Me.cbCollege.Enabled = True Then
            loadgrid1()
        Else
            loadgrid2()
        End If
    End Sub

    Private Sub loadgrid1()
        Try
            Me.DataGridView1.Rows.Clear()
            Dim sql As String = "SELECT * FROM staff WHERE [name] LIKE '" & Me.tbCollege.Text & "%' AND CollegeId='" & Me.cbCollege.SelectedValue & "'"
            Dim datatoken As DataTable = tudataDB.GetDataTable(sql)
            If Not datatoken Is Nothing And datatoken.Rows.Count > 0 Then
                For Each row As DataRow In datatoken.Rows
                    Dim grow() As Object = {row.Item("id"), row.Item("name")} ', row.Item("address"), row.Item("district"), row.Item("affiliated")}
                    Me.DataGridView1.Rows.Add(grow)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub loadgrid2()
        Try
            Me.DataGridView1.Rows.Clear()
            Dim sql As String = "SELECT * FROM staff WHERE [name] LIKE '" & Me.tbCollege.Text & "%'"
            Dim datatoken As DataTable = tudataDB.GetDataTable(sql)
            If Not datatoken Is Nothing And datatoken.Rows.Count > 0 Then
                For Each row As DataRow In datatoken.Rows
                    Dim grow() As Object = {row.Item("id"), row.Item("name")} ', row.Item("address"), row.Item("district"), row.Item("affiliated")}
                    Me.DataGridView1.Rows.Add(grow)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        staffid = Me.DataGridView1.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If Me.RadioButton1.Checked = True Then
            Me.cbCollege.SelectedIndex = -1
            Me.cbCollege.Enabled = True
            Me.DataGridView1.Rows.Clear()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If Me.RadioButton2.Checked = True Then
            Me.cbCollege.SelectedIndex = -1
            Me.cbCollege.Enabled = False
            Me.DataGridView1.Rows.Clear()
        End If
    End Sub

    Private Sub cbCollege_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCollege.SelectedIndexChanged
        If TypeOf (Me.cbCollege.SelectedValue) Is System.Data.DataRowView Then Exit Sub
        loadgrid()
    End Sub
End Class