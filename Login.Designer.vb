<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        show_password = New CheckBox()
        Textbox_Password = New Guna.UI2.WinForms.Guna2TextBox()
        Textbox_Username = New Guna.UI2.WinForms.Guna2TextBox()
        cancel_btn = New Guna.UI2.WinForms.Guna2GradientButton()
        login_btn = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Guna2ShadowPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.PeachPuff
        Label4.Location = New Point(139, 251)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 17)
        Label4.TabIndex = 4
        Label4.Text = "Forgot Password"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(48, 177)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(30, 27)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(48, 115)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(30, 27)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.PeachPuff
        Label2.Location = New Point(84, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.HighlightText
        Label3.Location = New Point(160, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 23)
        Label3.TabIndex = 1
        Label3.Text = "Login"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.PeachPuff
        Label1.Location = New Point(84, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' Guna2ShadowPanel1
        ' 
        Guna2ShadowPanel1.BackColor = Color.Transparent
        Guna2ShadowPanel1.Controls.Add(show_password)
        Guna2ShadowPanel1.Controls.Add(Textbox_Password)
        Guna2ShadowPanel1.Controls.Add(Textbox_Username)
        Guna2ShadowPanel1.Controls.Add(cancel_btn)
        Guna2ShadowPanel1.Controls.Add(login_btn)
        Guna2ShadowPanel1.Controls.Add(Label3)
        Guna2ShadowPanel1.Controls.Add(Label1)
        Guna2ShadowPanel1.Controls.Add(Label4)
        Guna2ShadowPanel1.Controls.Add(PictureBox2)
        Guna2ShadowPanel1.Controls.Add(PictureBox1)
        Guna2ShadowPanel1.Controls.Add(Label2)
        Guna2ShadowPanel1.FillColor = Color.Transparent
        Guna2ShadowPanel1.Location = New Point(101, 130)
        Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Guna2ShadowPanel1.ShadowColor = Color.Black
        Guna2ShadowPanel1.Size = New Size(373, 415)
        Guna2ShadowPanel1.TabIndex = 2
        ' 
        ' show_password
        ' 
        show_password.AutoSize = True
        show_password.ForeColor = Color.RosyBrown
        show_password.Location = New Point(84, 211)
        show_password.Name = "show_password"
        show_password.Size = New Size(132, 24)
        show_password.TabIndex = 3
        show_password.Text = "Show Password"
        show_password.UseVisualStyleBackColor = True
        ' 
        ' Textbox_Password
        ' 
        Textbox_Password.BorderColor = SystemColors.ActiveBorder
        Textbox_Password.BorderRadius = 3
        Textbox_Password.BorderThickness = 0
        Textbox_Password.CustomizableEdges = CustomizableEdges1
        Textbox_Password.DefaultText = ""
        Textbox_Password.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Textbox_Password.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Textbox_Password.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Textbox_Password.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Textbox_Password.FillColor = SystemColors.ControlDark
        Textbox_Password.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Textbox_Password.Font = New Font("Segoe UI", 9F)
        Textbox_Password.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Textbox_Password.Location = New Point(84, 177)
        Textbox_Password.Margin = New Padding(3, 4, 3, 4)
        Textbox_Password.Name = "Textbox_Password"
        Textbox_Password.PlaceholderForeColor = Color.Coral
        Textbox_Password.PlaceholderText = ""
        Textbox_Password.SelectedText = ""
        Textbox_Password.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Textbox_Password.Size = New Size(235, 27)
        Textbox_Password.TabIndex = 2
        Textbox_Password.UseSystemPasswordChar = True
        ' 
        ' Textbox_Username
        ' 
        Textbox_Username.BorderColor = SystemColors.ActiveBorder
        Textbox_Username.BorderRadius = 3
        Textbox_Username.BorderThickness = 0
        Textbox_Username.CustomizableEdges = CustomizableEdges3
        Textbox_Username.DefaultText = ""
        Textbox_Username.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Textbox_Username.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Textbox_Username.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Textbox_Username.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Textbox_Username.FillColor = SystemColors.ControlDark
        Textbox_Username.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Textbox_Username.Font = New Font("Segoe UI", 9F)
        Textbox_Username.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Textbox_Username.Location = New Point(84, 115)
        Textbox_Username.Margin = New Padding(3, 4, 3, 4)
        Textbox_Username.Name = "Textbox_Username"
        Textbox_Username.PlaceholderForeColor = Color.RosyBrown
        Textbox_Username.PlaceholderText = "Email or Phone"
        Textbox_Username.SelectedText = ""
        Textbox_Username.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Textbox_Username.Size = New Size(235, 27)
        Textbox_Username.TabIndex = 1
        ' 
        ' cancel_btn
        ' 
        cancel_btn.BorderColor = Color.Transparent
        cancel_btn.BorderRadius = 10
        cancel_btn.BorderThickness = 1
        cancel_btn.CustomizableEdges = CustomizableEdges5
        cancel_btn.DisabledState.BorderColor = Color.DarkGray
        cancel_btn.DisabledState.CustomBorderColor = Color.DarkGray
        cancel_btn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        cancel_btn.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        cancel_btn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        cancel_btn.FillColor = Color.Transparent
        cancel_btn.FillColor2 = Color.Transparent
        cancel_btn.Font = New Font("Segoe UI", 9F)
        cancel_btn.ForeColor = Color.PeachPuff
        cancel_btn.Location = New Point(153, 348)
        cancel_btn.Name = "cancel_btn"
        cancel_btn.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        cancel_btn.Size = New Size(73, 33)
        cancel_btn.TabIndex = 6
        cancel_btn.Text = "Cancel"
        ' 
        ' login_btn
        ' 
        login_btn.BorderColor = Color.PeachPuff
        login_btn.BorderRadius = 10
        login_btn.BorderThickness = 1
        login_btn.CustomizableEdges = CustomizableEdges7
        login_btn.DisabledState.BorderColor = Color.DarkGray
        login_btn.DisabledState.CustomBorderColor = Color.DarkGray
        login_btn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        login_btn.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        login_btn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        login_btn.FillColor = Color.Transparent
        login_btn.FillColor2 = Color.Transparent
        login_btn.Font = New Font("Segoe UI", 9F)
        login_btn.ForeColor = Color.PeachPuff
        login_btn.Location = New Point(106, 284)
        login_btn.Name = "login_btn"
        login_btn.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        login_btn.Size = New Size(167, 58)
        login_btn.TabIndex = 5
        login_btn.Text = "Login"
        ' 
        ' Guna2ShadowForm1
        ' 
        Guna2ShadowForm1.ShadowColor = Color.WhiteSmoke
        Guna2ShadowForm1.TargetForm = Me
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1061, 675)
        ControlBox = False
        Controls.Add(Guna2ShadowPanel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Guna2ShadowPanel1.ResumeLayout(False)
        Guna2ShadowPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents login_btn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents cancel_btn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Textbox_Username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Textbox_Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents show_password As CheckBox
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
End Class
