<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reportForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lblsource = New System.Windows.Forms.Label()
        Me.lblactivity = New System.Windows.Forms.Label()
        Me.lbldetails = New System.Windows.Forms.Label()
        Me.lbltoa = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(124, 40)
        Me.lbldate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(40, 19)
        Me.lbldate.TabIndex = 0
        Me.lbldate.Text = "Date"
        Me.lbldate.UseWaitCursor = True
        '
        'lblsource
        '
        Me.lblsource.AutoSize = True
        Me.lblsource.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsource.Location = New System.Drawing.Point(124, 72)
        Me.lblsource.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsource.Name = "lblsource"
        Me.lblsource.Size = New System.Drawing.Size(52, 19)
        Me.lblsource.TabIndex = 1
        Me.lblsource.Text = "Source"
        Me.lblsource.UseWaitCursor = True
        '
        'lblactivity
        '
        Me.lblactivity.AutoSize = True
        Me.lblactivity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblactivity.Location = New System.Drawing.Point(121, 101)
        Me.lblactivity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblactivity.Name = "lblactivity"
        Me.lblactivity.Size = New System.Drawing.Size(59, 19)
        Me.lblactivity.TabIndex = 2
        Me.lblactivity.Text = "Activity"
        Me.lblactivity.UseWaitCursor = True
        '
        'lbldetails
        '
        Me.lbldetails.AutoSize = True
        Me.lbldetails.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldetails.Location = New System.Drawing.Point(124, 168)
        Me.lbldetails.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldetails.MaximumSize = New System.Drawing.Size(350, 0)
        Me.lbldetails.Name = "lbldetails"
        Me.lbldetails.Size = New System.Drawing.Size(54, 19)
        Me.lbldetails.TabIndex = 3
        Me.lbldetails.Text = "Details"
        Me.lbldetails.UseWaitCursor = True
        '
        'lbltoa
        '
        Me.lbltoa.AutoSize = True
        Me.lbltoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltoa.Location = New System.Drawing.Point(121, 124)
        Me.lbltoa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltoa.Name = "lbltoa"
        Me.lbltoa.Size = New System.Drawing.Size(110, 19)
        Me.lbltoa.TabIndex = 4
        Me.lbltoa.Text = "Type of Activity"
        Me.lbltoa.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "DATE:"
        Me.Label1.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "SOURCE:"
        Me.Label2.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 101)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ACTIVITY:"
        Me.Label3.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 165)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "DETAILS:"
        Me.Label5.UseWaitCursor = True
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(369, 9)
        Me.lbltitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(60, 26)
        Me.lbltitle.TabIndex = 10
        Me.lbltitle.Text = "Title"
        Me.lbltitle.UseWaitCursor = True
        '
        'reportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 450)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbltoa)
        Me.Controls.Add(Me.lbldetails)
        Me.Controls.Add(Me.lblactivity)
        Me.Controls.Add(Me.lblsource)
        Me.Controls.Add(Me.lbldate)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "reportForm"
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbldate As Label
    Friend WithEvents lblsource As Label
    Friend WithEvents lblactivity As Label
    Friend WithEvents lbldetails As Label
    Friend WithEvents lbltoa As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label

    Private Sub reportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lbldate_Click(sender As Object, e As EventArgs) Handles lbldate.Click

    End Sub

    Friend WithEvents lbltitle As Label
End Class
