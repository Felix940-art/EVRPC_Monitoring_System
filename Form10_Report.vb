Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Imports System.IO

Public Class Form10_Report

    Dim connStr As String = "server=localhost;user id=root;password=;database=evrpc_db"
    Dim conn As New MySqlConnection(connStr)

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        SearchNameByFirstLetter(txtsearch.Text)
    End Sub

    Private Sub SearchNameByFirstLetter(keyword As String)
        Try
            conn.Open()

            Dim query As String = "SELECT * FROM report_table WHERE attach_to LIKE @attach_to"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@attach_to", keyword & "%")

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView2.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub DeleteRecord(id As Integer)
        Try
            conn.Open()
            Dim query As String = "DELETE FROM report_table WHERE Date = @date, Source = @source, Activity = @activity, Details = @details, Attach_to = @attach_to, Listbox = @listbox, Title = @title"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Date", id)
            cmd.Parameters.AddWithValue("@Source", id)
            cmd.Parameters.AddWithValue("@Activity", id)
            cmd.Parameters.AddWithValue("@Details", id)
            cmd.Parameters.AddWithValue("@Attach_to", id)
            cmd.Parameters.AddWithValue("@Listbox", id)
            Dim result As Integer = cmd.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record deleted.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView2.Rows(e.RowIndex)

            ' Get values if needed
            Dim idValue As Integer = Convert.ToInt32(selectedRow.Cells("id").Value) ' Column must exist
            Dim dateValue As String = Convert.ToInt32(selectedRow.Cells("Date").Value)
            Dim sourceValue As String = Convert.ToInt32(selectedRow.Cells("Source").Value)
            Dim activityValue As String = Convert.ToInt32(selectedRow.Cells("Activity").Value)
            Dim detailsValue As String = Convert.ToInt32(selectedRow.Cells("Details").Value)
            Dim attachToValue As String = Convert.ToInt32(selectedRow.Cells("Attach_to").Value)
            Dim listboxValue As String = Convert.ToInt32(selectedRow.Cells("Listbox").Value)
            Dim titleValue As String = Convert.ToInt32(selectedRow.Cells("Title").Value)

            'Dim dateValue As String = selectedRow.Cells("Date").Value.ToString()
            'Dim sourceValue As String = selectedRow.Cells("Source").Value.ToString()
            'Dim activityValue As String = selectedRow.Cells("Activity").Value.ToString()
            'Dim detailsValue As String = selectedRow.Cells("Details").Value.ToString()
            'Dim attachToValue As String = selectedRow.Cells("Attach_to").Value.ToString()
            'Dim listboxValue As String = selectedRow.Cells("Listbox").Value.ToString()
            'Dim titleValue As String = selectedRow.Cells("Title").Value.ToString()

            ' Confirm deletion
            Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If confirmDelete = DialogResult.Yes Then
                DeleteRecord(idValue)
                LoadDataGridView()
            End If
        End If
    End Sub



    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGridView()
    End Sub


    Private Sub LoadDataGridView()
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM report_table"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridView2.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class