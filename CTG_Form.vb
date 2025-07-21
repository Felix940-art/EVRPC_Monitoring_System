Public Class CTG_Form
    Private Sub CTG_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStrip1.Renderer = New CustomRenderer
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
    Private Sub VERTICALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERTICALToolStripMenuItem.Click
        Dim evrpcMRGU As New Sampletaskorg
        evrpcMRGU.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub NSFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NSFToolStripMenuItem.Click
        Dim nsf As New NSF_TaskOrg
        nsf.ShowDialog()
    End Sub

    Private Sub YAKALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YAKALToolStripMenuItem.Click
        Dim yakal As New Yakal_TaskOrg
        yakal.ShowDialog()
    End Sub


End Class