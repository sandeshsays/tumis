Public Class frm_RetireList

    Private Sub frm_RetireList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If retirelist = 0 Then
            'load teachers
            If singleYear = 1 Then

                Dim sql1 As String = "select id,[name],[appdatenep],[retdatenep] from teachers where retdatenep like '%" & year & "' and status ='1' and collegeid='" & collegeid & "'"
                Dim dt1 As DataTable = tudataDB.GetDataTable(sql1)
                If Not dt1 Is Nothing And dt1.Rows.Count > 0 Then
                    For Each row As DataRow In dt1.Rows
                        Dim grow() As Object = {row.Item("id"), row.Item("name"), row.Item("appdatenep"), row.Item("retdatenep")}
                        Me.DataGridView1.Rows.Add(grow)
                    Next
                End If

            ElseIf multiYear = 1 Then

            End If
            
        ElseIf retirelist = 1 Then
            'load staff
            If singleYear = 1 Then

                Dim sql2 As String = "select id,[name],[appdatenep],[retdatenep] from staff where retdatenep like '%" & year & "' and status ='1' and collegeid='" & collegeid & "'"
                Dim dt2 As DataTable = tudataDB.GetDataTable(sql2)
                If Not dt2 Is Nothing And dt2.Rows.Count > 0 Then
                    For Each row As DataRow In dt2.Rows
                        Dim grow() As Object = {row.Item("id"), row.Item("name"), row.Item("appdatenep"), row.Item("retdatenep")}
                        Me.DataGridView1.Rows.Add(grow)
                    Next
                End If

            ElseIf multiYear = 1 Then

            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
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