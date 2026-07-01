<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productupdate
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
        Dim Label1 As System.Windows.Forms.Label
        Dim USERNAMELabel As System.Windows.Forms.Label
        Me.txtupdateprice = New System.Windows.Forms.TextBox()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.txtupdateproductname = New System.Windows.Forms.TextBox()
        Me.picUpdate = New System.Windows.Forms.PictureBox()
        Label1 = New System.Windows.Forms.Label()
        USERNAMELabel = New System.Windows.Forms.Label()
        CType(Me.picUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(118, 85)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(37, 13)
        Label1.TabIndex = 362
        Label1.Text = "Price :"
        '
        'USERNAMELabel
        '
        USERNAMELabel.AutoSize = True
        USERNAMELabel.Location = New System.Drawing.Point(118, 36)
        USERNAMELabel.Name = "USERNAMELabel"
        USERNAMELabel.Size = New System.Drawing.Size(78, 13)
        USERNAMELabel.TabIndex = 358
        USERNAMELabel.Text = "Product Name:"
        '
        'txtupdateprice
        '
        Me.txtupdateprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtupdateprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupdateprice.Location = New System.Drawing.Point(121, 101)
        Me.txtupdateprice.Name = "txtupdateprice"
        Me.txtupdateprice.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtupdateprice.Size = New System.Drawing.Size(385, 30)
        Me.txtupdateprice.TabIndex = 361
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.Maroon
        Me.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnupdate.Location = New System.Drawing.Point(78, 162)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(428, 37)
        Me.btnupdate.TabIndex = 360
        Me.btnupdate.Text = "Update"
        Me.btnupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'txtupdateproductname
        '
        Me.txtupdateproductname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtupdateproductname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupdateproductname.Location = New System.Drawing.Point(121, 52)
        Me.txtupdateproductname.Name = "txtupdateproductname"
        Me.txtupdateproductname.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtupdateproductname.Size = New System.Drawing.Size(385, 30)
        Me.txtupdateproductname.TabIndex = 357
        '
        'picUpdate
        '
        Me.picUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picUpdate.Location = New System.Drawing.Point(12, 38)
        Me.picUpdate.Name = "picUpdate"
        Me.picUpdate.Size = New System.Drawing.Size(103, 93)
        Me.picUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUpdate.TabIndex = 364
        Me.picUpdate.TabStop = False
        '
        'Productupdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 571)
        Me.Controls.Add(Me.picUpdate)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtupdateprice)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(USERNAMELabel)
        Me.Controls.Add(Me.txtupdateproductname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Productupdate"
        Me.Text = "Productupdate"
        CType(Me.picUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtupdateprice As TextBox
    Friend WithEvents btnupdate As Button
    Friend WithEvents txtupdateproductname As TextBox
    Friend WithEvents picUpdate As PictureBox
End Class
