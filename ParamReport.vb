Imports CrystalDecisions.Shared
Public Class ParamReport
    Private Sub ParamReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            DataSet1.EnforceConstraints = False
            PaymentTableAdapter.Fill(DataSet1.Payment)
            CustomerTableAdapter.Fill(DataSet1.Customer)
            ParamCrystalReport1.SetDataSource(DataSet1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try

            Dim Report1 As New ParamCrystalReport
            Report1.Load(Application.StartupPath & "\ParamCrystalReport.rpt")
            Dim pfield As New ParameterField
            Dim pfields As New ParameterFields
            Dim pdiscrete As New ParameterDiscreteValue

            Dim pfield1 As New ParameterField
            Dim pdiscrete1 As New ParameterDiscreteValue

            Dim pfield2 As New ParameterField
            Dim pdiscrete2 As New ParameterDiscreteValue

            Dim pfield3 As New ParameterField
            Dim pdiscrete3 As New ParameterDiscreteValue

            pfield.Name = "Month"
            pdiscrete.Value = "May"
            pfield.CurrentValues.Add(pdiscrete)
            pfields.Add(pfield)

            pfield1.Name = "Year"
            pdiscrete1.Value = "2019"
            pfield1.CurrentValues.Add(pdiscrete1)
            pfields.Add(pfield1)
            PaymentTableAdapter.Fill(DataSet1.Payment)
            CustomerTableAdapter.Fill(DataSet1.Customer)
            Report1.SetDataSource(DataSet1)
            CrystalReportViewer1.ReportSource = Report1

            CrystalReportViewer1.ParameterFieldInfo = pfields

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ParamReport_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.ParameterisedReportToolStripMenuItem.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If (ComboBox1.Text <> "" And ComboBox2.Text <> "") Then
            Try

                Dim Report1 As New ParamCrystalReport
                Report1.Load(Application.StartupPath & "\ParamCrystalReport.rpt")
                Dim pfield As New ParameterField
                Dim pfields As New ParameterFields
                Dim pdiscrete As New ParameterDiscreteValue

                Dim pfield1 As New ParameterField
                Dim pdiscrete1 As New ParameterDiscreteValue

                Dim pfield2 As New ParameterField
                Dim pdiscrete2 As New ParameterDiscreteValue

                Dim pfield3 As New ParameterField
                Dim pdiscrete3 As New ParameterDiscreteValue

                pfield.Name = "Month"
                pdiscrete.Value = ComboBox1.Text
                pfield.CurrentValues.Add(pdiscrete)
                pfields.Add(pfield)

                pfield1.Name = "Year"
                pdiscrete1.Value = ComboBox2.Text
                pfield1.CurrentValues.Add(pdiscrete1)
                pfields.Add(pfield1)
                PaymentTableAdapter.Fill(DataSet1.Payment)
                CustomerTableAdapter.Fill(DataSet1.Customer)
                Report1.SetDataSource(DataSet1)
                CrystalReportViewer1.ReportSource = Report1

                CrystalReportViewer1.ParameterFieldInfo = pfields

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("No Null's Accepted. make sure that the 2 combo boxes are filled")
        End If
    End Sub
End Class