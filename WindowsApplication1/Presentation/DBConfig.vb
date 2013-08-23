Imports System.Threading

Public Class DBConfig

    Dim constring, conn, connmaster As String
    Private th As Thread

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ch As String = common.validcheck(Me.TextBox1, "DataBase Server Name")
        If ch = True Then
            Me.TextBox1.Focus()
            Exit Sub
        End If
        constring = "server=" & Me.TextBox1.Text & "\SQLEXPRESS;Initial Catalog=tudata;Integrated Security=SSPI;"
        'database=tudata;Trusted_Connection=True;Connection Timeout=0;Max Pool Size=1000;"
        conn = "server=" & Me.TextBox1.Text & ";database=tudata;Trusted_Connection=True"
        connmaster = "server=" & Me.TextBox1.Text & ";database=tudata;Trusted_Connection=True"

        common.WriteFile("Sms@.@", constring)
        common.WriteFile("SMS.dat", "True")

        MessageBox.Show("Database is successfully configured!")
        OpenMainForm()
        Me.Close()

    End Sub

    Private Sub DBConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim test_file As String = common.ReadFile("SMS.dat")
        If test_file = "True" Then
            constring = common.ReadFile("Sms@.@")
            OpenMainForm()
        End If
    End Sub

    Private Sub OpenMainForm()
        th = New Thread(AddressOf OpenForm)
        th.SetApartmentState(ApartmentState.STA)
        Application.Exit()
        th.Start()
    End Sub
    Private Sub OpenForm()
        Dim frm As Form1
        frm = New Form1
        frm.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class