Public Class Form5
    Private dgvCoursesTrainingUndertaken As DataGridView
    Private btnSave As Button

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCoursesTrainingUndertaken = New DataGridView With {
            .Left = 10,
            .Top = 10,
            .Width = Me.ClientSize.Width - 20,
            .Height = 250,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None,
            .AllowUserToAddRows = True,
            .AllowUserToResizeColumns = False,
            .AllowUserToResizeRows = False,
            .ScrollBars = ScrollBars.Both,
            .Name = "dgvCoursesTrainingUndertaken"
        }

        With dgvCoursesTrainingUndertaken
            .ColumnCount = 2
            .Columns(0).Name = "DATE"
            .Columns(0).Width = 150
            .Columns(1).Name = "COURSE / TRAINING UNDERTAKEN"
            .Columns(1).Width = 585

            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next
            With dgvCoursesTrainingUndertaken.ColumnHeadersDefaultCellStyle
                .Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
        End With

        Me.Controls.Add(dgvCoursesTrainingUndertaken)

        btnSave = New Button With {
            .Text = "Save",
            .Top = dgvCoursesTrainingUndertaken.Bottom + 10,
            .Left = 10,
            .Width = 150
        }

        AddHandler btnSave.Click, AddressOf BtnSave_Click
        Me.Controls.Add(btnSave)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs)
        Dim CoursesTrainingUndertakenData As New List(Of String())

        For Each row As DataGridViewRow In dgvCoursesTrainingUndertaken.Rows
            If Not row.IsNewRow Then
                Dim rowData(4) As String
                For i As Integer = 0 To 1
                    rowData(i) = If(row.Cells(i).Value?.ToString(), "")
                Next
                CoursesTrainingUndertakenData.Add(rowData)
            End If
        Next

        MessageBox.Show("Data saved. Entries: " & CoursesTrainingUndertakenData.Count.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        Form1.Show()
    End Sub
    Public ReadOnly Property CoursesTrainingUndertakenData As List(Of String())
        Get
            Dim list As New List(Of String())()
            For Each row As DataGridViewRow In dgvCoursesTrainingUndertaken.Rows
                If Not row.IsNewRow Then
                    list.Add(New String() {
                    row.Cells(0).Value?.ToString(),
                    row.Cells(1).Value?.ToString()
                })
                End If
            Next
            Return list
        End Get
    End Property

End Class