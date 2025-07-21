Public Class Form6
    Private dgvAssociatedPersonalities As DataGridView
    Private btnSave As Button

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvAssociatedPersonalities = New DataGridView With {
            .Left = 10,
            .Top = 10,
            .Width = Me.ClientSize.Width - 20,
            .Height = 250,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None,
            .AllowUserToAddRows = True,
            .AllowUserToResizeColumns = False,
            .AllowUserToResizeRows = False,
            .ScrollBars = ScrollBars.Both,
            .Name = "dgvAssociatedPersonalities"
        }

        With dgvAssociatedPersonalities
            .ColumnCount = 4
            .Columns(0).Name = "NAME"
            .Columns(0).Width = 220
            .Columns(1).Name = "POSITION"
            .Columns(1).Width = 120
            .Columns(2).Name = "ORGANIZATION"
            .Columns(2).Width = 130
            .Columns(3).Name = "ASSOCIATION/RELATIONSHIP"
            .Columns(3).Width = 265

            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next
            With dgvAssociatedPersonalities.ColumnHeadersDefaultCellStyle
                .Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
        End With

        Me.Controls.Add(dgvAssociatedPersonalities)

        btnSave = New Button With {
            .Text = "Save",
            .Top = dgvAssociatedPersonalities.Bottom + 10,
            .Left = 10,
            .Width = 150
        }

        AddHandler btnSave.Click, AddressOf BtnSave_Click
        Me.Controls.Add(btnSave)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs)
        Dim AssociatedPersonalitiesData As New List(Of String())

        For Each row As DataGridViewRow In dgvAssociatedPersonalities.Rows
            If Not row.IsNewRow Then
                Dim rowData(4) As String
                For i As Integer = 0 To 3
                    rowData(i) = If(row.Cells(i).Value?.ToString(), "")
                Next
                AssociatedPersonalitiesData.Add(rowData)
            End If
        Next

        MessageBox.Show("Data saved. Entries: " & AssociatedPersonalitiesData.Count.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        Form1.Show()
    End Sub
    Public ReadOnly Property AssociatedPersonalitiesData As List(Of String())
        Get
            Dim list As New List(Of String())()
            For Each row As DataGridViewRow In dgvAssociatedPersonalities.Rows
                If Not row.IsNewRow Then
                    list.Add(New String() {
                    row.Cells(0).Value?.ToString(),
                    row.Cells(1).Value?.ToString(),
                    row.Cells(2).Value?.ToString(),
                    row.Cells(3).Value?.ToString()
                })
                End If
            Next
            Return list
        End Get
    End Property
End Class