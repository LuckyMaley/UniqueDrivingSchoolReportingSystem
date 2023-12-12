Public Class LoginForm

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Or TextBox2.Text <> "" Then
            ManagerTableAdapter1.FillByMan(DataSet11.Manager, TextBox1.Text, TextBox2.Text)
            If DataSet11.Manager.Rows.Count > 0 Then
                MessageBox.Show("Welcome you will be redirected to the main page")
                With MainForm
                    .ViewToolStripMenuItem.Enabled = True
                    .LoginToolStripMenuItem.Enabled = False
                    .DashboardToolStripMenuItem.Enabled = True
                    .Indicate.Text = "[Logged in - " & DataSet11.Manager.Rows(0).Item(1) & " " & DataSet11.Manager.Rows(0).Item(2) & "]"
                End With
                Me.Close()
            Else
                MessageBox.Show("Username or Password is incorrect, please try again")
                TextBox1.Clear()
                TextBox1.Focus()
                TextBox2.Clear()
            End If
        Else
            MessageBox.Show("Username or Password is incorrect, please try again")
        End If
    End Sub

    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataSet11.EnforceConstraints = False
        ManagerTableAdapter1.Fill(DataSet11.Manager)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'Hides and Hides the password in characters
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit", "Confirmation", MessageBoxButtons.YesNo)
        If Result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class