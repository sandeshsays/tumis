Imports System.Data.SqlClient
Imports System.IO

Public Class common

    Public Shared Function getMD5Hash(ByVal strToHash As String) As String
        Dim md5Obj As New Security.Cryptography.MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = md5Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult
    End Function
    Public Shared Function IsMdiChildExists(ByVal parentForm As Form, ByVal name As String) As Boolean
        For Each frmChild As Form In parentForm.MdiChildren
            If (frmChild.Name = name) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Shared Function ReadFile(ByVal fileName As String) As String
        Dim str As String = Nothing
        Try
            Dim obj As Object = Nothing
            Dim dir As String = System.AppDomain.CurrentDomain.BaseDirectory()
            Dim sr As StreamReader = New StreamReader(dir & fileName)
            str = sr.ReadToEnd()
            sr.Close()
            sr = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        Return str.Trim()
    End Function

    Public Shared Sub WriteFile(ByVal filename As String, ByVal content As String)
        Dim sw As StreamWriter
        Try
            sw = New StreamWriter(filename, False)
            sw.Write(content)
            sw.Close()
            sw = Nothing
        Catch
        End Try
    End Sub

    Public Shared Function CreateDbBackup(ByVal path As String)
        Dim retValue As Int32 = -1
        Try
            Using con As SqlConnection = tudataDB.GetConnection()
                Using cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandText = "CreateDbBackup"
                    cmd.Parameters.AddWithValue("@fileName", path)
                    cmd.CommandType = CommandType.StoredProcedure
                    con.Open()
                    retValue = cmd.ExecuteNonQuery()
                    con.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return retValue
    End Function

    Public Shared Function RestoreDb(ByVal backFileName As String, ByVal dbNameToRestore As String) As Int32
        Dim retValue As Int32 = -1
        Try
            Dim constring As String = common.ReadFile("Sms@.@")
            Using con As SqlConnection = New SqlConnection(constring)
                Using cmd As SqlCommand = con.CreateCommand()

                    cmd.CommandText = "use master; RESTORE DATABASE " & dbNameToRestore & " FROM DISK = '" & backFileName & "' WITH   replace;"
                    cmd.CommandType = CommandType.Text
                    con.Open()
                    retValue = cmd.ExecuteNonQuery()
                    con.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return retValue

    End Function

    '------------------------------------------------DATE CONVERSION-------------------------------------------------------------------------------
    Public Shared Function engtonepalidate(ByVal edate As String)

        If edate = "" Or edate = "  /  /" Then
            Return False
            'Exit Function
        End If

        Dim dt As Date = edate

        Dim dt2 As DataTable = tudataDB.GetDataTable("select * from Nepyear where Nepyear_estrdate<='" & dt & "' and Nepyear_eenddate>='" & dt & "'")
        If Not dt2 Is Nothing And dt2.Rows().Count() > 0 Then
            Dim nyear As String = dt2.Rows(0).Item("Nepyear_nyear")
            Dim x As Date = dt2.Rows(0).Item("Nepyear_estrdate")
            Dim days As Integer = DateDiff(DateInterval.Day, x, dt)
            Dim months As String = 0
            Dim day As Integer = 0
            Dim max As Integer = 366
            Dim adddays As Integer = dt2.Rows(0).Item("m1")

            If days < adddays Then
                months = "01"
                day = dt2.Rows(0).Item("m1") - (adddays - days)
                days = max
            Else
                day = dt2.Rows(0).Item("m1")
                adddays = adddays + dt2.Rows(0).Item("m2")
            End If
            If days < adddays Then
                months = "02"
                day = dt2.Rows(0).Item("m2") - (adddays - days)
                days = max
            Else
                adddays = adddays + dt2.Rows(0).Item("m3")
            End If
            If days < adddays Then
                months = "03"
                day = dt2.Rows(0).Item("m3") - (adddays - days)
                days = max
            Else
                adddays = adddays + dt2.Rows(0).Item("m4")
            End If
            If days < adddays Then
                months = "04"
                day = dt2.Rows(0).Item("m4") - (adddays - days)
                days = max
            Else
                adddays = adddays + dt2.Rows(0).Item("m5")
            End If
            If days < adddays Then
                months = "05"
                day = dt2.Rows(0).Item("m5") - (adddays - days)
                days = max
            Else
                adddays = adddays + dt2.Rows(0).Item("m6")
            End If
            If days < adddays Then
                months = "06"
                day = dt2.Rows(0).Item("m6") - (adddays - days)
                days = max
            Else
                adddays = adddays + dt2.Rows(0).Item("m7")
            End If
            If days < adddays Then
                months = "07"
                day = dt2.Rows(0).Item("m7") - (adddays - days)
                days = max
            Else
                adddays = adddays + dt2.Rows(0).Item("m8")
            End If
            If days < adddays Then
                months = "08"
                day = dt2.Rows(0).Item("m8") - (adddays - days)
                days = max
            Else
                adddays = adddays + dt2.Rows(0).Item("m9")
            End If
            If days < adddays Then
                months = "09"
                day = dt2.Rows(0).Item("m9") - (adddays - days)
                days = max
            Else
                adddays = adddays + dt2.Rows(0).Item("m10")
            End If
            If days < adddays Then
                months = "10"
                day = dt2.Rows(0).Item("m10") - (adddays - days)
                days = max
            Else
                adddays = adddays + dt2.Rows(0).Item("m11")
            End If
            If days < adddays Then
                months = "11"
                day = dt2.Rows(0).Item("m11") - (adddays - days)
                days = max
            Else
                adddays = adddays + dt2.Rows(0).Item("m12")
            End If
            If days < adddays Then
                months = "12"
                day = dt2.Rows(0).Item("m12") - (adddays - days)
                days = max

            End If
            Dim daynew As String
            If day + 1 <= 9 Then
                daynew = "0" & day + 1
            Else
                daynew = day + 1
            End If
            Dim da As String = months & "/" & daynew & "/" & nyear
            'Dim daa As String = months & "/" & daynew & "/" & nyear
            Return da
        End If
        Return False
    End Function

    Public Shared Function NeptoEngDate(ByVal a As String, ByVal b As Control, ByVal c As Control)
        Dim yr As String
        Dim mth As String
        Dim day As String
        If a = "  /  /" Then
            Return False
            'Exit Function
        End If
        yr = Mid(a, 7, 4)

        If yr = "" Then
            MessageBox.Show("Invalid Day.")
            c.Focus()
            Return False
        End If

        day = Mid(a, 4, 2)
        mth = Mid(a, 1, 2)

        'b.Text = mth & day & yr

        Dim tday As Integer = 0



        Dim dt As DataTable = tudataDB.GetDataTable("select * from Nepyear where Nepyear_nyear=" + yr)
        If Not dt Is Nothing And dt.Rows().Count() > 0 Then
            Dim d As Date = dt.Rows(0).Item("Nepyear_estrdate")

            If mth = "01" Then
                tday = tday + day
                If day <= dt.Rows(0).Item("m1") And day <> 0 Then
                    b.Text = d.AddDays(tday - 1)
                Else
                    MessageBox.Show("Invalid Day.")
                End If

            ElseIf mth = "02" Then

                tday = dt.Rows(0).Item("m1") + day
                If day <= dt.Rows(0).Item("m2") And day <> 0 Then
                    b.Text = d.AddDays(tday - 1)
                Else
                    MessageBox.Show("Invalid Day.")
                End If
            ElseIf mth = "03" Then
                tday = dt.Rows(0).Item("m1") + dt.Rows(0).Item("m2") + day
                If day <= dt.Rows(0).Item("m3") And day <> 0 Then
                    b.Text = d.AddDays(tday - 1)
                Else
                    MessageBox.Show("Invalid Day.")
                End If
            ElseIf mth = "04" Then
                tday = dt.Rows(0).Item("m1") + dt.Rows(0).Item("m2") + dt.Rows(0).Item("m3") + day
                If day <= dt.Rows(0).Item("m4") And day <> 0 Then
                    b.Text = d.AddDays(tday - 1)
                Else
                    MessageBox.Show("Invalid Day.")
                End If
            ElseIf mth = "05" Then
                tday = dt.Rows(0).Item("m1") + dt.Rows(0).Item("m2") + dt.Rows(0).Item("m3") + dt.Rows(0).Item("m4") + day
                If day <= dt.Rows(0).Item("m5") And day <> 0 Then
                    b.Text = d.AddDays(tday - 1)
                Else
                    MessageBox.Show("Invalid Day.")
                End If
            ElseIf mth = "06" Then
                tday = dt.Rows(0).Item("m1") + dt.Rows(0).Item("m2") + dt.Rows(0).Item("m3") + dt.Rows(0).Item("m4") + dt.Rows(0).Item("m5") + day
                If day <= dt.Rows(0).Item("m6") And day <> 0 Then
                    b.Text = d.AddDays(tday - 1)
                Else
                    MessageBox.Show("Invalid Day.")
                End If
            ElseIf mth = "07" Then
                tday = dt.Rows(0).Item("m1") + dt.Rows(0).Item("m2") + dt.Rows(0).Item("m3") + dt.Rows(0).Item("m4") + dt.Rows(0).Item("m5") + dt.Rows(0).Item("m6") + day
                If day <= dt.Rows(0).Item("m7") And day <> 0 Then
                    b.Text = d.AddDays(tday - 1)
                Else
                    MessageBox.Show("Invalid Day.")
                End If
            ElseIf mth = "08" Then
                tday = dt.Rows(0).Item("m1") + dt.Rows(0).Item("m2") + dt.Rows(0).Item("m3") + dt.Rows(0).Item("m4") + dt.Rows(0).Item("m5") + dt.Rows(0).Item("m6") + dt.Rows(0).Item("m7") + day
                If day <= dt.Rows(0).Item("m8") And day <> 0 Then
                    b.Text = d.AddDays(tday - 1)
                Else
                    MessageBox.Show("Invalid Day.")
                End If
            ElseIf mth = "09" Then
                tday = dt.Rows(0).Item("m1") + dt.Rows(0).Item("m2") + dt.Rows(0).Item("m3") + dt.Rows(0).Item("m4") + dt.Rows(0).Item("m5") + dt.Rows(0).Item("m6") + dt.Rows(0).Item("m7") + dt.Rows(0).Item("m8") + day
                If day <= dt.Rows(0).Item("m9") And day <> 0 Then
                    b.Text = d.AddDays(tday - 1)
                Else
                    MessageBox.Show("Invalid Day.")
                End If
            ElseIf mth = "10" Then
                tday = dt.Rows(0).Item("m1") + dt.Rows(0).Item("m2") + dt.Rows(0).Item("m3") + dt.Rows(0).Item("m4") + dt.Rows(0).Item("m5") + dt.Rows(0).Item("m6") + dt.Rows(0).Item("m7") + dt.Rows(0).Item("m8") + dt.Rows(0).Item("m9") + day
                If day <= dt.Rows(0).Item("m10") And day <> 0 Then
                    b.Text = d.AddDays(tday - 1)
                Else
                    MessageBox.Show("Invalid Day.")
                End If
            ElseIf mth = "11" Then
                tday = dt.Rows(0).Item("m1") + dt.Rows(0).Item("m2") + dt.Rows(0).Item("m3") + dt.Rows(0).Item("m4") + dt.Rows(0).Item("m5") + dt.Rows(0).Item("m6") + dt.Rows(0).Item("m7") + dt.Rows(0).Item("m8") + dt.Rows(0).Item("m9") + dt.Rows(0).Item("m10") + day
                If day <= dt.Rows(0).Item("m11") And day <> 0 Then
                    b.Text = d.AddDays(tday - 1)
                Else
                    MessageBox.Show("Invalid Day.")
                End If
            ElseIf mth = "12" Then
                tday = dt.Rows(0).Item("m1") + dt.Rows(0).Item("m2") + dt.Rows(0).Item("m3") + dt.Rows(0).Item("m4") + dt.Rows(0).Item("m5") + dt.Rows(0).Item("m6") + dt.Rows(0).Item("m7") + dt.Rows(0).Item("m8") + dt.Rows(0).Item("m9") + dt.Rows(0).Item("m10") + dt.Rows(0).Item("m11") + day
                If day <= dt.Rows(0).Item("m12") And day <> 0 Then
                    b.Text = d.AddDays(tday - 1)
                Else
                    MessageBox.Show("Invalid Day.")
                    c.Text = "    ÷  ÷"
                    b.Text = ""
                End If
            Else
                MessageBox.Show("invalid month")
                c.Text = "    ÷  ÷"
                b.Text = ""
            End If

        Else
            MessageBox.Show("Invalid date")
            c.Text = "    ÷  ÷"
            b.Text = ""
        End If

        Return False

    End Function

    '------------------------------------end of date conversion------------------------------------------

    '''''''''''''''''''''''''''''''''''''validation Starts''''''''''''''''''''''''''''''''''''''''

    Public Shared Function combovalid(ByVal combo As ComboBox)
        If combo.Text <> "" Then
            If combo.FindStringExact(combo.Text) = True Then
                MessageBox.Show("Select from list")
                combo.Focus()
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Shared Function validcheck(ByVal field As Control, ByVal name As String)
        If Trim(field.Text) = "" Then
            MessageBox.Show(name.ToString & " " & "is required")
            field.Select()
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function NumericCheck(ByVal field As Control, ByVal name As String)
        If Not IsNumeric(field.Text) Then
            MessageBox.Show(name.ToString & " " & "must contain numeric value")
            field.Select()
            Return True
        Else
            If field.Text < 1 Then
                MessageBox.Show(name.ToString & " " & "is required")
                field.Select()
                Return True
            End If
        End If
        Return False
    End Function

    Public Shared Function NumericChecknovalue(ByVal field As Control, ByVal name As String)
        If field.Text = Nothing Then
            Return False
        ElseIf Not IsNumeric(field.Text) Then
            MessageBox.Show(name.ToString & " " & "must contain numeric value")
            field.Select()
            Return True
        End If
        Return False
    End Function

    Public Shared Function datecheck(ByVal field As Control, ByVal name As String)
        If field.Text = "  /  /" Then
            MessageBox.Show(name.ToString & " " & "must contain valid date")
            field.Focus()
            Return True
        End If
        Return False
    End Function

    Public Shared Sub validation(ByVal e As Windows.Forms.KeyPressEventArgs)
        Dim ascii As Integer = Convert.ToInt16(e.KeyChar)
        If (ascii >= 48 AndAlso ascii <= 57) OrElse (ascii = 8) OrElse (ascii = 46) OrElse (ascii = 13) Then
            e.Handled = False
        Else
            MessageBox.Show("Enter only numeric value.", msgCaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True
        End If
    End Sub

    Public Shared Function IsItemExists(ByVal item As String, ByVal columnName As String, ByVal table As String) As Boolean

        Dim dt1 As DataTable = tudataDB.GetDataTable("SET ROWCOUNT 1 select " & columnName & " from " & table & " where " & columnName & "= '" & item & "' SET ROWCOUNT 0")
        If dt1.Rows.Count = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    '----------------End Validation


    Public Shared Function comboCollege(ByVal c As ComboBox)
        Dim dt3 As DataTable = tudataDB.GetDataTable("SELECT * FROM colleges ORDER BY Name")
        If Not dt3 Is Nothing Then
            c.DataSource = dt3
            c.DisplayMember = "name"
            c.ValueMember = "id"
        End If
        c.SelectedIndex = -1
        Return False
    End Function

    Public Shared Function comboSubjects(ByVal c As ComboBox)
        Dim dt3 As DataTable = tudataDB.GetDataTable("select distinct teachingsubject from teachers order by teachingsubject")
        If Not dt3 Is Nothing Then
            c.DataSource = dt3
            c.DisplayMember = "teachingsubject"
            c.ValueMember = "teachingsubject"
        End If
        c.SelectedIndex = -1
        Return False
    End Function

    Public Shared Function comboCollegeSubject(ByVal cs As String, ByVal c As ComboBox)
        Dim dt3 As DataTable = tudataDB.GetDataTable("select distinct teachingsubject from teachers WHERE collegeid = '" & cs & "' order by teachingsubject")
        If Not dt3 Is Nothing Then
            c.DataSource = dt3
            c.DisplayMember = "teachingsubject"
            c.ValueMember = "teachingsubject"
        End If
        c.SelectedIndex = -1
        Return False
    End Function

    Public Shared Function comboCollegeTeacherPost(ByVal cs As String, ByVal c As ComboBox)
        Dim dt3 As DataTable = tudataDB.GetDataTable("SELECT * FROM TeacherPost WHERE collegeid = '" & cs & "' ORDER BY Id")
        If Not dt3 Is Nothing Then
            c.DataSource = dt3
            c.DisplayMember = "post"
            c.ValueMember = "id"
        End If
        c.SelectedIndex = -1
        Return False
    End Function


    Public Shared Function comboTeacherPost(ByVal c As ComboBox)
        'Dim dt3 As DataTable = tudataDB.GetDataTable("SELECT * FROM TeacherPost ORDER BY Id")
        Dim dt3 As DataTable = tudataDB.GetDataTable("select distinct post from teachers where collegeid = '" & collegeid & "' order by post")
        If Not dt3 Is Nothing Then
            c.DataSource = dt3
            c.DisplayMember = "post"
            c.ValueMember = "post"
        End If
        c.SelectedIndex = -1
        Return False
    End Function

    Public Shared Function comboStaffPost(ByVal c As ComboBox)
        'Dim dt3 As DataTable = tudataDB.GetDataTable("SELECT * FROM StaffPost ORDER BY Id")
        Dim dt3 As DataTable = tudataDB.GetDataTable("select distinct post from staff where collegeid = '" & collegeid & "' order by post")
        If Not dt3 Is Nothing Then
            c.DataSource = dt3
            c.DisplayMember = "post"
            c.ValueMember = "post"
        End If
        c.SelectedIndex = -1
        Return False
    End Function

    Public Shared Function comboStaffDept(ByVal c As ComboBox)
        Dim dt3 As DataTable = tudataDB.GetDataTable("select distinct department from staff order by department")
        If Not dt3 Is Nothing Then
            c.DataSource = dt3
            c.DisplayMember = "department"
            c.ValueMember = "department"
        End If
        c.SelectedIndex = -1
        Return False
    End Function

    Public Shared Function comboLeaveType(ByVal c As ComboBox)
        Dim dt3 As DataTable = tudataDB.GetDataTable("SELECT * FROM LeaveType ORDER BY Id")
        If Not dt3 Is Nothing Then
            c.DataSource = dt3
            c.DisplayMember = "leave"
            c.ValueMember = "id"
        End If
        c.SelectedIndex = -1
        Return False
    End Function

    Public Shared Function comboStdLevel(ByVal c As ComboBox)
        Dim dt3 As DataTable = tudataDB.GetDataTable("SELECT * FROM StudentLevel ORDER BY Id")
        If Not dt3 Is Nothing Then
            c.DataSource = dt3
            c.DisplayMember = "Level"
            c.ValueMember = "id"
        End If
        c.SelectedIndex = -1
        Return False
    End Function

    Public Shared Function comboFaculty(ByVal c As ComboBox)
        Dim dt3 As DataTable = tudataDB.GetDataTable("SELECT * FROM InstitutesAndFaculties ORDER BY Id")
        If Not dt3 Is Nothing Then
            c.DataSource = dt3
            c.DisplayMember = "name"
            c.ValueMember = "id"
        End If
        c.SelectedIndex = -1
        Return False
    End Function

    Public Shared Function chkInstitute(ByVal c As CheckedListBox)
        Dim dt3 As DataTable = tudataDB.GetDataTable("SELECT * FROM Institutes ORDER BY Id")
        If Not dt3 Is Nothing Then
            c.DataSource = dt3
            c.DisplayMember = "name"
            c.ValueMember = "id"
        End If
        c.SelectedIndex = -1
        Return False
    End Function

    Public Shared Function chkFaculty(ByVal c As CheckedListBox)
        Dim dt3 As DataTable = tudataDB.GetDataTable("SELECT * FROM Faculties ORDER BY Id")
        If Not dt3 Is Nothing Then
            c.DataSource = dt3
            c.DisplayMember = "name"
            c.ValueMember = "id"
        End If
        c.SelectedIndex = -1
        Return False
    End Function

    Public Shared Function chkOthers(ByVal c As CheckedListBox)
        Dim dt3 As DataTable = tudataDB.GetDataTable("SELECT * FROM centres ORDER BY Id")
        If Not dt3 Is Nothing Then
            c.DataSource = dt3
            c.DisplayMember = "name"
            c.ValueMember = "id"
        End If
        c.SelectedIndex = -1
        Return False
    End Function

    Public Shared Function comboDistrict(ByVal c As ComboBox)
        Dim dt3 As DataTable = tudataDB.GetDataTable("SELECT * FROM districts ORDER BY name")
        If Not dt3 Is Nothing Then
            c.DataSource = dt3
            c.DisplayMember = "name"
            c.ValueMember = "id"
        End If
        c.SelectedIndex = -1
        Return False
    End Function

    Public Shared Function comboNepYear(ByVal c As ComboBox)
        Dim dt3 As DataTable = tudataDB.GetDataTable("SELECT Nepyear_nyear FROM Nepyear")
        If Not dt3 Is Nothing Then
            c.DataSource = dt3
            c.DisplayMember = "Nepyear_nyear"
            c.ValueMember = "Nepyear_nyear"
        End If
        c.SelectedIndex = -1
        Return False
    End Function

    Public Shared Function combolevelwiseyear(ByVal cs As String, ByVal c As ComboBox)
        Dim dt3 As DataTable = tudataDB.GetDataTable("SELECT * FROM levelyear WHERE levelid = '" & cs & "' ")
        If Not dt3 Is Nothing Then
            c.DataSource = dt3
            c.DisplayMember = "year"
            c.ValueMember = "id"
        End If
        'c.SelectedIndex = -1
        Return False
    End Function

    Public Shared Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

    Public Shared Sub ClearComboBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearComboBox(ctrl)
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).SelectedIndex = -1
                'CType(ctrl, ComboBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

    Public Shared Sub ClearCheckBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearCheckBox(ctrl)
            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False
            End If
        Next ctrl
    End Sub

    Public Shared Sub ClearRadioButton(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearRadioButton(ctrl)
            If TypeOf ctrl Is RadioButton Then
                CType(ctrl, RadioButton).Checked = False
            End If
        Next ctrl
    End Sub

    Public Shared Sub ClearMaskedTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearMaskedTextBox(ctrl)
            If TypeOf ctrl Is MaskedTextBox Then
                CType(ctrl, MaskedTextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

End Class
