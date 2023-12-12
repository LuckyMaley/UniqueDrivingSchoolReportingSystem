Public Class StandardReport
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            DataSet1.EnforceConstraints = False
            'TODO: This line of code loads data into the 'DataSet1.Payment' table. You can move, or remove it, as needed.
            Me.PaymentTableAdapter.Fill(Me.DataSet1.Payment)
            'TODO: This line of code loads data into the 'DataSet1.Booking' table. You can move, or remove it, as needed.
            Me.CustomerTableAdapter.Fill(Me.DataSet1.Customer)
            StandardCrystalReport1.SetDataSource(DataSet1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub StandardReport_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.StandardReportToolStripMenuItem.Enabled = True
    End Sub
End Class