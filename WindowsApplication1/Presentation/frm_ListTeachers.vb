Public Class frm_ListTeachers

    Private Sub frm_ListTeachers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadgrid()
        With Me.DataGridView1
            .RowsDefaultCellStyle.BackColor = Color.Bisque
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
        End With
    End Sub

    Private Sub loadgrid()
        Try
            Me.DataGridView1.Rows.Clear()
            Dim datatoken As DataTable = tudataDB.GetDataTable("SELECT id as [Id],name as [Name] FROM teachers ORDER BY Name")
            If Not datatoken Is Nothing And datatoken.Rows.Count > 0 Then
                For Each row As DataRow In datatoken.Rows
                    'Dim grow() As Object = {row.Item("standard"), row.Item("id")}
                    'Me.DataGridView1.Rows.Add(grow)
                    Me.DataGridView1.DataSource = datatoken
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        teacherid = Me.DataGridView1.CurrentRow.Cells(0).Value
    End Sub
End Class