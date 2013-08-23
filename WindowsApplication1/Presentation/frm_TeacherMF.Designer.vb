<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TeacherMF
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TBM = New System.Windows.Forms.TextBox
        Me.TBF = New System.Windows.Forms.TextBox
        Me.TBT = New System.Windows.Forms.TextBox
        Me.tbMper = New System.Windows.Forms.TextBox
        Me.tbFper = New System.Windows.Forms.TextBox
        Me.tbTper = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.tbSM = New System.Windows.Forms.TextBox
        Me.tbSTP = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.tbST = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.tbSFP = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.tbSF = New System.Windows.Forms.TextBox
        Me.tbSMP = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Male"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Female"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "College"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(84, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(248, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'TBM
        '
        Me.TBM.BackColor = System.Drawing.SystemColors.Window
        Me.TBM.Location = New System.Drawing.Point(67, 31)
        Me.TBM.Name = "TBM"
        Me.TBM.ReadOnly = True
        Me.TBM.Size = New System.Drawing.Size(100, 20)
        Me.TBM.TabIndex = 6
        '
        'TBF
        '
        Me.TBF.BackColor = System.Drawing.SystemColors.Window
        Me.TBF.Location = New System.Drawing.Point(67, 56)
        Me.TBF.Name = "TBF"
        Me.TBF.ReadOnly = True
        Me.TBF.Size = New System.Drawing.Size(100, 20)
        Me.TBF.TabIndex = 6
        '
        'TBT
        '
        Me.TBT.BackColor = System.Drawing.SystemColors.Window
        Me.TBT.Location = New System.Drawing.Point(67, 82)
        Me.TBT.Name = "TBT"
        Me.TBT.ReadOnly = True
        Me.TBT.Size = New System.Drawing.Size(100, 20)
        Me.TBT.TabIndex = 6
        '
        'tbMper
        '
        Me.tbMper.BackColor = System.Drawing.SystemColors.Window
        Me.tbMper.Location = New System.Drawing.Point(177, 31)
        Me.tbMper.Name = "tbMper"
        Me.tbMper.ReadOnly = True
        Me.tbMper.Size = New System.Drawing.Size(100, 20)
        Me.tbMper.TabIndex = 6
        '
        'tbFper
        '
        Me.tbFper.BackColor = System.Drawing.SystemColors.Window
        Me.tbFper.Location = New System.Drawing.Point(177, 56)
        Me.tbFper.Name = "tbFper"
        Me.tbFper.ReadOnly = True
        Me.tbFper.Size = New System.Drawing.Size(100, 20)
        Me.tbFper.TabIndex = 6
        '
        'tbTper
        '
        Me.tbTper.BackColor = System.Drawing.SystemColors.Window
        Me.tbTper.Location = New System.Drawing.Point(177, 82)
        Me.tbTper.Name = "tbTper"
        Me.tbTper.ReadOnly = True
        Me.tbTper.Size = New System.Drawing.Size(100, 20)
        Me.tbTper.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBM)
        Me.GroupBox1.Controls.Add(Me.tbTper)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBT)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbFper)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TBF)
        Me.GroupBox1.Controls.Add(Me.tbMper)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 117)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Teachers"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(283, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(283, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(283, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "%"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tbSM)
        Me.GroupBox2.Controls.Add(Me.tbSTP)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.tbST)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.tbSFP)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.tbSF)
        Me.GroupBox2.Controls.Add(Me.tbSMP)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 117)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Staff"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(283, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(283, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(283, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "%"
        '
        'tbSM
        '
        Me.tbSM.BackColor = System.Drawing.SystemColors.Window
        Me.tbSM.Location = New System.Drawing.Point(67, 31)
        Me.tbSM.Name = "tbSM"
        Me.tbSM.ReadOnly = True
        Me.tbSM.Size = New System.Drawing.Size(100, 20)
        Me.tbSM.TabIndex = 6
        '
        'tbSTP
        '
        Me.tbSTP.BackColor = System.Drawing.SystemColors.Window
        Me.tbSTP.Location = New System.Drawing.Point(177, 82)
        Me.tbSTP.Name = "tbSTP"
        Me.tbSTP.ReadOnly = True
        Me.tbSTP.Size = New System.Drawing.Size(100, 20)
        Me.tbSTP.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = " Male"
        '
        'tbST
        '
        Me.tbST.BackColor = System.Drawing.SystemColors.Window
        Me.tbST.Location = New System.Drawing.Point(67, 82)
        Me.tbST.Name = "tbST"
        Me.tbST.ReadOnly = True
        Me.tbST.Size = New System.Drawing.Size(100, 20)
        Me.tbST.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Female"
        '
        'tbSFP
        '
        Me.tbSFP.BackColor = System.Drawing.SystemColors.Window
        Me.tbSFP.Location = New System.Drawing.Point(177, 56)
        Me.tbSFP.Name = "tbSFP"
        Me.tbSFP.ReadOnly = True
        Me.tbSFP.Size = New System.Drawing.Size(100, 20)
        Me.tbSFP.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Total"
        '
        'tbSF
        '
        Me.tbSF.BackColor = System.Drawing.SystemColors.Window
        Me.tbSF.Location = New System.Drawing.Point(67, 56)
        Me.tbSF.Name = "tbSF"
        Me.tbSF.ReadOnly = True
        Me.tbSF.Size = New System.Drawing.Size(100, 20)
        Me.tbSF.TabIndex = 6
        '
        'tbSMP
        '
        Me.tbSMP.BackColor = System.Drawing.SystemColors.Window
        Me.tbSMP.Location = New System.Drawing.Point(177, 31)
        Me.tbSMP.Name = "tbSMP"
        Me.tbSMP.ReadOnly = True
        Me.tbSMP.Size = New System.Drawing.Size(100, 20)
        Me.tbSMP.TabIndex = 6
        '
        'frm_TeacherMF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 333)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frm_TeacherMF"
        Me.Text = "Male Female Ratio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TBM As System.Windows.Forms.TextBox
    Friend WithEvents TBF As System.Windows.Forms.TextBox
    Friend WithEvents TBT As System.Windows.Forms.TextBox
    Friend WithEvents tbMper As System.Windows.Forms.TextBox
    Friend WithEvents tbFper As System.Windows.Forms.TextBox
    Friend WithEvents tbTper As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbSM As System.Windows.Forms.TextBox
    Friend WithEvents tbSTP As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbST As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbSFP As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbSF As System.Windows.Forms.TextBox
    Friend WithEvents tbSMP As System.Windows.Forms.TextBox
End Class
