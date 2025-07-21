<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4_Report
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
        Me.btnrhq = New System.Windows.Forms.Button()
        Me.btnemporium = New System.Windows.Forms.Button()
        Me.btnarctic = New System.Windows.Forms.Button()
        Me.btnbrowser = New System.Windows.Forms.Button()
        Me.btnlevox = New System.Windows.Forms.Button()
        Me.btnsesame = New System.Windows.Forms.Button()
        Me.btnback2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnrhq
        '
        Me.btnrhq.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrhq.Location = New System.Drawing.Point(12, 12)
        Me.btnrhq.Name = "btnrhq"
        Me.btnrhq.Size = New System.Drawing.Size(191, 54)
        Me.btnrhq.TabIndex = 0
        Me.btnrhq.Text = "RHQ"
        Me.btnrhq.UseVisualStyleBackColor = True
        '
        'btnemporium
        '
        Me.btnemporium.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnemporium.Location = New System.Drawing.Point(12, 132)
        Me.btnemporium.Name = "btnemporium"
        Me.btnemporium.Size = New System.Drawing.Size(191, 54)
        Me.btnemporium.TabIndex = 1
        Me.btnemporium.Text = "SRMA EMPORIUM"
        Me.btnemporium.UseVisualStyleBackColor = True
        '
        'btnarctic
        '
        Me.btnarctic.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnarctic.Location = New System.Drawing.Point(12, 72)
        Me.btnarctic.Name = "btnarctic"
        Me.btnarctic.Size = New System.Drawing.Size(191, 54)
        Me.btnarctic.TabIndex = 2
        Me.btnarctic.Text = "SRMA ARCTIC"
        Me.btnarctic.UseVisualStyleBackColor = True
        '
        'btnbrowser
        '
        Me.btnbrowser.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbrowser.Location = New System.Drawing.Point(12, 192)
        Me.btnbrowser.Name = "btnbrowser"
        Me.btnbrowser.Size = New System.Drawing.Size(191, 43)
        Me.btnbrowser.TabIndex = 3
        Me.btnbrowser.Text = "SRMA BROWSER"
        Me.btnbrowser.UseVisualStyleBackColor = True
        '
        'btnlevox
        '
        Me.btnlevox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlevox.Location = New System.Drawing.Point(12, 290)
        Me.btnlevox.Name = "btnlevox"
        Me.btnlevox.Size = New System.Drawing.Size(191, 43)
        Me.btnlevox.TabIndex = 4
        Me.btnlevox.Text = "IC LEVOX"
        Me.btnlevox.UseVisualStyleBackColor = True
        '
        'btnsesame
        '
        Me.btnsesame.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsesame.Location = New System.Drawing.Point(12, 241)
        Me.btnsesame.Name = "btnsesame"
        Me.btnsesame.Size = New System.Drawing.Size(191, 43)
        Me.btnsesame.TabIndex = 5
        Me.btnsesame.Text = "SRMA SESAME"
        Me.btnsesame.UseVisualStyleBackColor = True
        '
        'btnback2
        '
        Me.btnback2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback2.Location = New System.Drawing.Point(143, 388)
        Me.btnback2.Name = "btnback2"
        Me.btnback2.Size = New System.Drawing.Size(60, 26)
        Me.btnback2.TabIndex = 6
        Me.btnback2.Text = "Back"
        Me.btnback2.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 426)
        Me.Controls.Add(Me.btnback2)
        Me.Controls.Add(Me.btnsesame)
        Me.Controls.Add(Me.btnlevox)
        Me.Controls.Add(Me.btnbrowser)
        Me.Controls.Add(Me.btnarctic)
        Me.Controls.Add(Me.btnemporium)
        Me.Controls.Add(Me.btnrhq)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnrhq As Button
    Friend WithEvents btnemporium As Button
    Friend WithEvents btnarctic As Button
    Friend WithEvents btnbrowser As Button
    Friend WithEvents btnlevox As Button
    Friend WithEvents btnsesame As Button
    Friend WithEvents btnback2 As Button
End Class
