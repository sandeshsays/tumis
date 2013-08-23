<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FacultyOverview
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
        Me.tbTotPost = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbPost = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbCollege = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbTotalTeachers = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbStaffPost = New System.Windows.Forms.ComboBox
        Me.tbStaffPost = New System.Windows.Forms.TextBox
        Me.tbTotalStaff = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnRetStaffList = New System.Windows.Forms.Button
        Me.btnRetTeachersList = New System.Windows.Forms.Button
        Me.chkRange = New System.Windows.Forms.CheckBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.btnRetire = New System.Windows.Forms.Button
        Me.tbRetStaff = New System.Windows.Forms.TextBox
        Me.tbRetTeachers = New System.Windows.Forms.TextBox
        Me.tbYearTo = New System.Windows.Forms.TextBox
        Me.tbYearFrom = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.tbRetYear = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbTotPost
        '
        Me.tbTotPost.Enabled = False
        Me.tbTotPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotPost.Location = New System.Drawing.Point(315, 57)
        Me.tbTotPost.Name = "tbTotPost"
        Me.tbTotPost.Size = New System.Drawing.Size(100, 22)
        Me.tbTotPost.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Post"
        '
        'cbPost
        '
        Me.cbPost.FormattingEnabled = True
        Me.cbPost.Location = New System.Drawing.Point(136, 57)
        Me.cbPost.Name = "cbPost"
        Me.cbPost.Size = New System.Drawing.Size(121, 21)
        Me.cbPost.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Faculty"
        '
        'cbCollege
        '
        Me.cbCollege.FormattingEnabled = True
        Me.cbCollege.Location = New System.Drawing.Point(102, 12)
        Me.cbCollege.Name = "cbCollege"
        Me.cbCollege.Size = New System.Drawing.Size(355, 21)
        Me.cbCollege.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Total"
        '
        'tbTotalTeachers
        '
        Me.tbTotalTeachers.Enabled = False
        Me.tbTotalTeachers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalTeachers.Location = New System.Drawing.Point(136, 29)
        Me.tbTotalTeachers.Name = "tbTotalTeachers"
        Me.tbTotalTeachers.Size = New System.Drawing.Size(100, 22)
        Me.tbTotalTeachers.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbTotalTeachers)
        Me.GroupBox1.Controls.Add(Me.cbPost)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbTotPost)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 86)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Teachers Count"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(278, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Total"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbStaffPost)
        Me.GroupBox2.Controls.Add(Me.tbStaffPost)
        Me.GroupBox2.Controls.Add(Me.tbTotalStaff)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(460, 90)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Staff Count"
        '
        'cbStaffPost
        '
        Me.cbStaffPost.FormattingEnabled = True
        Me.cbStaffPost.Location = New System.Drawing.Point(136, 57)
        Me.cbStaffPost.Name = "cbStaffPost"
        Me.cbStaffPost.Size = New System.Drawing.Size(121, 21)
        Me.cbStaffPost.TabIndex = 1
        '
        'tbStaffPost
        '
        Me.tbStaffPost.Enabled = False
        Me.tbStaffPost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStaffPost.Location = New System.Drawing.Point(315, 57)
        Me.tbStaffPost.Name = "tbStaffPost"
        Me.tbStaffPost.Size = New System.Drawing.Size(100, 22)
        Me.tbStaffPost.TabIndex = 2
        '
        'tbTotalStaff
        '
        Me.tbTotalStaff.Enabled = False
        Me.tbTotalStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalStaff.Location = New System.Drawing.Point(136, 29)
        Me.tbTotalStaff.Name = "tbTotalStaff"
        Me.tbTotalStaff.Size = New System.Drawing.Size(100, 22)
        Me.tbTotalStaff.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Post"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(278, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnRetStaffList)
        Me.GroupBox3.Controls.Add(Me.btnRetTeachersList)
        Me.GroupBox3.Controls.Add(Me.chkRange)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.btnRetire)
        Me.GroupBox3.Controls.Add(Me.tbRetStaff)
        Me.GroupBox3.Controls.Add(Me.tbRetTeachers)
        Me.GroupBox3.Controls.Add(Me.tbYearTo)
        Me.GroupBox3.Controls.Add(Me.tbYearFrom)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.tbRetYear)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 240)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(460, 170)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Retiring"
        '
        'btnRetStaffList
        '
        Me.btnRetStaffList.Location = New System.Drawing.Point(256, 127)
        Me.btnRetStaffList.Name = "btnRetStaffList"
        Me.btnRetStaffList.Size = New System.Drawing.Size(75, 23)
        Me.btnRetStaffList.TabIndex = 8
        Me.btnRetStaffList.Text = "View List"
        Me.btnRetStaffList.UseVisualStyleBackColor = True
        '
        'btnRetTeachersList
        '
        Me.btnRetTeachersList.Location = New System.Drawing.Point(256, 98)
        Me.btnRetTeachersList.Name = "btnRetTeachersList"
        Me.btnRetTeachersList.Size = New System.Drawing.Size(75, 23)
        Me.btnRetTeachersList.TabIndex = 6
        Me.btnRetTeachersList.Text = "View List"
        Me.btnRetTeachersList.UseVisualStyleBackColor = True
        '
        'chkRange
        '
        Me.chkRange.AutoSize = True
        Me.chkRange.Location = New System.Drawing.Point(256, 30)
        Me.chkRange.Name = "chkRange"
        Me.chkRange.Size = New System.Drawing.Size(58, 17)
        Me.chkRange.TabIndex = 1
        Me.chkRange.Text = "Range"
        Me.chkRange.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(234, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(16, 13)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "to"
        '
        'btnRetire
        '
        Me.btnRetire.Location = New System.Drawing.Point(371, 28)
        Me.btnRetire.Name = "btnRetire"
        Me.btnRetire.Size = New System.Drawing.Size(55, 46)
        Me.btnRetire.TabIndex = 4
        Me.btnRetire.Text = "GO"
        Me.btnRetire.UseVisualStyleBackColor = True
        '
        'tbRetStaff
        '
        Me.tbRetStaff.Enabled = False
        Me.tbRetStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRetStaff.Location = New System.Drawing.Point(125, 129)
        Me.tbRetStaff.Name = "tbRetStaff"
        Me.tbRetStaff.Size = New System.Drawing.Size(100, 22)
        Me.tbRetStaff.TabIndex = 7
        '
        'tbRetTeachers
        '
        Me.tbRetTeachers.Enabled = False
        Me.tbRetTeachers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRetTeachers.Location = New System.Drawing.Point(125, 100)
        Me.tbRetTeachers.Name = "tbRetTeachers"
        Me.tbRetTeachers.Size = New System.Drawing.Size(100, 22)
        Me.tbRetTeachers.TabIndex = 5
        '
        'tbYearTo
        '
        Me.tbYearTo.Enabled = False
        Me.tbYearTo.Location = New System.Drawing.Point(256, 54)
        Me.tbYearTo.MaxLength = 4
        Me.tbYearTo.Name = "tbYearTo"
        Me.tbYearTo.Size = New System.Drawing.Size(100, 20)
        Me.tbYearTo.TabIndex = 3
        '
        'tbYearFrom
        '
        Me.tbYearFrom.Enabled = False
        Me.tbYearFrom.Location = New System.Drawing.Point(125, 54)
        Me.tbYearFrom.MaxLength = 4
        Me.tbYearFrom.Name = "tbYearFrom"
        Me.tbYearFrom.Size = New System.Drawing.Size(100, 20)
        Me.tbYearFrom.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(35, 132)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Staff"
        '
        'tbRetYear
        '
        Me.tbRetYear.Location = New System.Drawing.Point(125, 28)
        Me.tbRetYear.MaxLength = 4
        Me.tbRetYear.Name = "tbRetYear"
        Me.tbRetYear.Size = New System.Drawing.Size(100, 20)
        Me.tbRetYear.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(35, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Teachers"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(35, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Retiring during"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(35, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Retiring in"
        '
        'frm_FacultyOverview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 422)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbCollege)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_FacultyOverview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Faculty Overview"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbTotPost As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbPost As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbCollege As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbTotalTeachers As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbStaffPost As System.Windows.Forms.ComboBox
    Friend WithEvents tbStaffPost As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalStaff As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tbRetStaff As System.Windows.Forms.TextBox
    Friend WithEvents tbRetTeachers As System.Windows.Forms.TextBox
    Friend WithEvents tbYearFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tbRetYear As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chkRange As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnRetire As System.Windows.Forms.Button
    Friend WithEvents tbYearTo As System.Windows.Forms.TextBox
    Friend WithEvents btnRetStaffList As System.Windows.Forms.Button
    Friend WithEvents btnRetTeachersList As System.Windows.Forms.Button
End Class
