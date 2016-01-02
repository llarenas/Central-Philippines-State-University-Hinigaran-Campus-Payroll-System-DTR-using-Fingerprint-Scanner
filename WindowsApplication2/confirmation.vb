
Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.IO
Imports System.Text


Public Class confirmation
    Implements DPFP.Capture.EventHandler
    Public ctr As Integer = 0
    Private Capturer As DPFP.Capture.Capture
    Private Verificator As DPFP.Verification.Verification
    Public tplate As DPFP.Template
    Public folderpath As String

    Dim sql_connection As MySqlClient.MySqlConnection
    Dim sql_command As MySqlClient.MySqlCommand
    Dim DR As MySqlClient.MySqlDataReader

    Dim sql As String
    Dim sqlup As String


    Private Sub getid()
        Try

            Dim xeid As String = Nothing
            Dim s As String = Nothing
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


    Protected Sub UpdateStatus(ByVal FAR As Integer)
        SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR))
    End Sub




    Private Sub confirmation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql_connection = New MySqlClient.MySqlConnection("Data Source=localhost;user id=root;password=NO;database=system;")
        Try
            sql_connection.Open()
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

        TextBox1.Hide()
        StatusText.Hide()


        ListBox1.Hide()
        Label1.Hide()
        StatusLine.Hide()


        idnumber.Hide()
        useridnum.Hide()
        userfname.Hide()
        mname.Hide()
        userlname.Hide()
        userappoint.Hide()
        status.Hide()
        bday.Hide()
        address.Hide()
        gender.Hide()
        TextBox2.Hide()



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
                mname.Text = Format(DR("mname"))
                userlname.Text = Format(DR("lname"))
                status.Text = Format(DR("status"))
                userappoint.Text = Format(DR("appointment"))
                bday.Text = Format(DR("birthday"))
                address.Text = Format(DR("address"))
                gender.Text = Format(DR("gender"))
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




    Private Sub idnumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idnumber.TextChanged


        search_user()

        If TextBox6.Text = "" Then

            MsgBox("Please Fill Up all Fields in order to Register")
            idnumber.Text = ""
        ElseIf TextBox8.Text = "" Then

            MsgBox("Please Fill Up all Fields in order to Register")
            idnumber.Text = ""
        ElseIf TextBox5.Text = "" Then

            MsgBox("Please Fill Up all Fields in order to Register")
            idnumber.Text = ""
        ElseIf TextBox7.Text = "" Then



            MsgBox("Please Fill Up all Fields in order to Register")
            idnumber.Text = ""
        ElseIf ComboBox1.Text = "" Then

            MsgBox("Please Fill Up all Fields in order to Register")
            idnumber.Text = ""
        ElseIf ComboBox2.Text = "" Then

            MsgBox("Please Fill Up all Fields in order to Register")
            idnumber.Text = ""

        ElseIf DateTimePicker1.Text = "" Then
            MsgBox("Please Fill Up all Fields in order to Register")
            idnumber.Text = ""

        ElseIf address.Text = "" Then
            MsgBox("Please Fill Up all Fields in order to Register")
            idnumber.Text = ""

        ElseIf ComboBox3.Text = "" Then
            MsgBox("Please Fill Up all Fields in order to Register")
            idnumber.Text = ""
        Else



            If useridnum.Text = TextBox6.Text And userfname.Text = TextBox8.Text And mname.Text = TextBox5.Text And userlname.Text = TextBox7.Text And status.Text = ComboBox1.Text And userappoint.Text = ComboBox2.Text And bday.Text = DateTimePicker1.Text And address.Text = TextBox3.Text And gender.Text = ComboBox3.Text Then

                TextBox2.Text = "veri"


                If sql_connection.State <> ConnectionState.Open Then sql_connection.Open()



                Try
                    sqlup = "update user set veri = @veri where idnum =@idnum"
                    sql_command = New MySqlClient.MySqlCommand(sqlup, sql_connection)

                    '  sql_command.Parameters.AddWithValue("@fpt", Template.Bytes)
                    sql_command.Parameters.AddWithValue("@veri", TextBox2.Text)

                    sql_command.Parameters.AddWithValue("@idnum", idnumber.Text)

                    sql_command.ExecuteNonQuery()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Exit Sub
                End Try


                StopCapture()
                MsgBox("successfully confirmed account.")
                Me.Close()
                timeattendance.Show()

            Else
                MsgBox("your info doesnt match to the info that admin gave.")
                idnumber.Text = ""

            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        StopCapture()

        timeattendance.Show()

        Me.Close()
    End Sub

    Private Sub TextBox8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.LostFocus
        TextBox8.Text = StrConv(TextBox8.Text, vbProperCase)
    End Sub

    Private Sub TextBox5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.LostFocus
        TextBox5.Text = StrConv(TextBox5.Text, vbProperCase)
    End Sub

    Private Sub TextBox7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.LostFocus
        TextBox7.Text = StrConv(TextBox7.Text, vbProperCase)
    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        TextBox3.Text = StrConv(TextBox3.Text, vbProperCase)
    End Sub

  
End Class
































































