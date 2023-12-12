Imports System.Globalization

Public Class MainForm
    Dim strHelpPath As String = System.IO.Path.Combine(Application.StartupPath, "help.chm")

    Friend Sub FormSetUp(ByVal ChildForm As Form)
        Try
            Me.ActiveMdiChild.Close()

        Catch ex As Exception
        End Try
        With ChildForm
            .MdiParent = Me
            .MaximizeBox = False
            .MinimizeBox = False
            .ControlBox = False
            .WindowState = FormWindowState.Maximized
            .Show()
        End With

    End Sub

    Friend Sub FormSetUp1(ByVal ChildForm As Form)
        Try
            Me.ActiveMdiChild.Close()

        Catch ex As Exception
        End Try
        With ChildForm
            .MdiParent = Me
            .Show()
        End With

    End Sub
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormSetUp1(LoginForm)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit", "Confirmation", MessageBoxButtons.YesNo)
        If Result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub StandardReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StandardReportToolStripMenuItem.Click
        FormSetUp(StandardReport)
        StandardReportToolStripMenuItem.Enabled = False
    End Sub

    Private Sub CrossTabReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CrossTabReportToolStripMenuItem.Click
        FormSetUp(CrossTabReport)
        CrossTabReportToolStripMenuItem.Enabled = False
    End Sub

    Private Sub ParameterisedReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ParameterisedReportToolStripMenuItem.Click
        FormSetUp(ParamReport)
        ParameterisedReportToolStripMenuItem.Enabled = False
    End Sub

    Private Sub DrillDownReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DrillDownReportToolStripMenuItem.Click
        FormSetUp(DrillReport)
        DrillDownReportToolStripMenuItem.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Status.Text = DateTime.Now.ToString("hh:mm tt") & "  " & DateTime.Now.ToString("MMMM  dd  yyyy")
    End Sub

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ri As System.Globalization.RegionInfo = New System.Globalization.RegionInfo(New CultureInfo("en-ZA").LCID)

        Timer1.Start()
        HelpProvider1.HelpNamespace = strHelpPath
        Indicate.Text = "[Not Logged in]"
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        'Help.ShowHelp(Me, HelpProvider1.HelpNamespace, HelpNavigator.TableOfContents)
        Help.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
        AboutToolStripMenuItem.Enabled = False
    End Sub

    Private Sub PowerBiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PowerBiToolStripMenuItem.Click
        FormSetUp(PowerBi)
        PowerBiToolStripMenuItem.Enabled = False
    End Sub

    Private Sub CrystalReportsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CrystalReportsToolStripMenuItem.Click
        FormSetUp(Form2)
        CrystalReportsToolStripMenuItem.Enabled = False
    End Sub
End Class