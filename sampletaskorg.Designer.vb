<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sampletaskorg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sampletaskorg))
        lblEVRPCMRGU = New Label()
        lblEVRPCMRGUMembers = New Label()
        lbEVRPCMRGUMembers = New ListBox()
        lblEVRPCMRGUCO = New Label()
        lblEVRPCMRGUVCO = New Label()
        lblEVRPCMRGUSEC = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        btnBack = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblEVRPCMRGU
        ' 
        lblEVRPCMRGU.AutoSize = True
        lblEVRPCMRGU.Font = New Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEVRPCMRGU.Location = New Point(67, 64)
        lblEVRPCMRGU.Margin = New Padding(4, 0, 4, 0)
        lblEVRPCMRGU.Name = "lblEVRPCMRGU"
        lblEVRPCMRGU.Size = New Size(144, 29)
        lblEVRPCMRGU.TabIndex = 4
        lblEVRPCMRGU.Text = "EVRPC MRGU"
        ' 
        ' lblEVRPCMRGUMembers
        ' 
        lblEVRPCMRGUMembers.AutoSize = True
        lblEVRPCMRGUMembers.Font = New Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEVRPCMRGUMembers.Location = New Point(996, 64)
        lblEVRPCMRGUMembers.Margin = New Padding(4, 0, 4, 0)
        lblEVRPCMRGUMembers.Name = "lblEVRPCMRGUMembers"
        lblEVRPCMRGUMembers.Size = New Size(112, 29)
        lblEVRPCMRGUMembers.TabIndex = 15
        lblEVRPCMRGUMembers.Text = "MEMBERS"
        ' 
        ' lbEVRPCMRGUMembers
        ' 
        lbEVRPCMRGUMembers.FormattingEnabled = True
        lbEVRPCMRGUMembers.Location = New Point(996, 99)
        lbEVRPCMRGUMembers.Margin = New Padding(4, 5, 4, 5)
        lbEVRPCMRGUMembers.Name = "lbEVRPCMRGUMembers"
        lbEVRPCMRGUMembers.Size = New Size(312, 644)
        lbEVRPCMRGUMembers.TabIndex = 16
        ' 
        ' lblEVRPCMRGUCO
        ' 
        lblEVRPCMRGUCO.AutoSize = True
        lblEVRPCMRGUCO.Font = New Font("Segoe UI", 7.8F)
        lblEVRPCMRGUCO.Location = New Point(211, 236)
        lblEVRPCMRGUCO.Margin = New Padding(4, 0, 4, 0)
        lblEVRPCMRGUCO.Name = "lblEVRPCMRGUCO"
        lblEVRPCMRGUCO.Size = New Size(26, 17)
        lblEVRPCMRGUCO.TabIndex = 17
        lblEVRPCMRGUCO.Text = "CO"
        ' 
        ' lblEVRPCMRGUVCO
        ' 
        lblEVRPCMRGUVCO.AutoSize = True
        lblEVRPCMRGUVCO.Font = New Font("Segoe UI", 7.8F)
        lblEVRPCMRGUVCO.Location = New Point(211, 256)
        lblEVRPCMRGUVCO.Margin = New Padding(4, 0, 4, 0)
        lblEVRPCMRGUVCO.Name = "lblEVRPCMRGUVCO"
        lblEVRPCMRGUVCO.Size = New Size(34, 17)
        lblEVRPCMRGUVCO.TabIndex = 18
        lblEVRPCMRGUVCO.Text = "VCO"
        ' 
        ' lblEVRPCMRGUSEC
        ' 
        lblEVRPCMRGUSEC.AutoSize = True
        lblEVRPCMRGUSEC.Font = New Font("Segoe UI", 7.8F)
        lblEVRPCMRGUSEC.Location = New Point(211, 275)
        lblEVRPCMRGUSEC.Margin = New Padding(4, 0, 4, 0)
        lblEVRPCMRGUSEC.Name = "lblEVRPCMRGUSEC"
        lblEVRPCMRGUSEC.Size = New Size(30, 17)
        lblEVRPCMRGUSEC.TabIndex = 19
        lblEVRPCMRGUSEC.Text = "SEC"
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(1208, 784)
        btnBack.Margin = New Padding(4, 5, 4, 5)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(100, 35)
        btnBack.TabIndex = 23
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-127, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1116, 794)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 7.8F)
        Label1.Location = New Point(166, 236)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 17)
        Label1.TabIndex = 25
        Label1.Text = "CO    :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 7.8F)
        Label2.Location = New Point(166, 256)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 17)
        Label2.TabIndex = 26
        Label2.Text = "VCO  :"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 7.8F)
        Label3.Location = New Point(166, 275)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 17)
        Label3.TabIndex = 27
        Label3.Text = "SEC   :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 7.8F)
        Label4.Location = New Point(555, 134)
        Label4.Name = "Label4"
        Label4.Size = New Size(27, 17)
        Label4.TabIndex = 30
        Label4.Text = "PG:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 7.8F)
        Label5.Location = New Point(555, 99)
        Label5.Name = "Label5"
        Label5.Size = New Size(32, 17)
        Label5.TabIndex = 29
        Label5.Text = "VSL:"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 7.8F)
        Label6.Location = New Point(555, 64)
        Label6.Name = "Label6"
        Label6.Size = New Size(24, 17)
        Label6.TabIndex = 28
        Label6.Text = "SL:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 7.8F)
        Label7.Location = New Point(672, 264)
        Label7.Name = "Label7"
        Label7.Size = New Size(27, 17)
        Label7.TabIndex = 33
        Label7.Text = "PG:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 7.8F)
        Label8.Location = New Point(672, 214)
        Label8.Name = "Label8"
        Label8.Size = New Size(32, 17)
        Label8.TabIndex = 32
        Label8.Text = "VSL:"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 7.8F)
        Label9.Location = New Point(672, 164)
        Label9.Name = "Label9"
        Label9.Size = New Size(24, 17)
        Label9.TabIndex = 31
        Label9.Text = "SL:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 7.8F)
        Label10.Location = New Point(672, 423)
        Label10.Name = "Label10"
        Label10.Size = New Size(27, 17)
        Label10.TabIndex = 36
        Label10.Text = "PG:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 7.8F)
        Label11.Location = New Point(672, 374)
        Label11.Name = "Label11"
        Label11.Size = New Size(32, 17)
        Label11.TabIndex = 35
        Label11.Text = "VSL:"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 7.8F)
        Label12.Location = New Point(672, 324)
        Label12.Name = "Label12"
        Label12.Size = New Size(24, 17)
        Label12.TabIndex = 34
        Label12.Text = "SL:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 7.8F)
        Label13.Location = New Point(675, 599)
        Label13.Name = "Label13"
        Label13.Size = New Size(27, 17)
        Label13.TabIndex = 39
        Label13.Text = "PG:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 7.8F)
        Label14.Location = New Point(675, 549)
        Label14.Name = "Label14"
        Label14.Size = New Size(32, 17)
        Label14.TabIndex = 38
        Label14.Text = "VSL:"
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 7.8F)
        Label15.Location = New Point(675, 499)
        Label15.Name = "Label15"
        Label15.Size = New Size(24, 17)
        Label15.TabIndex = 37
        Label15.Text = "SL:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 7.8F)
        Label16.Location = New Point(675, 760)
        Label16.Name = "Label16"
        Label16.Size = New Size(27, 17)
        Label16.TabIndex = 42
        Label16.Text = "PG:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 7.8F)
        Label17.Location = New Point(675, 710)
        Label17.Name = "Label17"
        Label17.Size = New Size(32, 17)
        Label17.TabIndex = 41
        Label17.Text = "VSL:"
        Label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 7.8F)
        Label18.Location = New Point(675, 659)
        Label18.Name = "Label18"
        Label18.Size = New Size(24, 17)
        Label18.TabIndex = 40
        Label18.Text = "SL:"
        ' 
        ' Sampletaskorg
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 863)
        Controls.Add(Label16)
        Controls.Add(Label17)
        Controls.Add(Label18)
        Controls.Add(Label13)
        Controls.Add(Label14)
        Controls.Add(Label15)
        Controls.Add(Label10)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        Controls.Add(lblEVRPCMRGUSEC)
        Controls.Add(lblEVRPCMRGUVCO)
        Controls.Add(lblEVRPCMRGUCO)
        Controls.Add(lbEVRPCMRGUMembers)
        Controls.Add(lblEVRPCMRGUMembers)
        Controls.Add(lblEVRPCMRGU)
        Controls.Add(PictureBox1)
        Cursor = Cursors.Hand
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "Sampletaskorg"
        StartPosition = FormStartPosition.CenterScreen
        Text = "sampletaskorg"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents lblEVRPCMRGU As Label
    Friend WithEvents lblEVRPCMRGUMembers As Label
    Friend WithEvents lbEVRPCMRGUMembers As ListBox
    Friend WithEvents lblEVRPCMRGUCO As Label
    Friend WithEvents lblEVRPCMRGUVCO As Label
    Friend WithEvents lblEVRPCMRGUSEC As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
End Class
