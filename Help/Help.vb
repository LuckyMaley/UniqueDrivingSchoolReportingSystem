Public Class Help
    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Introduction.TopLevel = False
        HelpPanel.Controls.Add(Introduction)
        Introduction.Show()
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If Not (TreeView1.SelectedNode Is Nothing) Then
            Select Case TreeView1.SelectedNode.Name
                Case "Node0"
                    Introduction.TopLevel = False
                    HelpPanel.Controls.Add(Introduction)
                    Introduction.Show()
                    CustomerPaymentsReport.Close()
                    Login.Close()
                    MonthlyReport.Close()
                    BookingDrillDownReport.Close()
                    Power_BI.Close()
                    Crystal_Report.Close()
                    Code08_10PaymentReport.Close()
                Case "Node1"
                    Login.TopLevel = False
                    HelpPanel.Controls.Add(Login)
                    Login.Show()
                    CustomerPaymentsReport.Close()
                    Introduction.Close()
                    MonthlyReport.Close()
                    BookingDrillDownReport.Close()
                    Power_BI.Close()
                    Crystal_Report.Close()
                    Code08_10PaymentReport.Close()
                Case "Node2"
                    Crystal_Report.TopLevel = False
                    HelpPanel.Controls.Add(Crystal_Report)
                    Crystal_Report.Show()
                    CustomerPaymentsReport.Close()
                    Login.Close()
                    MonthlyReport.Close()
                    BookingDrillDownReport.Close()
                    Power_BI.Close()
                    Introduction.Close()
                    Code08_10PaymentReport.Close()
                Case "Node3"
                    Power_BI.TopLevel = False
                    HelpPanel.Controls.Add(Power_BI)
                    Power_BI.Show()
                    CustomerPaymentsReport.Close()
                    Login.Close()
                    MonthlyReport.Close()
                    BookingDrillDownReport.Close()
                    Crystal_Report.Close()
                    Introduction.Close()
                    Code08_10PaymentReport.Close()
                Case "Node4"
                    CustomerPaymentsReport.TopLevel = False
                    HelpPanel.Controls.Add(CustomerPaymentsReport)
                    CustomerPaymentsReport.Show()
                    Crystal_Report.Close()
                    Login.Close()
                    MonthlyReport.Close()
                    BookingDrillDownReport.Close()
                    Power_BI.Close()
                    Introduction.Close()
                    Code08_10PaymentReport.Close()
                Case "Node5"
                    Code08_10PaymentReport.TopLevel = False
                    HelpPanel.Controls.Add(Code08_10PaymentReport)
                    Code08_10PaymentReport.Show()
                    Crystal_Report.Close()
                    Login.Close()
                    MonthlyReport.Close()
                    BookingDrillDownReport.Close()
                    Power_BI.Close()
                    Introduction.Close()
                    CustomerPaymentsReport.Close()
                Case "Node6"
                    MonthlyReport.TopLevel = False
                    HelpPanel.Controls.Add(MonthlyReport)
                    MonthlyReport.Show()
                    Crystal_Report.Close()
                    Login.Close()
                    CustomerPaymentsReport.Close()
                    BookingDrillDownReport.Close()
                    Power_BI.Close()
                    Introduction.Close()
                    Code08_10PaymentReport.Close()
                Case "Node7"
                    BookingDrillDownReport.TopLevel = False
                    HelpPanel.Controls.Add(BookingDrillDownReport)
                    BookingDrillDownReport.Show()
                    Crystal_Report.Close()
                    Login.Close()
                    MonthlyReport.Close()
                    CustomerPaymentsReport.Close()
                    Power_BI.Close()
                    Introduction.Close()
                    Code08_10PaymentReport.Close()
            End Select
        End If
    End Sub
End Class