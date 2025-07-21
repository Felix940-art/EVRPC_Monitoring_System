<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10_Report
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
        DataGridView2 = New DataGridView()
        txtsearch = New TextBox()
        lblsearch = New Label()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView2
        ' 
        DataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(149, 172)
        DataGridView2.Margin = New Padding(4, 5, 4, 5)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(812, 428)
        DataGridView2.TabIndex = 0
        ' 
        ' txtsearch
        ' 
        txtsearch.Location = New Point(149, 114)
        txtsearch.Margin = New Padding(4, 5, 4, 5)
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(431, 27)
        txtsearch.TabIndex = 1
        ' 
        ' lblsearch
        ' 
        lblsearch.AutoSize = True
        lblsearch.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblsearch.Location = New Point(16, 114)
        lblsearch.Margin = New Padding(4, 0, 4, 0)
        lblsearch.Name = "lblsearch"
        lblsearch.Size = New Size(117, 29)
        lblsearch.TabIndex = 2
        lblsearch.Text = "SEARCH"
        ' 
        ' Form10_Report
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1067, 692)
        Controls.Add(lblsearch)
        Controls.Add(txtsearch)
        Controls.Add(DataGridView2)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form10_Report"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form10"
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents lblsearch As Label
End Class
