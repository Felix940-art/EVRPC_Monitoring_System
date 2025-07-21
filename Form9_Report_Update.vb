Public Class Form9_Report_Update
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim nextForm As New Form10_Report()
        nextForm.Show()
        Me.Hide()
    End Sub

End Class