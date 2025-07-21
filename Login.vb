Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Class Login
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Dim result As New DialogResult
        result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        login()
    End Sub

    Private Sub show_password_CheckedChanged(sender As Object, e As EventArgs) Handles show_password.CheckedChanged
        If Textbox_Password.UseSystemPasswordChar Then
            Textbox_Password.UseSystemPasswordChar = False
        Else
            Textbox_Password.UseSystemPasswordChar = True
        End If
    End Sub

    Sub login()
        Dim db As New My_DB
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        Dim com As New MySqlCommand("SELECT * FROM `admin` WHERE `username` = @usr_nm AND `password` = @psswrd", db.getConnection)
        com.Parameters.Add("usr_nm", MySqlDbType.VarChar).Value = Textbox_Username.Text
        com.Parameters.Add("psswrd", MySqlDbType.VarChar).Value = Textbox_Password.Text

        adapter.SelectCommand = com
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Dim dash_b As New main_dashboard
            MsgBox("Login Successfully", MsgBoxStyle.OkOnly, "EVRPC")
            dash_b.Show()
            Me.Hide()
        Else
            Error_Form.Show()
            Error_Form.Label2.Text = "Invalid Input"
            Error_Form.Label3.Text = "Incorrect Username or Password"
        End If

    End Sub
End Class