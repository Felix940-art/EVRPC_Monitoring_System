Public Class Form5_Report
    Private Sub btnvertical_Click(sender As Object, e As EventArgs) Handles btnvertical.Click

        Dim form3 As New Form3_Report()
        form3.Show()
        Me.Hide()

    End Sub

    Private Sub bnthorizontal_Click(sender As Object, e As EventArgs) Handles btnhorizontal.Click

        Dim form4 As New Form4_Report()
        form4.Show()
        Me.Hide()

    End Sub

    Private Sub Form5_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class