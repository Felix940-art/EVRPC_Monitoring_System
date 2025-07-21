Public Class Form4_Report
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub btnback2_Click(sender As Object, e As EventArgs) Handles btnback2.Click
        Dim Form5 As New Form5_Report()
        Form5.Show()
        Me.Close() ' Closes Form4
    End Sub
End Class