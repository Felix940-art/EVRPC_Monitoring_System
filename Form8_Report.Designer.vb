<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8_Report
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
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(1, 1)
        ListBox1.Margin = New Padding(4, 5, 4, 5)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(380, 504)
        ListBox1.TabIndex = 0
        ' 
        ' Form8_Report
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(392, 528)
        Controls.Add(ListBox1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form8_Report"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form8"
        ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
End Class
