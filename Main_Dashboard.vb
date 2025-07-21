Imports System.Data.SqlTypes

Public Class Main_Dashboard
    Dim ctghover As CTG_Form
    Dim myToolTip As New ToolTip
    Dim result As DialogResult
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctg.BackColor = Color.Transparent
        Timer1.Start()
        For Each item As ToolStripMenuItem In MenuStrip1.Items
            item.ForeColor = Color.WhiteSmoke
            SetSubItemColor(item, Color.Red)
        Next
        'MenuStrip1.Renderer = New Custom_MenuStrip_Hover

        myToolTip.SetToolTip(ctg, "This panel will bring you to the Communist Terrorist Group's Vertical and Horizontal platform.")
        myToolTip.SetToolTip(informants, "This panel will show you the List of Informants.")
        myToolTip.SetToolTip(aa, "This panel will show you the List of Action Agents.")
        myToolTip.SetToolTip(fr, "This panel will show you the List of Former Rebels.")
        myToolTip.SetToolTip(od, "This panel will show you the List of Operational Data.")
        myToolTip.SetToolTip(Label7, "This Monitoring System is Originated from 84MICO(T)")
        myToolTip.SetToolTip(lbl_exit, "Terminate the system")
    End Sub
    Private Sub SetSubItemColor(menuItem As ToolStripMenuItem, color As Color)
        For Each subItem As ToolStripItem In menuItem.DropDownItems
            subItem.ForeColor = color
            If TypeOf subItem Is ToolStripMenuItem Then
                SetSubItemColor(CType(subItem, ToolStripMenuItem), color)
            End If
        Next
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy - hh:mm:ss tt")
    End Sub
    Private Sub lbl_exit_Click(sender As Object, e As EventArgs) Handles lbl_exit.Click
        result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
            Login.Show()
        End If
    End Sub
    'Private Sub ctg_MouseEnter(sender As Object, e As EventArgs) Handles ctg.MouseEnter
    '    If ctghover Is Nothing OrElse ctghover.IsDisposed Then
    '        ctghover = New CTG_Form
    '        ctghover.Show()
    '    End If
    'End Sub
    'Private Sub ctg_MouseLeave(sender As Object, e As EventArgs) Handles ctg.MouseLeave
    '    If ctghover IsNot Nothing AndAlso Not ctghover.IsDisposed Then
    '        ctghover.Close()
    '    End If
    'End Sub
    Private Sub ctg_Click(sender As Object, e As EventArgs) Handles ctg.Click
        CTG_Form.Show()
    End Sub

    Private Sub NewDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDataToolStripMenuItem.Click
        Dim ppsForm As New Form1
        ppsForm.ShowDialog()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Dim update As New Form9_Report_Update
        update.ShowDialog()
    End Sub
    Private Sub NewReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewReportToolStripMenuItem.Click
        Dim reportForm As New Form1_Report
        reportForm.ShowDialog()
    End Sub

End Class