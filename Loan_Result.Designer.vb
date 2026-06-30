<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loan_Result
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loan_Result))
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblLoanType = New System.Windows.Forms.Label()
        Me.lblLoanAmount = New System.Windows.Forms.Label()
        Me.lblMonthlyAmort = New System.Windows.Forms.Label()
        Me.lblTotalPayable = New System.Windows.Forms.Label()
        Me.lblInterest = New System.Windows.Forms.Label()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Picapprove = New System.Windows.Forms.PictureBox()
        Me.picnotapprove = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblinterest2 = New System.Windows.Forms.Label()
        Me.lblTotalPayable2 = New System.Windows.Forms.Label()
        Me.lblMonthlyAmort2 = New System.Windows.Forms.Label()
        CType(Me.Picapprove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picnotapprove, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(927, 370)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(28, 26)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "--"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoanType
        '
        Me.lblLoanType.AutoSize = True
        Me.lblLoanType.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanType.Location = New System.Drawing.Point(693, 520)
        Me.lblLoanType.Name = "lblLoanType"
        Me.lblLoanType.Size = New System.Drawing.Size(24, 22)
        Me.lblLoanType.TabIndex = 1
        Me.lblLoanType.Text = "--"
        '
        'lblLoanAmount
        '
        Me.lblLoanAmount.AutoSize = True
        Me.lblLoanAmount.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanAmount.Location = New System.Drawing.Point(1382, 517)
        Me.lblLoanAmount.Name = "lblLoanAmount"
        Me.lblLoanAmount.Size = New System.Drawing.Size(28, 26)
        Me.lblLoanAmount.TabIndex = 2
        Me.lblLoanAmount.Text = "--"
        '
        'lblMonthlyAmort
        '
        Me.lblMonthlyAmort.AutoSize = True
        Me.lblMonthlyAmort.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyAmort.Location = New System.Drawing.Point(329, 894)
        Me.lblMonthlyAmort.Name = "lblMonthlyAmort"
        Me.lblMonthlyAmort.Size = New System.Drawing.Size(24, 21)
        Me.lblMonthlyAmort.TabIndex = 5
        Me.lblMonthlyAmort.Text = "--"
        '
        'lblTotalPayable
        '
        Me.lblTotalPayable.AutoSize = True
        Me.lblTotalPayable.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayable.Location = New System.Drawing.Point(310, 835)
        Me.lblTotalPayable.Name = "lblTotalPayable"
        Me.lblTotalPayable.Size = New System.Drawing.Size(24, 21)
        Me.lblTotalPayable.TabIndex = 4
        Me.lblTotalPayable.Text = "--"
        '
        'lblInterest
        '
        Me.lblInterest.AutoSize = True
        Me.lblInterest.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterest.Location = New System.Drawing.Point(249, 780)
        Me.lblInterest.Name = "lblInterest"
        Me.lblInterest.Size = New System.Drawing.Size(24, 21)
        Me.lblInterest.TabIndex = 3
        Me.lblInterest.Text = "--"
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.Location = New System.Drawing.Point(722, 637)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(90, 25)
        Me.lblRemarks.TabIndex = 7
        Me.lblRemarks.Text = "Remarks"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblStatus.Location = New System.Drawing.Point(867, 252)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(90, 31)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Status"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Picapprove
        '
        Me.Picapprove.Image = CType(resources.GetObject("Picapprove.Image"), System.Drawing.Image)
        Me.Picapprove.Location = New System.Drawing.Point(873, 85)
        Me.Picapprove.Name = "Picapprove"
        Me.Picapprove.Size = New System.Drawing.Size(157, 142)
        Me.Picapprove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picapprove.TabIndex = 130
        Me.Picapprove.TabStop = False
        '
        'picnotapprove
        '
        Me.picnotapprove.Image = CType(resources.GetObject("picnotapprove.Image"), System.Drawing.Image)
        Me.picnotapprove.Location = New System.Drawing.Point(873, 85)
        Me.picnotapprove.Name = "picnotapprove"
        Me.picnotapprove.Size = New System.Drawing.Size(157, 142)
        Me.picnotapprove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picnotapprove.TabIndex = 131
        Me.picnotapprove.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(722, 370)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 26)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Good Day! Mr/Mrs."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(507, 517)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 26)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "your Loan Type is"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1249, 518)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 26)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Amouunt of"
        '
        'lblinterest2
        '
        Me.lblinterest2.AutoSize = True
        Me.lblinterest2.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinterest2.Location = New System.Drawing.Point(147, 777)
        Me.lblinterest2.Name = "lblinterest2"
        Me.lblinterest2.Size = New System.Drawing.Size(96, 26)
        Me.lblinterest2.TabIndex = 163
        Me.lblinterest2.Text = "Interest :"
        '
        'lblTotalPayable2
        '
        Me.lblTotalPayable2.AutoSize = True
        Me.lblTotalPayable2.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayable2.Location = New System.Drawing.Point(151, 832)
        Me.lblTotalPayable2.Name = "lblTotalPayable2"
        Me.lblTotalPayable2.Size = New System.Drawing.Size(153, 26)
        Me.lblTotalPayable2.TabIndex = 164
        Me.lblTotalPayable2.Text = "Total Payable :"
        '
        'lblMonthlyAmort2
        '
        Me.lblMonthlyAmort2.AutoSize = True
        Me.lblMonthlyAmort2.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyAmort2.Location = New System.Drawing.Point(152, 889)
        Me.lblMonthlyAmort2.Name = "lblMonthlyAmort2"
        Me.lblMonthlyAmort2.Size = New System.Drawing.Size(171, 26)
        Me.lblMonthlyAmort2.TabIndex = 165
        Me.lblMonthlyAmort2.Text = "Monthly Amort :"
        '
        'Loan_Result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1045)
        Me.Controls.Add(Me.lblMonthlyAmort2)
        Me.Controls.Add(Me.lblTotalPayable2)
        Me.Controls.Add(Me.lblinterest2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Picapprove)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblMonthlyAmort)
        Me.Controls.Add(Me.lblTotalPayable)
        Me.Controls.Add(Me.lblInterest)
        Me.Controls.Add(Me.lblLoanAmount)
        Me.Controls.Add(Me.lblLoanType)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.picnotapprove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Loan_Result"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan_Result"
        CType(Me.Picapprove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picnotapprove, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblLoanType As Label
    Friend WithEvents lblLoanAmount As Label
    Friend WithEvents lblMonthlyAmort As Label
    Friend WithEvents lblTotalPayable As Label
    Friend WithEvents lblInterest As Label
    Friend WithEvents lblRemarks As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Picapprove As PictureBox
    Friend WithEvents picnotapprove As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblinterest2 As Label
    Friend WithEvents lblTotalPayable2 As Label
    Friend WithEvents lblMonthlyAmort2 As Label
End Class
