<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NAVIGATION
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NAVIGATION))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.POLICY = New System.Windows.Forms.Label
        Me.POLICY1 = New System.Windows.Forms.Button
        Me.CLIENT = New System.Windows.Forms.Button
        Me.AGENT = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(230, 423)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(456, 36)
        Me.ProgressBar1.TabIndex = 15
        Me.ProgressBar1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.POLICY)
        Me.GroupBox1.Controls.Add(Me.POLICY1)
        Me.GroupBox1.Controls.Add(Me.CLIENT)
        Me.GroupBox1.Controls.Add(Me.AGENT)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(884, 293)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECT USER"
        '
        'POLICY
        '
        Me.POLICY.BackColor = System.Drawing.Color.DodgerBlue
        Me.POLICY.Location = New System.Drawing.Point(122, 188)
        Me.POLICY.Name = "POLICY"
        Me.POLICY.Size = New System.Drawing.Size(103, 23)
        Me.POLICY.TabIndex = 4
        Me.POLICY.Text = "POLICY"
        Me.POLICY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'POLICY1
        '
        Me.POLICY1.Image = CType(resources.GetObject("POLICY1.Image"), System.Drawing.Image)
        Me.POLICY1.Location = New System.Drawing.Point(77, 57)
        Me.POLICY1.Name = "POLICY1"
        Me.POLICY1.Size = New System.Drawing.Size(196, 206)
        Me.POLICY1.TabIndex = 3
        Me.POLICY1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.POLICY1.UseVisualStyleBackColor = True
        '
        'CLIENT
        '
        Me.CLIENT.Image = CType(resources.GetObject("CLIENT.Image"), System.Drawing.Image)
        Me.CLIENT.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CLIENT.Location = New System.Drawing.Point(603, 57)
        Me.CLIENT.Name = "CLIENT"
        Me.CLIENT.Size = New System.Drawing.Size(176, 206)
        Me.CLIENT.TabIndex = 2
        Me.CLIENT.Text = "CLIENT LOGIN"
        Me.CLIENT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CLIENT.UseVisualStyleBackColor = True
        '
        'AGENT
        '
        Me.AGENT.Image = CType(resources.GetObject("AGENT.Image"), System.Drawing.Image)
        Me.AGENT.Location = New System.Drawing.Point(346, 57)
        Me.AGENT.Name = "AGENT"
        Me.AGENT.Size = New System.Drawing.Size(183, 206)
        Me.AGENT.TabIndex = 1
        Me.AGENT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(155, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(600, 65)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "INSURANCE MANAGEMENT SYSTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'NAVIGATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IMS.My.Resources.Resources.th__4_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(937, 578)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NAVIGATION"
        Me.Text = "NAVIGATION"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents POLICY As System.Windows.Forms.Label
    Friend WithEvents POLICY1 As System.Windows.Forms.Button
    Friend WithEvents CLIENT As System.Windows.Forms.Button
    Friend WithEvents AGENT As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
