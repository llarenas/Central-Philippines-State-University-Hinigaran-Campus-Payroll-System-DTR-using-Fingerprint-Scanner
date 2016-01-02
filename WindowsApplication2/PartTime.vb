'*******************************************************************'
'CPSU Hinigaran Payrol System Using Biometric
'Programmer: Ronel B. Llarenas 
'*******************************************************************'

Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.ComponentModel


Public Class PartTime


    'Dim Cn As new
    Dim cmd As New MySqlCommand
    Dim adp As New MySqlDataAdapter
    Dim adp1 As New MySqlDataAdapter
    Dim mRow As Integer = 0
    Dim newpage As Boolean = True

    Dim sql As String
    Dim sql1 As String
    Dim sqla As String

    Dim sql_connection As MySqlClient.MySqlConnection
    Dim sql_connection1 As MySqlClient.MySqlConnection
    Dim sql_connection2 As MySqlClient.MySqlConnection
    Dim sql_command As MySqlClient.MySqlCommand
    Dim sql_command1 As MySqlClient.MySqlCommand
    Dim tbl As New DataTable
    Dim tbl1 As New DataTable
    Dim DR As MySqlClient.MySqlDataReader
    Dim DR1 As MySqlClient.MySqlDataReader


    Private Sub PartTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        yeartext.Text = Now.Year
        monthtext.Text = Now.Month

        daytext.Text = Now.Day

        ''''
        Dim valx As Integer
        valx = (Val(daytext.Text))

        If Val(daytext.Text.Trim) < "16" Then

            kinsenas.Text = "a"
        Else
            kinsenas.Text = "b"

        End If



        sql_connection = New MySqlClient.MySqlConnection("Data Source=localhost;user id=root;password=NO;database=system;")
        sql_connection1 = New MySqlClient.MySqlConnection("Data Source=localhost;user id=root;password=NO;database=system;")
        sql_connection2 = New MySqlClient.MySqlConnection("Data Source=localhost;user id=root;password=NO;database=system;")
        Try
            sql_connection.Open()
            sql_connection1.Open()
            sql_connection2.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try



        Try


            sql = "SELECT * from user where appointment like '%" & "Part_Time" & "%'   "

            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

            DR = sql_command.ExecuteReader()


            DataGridView1.Rows.Clear()
            Dim tot As Double
            Do While DR.Read = True

                'AA = DR("idnum") 
                'sql_command1 = New MySqlClient.MySqlCommand("SELECT sum(alltotal) from dtr where idnum = '" & DR("idnum") & "' ", sql_connection1)
                'adp.SelectCommand = New MySqlCommand("SELECT sum(alltotal) from dtr where idnum = '" & DR("idnum") & "' ", sql_connection1)

                ' adp.SelectCommand = New MySqlCommand("SELECT sum(alltotal) from dtr where idnum = '" & DR("idnum") & "'  ", sql_connection1)
                adp.SelectCommand = New MySqlCommand("SELECT SEC_TO_TIME(SUM(TIME_TO_SEC(alltotal))), sum(gp), sum(madeduct), sum(debit)  from dtr where idnum =  '" & DR("idnum") & "' and nowmonth = '" & monthtext.Text & " ' and nowyear = '" & yeartext.Text & " ' and halfmonth = '" & kinsenas.Text & " '   ", sql_connection1)
                adp1.SelectCommand = New MySqlCommand("SELECT (parttimerate)  from admin ", sql_connection1)

                'adp.SelectCommand = New MySqlCommand("SELECT rate from admin   ", sql_connection)

                adp.Fill(tbl)
                adp1.Fill(tbl1)
                '  DR1 = sql_command1.ExecuteReader() 

                'DataGridView1.Rows.Add(DR("idnum"), DR("lname"), DR("fname"), DR("appointment"), DR("allhours"), DR("rate"), DR("amount"), DR("deduction"))
                'DataGridView1.Rows.Add(AA, DR("lname"), DR("fname"), DR("appointment"), DR1("alltotal"), DR("rate"), DR("amount"), DR("deduction"))

                DataGridView1.Rows.Add(DR("idnum"), DR("lname"), DR("fname"), DR("mname"), DR("appointment"), tbl.Rows(0)("SEC_TO_TIME(SUM(TIME_TO_SEC(alltotal)))").ToString, tbl1.Rows(0)("parttimerate").ToString, tbl.Rows(0)("sum(gp)").ToString, tbl.Rows(0)("sum(madeduct)").ToString, tbl.Rows(0)("sum(debit)").ToString)


                ' DR1.Close()
                tot = Nothing
                tbl.Clear()

            Loop

            DR.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        DataGridView1.Sort(DataGridView1.Columns(1), ListSortDirection.Ascending)


        '   para sa word nga total
        'Dim max As Integer = DataGridView1.Rows.Count - 1
        'DataGridView1.Rows(max).Cells(6).Value = "Total:"

        ''forsalary

        'Dim total As Double = 0
        'For Each row As DataGridViewRow In DataGridView1.Rows
        '    '    formula()
        '    total += Val(row.Cells(7).Value)
        'Next
        'DataGridView1.Rows(max).Cells(7).Value = total.ToString



        ''forsalary

        Dim totala As Double = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            '    formula()
            totala += Val(row.Cells(8).Value)
        Next
        'DataGridView1.Rows(max).Cells(8).Value = totala.ToString
        credit.Text = totala.ToString



        Dim totalaa As Double = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            '    formula()
            totalaa += Val(row.Cells(9).Value)
        Next
        'DataGridView1.Rows(max).Cells(9).Value = totalaa.ToString
        debit.Text = totalaa.ToString
        TextBox1.Text = totalaa.ToString

        ''''

        daytext.Hide()
        kinsenas.Hide()
        yeartext.Hide()
        monthtext.Hide()

        If kinsenas.Text = "a" Then
            monthquarter.Text = "1 to 15, "

        ElseIf kinsenas.Text = "b" Then
            monthquarter.Text = "16 to 31, "

        End If

        formonthname.Text = MonthName(Now.Month)
        Label20.Text = Now.Year

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Dim font As New Font("arial", 16, FontStyle.Regular)
        'Dim font1 As New Font("arial", 10, FontStyle.Regular)
        'Dim font2 As New Font("arial", 20, FontStyle.Regular)
        'e.Graphics.DrawString(Label14.Text, font, Brushes.Black, 150, 30)
        'e.Graphics.DrawString(Label1.Text, font1, Brushes.Black, 300, 80) 'left to right, top to bottom
        'e.Graphics.DrawString(Label19.Text, font1, Brushes.Black, 500, 800)
        'e.Graphics.DrawString(Label9.Text, font1, Brushes.Black, 600, 800) 'left to right, top to bottom
        'e.Graphics.DrawString(credit.Text, font1, Brushes.Black, 500, 825)
        'e.Graphics.DrawString(debit.Text, font1, Brushes.Black, 600, 825) 'left to right, top to bottom


        'e.Graphics.DrawString(Label18.Text, font1, Brushes.Black, 150, 115)
        'e.Graphics.DrawString(formonthname.Text, font1, Brushes.Black, 265, 115)
        'e.Graphics.DrawString(Label20.Text, font1, Brushes.Black, 300, 115)
        'e.Graphics.DrawString(monthquarter.Text, font1, Brushes.Black, 360, 115)

        'e.Graphics.DrawString(Label4.Text, font1, Brushes.Black, 100, 850)
        '' e.Graphics.DrawString(Label6.Text, font1, Brushes.Black, 100, 875) 'left to right, top to bottom

        'e.Graphics.DrawString(Label5.Text, font1, Brushes.Black, 100, 1000)
        'e.Graphics.DrawString(TextBox1.Text, font1, Brushes.Black, 370, 1000)

        'e.Graphics.DrawString(DateTimePicker1.Text, font1, Brushes.Black, 300, 100)

        'e.Graphics.DrawString(Label12.Text, font1, Brushes.Black, 100, 950)
        '' e.Graphics.DrawString(Label13.Text, font1, Brushes.Black, 100, 975)





        Dim font As New Font("arial", 16, FontStyle.Regular)
        Dim font1 As New Font("arial", 10, FontStyle.Regular)
        Dim font2 As New Font("arial", 20, FontStyle.Regular)
        e.Graphics.DrawString(Label14.Text, font, Brushes.Black, 250, 30)

        e.Graphics.DrawString(Label18.Text, font1, Brushes.Black, 150, 145)
        e.Graphics.DrawString(DateTimePicker1.Text, font1, Brushes.Black, 666, 145)


        e.Graphics.DrawString(formonthname.Text, font1, Brushes.Black, 270, 145)
        e.Graphics.DrawString(Label20.Text, font1, Brushes.Black, 400, 145)
        e.Graphics.DrawString(monthquarter.Text, font1, Brushes.Black, 330, 145)

        e.Graphics.DrawString(Label1.Text, font, Brushes.Black, 300, 100) 'left to right, top to bottom
        e.Graphics.DrawString(Label19.Text, font1, Brushes.Black, 800, 800)

        e.Graphics.DrawString(Label9.Text, font1, Brushes.Black, 950, 800) 'left to right, top to bottom
        e.Graphics.DrawString(credit.Text, font1, Brushes.Black, 800, 825)



        'e.Graphics.DrawString(Label5.Text, font1, Brushes.Black, 50, 800) 'left to right, top to bottom
        'e.Graphics.DrawString(TextBox1.Text, font1, Brushes.Black, 360, 800)
        ''e.Graphics.DrawString(Label7.Text, font1, Brushes.Black, 700, 800) 'left to right, top to bottom
        ''e.Graphics.DrawString(TextBox2.Text, font1, Brushes.Black, 700, 825)



        e.Graphics.DrawString(debit.Text, font1, Brushes.Black, 950, 825) 'left to right, top to bottom


        'e.Graphics.DrawString(Label6.Text, font1, Brushes.Black, 100, 875) 'left to right, top to bottom

        e.Graphics.DrawString(Label5.Text, font1, Brushes.Black, 50, 750)
        e.Graphics.DrawString(TextBox1.Text, font1, Brushes.Black, 370, 750)


        e.Graphics.DrawString(collecting.Text, font1, Brushes.Black, 400, 800)
        e.Graphics.DrawString(direct.Text, font1, Brushes.Black, 100, 800)








        'With DataGridView1
        '    Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)

        '    fmt.LineAlignment = StringAlignment.Center
        '    fmt.Trimming = StringTrimming.EllipsisCharacter


        '    ' Dim headerfont As Font = New Drawing.Font("times new roman", 20)


        '    Dim y As Single = 190
        '    Do While mRow < .RowCount
        '        Dim row As DataGridViewRow = .Rows(mRow)
        '        Dim x As Single = 5
        '        Dim h As Single = 0
        '        For Each cell As DataGridViewCell In row.Cells
        '            Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)

        '            e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)

        '            ' e.Graphics.DrawString(dgvData.ColumnHeadersVisible).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
        '            If (newpage) Then
        '                e.Graphics.DrawString(DataGridView1.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)

        '            Else

        '                'e.Graphics.DrawString(dgvData.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)

        '                e.Graphics.DrawString(DataGridView1.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)

        '            End If


        '            x += rc.Width
        '            h = Math.Max(h, rc.Height)

        '        Next
        '        newpage = False
        '        y += h
        '        mRow += 1
        '        If y + h > e.MarginBounds.Bottom Then
        '            e.HasMorePages = True
        '            mRow -= 1
        '            newpage = True
        '            Exit Sub
        '        End If
        '    Loop
        '    mRow = 0

        'End With


        Dim mRow As Integer = 0
        Dim newpage As Boolean = True
        With Me.DataGridView1
            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fmt.LineAlignment = StringAlignment.Center
            fmt.Trimming = StringTrimming.EllipsisCharacter
            Dim y As Single = e.MarginBounds.Top
            Dim prFont As New System.Drawing.Font("Verdana", 22, GraphicsUnit.Point)
            Dim siFont As New System.Drawing.Font("Verdana", 9, GraphicsUnit.Point)
            Dim hdrFont As New System.Drawing.Font("Verdana", 10, FontStyle.Bold)

            PrintPreviewDialog1.Document = PrintDocument1
            PrintDocument1.DefaultPageSettings.Margins.Left = 50
            PrintDocument1.DefaultPageSettings.Margins.Right = 50
            PrintDocument1.DefaultPageSettings.Margins.Top = 10
            PrintDocument1.DefaultPageSettings.Margins.Bottom = 50
            y = 200
            'End If
            Do While mRow < .RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left
                Dim h As Single = 0

                For Each cell As DataGridViewCell In row.Cells
                    Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)

                    e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)
                    If (newpage) Then

                        e.Graphics.DrawString(Me.DataGridView1.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)

                    Else

                        e.Graphics.DrawString(Me.DataGridView1.Rows(cell.RowIndex - 1).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)

                        ' e.Graphics.DrawString(DataGridView1.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)

                    End If

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                Next
                newpage = False
                y += h
                mRow += 1
                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    mRow -= 1
                    newpage = True
                    Exit Sub
                End If
            Loop
            mRow = 0
        End With




    End Sub

    

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        PrintDocument1.DefaultPageSettings.Landscape = True
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        timeattendance.Show()

    End Sub

    Private Sub PaySlipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaySlipToolStripMenuItem.Click
        individual_payslip.Show()
        Me.Close()
    End Sub
End Class