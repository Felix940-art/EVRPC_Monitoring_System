Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Imports System.IO

Public Class Form1_Report

    Dim connStr As String = "server=localhost;user id=root;password=;database=evrpc_db"
    Dim conn As New MySqlConnection(connStr)

    Private Sub frmrecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadnametoDatagrid()

        datetimepicker.Format = DateTimePickerFormat.Custom
        datetimepicker.CustomFormat = "yyyy-MM-dd"

        LoadnametoDatagrid()

        cmbox.Items.Add("VIOLENT")
        cmbox.Items.Add("Non-VIOLENT")
        cmbox.Items.Add("IPSO")
        cmbox.SelectedIndex = 0

        'DataGridView1.Columns.Add("colName", "date")
        'DataGridView1.Columns.Add("colSource", "source")
        'DataGridView1.Columns.Add("colActivity", "activity")
        'DataGridView1.Columns.Add("colDetails", "details")
        'DataGridView1.Columns.Add("colAttach_to", "attach_to")
        'DataGridView1.Columns.Add("colListbox", "listbox")

    End Sub

    Private Sub LoadnametoDatagrid()
        Try
            conn.Open()
            Dim query As String = "SELECT attach_to AS 'Attach To' FROM report_table"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading names: " & ex.Message)
        End Try
    End Sub

    Private Sub cmbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbox.SelectedIndexChanged
        cmbox.DropDownStyle = ComboBoxStyle.DropDownList

        listbox.Items.Clear()


        Select Case cmbox.SelectedItem.ToString()
            Case "VIOLENT"
                listbox.Items.Add("Abduction")
                listbox.Items.Add("Ambush")
                listbox.Items.Add("Arson")
                listbox.Items.Add("Harassment")
                listbox.Items.Add("Land Mining")
                listbox.Items.Add("Liquidation")
                listbox.Items.Add("Raid")
            Case "Non-VIOLENT"
                listbox.Items.Add("Checkpoint")
                listbox.Items.Add("Confiscation")
                listbox.Items.Add("Consolidation")
                listbox.Items.Add("Extortion")
                listbox.Items.Add("Foraging")
                listbox.Items.Add("Liquidation")
                listbox.Items.Add("IPO")
                listbox.Items.Add("Logistic Procurement")
                listbox.Items.Add("Logistic Transport")
                listbox.Items.Add("Meeting")
                listbox.Items.Add("Movement")
                listbox.Items.Add("Planning")
                listbox.Items.Add("Propaganda")
                listbox.Items.Add("Rally")
                listbox.Items.Add("Recruitment")
                listbox.Items.Add("Visitation")
            Case "IPSO"
                listbox.Items.Add("Encounter")
                listbox.Items.Add("Surrender")
                listbox.Items.Add("Discovery of Arms Cache")
                listbox.Items.Add("Discovery of Food Cache")
                listbox.Items.Add("Discovery of War Materials/Paraphernalia")
                listbox.Items.Add("Discovery of Temporary Hideout")
        End Select


    End Sub

    Private Sub Btnrecordreport_Click(sender As Object, e As EventArgs) Handles btnrecordreport.Click
        Dim selectedDate As String = datetimepicker.Value.ToString("yyyy-MM-dd")
        Dim f8 As New Form8_Report()
        Form8_Report.ListBox1.Items.Add(selectedDate)

        Dim ConnStr As String = "server=localhost;user id=root;password=;database=evrpc_db"
        Using conn As New MySqlConnection(ConnStr)
            Try
                conn.Open()

                Dim query As String = "INSERT INTO report_table (`Date`, `Source`, `Activity`, `listbox`, `Details`, `Attach_to`,`Title`) " &
                                      "VALUES (@date, @source, @activity, @listbox, @details, @attach_to, @Title)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@date", datetimepicker.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@source", txtsource.Text)
                    cmd.Parameters.AddWithValue("@activity", cmbox.Text)
                    cmd.Parameters.AddWithValue("@listbox", listbox.Text)
                    cmd.Parameters.AddWithValue("@details", txtdetail.Text)
                    cmd.Parameters.AddWithValue("@attach_to", txtattach.Text)
                    cmd.Parameters.AddWithValue("@Title", txttitle.Text)
                    Dim result As Integer = cmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim nextForm As New Form8_Report()
                        nextForm.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("No data inserted. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using

            Catch ex As MySqlException
                MessageBox.Show("Database Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnpreview_Click(sender As Object, e As EventArgs) Handles btnpreview.Click
        Dim connection As New MySqlConnection("server=localhost;user id=root;password=;database=evrpc_db")
        Try
            conn.Open()
            Dim query As String = "SELECT attach_to AS 'Attach To' FROM report_table"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub txtattach_TextChanged(sender As Object, e As EventArgs) Handles txtattach.TextChanged
        SearchNameByFirstLetter(txtattach.Text)
    End Sub
    Private Sub SearchNameByFirstLetter(keyword As String)
        Try
            conn.Open()

            Dim query As String = "SELECT attach_to FROM report_table WHERE attach_to LIKE @attach_to"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Attach_to", keyword & "%") ' starts with the typed letters

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim connection As New MySqlConnection("server=localhost;user id=root;password=;database=evrpc_db")
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtattach.Text = selectedRow.Cells(0).Value.ToString() ' Change 0 to the correct column index
        End If
    End Sub

End Class
