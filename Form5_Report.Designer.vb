<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5_Report
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
        Me.btnvertical = New System.Windows.Forms.Button()
        Me.btnhorizontal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnvertical
        '
        Me.btnvertical.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvertical.Location = New System.Drawing.Point(37, 69)
        Me.btnvertical.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnvertical.Name = "btnvertical"
        Me.btnvertical.Size = New System.Drawing.Size(341, 90)
        Me.btnvertical.TabIndex = 0
        Me.btnvertical.Text = "Vertical"
        Me.btnvertical.UseVisualStyleBackColor = True
        '
        'btnhorizontal
        '
        Me.btnhorizontal.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhorizontal.Location = New System.Drawing.Point(387, 69)
        Me.btnhorizontal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnhorizontal.Name = "btnhorizontal"
        Me.btnhorizontal.Size = New System.Drawing.Size(361, 90)
        Me.btnhorizontal.TabIndex = 1
        Me.btnhorizontal.Text = "Horizontal"
        Me.btnhorizontal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(628, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "COMMUNIST TERRORIST GRUOP"
        '
        'Form5_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 174)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnhorizontal)
        Me.Controls.Add(Me.btnvertical)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form5_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnvertical As Button
    Friend WithEvents btnhorizontal As Button
    Friend WithEvents Label1 As Label
End Class
