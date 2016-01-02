'*******************************************************************'
'CPSU Hinigaran Payrol System Using Biometric
'Programmer: Ronel B. Llarenas 
'*******************************************************************'


Imports System.IO
Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Globalization
Imports System.Drawing.Printing

Imports System.Data.SqlClient


Public Class dtr




    Dim mRow As Integer = 0
    Dim newpage As Boolean = True

    Dim sql As String
    Dim sql1 As String
    Dim sql2 As String
    Dim sqla As String


    Dim sql_connection As MySqlClient.MySqlConnection
    Dim sql_command As MySqlClient.MySqlCommand

    Dim DR As MySqlClient.MySqlDataReader

    Private Sub dtr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      

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

        ''''''
        daytext.Hide()

        monthtext.Hide()
        yeartext.Hide()
        kinsenas.Hide()

        If kinsenas.Text = "a" Then
            monthquarter.Text = "1 to 15, "

        ElseIf kinsenas.Text = "b" Then
            monthquarter.Text = "16 to 31, "

        End If

        formonthname.Text = MonthName(Now.Month)
        Label20.Text = Now.Year





    End Sub

    Public Sub search_dtr()
        '  always check your connection state first
        If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()
        Try
            sql = "SELECT * from dtr where idnum like '%" & TextBox1.Text & "%'  and nowyear like '%" & yeartext.Text & "%' and nowmonth like '%" & monthtext.Text & "%' and halfmonth like '%" & kinsenas.Text & "%'  "
            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
            DR = sql_command.ExecuteReader()

            dgvData.Rows.Clear()

            'for random numbers
            Dim indRow As Integer = 0
            For i As Integer = 0 To 31
                indRow = Me.dgvData.RowCount
                Me.dgvData.Rows.Add()

                With Me.dgvData.Rows(indRow)
                    .Cells("dayy").Value = i.ToString
                    .Cells("column15").Value = "00:00"
                End With
            Next


            Do While DR.Read = True

                Dim nowday = DR.GetString("nowday")

                Dim amin = DR.GetString("amin")
                Dim amout = DR.GetString("amout")
                Dim amtotal = DR.GetString("amtotal")
                Dim pmin = DR.GetString("pmin")
                Dim pmout = DR.GetString("pmout")
                Dim pmtotal = DR.GetString("pmtotal")
                Dim alltotal = DR.GetString("alltotal")
                '  Dim gp = DR.GetString("gp")
                '  Dim dates = DR.GetString("date")


                dgvData.Rows.Item(CInt(nowday)).Cells(1).Value = amin
                dgvData.Rows.Item(CInt(nowday)).Cells(2).Value = amout
                dgvData.Rows.Item(CInt(nowday)).Cells(3).Value = amtotal
                dgvData.Rows.Item(CInt(nowday)).Cells(4).Value = pmin
                dgvData.Rows.Item(CInt(nowday)).Cells(5).Value = pmout
                dgvData.Rows.Item(CInt(nowday)).Cells(6).Value = pmtotal

                dgvData.Rows.Item(CInt(nowday)).Cells(7).Value = alltotal



            Loop
            DR.Close()

            sql_command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        Finally
            sql_connection.Close()
        End Try






        Dim max As Integer = dgvData.Rows.Count - 1

        'fortime()

        'dgvData.Rows(max).Cells(7).Value = 0
        'allhours.Text = 0
        Dim totala As New TimeSpan
        For Each row As DataGridViewRow In dgvData.Rows


            '        '    formula()

            totala += (TimeSpan.Parse(row.Cells(7).Value))

        Next
        ' dgvData.Rows(max).Cells(7).Value = totala.ToString

        timeall.Text = totala.ToString


        '    ' for total income
        '    'dgvData.Rows(max).Cells(8).Value = 0
        '    amount.Text = 0
        '    Dim total As Double = 0
        '    For Each row As DataGridViewRow In dgvData.Rows
        '        '   formula...
        '        total += Val(row.Cells(8).Value)
        '    Next
        '    'dgvData.Rows(max).Cells(8).Value = total.ToString
        '    amount.Text = total.ToString


        '    sql_connection.Close()

        '    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '    'tax deduct etc.


        '    Dim amountt As Integer
        '    Dim taxx As Integer

        '    taxx = tax.Text
        '    amountt = amount.Text



        '    madeduct.Text = amount.Text * tax.Text

        '    totalgrosspay.Text = amount.Text - madeduct.Text




    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        search_dtr()

        If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

        Try

            sql1 = "SELECT * from user where idnum like '%" & TextBox1.Text & "%'"


            sql_command = New MySqlCommand(sql1, sql_connection)
            DR = sql_command.ExecuteReader()


            Do While DR.Read = True
                fname.Text = Format(DR("fname"))

                mname.Text = Format(DR("mname"))
                lname.Text = Format(DR("lname"))
                appoint.Text = Format(DR("appointment"))

            Loop
            DR.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub

        End Try

        sql_connection.Close()


    End Sub



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        PrintPreviewDialog1.ShowDialog()


    End Sub



    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim font As New System.Drawing.Font("arial", 16, FontStyle.Regular)
        Dim font1 As New System.Drawing.Font("arial", 9, FontStyle.Regular)
        Dim font2 As New System.Drawing.Font("arial", 20, FontStyle.Regular)

        e.Graphics.DrawString(Label3.Text, font, Brushes.Black, 150, 30)
        e.Graphics.DrawString(DateTimePicker1.Text, font1, Brushes.Black, 500, 190)

        e.Graphics.DrawString(Label8.Text, font, Brushes.Black, 280, 110)
        e.Graphics.DrawString(Label2.Text, font1, Brushes.Black, 100, 170) 'left to right, top to bottom
        e.Graphics.DrawString(fname.Text, font1, Brushes.Black, 225, 170)
        e.Graphics.DrawString(mname.Text, font1, Brushes.Black, 295, 170)
        e.Graphics.DrawString(lname.Text, font1, Brushes.Black, 350, 170)

        e.Graphics.DrawString(Label18.Text, font1, Brushes.Black, 100, 190)

        e.Graphics.DrawString(formonthname.Text, font1, Brushes.Black, 210, 190)

        e.Graphics.DrawString(monthquarter.Text, font1, Brushes.Black, 270, 190)
        e.Graphics.DrawString(Label20.Text, font1, Brushes.Black, 318, 190)
        e.Graphics.DrawString(Label22.Text, font1, Brushes.Black, 260, 190)


        e.Graphics.DrawString(Label5.Text, font1, Brushes.Black, 200, 230)
        e.Graphics.DrawString(Label7.Text, font1, Brushes.Black, 395, 230)


        e.Graphics.DrawString(Label11.Text, font1, Brushes.Black, 150, 935)
        e.Graphics.DrawString(Label12.Text, font1, Brushes.Black, 200, 975)
        e.Graphics.DrawString(Label16.Text, font1, Brushes.Black, 280, 990)

        e.Graphics.DrawString(kurit.Text, font1, Brushes.Black, 200, 1030)

        e.Graphics.DrawString(Label15.Text, font1, Brushes.Black, 280, 1050)
        e.Graphics.DrawString(timeall.Text, font1, Brushes.Black, 545, 915)



        Dim mRow As Integer = 0
        Dim newpage As Boolean = True
        With Me.dgvData
            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fmt.LineAlignment = StringAlignment.Center
            fmt.Trimming = StringTrimming.EllipsisCharacter
            Dim y As Single = e.MarginBounds.Top
            Dim prFont As New System.Drawing.Font("Verdana", 22, GraphicsUnit.Point)
            Dim siFont As New System.Drawing.Font("Verdana", 9, GraphicsUnit.Point)
            Dim hdrFont As New System.Drawing.Font("Verdana", 10, FontStyle.Bold)
            '  Dim strInfo As String
            'If PrintDocument1.DefaultPageSettings.Landscape Then

            '    e.Graphics.DrawString(vbTab & "" & "", prFont, Brushes.Black, 60, 40)
            '    ' e.Graphics.DrawString(strInfo, siFont, Brushes.Black, 110, 80)
            '    PrintPreviewDialog1.Document = PrintDocument1
            '    PrintDocument1.DefaultPageSettings.Margins.Left = 50
            '    PrintDocument1.DefaultPageSettings.Margins.Right = 50
            '    PrintDocument1.DefaultPageSettings.Margins.Top = 100
            '    PrintDocument1.DefaultPageSettings.Margins.Bottom = 50
            '    y = 120
            'Else

            ' e.Graphics.DrawString(strInfo, siFont, Brushes.Black, 55, 80)
            PrintPreviewDialog1.Document = PrintDocument1
            PrintDocument1.DefaultPageSettings.Margins.Left = 100
            PrintDocument1.DefaultPageSettings.Margins.Right = 50
            PrintDocument1.DefaultPageSettings.Margins.Top = 50
            PrintDocument1.DefaultPageSettings.Margins.Bottom = 50
            y = 250
            'End If
            Do While mRow < .RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left
                Dim h As Single = 0

                For Each cell As DataGridViewCell In row.Cells
                    Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)

                    e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)
                    If (newpage) Then

                        e.Graphics.DrawString(Me.dgvData.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)
                        
                    Else

                        e.Graphics.DrawString(Me.dgvData.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)

                       

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


    'Private Sub RegisterAEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub
    'Private Sub PayrollToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    Private Sub PayrollToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayrollToolStripMenuItem.Click
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        timeattendance.Show()
    End Sub




    Private Sub PaySlipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaySlipToolStripMenuItem.Click
        individual_payslip.Show()
        Me.Close()
    End Sub
End Class



