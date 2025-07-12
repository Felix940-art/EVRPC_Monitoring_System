Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Close()
    End Sub
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        MsgBox("Login Successfully", MsgBoxStyle.YesNo,)
    End Sub
End Class