Public Class frmlogin

    Dim attemptCount As Integer = 3
    Dim isLocked As Boolean = False
    Dim secondsLeft As Integer = 60

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If isLocked = True Then
            MsgBox("Please wait until the timer finishes.", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Check Admin credentials
        If txtUsername.Text.Trim() = "admin" And txtPassword.Text.Trim() = "admin123" Then
            MessageBox.Show("Welcome Back! : " & txtUsername.Text, " - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Hide()
            Home.Show()
            Home.stsusername.Text = txtUsername.Text
            attemptCount = 3

            ' Check Student credentials
        ElseIf txtUsername.Text.Trim() = "user" And txtPassword.Text.Trim() = "user123" Then
            MessageBox.Show("Login Successful!" & txtUsername.Text, " - Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Hide()
            Home.Show()
            Home.stsusername.Text = txtUsername.Text
            attemptCount = 3

        Else
            attemptCount -= 1

            If attemptCount > 0 Then
                MsgBox("Incorrect username or password. Remaining attempts: " & attemptCount, MsgBoxStyle.Exclamation)
                txtPassword.Clear()
                txtPassword.Focus()
            Else
                MsgBox("Too many failed attempts. Please wait 1 minute.", MsgBoxStyle.Exclamation)

                ' Lock all fields
                txtUsername.Enabled = False
                txtPassword.Enabled = False
                btnLogin.Enabled = False
                isLocked = True

                ' Set and start timer
                secondsLeft = 60
                lblCountdown.Text = "Wait: " & secondsLeft & " seconds"
                Timer1.Interval = 1000 ' 1000 ms = 1 second
                Timer1.Start()
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        secondsLeft -= 1

        ' Update label every second
        lblCountdown.Text = "Wait: " & secondsLeft & " seconds"

        ' When time is up
        If secondsLeft <= 0 Then
            Timer1.Stop()
            isLocked = False
            attemptCount = 3

            ' Enable everything again
            txtUsername.Enabled = True
            txtPassword.Enabled = True
            btnLogin.Enabled = True
            txtUsername.Clear()
            txtPassword.Clear()
            lblCountdown.Text = ""

            MsgBox("You can try logging in again now.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Stop()
        lblCountdown.Text = ""
    End Sub

End Class