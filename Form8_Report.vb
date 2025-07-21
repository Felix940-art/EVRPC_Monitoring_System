Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Public Class Form8_Report
    Dim dt As New DataTable()
    Dim connStr As String = "server=localhost;user id=root;password=;database=evrpc_db"
    Dim conn As MySqlConnection

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn = New MySqlConnection(connStr)
            conn.Open()

            Dim query As String = "SELECT * FROM report_table"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)

            ListBox1.Items.Clear()
            For Each row As DataRow In dt.Rows
                ' You can choose to show Source or Date
                ListBox1.Items.Add(row("Source").ToString())
            Next

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If ListBox1.SelectedIndex >= 0 Then
            Dim selectedValue As String = ListBox1.SelectedItem.ToString()
            Dim matchedRow As DataRow = dt.AsEnumerable().FirstOrDefault(Function(row) row("source").ToString() = selectedValue)
            If matchedRow IsNot Nothing Then
                Dim reportForm As New reportForm()
                reportForm.lbldate.Text = matchedRow("Date").ToString()
                reportForm.lblsource.Text = matchedRow("Source").ToString()
                reportForm.lblactivity.Text = matchedRow("Activity").ToString()
                reportForm.lbltoa.Text = matchedRow("Listbox").ToString()
                reportForm.lbldetails.Text = matchedRow("Details").ToString()
                reportForm.lbltitle.Text = matchedRow("Title").ToString()
                Dim parsedDate As DateTime
                If DateTime.TryParse(matchedRow("Date").ToString(), parsedDate) Then
                    Form1_Report.datetimepicker.Value = parsedDate
                End If
                reportForm.Show()
            End If
        End If
    End Sub
End Class