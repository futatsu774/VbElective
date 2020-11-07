<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.POSActivity1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.activity1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.activity2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.activity4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.accountingstaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.horizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.cascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.vertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.POSActivity1ToolStripMenuItem, Me.PayrollToolStripMenuItem, Me.EmployeeInformationToolStripMenuItem, Me.UserAccountsToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.WindowToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'POSActivity1ToolStripMenuItem
        '
        Me.POSActivity1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.activity1, Me.activity2, Me.activity4})
        Me.POSActivity1ToolStripMenuItem.Name = "POSActivity1ToolStripMenuItem"
        Me.POSActivity1ToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.POSActivity1ToolStripMenuItem.Text = "POS Application"
        '
        'activity1
        '
        Me.activity1.Name = "activity1"
        Me.activity1.Size = New System.Drawing.Size(194, 26)
        Me.activity1.Text = "POS (Activity 1)"
        '
        'activity2
        '
        Me.activity2.Name = "activity2"
        Me.activity2.Size = New System.Drawing.Size(194, 26)
        Me.activity2.Text = "POS (Activity 2)"
        '
        'activity4
        '
        Me.activity4.Name = "activity4"
        Me.activity4.Size = New System.Drawing.Size(194, 26)
        Me.activity4.Text = "POS (Activity 4)"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.accountingstaff})
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.PayrollToolStripMenuItem.Text = "Payroll"
        '
        'accountingstaff
        '
        Me.accountingstaff.Name = "accountingstaff"
        Me.accountingstaff.Size = New System.Drawing.Size(202, 26)
        Me.accountingstaff.Text = "Accounting Staff"
        '
        'EmployeeInformationToolStripMenuItem
        '
        Me.EmployeeInformationToolStripMenuItem.Name = "EmployeeInformationToolStripMenuItem"
        Me.EmployeeInformationToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.EmployeeInformationToolStripMenuItem.Text = "Employee Information"
        '
        'UserAccountsToolStripMenuItem
        '
        Me.UserAccountsToolStripMenuItem.Name = "UserAccountsToolStripMenuItem"
        Me.UserAccountsToolStripMenuItem.Size = New System.Drawing.Size(116, 24)
        Me.UserAccountsToolStripMenuItem.Text = "User Accounts"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.horizontal, Me.cascade, Me.vertical})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'horizontal
        '
        Me.horizontal.Name = "horizontal"
        Me.horizontal.Size = New System.Drawing.Size(224, 26)
        Me.horizontal.Text = "Horizontal"
        '
        'cascade
        '
        Me.cascade.Name = "cascade"
        Me.cascade.Size = New System.Drawing.Size(224, 26)
        Me.cascade.Text = "Cascade"
        '
        'vertical
        '
        Me.vertical.Name = "vertical"
        Me.vertical.Size = New System.Drawing.Size(224, 26)
        Me.vertical.Text = "Vertical"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents POSActivity1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents activity1 As ToolStripMenuItem
    Friend WithEvents activity2 As ToolStripMenuItem
    Friend WithEvents activity4 As ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserAccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents accountingstaff As ToolStripMenuItem
    Friend WithEvents horizontal As ToolStripMenuItem
    Friend WithEvents cascade As ToolStripMenuItem
    Friend WithEvents vertical As ToolStripMenuItem
End Class
