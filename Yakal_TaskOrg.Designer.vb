<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Yakal_TaskOrg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Yakal_TaskOrg))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        ListBox1 = New ListBox()
        Label7 = New Label()
        Label8 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(409, 454)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(290, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 20)
        Label1.TabIndex = 1
        Label1.Text = "PL   :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(290, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 20)
        Label2.TabIndex = 1
        Label2.Text = "VPL :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(290, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 20)
        Label3.TabIndex = 1
        Label3.Text = "PI    :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(161, 383)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 20)
        Label4.TabIndex = 1
        Label4.Text = "SL   :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(161, 403)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 20)
        Label5.TabIndex = 1
        Label5.Text = "VSL :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(161, 423)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 20)
        Label6.TabIndex = 1
        Label6.Text = "PG   :"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(45, 552)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(566, 164)
        ListBox1.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(37, 518)
        Label7.Name = "Label7"
        Label7.Size = New Size(125, 31)
        Label7.TabIndex = 1
        Label7.Text = "MEMBERS"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(686, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(40, 20)
        Label8.TabIndex = 1
        Label8.Text = "Back"
        ' 
        ' Yakal_TaskOrg
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(738, 747)
        Controls.Add(ListBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Label4)
        Controls.Add(Label8)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Yakal_TaskOrg"
        Text = "Yakal_TaskOrg"
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
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
