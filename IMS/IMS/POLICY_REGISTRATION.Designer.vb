<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POLICY_REGISTRATION
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CANCEL = New System.Windows.Forms.Button
        Me.DELETE = New System.Windows.Forms.Button
        Me.VIEW = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.P_TYPE = New System.Windows.Forms.ComboBox
        Me.CLEAR = New System.Windows.Forms.Button
        Me.UPDATEE = New System.Windows.Forms.Button
        Me.P_DESC = New System.Windows.Forms.TextBox
        Me.P_NY = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SUBMIT = New System.Windows.Forms.Button
        Me.P_AMOUNT = New System.Windows.Forms.TextBox
        Me.P_NAME = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CANCEL)
        Me.GroupBox2.Controls.Add(Me.DELETE)
        Me.GroupBox2.Controls.Add(Me.VIEW)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(726, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(641, 621)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        '
        'CANCEL
        '
        Me.CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CANCEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCEL.Location = New System.Drawing.Point(483, 536)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(134, 41)
        Me.CANCEL.TabIndex = 16
        Me.CANCEL.Text = "CANCEL"
        Me.CANCEL.UseVisualStyleBackColor = True
        '
        'DELETE
        '
        Me.DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETE.Location = New System.Drawing.Point(274, 536)
        Me.DELETE.Name = "DELETE"
        Me.DELETE.Size = New System.Drawing.Size(119, 41)
        Me.DELETE.TabIndex = 14
        Me.DELETE.Text = "DELETE"
        Me.DELETE.UseVisualStyleBackColor = True
        '
        'VIEW
        '
        Me.VIEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VIEW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VIEW.Location = New System.Drawing.Point(70, 536)
        Me.VIEW.Name = "VIEW"
        Me.VIEW.Size = New System.Drawing.Size(117, 41)
        Me.VIEW.TabIndex = 12
        Me.VIEW.Text = "VIEW"
        Me.VIEW.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(594, 416)
        Me.DataGridView1.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.P_TYPE)
        Me.GroupBox1.Controls.Add(Me.CLEAR)
        Me.GroupBox1.Controls.Add(Me.UPDATEE)
        Me.GroupBox1.Controls.Add(Me.P_DESC)
        Me.GroupBox1.Controls.Add(Me.P_NY)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SUBMIT)
        Me.GroupBox1.Controls.Add(Me.P_AMOUNT)
        Me.GroupBox1.Controls.Add(Me.P_NAME)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(708, 620)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        '
        'P_TYPE
        '
        Me.P_TYPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_TYPE.FormattingEnabled = True
        Me.P_TYPE.Items.AddRange(New Object() {"HEALTH INSURANCE", "VEHICLE INSURANCE", "LIFE INSURANCE"})
        Me.P_TYPE.Location = New System.Drawing.Point(345, 173)
        Me.P_TYPE.Name = "P_TYPE"
        Me.P_TYPE.Size = New System.Drawing.Size(183, 24)
        Me.P_TYPE.TabIndex = 49
        Me.P_TYPE.Text = "SELECT POLICY TYPE"
        '
        'CLEAR
        '
        Me.CLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CLEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLEAR.Location = New System.Drawing.Point(494, 542)
        Me.CLEAR.Name = "CLEAR"
        Me.CLEAR.Size = New System.Drawing.Size(139, 33)
        Me.CLEAR.TabIndex = 33
        Me.CLEAR.Text = "CLEAR"
        Me.CLEAR.UseVisualStyleBackColor = True
        '
        'UPDATEE
        '
        Me.UPDATEE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UPDATEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPDATEE.Location = New System.Drawing.Point(283, 542)
        Me.UPDATEE.Name = "UPDATEE"
        Me.UPDATEE.Size = New System.Drawing.Size(130, 33)
        Me.UPDATEE.TabIndex = 31
        Me.UPDATEE.Text = "UPDATE"
        Me.UPDATEE.UseVisualStyleBackColor = True
        '
        'P_DESC
        '
        Me.P_DESC.Location = New System.Drawing.Point(347, 352)
        Me.P_DESC.Name = "P_DESC"
        Me.P_DESC.Size = New System.Drawing.Size(185, 27)
        Me.P_DESC.TabIndex = 29
        '
        'P_NY
        '
        Me.P_NY.Location = New System.Drawing.Point(347, 436)
        Me.P_NY.Name = "P_NY"
        Me.P_NY.Size = New System.Drawing.Size(185, 27)
        Me.P_NY.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(109, 436)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 18)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "NO OF YEARS"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(109, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 27)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "DESCRIPTION"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(108, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 31)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "POLICY AMOUNT"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "POLICY TYPE"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 32)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "POLICY NAME"
        '
        'SUBMIT
        '
        Me.SUBMIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SUBMIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUBMIT.Location = New System.Drawing.Point(93, 542)
        Me.SUBMIT.Name = "SUBMIT"
        Me.SUBMIT.Size = New System.Drawing.Size(133, 33)
        Me.SUBMIT.TabIndex = 20
        Me.SUBMIT.Text = "SUBMIT"
        Me.SUBMIT.UseVisualStyleBackColor = True
        '
        'P_AMOUNT
        '
        Me.P_AMOUNT.Location = New System.Drawing.Point(346, 252)
        Me.P_AMOUNT.Name = "P_AMOUNT"
        Me.P_AMOUNT.Size = New System.Drawing.Size(185, 27)
        Me.P_AMOUNT.TabIndex = 19
        '
        'P_NAME
        '
        Me.P_NAME.ForeColor = System.Drawing.SystemColors.WindowText
        Me.P_NAME.Location = New System.Drawing.Point(347, 90)
        Me.P_NAME.Name = "P_NAME"
        Me.P_NAME.Size = New System.Drawing.Size(185, 27)
        Me.P_NAME.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(550, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(428, 39)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "POLICY REGISTRATION"
        '
        'POLICY_REGISTRATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IMS.My.Resources.Resources.th__4_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1429, 796)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "POLICY_REGISTRATION"
        Me.Text = "POLICY_REGISTRATION"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CANCEL As System.Windows.Forms.Button
    Friend WithEvents DELETE As System.Windows.Forms.Button
    Friend WithEvents VIEW As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CLEAR As System.Windows.Forms.Button
    Friend WithEvents UPDATEE As System.Windows.Forms.Button
    Friend WithEvents P_DESC As System.Windows.Forms.TextBox
    Friend WithEvents P_NY As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SUBMIT As System.Windows.Forms.Button
    Friend WithEvents P_AMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents P_NAME As System.Windows.Forms.TextBox
    Friend WithEvents P_TYPE As System.Windows.Forms.ComboBox

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub POLICY_REGISTRATION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
