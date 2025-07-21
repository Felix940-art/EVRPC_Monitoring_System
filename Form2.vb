Imports MySql.Data.MySqlClient

Public Class Form2

    Private dgvFamilyMembers As DataGridView
    Private btnSave As Button
    Public Property CurrentPPSID As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupDataGridView()
        LoadFamilyMembers(CurrentPPSID)
    End Sub

    Private Sub SetupDataGridView()
        dgvFamilyMembers = New DataGridView With {
            .Left = 10,
            .Top = 10,
            .Width = Me.ClientSize.Width - 20,
            .Height = 250,
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None,
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing,
            .ColumnHeadersHeightSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing,
            .AllowUserToAddRows = True,
            .AllowUserToResizeColumns = False,
            .AllowUserToResizeRows = False,
            .ScrollBars = ScrollBars.Both,
            .Name = "dgvFamilyMembers"
        }
        For Each col As DataGridViewColumn In dgvFamilyMembers.Columns
            col.Resizable = DataGridViewTriState.False
            col.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next

        With dgvFamilyMembers
            .ColumnCount = 5
            .Columns(0).Name = "NAME"
            .Columns(0).Width = 150
            .Columns(1).Name = "RELATION"
            .Columns(1).Width = 110
            .Columns(2).Name = "OCCUPATION"
            .Columns(2).Width = 120
            .Columns(3).Name = "ADDRESS"
            .Columns(3).Width = 250
            .Columns(4).Name = "REMARKS"
            .Columns(4).Width = 105

            For Each col As DataGridViewColumn In dgvFamilyMembers.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial Narrow", 10, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
            .ColumnHeadersHeight = 35
        End With

        Me.Controls.Add(dgvFamilyMembers)

        btnSave = New Button With {
            .Text = "Save",
            .Top = dgvFamilyMembers.Bottom + 10,
            .Left = 10,
            .Width = 150
        }
        AddHandler btnSave.Click, AddressOf BtnSave_Click
        Me.Controls.Add(btnSave)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(CurrentPPSID) Then
            MessageBox.Show("Please save the personality record first before adding data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim connStr As String = "server=localhost;user id=root;password=;database=evrpc_pps;"
        Dim savedCount As Integer = 0

        Using conn As New MySqlConnection(connStr)
            conn.Open()

            For Each row As DataGridViewRow In dgvFamilyMembers.Rows
                If row.IsNewRow Then Continue For

                If row.Cells.Cast(Of DataGridViewCell).All(Function(c) String.IsNullOrWhiteSpace(Convert.ToString(c.Value))) Then
                    Continue For
                End If

                Using insertCmd As New MySqlCommand("INSERT INTO pps_familymembers " &
                "(PPS_FMName, PPS_FMRelation, PPS_FMOccupation, PPS_FMAddress, PPS_FMRemarks, PPS_ID) " &
                "VALUES (@name, @relation, @occupation, @address, @remarks, @pps_id)", conn)

                    insertCmd.Parameters.AddWithValue("@name", If(row.Cells(0).Value?.ToString(), ""))
                    insertCmd.Parameters.AddWithValue("@relation", If(row.Cells(1).Value?.ToString(), ""))
                    insertCmd.Parameters.AddWithValue("@occupation", If(row.Cells(2).Value?.ToString(), ""))
                    insertCmd.Parameters.AddWithValue("@address", If(row.Cells(3).Value?.ToString(), ""))
                    insertCmd.Parameters.AddWithValue("@remarks", If(row.Cells(4).Value?.ToString(), ""))
                    insertCmd.Parameters.AddWithValue("@pps_id", CurrentPPSID)

                    insertCmd.ExecuteNonQuery()
                    savedCount += 1
                End Using
            Next
        End Using

        MessageBox.Show("Data saved. Entries: " & savedCount.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Public Sub LoadFamilyMembers(ByVal ppsID As String)
        dgvFamilyMembers.Rows.Clear()

        Dim connStr As String = "server=localhost;user id=root;password=;database=evrpc_pps;"
        Using conn As New MySqlConnection(connStr)
            conn.Open()

            Dim query As String = "
                SELECT PPS_FMName, PPS_FMRelation, PPS_FMOccupation, PPS_FMAddress, PPS_FMRemarks 
                FROM pps_familymembers 
                WHERE PPS_ID = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", ppsID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        dgvFamilyMembers.Rows.Add(
                            reader("PPS_FMName").ToString(),
                            reader("PPS_FMRelation").ToString(),
                            reader("PPS_FMOccupation").ToString(),
                            reader("PPS_FMAddress").ToString(),
                            reader("PPS_FMRemarks").ToString()
                        )
                    End While
                End Using
            End Using
        End Using
    End Sub

    Public ReadOnly Property FamilyMembers As List(Of String())
        Get
            Dim list As New List(Of String())()
            For Each row As DataGridViewRow In dgvFamilyMembers.Rows
                If Not row.IsNewRow Then
                    list.Add(New String() {
                        row.Cells(0).Value?.ToString(),
                        row.Cells(1).Value?.ToString(),
                        row.Cells(2).Value?.ToString(),
                        row.Cells(3).Value?.ToString(),
                        row.Cells(4).Value?.ToString()
                    })
                End If
            Next
            Return list
        End Get
    End Property

End Class