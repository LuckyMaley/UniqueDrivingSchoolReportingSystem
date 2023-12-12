<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrossTabReport
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
        Me.DataSet1 = New WindowsApplication1CrystalReports.DataSet1()
        Me.BookingTableAdapter = New WindowsApplication1CrystalReports.DataSet1TableAdapters.BookingTableAdapter()
        Me.CustomerTableAdapter = New WindowsApplication1CrystalReports.DataSet1TableAdapters.CustomerTableAdapter()
        Me.PaymentTableAdapter = New WindowsApplication1CrystalReports.DataSet1TableAdapters.PaymentTableAdapter()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.crossTabCrystalReport1 = New WindowsApplication1CrystalReports.CrossTabCrystalReport()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.crossTabCrystalReport1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1184, 961)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'CrossTabReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 961)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "CrossTabReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrossTab"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crossTabCrystalReport1 As WindowsApplication1CrystalReports.CrossTabCrystalReport
    Friend WithEvents DataSet1 As WindowsApplication1CrystalReports.DataSet1
    Friend WithEvents BookingTableAdapter As WindowsApplication1CrystalReports.DataSet1TableAdapters.BookingTableAdapter
    Friend WithEvents CustomerTableAdapter As WindowsApplication1CrystalReports.DataSet1TableAdapters.CustomerTableAdapter
    Friend WithEvents PaymentTableAdapter As WindowsApplication1CrystalReports.DataSet1TableAdapters.PaymentTableAdapter
End Class
