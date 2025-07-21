<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2_Report
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
        Button1 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(35, 41)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(407, 121)
        Button1.TabIndex = 0
        Button1.Text = "Task Organizition"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(35, 172)
        Button3.Margin = New Padding(4, 5, 4, 5)
        Button3.Name = "Button3"
        Button3.Size = New Size(407, 121)
        Button3.TabIndex = 2
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form2_Report
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(489, 578)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form2_Report"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
