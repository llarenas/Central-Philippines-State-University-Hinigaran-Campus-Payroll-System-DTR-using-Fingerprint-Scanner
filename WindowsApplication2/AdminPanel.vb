'*******************************************************************'
'CPSU Hinigaran Payrol System Using Biometric
'Programmer: Ronel B. Llarenas 
'*******************************************************************'


Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Imports Microsoft.VisualBasic

Public Class AdminPanel
    Dim sql_connection As MySqlClient.MySqlConnection
    Dim sql_command As MySqlClient.MySqlCommand

    Dim DR As MySqlClient.MySqlDataReader

    Dim sql As String
    Dim sql2 As String


    Private Sub AdminPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql_connection = New MySqlClient.MySqlConnection("Data Source=localhost;user id=root;password=NO;database=system;")
        Try
            sql_connection.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try

            sql = "SELECT * from admin"

            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

            DR = sql_command.ExecuteReader()

            Do While DR.Read = True

                rate.Text = Format(DR("rate"))
                tax.Text = Format(DR("tax"))
                jorate.Text = Format(DR("joborderrate"))
                ptrate.Text = Format(DR("parttimerate"))

            Loop
            DR.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' always check your connection state first
        If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

        Try

            sql = "update admin set  rate = @rate, tax= @tax, joborderrate=@joborderrate, parttimerate=@parttimerate "
            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

            'sql_command.Parameters.AddWithValue("@password", vbNullChar)
            sql_command.Parameters.AddWithValue("@rate", rate.Text)

            sql_command.Parameters.AddWithValue("@tax", tax.Text)


            sql_command.Parameters.AddWithValue("@joborderrate", jorate.Text)
            sql_command.Parameters.AddWithValue("@parttimerate", ptrate.Text)
            sql_command.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        Me.Refresh()

        MsgBox("Successfully Updated")
        ' End If
    End Sub

    Private Sub IndividualRecordsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dtr.Show()
        Me.Close()

    End Sub

    Private Sub PayrollToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        payroll.Show()
        Me.Close()
    End Sub


    Private Sub RegisterAEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        reg.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        timeattendance.Show()
        Me.Close()

    End Sub

    Private Sub rate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rate.KeyPress

       if e.KeyChar <> ControlChars.Back then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If

    End Sub

    Private Sub tax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tax.KeyPress

        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If

    End Sub

    Private Sub jorate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles jorate.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If

    End Sub

    
    Private Sub ListOfEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub IndividualRecordsToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndividualRecordsToolStripMenuItem1.Click
        dtr.Show()
        Me.Close()

    End Sub

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

    Private Sub ListOfEmployeeToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfEmployeeToolStripMenuItem.Click
        Employee.Show()
        Me.Close()

    End Sub

    Private Sub RegisterEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterEmployeeToolStripMenuItem.Click
        reg.Show()
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