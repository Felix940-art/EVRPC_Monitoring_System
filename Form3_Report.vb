Public Class Form3_Report

    Private Sub btnback1_Click(sender As Object, e As EventArgs) Handles btnback1.Click
        Dim Form5 As New Form5_Report()
        Form5.Show()
        Me.Close() ' Closes Form3
    End Sub
End Class