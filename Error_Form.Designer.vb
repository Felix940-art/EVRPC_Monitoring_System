<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Error_Form
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
        open_timer = New Timer(components)
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        close_timer = New Timer(components)
        proxy_timer = New Timer(components)
        SuspendLayout()
        ' 
        ' open_timer
        ' 
        open_timer.Interval = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(28, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 46)
        Label1.TabIndex = 0
        Label1.Text = "!"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(92, 7)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 1
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(92, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 2
        Label3.Text = "Label3"
        ' 
        ' close_timer
        ' 
        close_timer.Interval = 1
        ' 
        ' proxy_timer
        ' 
        proxy_timer.Interval = 1500
        ' 
        ' Error_Form
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Red
        ClientSize = New Size(396, 56)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Error_Form"
        Text = "Error_Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents open_timer As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents close_timer As Timer
    Friend WithEvents proxy_timer As Timer
End Class
