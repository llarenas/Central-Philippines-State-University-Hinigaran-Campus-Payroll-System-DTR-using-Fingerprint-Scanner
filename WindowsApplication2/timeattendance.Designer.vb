<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class timeattendance
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
        Me.StatusText = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.StatusLine = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idnumber = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grosspay = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.datee = New System.Windows.Forms.TextBox()
        Me.alltotal = New System.Windows.Forms.TextBox()
        Me.pmtotal = New System.Windows.Forms.TextBox()
        Me.pmout = New System.Windows.Forms.TextBox()
        Me.pmin = New System.Windows.Forms.TextBox()
        Me.amtotal = New System.Windows.Forms.TextBox()
        Me.amout = New System.Windows.Forms.TextBox()
        Me.aminn = New System.Windows.Forms.TextBox()
        Me.appointment = New System.Windows.Forms.TextBox()
        Me.status = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.idnumb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timelabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountingOfficerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.notif = New System.Windows.Forms.Label()
        Me.prompt = New System.Windows.Forms.Label()
        Me.rate = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.userfname = New System.Windows.Forms.TextBox()
        Me.userlname = New System.Windows.Forms.TextBox()
        Me.useridnum = New System.Windows.Forms.TextBox()
        Me.userappoint = New System.Windows.Forms.TextBox()
        Me.nowdaytext = New System.Windows.Forms.TextBox()
        Me.nowmonthtext = New System.Windows.Forms.TextBox()
        Me.datetext = New System.Windows.Forms.TextBox()
        Me.nowyeartext = New System.Windows.Forms.TextBox()
        Me.halfmonth = New System.Windows.Forms.TextBox()
        Me.tax = New System.Windows.Forms.TextBox()
        Me.madeduct = New System.Windows.Forms.TextBox()
        Me.debit = New System.Windows.Forms.TextBox()
        Me.jorate = New System.Windows.Forms.TextBox()
        Me.ptrate = New System.Windows.Forms.TextBox()
        Me.textboxveri = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusText
        '
        Me.StatusText.BackColor = System.Drawing.Color.White
        Me.StatusText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusText.ForeColor = System.Drawing.Color.Black
        Me.StatusText.Location = New System.Drawing.Point(12, 329)
        Me.StatusText.Multiline = True
        Me.StatusText.Name = "StatusText"
        Me.StatusText.ReadOnly = True
        Me.StatusText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.StatusText.Size = New System.Drawing.Size(320, 56)
        Me.StatusText.TabIndex = 62
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(640, 239)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(134, 225)
        Me.ListBox1.TabIndex = 65
        '
        'Picture
        '
        Me.Picture.BackColor = System.Drawing.Color.White
        Me.Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture.Location = New System.Drawing.Point(347, 239)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(213, 225)
        Me.Picture.TabIndex = 61
        Me.Picture.TabStop = False
        '
        'StatusLine
        '
        Me.StatusLine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StatusLine.AutoSize = True
        Me.StatusLine.BackColor = System.Drawing.SystemColors.ControlText
        Me.StatusLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.StatusLine.Location = New System.Drawing.Point(19, 407)
        Me.StatusLine.Name = "StatusLine"
        Me.StatusLine.Size = New System.Drawing.Size(70, 15)
        Me.StatusLine.TabIndex = 63
        Me.StatusLine.Text = "[Status line]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 449)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Label1"
        '
        'idnumber
        '
        Me.idnumber.Location = New System.Drawing.Point(105, 444)
        Me.idnumber.Name = "idnumber"
        Me.idnumber.Size = New System.Drawing.Size(100, 20)
        Me.idnumber.TabIndex = 68
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(605, 83)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(19, 13)
        Me.Label18.TabIndex = 154
        Me.Label18.Text = "gp"
        Me.Label18.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(540, 83)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 13)
        Me.Label17.TabIndex = 153
        Me.Label17.Text = "date"
        Me.Label17.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(185, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 145
        Me.Label9.Text = "appointment"
        Me.Label9.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(100, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "lname"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(144, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 144
        Me.Label8.Text = "status"
        Me.Label8.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 142
        Me.Label6.Text = "fname"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 141
        Me.Label5.Text = "idnum"
        Me.Label5.Visible = False
        '
        'grosspay
        '
        Me.grosspay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grosspay.Location = New System.Drawing.Point(596, 108)
        Me.grosspay.Name = "grosspay"
        Me.grosspay.Size = New System.Drawing.Size(49, 20)
        Me.grosspay.TabIndex = 140
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(383, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 18)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "Time:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(454, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 151
        Me.Label15.Text = "pmtotal"
        Me.Label15.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(409, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 13)
        Me.Label14.TabIndex = 150
        Me.Label14.Text = "pmout"
        Me.Label14.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(367, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 13)
        Me.Label13.TabIndex = 149
        Me.Label13.Text = "pmin"
        Me.Label13.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(497, 83)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 152
        Me.Label16.Text = "alltotal"
        Me.Label16.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(320, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 148
        Me.Label12.Text = "amtotal"
        Me.Label12.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(278, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "amout"
        Me.Label11.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(248, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 146
        Me.Label10.Text = "amin"
        Me.Label10.Visible = False
        '
        'datee
        '
        Me.datee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.datee.Location = New System.Drawing.Point(540, 108)
        Me.datee.Name = "datee"
        Me.datee.Size = New System.Drawing.Size(50, 20)
        Me.datee.TabIndex = 138
        '
        'alltotal
        '
        Me.alltotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.alltotal.Location = New System.Drawing.Point(495, 108)
        Me.alltotal.Name = "alltotal"
        Me.alltotal.Size = New System.Drawing.Size(39, 20)
        Me.alltotal.TabIndex = 137
        '
        'pmtotal
        '
        Me.pmtotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pmtotal.Location = New System.Drawing.Point(451, 108)
        Me.pmtotal.Name = "pmtotal"
        Me.pmtotal.Size = New System.Drawing.Size(38, 20)
        Me.pmtotal.TabIndex = 136
        '
        'pmout
        '
        Me.pmout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pmout.Location = New System.Drawing.Point(406, 108)
        Me.pmout.Name = "pmout"
        Me.pmout.Size = New System.Drawing.Size(39, 20)
        Me.pmout.TabIndex = 135
        '
        'pmin
        '
        Me.pmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pmin.Location = New System.Drawing.Point(364, 108)
        Me.pmin.Name = "pmin"
        Me.pmin.Size = New System.Drawing.Size(36, 20)
        Me.pmin.TabIndex = 134
        '
        'amtotal
        '
        Me.amtotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.amtotal.Location = New System.Drawing.Point(317, 108)
        Me.amtotal.Name = "amtotal"
        Me.amtotal.Size = New System.Drawing.Size(35, 20)
        Me.amtotal.TabIndex = 133
        '
        'amout
        '
        Me.amout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.amout.Location = New System.Drawing.Point(275, 108)
        Me.amout.Name = "amout"
        Me.amout.Size = New System.Drawing.Size(24, 20)
        Me.amout.TabIndex = 132
        '
        'aminn
        '
        Me.aminn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.aminn.Location = New System.Drawing.Point(245, 108)
        Me.aminn.Name = "aminn"
        Me.aminn.Size = New System.Drawing.Size(27, 20)
        Me.aminn.TabIndex = 131
        '
        'appointment
        '
        Me.appointment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.appointment.Location = New System.Drawing.Point(182, 108)
        Me.appointment.Name = "appointment"
        Me.appointment.Size = New System.Drawing.Size(41, 20)
        Me.appointment.TabIndex = 130
        '
        'status
        '
        Me.status.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.status.Location = New System.Drawing.Point(141, 108)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(35, 20)
        Me.status.TabIndex = 129
        '
        'lname
        '
        Me.lname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lname.Location = New System.Drawing.Point(105, 108)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(30, 20)
        Me.lname.TabIndex = 128
        '
        'fname
        '
        Me.fname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fname.Location = New System.Drawing.Point(57, 108)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(29, 20)
        Me.fname.TabIndex = 127
        '
        'idnumb
        '
        Me.idnumb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.idnumb.Location = New System.Drawing.Point(11, 108)
        Me.idnumb.Name = "idnumb"
        Me.idnumb.Size = New System.Drawing.Size(40, 20)
        Me.idnumb.TabIndex = 126
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(176, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(2, 18)
        Me.Label2.TabIndex = 122
        '
        'timelabel
        '
        Me.timelabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timelabel.AutoSize = True
        Me.timelabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.timelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timelabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.timelabel.Location = New System.Drawing.Point(449, 42)
        Me.timelabel.Name = "timelabel"
        Me.timelabel.Size = New System.Drawing.Size(2, 18)
        Me.timelabel.TabIndex = 121
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministratorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(798, 30)
        Me.MenuStrip1.TabIndex = 155
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministratorToolStripMenuItem
        '
        Me.AdministratorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AdministratorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountingOfficerToolStripMenuItem})
        Me.AdministratorToolStripMenuItem.Font = New System.Drawing.Font("Vrinda", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministratorToolStripMenuItem.Name = "AdministratorToolStripMenuItem"
        Me.AdministratorToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.AdministratorToolStripMenuItem.Text = "Administrator"
        '
        'AccountingOfficerToolStripMenuItem
        '
        Me.AccountingOfficerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AccountingOfficerToolStripMenuItem.Name = "AccountingOfficerToolStripMenuItem"
        Me.AccountingOfficerToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.AccountingOfficerToolStripMenuItem.Text = "Accounting Officer"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'notif
        '
        Me.notif.AutoSize = True
        Me.notif.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notif.Location = New System.Drawing.Point(560, 197)
        Me.notif.Name = "notif"
        Me.notif.Size = New System.Drawing.Size(0, 24)
        Me.notif.TabIndex = 157
        '
        'prompt
        '
        Me.prompt.AutoSize = True
        Me.prompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prompt.Location = New System.Drawing.Point(277, 149)
        Me.prompt.Name = "prompt"
        Me.prompt.Size = New System.Drawing.Size(0, 15)
        Me.prompt.TabIndex = 158
        '
        'rate
        '
        Me.rate.Location = New System.Drawing.Point(651, 108)
        Me.rate.Name = "rate"
        Me.rate.Size = New System.Drawing.Size(32, 20)
        Me.rate.TabIndex = 159
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(326, 197)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 20)
        Me.TextBox1.TabIndex = 165
        '
        'userfname
        '
        Me.userfname.Location = New System.Drawing.Point(80, 202)
        Me.userfname.Name = "userfname"
        Me.userfname.Size = New System.Drawing.Size(74, 20)
        Me.userfname.TabIndex = 166
        '
        'userlname
        '
        Me.userlname.Location = New System.Drawing.Point(160, 202)
        Me.userlname.Name = "userlname"
        Me.userlname.Size = New System.Drawing.Size(64, 20)
        Me.userlname.TabIndex = 167
        '
        'useridnum
        '
        Me.useridnum.Location = New System.Drawing.Point(5, 202)
        Me.useridnum.Name = "useridnum"
        Me.useridnum.Size = New System.Drawing.Size(63, 20)
        Me.useridnum.TabIndex = 168
        '
        'userappoint
        '
        Me.userappoint.Location = New System.Drawing.Point(233, 202)
        Me.userappoint.Name = "userappoint"
        Me.userappoint.Size = New System.Drawing.Size(54, 20)
        Me.userappoint.TabIndex = 169
        '
        'nowdaytext
        '
        Me.nowdaytext.Location = New System.Drawing.Point(540, 150)
        Me.nowdaytext.Name = "nowdaytext"
        Me.nowdaytext.Size = New System.Drawing.Size(39, 20)
        Me.nowdaytext.TabIndex = 171
        '
        'nowmonthtext
        '
        Me.nowmonthtext.Location = New System.Drawing.Point(585, 149)
        Me.nowmonthtext.Name = "nowmonthtext"
        Me.nowmonthtext.Size = New System.Drawing.Size(39, 20)
        Me.nowmonthtext.TabIndex = 172
        '
        'datetext
        '
        Me.datetext.Location = New System.Drawing.Point(474, 149)
        Me.datetext.Name = "datetext"
        Me.datetext.Size = New System.Drawing.Size(60, 20)
        Me.datetext.TabIndex = 170
        '
        'nowyeartext
        '
        Me.nowyeartext.Location = New System.Drawing.Point(631, 149)
        Me.nowyeartext.Name = "nowyeartext"
        Me.nowyeartext.Size = New System.Drawing.Size(52, 20)
        Me.nowyeartext.TabIndex = 173
        '
        'halfmonth
        '
        Me.halfmonth.Location = New System.Drawing.Point(689, 149)
        Me.halfmonth.Name = "halfmonth"
        Me.halfmonth.Size = New System.Drawing.Size(57, 20)
        Me.halfmonth.TabIndex = 174
        '
        'tax
        '
        Me.tax.Location = New System.Drawing.Point(595, 185)
        Me.tax.Name = "tax"
        Me.tax.Size = New System.Drawing.Size(50, 20)
        Me.tax.TabIndex = 175
        '
        'madeduct
        '
        Me.madeduct.Location = New System.Drawing.Point(654, 185)
        Me.madeduct.Name = "madeduct"
        Me.madeduct.Size = New System.Drawing.Size(46, 20)
        Me.madeduct.TabIndex = 176
        '
        'debit
        '
        Me.debit.Location = New System.Drawing.Point(706, 185)
        Me.debit.Name = "debit"
        Me.debit.Size = New System.Drawing.Size(51, 20)
        Me.debit.TabIndex = 177
        '
        'jorate
        '
        Me.jorate.Location = New System.Drawing.Point(689, 108)
        Me.jorate.Name = "jorate"
        Me.jorate.Size = New System.Drawing.Size(32, 20)
        Me.jorate.TabIndex = 178
        '
        'ptrate
        '
        Me.ptrate.Location = New System.Drawing.Point(727, 108)
        Me.ptrate.Name = "ptrate"
        Me.ptrate.Size = New System.Drawing.Size(30, 20)
        Me.ptrate.TabIndex = 179
        '
        'textboxveri
        '
        Me.textboxveri.Location = New System.Drawing.Point(631, 490)
        Me.textboxveri.Name = "textboxveri"
        Me.textboxveri.Size = New System.Drawing.Size(100, 20)
        Me.textboxveri.TabIndex = 180
        Me.textboxveri.Text = "veri"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(331, 490)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 181
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(670, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 23)
        Me.Button1.TabIndex = 182
        Me.Button1.Text = "Confirm Your Account"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'timeattendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(798, 529)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.textboxveri)
        Me.Controls.Add(Me.ptrate)
        Me.Controls.Add(Me.jorate)
        Me.Controls.Add(Me.debit)
        Me.Controls.Add(Me.madeduct)
        Me.Controls.Add(Me.tax)
        Me.Controls.Add(Me.halfmonth)
        Me.Controls.Add(Me.nowyeartext)
        Me.Controls.Add(Me.nowmonthtext)
        Me.Controls.Add(Me.nowdaytext)
        Me.Controls.Add(Me.datetext)
        Me.Controls.Add(Me.userappoint)
        Me.Controls.Add(Me.useridnum)
        Me.Controls.Add(Me.userlname)
        Me.Controls.Add(Me.userfname)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.rate)
        Me.Controls.Add(Me.prompt)
        Me.Controls.Add(Me.notif)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grosspay)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.datee)
        Me.Controls.Add(Me.alltotal)
        Me.Controls.Add(Me.pmtotal)
        Me.Controls.Add(Me.pmout)
        Me.Controls.Add(Me.pmin)
        Me.Controls.Add(Me.amtotal)
        Me.Controls.Add(Me.amout)
        Me.Controls.Add(Me.aminn)
        Me.Controls.Add(Me.appointment)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.idnumb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.timelabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.idnumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusText)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.StatusLine)
        Me.Controls.Add(Me.Picture)
        Me.Name = "timeattendance"
        Me.Text = "time attendance"
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Picture As System.Windows.Forms.PictureBox
    Private WithEvents StatusText As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Private WithEvents StatusLine As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents idnumber As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grosspay As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents datee As System.Windows.Forms.TextBox
    Friend WithEvents alltotal As System.Windows.Forms.TextBox
    Friend WithEvents pmtotal As System.Windows.Forms.TextBox
    Friend WithEvents pmout As System.Windows.Forms.TextBox
    Friend WithEvents pmin As System.Windows.Forms.TextBox
    Friend WithEvents amtotal As System.Windows.Forms.TextBox
    Friend WithEvents amout As System.Windows.Forms.TextBox
    Friend WithEvents aminn As System.Windows.Forms.TextBox
    Friend WithEvents appointment As System.Windows.Forms.TextBox
    Friend WithEvents status As System.Windows.Forms.TextBox
    Friend WithEvents lname As System.Windows.Forms.TextBox
    Friend WithEvents fname As System.Windows.Forms.TextBox
    Friend WithEvents idnumb As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents timelabel As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountingOfficerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents notif As System.Windows.Forms.Label
    Friend WithEvents prompt As System.Windows.Forms.Label
    Friend WithEvents rate As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents userfname As System.Windows.Forms.TextBox
    Friend WithEvents userlname As System.Windows.Forms.TextBox
    Friend WithEvents useridnum As System.Windows.Forms.TextBox
    Friend WithEvents userappoint As System.Windows.Forms.TextBox
    Friend WithEvents nowdaytext As System.Windows.Forms.TextBox
    Friend WithEvents nowmonthtext As System.Windows.Forms.TextBox
    Friend WithEvents datetext As System.Windows.Forms.TextBox
    Friend WithEvents nowyeartext As System.Windows.Forms.TextBox
    Friend WithEvents halfmonth As System.Windows.Forms.TextBox
    Friend WithEvents tax As System.Windows.Forms.TextBox
    Friend WithEvents madeduct As System.Windows.Forms.TextBox
    Friend WithEvents debit As System.Windows.Forms.TextBox
    Friend WithEvents jorate As System.Windows.Forms.TextBox
    Friend WithEvents ptrate As System.Windows.Forms.TextBox
    Friend WithEvents textboxveri As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
