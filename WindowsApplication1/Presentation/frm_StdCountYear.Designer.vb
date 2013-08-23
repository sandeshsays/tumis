<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_StdCountYear
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
        Me.College = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbCollege = New System.Windows.Forms.ComboBox
        Me.tbBoys = New System.Windows.Forms.TextBox
        Me.tbGirls = New System.Windows.Forms.TextBox
        Me.tbTotal = New System.Windows.Forms.TextBox
        Me.tbAyear = New System.Windows.Forms.TextBox
        Me.tbSubject = New System.Windows.Forms.TextBox
        Me.btCancel1 = New System.Windows.Forms.Button
        Me.btSave1 = New System.Windows.Forms.Button
        Me.cbLevel = New System.Windows.Forms.ComboBox
        Me.cbYear = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'College
        '
        Me.College.AutoSize = True
        Me.College.Location = New System.Drawing.Point(14, 19)
        Me.College.Name = "College"
        Me.College.Size = New System.Drawing.Size(42, 13)
        Me.College.TabIndex = 0
        Me.College.Text = "College"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Academic Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Subject"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "No. of male students"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "No. of female students"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Total"
        '
        'cbCollege
        '
        Me.cbCollege.FormattingEnabled = True
        Me.cbCollege.Location = New System.Drawing.Point(222, 16)
        Me.cbCollege.Name = "cbCollege"
        Me.cbCollege.Size = New System.Drawing.Size(200, 21)
        Me.cbCollege.TabIndex = 0
        '
        'tbBoys
        '
        Me.tbBoys.Location = New System.Drawing.Point(222, 147)
        Me.tbBoys.Name = "tbBoys"
        Me.tbBoys.Size = New System.Drawing.Size(200, 20)
        Me.tbBoys.TabIndex = 5
        '
        'tbGirls
        '
        Me.tbGirls.Location = New System.Drawing.Point(222, 173)
        Me.tbGirls.Name = "tbGirls"
        Me.tbGirls.Size = New System.Drawing.Size(200, 20)
        Me.tbGirls.TabIndex = 6
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(222, 199)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.Size = New System.Drawing.Size(200, 20)
        Me.tbTotal.TabIndex = 7
        '
        'tbAyear
        '
        Me.tbAyear.Location = New System.Drawing.Point(222, 43)
        Me.tbAyear.Name = "tbAyear"
        Me.tbAyear.Size = New System.Drawing.Size(200, 20)
        Me.tbAyear.TabIndex = 1
        '
        'tbSubject
        '
        Me.tbSubject.Location = New System.Drawing.Point(222, 121)
        Me.tbSubject.Name = "tbSubject"
        Me.tbSubject.Size = New System.Drawing.Size(200, 20)
        Me.tbSubject.TabIndex = 4
        '
        'btCancel1
        '
        Me.btCancel1.Location = New System.Drawing.Point(220, 239)
        Me.btCancel1.Name = "btCancel1"
        Me.btCancel1.Size = New System.Drawing.Size(75, 23)
        Me.btCancel1.TabIndex = 9
        Me.btCancel1.Text = "Cancel"
        Me.btCancel1.UseVisualStyleBackColor = True
        '
        'btSave1
        '
        Me.btSave1.Location = New System.Drawing.Point(139, 239)
        Me.btSave1.Name = "btSave1"
        Me.btSave1.Size = New System.Drawing.Size(75, 23)
        Me.btSave1.TabIndex = 8
        Me.btSave1.Text = "Save"
        Me.btSave1.UseVisualStyleBackColor = True
        '
        'cbLevel
        '
        Me.cbLevel.FormattingEnabled = True
        Me.cbLevel.Items.AddRange(New Object() {"Certificate", "Bachelor`s", "Master`s", "M.Phil", "Ph.D"})
        Me.cbLevel.Location = New System.Drawing.Point(222, 69)
        Me.cbLevel.Name = "cbLevel"
        Me.cbLevel.Size = New System.Drawing.Size(200, 21)
        Me.cbLevel.TabIndex = 10
        '
        'cbYear
        '
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Location = New System.Drawing.Point(222, 96)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(200, 21)
        Me.cbYear.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(98, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(53, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(46, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(120, 150)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(133, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "*"
        '
        'frm_StdCountYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 272)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbYear)
        Me.Controls.Add(Me.cbLevel)
        Me.Controls.Add(Me.btCancel1)
        Me.Controls.Add(Me.btSave1)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.tbGirls)
        Me.Controls.Add(Me.tbAyear)
        Me.Controls.Add(Me.tbSubject)
        Me.Controls.Add(Me.tbBoys)
        Me.Controls.Add(Me.cbCollege)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.College)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_StdCountYear"
        Me.Text = "Yearwise Student Count"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents College As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbCollege As System.Windows.Forms.ComboBox
    Friend WithEvents tbBoys As System.Windows.Forms.TextBox
    Friend WithEvents tbGirls As System.Windows.Forms.TextBox
    Friend WithEvents tbTotal As System.Windows.Forms.TextBox
    Friend WithEvents tbAyear As System.Windows.Forms.TextBox
    Friend WithEvents tbSubject As System.Windows.Forms.TextBox
    Friend WithEvents btCancel1 As System.Windows.Forms.Button
    Friend WithEvents btSave1 As System.Windows.Forms.Button
    Friend WithEvents cbLevel As System.Windows.Forms.ComboBox
    Friend WithEvents cbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
