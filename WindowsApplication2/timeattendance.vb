
'*******************************************************************'
'CPSU Hinigaran Payrol System Using Biometric
'Programmer: Ronel B. Llarenas 
'*******************************************************************'


Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.IO
Imports System.Text


Public Class timeattendance

    Implements DPFP.Capture.EventHandler
    Public ctr As Integer = 0
    Private Capturer As DPFP.Capture.Capture
    Private Verificator As DPFP.Verification.Verification
    Public tplate As DPFP.Template
    Public folderpath As String
    'Dim emp As String
    'Dim recid As String
    ''' '''
    Dim sql_connection As MySqlClient.MySqlConnection
    Dim sql_command As MySqlClient.MySqlCommand
    Dim DR As MySqlClient.MySqlDataReader

    Dim sql As String
    'Dim sql1 As String
    'Dim sql2 As String
    'Dim aminup As String
    'Dim amoutup As String
    'Dim pminup As String
    'Dim emptyup As String

    'for adding timespan
    Dim first As DateTime
    Dim second As DateTime
    Dim alll As DateTime
    'Dim una As DateTime
    'Dim duwa As DateTime
    'Dim all As DateTime

    Dim value As String
    Dim gp As String
    Dim valuee As String
    'Dim gpp As String
    'Public amin As DateTime
    'Public dateeh As String
    'Public idnum As String

    'for getting file name of the fpt.
    Private Sub getid()
        Try

            Dim xeid As String = Nothing
            dim s as string = nothing
            Dim ii As Integer
            If Label1.InvokeRequired Then
                Me.Label1.Invoke(New MethodInvoker(AddressOf getid), New Object() {Text})
                Exit Sub
            End If

            'emp = ListBox1.Items(ctr).ToString()
            Me.Text = ListBox1.Items(ctr).ToString() 'ang gn  loop sa listbox as name of form.
            For ii = 1 To Len(Me.Text) ' more than 1 ang kwaun.
                s = Mid(Me.Text, ii, 1)

                If s = "." Then GoTo srch
                xeid = xeid & s

            Next
srch:
            idnumber.Text = xeid

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Protected Overridable Sub Process(ByVal Sample As DPFP.Sample)

        Try

SCAN_AGAIN:
            Process2(Sample)


            ' Process the sample and create a feature set for the enrollment purpose.
            Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification)

            ' Check quality of the sample and start verification if it's good
            If Not features Is Nothing Then

                ' Compare the feature set with our template
                Dim result As DPFP.Verification.Verification.Result = New DPFP.Verification.Verification.Result()

                Verificator.Verify(features, tplate, result)

                UpdateStatus(result.FARAchieved)
                If result.Verified Then
                    Call getid()

                    Me.ctr = 0
                    '  Me.ctr += 0 
                    Call Me.getFingerPrintSample()

                    MakeReport("VERIFIED.")

                Else

                    ' MakeReport("The fingerprint was NOT VERIFIED.")
                    Me.ctr += 1

                    Call Me.getFingerPrintSample()

                    If Me.ctr < Me.ListBox1.Items.Count Then
                        GoTo SCAN_AGAIN


                        ' ElseIf Me.ctr < Me.ListBox1.Items.Count Then
                        '  GoTo SCAN_AGAIN
                    Else

                        MakeReport("Unregistered user.")

                        Me.ctr = 0
                        Call Me.getFingerPrintSample()

                    End If

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'kung pila ang false rate sang features
    Protected Sub UpdateStatus(ByVal FAR As Integer)
        SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR))
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        sql_connection = New MySqlClient.MySqlConnection("Data Source=localhost;user id=root;password=NO;database=system;")
        Try
            sql_connection.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


        'select at retrieve regular rate, tax, job order rate, part time rate value from admin table.
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

        'every load of this form start capture
        StartCapture()

        Try
            Call getFingerPrintSample()
            Verificator = New DPFP.Verification.Verification()
            UpdateStatus(0)

            Capturer = New DPFP.Capture.Capture()                   ' Create a capture operation.

            If (Not Capturer Is Nothing) Then
                StatusText.Clear()
                Capturer.EventHandler = Me                              ' Subscribe for capturing events.



            Else
                SetPrompt("Can't initiate capture operation!")

            End If

            StartCapture()
        Catch ex As Exception
            MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        'idnumb.Hide()
        'fname.Hide()
        'mname.Hide()
        ''aminn.Hide()
        ''amout.Hide()
        ''amtotal.Hide()
        ''pmin.Hide()
        ''pmout.Hide()
        ''pmtotal.Hide()
        ''alltotal.Hide()
        ''datee.Hide()
        ''grosspay.Hide()
        ''nowday.Hide()
        ''rate.Hide()


        '  StatusText.Hide()
        ListBox1.Hide()
        idnumber.Hide()
        Label1.Hide()
        StatusLine.Hide()


        ''''
        datetext.Text = DateString
        nowdaytext.Text = Now.Day
        nowmonthtext.Text = Now.Month
        nowyeartext.Text = Now.Year


        idnumb.Hide()
        fname.Hide()
        lname.Hide()
        status.Hide()
        appointment.Hide()
        aminn.Hide()
        amout.Hide()
        amtotal.Hide()
        pmin.Hide()
        pmout.Hide()
        pmtotal.Hide()
        alltotal.Hide()
        datee.Hide()
        grosspay.Hide()
        rate.Hide()
        jorate.Hide()
        ptrate.Hide()

        datetext.Hide()
        nowdaytext.Hide()
        nowmonthtext.Hide()
        nowyeartext.Hide()
        halfmonth.Hide()
        tax.Hide()
        madeduct.Hide()
        debit.Hide()
        useridnum.Hide()
        userfname.Hide()
        userlname.Hide()
        userappoint.Hide()
        TextBox2.Hide()
        textboxveri.Hide()


    End Sub

    Protected Sub SetStatus(ByVal status)
        Invoke(New FunctionCall(AddressOf _SetStatus), status)
    End Sub

    Private Sub _SetStatus(ByVal status)
        StatusLine.Text = status
    End Sub

    Protected Sub SetPrompt(ByVal text)
        Invoke(New FunctionCall(AddressOf _SetPrompt), text)
    End Sub

    Private Sub _SetPrompt(ByVal text)
        Prompt.Text = text
    End Sub
    Protected Sub MakeReport2(ByVal status)
        Invoke(New FunctionCall(AddressOf _MakeReport2), status)
    End Sub

    Private Sub _MakeReport2(ByVal status)
        ' TextBox2.AppendText(status + Chr(13) + Chr(10))

    End Sub

    Protected Sub MakeReport(ByVal status)
        Invoke(New FunctionCall(AddressOf _MakeReport), status)
    End Sub

    Private Sub _MakeReport(ByVal status)
        StatusText.AppendText(status + Chr(13) + Chr(10))

    End Sub
    Protected Sub MakeReport3(ByVal status)
        Invoke(New FunctionCall(AddressOf _MakeReport3), status)
    End Sub

    Private Sub _MakeReport3(ByVal status)
        ' TextBox2.AppendText(status + Chr(13) + Chr(10))
    End Sub
    Protected Sub DrawPicture(ByVal bmp)
        Invoke(New FunctionCall(AddressOf _DrawPicture), bmp)
    End Sub

    Private Sub _DrawPicture(ByVal bmp)
        Picture.Image = New Bitmap(bmp, Picture.Size)
    End Sub

    Private Sub Process2(ByVal Sample As DPFP.Sample)
        DrawPicture(ConvertSampleToBitmap(Sample))
    End Sub

    Protected Function ConvertSampleToBitmap(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertor As New DPFP.Capture.SampleConversion()    ' Create a sample convertor.
        Dim bitmap As Bitmap = Nothing                          ' TODO: the size doesn't matter
        convertor.ConvertToPicture(Sample, bitmap)              ' TODO: return bitmap as a result
        Return bitmap
    End Function

    Protected Function ExtractFeatures(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet

        Dim extractor As New DPFP.Processing.FeatureExtraction()        ' Create a feature extractor
        Dim feedback As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim features As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(Sample, Purpose, feedback, features) ' TODO: return features as a result?
        If (feedback = DPFP.Capture.CaptureFeedback.Good) Then
            Return features
        Else
            Return Nothing
        End If
    End Function


    Protected Sub StartCapture()
        If (Not Capturer Is Nothing) Then
            Try

                Capturer.StartCapture()

                SetPrompt("Using the fingerprint reader, scan your fingerprint.")
            Catch ex As Exception
                SetPrompt("Can't initiate capture!")
            End Try
        End If

    End Sub

    Protected Sub StopCapture()

        If (Not Capturer Is Nothing) Then
            Try
                Capturer.StopCapture()
            Catch ex As Exception
                SetPrompt("Can't terminate capture!")
            End Try
        End If
    End Sub


    Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        Process(Sample)
    End Sub

    Sub OnFingerGone(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone
        'MakeReport("The finger was removed from the fingerprint reader.")
    End Sub

    Sub OnFingerTouch(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch
        'MakeReport("The fingerprint reader was touched.")
    End Sub

    Sub OnReaderConnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect

        MakeReport("The fingerprint reader is connected.")
    End Sub

    Sub OnReaderDisconnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect
        MakeReport("The fingerprint reader is not connected.")
        MakeReport2("The fingerprint reader is not connected.")
    End Sub

    Sub OnSampleQuality(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal CaptureFeedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality
        If CaptureFeedback = DPFP.Capture.CaptureFeedback.Good Then
            MakeReport("The quality of the fingerprint sample is good.")
        Else
            MakeReport("The quality of the fingerprint sample is poor.")
        End If
    End Sub


    Public Sub getFingerPrintSample()

        Try

            Dim di As New IO.DirectoryInfo(Application.StartupPath & "\")
            Dim dra As IO.FileInfo
            Dim diar1 As IO.FileInfo() = di.GetFiles("*.fpt")

            folderpath = di.FullName.ToString

            If ListBox1.InvokeRequired Then
                Me.ListBox1.Invoke(New MethodInvoker(AddressOf getFingerPrintSample), New Object() {Text})

                Exit Sub
            End If

            Me.ListBox1.Items.Clear()

            For Each dra In diar1
                Me.ListBox1.Items.Add(dra)
            Next


            ' 
            Using fs As IO.FileStream = IO.File.OpenRead(ListBox1.Items(ctr).ToString())
                Dim template As New DPFP.Template(fs)
                Me.tplate = template

            End Using


        Catch ex As Exception

            '  MsgBox("ew")
        End Try

    End Sub
    Private Sub OnTemplate(ByVal template)
        Invoke(New FunctionCall(AddressOf _OnTemplate), template)
    End Sub

    Private Sub _OnTemplate(ByVal template)
        ' me.tplate is template
        Me.tplate = template

    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        timelabel.Text = (TimeString)
        Label2.Text = "Date: " + DateString
        

        'show in textbox 1 if it is lof in time or log out time or cannot operate attendance.
        If timelabel.Text > "07:00:00" And timelabel.Text < "11:30:00" Then
            TextBox1.Text = "Morning Log-In Time!"
        ElseIf timelabel.Text > "11:29:59" And timelabel.Text < "12:00:00" Then

            TextBox1.Text = "Morning Log-Out Time!"

        ElseIf timelabel.Text > "11:59:59" And timelabel.Text < "17:30:00" Then
            TextBox1.Text = "Afternoon Log-In Time!"
        ElseIf timelabel.Text > "17:29:59" Then
            TextBox1.Text = "Afternoon Log-Out Time!"


        Else
            TextBox1.Text = "Cannot Operate Attendance"
        End If

    End Sub





    'search all  user info from user or employee table
    Public Sub search_user()
        ' always check your connection state first
        If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()
        Try
            sql = "SELECT * from user where idnum like '%" & idnumber.Text & "%'   "

            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
            DR = sql_command.ExecuteReader()
            Do While DR.Read = True

                'get on ly info na kinanglanon para sa attendance now
                useridnum.Text = Format(DR("idnum"))
                userfname.Text = Format(DR("fname"))
                '  mname.Text = Format(DR("mname"))
                userlname.Text = Format(DR("lname"))
                ' status.Text = Format(DR("status"))
                userappoint.Text = Format(DR("appointment"))
                TextBox2.Text = Format(DR("veri"))

                ''''''''''''''''''''

                'aminn.Text = Format(DR("amin"))
                'amout.Text = Format(DR("amout"))
                'amtotal.Text = Format(DR("amtotal"))

                'pmin.Text = Format(DR("pmin"))
                'pmout.Text = Format(DR("pmout"))
                'pmtotal.Text = Format(DR("pmtotal"))

                'alltotal.Text = Format(DR("alltotal"))
                'datee.Text = Format(DR("date"))
                'grosspay.Text = Format(DR("gp"))
                'nowday.Text = Format(DR("nowday"))

            Loop
            DR.Close()

            sql_command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub




    'para sa search sang record subong nga adlaw kung may ara kna record
    Public Sub search_dtr()
        ' always check your connection state first
        If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

        Try
            sql = "SELECT * from dtr where idnum like '%" & idnumber.Text & "%'  And  date like '%" & datetext.Text & "%'  "

            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
            DR = sql_command.ExecuteReader()
            Do While DR.Read = True

                idnumb.Text = Format(DR("idnum"))

                fname.Text = Format(DR("fname"))

                lname.Text = Format(DR("lname"))

                appointment.Text = Format(DR("appointment"))


                ''''''''''''''''''''

                aminn.Text = Format(DR("amin"))
                amout.Text = Format(DR("amout"))
                amtotal.Text = Format(DR("amtotal"))

                pmin.Text = Format(DR("pmin"))
                pmout.Text = Format(DR("pmout"))
                pmtotal.Text = Format(DR("pmtotal"))

                alltotal.Text = Format(DR("alltotal"))
                datee.Text = Format(DR("date"))
                grosspay.Text = Format(DR("gp"))

                '  nowday.Text = Format(DR("nowday"))

            Loop
            DR.Close()

            sql_command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub


    'insert record to dtr table kung wala kapa record today.
    Public Sub insert_dtr()

        'if day of month is 1 to 15 put a else 16 above put b.
        Dim valx As Integer
        valx = (Val(nowdaytext.Text))

        If Val(nowdaytext.Text.Trim) < "16" Then
            halfmonth.Text = "a"
        Else
            halfmonth.Text = "b"

        End If

        'always check coonnection
        If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()
        Try

            sql = "INSERT INTO dtr(id, idnum, fname,  lname, appointment,amin,amout,amtotal,pmin,pmout,pmtotal,alltotal,gp, date,nowday, nowmonth,nowyear, halfmonth) VALUES(@id, @idnum, @fname,  @lname,  @appointment,@amin,@amout,@amtotal,@pmin,@pmout,@pmtotal,@alltotal,@gp, @date, @nowday, @nowmonth, @nowyear, @halfmonth)"
            sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
            sql_command.Parameters.AddWithValue("@id", Nothing)

            sql_command.Parameters.AddWithValue("@idnum", useridnum.Text)
            sql_command.Parameters.AddWithValue("@fname", userfname.Text)
            sql_command.Parameters.AddWithValue("@lname", userlname.Text)
            sql_command.Parameters.AddWithValue("@appointment", userappoint.Text)
            sql_command.Parameters.AddWithValue("@amin", vbNullChar)
            sql_command.Parameters.AddWithValue("@amout", vbNullChar)
            sql_command.Parameters.AddWithValue("@amtotal", vbNullChar)
            sql_command.Parameters.AddWithValue("@pmin", vbNullChar)
            sql_command.Parameters.AddWithValue("@pmout", vbNullChar)
            sql_command.Parameters.AddWithValue("@pmtotal", vbNullChar)
            sql_command.Parameters.AddWithValue("@alltotal", "00:00:00")
            sql_command.Parameters.AddWithValue("@gp", vbNullChar)

            sql_command.Parameters.AddWithValue("@date", datetext.Text)

            sql_command.Parameters.AddWithValue("@nowday", nowdaytext.Text)
            sql_command.Parameters.AddWithValue("@nowmonth", nowmonthtext.Text)
            sql_command.Parameters.AddWithValue("@nowyear", nowyeartext.Text)
            sql_command.Parameters.AddWithValue("@halfmonth", halfmonth.Text)

            sql_command.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

    End Sub



    'attendance for regular employee.
    Public Sub attendance()

        'If idnumb.Text = "" Then
        '    notif.Text = "Employee Not Found"
        'End If

        'if am and pm wla time
        If aminn.Text = "" And amout.Text = "" And pmin.Text = "" And pmout.Text = "" And timelabel.Text > "07:00:00" And timelabel.Text < "11:30:00" Then

            'amintext put time and pm total put default "0:0" for later adding total of morning and afternoon.
            aminn.Text = (TimeString)
            pmtotal.Text = "0:0"

            ' always check your connection state first
            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()
            'then update or make your account today in attendance table
            Try
                sql = "Update dtr set amin = '" + aminn.Text + "',   pmtotal = '" + pmtotal.Text + "' where idnum = '" + idnumb.Text + "' and date = '" + datee.Text + "' "
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
                sql_command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            notif.Text = lname.Text & ", You are logged-in: " + TimeString
            'idnumb.Text = ""
            '' idnumber.Text = ""
            StopCapture()
            notifi.Show()
            Me.Close()



            'else kung ang amin in wla time or wla siya ka log in pero log out time na sa aga.
        ElseIf aminn.Text = "" And amout.Text = "" And pmin.Text = "" And pmout.Text = "" And timelabel.Text > "11:29:59" And timelabel.Text < "12:00:00" Then
            'put amout time sa amout textbox
            amout.Text = (TimeString)
            '  datee.Text = (DateString)

            ' always check your connection state first.
            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()
            'put or update your log out time.
            Try
                sql = "Update dtr set amout = '" + amout.Text + "'   where idnum = '" + idnumb.Text + "' and date = '" + datee.Text + "' "
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
                sql_command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            notif.Text = lname.Text & ", You are logged-out: " + TimeString
            ' SAPI = CreateObject("SAPI.spvoice")
            ' SAPI.Speak(notif.Text)
            '  idnumb.Text = ""
            ' idnumber.Text = ""
            StopCapture()
            notifi.Show()
            Me.Close()

            'kung naka log in sa aga kag log out time na
        ElseIf aminn.Text > "" And amout.Text = "" And pmin.Text = "" And pmout.Text = "" And timelabel.Text < "12:00:00" Then
            'butang time sa amo out nga txtbox
            amout.Text = (TimeString)

            'then amo out nga time minus am in nga time, put sa amtotal
            Dim ts As TimeSpan = (Convert.ToDateTime(amout.Text).Subtract(Convert.ToDateTime(aminn.Text))).Duration()
            amtotal.Text = [String].Format("{0}:{1}", ts.Hours, ts.Minutes)

            'kung more than 4 hours subong nga aga the make it 4 lang 
            If amtotal.Text > "4:0" Then
                amtotal.Text = "4:0"
            Else
            End If


            'alltotal,  total this morning plus total sang hapon
            first = DateTime.Parse(amtotal.Text)
            second = DateTime.Parse(pmtotal.Text)
            alll = first.Add(second.TimeOfDay)
            alltotal.Text = (alll.TimeOfDay.ToString()) 'total of all rendered hours

            value = CDbl(CDate(alltotal.Text).ToOADate()) * 24 'total hours to decimal

            gp = value * rate.Text 'total hours na decimal * rate per hour ''
            grosspay.Text = gp

            ' grosspay time percent of tax, amu na ang madeduct 
            madeduct.Text = grosspay.Text * tax.Text

            'ang grosspay minusan mo sang madeduct nga percent sa iya grosspay, amu na debit ya.
            debit.Text = grosspay.Text - madeduct.Text


            ' always check your connection state first.
            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

            Try
                sql = "Update dtr set amout = '" + amout.Text + "', amtotal = '" + amtotal.Text + "', alltotal = '" + alltotal.Text + "', gp = '" + grosspay.Text + "', madeduct = '" + madeduct.Text + "', debit = '" + debit.Text + "'  where idnum = '" + idnumb.Text + "' and date = '" + datee.Text + "' "

                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
                sql_command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub

            End Try

            notif.Text = lname.Text & ", You are logged-out: " + TimeString
            StopCapture()
            notifi.Show()
            Me.Close()

            '  If pm Then wla ka in and out 
        ElseIf pmin.Text = "" And pmout.Text = "" And timelabel.Text > "11:59:59" And timelabel.Text < "17:29:59" Then
            pmin.Text = (TimeString)
            '  datee.Text = (DateString)

            'kung wla unod ang am total  put "0:0"
            If amtotal.Text = "" Then
                amtotal.Text = "0:0"
            Else
            End If


            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()
            Try

                sql = "Update dtr set pmin = '" + pmin.Text + "',   amtotal = '" + amtotal.Text + "' where idnum = '" + idnumb.Text + "' and date = '" + datee.Text + "' "

                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

                sql_command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            notif.Text = lname.Text & ", You are logged-In: " + TimeString

            StopCapture()
            notifi.Show()

            Me.Close()

            'kung wla sya ka in sa hapon kag log out time na
        ElseIf pmin.Text = "" And pmout.Text = "" And timelabel.Text > "17:29:59" Then

            'pmout
            pmout.Text = (TimeString)
            ' datee.Text = (DateString)

            ' always check your connection state first.
            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

            Try

                sql = "Update dtr set pmout = '" + pmout.Text + "'   where idnum = '" + idnumb.Text + "' and date = '" + datee.Text + "' "

                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)


                sql_command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub

            End Try

            notif.Text = lname.Text & ", You are logged-out: " + TimeString
            ' SAPI = CreateObject("SAPI.spvoice")
            '
            ' SAPI.Speak(notif.Text)
            '  idnumb.Text = ""
            ' idnumber.Text = ""
            StopCapture()
            notifi.Show()
            Me.Close()

            'kung ka in sya kag log out time na.
        ElseIf pmin.Text > "" And pmout.Text = "" And timelabel.Text > "11:59:59" Then

            pmout.Text = (TimeString)

            'pmin minus pmout
            Dim ts As TimeSpan = (Convert.ToDateTime(pmout.Text).Subtract(Convert.ToDateTime(pmin.Text))).Duration()
            pmtotal.Text = [String].Format("{0}:{1}", ts.Hours, ts.Minutes)

            If pmtotal.Text > "4:0" Then
                pmtotal.Text = "4:0"
            Else

            End If


            'alltotal, am total plus pm total.
            first = DateTime.Parse(amtotal.Text)
            second = DateTime.Parse(pmtotal.Text)
            alll = first.Add(second.TimeOfDay)
            alltotal.Text = (alll.TimeOfDay.ToString()) 'total of all rendered hours

            value = CDbl(CDate(alltotal.Text).ToOADate()) * 24 'total hours to decimal

            gp = value * rate.Text 'total hours na decimal * rate per hour ''
            grosspay.Text = gp

            '
            madeduct.Text = grosspay.Text * tax.Text

            debit.Text = grosspay.Text - madeduct.Text


            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

            Try
                'pm out attendance
                sql = "Update dtr set pmout = '" + pmout.Text + "', pmtotal = '" + pmtotal.Text + "',     alltotal = '" + alltotal.Text + "', gp = '" + grosspay.Text + "', madeduct = '" + madeduct.Text + "', debit = '" + debit.Text + "' where idnum = '" + idnumb.Text + "' and date = '" + datee.Text + "' "
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
                sql_command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub

            End Try

            notif.Text = lname.Text & ", You are logged-out: " + TimeString
            StopCapture()
            notifi.Show()
            Me.Close()

        ElseIf timelabel.Text < "07:00:01" Then
            notif.Text = "Cannot operate attendance, please wait for log in time!: " + TimeString
            StopCapture()
            notifi.Show()
            Me.Close()

        End If


    End Sub


    'job order attendance process
    Public Sub jo_attendance()

        ' kung wla pagd unod, then  between 7 and 8 sang aga, log in time
        If aminn.Text = "" And amout.Text = "" And pmin.Text = "" And pmout.Text = "" And timelabel.Text > "07:00:00" And timelabel.Text < "08:00:00" Then
            aminn.Text = (TimeString)
            ' datee.Text = (DateString)
            pmtotal.Text = "0:0"

            ' always check your connection state first
            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

            Try
                sql = "Update dtr set amin = '" + aminn.Text + "',   pmtotal = '" + pmtotal.Text + "' where idnum = '" + idnumb.Text + "' and date = '" + datee.Text + "' "

                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
                sql_command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            notif.Text = lname.Text & ", You are logged-in: " + TimeString
            'idnumb.Text = ""
            '' idnumber.Text = ""
            StopCapture()
            notifi.Show()
            Me.Close()

            'kung wla sya ka in sa aga pero log out time na between 12:1 and before 1
        ElseIf aminn.Text = "" And amout.Text = "" And pmin.Text = "" And pmout.Text = "" And timelabel.Text > "12:00:00" And timelabel.Text < "13:00:00" Then

            amout.Text = (TimeString)
            '  datee.Text = (DateString)

            ' always check your connection state first.
            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

            Try
                sql = "Update dtr set amout = '" + amout.Text + "'   where idnum = '" + idnumb.Text + "' and date = '" + datee.Text + "' "

                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
                sql_command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            notif.Text = lname.Text & ", You are logged-out: " + TimeString
            ' SAPI = CreateObject("SAPI.spvoice")
            ' SAPI.Speak(notif.Text)
            '  idnumb.Text = ""
            ' idnumber.Text = ""

            StopCapture()
            notifi.Show()
            Me.Close()

            'kung ka in sya sa aga kag am out na
        ElseIf aminn.Text > "" And amout.Text = "" And pmin.Text = "" And pmout.Text = "" And timelabel.Text > "12:00:00" And timelabel.Text < "13:00:00" Then

            amout.Text = (TimeString)

            'Dim ts As TimeSpan = (Convert.ToDateTime(amout.Text).Subtract(Convert.ToDateTime(aminn.Text))).Duration()
            'amtotal.Text = [String].Format("{0}:{1}", ts.Hours, ts.Minutes)
            'If amtotal.Text > "4:0" Then

            amtotal.Text = "4:0"
            'Else

            'End If
            'alltotal
            'first = DateTime.Parse(amtotal.Text)
            'second = DateTime.Parse(pmtotal.Text)
            'alll = first.Add(second.TimeOfDay)
            'alltotal.Text = (alll.TimeOfDay.ToString()) 'total of all rendered hours

            alltotal.Text = "4:0"

            'value = CDbl(CDate(alltotal.Text).ToOADate()) * 24 'total hours to decimal

            '   grosspay.Text = jorate.Text
            'jorate.text ara na ang view sa iya sang halfday rate sng job order

            madeduct.Text = jorate.Text * tax.Text
            debit.Text = jorate.Text - madeduct.Text

            ' always check your connection state first.
            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

            Try
                sql = "Update dtr set amout = '" + amout.Text + "', amtotal = '" + amtotal.Text + "', alltotal = '" + alltotal.Text + "', gp = '" + jorate.Text + "', madeduct = '" + madeduct.Text + "', debit = '" + debit.Text + "'  where idnum = '" + idnumb.Text + "' and date = '" + datee.Text + "' "

                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
                sql_command.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            notif.Text = lname.Text & ", You are logged-out: " + TimeString
            StopCapture()
            notifi.Show()

            Me.Close()


        ElseIf pmin.Text = "" And pmout.Text = "" And timelabel.Text > "12:00:00" And timelabel.Text < "13:00:00" Then
            pmin.Text = (TimeString)
            '  datee.Text = (DateString)
            If amtotal.Text = "" Then
                amtotal.Text = "0:0"

            Else
            End If


            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()
            Try
                sql = "Update dtr set pmin = '" + pmin.Text + "',   amtotal = '" + amtotal.Text + "' where idnum = '" + idnumb.Text + "' and date = '" + datee.Text + "' "

                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
                sql_command.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            notif.Text = lname.Text & ", You are logged-In: " + TimeString
            StopCapture()
            notifi.Show()

            Me.Close()

        ElseIf pmin.Text = "" And pmout.Text = "" And timelabel.Text > "17:00:00" Then


            'pmout
            pmout.Text = (TimeString)
            ' datee.Text = (DateString)

            ' always check your connection state first.
            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

            Try

                sql = "Update dtr set pmout = '" + pmout.Text + "'   where idnum = '" + idnumb.Text + "' and date = '" + datee.Text + "' "

                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)


                sql_command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub

            End Try

            notif.Text = lname.Text & ", You are logged-out: " + TimeString
            ' SAPI = CreateObject("SAPI.spvoice")
            '
            ' SAPI.Speak(notif.Text)

            '  idnumb.Text = ""
            ' idnumber.Text = ""

            StopCapture()
            notifi.Show()

            Me.Close()

        ElseIf pmin.Text > "" And pmout.Text = "" And timelabel.Text > "17:00:00" Then


            pmout.Text = (TimeString)



            'Dim ts As TimeSpan = (Convert.ToDateTime(pmout.Text).Subtract(Convert.ToDateTime(pmin.Text))).Duration()
            'pmtotal.Text = [String].Format("{0}:{1}", ts.Hours, ts.Minutes)

            'If pmtotal.Text > "4:0" Then

            pmtotal.Text = "4:0"
            'Else

            'End If


            'alltotal
            first = DateTime.Parse(amtotal.Text)
            second = DateTime.Parse(pmtotal.Text)

            alll = first.Add(second.TimeOfDay)
            alltotal.Text = (alll.TimeOfDay.ToString()) 'total of all rendered hours

            If alltotal.Text = "04:00:00" Then

                grosspay.Text = jorate.Text
            ElseIf alltotal.Text = "08:00:00" Then

                grosspay.Text = jorate.Text * 2
            End If

            madeduct.Text = grosspay.Text * tax.Text
            debit.Text = grosspay.Text - madeduct.Text
        


            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

            Try

                sql = "Update dtr set pmout = '" + pmout.Text + "', pmtotal = '" + pmtotal.Text + "',     alltotal = '" + alltotal.Text + "', gp = '" + grosspay.Text + "', madeduct = '" + madeduct.Text + "', debit = '" + debit.Text + "' where idnum = '" + idnumb.Text + "' and date = '" + datee.Text + "' "
                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

                sql_command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub

            End Try

            notif.Text = lname.Text & ", You are logged-out: " + TimeString
            StopCapture()
            notifi.Show()
            Me.Close()

        ElseIf timelabel.Text < "07:00:01" Then

            notif.Text = "Please Wait for the Log in time. "
            StopCapture()
            notifi.Show()
            Me.Close()


        ElseIf timelabel.Text > "07:59:59" And timelabel.Text < "12:00:01" Then

            notif.Text = "Job Order Cannot proccess this time. "
            StopCapture()
            notifi.Show()
            Me.Close()

        ElseIf timelabel.Text > "12:59:59" And timelabel.Text < "17:00:01" Then

            notif.Text = "Job Order Cannot proccess this time. "
            StopCapture()
            notifi.Show()
            Me.Close()
        End If

    End Sub







    Public Sub pt_attendance()
        'if time between 8  and 11:00
        If aminn.Text = "" And amout.Text = "" And pmin.Text = "" And pmout.Text = "" And timelabel.Text > "07:00:00" And timelabel.Text < "11:00:00" Then
            aminn.Text = (TimeString)
            pmtotal.Text = "0:0"

            ' always check your connection state first
            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

            Try

                sql = "Update dtr set amin = '" + aminn.Text + "',   pmtotal = '" + pmtotal.Text + "' where idnum = '" + idnumb.Text + "' and date = '" + datee.Text + "' "

                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

                sql_command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            notif.Text = lname.Text & ", You are logged-in: " + TimeString



            'idnumb.Text = ""
            '' idnumber.Text = ""

            StopCapture()
            notifi.Show()

            Me.Close()


            'lessthan 12, pwede ka out bian anu oras
        ElseIf aminn.Text > "" And amout.Text = "" And pmin.Text = "" And pmout.Text = "" And timelabel.Text < "12:00:00" Then

            amout.Text = (TimeString)

            Dim ts As TimeSpan = (Convert.ToDateTime(amout.Text).Subtract(Convert.ToDateTime(aminn.Text))).Duration()
            amtotal.Text = [String].Format("{0}:{1}", ts.Hours, ts.Minutes)

            If amtotal.Text > "4:0" Then

                amtotal.Text = "4:0"
            Else

            End If


            'alltotal
            first = DateTime.Parse(amtotal.Text)
            second = DateTime.Parse(pmtotal.Text)
            alll = first.Add(second.TimeOfDay)
            alltotal.Text = (alll.TimeOfDay.ToString()) 'total of all rendered hours

            value = CDbl(CDate(alltotal.Text).ToOADate()) * 24 'total hours to decimal


            gp = value * ptrate.Text 'total hours na decimal * rate per hour ''
            grosspay.Text = gp

            madeduct.Text = grosspay.Text * tax.Text

            debit.Text = grosspay.Text - madeduct.Text


            '  grosspay.Text -


            ' always check your connection state first.
            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

            Try

                sql = "Update dtr set amout = '" + amout.Text + "', amtotal = '" + amtotal.Text + "', alltotal = '" + alltotal.Text + "', gp = '" + grosspay.Text + "', madeduct = '" + madeduct.Text + "', debit = '" + debit.Text + "'  where idnum = '" + idnumb.Text + "' and date = '" + datee.Text + "' "

                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

                sql_command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub

            End Try

            notif.Text = lname.Text & ", You are logged-out: " + TimeString

            StopCapture()
            notifi.Show()

            Me.Close()


            ' If greater then 12 oclock
        ElseIf pmin.Text = "" And pmout.Text = "" And timelabel.Text > "12:00:00" Then
            pmin.Text = (TimeString)
            '  datee.Text = (DateString)


            If amtotal.Text = "" Then
                amtotal.Text = "0:0"

            Else
            End If


            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()
            Try


                sql = "Update dtr set pmin = '" + pmin.Text + "',   amtotal = '" + amtotal.Text + "' where idnum = '" + idnumb.Text + "' and date = '" + datee.Text + "' "

                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)

                sql_command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try


            notif.Text = lname.Text & ", You are logged-In: " + TimeString


            StopCapture()
            notifi.Show()

            Me.Close()


            'ElseIf pmin.Text = "" And pmout.Text = "" And timelabel.Text > "17:29:59" Then


            '    'pmout
            '    pmout.Text = (TimeString)
            '    ' datee.Text = (DateString)

            '    ' always check your connection state first.
            '    If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

            '    Try

            '        amoutup = "Update dtr set pmout = '" + pmout.Text + "'   where idnum = '" + idnumb.Text + "' and date = '" + datee.Text + "' "

            '        sql_command = New MySqlClient.MySqlCommand(amoutup, sql_connection)


            '        sql_command.ExecuteNonQuery()

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        Exit Sub

            '    End Try

            '    notif.Text = lname.Text & ", You are logged-out: " + TimeString
            '    ' SAPI = CreateObject("SAPI.spvoice")
            '    '
            '    ' SAPI.Speak(notif.Text)

            '    '  idnumb.Text = ""
            '    ' idnumber.Text = ""

            '    StopCapture()
            '    notifi.Show()

            '    Me.Close()

        ElseIf pmin.Text > "" And pmout.Text = "" And timelabel.Text > "12:00:00" Then

            pmout.Text = (TimeString)

            Dim ts As TimeSpan = (Convert.ToDateTime(pmout.Text).Subtract(Convert.ToDateTime(pmin.Text))).Duration()
            pmtotal.Text = [String].Format("{0}:{1}", ts.Hours, ts.Minutes)

            If pmtotal.Text > "4:0" Then

                pmtotal.Text = "4:0"
            Else

            End If


            'alltotal
            first = DateTime.Parse(amtotal.Text)
            second = DateTime.Parse(pmtotal.Text)
            alll = first.Add(second.TimeOfDay)
            alltotal.Text = (alll.TimeOfDay.ToString()) 'total of all rendered hours

            value = CDbl(CDate(alltotal.Text).ToOADate()) * 24 'total hours to decimal




            gp = value * ptrate.Text 'total hours na decimal * rate per hour ''
            grosspay.Text = gp

            '
            madeduct.Text = grosspay.Text * tax.Text

            debit.Text = grosspay.Text - madeduct.Text





            If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

            Try

                sql = "Update dtr set pmout = '" + pmout.Text + "', pmtotal = '" + pmtotal.Text + "',     alltotal = '" + alltotal.Text + "', gp = '" + grosspay.Text + "', madeduct = '" + madeduct.Text + "', debit = '" + debit.Text + "' where idnum = '" + idnumb.Text + "' and date = '" + datee.Text + "' "

                sql_command = New MySqlClient.MySqlCommand(sql, sql_connection)
                sql_command.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub

            End Try

            notif.Text = lname.Text & ", You are logged-out: " + TimeString
            StopCapture()
            notifi.Show()

            Me.Close()

        ElseIf timelabel.Text < "07:00:01" Then

            notif.Text = "Please Wait for the Log in time. "
            StopCapture()
            notifi.Show()
            Me.Close()

            End If
    End Sub



    '  Dim SAPI

    Private Sub idnumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idnumber.TextChanged

        Me.Refresh()
        ' idnumb.Text = ""

        search_user() 'search from employee table
        search_dtr() 'and search mn sa dtr table where id num ang date today

        If useridnum.Text > "" And TextBox2.Text = "veri" Then


            If datee.Text = "" Then ' if wala date it mmeans wala unod today

                insert_dtr() 'then insert profile for today
                search_dtr() 'search again where the id number and date

                ''''''''''' naggwa na ang gn search
                If appointment.Text = "Contractual" Then

                    attendance()

                ElseIf appointment.Text = "Job_Order" Then

                    jo_attendance()

                ElseIf appointment.Text = "Part_Time" Then
                    pt_attendance()


                End If
                '''''''''

            Else
                'else my unod na, nka attendance na sya gina.
                '''''''''''
                If appointment.Text = "Contractual" Then

                    attendance()

                ElseIf appointment.Text = "Job_Order" Then

                    jo_attendance()

                ElseIf appointment.Text = "Part_Time" Then
                    pt_attendance()

                End If
                ''
            End If


        Else
            MsgBox("you didn't confirm your account yet!")

            idnumber.Text = ""

        End If









        '    ''pmtotal
        '    'Dim ts2 As TimeSpan = (Convert.ToDateTime(pmout.Text).Subtract(Convert.ToDateTime(pmin.Text))).Duration()
        '    'pmtotal.Text = [String].Format("{0}:{1}", ts2.Hours, ts2.Minutes)


        '    'If pmtotal.Text > "4:0" Then

        '    '    pmtotal.Text = "4:0"
        '    'Else

        '    'End If





        '    '    'alltotal

        '    '    una = DateTime.Parse(amtotal.Text)
        '    '    duwa = DateTime.Parse(pmtotal.Text)
        '    '    all = una.Add(duwa.TimeOfDay)

        '    '    alltotal.Text = (all.TimeOfDay.ToString()) 'all total hours again

        '    '    'gp
        '    '    value = CDbl(CDate(alltotal.Text).ToOADate()) * 24 'total hours to decimal

        '    '    gp = value * rate.Text  '85.23 'toal hours nga decimal * rate per hour
        '    '    grosspay.Text = gp


        '    '    If idnum = idnumb.Text Then

        '    '    ElseIf alltotal.Text > "" Then

        '    '        ' always check your connection state first
        '    '        If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

        '    '        Try


        '    '            sql1 = "INSERT INTO alldtr(idnum, fname, mname, lname, status, appointment, amin, amout, amtotal, pmin, pmout, pmtotal, alltotal, gp, date, nowday) VALUES(@idnum, @fname, @mname, @lname, @status, @appointment, @amin, @amout, @amtotal, @pmin, @pmout, @pmtotal, @alltotal, @gp, @date, @nowday)"
        '    '            sql_command = New MySqlClient.MySqlCommand(sql1, sql_connection)

        '    '            sql_command.Parameters.AddWithValue("@idnum", idnumb.Text)
        '    '            sql_command.Parameters.AddWithValue("@fname", fname.Text)
        '    '            sql_command.Parameters.AddWithValue("@mname", mname.Text)
        '    '            sql_command.Parameters.AddWithValue("@lname", lname.Text)
        '    '            sql_command.Parameters.AddWithValue("@status", status.Text)
        '    '            sql_command.Parameters.AddWithValue("@appointment", appointment.Text)
        '    '            sql_command.Parameters.AddWithValue("@amin", aminn.Text)
        '    '            sql_command.Parameters.AddWithValue("@amout", amout.Text)
        '    '            sql_command.Parameters.AddWithValue("@amtotal", amtotal.Text)
        '    '            sql_command.Parameters.AddWithValue("@pmin", pmin.Text)
        '    '            sql_command.Parameters.AddWithValue("@pmout", pmout.Text)
        '    '            sql_command.Parameters.AddWithValue("@pmtotal", pmtotal.Text)
        '    '            sql_command.Parameters.AddWithValue("@alltotal", alltotal.Text)
        '    '            sql_command.Parameters.AddWithValue("@gp", grosspay.Text)
        '    '            sql_command.Parameters.AddWithValue("@date", datee.Text)
        '    '            sql_command.Parameters.AddWithValue("@nowday", nowday.Text)

        '    '            sql_command.ExecuteNonQuery()

        '    '        Catch ex As Exception
        '    '            MsgBox(ex.Message)
        '    '            Exit Sub

        '    '        End Try

        '    '        If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

        '    '        Try

        '    '            sql1 = "INSERT INTO permanentdtr(idnum, fname, mname, lname, status, appointment, amin, amout, amtotal, pmin, pmout, pmtotal, alltotal, gp, date, nowday) VALUES(@idnum, @fname, @mname, @lname, @status, @appointment, @amin, @amout, @amtotal, @pmin, @pmout, @pmtotal, @alltotal, @gp, @date, @nowday)"
        '    '            sql_command = New MySqlClient.MySqlCommand(sql1, sql_connection)

        '    '            sql_command.Parameters.AddWithValue("@idnum", idnumb.Text)
        '    '            sql_command.Parameters.AddWithValue("@fname", fname.Text)
        '    '            sql_command.Parameters.AddWithValue("@mname", mname.Text)
        '    '            sql_command.Parameters.AddWithValue("@lname", lname.Text)
        '    '            sql_command.Parameters.AddWithValue("@status", status.Text)
        '    '            sql_command.Parameters.AddWithValue("@appointment", appointment.Text)
        '    '            sql_command.Parameters.AddWithValue("@amin", aminn.Text)
        '    '            sql_command.Parameters.AddWithValue("@amout", amout.Text)
        '    '            sql_command.Parameters.AddWithValue("@amtotal", amtotal.Text)
        '    '            sql_command.Parameters.AddWithValue("@pmin", pmin.Text)
        '    '            sql_command.Parameters.AddWithValue("@pmout", pmout.Text)
        '    '            sql_command.Parameters.AddWithValue("@pmtotal", pmtotal.Text)
        '    '            sql_command.Parameters.AddWithValue("@alltotal", alltotal.Text)
        '    '            sql_command.Parameters.AddWithValue("@gp", grosspay.Text)
        '    '            sql_command.Parameters.AddWithValue("@date", datee.Text)
        '    '            sql_command.Parameters.AddWithValue("@nowday", nowday.Text)

        '    '            sql_command.ExecuteNonQuery()

        '    '        Catch ex As Exception
        '    '            MsgBox(ex.Message)
        '    '            Exit Sub

        '    '        End Try


        '    '        aminn.Text = ""
        '    '        amout.Text = ""
        '    '        amtotal.Text = ""
        '    '        pmin.Text = ""
        '    '        pmout.Text = ""
        '    '        pmtotal.Text = ""
        '    '        alltotal.Text = ""
        '    '        grosspay.Text = ""
        '    '        datee.Text = ""

        '    '        ' always check your connection state first

        '    '        If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()

        '    '        Try

        '    '            emptyup = "update user set amin = @amin, amout = @amout, amtotal= @amtotal, pmin = @pmin, pmout = @pmout, pmtotal= @pmtotal, alltotal = @alltotal, gp = @gp, date= @date where idnum =@idnum"
        '    '            sql_command = New MySqlClient.MySqlCommand(emptyup, sql_connection)

        '    '            sql_command.Parameters.AddWithValue("@amin", aminn.Text)
        '    '            sql_command.Parameters.AddWithValue("@amout", amout.Text)
        '    '            sql_command.Parameters.AddWithValue("@amtotal", amtotal.Text)
        '    '            sql_command.Parameters.AddWithValue("@pmin", pmin.Text)
        '    '            sql_command.Parameters.AddWithValue("@pmout", pmout.Text)
        '    '            sql_command.Parameters.AddWithValue("@pmtotal", pmtotal.Text)
        '    '            sql_command.Parameters.AddWithValue("@alltotal", alltotal.Text)
        '    '            sql_command.Parameters.AddWithValue("@gp", grosspay.Text)
        '    '            sql_command.Parameters.AddWithValue("@date", datee.Text)


        '    '            sql_command.Parameters.AddWithValue("@idnum", idnumb.Text)

        '    '            sql_command.ExecuteNonQuery()
        '    '        Catch ex As Exception
        '    '            MsgBox(ex.Message)
        '    '            Exit Sub

        '    '        End Try

        '    '        notif.Text = lname.Text & ", You are logged-out: " + TimeString
        '    '        ' SAPI = CreateObject("SAPI.spvoice")
        '    '        '
        '    '        ' SAPI.Speak(notif.Text)

        '    '        idnumb.Text = ""
        '    '        ' idnumber.Text = ""

        '    '        StopCapture()
        '    '        notifi.Show()

        '    '        Me.Close()

        '    '    Else
        '    '        notif.Text = "UnAble to Log-In or Log-Out"
        '    '        '  SAPI = CreateObject("SAPI.spvoice")
        '    '        '  SAPI.Speak(notif.Text)

        '    '    End If
        '    'End If
        'End If
    End Sub

    Private Sub AccountingOfficerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountingOfficerToolStripMenuItem.Click

        StopCapture()

        authentication.Show()

        Me.Close()

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        StopCapture()

        confirmation.Show()

        Me.Close()
    End Sub
End Class


