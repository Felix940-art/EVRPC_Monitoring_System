Public Class Form3
    Private dgvEmploymentRecord As DataGridView
    Private btnSave As Button

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEmploymentRecord = New DataGridView With {
            .Left = 10,
            .Top = 10,
            .Width = Me.ClientSize.Width - 20,
            .Height = 250,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None,
            .AllowUserToAddRows = True,
            .AllowUserToResizeColumns = False,
            .AllowUserToResizeRows = False,
            .ScrollBars = ScrollBars.Both,
            .Name = "dgvEmploymentRecord"
        }

        With dgvEmploymentRecord
            .ColumnCount = 3
            .Columns(0).Name = "DATE"
            .Columns(0).Width = 150
            .Columns(1).Name = "OCCUPATION"
            .Columns(1).Width = 200
            .Columns(2).Name = "ADDRESS"
            .Columns(2).Width = 385


            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next
            With dgvEmploymentRecord.ColumnHeadersDefaultCellStyle
                .Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
        End With

        Me.Controls.Add(dgvEmploymentRecord)

        btnSave = New Button With {
            .Text = "Save",
            .Top = dgvEmploymentRecord.Bottom + 10,
            .Left = 10,
            .Width = 150
        }

        AddHandler btnSave.Click, AddressOf BtnSave_Click
        Me.Controls.Add(btnSave)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs)
        Dim employmentrecordData As New List(Of String())

        For Each row As DataGridViewRow In dgvEmploymentRecord.Rows
            If Not row.IsNewRow Then
                Dim rowData(4) As String
                For i As Integer = 0 To 2
                    rowData(i) = If(row.Cells(i).Value?.ToString(), "")
                Next
                employmentrecordData.Add(rowData)
            End If
        Next

        MessageBox.Show("Data saved. Entries: " & employmentrecordData.Count.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        Form1.Show()
    End Sub
    Public ReadOnly Property EmploymentRecordData As List(Of String())
        Get
            Dim list As New List(Of String())()
            For Each row As DataGridViewRow In dgvEmploymentRecord.Rows
                If Not row.IsNewRow Then
                    list.Add(New String() {
                    row.Cells(0).Value?.ToString(),
                    row.Cells(1).Value?.ToString(),
                    row.Cells(2).Value?.ToString()
                })
                End If
            Next
            Return list
        End Get
    End Property

End Class