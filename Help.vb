Public Class Help

    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Help & User Guide"

        rchHelp.Text = "HOW TO USE THE LOAN SYSTEM" & vbCrLf & vbCrLf &
                       "1. LOGIN" & vbCrLf &
                       "• Enter your Username and Password." & vbCrLf &
                       "• Click Login to open the Main Menu." & vbCrLf &
                       "• You have 3 attempts before the system locks for 1 minute." & vbCrLf & vbCrLf &
                       "2. APPLY FOR A LOAN" & vbCrLf &
                       "• From Main Menu, click 'Apply for Loan'." & vbCrLf &
                       "• Fill in all required information:" & vbCrLf &
                       "   - Full Name, Address, Contact Number" & vbCrLf &
                       "   - Occupation, Company Name" & vbCrLf &
                       "   - Monthly Salary and Loan Amount" & vbCrLf &
                       "• Select Loan Type and Loan Term from the dropdown lists." & vbCrLf &
                       "• Click 'Compute' to see your result." & vbCrLf & vbCrLf &
                       "3. QUICK APPLY OPTION" & vbCrLf &
                       "• On the Product page, click 'Apply Now' for any item." & vbCrLf &
                       "• The form will open automatically with Loan Type and Amount already filled." & vbCrLf &
                       "• Just fill the rest and compute." & vbCrLf & vbCrLf &
                       "4. LOAN RULES" & vbCrLf &
                       "• Minimum Monthly Salary: ₱20,000" & vbCrLf &
                       "• Maximum Monthly Payment: 35% of your salary" & vbCrLf &
                       "• Interest Rates:" & vbCrLf &
                       "   - Personal Loan = 10% per year" & vbCrLf &
                       "   - Appliance Loan = 8% per year" & vbCrLf &
                       "   - Gadget Loan = 12% per year" & vbCrLf & vbCrLf &
                       "5. OTHER OPTIONS" & vbCrLf &
                       "• Clear Button: Erases all entries to start over." & vbCrLf &
                       "• Back Button: Returns to the previous screen." & vbCrLf &
                       "• About Us / Developer Info: Shows details about the system."
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class