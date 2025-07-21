<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9_Report_Update
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
        btnupdate = New Button()
        SuspendLayout()
        ' 
        ' btnupdate
        ' 
        btnupdate.Font = New Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnupdate.ImageAlign = ContentAlignment.TopLeft
        btnupdate.Location = New Point(47, 39)
        btnupdate.Margin = New Padding(4, 5, 4, 5)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(331, 169)
        btnupdate.TabIndex = 0
        btnupdate.Text = "UPDATE"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' Form9_Report_Update
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(436, 241)
        Controls.Add(btnupdate)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form9_Report_Update"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form9"
        ResumeLayout(False)

    End Sub

    Friend WithEvents btnupdate As Button
End Class
