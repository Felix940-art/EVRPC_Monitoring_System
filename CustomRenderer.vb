Public Class CustomRenderer
    Inherits ToolStripProfessionalRenderer

    Protected Overrides Sub OnRenderItemText(e As ToolStripItemTextRenderEventArgs)
        e.TextColor = Color.DimGray  ' Set your desired text color here
        MyBase.OnRenderItemText(e)
    End Sub
End Class
