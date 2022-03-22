<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PURCHASE
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.A_NAME = New System.Windows.Forms.ComboBox
        Me.AGENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IMSDataSet = New IMS.IMSDataSet
        Me.CP_NOP = New System.Windows.Forms.TextBox
        Me.CANCEL = New System.Windows.Forms.Button
        Me.BUY = New System.Windows.Forms.Button
        Me.CP_DOE = New System.Windows.Forms.DateTimePicker
        Me.CP_DOC = New System.Windows.Forms.DateTimePicker
        Me.CP_EMI = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.P_AMOUNT = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.P_NAME = New System.Windows.Forms.TextBox
        Me.P_ID = New System.Windows.Forms.TextBox
        Me.C_NAME = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.AGENTTableAdapter = New IMS.IMSDataSetTableAdapters.AGENTTableAdapter
        Me.GroupBox2.SuspendLayout()
        CType(Me.AGENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.IMS.My.Resources.Resources.th__4_
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.A_NAME)
        Me.GroupBox2.Controls.Add(Me.CP_NOP)
        Me.GroupBox2.Controls.Add(Me.CANCEL)
        Me.GroupBox2.Controls.Add(Me.BUY)
        Me.GroupBox2.Controls.Add(Me.CP_DOE)
        Me.GroupBox2.Controls.Add(Me.CP_DOC)
        Me.GroupBox2.Controls.Add(Me.CP_EMI)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.P_AMOUNT)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.P_NAME)
        Me.GroupBox2.Controls.Add(Me.P_ID)
        Me.GroupBox2.Controls.Add(Me.C_NAME)
        Me.GroupBox2.Location = New System.Drawing.Point(45, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(539, 608)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'A_NAME
        '
        Me.A_NAME.DataSource = Me.AGENTBindingSource
        Me.A_NAME.DisplayMember = "A_NAME"
        Me.A_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_NAME.FormattingEnabled = True
        Me.A_NAME.Location = New System.Drawing.Point(303, 131)
        Me.A_NAME.Name = "A_NAME"
        Me.A_NAME.Size = New System.Drawing.Size(191, 28)
        Me.A_NAME.TabIndex = 81
        Me.A_NAME.Text = "KSHITIZ"
        '
        'AGENTBindingSource
        '
        Me.AGENTBindingSource.DataMember = "AGENT"
        Me.AGENTBindingSource.DataSource = Me.IMSDataSet
        '
        'IMSDataSet
        '
        Me.IMSDataSet.DataSetName = "IMSDataSet"
        Me.IMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CP_NOP
        '
        Me.CP_NOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CP_NOP.Location = New System.Drawing.Point(304, 390)
        Me.CP_NOP.Name = "CP_NOP"
        Me.CP_NOP.Size = New System.Drawing.Size(188, 27)
        Me.CP_NOP.TabIndex = 80
        '
        'CANCEL
        '
        Me.CANCEL.BackColor = System.Drawing.Color.Transparent
        Me.CANCEL.Enabled = False
        Me.CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CANCEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANCEL.Location = New System.Drawing.Point(272, 533)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(149, 34)
        Me.CANCEL.TabIndex = 79
        Me.CANCEL.Text = "CANCEL"
        Me.CANCEL.UseVisualStyleBackColor = False
        '
        'BUY
        '
        Me.BUY.BackColor = System.Drawing.Color.Transparent
        Me.BUY.Enabled = False
        Me.BUY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BUY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUY.Location = New System.Drawing.Point(46, 533)
        Me.BUY.Name = "BUY"
        Me.BUY.Size = New System.Drawing.Size(145, 34)
        Me.BUY.TabIndex = 78
        Me.BUY.Text = "BUY"
        Me.BUY.UseVisualStyleBackColor = False
        '
        'CP_DOE
        '
        Me.CP_DOE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CP_DOE.Location = New System.Drawing.Point(303, 465)
        Me.CP_DOE.Name = "CP_DOE"
        Me.CP_DOE.Size = New System.Drawing.Size(200, 27)
        Me.CP_DOE.TabIndex = 77
        '
        'CP_DOC
        '
        Me.CP_DOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CP_DOC.Location = New System.Drawing.Point(304, 290)
        Me.CP_DOC.Name = "CP_DOC"
        Me.CP_DOC.Size = New System.Drawing.Size(189, 27)
        Me.CP_DOC.TabIndex = 76
        '
        'CP_EMI
        '
        Me.CP_EMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CP_EMI.Location = New System.Drawing.Point(304, 432)
        Me.CP_EMI.Name = "CP_EMI"
        Me.CP_EMI.Size = New System.Drawing.Size(188, 27)
        Me.CP_EMI.TabIndex = 69
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 438)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 25)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "EMI"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 471)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(273, 25)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "DATE OF EXPIRATION"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 24)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "AGENT NAME"
        '
        'P_AMOUNT
        '
        Me.P_AMOUNT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_AMOUNT.Location = New System.Drawing.Point(305, 335)
        Me.P_AMOUNT.Name = "P_AMOUNT"
        Me.P_AMOUNT.Size = New System.Drawing.Size(188, 27)
        Me.P_AMOUNT.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 397)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(248, 25)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "NO. OF PREMIUMS"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(236, 25)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "POLICY AMOUNT"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 25)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "START DATE"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 19)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "POLICY NAME"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 19)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "POLICY ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "NAME"
        '
        'P_NAME
        '
        Me.P_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_NAME.Location = New System.Drawing.Point(303, 237)
        Me.P_NAME.Name = "P_NAME"
        Me.P_NAME.Size = New System.Drawing.Size(188, 27)
        Me.P_NAME.TabIndex = 52
        '
        'P_ID
        '
        Me.P_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_ID.Location = New System.Drawing.Point(303, 187)
        Me.P_ID.Name = "P_ID"
        Me.P_ID.Size = New System.Drawing.Size(188, 27)
        Me.P_ID.TabIndex = 51
        '
        'C_NAME
        '
        Me.C_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_NAME.Location = New System.Drawing.Point(305, 52)
        Me.C_NAME.Name = "C_NAME"
        Me.C_NAME.Size = New System.Drawing.Size(188, 27)
        Me.C_NAME.TabIndex = 50
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(597, 52)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "PURCHASE"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AGENTTableAdapter
        '
        Me.AGENTTableAdapter.ClearBeforeFill = True
        '
        'PURCHASE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IMS.My.Resources.Resources.th__4_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(630, 707)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "PURCHASE"
        Me.Text = "PURCHASE"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.AGENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents P_AMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents P_NAME As System.Windows.Forms.TextBox
    Friend WithEvents P_ID As System.Windows.Forms.TextBox
    Friend WithEvents C_NAME As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CP_EMI As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CP_DOC As System.Windows.Forms.DateTimePicker
    Friend WithEvents CP_DOE As System.Windows.Forms.DateTimePicker
    Friend WithEvents CANCEL As System.Windows.Forms.Button
    Friend WithEvents BUY As System.Windows.Forms.Button
    Friend WithEvents CP_NOP As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents A_NAME As System.Windows.Forms.ComboBox
    Friend WithEvents IMSDataSet As IMS.IMSDataSet
    Friend WithEvents AGENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AGENTTableAdapter As IMS.IMSDataSetTableAdapters.AGENTTableAdapter
End Class
