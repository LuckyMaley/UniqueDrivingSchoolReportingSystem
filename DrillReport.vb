Imports System.Globalization

Public Class DrillReport
    Private Sub DrillReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            DataSet1.EnforceConstraints = False
            Dim ri As System.Globalization.RegionInfo = New System.Globalization.RegionInfo(New CultureInfo("en-ZA").LCID)
            BookingTableAdapter.Fill(DataSet1.Booking)
            PaymentTableAdapter.Fill(DataSet1.Payment)
            CustomerTableAdapter.Fill(DataSet1.Customer)
            DrillCrystalReport1.SetDataSource(DataSet1)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DrillReport_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.DrillDownReportToolStripMenuItem.Enabled = True
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As System.Object, e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class