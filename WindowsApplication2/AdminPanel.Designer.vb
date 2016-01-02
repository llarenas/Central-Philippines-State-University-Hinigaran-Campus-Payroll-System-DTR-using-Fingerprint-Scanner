<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPanel
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
        Me.rate = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tax = New System.Windows.Forms.TextBox()
        Me.jorate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ptrate = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IndividualRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndividualRecordsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollForJobOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollForPartTimeEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaySlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterAEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rate
        '
        Me.rate.Location = New System.Drawing.Point(38, 115)
        Me.rate.Name = "rate"
        Me.rate.Size = New System.Drawing.Size(60, 20)
        Me.rate.TabIndex = 45
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 23)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Change the Rate per Hour"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.Salmon
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(666, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 23)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Change the Tax/Deduction"
        '
        'tax
        '
        Me.tax.Location = New System.Drawing.Point(38, 180)
        Me.tax.Name = "tax"
        Me.tax.Size = New System.Drawing.Size(60, 20)
        Me.tax.TabIndex = 50
        '
        'jorate
        '
        Me.jorate.Location = New System.Drawing.Point(316, 180)
        Me.jorate.Name = "jorate"
        Me.jorate.Size = New System.Drawing.Size(71, 20)
        Me.jorate.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Contractual"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(313, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Job Order Per Half Day"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(195, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Part Time"
        '
        'ptrate
        '
        Me.ptrate.Location = New System.Drawing.Point(198, 115)
        Me.ptrate.Name = "ptrate"
        Me.ptrate.Size = New System.Drawing.Size(71, 20)
        Me.ptrate.TabIndex = 54
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndividualRecordsToolStripMenuItem, Me.RegisterAEmployeeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(731, 24)
        Me.MenuStrip1.TabIndex = 70
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
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(656, 27)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 71
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AdminPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(731, 342)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ptrate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.jorate)
        Me.Controls.Add(Me.tax)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rate)
        Me.Name = "AdminPanel"
        Me.Text = "AdminPanel"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rate As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tax As System.Windows.Forms.TextBox
    Friend WithEvents jorate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ptrate As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents IndividualRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndividualRecordsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayrollForJobOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayrollForPartTimeEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterAEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListOfEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PaySlipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
