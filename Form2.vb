Imports CrystalDecisions.Shared
Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
         
        Try
            DateTimePicker1.MaxDate = Today
            RadioButton1.Checked = True
            Dim Report1 As New CrystalReport3
            Report1.Load(Application.StartupPath & "\CrystalReport3.rpt")
            Dim pfield As New ParameterField
            Dim pfields As New ParameterFields
            Dim pdiscrete As New ParameterDiscreteValue

            Dim pfield1 As New ParameterField
            Dim pdiscrete1 As New ParameterDiscreteValue

            Dim pfield2 As New ParameterField
            Dim pdiscrete2 As New ParameterDiscreteValue

            Dim pfield3 As New ParameterField
            Dim pdiscrete3 As New ParameterDiscreteValue

            pfield.Name = "StartDate"
            pdiscrete.Value = "02/10/2019"
            pfield.CurrentValues.Add(pdiscrete)
            pfields.Add(pfield)

            pfield1.Name = "EndDate"
            pdiscrete1.Value = DateTimePicker2.Value.Date
            pfield1.CurrentValues.Add(pdiscrete1)
            pfields.Add(pfield1)
            BookingTableAdapter1.Fill(DataSet11.Booking)

            pfield2.Name = "Code"
            pdiscrete2.Value = "08"
            pfield2.CurrentValues.Add(pdiscrete2)
            pfields.Add(pfield2)

            pfield3.Name = "Code1"
            pdiscrete3.Value = "10"
            pfield3.CurrentValues.Add(pdiscrete3)
            pfields.Add(pfield3)

            Report1.SetDataSource(DataSet11)
            CrystalReportViewer1.ReportSource = Report1

            CrystalReportViewer1.ParameterFieldInfo = pfields

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub Form2_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.CrystalReportsToolStripMenuItem.Enabled = True
    End Sub

   

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Dim Report1 As New CrystalReport3
            Report1.Load(Application.StartupPath & "\CrystalReport3.rpt")
            Dim pfield As New ParameterField
            Dim pfields As New ParameterFields
            Dim pdiscrete As New ParameterDiscreteValue

            Dim pfield1 As New ParameterField
            Dim pdiscrete1 As New ParameterDiscreteValue

            Dim pfield2 As New ParameterField
            Dim pdiscrete2 As New ParameterDiscreteValue

            Dim pfield3 As New ParameterField
            Dim pdiscrete3 As New ParameterDiscreteValue
            If RadioButton1.Checked = True Then


                pfield.Name = "StartDate"
                pdiscrete.Value = DateTimePicker1.Value.Date
                pfield.CurrentValues.Add(pdiscrete)
                pfields.Add(pfield)

                pfield1.Name = "EndDate"
                pdiscrete1.Value = DateTimePicker2.Value.Date
                pfield1.CurrentValues.Add(pdiscrete1)
                pfields.Add(pfield1)

                pfield2.Name = "Code"
                pdiscrete2.Value = "08"
                pfield2.CurrentValues.Add(pdiscrete2)
                pfields.Add(pfield2)

                pfield3.Name = "Code1"
                pdiscrete3.Value = "10"
                pfield3.CurrentValues.Add(pdiscrete3)
                pfields.Add(pfield3)


            ElseIf RadioButton2.Checked = True Then
                pfield.Name = "StartDate"
                pdiscrete.Value = DateTimePicker1.Value.Date
                pfield.CurrentValues.Add(pdiscrete)
                pfields.Add(pfield)

                pfield1.Name = "EndDate"
                pdiscrete1.Value = DateTimePicker2.Value.Date
                pfield1.CurrentValues.Add(pdiscrete1)
                pfields.Add(pfield1)

                pfield2.Name = "Code"
                pdiscrete2.Value = "08"
                pfield2.CurrentValues.Add(pdiscrete2)
                pfields.Add(pfield2)

                pfield3.Name = "Code1"
                pdiscrete3.Value = ""
                pfield3.CurrentValues.Add(pdiscrete3)
                pfields.Add(pfield3)
            Else
                pfield.Name = "StartDate"
                pdiscrete.Value = DateTimePicker1.Value.Date
                pfield.CurrentValues.Add(pdiscrete)
                pfields.Add(pfield)

                pfield1.Name = "EndDate"
                pdiscrete1.Value = DateTimePicker2.Value.Date
                pfield1.CurrentValues.Add(pdiscrete1)
                pfields.Add(pfield1)

                pfield2.Name = "Code"
                pdiscrete2.Value = ""
                pfield2.CurrentValues.Add(pdiscrete2)
                pfields.Add(pfield2)

                pfield3.Name = "Code1"
                pdiscrete3.Value = "10"
                pfield3.CurrentValues.Add(pdiscrete3)
                pfields.Add(pfield3)

            End If
            BookingTableAdapter1.Fill(DataSet11.Booking)
            Report1.SetDataSource(DataSet11)
            CrystalReportViewer1.ReportSource = Report1

            CrystalReportViewer1.ParameterFieldInfo = pfields


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Try
            Dim Report1 As New CrystalReport3
            Report1.Load(Application.StartupPath & "\CrystalReport3.rpt")
            Dim pfield As New ParameterField
            Dim pfields As New ParameterFields
            Dim pdiscrete As New ParameterDiscreteValue

            Dim pfield1 As New ParameterField
            Dim pdiscrete1 As New ParameterDiscreteValue

            Dim pfield2 As New ParameterField
            Dim pdiscrete2 As New ParameterDiscreteValue

            Dim pfield3 As New ParameterField
            Dim pdiscrete3 As New ParameterDiscreteValue

            pfield.Name = "StartDate"
            pdiscrete.Value = DateTimePicker1.Value.Date
            pfield.CurrentValues.Add(pdiscrete)
            pfields.Add(pfield)

            pfield1.Name = "EndDate"
            pdiscrete1.Value = DateTimePicker2.Value.Date
            pfield1.CurrentValues.Add(pdiscrete1)
            pfields.Add(pfield1)
            BookingTableAdapter1.Fill(DataSet11.Booking)

            pfield2.Name = "Code"
            pdiscrete2.Value = "08"
            pfield2.CurrentValues.Add(pdiscrete2)
            pfields.Add(pfield2)

            pfield3.Name = "Code1"
            pdiscrete3.Value = "10"
            pfield3.CurrentValues.Add(pdiscrete3)
            pfields.Add(pfield3)

            Report1.SetDataSource(DataSet11)
            CrystalReportViewer1.ReportSource = Report1

            CrystalReportViewer1.ParameterFieldInfo = pfields

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Try
            Dim Report1 As New CrystalReport3
            Report1.Load(Application.StartupPath & "\CrystalReport3.rpt")
            Dim pfield As New ParameterField
            Dim pfields As New ParameterFields
            Dim pdiscrete As New ParameterDiscreteValue

            Dim pfield1 As New ParameterField
            Dim pdiscrete1 As New ParameterDiscreteValue

            Dim pfield2 As New ParameterField
            Dim pdiscrete2 As New ParameterDiscreteValue

            Dim pfield3 As New ParameterField
            Dim pdiscrete3 As New ParameterDiscreteValue

            pfield.Name = "StartDate"
            pdiscrete.Value = DateTimePicker1.Value.Date
            pfield.CurrentValues.Add(pdiscrete)
            pfields.Add(pfield)

            pfield1.Name = "EndDate"
            pdiscrete1.Value = DateTimePicker2.Value.Date
            pfield1.CurrentValues.Add(pdiscrete1)
            pfields.Add(pfield1)
            BookingTableAdapter1.Fill(DataSet11.Booking)

            pfield2.Name = "Code"
            pdiscrete2.Value = "08"
            pfield2.CurrentValues.Add(pdiscrete2)
            pfields.Add(pfield2)

            pfield3.Name = "Code1"
            pdiscrete3.Value = ""
            pfield3.CurrentValues.Add(pdiscrete3)
            pfields.Add(pfield3)

            Report1.SetDataSource(DataSet11)
            CrystalReportViewer1.ReportSource = Report1

            CrystalReportViewer1.ParameterFieldInfo = pfields

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Try
            Dim Report1 As New CrystalReport3
            Report1.Load(Application.StartupPath & "\CrystalReport3.rpt")
            Dim pfield As New ParameterField
            Dim pfields As New ParameterFields
            Dim pdiscrete As New ParameterDiscreteValue

            Dim pfield1 As New ParameterField
            Dim pdiscrete1 As New ParameterDiscreteValue

            Dim pfield2 As New ParameterField
            Dim pdiscrete2 As New ParameterDiscreteValue

            Dim pfield3 As New ParameterField
            Dim pdiscrete3 As New ParameterDiscreteValue

            pfield.Name = "StartDate"
            pdiscrete.Value = DateTimePicker1.Value.Date
            pfield.CurrentValues.Add(pdiscrete)
            pfields.Add(pfield)

            pfield1.Name = "EndDate"
            pdiscrete1.Value = DateTimePicker2.Value.Date
            pfield1.CurrentValues.Add(pdiscrete1)
            pfields.Add(pfield1)
            BookingTableAdapter1.Fill(DataSet11.Booking)

            pfield2.Name = "Code"
            pdiscrete2.Value = ""
            pfield2.CurrentValues.Add(pdiscrete2)
            pfields.Add(pfield2)

            pfield3.Name = "Code1"
            pdiscrete3.Value = "10"
            pfield3.CurrentValues.Add(pdiscrete3)
            pfields.Add(pfield3)

            Report1.SetDataSource(DataSet11)
            CrystalReportViewer1.ReportSource = Report1

            CrystalReportViewer1.ParameterFieldInfo = pfields

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class