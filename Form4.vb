Public Class Form4
    Private dgvAdministrativeCriminalRecord As DataGridView
    Private btnSave As Button

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvAdministrativeCriminalRecord = New DataGridView With {
            .Left = 10,
            .Top = 10,
            .Width = Me.ClientSize.Width - 20,
            .Height = 250,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None,
            .AllowUserToAddRows = True,
            .AllowUserToResizeColumns = False,
            .AllowUserToResizeRows = False,
            .ScrollBars = ScrollBars.Both,
            .Name = "dgvAdministrativeCriminalRecord"
        }

        With dgvAdministrativeCriminalRecord
            .ColumnCount = 3
            .Columns(0).Name = "CASE NUMBER"
            .Columns(0).Width = 150
            .Columns(1).Name = "CASE TITLE"
            .Columns(1).Width = 385
            .Columns(2).Name = "REMARKS"
            .Columns(2).Width = 200


            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next
            With dgvAdministrativeCriminalRecord.ColumnHeadersDefaultCellStyle
                .Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
        End With

        Me.Controls.Add(dgvAdministrativeCriminalRecord)

        btnSave = New Button With {
            .Text = "Save",
            .Top = dgvAdministrativeCriminalRecord.Bottom + 10,
            .Left = 10,
            .Width = 150
        }

        AddHandler btnSave.Click, AddressOf BtnSave_Click
        Me.Controls.Add(btnSave)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs)
        Dim AdministrativeCriminalRecordData As New List(Of String())

        For Each row As DataGridViewRow In dgvAdministrativeCriminalRecord.Rows
            If Not row.IsNewRow Then
                Dim rowData(4) As String
                For i As Integer = 0 To 2
                    rowData(i) = If(row.Cells(i).Value?.ToString(), "")
                Next
                AdministrativeCriminalRecordData.Add(rowData)
            End If
        Next

        MessageBox.Show("Data saved. Entries: " & AdministrativeCriminalRecordData.Count.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        Form1.Show()
    End Sub
    Public ReadOnly Property AdministrativeCriminalRecordData As List(Of String())
        Get
            Dim list As New List(Of String())()
            For Each row As DataGridViewRow In dgvAdministrativeCriminalRecord.Rows
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