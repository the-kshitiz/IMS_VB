<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AGENT_REGISTRATION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AGENT_REGISTRATION))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.AGENT_POLICY_DETAILS = New System.Windows.Forms.Button
        Me.CANCEL = New System.Windows.Forms.Button
        Me.DELETE = New System.Windows.Forms.Button
        Me.VIEW = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.A_DOB = New System.Windows.Forms.DateTimePicker
        Me.A_TYPE = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.A_TARGET = New System.Windows.Forms.TextBox
        Me.CLEAR = New System.Windows.Forms.Button
        Me.UPDATEE = New System.Windows.Forms.Button
        Me.A_STATE = New System.Windows.Forms.TextBox
        Me.A_ADDR = New System.Windows.Forms.TextBox
        Me.A_CITY = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SUBMIT = New System.Windows.Forms.Button
        Me.A_EMAIL = New System.Windows.Forms.TextBox
        Me.A_MOBILE = New System.Windows.Forms.TextBox
        Me.A_NAME = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.AGENT_POLICY_DETAILS)
        Me.GroupBox2.Controls.Add(Me.CANCEL)
        Me.GroupBox2.Controls.Add(Me.DELETE)
        Me.GroupBox2.Controls.Add(Me.VIEW)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(826, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(713, 621)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        '
        'AGENT_POLICY_DETAILS
        '
        Me.AGENT_POLICY_DETAILS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AGENT_POLICY_DETAILS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGENT_POLICY_DETAILS.Location = New System.Drawing.Point(208, 481)
        Me.AGENT_POLICY_DETAILS.Name = "AGENT_POLICY_DETAILS"
        Me.AGENT_POLICY_DETAILS.Size = New System.Drawing.Size(317, 41)
        Me.AGENT_POLICY_DETAILS.TabIndex = 18
        Me.AGENT_POLICY_DETAILS.Text = "AGENT POLICY DETAILS"
        Me.AGENT_POLICY_DETAILS.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Location = New System.Drawing.Point(58, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(594, 416)
        Me.DataGridView1.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.A_DOB)
        Me.GroupBox1.Controls.Add(Me.A_TYPE)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.A_TARGET)
        Me.GroupBox1.Controls.Add(Me.CLEAR)
        Me.GroupBox1.Controls.Add(Me.UPDATEE)
        Me.GroupBox1.Controls.Add(Me.A_STATE)
        Me.GroupBox1.Controls.Add(Me.A_ADDR)
        Me.GroupBox1.Controls.Add(Me.A_CITY)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SUBMIT)
        Me.GroupBox1.Controls.Add(Me.A_EMAIL)
        Me.GroupBox1.Controls.Add(Me.A_MOBILE)
        Me.GroupBox1.Controls.Add(Me.A_NAME)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(96, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(708, 620)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'A_DOB
        '
        Me.A_DOB.CustomFormat = ""
        Me.A_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_DOB.Location = New System.Drawing.Point(345, 108)
        Me.A_DOB.Name = "A_DOB"
        Me.A_DOB.Size = New System.Drawing.Size(188, 22)
        Me.A_DOB.TabIndex = 48
        '
        'A_TYPE
        '
        Me.A_TYPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_TYPE.FormattingEnabled = True
        Me.A_TYPE.Items.AddRange(New Object() {"AMATEUR", "EXPERIENCED"})
        Me.A_TYPE.Location = New System.Drawing.Point(347, 428)
        Me.A_TYPE.Name = "A_TYPE"
        Me.A_TYPE.Size = New System.Drawing.Size(183, 24)
        Me.A_TYPE.TabIndex = 46
        Me.A_TYPE.Text = "SELECT AGENT TYPE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(108, 481)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 16)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "AGENT TARGET"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(108, 428)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "AGENT TYPE"
        '
        'A_TARGET
        '
        Me.A_TARGET.Location = New System.Drawing.Point(346, 478)
        Me.A_TARGET.Name = "A_TARGET"
        Me.A_TARGET.Size = New System.Drawing.Size(185, 27)
        Me.A_TARGET.TabIndex = 43
        '
        'CLEAR
        '
        Me.CLEAR.BackColor = System.Drawing.Color.Transparent
        Me.CLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CLEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLEAR.Location = New System.Drawing.Point(494, 542)
        Me.CLEAR.Name = "CLEAR"
        Me.CLEAR.Size = New System.Drawing.Size(139, 33)
        Me.CLEAR.TabIndex = 33
        Me.CLEAR.Text = "CLEAR"
        Me.CLEAR.UseVisualStyleBackColor = False
        '
        'UPDATEE
        '
        Me.UPDATEE.BackColor = System.Drawing.Color.Transparent
        Me.UPDATEE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UPDATEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPDATEE.Location = New System.Drawing.Point(283, 542)
        Me.UPDATEE.Name = "UPDATEE"
        Me.UPDATEE.Size = New System.Drawing.Size(130, 33)
        Me.UPDATEE.TabIndex = 31
        Me.UPDATEE.Text = "UPDATE"
        Me.UPDATEE.UseVisualStyleBackColor = False
        '
        'A_STATE
        '
        Me.A_STATE.Location = New System.Drawing.Point(347, 375)
        Me.A_STATE.Name = "A_STATE"
        Me.A_STATE.Size = New System.Drawing.Size(185, 27)
        Me.A_STATE.TabIndex = 30
        '
        'A_ADDR
        '
        Me.A_ADDR.Location = New System.Drawing.Point(347, 267)
        Me.A_ADDR.Name = "A_ADDR"
        Me.A_ADDR.Size = New System.Drawing.Size(185, 27)
        Me.A_ADDR.TabIndex = 29
        '
        'A_CITY
        '
        Me.A_CITY.Location = New System.Drawing.Point(347, 321)
        Me.A_CITY.Name = "A_CITY"
        Me.A_CITY.Size = New System.Drawing.Size(185, 27)
        Me.A_CITY.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(109, 375)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "STATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(109, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "CITY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(109, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "ADDRESS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(109, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "EMAIL ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "MOBILE NO."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "DATE OF BIRTH"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "NAME"
        '
        'SUBMIT
        '
        Me.SUBMIT.BackColor = System.Drawing.Color.Transparent
        Me.SUBMIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SUBMIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUBMIT.Location = New System.Drawing.Point(93, 542)
        Me.SUBMIT.Name = "SUBMIT"
        Me.SUBMIT.Size = New System.Drawing.Size(133, 33)
        Me.SUBMIT.TabIndex = 20
        Me.SUBMIT.Text = "SUBMIT"
        Me.SUBMIT.UseVisualStyleBackColor = False
        '
        'A_EMAIL
        '
        Me.A_EMAIL.Location = New System.Drawing.Point(347, 216)
        Me.A_EMAIL.Name = "A_EMAIL"
        Me.A_EMAIL.Size = New System.Drawing.Size(185, 27)
        Me.A_EMAIL.TabIndex = 19
        '
        'A_MOBILE
        '
        Me.A_MOBILE.Location = New System.Drawing.Point(347, 164)
        Me.A_MOBILE.Name = "A_MOBILE"
        Me.A_MOBILE.Size = New System.Drawing.Size(185, 27)
        Me.A_MOBILE.TabIndex = 18
        '
        'A_NAME
        '
        Me.A_NAME.Location = New System.Drawing.Point(347, 64)
        Me.A_NAME.Name = "A_NAME"
        Me.A_NAME.Size = New System.Drawing.Size(185, 27)
        Me.A_NAME.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(641, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(339, 31)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "AGENT REGISTRATION"
        '
        'AGENT_REGISTRATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AGENT_REGISTRATION"
        Me.Text = "AGENT REGISTRATION"
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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents A_TARGET As System.Windows.Forms.TextBox
    Friend WithEvents CLEAR As System.Windows.Forms.Button
    Friend WithEvents UPDATEE As System.Windows.Forms.Button
    Friend WithEvents A_STATE As System.Windows.Forms.TextBox
    Friend WithEvents A_ADDR As System.Windows.Forms.TextBox
    Friend WithEvents A_CITY As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SUBMIT As System.Windows.Forms.Button
    Friend WithEvents A_EMAIL As System.Windows.Forms.TextBox
    Friend WithEvents A_MOBILE As System.Windows.Forms.TextBox
    Friend WithEvents A_NAME As System.Windows.Forms.TextBox
    Friend WithEvents A_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents A_DOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents AGENT_POLICY_DETAILS As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
