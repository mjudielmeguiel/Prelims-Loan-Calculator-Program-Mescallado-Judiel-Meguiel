<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.tsShop = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tspersonalloan = New System.Windows.Forms.ToolStripButton()
        Me.ststimer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsusername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsmenu = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SwitchAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tssettings = New System.Windows.Forms.ToolStripButton()
        Me.Datetime = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip2.SuspendLayout()
        Me.stsmenu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(105, 36)
        Me.ToolStripButton5.Text = "Help Center"
        '
        'tsShop
        '
        Me.tsShop.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsShop.Image = CType(resources.GetObject("tsShop.Image"), System.Drawing.Image)
        Me.tsShop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsShop.Name = "tsShop"
        Me.tsShop.Size = New System.Drawing.Size(71, 36)
        Me.tsShop.Text = "Shop"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(92, 36)
        Me.ToolStripButton1.Text = "About Us"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tspersonalloan, Me.tsShop, Me.ToolStripButton5, Me.ToolStripButton1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 94)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1920, 39)
        Me.ToolStrip2.TabIndex = 146
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tspersonalloan
        '
        Me.tspersonalloan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tspersonalloan.Image = CType(resources.GetObject("tspersonalloan.Image"), System.Drawing.Image)
        Me.tspersonalloan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspersonalloan.Name = "tspersonalloan"
        Me.tspersonalloan.Size = New System.Drawing.Size(143, 36)
        Me.tspersonalloan.Text = "Loans and Services"
        '
        'ststimer
        '
        Me.ststimer.Name = "ststimer"
        Me.ststimer.Size = New System.Drawing.Size(635, 21)
        Me.ststimer.Spring = True
        Me.ststimer.Text = "---"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(635, 21)
        Me.ToolStripStatusLabel2.Spring = True
        Me.ToolStripStatusLabel2.Text = "ABC Lending Corporation"
        '
        'stsusername
        '
        Me.stsusername.Name = "stsusername"
        Me.stsusername.Size = New System.Drawing.Size(635, 21)
        Me.stsusername.Spring = True
        Me.stsusername.Text = "Name of User"
        '
        'stsmenu
        '
        Me.stsmenu.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stsmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsusername, Me.ToolStripStatusLabel2, Me.ststimer})
        Me.stsmenu.Location = New System.Drawing.Point(0, 1174)
        Me.stsmenu.Name = "stsmenu"
        Me.stsmenu.Size = New System.Drawing.Size(1920, 26)
        Me.stsmenu.TabIndex = 144
        Me.stsmenu.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1920, 66)
        Me.Panel1.TabIndex = 143
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 133)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1920, 1041)
        Me.Panel2.TabIndex = 147
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SwitchAccountToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(47, 25)
        Me.ToolStripButton3.Text = "File"
        '
        'SwitchAccountToolStripMenuItem
        '
        Me.SwitchAccountToolStripMenuItem.Image = CType(resources.GetObject("SwitchAccountToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SwitchAccountToolStripMenuItem.Name = "SwitchAccountToolStripMenuItem"
        Me.SwitchAccountToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.SwitchAccountToolStripMenuItem.Text = "Switch Account"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Image = CType(resources.GetObject("LogOutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.LogOutToolStripMenuItem.Text = "Application Exit"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(92, 25)
        Me.ToolStripButton4.Text = "Monitoring"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.tssettings})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 66)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1920, 28)
        Me.ToolStrip1.TabIndex = 145
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tssettings
        '
        Me.tssettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tssettings.Image = CType(resources.GetObject("tssettings.Image"), System.Drawing.Image)
        Me.tssettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssettings.Name = "tssettings"
        Me.tssettings.Size = New System.Drawing.Size(70, 25)
        Me.tssettings.Text = "Settings"
        '
        'Datetime
        '
        Me.Datetime.Enabled = True
        Me.Datetime.Interval = 1000
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1200)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.stsmenu)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.stsmenu.ResumeLayout(False)
        Me.stsmenu.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents tsShop As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ststimer As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents stsusername As ToolStripStatusLabel
    Friend WithEvents stsmenu As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tspersonalloan As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripDropDownButton
    Friend WithEvents SwitchAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tssettings As ToolStripButton
    Friend WithEvents Datetime As Timer
End Class
