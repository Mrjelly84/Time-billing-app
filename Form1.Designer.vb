<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cboClient = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.lblFinish = New System.Windows.Forms.Label()
        Me.lblBilling = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(22, 200)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(166, 200)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(293, 200)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cboClient
        '
        Me.cboClient.FormattingEnabled = True
        Me.cboClient.Location = New System.Drawing.Point(191, 40)
        Me.cboClient.Name = "cboClient"
        Me.cboClient.Size = New System.Drawing.Size(271, 21)
        Me.cboClient.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Client Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Billing in progress."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(293, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Start time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(293, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Stop time:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(227, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Billable hours , minutes:"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStart.Location = New System.Drawing.Point(365, 105)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(108, 15)
        Me.lblStart.TabIndex = 9
        Me.lblStart.Text = "                                 "
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Enabled = False
        Me.HScrollBar1.LargeChange = 100
        Me.HScrollBar1.Location = New System.Drawing.Point(9, 75)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(479, 17)
        Me.HScrollBar1.TabIndex = 12
        '
        'lblFinish
        '
        Me.lblFinish.AutoSize = True
        Me.lblFinish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFinish.Location = New System.Drawing.Point(365, 134)
        Me.lblFinish.Name = "lblFinish"
        Me.lblFinish.Size = New System.Drawing.Size(108, 15)
        Me.lblFinish.TabIndex = 13
        Me.lblFinish.Text = "                                 "
        '
        'lblBilling
        '
        Me.lblBilling.AutoSize = True
        Me.lblBilling.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBilling.Location = New System.Drawing.Point(365, 164)
        Me.lblBilling.Name = "lblBilling"
        Me.lblBilling.Size = New System.Drawing.Size(108, 15)
        Me.lblBilling.TabIndex = 14
        Me.lblBilling.Text = "                                 "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 253)
        Me.Controls.Add(Me.lblBilling)
        Me.Controls.Add(Me.lblFinish)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboClient)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Consulting Time Clock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents cboClient As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents lblFinish As Label
    Friend WithEvents lblBilling As Label
End Class
