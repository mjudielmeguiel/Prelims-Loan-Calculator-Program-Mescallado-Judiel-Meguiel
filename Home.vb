Public Class Home
    Private Sub tsShop_Click(sender As Object, e As EventArgs) Handles tsShop.Click
        Panel2.Controls.Clear()
        Dim S As New Shop
        S.TopLevel = False
        S.FormBorderStyle = FormBorderStyle.None
        S.Dock = DockStyle.Fill
        Panel2.Controls.Add(S)
        S.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Panel2.Controls.Clear()
        Dim AUS As New About_us
        AUS.TopLevel = False
        AUS.FormBorderStyle = FormBorderStyle.None
        AUS.Dock = DockStyle.Fill
        Panel2.Controls.Add(AUS)
        AUS.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)
        Panel2.Controls.Clear()
        Dim LR As New Loan_Result
        LR.TopLevel = False
        LR.FormBorderStyle = FormBorderStyle.None
        LR.Dock = DockStyle.Fill
        Panel2.Controls.Add(LR)
        LR.Show()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Dim H As New Help
        H.Show()
    End Sub

    Private Sub tspersonalloan_Click(sender As Object, e As EventArgs) Handles tspersonalloan.Click
        Dim LA As New Loan_Application_form
        LA.Show()
        LA.txtLoanType.Text = "Personal Loan"
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        MsgBox("Comming Soon.")
    End Sub
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to Logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub SwitchAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SwitchAccountToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to exit?", "Confirm Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Restart()
        End If
    End Sub
    Private Sub Datetime_Tick_1(sender As Object, e As EventArgs) Handles Datetime.Tick
        ststimer.Text = "Date and Time : " & Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub tssettings_Click(sender As Object, e As EventArgs) Handles tssettings.Click
        MsgBox("Comming Soon.")
    End Sub
End Class