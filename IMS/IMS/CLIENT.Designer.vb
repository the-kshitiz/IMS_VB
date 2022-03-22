<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CLIENT
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.CNAME = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BUY = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.C_DOB = New System.Windows.Forms.DateTimePicker
        Me.C_STATE = New System.Windows.Forms.TextBox
        Me.C_ADDR = New System.Windows.Forms.TextBox
        Me.C_CITY = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.C_EMAIL = New System.Windows.Forms.TextBox
        Me.C_MOBILE = New System.Windows.Forms.TextBox
        Me.C_NAME = New System.Windows.Forms.TextBox
        Me.OPERATION = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(440, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "WELCOME"
        '
        'CNAME
        '
        Me.CNAME.AutoSize = True
        Me.CNAME.BackColor = System.Drawing.Color.Transparent
        Me.CNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNAME.Location = New System.Drawing.Point(639, 39)
        Me.CNAME.Name = "CNAME"
        Me.CNAME.Size = New System.Drawing.Size(126, 39)
        Me.CNAME.TabIndex = 3
        Me.CNAME.Text = "Label2"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BUY)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(421, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(825, 550)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'BUY
        '
        Me.BUY.Enabled = False
        Me.BUY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BUY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUY.Location = New System.Drawing.Point(295, 500)
        Me.BUY.Name = "BUY"
        Me.BUY.Size = New System.Drawing.Size(97, 34)
        Me.BUY.TabIndex = 4
        Me.BUY.Text = "BUY"
        Me.BUY.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(58, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(676, 457)
        Me.DataGridView1.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.C_DOB)
        Me.GroupBox2.Controls.Add(Me.C_STATE)
        Me.GroupBox2.Controls.Add(Me.C_ADDR)
        Me.GroupBox2.Controls.Add(Me.C_CITY)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.C_EMAIL)
        Me.GroupBox2.Controls.Add(Me.C_MOBILE)
        Me.GroupBox2.Controls.Add(Me.C_NAME)
        Me.GroupBox2.Controls.Add(Me.OPERATION)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(383, 551)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'C_DOB
        '
        Me.C_DOB.CustomFormat = ""
        Me.C_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_DOB.Location = New System.Drawing.Point(183, 159)
        Me.C_DOB.Name = "C_DOB"
        Me.C_DOB.Size = New System.Drawing.Size(188, 27)
        Me.C_DOB.TabIndex = 63
        '
        'C_STATE
        '
        Me.C_STATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_STATE.Location = New System.Drawing.Point(184, 454)
        Me.C_STATE.Name = "C_STATE"
        Me.C_STATE.Size = New System.Drawing.Size(188, 27)
        Me.C_STATE.TabIndex = 62
        '
        'C_ADDR
        '
        Me.C_ADDR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_ADDR.Location = New System.Drawing.Point(184, 339)
        Me.C_ADDR.Name = "C_ADDR"
        Me.C_ADDR.Size = New System.Drawing.Size(188, 27)
        Me.C_ADDR.TabIndex = 61
        '
        'C_CITY
        '
        Me.C_CITY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_CITY.Location = New System.Drawing.Point(184, 395)
        Me.C_CITY.Name = "C_CITY"
        Me.C_CITY.Size = New System.Drawing.Size(188, 27)
        Me.C_CITY.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 454)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "STATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 395)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "CITY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "ADDRESS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "EMAIL ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "MOBILE NO."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "DATE OF BIRTH"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "NAME"
        '
        'C_EMAIL
        '
        Me.C_EMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_EMAIL.Location = New System.Drawing.Point(184, 274)
        Me.C_EMAIL.Name = "C_EMAIL"
        Me.C_EMAIL.Size = New System.Drawing.Size(188, 27)
        Me.C_EMAIL.TabIndex = 52
        '
        'C_MOBILE
        '
        Me.C_MOBILE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_MOBILE.Location = New System.Drawing.Point(184, 212)
        Me.C_MOBILE.Name = "C_MOBILE"
        Me.C_MOBILE.Size = New System.Drawing.Size(188, 27)
        Me.C_MOBILE.TabIndex = 51
        '
        'C_NAME
        '
        Me.C_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_NAME.Location = New System.Drawing.Point(184, 103)
        Me.C_NAME.Name = "C_NAME"
        Me.C_NAME.Size = New System.Drawing.Size(188, 27)
        Me.C_NAME.TabIndex = 50
        '
        'OPERATION
        '
        Me.OPERATION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPERATION.FormattingEnabled = True
        Me.OPERATION.Items.AddRange(New Object() {"ACTIVE POLICIES", "NEW HEALTH INSURANCE", "NEW VEHICLE INSURANCE", "NEW LIFE INSURANCE"})
        Me.OPERATION.Location = New System.Drawing.Point(14, 40)
        Me.OPERATION.Name = "OPERATION"
        Me.OPERATION.Size = New System.Drawing.Size(213, 28)
        Me.OPERATION.TabIndex = 1
        Me.OPERATION.Text = "SELECT OPERATION"
        '
        'CLIENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IMS.My.Resources.Resources.th__4_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1316, 696)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CNAME)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CLIENT"
        Me.Text = "CLIENT"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CNAME As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OPERATION As System.Windows.Forms.ComboBox
    Friend WithEvents C_DOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents C_STATE As System.Windows.Forms.TextBox
    Friend WithEvents C_ADDR As System.Windows.Forms.TextBox
    Friend WithEvents C_CITY As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents C_EMAIL As System.Windows.Forms.TextBox
    Friend WithEvents C_MOBILE As System.Windows.Forms.TextBox
    Friend WithEvents C_NAME As System.Windows.Forms.TextBox
    Friend WithEvents BUY As System.Windows.Forms.Button
End Class
