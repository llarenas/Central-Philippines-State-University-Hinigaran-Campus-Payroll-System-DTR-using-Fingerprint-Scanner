<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IndividualRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndividualRecordsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollForJobOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollForPartTimeEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaySlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterAEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(391, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List of Employee"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.fname, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(99, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(800, 560)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id Number"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 75
        '
        'fname
        '
        Me.fname.HeaderText = "First Name"
        Me.fname.Name = "fname"
        Me.fname.Width = 76
        '
        'Column2
        '
        Me.Column2.HeaderText = "Middle Name"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 87
        '
        'Column3
        '
        Me.Column3.HeaderText = "Last Name"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 77
        '
        'Column4
        '
        Me.Column4.HeaderText = "Relationship Status"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 113
        '
        'Column5
        '
        Me.Column5.HeaderText = "Appointment"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 91
        '
        'Column6
        '
        Me.Column6.HeaderText = "Birthday"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 70
        '
        'Column7
        '
        Me.Column7.HeaderText = "Address"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 70
        '
        'Column8
        '
        Me.Column8.HeaderText = "Gender"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 67
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndividualRecordsToolStripMenuItem, Me.RegisterAEmployeeToolStripMenuItem, Me.AdminPageToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(969, 24)
        Me.MenuStrip1.TabIndex = 45
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IndividualRecordsToolStripMenuItem
        '
        Me.IndividualRecordsToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.IndividualRecordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndividualRecordsToolStripMenuItem1, Me.PayrollToolStripMenuItem, Me.PayrollForJobOrderToolStripMenuItem, Me.PayrollForPartTimeEmployeeToolStripMenuItem, Me.PaySlipToolStripMenuItem})
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
        Me.IndividualRecordsToolStripMenuItem1.Size = New System.Drawing.Size(250, 22)
        Me.IndividualRecordsToolStripMenuItem1.Text = "Individual Records"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayrollToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.PayrollToolStripMenuItem.Text = "Payroll for Contractual Employee"
        '
        'PayrollForJobOrderToolStripMenuItem
        '
        Me.PayrollForJobOrderToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.PayrollForJobOrderToolStripMenuItem.Name = "PayrollForJobOrderToolStripMenuItem"
        Me.PayrollForJobOrderToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.PayrollForJobOrderToolStripMenuItem.Text = "Payroll for Job Order"
        '
        'PayrollForPartTimeEmployeeToolStripMenuItem
        '
        Me.PayrollForPartTimeEmployeeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PayrollForPartTimeEmployeeToolStripMenuItem.Name = "PayrollForPartTimeEmployeeToolStripMenuItem"
        Me.PayrollForPartTimeEmployeeToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.PayrollForPartTimeEmployeeToolStripMenuItem.Text = "Payroll for Part Time Employee"
        '
        'PaySlipToolStripMenuItem
        '
        Me.PaySlipToolStripMenuItem.Name = "PaySlipToolStripMenuItem"
        Me.PaySlipToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.PaySlipToolStripMenuItem.Text = "Pay Slip"
        '
        'RegisterAEmployeeToolStripMenuItem
        '
        Me.RegisterAEmployeeToolStripMenuItem.Checked = True
        Me.RegisterAEmployeeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RegisterAEmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterEmployeeToolStripMenuItem})
        Me.RegisterAEmployeeToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterAEmployeeToolStripMenuItem.Name = "RegisterAEmployeeToolStripMenuItem"
        Me.RegisterAEmployeeToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.RegisterAEmployeeToolStripMenuItem.Text = "For Employee"
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
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(882, 27)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 72
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 695)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Employee"
        Me.Text = "Employee"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents IndividualRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndividualRecordsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayrollForJobOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayrollForPartTimeEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterAEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaySlipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
