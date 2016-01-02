'*******************************************************************'
'CPSU Hinigaran Payrol System Using Biometric
'Programmer: Ronel B. Llarenas 
'*******************************************************************'

Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.ComponentModel



Public Class Employee

    Dim sql_connection As MySqlClient.MySqlConnection
    Dim sql_command As MySqlClient.MySqlCommand

    Dim DR As MySqlClient.MySqlDataReader


    Dim sql As String


    Private Sub Employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        sql_connection = New MySqlClient.MySqlConnection("Data Source=localhost;user id=root;password=NO;database=system;")
        Try
            sql_connection.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()
        Try


            sql = "SELECT * from user"

            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

            DR = sql_command.ExecuteReader()


            DataGridView1.Rows.Clear()
            Do While DR.Read = True


                DataGridView1.Rows.Add(DR("idnum"), DR("fname"), DR("mname"), DR("lname"), DR("status"), DR("appointment"), DR("birthday"), DR("address"), DR("gender"))


            Loop
            DR.Close()

        Catch ex As Exception
            MsgBox("Error Creating DB Connection")
        End Try
        sql_connection.Close()

        DataGridView1.Sort(DataGridView1.Columns(1), ListSortDirection.Ascending)
        ' DataGridView1.Sort(DataGridView1.Columns(5), ListSortDirection.Ascending)


    End Sub

    Private Sub IndividualRecordsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dtr.Show()
        Me.Close()
    End Sub

    Private Sub TodaysRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        payroll.Show()
        Me.Close()
    End Sub


    Private Sub RegisterAEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        reg.Show()
        Me.Close()
    End Sub

    Private Sub AdminMainPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AdminPanel.Show()
        Me.Close()
    End Sub

    Private Sub IndividualRecordsToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndividualRecordsToolStripMenuItem1.Click
        dtr.Show()
        Me.Hide()

    End Sub

    Private Sub PayrollToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayrollToolStripMenuItem.Click
        payroll.Show()
        Me.Hide()

    End Sub

    Private Sub PayrollForJobOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayrollForJobOrderToolStripMenuItem.Click
        JobOrderPayroll.Show()
        Me.Hide()

    End Sub

    Private Sub PayrollForPartTimeEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayrollForPartTimeEmployeeToolStripMenuItem.Click
        PartTime.Show()
        Me.Hide()


    End Sub

    Private Sub RegisterEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterEmployeeToolStripMenuItem.Click
        reg.Show()
        Me.Hide()

    End Sub

    Private Sub AdminPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminPageToolStripMenuItem.Click
        AdminPanel.Show()
        Me.Hide()

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