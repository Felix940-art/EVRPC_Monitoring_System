<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1_Report
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
        lbldate = New Label()
        lblsource = New Label()
        txtsource = New TextBox()
        cmbox = New ComboBox()
        Label1 = New Label()
        listbox = New ListBox()
        btnrecordreport = New Button()
        lbldetails = New Label()
        txtdetail = New TextBox()
        lblattach = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        txtattach = New TextBox()
        btnpreview = New Button()
        DataGridView1 = New DataGridView()
        datetimepicker = New DateTimePicker()
        txtdate = New TextBox()
        title = New Label()
        txttitle = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbldate
        ' 
        lbldate.AutoSize = True
        lbldate.Location = New Point(32, 45)
        lbldate.Margin = New Padding(4, 0, 4, 0)
        lbldate.Name = "lbldate"
        lbldate.Size = New Size(41, 20)
        lbldate.TabIndex = 0
        lbldate.Text = "Date"
        ' 
        ' lblsource
        ' 
        lblsource.AutoSize = True
        lblsource.Location = New Point(32, 102)
        lblsource.Margin = New Padding(4, 0, 4, 0)
        lblsource.Name = "lblsource"
        lblsource.Size = New Size(54, 20)
        lblsource.TabIndex = 1
        lblsource.Text = "Source"
        ' 
        ' txtsource
        ' 
        txtsource.Location = New Point(124, 97)
        txtsource.Margin = New Padding(4, 5, 4, 5)
        txtsource.Name = "txtsource"
        txtsource.Size = New Size(264, 27)
        txtsource.TabIndex = 3
        ' 
        ' cmbox
        ' 
        cmbox.FormattingEnabled = True
        cmbox.Location = New Point(123, 211)
        cmbox.Margin = New Padding(4, 5, 4, 5)
        cmbox.Name = "cmbox"
        cmbox.Size = New Size(264, 28)
        cmbox.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 211)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 20)
        Label1.TabIndex = 9
        Label1.Text = "Activity"
        ' 
        ' listbox
        ' 
        listbox.FormattingEnabled = True
        listbox.Location = New Point(425, 57)
        listbox.Margin = New Padding(4, 5, 4, 5)
        listbox.Name = "listbox"
        listbox.Size = New Size(277, 124)
        listbox.TabIndex = 10
        ' 
        ' btnrecordreport
        ' 
        btnrecordreport.Location = New Point(804, 634)
        btnrecordreport.Margin = New Padding(4, 5, 4, 5)
        btnrecordreport.Name = "btnrecordreport"
        btnrecordreport.Size = New Size(169, 40)
        btnrecordreport.TabIndex = 11
        btnrecordreport.Text = "Record Report"
        btnrecordreport.UseMnemonic = False
        btnrecordreport.UseVisualStyleBackColor = True
        ' 
        ' lbldetails
        ' 
        lbldetails.AutoSize = True
        lbldetails.Location = New Point(35, 260)
        lbldetails.Margin = New Padding(4, 0, 4, 0)
        lbldetails.Name = "lbldetails"
        lbldetails.Size = New Size(55, 20)
        lbldetails.TabIndex = 12
        lbldetails.Text = "Details"
        ' 
        ' txtdetail
        ' 
        txtdetail.Location = New Point(123, 260)
        txtdetail.Margin = New Padding(4, 5, 4, 5)
        txtdetail.Multiline = True
        txtdetail.Name = "txtdetail"
        txtdetail.Size = New Size(764, 181)
        txtdetail.TabIndex = 13
        ' 
        ' lblattach
        ' 
        lblattach.AutoSize = True
        lblattach.Location = New Point(35, 452)
        lblattach.Margin = New Padding(4, 0, 4, 0)
        lblattach.Name = "lblattach"
        lblattach.Size = New Size(70, 20)
        lblattach.TabIndex = 14
        lblattach.Text = "Attach to"
        ' 
        ' txtattach
        ' 
        txtattach.Location = New Point(125, 452)
        txtattach.Margin = New Padding(4, 5, 4, 5)
        txtattach.Name = "txtattach"
        txtattach.Size = New Size(148, 27)
        txtattach.TabIndex = 16
        ' 
        ' btnpreview
        ' 
        btnpreview.Location = New Point(16, 635)
        btnpreview.Margin = New Padding(4, 5, 4, 5)
        btnpreview.Name = "btnpreview"
        btnpreview.Size = New Size(169, 38)
        btnpreview.TabIndex = 19
        btnpreview.Text = "Preview"
        btnpreview.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(281, 452)
        DataGridView1.Margin = New Padding(4, 5, 4, 5)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(168, 198)
        DataGridView1.TabIndex = 20
        ' 
        ' datetimepicker
        ' 
        datetimepicker.Format = DateTimePickerFormat.Custom
        datetimepicker.Location = New Point(123, -2)
        datetimepicker.Margin = New Padding(4, 5, 4, 5)
        datetimepicker.Name = "datetimepicker"
        datetimepicker.Size = New Size(265, 27)
        datetimepicker.TabIndex = 21
        datetimepicker.Value = New Date(2025, 7, 17, 0, 0, 0, 0)
        ' 
        ' txtdate
        ' 
        txtdate.Location = New Point(125, 46)
        txtdate.Margin = New Padding(4, 5, 4, 5)
        txtdate.Name = "txtdate"
        txtdate.ReadOnly = True
        txtdate.Size = New Size(261, 27)
        txtdate.TabIndex = 22
        ' 
        ' title
        ' 
        title.AutoSize = True
        title.Location = New Point(36, 152)
        title.Margin = New Padding(4, 0, 4, 0)
        title.Name = "title"
        title.Size = New Size(38, 20)
        title.TabIndex = 23
        title.Text = "Title"
        ' 
        ' txttitle
        ' 
        txttitle.Location = New Point(123, 152)
        txttitle.Margin = New Padding(4, 5, 4, 5)
        txttitle.Name = "txttitle"
        txttitle.Size = New Size(264, 27)
        txttitle.TabIndex = 24
        ' 
        ' Form1_Report
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(996, 692)
        Controls.Add(txttitle)
        Controls.Add(title)
        Controls.Add(txtdate)
        Controls.Add(datetimepicker)
        Controls.Add(DataGridView1)
        Controls.Add(btnpreview)
        Controls.Add(txtattach)
        Controls.Add(lblattach)
        Controls.Add(txtdetail)
        Controls.Add(lbldetails)
        Controls.Add(btnrecordreport)
        Controls.Add(listbox)
        Controls.Add(Label1)
        Controls.Add(cmbox)
        Controls.Add(txtsource)
        Controls.Add(lblsource)
        Controls.Add(lbldate)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1_Report"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RECORD"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lbldate As Label
    Friend WithEvents lblsource As Label
    Friend WithEvents txtsource As TextBox
    Friend WithEvents cmbox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents listbox As ListBox
    Friend WithEvents btnrecordreport As Button
    Friend WithEvents lbldetails As Label
    Friend WithEvents txtdetail As TextBox
    Friend WithEvents lblattach As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtattach As TextBox
    Friend WithEvents btnpreview As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents datetimepicker As DateTimePicker
    Friend WithEvents txtdate As TextBox
    Friend WithEvents title As Label
    Friend WithEvents txttitle As TextBox
End Class
