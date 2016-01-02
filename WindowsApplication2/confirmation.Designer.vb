<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class confirmation
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.prompt = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.idnumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusText = New System.Windows.Forms.TextBox()
        Me.StatusLine = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.userappoint = New System.Windows.Forms.TextBox()
        Me.userlname = New System.Windows.Forms.TextBox()
        Me.userfname = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.mname = New System.Windows.Forms.TextBox()
        Me.status = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.TextBox()
        Me.gender = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.useridnum = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.bday = New System.Windows.Forms.TextBox()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(415, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 20)
        Me.TextBox1.TabIndex = 224
        '
        'prompt
        '
        Me.prompt.AutoSize = True
        Me.prompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prompt.Location = New System.Drawing.Point(284, 74)
        Me.prompt.Name = "prompt"
        Me.prompt.Size = New System.Drawing.Size(0, 15)
        Me.prompt.TabIndex = 222
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'idnumber
        '
        Me.idnumber.Location = New System.Drawing.Point(156, 113)
        Me.idnumber.Name = "idnumber"
        Me.idnumber.Size = New System.Drawing.Size(72, 20)
        Me.idnumber.TabIndex = 188
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 187
        Me.Label1.Text = "Label1"
        '
        'StatusText
        '
        Me.StatusText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusText.BackColor = System.Drawing.Color.White
        Me.StatusText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusText.ForeColor = System.Drawing.Color.Black
        Me.StatusText.Location = New System.Drawing.Point(10, 70)
        Me.StatusText.Multiline = True
        Me.StatusText.Name = "StatusText"
        Me.StatusText.ReadOnly = True
        Me.StatusText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.StatusText.Size = New System.Drawing.Size(264, 37)
        Me.StatusText.TabIndex = 184
        '
        'StatusLine
        '
        Me.StatusLine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StatusLine.AutoSize = True
        Me.StatusLine.BackColor = System.Drawing.SystemColors.ControlText
        Me.StatusLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.StatusLine.Location = New System.Drawing.Point(76, 114)
        Me.StatusLine.Name = "StatusLine"
        Me.StatusLine.Size = New System.Drawing.Size(70, 15)
        Me.StatusLine.TabIndex = 185
        Me.StatusLine.Text = "[Status line]"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(659, 74)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(134, 225)
        Me.ListBox1.TabIndex = 186
        '
        'Picture
        '
        Me.Picture.BackColor = System.Drawing.Color.White
        Me.Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture.Location = New System.Drawing.Point(429, 138)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(213, 225)
        Me.Picture.TabIndex = 183
        Me.Picture.TabStop = False
        '
        'userappoint
        '
        Me.userappoint.Location = New System.Drawing.Point(36, 302)
        Me.userappoint.Name = "userappoint"
        Me.userappoint.Size = New System.Drawing.Size(68, 20)
        Me.userappoint.TabIndex = 228
        '
        'userlname
        '
        Me.userlname.Location = New System.Drawing.Point(30, 234)
        Me.userlname.Name = "userlname"
        Me.userlname.Size = New System.Drawing.Size(64, 20)
        Me.userlname.TabIndex = 226
        '
        'userfname
        '
        Me.userfname.Location = New System.Drawing.Point(36, 167)
        Me.userfname.Name = "userfname"
        Me.userfname.Size = New System.Drawing.Size(74, 20)
        Me.userfname.TabIndex = 225
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(561, 436)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(81, 20)
        Me.TextBox2.TabIndex = 229
        '
        'mname
        '
        Me.mname.Location = New System.Drawing.Point(33, 205)
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(71, 20)
        Me.mname.TabIndex = 230
        '
        'status
        '
        Me.status.Location = New System.Drawing.Point(30, 275)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(80, 20)
        Me.status.TabIndex = 231
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(36, 361)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(54, 20)
        Me.address.TabIndex = 233
        '
        'gender
        '
        Me.gender.Location = New System.Drawing.Point(30, 402)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(57, 20)
        Me.gender.TabIndex = 234
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(720, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 23)
        Me.Button1.TabIndex = 235
        Me.Button1.Text = "exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(593, 24)
        Me.Label2.TabIndex = 236
        Me.Label2.Text = "Put all your info in order to confirm your account that admin registered."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(243, 400)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 254
        Me.Label14.Text = "Gender:"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"", "Male", "Female"})
        Me.ComboBox3.Location = New System.Drawing.Point(312, 397)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(71, 21)
        Me.ComboBox3.TabIndex = 253
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(243, 364)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 252
        Me.Label13.Text = "Address:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(243, 335)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 251
        Me.Label15.Text = "Birthday:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(312, 364)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(96, 20)
        Me.TextBox3.TabIndex = 250
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(312, 205)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(96, 20)
        Me.TextBox5.TabIndex = 248
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(243, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 247
        Me.Label12.Text = "Middle name:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(312, 138)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(78, 20)
        Me.TextBox6.TabIndex = 237
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"", "Contractual", "Job_Order", "Part_Time"})
        Me.ComboBox2.Location = New System.Drawing.Point(312, 305)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(111, 21)
        Me.ComboBox2.TabIndex = 246
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"", "Single", "Married"})
        Me.ComboBox1.Location = New System.Drawing.Point(312, 278)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(96, 21)
        Me.ComboBox1.TabIndex = 245
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(243, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 244
        Me.Label5.Text = "Civil Status:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(243, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 243
        Me.Label4.Text = "Appointment:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(243, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 242
        Me.Label3.Text = "Last name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(243, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 241
        Me.Label6.Text = "First name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(249, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 240
        Me.Label7.Text = "ID number"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(312, 238)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(98, 20)
        Me.TextBox7.TabIndex = 239
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(312, 167)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(102, 20)
        Me.TextBox8.TabIndex = 238
        '
        'useridnum
        '
        Me.useridnum.Location = New System.Drawing.Point(33, 141)
        Me.useridnum.Name = "useridnum"
        Me.useridnum.Size = New System.Drawing.Size(63, 20)
        Me.useridnum.TabIndex = 227
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(312, 335)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(103, 20)
        Me.DateTimePicker1.TabIndex = 255
        '
        'bday
        '
        Me.bday.Location = New System.Drawing.Point(28, 332)
        Me.bday.Name = "bday"
        Me.bday.Size = New System.Drawing.Size(100, 20)
        Me.bday.TabIndex = 256
        '
        'confirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 468)
        Me.Controls.Add(Me.bday)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.mname)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.userappoint)
        Me.Controls.Add(Me.useridnum)
        Me.Controls.Add(Me.userlname)
        Me.Controls.Add(Me.userfname)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.prompt)
        Me.Controls.Add(Me.idnumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusText)
        Me.Controls.Add(Me.StatusLine)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Picture)
        Me.Name = "confirmation"
        Me.Text = "confirmation"
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents prompt As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents idnumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents StatusText As System.Windows.Forms.TextBox
    Private WithEvents StatusLine As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Picture As System.Windows.Forms.PictureBox
    Friend WithEvents userappoint As System.Windows.Forms.TextBox
    Friend WithEvents userlname As System.Windows.Forms.TextBox
    Friend WithEvents userfname As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents mname As System.Windows.Forms.TextBox
    Friend WithEvents status As System.Windows.Forms.TextBox
    Friend WithEvents address As System.Windows.Forms.TextBox
    Friend WithEvents gender As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents useridnum As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents bday As System.Windows.Forms.TextBox
End Class
