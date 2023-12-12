Public Class PowerBi

    Private Sub PowerBi_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.PowerBiToolStripMenuItem.Enabled = True
    End Sub
End Class