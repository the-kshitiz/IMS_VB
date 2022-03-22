<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CLIENT_REGISTRATION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CLIENT_REGISTRATION))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.C_DOB = New System.Windows.Forms.DateTimePicker
        Me.CLEAR = New System.Windows.Forms.Button
        Me.UPDATEE = New System.Windows.Forms.Button
        Me.C_STATE = New System.Windows.Forms.TextBox
        Me.C_ADDR = New System.Windows.Forms.TextBox
        Me.C_CITY = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SUBMIT = New System.Windows.Forms.Button
        Me.C_EMAIL = New System.Windows.Forms.TextBox
        Me.C_MOBILE = New System.Windows.Forms.TextBox
        Me.C_NAME = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CLIENT_POLICY_DETAILS = New System.Windows.Forms.Button
        Me.CANCEL = New System.Windows.Forms.Button
        Me.DELETE = New System.Windows.Forms.Button
        Me.VIEW = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.C_DOB)
        Me.GroupBox1.Controls.Add(Me.CLEAR)
        Me.GroupBox1.Controls.Add(Me.UPDATEE)
        Me.GroupBox1.Controls.Add(Me.C_STATE)
        Me.GroupBox1.Controls.Add(Me.C_ADDR)
        Me.GroupBox1.Controls.Add(Me.C_CITY)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SUBMIT)
        Me.GroupBox1.Controls.Add(Me.C_EMAIL)
        Me.GroupBox1.Controls.Add(Me.C_MOBILE)
        Me.GroupBox1.Controls.Add(Me.C_NAME)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(35, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(710, 585)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CLIENT REGISTRATION"
        '
        'C_DOB
        '
        Me.C_DOB.CustomFormat = ""
        Me.C_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_DOB.Location = New System.Drawing.Point(344, 120)
        Me.C_DOB.Name = "C_DOB"
        Me.C_DOB.Size = New System.Drawing.Size(188, 22)
        Me.C_DOB.TabIndex = 49
        '
        'CLEAR
        '
        Me.CLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CLEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLEAR.ForeColor = System.Drawing.Color.Black
        Me.CLEAR.Location = New System.Drawing.Point(494, 501)
        Me.CLEAR.Name = "CLEAR"
        Me.CLEAR.Size = New System.Drawing.Size(139, 33)
        Me.CLEAR.TabIndex = 33
        Me.CLEAR.Text = "CLEAR"
        Me.CLEAR.UseVisualStyleBackColor = True
        '
        'UPDATEE
        '
        Me.UPDATEE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.UPDATEE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UPDATEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPDATEE.ForeColor = System.Drawing.Color.Black
        Me.UPDATEE.Location = New System.Drawing.Point(273, 501)
        Me.UPDATEE.Name = "UPDATEE"
        Me.UPDATEE.Size = New System.Drawing.Size(130, 33)
        Me.UPDATEE.TabIndex = 31
        Me.UPDATEE.Text = "UPDATE"
        Me.UPDATEE.UseVisualStyleBackColor = True
        '
        'C_STATE
        '
        Me.C_STATE.Location = New System.Drawing.Point(345, 415)
        Me.C_STATE.Name = "C_STATE"
        Me.C_STATE.Size = New System.Drawing.Size(188, 27)
        Me.C_STATE.TabIndex = 30
        '
        'C_ADDR
        '
        Me.C_ADDR.Location = New System.Drawing.Point(345, 300)
        Me.C_ADDR.Name = "C_ADDR"
        Me.C_ADDR.Size = New System.Drawing.Size(188, 27)
        Me.C_ADDR.TabIndex = 29
        '
        'C_CITY
        '
        Me.C_CITY.Location = New System.Drawing.Point(345, 356)
        Me.C_CITY.Name = "C_CITY"
        Me.C_CITY.Size = New System.Drawing.Size(188, 27)
        Me.C_CITY.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(109, 415)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "STATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(109, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "CITY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(109, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "ADDRESS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(109, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "EMAIL ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(109, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "MOBILE NO."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(109, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "DATE OF BIRTH"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(109, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "NAME"
        '
        'SUBMIT
        '
        Me.SUBMIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SUBMIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUBMIT.ForeColor = System.Drawing.Color.Black
        Me.SUBMIT.Location = New System.Drawing.Point(93, 501)
        Me.SUBMIT.Name = "SUBMIT"
        Me.SUBMIT.Size = New System.Drawing.Size(133, 33)
        Me.SUBMIT.TabIndex = 20
        Me.SUBMIT.Text = "SUBMIT"
        Me.SUBMIT.UseVisualStyleBackColor = True
        '
        'C_EMAIL
        '
        Me.C_EMAIL.Location = New System.Drawing.Point(345, 235)
        Me.C_EMAIL.Name = "C_EMAIL"
        Me.C_EMAIL.Size = New System.Drawing.Size(188, 27)
        Me.C_EMAIL.TabIndex = 19
        '
        'C_MOBILE
        '
        Me.C_MOBILE.Location = New System.Drawing.Point(345, 173)
        Me.C_MOBILE.Name = "C_MOBILE"
        Me.C_MOBILE.Size = New System.Drawing.Size(188, 27)
        Me.C_MOBILE.TabIndex = 18
        '
        'C_NAME
        '
        Me.C_NAME.Location = New System.Drawing.Point(345, 64)
        Me.C_NAME.Name = "C_NAME"
        Me.C_NAME.Size = New System.Drawing.Size(188, 27)
        Me.C_NAME.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CLIENT_POLICY_DETAILS)
        Me.GroupBox2.Controls.Add(Me.CANCEL)
        Me.GroupBox2.Controls.Add(Me.DELETE)
        Me.GroupBox2.Controls.Add(Me.VIEW)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(762, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(641, 586)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'CLIENT_POLICY_DETAILS
        '
        Me.CLIENT_POLICY_DETAILS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CLIENT_POLICY_DETAILS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLIENT_POLICY_DETAILS.Location = New System.Drawing.Point(200, 533)
        Me.CLIENT_POLICY_DETAILS.Name = "CLIENT_POLICY_DETAILS"
        Me.CLIENT_POLICY_DETAILS.Size = New System.Drawing.Size(317, 41)
        Me.CLIENT_POLICY_DETAILS.TabIndex = 17
        Me.CLIENT_POLICY_DETAILS.Text = "CLIENT POLICY DETAILS"
        Me.CLIENT_POLICY_DETAILS.UseVisualStyleBackColor = True
        '
        'CANCEL
        '
        Me.CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CANCEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCEL.Location = New System.Drawing.Point(483, 493)
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
        Me.DELETE.Location = New System.Drawing.Point(274, 460)
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
        Me.VIEW.Location = New System.Drawing.Point(70, 493)
        Me.VIEW.Name = "VIEW"
        Me.VIEW.Size = New System.Drawing.Size(117, 41)
        Me.VIEW.TabIndex = 12
        Me.VIEW.Text = "VIEW"
        Me.VIEW.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(594, 416)
        Me.DataGridView1.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(596, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(426, 39)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "CLIENT REGISTRATION"
        '
        'CLIENT_REGISTRATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1512, 714)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CLIENT_REGISTRATION"
        Me.Text = "CLIENT REGISTRATION"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents C_STATE As System.Windows.Forms.TextBox
    Friend WithEvents C_ADDR As System.Windows.Forms.TextBox
    Friend WithEvents C_CITY As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SUBMIT As System.Windows.Forms.Button
    Friend WithEvents C_EMAIL As System.Windows.Forms.TextBox
    Friend WithEvents C_MOBILE As System.Windows.Forms.TextBox
    Friend WithEvents C_NAME As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VIEW As System.Windows.Forms.Button
    Friend WithEvents CLEAR As System.Windows.Forms.Button
    Friend WithEvents UPDATEE As System.Windows.Forms.Button
    Friend WithEvents CANCEL As System.Windows.Forms.Button
    Friend WithEvents DELETE As System.Windows.Forms.Button
    Friend WithEvents C_DOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents CLIENT_POLICY_DETAILS As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
