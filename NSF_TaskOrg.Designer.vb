<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NSF_TaskOrg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NSF_TaskOrg))
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
        ListBox1 = New ListBox()
        Label14 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(46, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(738, 455)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(987, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 20)
        Label1.TabIndex = 1
        Label1.Text = "Back"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(411, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 20)
        Label2.TabIndex = 2
        Label2.Text = "PL     :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(411, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 20)
        Label3.TabIndex = 2
        Label3.Text = "VPL   :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(411, 107)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 20)
        Label4.TabIndex = 2
        Label4.Text = "PI      :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(135, 369)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 20)
        Label5.TabIndex = 2
        Label5.Text = "SL     :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(135, 409)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 20)
        Label6.TabIndex = 2
        Label6.Text = "VSL   :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(135, 448)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 20)
        Label7.TabIndex = 2
        Label7.Text = "PG    :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(415, 369)
        Label8.Name = "Label8"
        Label8.Size = New Size(47, 20)
        Label8.TabIndex = 2
        Label8.Text = "SL     :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(415, 409)
        Label9.Name = "Label9"
        Label9.Size = New Size(48, 20)
        Label9.TabIndex = 2
        Label9.Text = "VSL   :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(415, 448)
        Label10.Name = "Label10"
        Label10.Size = New Size(46, 20)
        Label10.TabIndex = 2
        Label10.Text = "PG    :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(693, 369)
        Label11.Name = "Label11"
        Label11.Size = New Size(47, 20)
        Label11.TabIndex = 2
        Label11.Text = "SL     :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(693, 409)
        Label12.Name = "Label12"
        Label12.Size = New Size(48, 20)
        Label12.TabIndex = 2
        Label12.Text = "VSL   :"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(693, 448)
        Label13.Name = "Label13"
        Label13.Size = New Size(46, 20)
        Label13.TabIndex = 2
        Label13.Text = "PG    :"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(178, 586)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(606, 164)
        ListBox1.TabIndex = 3
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(46, 578)
        Label14.Name = "Label14"
        Label14.Size = New Size(125, 31)
        Label14.TabIndex = 4
        Label14.Text = "MEMBERS"
        ' 
        ' NSF_TaskOrg
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1051, 803)
        Controls.Add(Label14)
        Controls.Add(ListBox1)
        Controls.Add(Label13)
        Controls.Add(Label10)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(Label12)
        Controls.Add(Label9)
        Controls.Add(Label6)
        Controls.Add(Label11)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "NSF_TaskOrg"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NSF_TaskOrg"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

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
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label14 As Label
End Class
