<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrystalReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowerBiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrossTabReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParameterisedReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrillDownReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Indicate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Teal
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccessToolStripMenuItem, Me.DashboardToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AccessToolStripMenuItem
        '
        Me.AccessToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.AccessToolStripMenuItem.Name = "AccessToolStripMenuItem"
        Me.AccessToolStripMenuItem.Size = New System.Drawing.Size(72, 25)
        Me.AccessToolStripMenuItem.Text = "Access"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.LoginToolStripMenuItem.Text = "L&ogin"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrystalReportsToolStripMenuItem, Me.PowerBiToolStripMenuItem})
        Me.DashboardToolStripMenuItem.Enabled = False
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(105, 25)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'CrystalReportsToolStripMenuItem
        '
        Me.CrystalReportsToolStripMenuItem.Name = "CrystalReportsToolStripMenuItem"
        Me.CrystalReportsToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.CrystalReportsToolStripMenuItem.Text = "Crystal Reports"
        '
        'PowerBiToolStripMenuItem
        '
        Me.PowerBiToolStripMenuItem.Name = "PowerBiToolStripMenuItem"
        Me.PowerBiToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.PowerBiToolStripMenuItem.Text = "PowerBi"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StandardReportToolStripMenuItem, Me.CrossTabReportToolStripMenuItem, Me.ParameterisedReportToolStripMenuItem, Me.DrillDownReportToolStripMenuItem})
        Me.ViewToolStripMenuItem.Enabled = False
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(60, 25)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'StandardReportToolStripMenuItem
        '
        Me.StandardReportToolStripMenuItem.Name = "StandardReportToolStripMenuItem"
        Me.StandardReportToolStripMenuItem.Size = New System.Drawing.Size(303, 26)
        Me.StandardReportToolStripMenuItem.Text = "Customer Payments Report"
        '
        'CrossTabReportToolStripMenuItem
        '
        Me.CrossTabReportToolStripMenuItem.Name = "CrossTabReportToolStripMenuItem"
        Me.CrossTabReportToolStripMenuItem.Size = New System.Drawing.Size(303, 26)
        Me.CrossTabReportToolStripMenuItem.Text = "Code 08 -10 Payments Report"
        '
        'ParameterisedReportToolStripMenuItem
        '
        Me.ParameterisedReportToolStripMenuItem.Name = "ParameterisedReportToolStripMenuItem"
        Me.ParameterisedReportToolStripMenuItem.Size = New System.Drawing.Size(303, 26)
        Me.ParameterisedReportToolStripMenuItem.Text = "Monthly Report"
        '
        'DrillDownReportToolStripMenuItem
        '
        Me.DrillDownReportToolStripMenuItem.Name = "DrillDownReportToolStripMenuItem"
        Me.DrillDownReportToolStripMenuItem.Size = New System.Drawing.Size(303, 26)
        Me.DrillDownReportToolStripMenuItem.Text = "Bookings Drill Down Report"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(58, 25)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(158, 26)
        Me.HelpToolStripMenuItem1.Text = "View Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Teal
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Indicate, Me.Status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 707)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1350, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Indicate
        '
        Me.Indicate.Name = "Indicate"
        Me.Indicate.Size = New System.Drawing.Size(0, 17)
        '
        'Status
        '
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(1335, 17)
        Me.Status.Spring = True
        Me.Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "Z:\Reporting Sub-System\WindowsApplication1CrystalReports\WindowsApplication1Crys" & _
    "talReports\help.chm"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Teal
        Me.BackgroundImage = Global.WindowsApplication1CrystalReports.My.Resources.Resources.qkEGfH
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AccessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandardReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrossTabReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParameterisedReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DrillDownReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Indicate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DashboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PowerBiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrystalReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
