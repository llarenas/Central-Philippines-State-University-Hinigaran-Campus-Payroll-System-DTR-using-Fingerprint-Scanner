'*******************************************************************'
'CPSU Hinigaran Payrol System Using Biometric
'Programmer: Ronel B. Llarenas 
'*******************************************************************'


Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO

Delegate Sub FunctionCall(ByVal param)

Public Class reg

    '  Public ctr As Integer = 0

    Dim sql As String
    Dim sql1 As String
    Dim sqlup As String
    Dim sqld As String
    Dim queryResult As Integer

    Dim imagepath As String
    Dim idnum As String

    Dim sql_connection As MySqlClient.MySqlConnection
    Dim sql_command As MySqlClient.MySqlCommand

    Dim DR As MySqlClient.MySqlDataReader

    Dim sapi

    Private Sub EnrollButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollButton.Click

        Dim Enroller As New EnrollmentForm()
        AddHandler Enroller.OnTemplate, AddressOf OnTemplate
        Enroller.ShowDialog()

    End Sub




    'SAVE BUTTON
    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If TextBox1.Text = "" Then

            MsgBox("Please Fill Up all Fields in order to Register")
        ElseIf TextBox2.Text = "" Then

            MsgBox("Please Fill Up all Fields in order to Register")
        ElseIf mname.Text = "" Then

            MsgBox("Please Fill Up all Fields in order to Register")
        ElseIf TextBox3.Text = "" Then



            MsgBox("Please Fill Up all Fields in order to Register")
        ElseIf ComboBox1.Text = "" Then

            MsgBox("Please Fill Up all Fields in order to Register")
        ElseIf ComboBox2.Text = "" Then

            MsgBox("Please Fill Up all Fields in order to Register")

        ElseIf DateTimePicker1.Text = "" Then
            MsgBox("Please Fill Up all Fields in order to Register")

        ElseIf address.Text = "" Then
            MsgBox("Please Fill Up all Fields in order to Register")

        ElseIf ComboBox3.Text = "" Then
            MsgBox("Please Fill Up all Fields in order to Register")

        Else


            ' always check your connection state first
            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

            sql_command = New MySqlCommand("SELECT COUNT(*) AS numRows FROM user WHERE idnum like '%" & TextBox1.Text & "%' ", sql_connection)

            queryResult = sql_command.ExecuteScalar()

            If queryResult = 0 Then

                '  Dim mstream As New System.IO.MemoryStream()
                ' Template.Serialize(mstream)
                '  Dim temp() As Byte = mstream.GetBuffer()
                ' mstream.Close()

                Try

                    sql = "INSERT INTO user(id, idnum, fname, mname, lname, status, appointment, birthday, address, gender, veri) VALUES(@id, @idnum, @fname, @mname, @lname, @status, @appointment, @birthday, @address, @gender,  @veri)"
                    sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
                    sql_command.Parameters.AddWithValue("@id", Nothing)
                    '  sql_command.Parameters.AddWithValue("@fpt", temp)
                    sql_command.Parameters.AddWithValue("@idnum", TextBox1.Text)
                    sql_command.Parameters.AddWithValue("@fname", TextBox2.Text)
                    sql_command.Parameters.AddWithValue("@mname", mname.Text)
                    sql_command.Parameters.AddWithValue("@lname", TextBox3.Text)
                    sql_command.Parameters.AddWithValue("@status", ComboBox1.Text)
                    sql_command.Parameters.AddWithValue("@appointment", ComboBox2.Text)
                    sql_command.Parameters.AddWithValue("@birthday", DateTimePicker1.Text)
                    sql_command.Parameters.AddWithValue("@address", address.Text)
                    sql_command.Parameters.AddWithValue("@gender", ComboBox3.Text)
                    sql_command.Parameters.AddWithValue("@veri", "unveri")
                    sql_command.ExecuteNonQuery()


                    ''''''''

                    idnum = TextBox1.Text + (".fpt")

                    Using fs As IO.FileStream = IO.File.Open(imagepath & idnum, IO.FileMode.Create, IO.FileAccess.Write)

                        Template.Serialize(fs)

                    End Using



                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Exit Sub
                End Try

                Labelok.Text = "Successfully Registered"
                sapi = CreateObject("SAPI.spvoice")
                sapi.Speak(Labelok.Text)

                'TextBox1.Text = ""
                TextBox2.Text = ""
                mname.Text = ""
                TextBox3.Text = ""
                ComboBox1.Text = ""
                ComboBox2.Text = ""
                DateTimePicker1.Text = ""
                address.Text = ""
                ComboBox3.Text = ""

                Label7.Text = ""
                Label8.Text = ""
                Labelmname.Text = ""
                Label9.Text = ""
                Label10.Text = ""
                Label11.Text = ""
                Labelbday.Text = ""
                Labeladd.Text = ""
                Labelgender.Text = ""



            Else

                MessageBox.Show("Your ID Number Already Exist in the Database", "Cannot Register same ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub





    Private Sub OnTemplate(ByVal template)
        Invoke(New FunctionCall(AddressOf _OnTemplate), template)
    End Sub


    Private Sub _OnTemplate(ByVal template)
        Me.Template = template
        If Not template Is Nothing Then
            updatebutton.Enabled = True
            SaveButton.Enabled = True '() 'And (search.Text Is Nothing)
            Button1.Enabled = True
        End If
        If Not template Is Nothing Then
            ' MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment")
            Labelok.Text = "The fingerprint template is ready." ', "Fingerprint Enrollment"
            sapi = CreateObject("SAPI.spvoice")
            sapi.Speak(Labelok.Text)
          

        Else
            MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment")
        End If
    End Sub


    Private Template As DPFP.Template


    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql_connection = New MySqlClient.MySqlConnection("Data Source=localhost;user id=root;password=NO;database=system;")
        Try
            sql_connection.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Label7.Hide()

        Label8.Hide()
        Labelmname.Hide()

        Label9.Hide()

        Label10.Hide()

        Label11.Hide()
        Labelbday.Hide()
        Labeladd.Hide()
        Labelgender.Hide()

        ''''''''''


        imagepath = Application.StartupPath & "\"

        ' Check if Folder Exists
        If Directory.Exists(imagepath) = False Then
            'if not create a folder 
            Directory.CreateDirectory(imagepath)
        End If

        ' loadfpt()

        updatebutton.Enabled = False

    End Sub




    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        search.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        mname.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox4.Text = ""
        DateTimePicker1.Text = ""
        address.Text = ""
        ComboBox3.Text = ""


    End Sub

    Private Sub IndividualRecordsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dtr.Show()
        Me.Close()

    End Sub

    Private Sub PayrollToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        payroll.Show()
        Me.Close()
    End Sub


    

    Private Sub search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.TextChanged
        ' always check your connection state first
        If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

        Try

            sql1 = "SELECT * from user where idnum like '%" & search.Text & "%'"


            sql_command = New MySqlCommand(sql1, sql_connection)
            DR = sql_command.ExecuteReader()

            Do While DR.Read = True
                TextBox4.Text = Format(DR("id"))

                TextBox1.Text = Format(DR("idnum"))
                TextBox2.Text = Format(DR("fname"))
                mname.Text = Format(DR("mname"))
                TextBox3.Text = Format(DR("lname"))
                ComboBox1.Text = Format(DR("status"))
                ComboBox2.Text = Format(DR("appointment"))
                DateTimePicker1.Text = Format(DR("birthday"))
                address.Text = Format(DR("address"))
                ComboBox3.Text = Format(DR("gender"))

            Loop
            DR.Close()



        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub

        End Try

        sql_connection.Close()


        ''''
        '   Dim xeid As String = Nothing
        '  Dim s As String = Nothing

        '  Me.Text = ComboBox3.Items(ctr).ToString()
        '  For ii = 1 To Len(Me.Text)

        '  s = Mid(Me.Text, ii, 1)


        ' If s = "." Then GoTo srch
        '   xeid = xeid & s
        'ii += 1
        '   Next

        'srch:

        ' search.Text = xeid

        '   Dim di As New IO.DirectoryInfo(Application.StartupPath & "\")
        ' idnum = ComboBox3.Items.Add(System.IO.Path.GetFileNameWithoutExtension(idnum))

        ' Dim ImgFolder As New IO.DirectoryInfo(imagepath)
        ' Dim fptFile As IO.FileInfo() = di.GetFiles("*.fpt")
        '   Using fs As IO.FileStream = IO.File.OpenRead(idnum)
        ' ComboBox3
        'Dim template As New DPFP.Template(fs)
        ' OnTemplate(template)
        ' End Using

    End Sub


    '  Public Sub loadfpt()

    '  Dim ImgFolder As New IO.DirectoryInfo(imagepath)
    ' Dim ImgFile As IO.FileInfo() = ImgFolder.GetFiles("*.*")
    ' Dim info As IO.FileInfo
    ' Dim filename As String
    ' ComboBox3.Items.Clear() 'Clear all items from cmbCaption

    '  For Each info In ImgFile
    'Add all files to cmbCaption
    ' filename = IO.Path.GetFileName(info.FullName)
    '  ComboBox3.Items.Add(filename)
    '   Next
    ' End Sub

   

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox4.Text = "" Then
            MsgBox("Unable to Delete")
        Else

            ' always check your connection state first

            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

            Try
                sqld = "delete from user where id like '%" & TextBox4.Text & "%'"
                sql_command = New MySqlCommand(sqld, sql_connection)
                sql_command.ExecuteNonQuery()


            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try



            Labelok.Text = "Successfully  Deleted the Record"
            sapi = CreateObject("SAPI.spvoice")
            sapi.Speak(Labelok.Text)

            search.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            mname.Text = ""
            TextBox3.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            DateTimePicker1.Text = ""
            address.Text = ""
            ComboBox3.Text = ""

            TextBox4.Text = ""

            sql_connection.Close()

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Label7.Show()
        Else
            Label7.Hide()
        End If
    End Sub




    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "" Then
            Label10.Show()
        Else
            Label10.Hide()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "" Then
            Label11.Show()
        Else
            Label11.Hide()
        End If
    End Sub

   
    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        TextBox2.Text = StrConv(TextBox2.Text, vbProperCase)
    End Sub

   

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then

            Label8.Show()
        Else
            Label8.Hide()
        End If


    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        TextBox3.Text = StrConv(TextBox3.Text, vbProperCase)
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            Label9.Show()
        Else
            Label9.Hide()
        End If

    End Sub

    Private Sub AdminMainPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AdminPanel.Show()
        Me.Close()
    End Sub

    Private Sub mname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mname.LostFocus
        mname.Text = StrConv(mname.Text, vbProperCase)
    End Sub


    Private Sub mname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mname.TextChanged
        If mname.Text = "" Then
            Labelmname.Show()
        Else
            Labelmname.Hide()
        End If
    End Sub

    Private Sub address_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles address.LostFocus
        address.Text = StrConv(address.Text, vbProperCase)
    End Sub

    'Private Sub birthday_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If DateTimePicker1.Text = "" Then
    '        Labelbday.Show()
    '    Else
    '        Labelbday.Hide()
    '    End If
    'End Sub

    Private Sub address_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles address.TextChanged
        If address.Text = "" Then
            Labeladd.Show()
        Else
            Labeladd.Hide()
        End If
    End Sub



    Private Sub updatebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updatebutton.Click
        If TextBox4.Text = "" Then
            MsgBox("Unable to Updated")

        Else
            ' always check your connection state first

            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()



            Try
                sqlup = "update user set idnum = @idnum, fname= @fname, mname= @mname, lname = @lname, status =@status, appointment= @appointment,  birthday= @birthday,address= @address, gender=@gender where id =@id"
                sql_command = New MySqlClient.MySqlCommand(sqlup, sql_connection)

                '  sql_command.Parameters.AddWithValue("@fpt", Template.Bytes)
                sql_command.Parameters.AddWithValue("@idnum", TextBox1.Text)
                sql_command.Parameters.AddWithValue("@fname", TextBox2.Text)
                sql_command.Parameters.AddWithValue("@mname", mname.Text)
                sql_command.Parameters.AddWithValue("@lname", TextBox3.Text)
                sql_command.Parameters.AddWithValue("@status", ComboBox1.Text)
                sql_command.Parameters.AddWithValue("@appointment", ComboBox2.Text)
                sql_command.Parameters.AddWithValue("@birthday", DateTimePicker1.Text)
                sql_command.Parameters.AddWithValue("@address", address.Text)
                sql_command.Parameters.AddWithValue("@gender", ComboBox3.Text)


                sql_command.Parameters.AddWithValue("@id", TextBox4.Text)

                sql_command.ExecuteNonQuery()

                'idnum = TextBox1.Text + (".fpt")

                'Using fs As IO.FileStream = IO.File.Open(imagepath & idnum, IO.FileMode.Create, IO.FileAccess.Write)

                '    Template.Serialize(fs)

                'End Using


            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try



            Labelok.Text = "Successfully Update"
            sapi = CreateObject("SAPI.spvoice")
            sapi.Speak(Labelok.Text)



            search.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            mname.Text = ""
            TextBox3.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            DateTimePicker1.Text = ""
            address.Text = ""
            ComboBox3.Text = ""

            TextBox4.Text = ""


            Label7.Text = ""
            Label8.Text = ""
            Labelmname.Text = ""
            Label9.Text = ""
            Label10.Text = ""
            Label11.Text = ""
            Labelbday.Text = ""
            Labeladd.Text = ""
            Labelgender.Text = ""

            sql_connection.Close()

        End If


    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "" Then
            Labelgender.Show()
        Else
            Labelgender.Hide()
        End If

    End Sub


    Private Sub IndividualRecordsToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndividualRecordsToolStripMenuItem1.Click
        dtr.Show()
        Me.Hide()

    End Sub

    Private Sub PayrollToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayrollToolStripMenuItem.Click
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

    Private Sub ListOfEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfEmployeeToolStripMenuItem.Click
        Employee.Show()
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ''''''''
        If TextBox1.Text > "" Then


            idnum = TextBox1.Text + (".fpt1")

            Using fs As IO.FileStream = IO.File.Open(imagepath & idnum, IO.FileMode.Create, IO.FileAccess.Write)

                Template.Serialize(fs)

            End Using
            TextBox1.Text = ""
            MessageBox.Show("successfully saved the 2nd fpt")
            Me.Close()
            AdminPanel.Show()

        Else
            MessageBox.Show("un-able to save")
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim open As New OpenFileDialog()
        open.Filter = "Fingerprint Template File (*.fpt)|*.fpt"
        If open.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Using fs As IO.FileStream = IO.File.OpenRead(open.FileName)
                Dim template As New DPFP.Template(fs)
                OnTemplate(template)
            End Using
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        If DateTimePicker1.Text = "" Then
            Labelbday.Show()
        Else
            Labelbday.Hide()
        End If
    End Sub

  
    Private Sub PaySlipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaySlipToolStripMenuItem.Click



        individual_payslip.Show()
        Me.Close()



    End Sub
End Class


