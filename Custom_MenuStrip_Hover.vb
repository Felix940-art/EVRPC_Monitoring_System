Public Class Custom_MenuStrip_Hover
    Inherits ToolStripProfessionalRenderer

    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
        Dim item = e.Item
        Dim g = e.Graphics

        If item.Selected Then
            ' When hovered or selected
            Using b As New SolidBrush(Color.LightBlue) ' Change hover color here
                g.FillRectangle(b, New Rectangle(Point.Empty, item.Size))
            End Using
        Else
            ' Normal state background
            Using b As New SolidBrush(Color.Transparent) ' Normal background
                g.FillRectangle(b, New Rectangle(Point.Empty, item.Size))
            End Using
        End If
    End Sub

    Protected Overrides Sub OnRenderItemText(e As ToolStripItemTextRenderEventArgs)
        If e.Item.Selected Then
            e.TextColor = Color.DarkBlue ' Hover text color
        Else
            e.TextColor = Color.Black ' Normal text color
        End If
        MyBase.OnRenderItemText(e)
    End Sub
End Class
