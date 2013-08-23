Public Class frm_ListColleges

    Dim datatoken As DataTable

    Private Sub frm_ListColleges_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.tbCollege.Clear()
        loadgrid()
        With Me.DataGridView1
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        End With
    End Sub

    Private Sub loadgrid()
        Try
            DataGridView1.DataSource = Nothing
            Me.DataGridView1.Rows.Clear()
            Dim sql As String = _
            "SELECT [id],[name],[address] FROM Colleges order by [name]"
            Dim datatoken As DataTable = tudataDB.GetDataTable(sql)
            If Not datatoken Is Nothing And datatoken.Rows.Count > 0 Then
                For Each row As DataRow In datatoken.Rows
                    Dim grow() As Object = {row.Item("id"), row.Item("name"), row.Item("address")}
                    Me.DataGridView1.Rows.Add(grow)
                    'DataGridView1.DataSource = datatoken
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Dim a As String = Me.DataGridView1.CurrentRow.Cells(0).Value
        'MsgBox(a)
        collegeid = Me.DataGridView1.CurrentRow.Cells(0).Value
        edit = True
        Me.Close()
        'frm_College.ShowDialog()

    End Sub

    Private Sub tbCollege_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCollege.TextChanged
        loadgrid1()
    End Sub

    Private Sub loadgrid1()
        Try
            DataGridView1.DataSource = Nothing
            Me.DataGridView1.Rows.Clear()
            Dim sql As String = "SELECT [id],[name],[address] FROM Colleges WHERE [name] LIKE '" & Me.tbCollege.Text & "%'"
            datatoken = tudataDB.GetDataTable(sql)
            If Not datatoken Is Nothing And datatoken.Rows.Count > 0 Then
                For Each row As DataRow In datatoken.Rows
                    Dim grow() As Object = {row.Item("id"), row.Item("name"), row.Item("address")}
                    Me.DataGridView1.Rows.Add(grow)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class