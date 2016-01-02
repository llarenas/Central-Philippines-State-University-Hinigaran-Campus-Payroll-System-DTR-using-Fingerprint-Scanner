'*******************************************************************'
'CPSU Hinigaran Payrol System Using Biometric
'Programmer: Ronel B. Llarenas 
'*******************************************************************'


Imports System.IO
Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Globalization
Imports System.Drawing.Printing



Public Class individual_payslip
    Dim sql As String
    Dim sql1 As String


    Dim sql_connection As MySqlClient.MySqlConnection
    Dim sql_command As MySqlClient.MySqlCommand

    Dim DR As MySqlClient.MySqlDataReader



    Public Sub selectuser()

        If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

        Try

            sql1 = "SELECT * from user where idnum like '%" & search.Text & "%'"


            sql_command = New MySqlCommand(sql1, sql_connection)
            DR = sql_command.ExecuteReader()


            Do While DR.Read = True
                fname.Text = Format(DR("fname"))

                mname.Text = Format(DR("mname"))
                lname.Text = Format(DR("lname"))
                'appoint.Text = Format(DR("appointment"))

            Loop
            DR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub

        End Try

        sql_connection.Close()



    End Sub





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        selectuser()



        If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

        Try

            ' sql = "SELECT  sum(gp), sum(madeduct), sum(debit)  from dtr where idnum =  '" & search.Text & "' and nowmonth = '" & monthtext.Text & " ' and nowyear = '" & yeartext.Text & " ' and halfmonth = '" & kinsenas.Text & " '   "  ', sql_connection

            sql = "SELECT  sum(gp), sum(madeduct), sum(debit)  from dtr where idnum =  '" & search.Text & "' and nowmonth = '" & monthtext.Text & " ' and nowyear = '" & yeartext.Text & " '    "  ', sql_connection






            'sql = "SELECT * from user where idnum like '%" & search.Text & "%'"
            '("SELECT SEC_TO_TIME(SUM(TIME_TO_SEC(alltotal))), sum(gp), sum(madeduct), sum(debit)  from dtr where idnum =  '" & DR("idnum") & "' and nowmonth = '" & monthtext.Text & " ' and nowyear = '" & yeartext.Text & " ' and halfmonth = '" & kinsenas.Text & " '   ", sql_connection1)

            sql_command = New MySqlCommand(sql, sql_connection)
            DR = sql_command.ExecuteReader()


            Do While DR.Read = True
                'fname.Text = Format(DR("fname"))

                'mname.Text = Format(DR("mname"))
                'lname.Text = Format(DR("lname"))
                'appoint.Text = Format(DR("appointment"))

                monthlygp.Text = Format(DR("sum(gp)").ToString)
                TextBox1.Text = Format(DR("sum(madeduct)").ToString)
                madeduct.Text = Format(DR("sum(madeduct)").ToString)
                netpay.Text = Format(DR("sum(debit)").ToString)


            Loop
            DR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub

        End Try

        sql_connection.Close()


    End Sub

    Private Sub individual_payslip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql_connection = New MySqlClient.MySqlConnection("Data Source=localhost;user id=root;password=NO;database=system;")

        Try
            sql_connection.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        daytext.Text = Now.Day 'gamiton sa pagbutang sang a or b.
        monthtext.Text = Now.Month
        yeartext.Text = Now.Year

        '''' if 1 to 15 put a else b.
        Dim valx As Integer
        valx = (Val(daytext.Text))

        If Val(daytext.Text.Trim) < "16" Then

            kinsenas.Text = "a"
        Else
            kinsenas.Text = "b"

        End If


        If kinsenas.Text = "a" Then
            monthquarter.Text = "1 to 15, "

        ElseIf kinsenas.Text = "b" Then
            monthquarter.Text = "16 to 31, "

        End If


        formonthname.Text = MonthName(Now.Month)
        Label20.Text = Now.Year




        daytext.Hide()
        monthtext.Hide()
        yeartext.Hide()
        kinsenas.Hide()




    End Sub

   
  

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("arial", 16, FontStyle.Regular)
        Dim font1 As New Font("arial", 10, FontStyle.Regular)
        Dim font2 As New Font("arial", 20, FontStyle.Regular)


        e.Graphics.DrawString(Label14.Text, font, Brushes.Black, 190, 40) 'left to right, top to bottom
        e.Graphics.DrawString(Label15.Text, font, Brushes.Black, 250, 70) 'left to right, top to bottom
        e.Graphics.DrawString(Label1.Text, font, Brushes.Black, 300, 100) 'left to right, top to bottom

        e.Graphics.DrawString(Label18.Text, font1, Brushes.Black, 250, 160) 'left to right, top to bottom
        e.Graphics.DrawString(formonthname.Text, font1, Brushes.Black, 365, 160) 'left to right, top to bottom
        e.Graphics.DrawString(monthquarter.Text, font1, Brushes.Black, 410, 160) 'left to right, top to bottom
        ' e.Graphics.DrawString(Label22.Text, font1, Brushes.Black, 300, 140) 'left to right, top to bottom
        e.Graphics.DrawString(Label20.Text, font1, Brushes.Black, 464, 160) 'left to right, top to bottom


        e.Graphics.DrawString(Label2.Text, font1, Brushes.Black, 90, 200) 'left to right, top to bottom
        e.Graphics.DrawString(fname.Text, font1, Brushes.Black, 210, 200) 'left to right, top to bottom
        e.Graphics.DrawString(mname.Text, font1, Brushes.Black, 260, 200) 'left to right, top to bottom
        e.Graphics.DrawString(lname.Text, font1, Brushes.Black, 330, 200) 'left to right, top to bottom


        e.Graphics.DrawString(Label3.Text, font1, Brushes.Black, 90, 250) 'left to right, top to bottom
        e.Graphics.DrawString(monthlygp.Text, font1, Brushes.Black, 555, 250) 'left to right, top to bottom

        e.Graphics.DrawString(Le.Text, font1, Brushes.Black, 90, 300) 'left to right, top to bottom

        e.Graphics.DrawString(Label4.Text, font1, Brushes.Black, 150, 300) 'left to right, top to bottom

        e.Graphics.DrawString(Label5.Text, font1, Brushes.Black, 150, 320) 'left to right, top to bottom
        e.Graphics.DrawString(Label6.Text, font1, Brushes.Black, 150, 340) 'left to right, top to bottom
        e.Graphics.DrawString(Label7.Text, font1, Brushes.Black, 150, 360) 'left to right, top to bottom
        e.Graphics.DrawString(Label8.Text, font1, Brushes.Black, 150, 380) 'left to right, top to bottom

        e.Graphics.DrawString(Label9.Text, font1, Brushes.Black, 150, 400) 'left to right, top to bottom
        e.Graphics.DrawString(Label10.Text, font1, Brushes.Black, 150, 420) 'left to right, top to bottom

        e.Graphics.DrawString(Label11.Text, font1, Brushes.Black, 150, 440) 'left to right, top to bottom
        e.Graphics.DrawString(Label12.Text, font1, Brushes.Black, 150, 460) 'left to right, top to bottom

        e.Graphics.DrawString(Label13.Text, font1, Brushes.Black, 150, 480) 'left to right, top to bottom
        e.Graphics.DrawString(Label17.Text, font1, Brushes.Black, 150, 500) 'left to right, top to bottom

        e.Graphics.DrawString(Label19.Text, font1, Brushes.Black, 150, 530) 'left to right, top to bottom
        e.Graphics.DrawString(TextBox1.Text, font1, Brushes.Black, 400, 530) 'left to right, top to bottom

        e.Graphics.DrawString(Label21.Text, font1, Brushes.Black, 150, 560) 'left to right, top to bottom
        e.Graphics.DrawString(Label23.Text, font1, Brushes.Black, 150, 580) 'left to right, top to bottom

        e.Graphics.DrawString(Label24.Text, font1, Brushes.Black, 150, 600) 'left to right, top to bottom
        e.Graphics.DrawString(Label25.Text, font1, Brushes.Black, 150, 620) 'left to right, top to bottom


        e.Graphics.DrawString(Label26.Text, font1, Brushes.Black, 150, 640) 'left to right, top to bottom
        e.Graphics.DrawString(Label27.Text, font1, Brushes.Black, 150, 660) 'left to right, top to bottom




        e.Graphics.DrawString(Label28.Text, font1, Brushes.Black, 90, 700) 'left to right, top to bottom
        e.Graphics.DrawString(madeduct.Text, font1, Brushes.Black, 555, 700) 'left to right, top to bottom


        e.Graphics.DrawString(Label29.Text, font1, Brushes.Black, 90, 730) 'left to right, top to bottom
        e.Graphics.DrawString(netpay.Text, font1, Brushes.Black, 555, 730) 'left to right, top to bottom

        e.Graphics.DrawString(Label30.Text, font1, Brushes.Black, 455, 870) 'left to right, top to bottom
        e.Graphics.DrawString(Label31.Text, font1, Brushes.Black, 485, 940) 'left to right, top to bottom
        e.Graphics.DrawString(Label32.Text, font1, Brushes.Black, 485, 960) 'left to right, top to bottom


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub IndividualRecordsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndividualRecordsToolStripMenuItem1.Click
        dtr.Show()
        Me.Close()
    End Sub

    Private Sub PayrollToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayrollToolStripMenuItem.Click
        payroll.Show()
        Me.Close()
    End Sub

    Private Sub PayrollForJobOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayrollForJobOrderToolStripMenuItem.Click
        JobOrderPayroll.Show()
        Me.Close()

    End Sub

    Private Sub PayrollForPartTimeEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayrollForPartTimeEmployeeToolStripMenuItem.Click
        PartTime.Show()
        Me.Close()
    End Sub

    Private Sub ListOfEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfEmployeeToolStripMenuItem.Click
        Employee.Show()
        Me.Close()
    End Sub

    Private Sub RegisterEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterEmployeeToolStripMenuItem.Click
        reg.Show()
        Me.Close()

    End Sub

    Private Sub AdminPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminPageToolStripMenuItem.Click
        AdminPanel.Show()
        Me.Close()
    End Sub
End Class