<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3_Report
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
        Me.btnevmrgu = New System.Windows.Forms.Button()
        Me.btnnsf = New System.Windows.Forms.Button()
        Me.btnyakal = New System.Windows.Forms.Button()
        Me.btnback1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnevmrgu
        '
        Me.btnevmrgu.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnevmrgu.Location = New System.Drawing.Point(28, 15)
        Me.btnevmrgu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnevmrgu.Name = "btnevmrgu"
        Me.btnevmrgu.Size = New System.Drawing.Size(247, 69)
        Me.btnevmrgu.TabIndex = 0
        Me.btnevmrgu.Text = "EV MRGU"
        Me.btnevmrgu.UseVisualStyleBackColor = True
        '
        'btnnsf
        '
        Me.btnnsf.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnsf.Location = New System.Drawing.Point(28, 102)
        Me.btnnsf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnnsf.Name = "btnnsf"
        Me.btnnsf.Size = New System.Drawing.Size(247, 69)
        Me.btnnsf.TabIndex = 1
        Me.btnnsf.Text = "NSF"
        Me.btnnsf.UseVisualStyleBackColor = True
        '
        'btnyakal
        '
        Me.btnyakal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnyakal.Location = New System.Drawing.Point(28, 198)
        Me.btnyakal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnyakal.Name = "btnyakal"
        Me.btnyakal.Size = New System.Drawing.Size(247, 69)
        Me.btnyakal.TabIndex = 2
        Me.btnyakal.Text = "YAKAL (SOG)"
        Me.btnyakal.UseVisualStyleBackColor = True
        '
        'btnback1
        '
        Me.btnback1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback1.Location = New System.Drawing.Point(188, 299)
        Me.btnback1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnback1.Name = "btnback1"
        Me.btnback1.Size = New System.Drawing.Size(87, 37)
        Me.btnback1.TabIndex = 3
        Me.btnback1.Text = "Back"
        Me.btnback1.UseVisualStyleBackColor = True
        '
        'Form3_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 351)
        Me.Controls.Add(Me.btnback1)
        Me.Controls.Add(Me.btnyakal)
        Me.Controls.Add(Me.btnnsf)
        Me.Controls.Add(Me.btnevmrgu)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form3_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORM3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnevmrgu As Button
    Friend WithEvents btnnsf As Button
    Friend WithEvents btnyakal As Button
    Friend WithEvents btnback1 As Button
End Class
