<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_College
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cbDistrict = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkInstitute = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkFaculty = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkCentres = New System.Windows.Forms.CheckedListBox()
        Me.chkIsTU = New System.Windows.Forms.CheckBox()
        Me.rbAffiliated = New System.Windows.Forms.RadioButton()
        Me.rbConstituent = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "College Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Street Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "District"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "College Type"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(127, 12)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(300, 20)
        Me.tbName.TabIndex = 0
        '
        'tbAddress
        '
        Me.tbAddress.Location = New System.Drawing.Point(127, 40)
        Me.tbAddress.Multiline = True
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(300, 40)
        Me.tbAddress.TabIndex = 1
        '
        'btSave
        '
        Me.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSave.Location = New System.Drawing.Point(61, 412)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 36)
        Me.btSave.TabIndex = 5
        Me.btSave.Text = "Save"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(142, 412)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(223, 412)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(304, 412)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 36)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cbDistrict
        '
        Me.cbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDistrict.FormattingEnabled = True
        Me.cbDistrict.Location = New System.Drawing.Point(127, 86)
        Me.cbDistrict.Name = "cbDistrict"
        Me.cbDistrict.Size = New System.Drawing.Size(300, 21)
        Me.cbDistrict.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkInstitute)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 124)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INSTITUTE"
        '
        'chkInstitute
        '
        Me.chkInstitute.FormattingEnabled = True
        Me.chkInstitute.Location = New System.Drawing.Point(6, 19)
        Me.chkInstitute.Name = "chkInstitute"
        Me.chkInstitute.Size = New System.Drawing.Size(188, 94)
        Me.chkInstitute.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkFaculty)
        Me.GroupBox2.Location = New System.Drawing.Point(222, 154)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 124)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FACULTY"
        '
        'chkFaculty
        '
        Me.chkFaculty.FormattingEnabled = True
        Me.chkFaculty.Location = New System.Drawing.Point(6, 19)
        Me.chkFaculty.Name = "chkFaculty"
        Me.chkFaculty.Size = New System.Drawing.Size(188, 94)
        Me.chkFaculty.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkCentres)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 284)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(410, 122)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CENTRES"
        '
        'chkCentres
        '
        Me.chkCentres.FormattingEnabled = True
        Me.chkCentres.Location = New System.Drawing.Point(6, 19)
        Me.chkCentres.Name = "chkCentres"
        Me.chkCentres.Size = New System.Drawing.Size(398, 94)
        Me.chkCentres.TabIndex = 0
        '
        'chkIsTU
        '
        Me.chkIsTU.AutoSize = True
        Me.chkIsTU.Location = New System.Drawing.Point(355, 117)
        Me.chkIsTU.Name = "chkIsTU"
        Me.chkIsTU.Size = New System.Drawing.Size(72, 17)
        Me.chkIsTU.TabIndex = 14
        Me.chkIsTU.Text = "Inside TU"
        Me.chkIsTU.UseVisualStyleBackColor = True
        '
        'rbAffiliated
        '
        Me.rbAffiliated.AutoSize = True
        Me.rbAffiliated.Location = New System.Drawing.Point(127, 117)
        Me.rbAffiliated.Name = "rbAffiliated"
        Me.rbAffiliated.Size = New System.Drawing.Size(65, 17)
        Me.rbAffiliated.TabIndex = 15
        Me.rbAffiliated.TabStop = True
        Me.rbAffiliated.Text = "Affiliated"
        Me.rbAffiliated.UseVisualStyleBackColor = True
        '
        'rbConstituent
        '
        Me.rbConstituent.AutoSize = True
        Me.rbConstituent.Location = New System.Drawing.Point(219, 117)
        Me.rbConstituent.Name = "rbConstituent"
        Me.rbConstituent.Size = New System.Drawing.Size(78, 17)
        Me.rbConstituent.TabIndex = 16
        Me.rbConstituent.TabStop = True
        Me.rbConstituent.Text = "Constituent"
        Me.rbConstituent.UseVisualStyleBackColor = True
        '
        'frm_College
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 460)
        Me.Controls.Add(Me.rbConstituent)
        Me.Controls.Add(Me.rbAffiliated)
        Me.Controls.Add(Me.chkIsTU)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbDistrict)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.tbAddress)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_College"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "College Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents tbAddress As System.Windows.Forms.TextBox
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cbDistrict As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkInstitute As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFaculty As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCentres As System.Windows.Forms.CheckedListBox
    Friend WithEvents chkIsTU As System.Windows.Forms.CheckBox
    Friend WithEvents rbAffiliated As System.Windows.Forms.RadioButton
    Friend WithEvents rbConstituent As System.Windows.Forms.RadioButton
End Class
