<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_dashboard
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_dashboard))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        lbl_sys = New Label()
        Label1 = New Label()
        ctg = New Label()
        informants = New Label()
        aa = New Label()
        fr = New Label()
        od = New Label()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        lblDateTime = New Label()
        Timer1 = New Timer(components)
        ToolTip1 = New ToolTip(components)
        lbl_exit = New Label()
        MenuStrip1 = New MenuStrip()
        AddToolStripMenuItem = New ToolStripMenuItem()
        NewDataToolStripMenuItem = New ToolStripMenuItem()
        NewReportToolStripMenuItem = New ToolStripMenuItem()
        UpdateToolStripMenuItem = New ToolStripMenuItem()
        DeleteToolStripMenuItem = New ToolStripMenuItem()
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        Guna2GradientPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbl_sys
        ' 
        lbl_sys.AutoSize = True
        lbl_sys.BackColor = Color.Transparent
        lbl_sys.Font = New Font("Times New Roman", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_sys.ForeColor = Color.FromArgb(CByte(133), CByte(193), CByte(233))
        lbl_sys.Location = New Point(120, 142)
        lbl_sys.Name = "lbl_sys"
        lbl_sys.Size = New Size(444, 136)
        lbl_sys.TabIndex = 1
        lbl_sys.Text = "EVRPC"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(133), CByte(193), CByte(233))
        Label1.Location = New Point(136, 271)
        Label1.Name = "Label1"
        Label1.Size = New Size(486, 51)
        Label1.TabIndex = 1
        Label1.Text = "MONITORING SYSTEM"
        ' 
        ' ctg
        ' 
        ctg.AutoSize = True
        ctg.BackColor = Color.Transparent
        ctg.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ctg.ForeColor = Color.FromArgb(CByte(128), CByte(139), CByte(150))
        ctg.Location = New Point(183, 400)
        ctg.Name = "ctg"
        ctg.Size = New Size(258, 26)
        ctg.TabIndex = 1
        ctg.Text = "Communist Terrorist Group"
        ' 
        ' informants
        ' 
        informants.AutoSize = True
        informants.BackColor = Color.Transparent
        informants.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        informants.ForeColor = Color.FromArgb(CByte(128), CByte(139), CByte(150))
        informants.Location = New Point(183, 444)
        informants.Name = "informants"
        informants.Size = New Size(110, 26)
        informants.TabIndex = 1
        informants.Text = "Informants"
        ' 
        ' aa
        ' 
        aa.AutoSize = True
        aa.BackColor = Color.Transparent
        aa.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        aa.ForeColor = Color.FromArgb(CByte(128), CByte(139), CByte(150))
        aa.Location = New Point(183, 490)
        aa.Name = "aa"
        aa.Size = New Size(135, 26)
        aa.TabIndex = 1
        aa.Text = "Action Agents"
        ' 
        ' fr
        ' 
        fr.AutoSize = True
        fr.BackColor = Color.Transparent
        fr.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fr.ForeColor = Color.FromArgb(CByte(128), CByte(139), CByte(150))
        fr.Location = New Point(183, 538)
        fr.Name = "fr"
        fr.Size = New Size(142, 26)
        fr.TabIndex = 1
        fr.Text = "Former Rebels"
        ' 
        ' od
        ' 
        od.AutoSize = True
        od.BackColor = Color.Transparent
        od.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        od.ForeColor = Color.FromArgb(CByte(128), CByte(139), CByte(150))
        od.Location = New Point(183, 581)
        od.Name = "od"
        od.Size = New Size(167, 26)
        od.TabIndex = 1
        od.Text = "Operational Data"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(628, 105)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(646, 674)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Trebuchet MS", 7.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        Label7.Location = New Point(78, 718)
        Label7.Name = "Label7"
        Label7.Size = New Size(113, 18)
        Label7.TabIndex = 1
        Label7.Text = "Powered by: TICO"
        ' 
        ' lblDateTime
        ' 
        lblDateTime.AutoSize = True
        lblDateTime.BackColor = Color.Transparent
        lblDateTime.Font = New Font("Trebuchet MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDateTime.ForeColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        lblDateTime.Location = New Point(967, 57)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(96, 18)
        lblDateTime.TabIndex = 1
        lblDateTime.Text = "Date and Time"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' lbl_exit
        ' 
        lbl_exit.AutoSize = True
        lbl_exit.BackColor = Color.Transparent
        lbl_exit.Font = New Font("Trebuchet MS", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_exit.ForeColor = Color.FromArgb(CByte(174), CByte(214), CByte(241))
        lbl_exit.Location = New Point(1147, 712)
        lbl_exit.Name = "lbl_exit"
        lbl_exit.Size = New Size(47, 26)
        lbl_exit.TabIndex = 5
        lbl_exit.Text = "Exit"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Transparent
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AddToolStripMenuItem, UpdateToolStripMenuItem, DeleteToolStripMenuItem})
        MenuStrip1.Location = New Point(78, 47)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(394, 36)
        MenuStrip1.TabIndex = 6
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AddToolStripMenuItem
        ' 
        AddToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewDataToolStripMenuItem, NewReportToolStripMenuItem})
        AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        AddToolStripMenuItem.Size = New Size(63, 32)
        AddToolStripMenuItem.Text = "Add"
        ' 
        ' NewDataToolStripMenuItem
        ' 
        NewDataToolStripMenuItem.Name = "NewDataToolStripMenuItem"
        NewDataToolStripMenuItem.Size = New Size(201, 32)
        NewDataToolStripMenuItem.Text = "New Data"
        ' 
        ' NewReportToolStripMenuItem
        ' 
        NewReportToolStripMenuItem.Name = "NewReportToolStripMenuItem"
        NewReportToolStripMenuItem.Size = New Size(201, 32)
        NewReportToolStripMenuItem.Text = "New Report"
        ' 
        ' UpdateToolStripMenuItem
        ' 
        UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        UpdateToolStripMenuItem.Size = New Size(91, 32)
        UpdateToolStripMenuItem.Text = "Update"
        ' 
        ' DeleteToolStripMenuItem
        ' 
        DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        DeleteToolStripMenuItem.Size = New Size(82, 32)
        DeleteToolStripMenuItem.Text = "Delete"
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.Controls.Add(lbl_exit)
        Guna2GradientPanel1.Controls.Add(MenuStrip1)
        Guna2GradientPanel1.Controls.Add(lblDateTime)
        Guna2GradientPanel1.Controls.Add(PictureBox1)
        Guna2GradientPanel1.Controls.Add(Label7)
        Guna2GradientPanel1.Controls.Add(lbl_sys)
        Guna2GradientPanel1.Controls.Add(od)
        Guna2GradientPanel1.Controls.Add(Label1)
        Guna2GradientPanel1.Controls.Add(fr)
        Guna2GradientPanel1.Controls.Add(ctg)
        Guna2GradientPanel1.Controls.Add(aa)
        Guna2GradientPanel1.Controls.Add(informants)
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges1
        Guna2GradientPanel1.Dock = DockStyle.Fill
        Guna2GradientPanel1.FillColor = Color.FromArgb(CByte(28), CByte(40), CByte(51))
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        Guna2GradientPanel1.Location = New Point(0, 0)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GradientPanel1.Size = New Size(1273, 776)
        Guna2GradientPanel1.TabIndex = 7
        ' 
        ' Guna2ShadowForm1
        ' 
        Guna2ShadowForm1.TargetForm = Me
        ' 
        ' main_dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(46), CByte(64), CByte(83))
        ClientSize = New Size(1273, 776)
        Controls.Add(Guna2GradientPanel1)
        FormBorderStyle = FormBorderStyle.None
        MainMenuStrip = MenuStrip1
        Name = "main_dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main Window"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Guna2GradientPanel1.ResumeLayout(False)
        Guna2GradientPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents lbl_sys As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ctg As Label
    Friend WithEvents informants As Label
    Friend WithEvents aa As Label
    Friend WithEvents fr As Label
    Friend WithEvents od As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lbl_exit As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
End Class
