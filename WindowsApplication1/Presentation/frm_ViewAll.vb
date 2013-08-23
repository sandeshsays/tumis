Imports System.Drawing.Printing

Public Class frm_ViewAll

    Private MyDataGridViewPrinter As DataGridViewPrinter

    Private Sub frm_ViewAll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        common.comboCollege(Me.ComboBox1)
        With Me.DataGridView1
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        End With
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If TypeOf (Me.ComboBox2.SelectedValue) Is System.Data.DataRowView Then Exit Sub
        If Me.ComboBox2.Text = "Teachers" Then
            Me.DataGridView1.DataSource = Nothing
            loadteachers()
        ElseIf Me.ComboBox2.Text = "Staff" Then
            Me.DataGridView1.DataSource = Nothing
            loadstaff()
        End If
    End Sub
    Private Sub loadteachers()
        Try
            Me.DataGridView1.Rows.Clear()
            Dim sql As String = _
            "SELECT [Name] as [Name], Address as [Address],Gender as [Gedner],dobNep as [DOB(BS)]," & _
            "convert(varchar,dob,101) as [DOB(AD)],post as [Post],EmpType as [Employee Type],SerType as [Service], " & _
            "AppDateNep as [Appointed(BS)],convert(varchar,AppDate,101) as [Appointed(AD)],SerDuration as [Ser. Duration], " & _
            "RetDateNep as [Retirement(BS)],convert(varchar,RetDate,101) as [Retirement(AD)],FieldOfStudy as [Field Of Study], " & _
            "TeachingSubject as [Subject Taught],TeachingLevel as [Level Taught],Specialization as [Specialization],  " & _
            "Qualification as [Qualification], LeaveType as [Leave], Wages as [Wages],  " & _
            "WeeklyWtg, MonthlyWtg, MonthlyWtgExtra, Department, Training " & _
            "FROM teachers WHERE collegeid='" & Me.ComboBox1.SelectedValue & "' AND status='1' ORDER BY name"
            Dim datatoken As DataTable = tudataDB.GetDataTable(sql)
            If Not datatoken Is Nothing And datatoken.Rows.Count > 0 Then
                For Each row As DataRow In datatoken.Rows
                    'Dim grow() As Object = {row.Item("id"), row.Item("name")} ', row.Item("address"), row.Item("district"), row.Item("affiliated")}
                    'Me.DataGridView1.Rows.Add(grow)
                    Me.DataGridView1.DataSource = datatoken
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub loadstaff()
        Try
            Me.DataGridView1.Rows.Clear()
            Dim sql As String = _
            "SELECT [Name] as [Name], Address as [Address],Gender as [Gedner],dobNep as [DOB(BS)],convert(varchar,dob,101) as [BOB(AD)]," & _
            "post as [Post],EmpType as [Employee Type],SerType as [Service],AppDateNep as [Appointed Date (BS)],convert(varchar,AppDate,101) as [Appointed Date (AD)], " & _
            "SerDuration as [Service Duration],RetDateNep as [Retirement Date(BS)],convert(varchar,RetDate,101) as [Retirement Date (AD)], " & _
            "Qualification,LeaveType as [Leave],Department,Training  " & _
            "FROM Staff WHERE collegeid='" & Me.ComboBox1.SelectedValue & "' AND status='1' ORDER BY name"
            Dim datatoken As DataTable = tudataDB.GetDataTable(sql)
            If Not datatoken Is Nothing And datatoken.Rows.Count > 0 Then
                For Each row As DataRow In datatoken.Rows
                    'Dim grow() As Object = {row.Item("id"), row.Item("name")} ', row.Item("address"), row.Item("district"), row.Item("affiliated")}
                    'Me.DataGridView1.Rows.Add(grow)
                    Me.DataGridView1.DataSource = datatoken
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If TypeOf (Me.ComboBox2.SelectedValue) Is System.Data.DataRowView Then Exit Sub
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.Rows.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
        ' Else
        ' MsgBox("Result is not available", MsgBoxStyle.Information)
        ' End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If SetupThePrinting() Then
            Dim MyPrintPreviewDialog As New PrintPreviewDialog()
            MyPrintPreviewDialog.Document = MyPrintDocument
            MyPrintPreviewDialog.ShowDialog()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If SetupThePrinting() Then
            MyPrintDocument.Print()
        End If
    End Sub

    Private Function SetupThePrinting() As Boolean
        Dim MyPrintDialog As New PrintDialog()
        MyPrintDialog.AllowCurrentPage = False
        MyPrintDialog.AllowPrintToFile = False
        MyPrintDialog.AllowSelection = False
        MyPrintDialog.AllowSomePages = False
        MyPrintDialog.PrintToFile = False
        MyPrintDialog.ShowHelp = False
        MyPrintDialog.ShowNetwork = False

        If MyPrintDialog.ShowDialog() <> DialogResult.OK Then
            Return False
        End If

        MyPrintDocument.DocumentName = "List"
        MyPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings
        MyPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings
        MyPrintDocument.DefaultPageSettings.Margins = New Margins(40, 40, 40, 40)
        MyPrintDocument.DefaultPageSettings.Landscape = True

        Dim title As String = "List" '+ MarksLedger.Lterm + " " + MarksLedger.Lyear
        If MessageBox.Show("Do you want the report to be centered on the page", "Center on Page", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MyDataGridViewPrinter = New DataGridViewPrinter(DataGridView1, MyPrintDocument, True, True, title, New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), _
             Color.Black, True)
        Else
            MyDataGridViewPrinter = New DataGridViewPrinter(DataGridView1, MyPrintDocument, False, True, title, New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), _
             Color.Black, True)
        End If

        Return True
    End Function
End Class