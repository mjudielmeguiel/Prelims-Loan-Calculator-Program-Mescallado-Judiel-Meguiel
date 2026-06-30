Public Class Loan_Application_form

    Private Sub Loan_Application_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rdo12.Text = "12 Months"
        rdo24.Text = "24 Months"
        rdo36.Text = "36 Months"

        rdo12.Checked = False
        rdo24.Checked = False
        rdo36.Checked = False
        btnCompute.Enabled = False
    End Sub

#Region "Validation"
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        If MessageBox.Show("Are you sure you want to Compute?", "ABC Lending Corporation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If txtCustomerName.Text.Trim = "" Then
                MessageBox.Show("Please enter your Full name.", "Missing Information")
                Return
            End If

            If txtAddress.Text.Trim = "" Then
                MessageBox.Show("Please enter your Full Address.", "Missing Information")
                Return
            End If

            If txtContact.Text.Trim = "" Then
                MessageBox.Show("Please enter your Valid Mobile Number.", "Missing Information")
                Return
            End If

            If txtOccupation.Text.Trim = "" Then
                MessageBox.Show("Please enter your Occupation.", "Missing Information")
                Return
            End If

            If txtCompany.Text.Trim = "" Then
                MessageBox.Show("Please enter your Company name.", "Missing Information")
                Return
            End If

            If txtMonthlySalary.Text.Trim = "" Then
                MessageBox.Show("Please enter your Monthly Salary.", "Missing Information")
                Return
            End If

            If txtLoanAmount.Text.Trim = "" Then
                MessageBox.Show("Please enter your Loan Amount.", "Missing Information")
                Return
            End If

            If txtLoanType.Text.Trim = "" Then
                MessageBox.Show("Please enter or set Loan Type.", "Missing Information")
                Return
            End If

            If Not rdo12.Checked AndAlso Not rdo24.Checked AndAlso Not rdo36.Checked Then
                MessageBox.Show("Please Choose your Preferred Loan Term.", "Missing Information")
                Return
            End If

            Dim monthlySalary As Decimal
            Dim loanAmount As Decimal

            If Not Decimal.TryParse(txtMonthlySalary.Text, monthlySalary) Then
                MessageBox.Show("Monthly Salary must be a valid number!", "Invalid Input")
                Return
            End If
            If monthlySalary <= 0 Then
                MessageBox.Show("Monthly Salary must be greater than zero!", "Invalid Input")
                Return
            End If

            If Not Decimal.TryParse(txtLoanAmount.Text, loanAmount) Then
                MessageBox.Show("Loan Amount must be a valid number!", "Invalid Input")
                Return
            End If
            If loanAmount <= 0 Then
                MessageBox.Show("Loan Amount must be greater than zero!", "Invalid Input")
                Return
            End If

            Dim termMonths As Integer = 0
            If rdo12.Checked Then termMonths = 12 ' 12 Months
            If rdo24.Checked Then termMonths = 24 ' 24 Months
            If rdo36.Checked Then termMonths = 36 ' 36, Months

            Dim interestRate As Decimal = 0
            Select Case txtLoanType.Text.Trim
                Case "Personal Loan" : interestRate = 0.1 ' 10%
                Case "Appliance Loan" : interestRate = 0.08 ' 8%
                Case "Gadget Loan" : interestRate = 0.12 ' 12%
                Case Else
                    MessageBox.Show("Invalid Loan Type entered!", "Invalid Input")
                    Return
            End Select

            Dim interest = loanAmount * interestRate
            Dim totalPayable = loanAmount + interest
            Dim monthlyAmort = totalPayable / termMonths
            Dim maxAllowed = monthlySalary * 0.35

            Dim status As String, remarks As String
            Dim ResultForm As New Loan_Result

            If monthlySalary >= 20000 AndAlso monthlyAmort <= maxAllowed Then
                status = "APPROVED"
                remarks = "Congratulations! Your loan has been approved."
                ResultForm.Picapprove.Visible = True
                ResultForm.picnotapprove.Visible = False

                ResultForm.lblInterest.Visible = True
                ResultForm.lblinterest2.Visible = True
                ResultForm.lblMonthlyAmort.Visible = True
                ResultForm.lblMonthlyAmort2.Visible = True
                ResultForm.lblTotalPayable.Visible = True
                ResultForm.lblTotalPayable2.Visible = True
            Else
                status = "DISAPPROVED"
                ResultForm.Picapprove.Visible = False
                ResultForm.picnotapprove.Visible = True

                ResultForm.lblInterest.Visible = False
                ResultForm.lblinterest2.Visible = False
                ResultForm.lblMonthlyAmort.Visible = False
                ResultForm.lblMonthlyAmort2.Visible = False
                ResultForm.lblTotalPayable.Visible = False
                ResultForm.lblTotalPayable2.Visible = False
                If monthlySalary < 20000 Then
                    remarks = "Sorry. Minimum monthly salary required is ₱20,000."
                Else
                    remarks = "Sorry. Monthly amortization exceeds 35% of your salary."
                End If
            End If

            ResultForm.lblName.Text = txtCustomerName.Text
            ResultForm.lblLoanType.Text = txtLoanType.Text
            ResultForm.lblLoanAmount.Text = "₱ " & loanAmount.ToString("N2")
            ResultForm.lblInterest.Text = "₱ " & interest.ToString("N2")
            ResultForm.lblTotalPayable.Text = "₱ " & totalPayable.ToString("N2")
            ResultForm.lblMonthlyAmort.Text = "₱ " & monthlyAmort.ToString("N2")
            ResultForm.lblStatus.Text = status
            ResultForm.lblRemarks.Text = remarks

            Me.Hide()
            Home.Panel2.Controls.Clear()
            ResultForm.TopLevel = False
            ResultForm.FormBorderStyle = FormBorderStyle.None
            ResultForm.Dock = DockStyle.Fill
            Home.Panel2.Controls.Add(ResultForm)
            ResultForm.Show()

        End If
    End Sub
#End Region

#Region "Buttons"
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnclear.Click

        If MessageBox.Show("Are you sure you want to Clear All Customer Information?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            txtCustomerName.Clear()
            txtAddress.Clear()
            txtContact.Clear()
            txtOccupation.Clear()
            txtCompany.Clear()
            txtMonthlySalary.Clear()
            rdo12.Checked = False
            rdo24.Checked = False
            rdo36.Checked = False
            btnCompute.Enabled = False
            txtCustomerName.Focus()
            MessageBox.Show("Information Remove!", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MessageBox.Show("Are you sure you want to cancel this Transaction?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            txtCustomerName.Clear()
            txtAddress.Clear()
            txtContact.Clear()
            txtOccupation.Clear()
            txtCompany.Clear()
            txtMonthlySalary.Clear()
            txtProductType.Clear()
            txtLoanAmount.Clear()
            txtLoanType.Clear()
            rdo12.Checked = False
            rdo24.Checked = False
            rdo36.Checked = False
            btnCompute.Enabled = False
            txtCustomerName.Focus()

            MessageBox.Show("Cancelled!", "Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        End If
    End Sub

#End Region

#Region "Checking Fields"
    Private Sub CheckFields()
        Dim termChosen = rdo12.Checked OrElse rdo24.Checked OrElse rdo36.Checked

        btnCompute.Enabled =
            txtCustomerName.Text.Trim <> "" AndAlso
            txtAddress.Text.Trim <> "" AndAlso
            txtContact.Text.Trim <> "" AndAlso
            txtOccupation.Text.Trim <> "" AndAlso
            txtCompany.Text.Trim <> "" AndAlso
            txtMonthlySalary.Text.Trim <> "" AndAlso
            txtLoanAmount.Text.Trim <> "" AndAlso
            txtLoanType.Text.Trim <> "" AndAlso
            termChosen
    End Sub

    Private Sub txtCustomerName_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerName.TextChanged
        CheckFields()
    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged
        CheckFields()
    End Sub

    Private Sub txtContact_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged
        CheckFields()
    End Sub

    Private Sub txtOccupation_TextChanged(sender As Object, e As EventArgs) Handles txtOccupation.TextChanged
        CheckFields()
    End Sub

    Private Sub txtCompany_TextChanged(sender As Object, e As EventArgs) Handles txtCompany.TextChanged
        CheckFields()
    End Sub

    Private Sub txtMonthlySalary_TextChanged(sender As Object, e As EventArgs) Handles txtMonthlySalary.TextChanged
        CheckFields()
    End Sub

    Private Sub txtLoanAmount_TextChanged(sender As Object, e As EventArgs) Handles txtLoanAmount.TextChanged
        CheckFields()
    End Sub

    Private Sub txtLoanType_TextChanged(sender As Object, e As EventArgs) Handles txtLoanType.TextChanged
        CheckFields()
    End Sub

    Private Sub rdo12_CheckedChanged(sender As Object, e As EventArgs) Handles rdo12.CheckedChanged
        CheckFields()
    End Sub

    Private Sub rdo24_CheckedChanged(sender As Object, e As EventArgs) Handles rdo24.CheckedChanged
        CheckFields()
    End Sub

    Private Sub rdo36_CheckedChanged(sender As Object, e As EventArgs) Handles rdo36.CheckedChanged
        CheckFields()
    End Sub
#End Region
End Class