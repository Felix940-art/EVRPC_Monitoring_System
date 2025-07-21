
Public Class Error_Form
    Dim message_que As New List(Of String)

    Private Sub size_validation()
        Me.Location = New Point(My.Computer.Screen.Bounds.Width / 2 - 200, -78)
        open_timer.Enabled = True
        open_timer.Start()
    End Sub
    Private Sub open_timer_Tick(sender As Object, e As EventArgs) Handles open_timer.Tick
        If Me.Location.Y = 0 Then
            open_timer.Stop()
            proxy_timer.Enabled = True
            proxy_timer.Start()
        Else
            Me.Location = New Point(My.Computer.Screen.Bounds.Width / 2 - 200, Me.Location.Y + 1)
        End If
    End Sub
    Private Sub close_timer_Tick(sender As Object, e As EventArgs) Handles close_timer.Tick
        If Me.Location.Y = -155 Then
            Me.Close()
        Else
            Me.Location = New Point(My.Computer.Screen.Bounds.Width / 2 - 200, Me.Location.Y - 1)
        End If
    End Sub
    Private Sub proxy_timer_Tick(sender As Object, e As EventArgs) Handles proxy_timer.Tick
        proxy_timer.Stop()
        close_timer.Enabled = True
        close_timer.Start()
    End Sub
    Private Sub Error_Form_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        proxy_timer.Start()
    End Sub

    Private Sub Error_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(My.Computer.Screen.Bounds.Width / 2 - 200, -78)
        Me.ShowInTaskbar = False

        Show_msg("", "", MessageType.Information)
    End Sub
    Public Enum MessageType
        Information
    End Enum
    Public Sub Show_msg(ByVal title As String, ByVal text As String, ByVal typeM As MessageType)
        size_validation()
        Select Case (typeM)
            Case MessageType.Information
                Label2.Text = title
                Label3.Text = text
        End Select
    End Sub
    Private Sub Error_Form_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        proxy_timer.Stop()
    End Sub
End Class