<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_StdCountSem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btCancel1 = New System.Windows.Forms.Button
        Me.btSave1 = New System.Windows.Forms.Button
        Me.tbTotal = New System.Windows.Forms.TextBox
        Me.tbGirls = New System.Windows.Forms.TextBox
        Me.tbAyear = New System.Windows.Forms.TextBox
        Me.tbSubject = New System.Windows.Forms.TextBox
        Me.tbSemester = New System.Windows.Forms.TextBox
        Me.tbShift = New System.Windows.Forms.TextBox
        Me.tbBoys = New System.Windows.Forms.TextBox
        Me.cbCollege = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.College = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbProgram = New System.Windows.Forms.TextBox
        Me.Level = New System.Windows.Forms.Label
        Me.cbLevel = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btCancel1
        '
        Me.btCancel1.Location = New System.Drawing.Point(221, 277)
        Me.btCancel1.Name = "btCancel1"
        Me.btCancel1.Size = New System.Drawing.Size(75, 23)
        Me.btCancel1.TabIndex = 11
        Me.btCancel1.Text = "Cancel"
        Me.btCancel1.UseVisualStyleBackColor = True
        '
        'btSave1
        '
        Me.btSave1.Location = New System.Drawing.Point(140, 277)
        Me.btSave1.Name = "btSave1"
        Me.btSave1.Size = New System.Drawing.Size(75, 23)
        Me.btSave1.TabIndex = 10
        Me.btSave1.Text = "Save"
        Me.btSave1.UseVisualStyleBackColor = True
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(222, 243)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.Size = New System.Drawing.Size(200, 20)
        Me.tbTotal.TabIndex = 9
        '
        'tbGirls
        '
        Me.tbGirls.Location = New System.Drawing.Point(222, 217)
        Me.tbGirls.Name = "tbGirls"
        Me.tbGirls.Size = New System.Drawing.Size(200, 20)
        Me.tbGirls.TabIndex = 8
        '
        'tbAyear
        '
        Me.tbAyear.Location = New System.Drawing.Point(221, 35)
        Me.tbAyear.Name = "tbAyear"
        Me.tbAyear.Size = New System.Drawing.Size(200, 20)
        Me.tbAyear.TabIndex = 1
        '
        'tbSubject
        '
        Me.tbSubject.Location = New System.Drawing.Point(222, 165)
        Me.tbSubject.Name = "tbSubject"
        Me.tbSubject.Size = New System.Drawing.Size(200, 20)
        Me.tbSubject.TabIndex = 6
        '
        'tbSemester
        '
        Me.tbSemester.Location = New System.Drawing.Point(222, 139)
        Me.tbSemester.Name = "tbSemester"
        Me.tbSemester.Size = New System.Drawing.Size(200, 20)
        Me.tbSemester.TabIndex = 5
        '
        'tbShift
        '
        Me.tbShift.Location = New System.Drawing.Point(221, 61)
        Me.tbShift.Name = "tbShift"
        Me.tbShift.Size = New System.Drawing.Size(200, 20)
        Me.tbShift.TabIndex = 2
        '
        'tbBoys
        '
        Me.tbBoys.Location = New System.Drawing.Point(222, 191)
        Me.tbBoys.Name = "tbBoys"
        Me.tbBoys.Size = New System.Drawing.Size(200, 20)
        Me.tbBoys.TabIndex = 7
        '
        'cbCollege
        '
        Me.cbCollege.FormattingEnabled = True
        Me.cbCollege.Location = New System.Drawing.Point(221, 8)
        Me.cbCollege.Name = "cbCollege"
        Me.cbCollege.Size = New System.Drawing.Size(200, 21)
        Me.cbCollege.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "No of female students"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "No. of male students"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Subject"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Semester"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Shift"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Academic Year"
        '
        'College
        '
        Me.College.AutoSize = True
        Me.College.Location = New System.Drawing.Point(13, 11)
        Me.College.Name = "College"
        Me.College.Size = New System.Drawing.Size(42, 13)
        Me.College.TabIndex = 12
        Me.College.Text = "College"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Program"
        '
        'tbProgram
        '
        Me.tbProgram.Location = New System.Drawing.Point(221, 87)
        Me.tbProgram.Name = "tbProgram"
        Me.tbProgram.Size = New System.Drawing.Size(200, 20)
        Me.tbProgram.TabIndex = 3
        '
        'Level
        '
        Me.Level.AutoSize = True
        Me.Level.Location = New System.Drawing.Point(13, 116)
        Me.Level.Name = "Level"
        Me.Level.Size = New System.Drawing.Size(33, 13)
        Me.Level.TabIndex = 14
        Me.Level.Text = "Level"
        '
        'cbLevel
        '
        Me.cbLevel.FormattingEnabled = True
        Me.cbLevel.Items.AddRange(New Object() {"Certificate", "Bachelor", "Master", "M.Phil", "Ph.D"})
        Me.cbLevel.Location = New System.Drawing.Point(222, 113)
        Me.cbLevel.Name = "cbLevel"
        Me.cbLevel.Size = New System.Drawing.Size(200, 21)
        Me.cbLevel.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(54, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(90, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(57, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(44, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(65, 142)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(116, 194)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(123, 220)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "*"
        '
        'frm_StdCountSem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 312)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbLevel)
        Me.Controls.Add(Me.btCancel1)
        Me.Controls.Add(Me.btSave1)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.tbGirls)
        Me.Controls.Add(Me.tbAyear)
        Me.Controls.Add(Me.tbSubject)
        Me.Controls.Add(Me.tbSemester)
        Me.Controls.Add(Me.tbProgram)
        Me.Controls.Add(Me.tbShift)
        Me.Controls.Add(Me.tbBoys)
        Me.Controls.Add(Me.cbCollege)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Level)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.College)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_StdCountSem"
        Me.Text = "Semester Wise Student Count"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btCancel1 As System.Windows.Forms.Button
    Friend WithEvents btSave1 As System.Windows.Forms.Button
    Friend WithEvents tbTotal As System.Windows.Forms.TextBox
    Friend WithEvents tbGirls As System.Windows.Forms.TextBox
    Friend WithEvents tbAyear As System.Windows.Forms.TextBox
    Friend WithEvents tbSubject As System.Windows.Forms.TextBox
    Friend WithEvents tbSemester As System.Windows.Forms.TextBox
    Friend WithEvents tbShift As System.Windows.Forms.TextBox
    Friend WithEvents tbBoys As System.Windows.Forms.TextBox
    Friend WithEvents cbCollege As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents College As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbProgram As System.Windows.Forms.TextBox
    Friend WithEvents Level As System.Windows.Forms.Label
    Friend WithEvents cbLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
