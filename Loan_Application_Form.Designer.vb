<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loan_Application_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim USERNAMELabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loan_Application_form))
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtOccupation = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.txtMonthlySalary = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.txtLoanAmount = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.rdo12 = New System.Windows.Forms.RadioButton()
        Me.rdo24 = New System.Windows.Forms.RadioButton()
        Me.rdo36 = New System.Windows.Forms.RadioButton()
        Me.txtLoanType = New System.Windows.Forms.TextBox()
        Me.txtProductType = New System.Windows.Forms.TextBox()
        USERNAMELabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'USERNAMELabel
        '
        USERNAMELabel.AutoSize = True
        USERNAMELabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        USERNAMELabel.Location = New System.Drawing.Point(9, 94)
        USERNAMELabel.Name = "USERNAMELabel"
        USERNAMELabel.Size = New System.Drawing.Size(181, 19)
        USERNAMELabel.TabIndex = 139
        USERNAMELabel.Text = "Please Enter your Full name."
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(432, 355)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(72, 19)
        Label1.TabIndex = 141
        Label1.Text = "Loan Type" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(7, 224)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(253, 19)
        Label2.TabIndex = 143
        Label2.Text = "Please Enter your Valid Mobile Number."
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(7, 159)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(196, 19)
        Label3.TabIndex = 145
        Label3.Text = "Please Enter your Full Address."
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(10, 290)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(194, 19)
        Label4.TabIndex = 147
        Label4.Text = "Please Enter your Occupation."
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(310, 290)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(219, 19)
        Label5.TabIndex = 149
        Label5.Text = "Please Enter your Company name."
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(10, 355)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(105, 19)
        Label6.TabIndex = 151
        Label6.Text = "Monthly Salary."
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(8, 501)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(254, 19)
        Label7.TabIndex = 155
        Label7.Text = "Please Choose your Prefered Loan Term"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(250, 355)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(112, 19)
        Label8.TabIndex = 157
        Label8.Text = "Product Amount"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(163, 18)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(366, 22)
        Label9.TabIndex = 224
        Label9.Text = "ABC Lending Corporation Application Form"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(8, 421)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(91, 19)
        Label10.TabIndex = 229
        Label10.Text = "Product Type" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(12, 61)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCustomerName.Size = New System.Drawing.Size(686, 30)
        Me.txtCustomerName.TabIndex = 137
        Me.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContact
        '
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(10, 191)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtContact.Size = New System.Drawing.Size(688, 30)
        Me.txtContact.TabIndex = 142
        Me.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(10, 126)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtAddress.Size = New System.Drawing.Size(688, 30)
        Me.txtAddress.TabIndex = 144
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOccupation
        '
        Me.txtOccupation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccupation.Location = New System.Drawing.Point(10, 257)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtOccupation.Size = New System.Drawing.Size(298, 30)
        Me.txtOccupation.TabIndex = 146
        Me.txtOccupation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCompany
        '
        Me.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.Location = New System.Drawing.Point(314, 257)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtCompany.Size = New System.Drawing.Size(384, 30)
        Me.txtCompany.TabIndex = 148
        Me.txtCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMonthlySalary
        '
        Me.txtMonthlySalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonthlySalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlySalary.Location = New System.Drawing.Point(10, 322)
        Me.txtMonthlySalary.Name = "txtMonthlySalary"
        Me.txtMonthlySalary.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtMonthlySalary.Size = New System.Drawing.Size(237, 30)
        Me.txtMonthlySalary.TabIndex = 150
        Me.txtMonthlySalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(8, 546)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(637, 42)
        Me.CheckBox1.TabIndex = 152
        Me.CheckBox1.Text = "I agree with ABC Lending Corporation Privacy Notice which governs the processing " &
    "of my personal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "information to check my eligibility for ABC products."
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(8, 604)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(566, 23)
        Me.CheckBox2.TabIndex = 153
        Me.CheckBox2.Text = "I would like to receive latest promos, deals, news & updates from ABC via SMS and" &
    " Viber."
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoanAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanAmount.Location = New System.Drawing.Point(253, 322)
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtLoanAmount.Size = New System.Drawing.Size(177, 30)
        Me.txtLoanAmount.TabIndex = 156
        Me.txtLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.Maroon
        Me.btnCompute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCompute.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCompute.Location = New System.Drawing.Point(10, 676)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(687, 37)
        Me.btnCompute.TabIndex = 158
        Me.btnCompute.Text = " Compute"
        Me.btnCompute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Transparent
        Me.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.Transparent
        Me.btnclear.Image = CType(resources.GetObject("btnclear.Image"), System.Drawing.Image)
        Me.btnclear.Location = New System.Drawing.Point(664, 389)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(33, 30)
        Me.btnclear.TabIndex = 212
        Me.btnclear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Maroon
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(10, 719)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(687, 37)
        Me.btnBack.TabIndex = 223
        Me.btnBack.Text = "Cancel"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'rdo12
        '
        Me.rdo12.AutoSize = True
        Me.rdo12.Location = New System.Drawing.Point(14, 469)
        Me.rdo12.Name = "rdo12"
        Me.rdo12.Size = New System.Drawing.Size(129, 29)
        Me.rdo12.TabIndex = 225
        Me.rdo12.TabStop = True
        Me.rdo12.Text = "12 Months"
        Me.rdo12.UseVisualStyleBackColor = True
        '
        'rdo24
        '
        Me.rdo24.AutoSize = True
        Me.rdo24.Location = New System.Drawing.Point(184, 469)
        Me.rdo24.Name = "rdo24"
        Me.rdo24.Size = New System.Drawing.Size(129, 29)
        Me.rdo24.TabIndex = 226
        Me.rdo24.TabStop = True
        Me.rdo24.Text = "24 Months"
        Me.rdo24.UseVisualStyleBackColor = True
        '
        'rdo36
        '
        Me.rdo36.AutoSize = True
        Me.rdo36.Location = New System.Drawing.Point(357, 469)
        Me.rdo36.Name = "rdo36"
        Me.rdo36.Size = New System.Drawing.Size(129, 29)
        Me.rdo36.TabIndex = 227
        Me.rdo36.TabStop = True
        Me.rdo36.Text = "36 Months"
        Me.rdo36.UseVisualStyleBackColor = True
        '
        'txtLoanType
        '
        Me.txtLoanType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoanType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanType.Location = New System.Drawing.Point(436, 322)
        Me.txtLoanType.Name = "txtLoanType"
        Me.txtLoanType.ReadOnly = True
        Me.txtLoanType.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtLoanType.Size = New System.Drawing.Size(262, 30)
        Me.txtLoanType.TabIndex = 228
        Me.txtLoanType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProductType
        '
        Me.txtProductType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductType.Location = New System.Drawing.Point(10, 389)
        Me.txtProductType.Name = "txtProductType"
        Me.txtProductType.ReadOnly = True
        Me.txtProductType.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtProductType.Size = New System.Drawing.Size(648, 30)
        Me.txtProductType.TabIndex = 230
        Me.txtProductType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Loan_Application_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 768)
        Me.Controls.Add(Me.txtProductType)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Me.txtLoanType)
        Me.Controls.Add(Me.rdo36)
        Me.Controls.Add(Me.rdo24)
        Me.Controls.Add(Me.rdo12)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Me.txtLoanAmount)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.txtMonthlySalary)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.txtOccupation)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Label1)
        Me.Controls.Add(USERNAMELabel)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Loan_Application_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan_Application_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtOccupation As TextBox
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents txtMonthlySalary As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents txtLoanAmount As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents rdo12 As RadioButton
    Friend WithEvents rdo24 As RadioButton
    Friend WithEvents rdo36 As RadioButton
    Friend WithEvents txtLoanType As TextBox
    Friend WithEvents txtProductType As TextBox
End Class
