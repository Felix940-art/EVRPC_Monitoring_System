Public Class Form7_PPS
    Private dgvOrganizationsAffiliated As DataGridView
    Private btnSave As Button

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOrganizationsAffiliated = New DataGridView With {
            .Left = 10,
            .Top = 10,
            .Width = Me.ClientSize.Width - 20,
            .Height = 250,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None,
            .AllowUserToAddRows = True,
            .AllowUserToResizeColumns = False,
            .AllowUserToResizeRows = False,
            .ScrollBars = ScrollBars.Both,
            .Name = "dgvOrganizationsAffiliated"
        }

        With dgvOrganizationsAffiliated
            .ColumnCount = 4
            .Columns(0).Name = "ORGANIZATION"
            .Columns(0).Width = 150
            .Columns(1).Name = "DESCRIPTION"
            .Columns(1).Width = 200
            .Columns(2).Name = "NATURE OF AFFILIATION"
            .Columns(2).Width = 275
            .Columns(3).Name = "REMARKS"
            .Columns(3).Width = 110

            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        Me.Controls.Add(dgvOrganizationsAffiliated)

        btnSave = New Button With {
            .Text = "Save",
            .Top = dgvOrganizationsAffiliated.Bottom + 10,
            .Left = 10,
            .Width = 150
        }

        AddHandler btnSave.Click, AddressOf BtnSave_Click
        Me.Controls.Add(btnSave)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs)
        ' Optional message - you can remove this if not needed
        MessageBox.Show("Data saved. Entries: " & OrganizationsAffiliatedData.Count.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Close this form and return to Form1
        Me.Close()
        Form1.Show()
    End Sub

    Public ReadOnly Property OrganizationsAffiliatedData As List(Of String())
        Get
            Dim list As New List(Of String())()
            For Each row As DataGridViewRow In dgvOrganizationsAffiliated.Rows
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