<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payroll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(payroll))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.direct = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.collecting = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.debit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.credit = New System.Windows.Forms.TextBox()
        Me.daytext = New System.Windows.Forms.TextBox()
        Me.kinsenas = New System.Windows.Forms.TextBox()
        Me.yeartext = New System.Windows.Forms.TextBox()
        Me.monthtext = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IndividualRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndividualRecordsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollForJobOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollForPartTimeEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterAEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.monthquarter = New System.Windows.Forms.TextBox()
        Me.formonthname = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PaySlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.Location = New System.Drawing.Point(1230, 27)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 32)
        Me.Button4.TabIndex = 56
        Me.Button4.Text = "Preview"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(1044, 144)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 53
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(168, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(379, 40)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "CENTRAL PHILIPPINES STATE UNIVERSITY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "            Hinigaran Negros Occidental"
        '
        'direct
        '
        Me.direct.AutoSize = True
        Me.direct.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direct.Location = New System.Drawing.Point(1088, 440)
        Me.direct.Name = "direct"
        Me.direct.Size = New System.Drawing.Size(193, 36)
        Me.direct.TabIndex = 48
        Me.direct.Text = "CHRISTOPHER D. MANDIN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        Campus Director"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'collecting
        '
        Me.collecting.AutoSize = True
        Me.collecting.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.collecting.Location = New System.Drawing.Point(1113, 527)
        Me.collecting.Name = "collecting"
        Me.collecting.Size = New System.Drawing.Size(169, 34)
        Me.collecting.TabIndex = 42
        Me.collecting.Text = "RAYMARK A. TAMPOS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Acting Collecting Officer"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(839, 686)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Debit"
        '
        'debit
        '
        Me.debit.Location = New System.Drawing.Point(842, 705)
        Me.debit.Name = "debit"
        Me.debit.Size = New System.Drawing.Size(84, 20)
        Me.debit.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(981, 705)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(277, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Certified: Funds available in the amount of Php."
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2, Me.Column11, Me.Column4, Me.Column6, Me.Column5, Me.Column7, Me.Column9, Me.Column10, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(963, 564)
        Me.DataGridView1.TabIndex = 34
        '
        'Column1
        '
        Me.Column1.HeaderText = "idnum"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 60
        '
        'Column3
        '
        Me.Column3.HeaderText = "Last Name"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 77
        '
        'Column2
        '
        Me.Column2.HeaderText = "First Name"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 76
        '
        'Column11
        '
        Me.Column11.HeaderText = "Middle Name"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 87
        '
        'Column4
        '
        Me.Column4.HeaderText = "Appointment"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 91
        '
        'Column6
        '
        Me.Column6.HeaderText = "Hours Rendered"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 101
        '
        'Column5
        '
        Me.Column5.HeaderText = "Rate"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 55
        '
        'Column7
        '
        Me.Column7.HeaderText = "Earned For The Period           "
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 130
        '
        'Column9
        '
        Me.Column9.HeaderText = "Tax Deduction     "
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 97
        '
        'Column10
        '
        Me.Column10.HeaderText = "Net Pay"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 65
        '
        'Column8
        '
        Me.Column8.HeaderText = "Signature"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 77
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(742, 686)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 16)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "Credit"
        '
        'credit
        '
        Me.credit.Location = New System.Drawing.Point(745, 705)
        Me.credit.Name = "credit"
        Me.credit.Size = New System.Drawing.Size(88, 20)
        Me.credit.TabIndex = 61
        '
        'daytext
        '
        Me.daytext.Location = New System.Drawing.Point(898, 48)
        Me.daytext.Name = "daytext"
        Me.daytext.Size = New System.Drawing.Size(67, 20)
        Me.daytext.TabIndex = 62
        '
        'kinsenas
        '
        Me.kinsenas.Location = New System.Drawing.Point(971, 48)
        Me.kinsenas.Name = "kinsenas"
        Me.kinsenas.Size = New System.Drawing.Size(67, 20)
        Me.kinsenas.TabIndex = 63
        '
        'yeartext
        '
        Me.yeartext.Location = New System.Drawing.Point(1044, 48)
        Me.yeartext.Name = "yeartext"
        Me.yeartext.Size = New System.Drawing.Size(62, 20)
        Me.yeartext.TabIndex = 64
        '
        'monthtext
        '
        Me.monthtext.Location = New System.Drawing.Point(1112, 47)
        Me.monthtext.Name = "monthtext"
        Me.monthtext.Size = New System.Drawing.Size(59, 20)
        Me.monthtext.TabIndex = 65
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1264, 705)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(101, 20)
        Me.TextBox1.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(597, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 20)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Contractual Employee"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndividualRecordsToolStripMenuItem, Me.RegisterAEmployeeToolStripMenuItem, Me.AdminPageToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 70
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IndividualRecordsToolStripMenuItem
        '
        Me.IndividualRecordsToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.IndividualRecordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndividualRecordsToolStripMenuItem1, Me.PayrollForJobOrderToolStripMenuItem, Me.PayrollForPartTimeEmployeeToolStripMenuItem, Me.PaySlipToolStripMenuItem})
        Me.IndividualRecordsToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndividualRecordsToolStripMenuItem.Name = "IndividualRecordsToolStripMenuItem"
        Me.IndividualRecordsToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.IndividualRecordsToolStripMenuItem.Text = "Links to Records"
        '
        'IndividualRecordsToolStripMenuItem1
        '
        Me.IndividualRecordsToolStripMenuItem1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndividualRecordsToolStripMenuItem1.ForeColor = System.Drawing.Color.Green
        Me.IndividualRecordsToolStripMenuItem1.Name = "IndividualRecordsToolStripMenuItem1"
        Me.IndividualRecordsToolStripMenuItem1.Size = New System.Drawing.Size(248, 22)
        Me.IndividualRecordsToolStripMenuItem1.Text = "Individual Records"
        '
        'PayrollForJobOrderToolStripMenuItem
        '
        Me.PayrollForJobOrderToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.PayrollForJobOrderToolStripMenuItem.Name = "PayrollForJobOrderToolStripMenuItem"
        Me.PayrollForJobOrderToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.PayrollForJobOrderToolStripMenuItem.Text = "Payroll for Job Order"
        '
        'PayrollForPartTimeEmployeeToolStripMenuItem
        '
        Me.PayrollForPartTimeEmployeeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PayrollForPartTimeEmployeeToolStripMenuItem.Name = "PayrollForPartTimeEmployeeToolStripMenuItem"
        Me.PayrollForPartTimeEmployeeToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.PayrollForPartTimeEmployeeToolStripMenuItem.Text = "Payroll for Part Time Employee"
        '
        'RegisterAEmployeeToolStripMenuItem
        '
        Me.RegisterAEmployeeToolStripMenuItem.Checked = True
        Me.RegisterAEmployeeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RegisterAEmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOfEmployeeToolStripMenuItem, Me.RegisterEmployeeToolStripMenuItem})
        Me.RegisterAEmployeeToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterAEmployeeToolStripMenuItem.Name = "RegisterAEmployeeToolStripMenuItem"
        Me.RegisterAEmployeeToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.RegisterAEmployeeToolStripMenuItem.Text = "For Employee"
        '
        'ListOfEmployeeToolStripMenuItem
        '
        Me.ListOfEmployeeToolStripMenuItem.Name = "ListOfEmployeeToolStripMenuItem"
        Me.ListOfEmployeeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListOfEmployeeToolStripMenuItem.Text = "List of Employee"
        '
        'RegisterEmployeeToolStripMenuItem
        '
        Me.RegisterEmployeeToolStripMenuItem.Name = "RegisterEmployeeToolStripMenuItem"
        Me.RegisterEmployeeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegisterEmployeeToolStripMenuItem.Text = "Register Employee"
        '
        'AdminPageToolStripMenuItem
        '
        Me.AdminPageToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminPageToolStripMenuItem.Name = "AdminPageToolStripMenuItem"
        Me.AdminPageToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.AdminPageToolStripMenuItem.Text = "Admin Page"
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(1295, 29)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 72
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'monthquarter
        '
        Me.monthquarter.Location = New System.Drawing.Point(869, 80)
        Me.monthquarter.Name = "monthquarter"
        Me.monthquarter.Size = New System.Drawing.Size(57, 20)
        Me.monthquarter.TabIndex = 107
        '
        'formonthname
        '
        Me.formonthname.Location = New System.Drawing.Point(788, 80)
        Me.formonthname.Name = "formonthname"
        Me.formonthname.Size = New System.Drawing.Size(56, 20)
        Me.formonthname.TabIndex = 106
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(850, 83)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(10, 13)
        Me.Label22.TabIndex = 105
        Me.Label22.Text = "-"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(940, 83)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(0, 13)
        Me.Label20.TabIndex = 104
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(673, 83)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(109, 13)
        Me.Label18.TabIndex = 103
        Me.Label18.Text = "For The Month of:"
        '
        'PaySlipToolStripMenuItem
        '
        Me.PaySlipToolStripMenuItem.Name = "PaySlipToolStripMenuItem"
        Me.PaySlipToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.PaySlipToolStripMenuItem.Text = "Pay Slip"
        '
        'payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 746)
        Me.Controls.Add(Me.monthquarter)
        Me.Controls.Add(Me.formonthname)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.monthtext)
        Me.Controls.Add(Me.yeartext)
        Me.Controls.Add(Me.kinsenas)
        Me.Controls.Add(Me.daytext)
        Me.Controls.Add(Me.credit)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.direct)
        Me.Controls.Add(Me.collecting)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.debit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "payroll"
        Me.Text = "payroll"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents direct As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents collecting As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents debit As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents credit As System.Windows.Forms.TextBox
    Friend WithEvents daytext As System.Windows.Forms.TextBox
    Friend WithEvents kinsenas As System.Windows.Forms.TextBox
    Friend WithEvents yeartext As System.Windows.Forms.TextBox
    Friend WithEvents monthtext As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents IndividualRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndividualRecordsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayrollForJobOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayrollForPartTimeEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterAEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListOfEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents monthquarter As System.Windows.Forms.TextBox
    Friend WithEvents formonthname As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaySlipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
