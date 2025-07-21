<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6_Report
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox7 = New TextBox()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(49, 51)
        TextBox1.Margin = New Padding(4, 5, 4, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(197, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(49, 128)
        TextBox2.Margin = New Padding(4, 5, 4, 5)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(192, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(49, 301)
        TextBox3.Margin = New Padding(4, 5, 4, 5)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(192, 27)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(288, 206)
        TextBox4.Margin = New Padding(4, 5, 4, 5)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(192, 27)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(49, 206)
        TextBox5.Margin = New Padding(4, 5, 4, 5)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(192, 27)
        TextBox5.TabIndex = 4
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(55, 431)
        TextBox7.Margin = New Padding(4, 5, 4, 5)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(192, 27)
        TextBox7.TabIndex = 6
        ' 
        ' Form6_Report
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1067, 692)
        Controls.Add(TextBox7)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form6_Report"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form6"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox7 As TextBox
End Class
