Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class Sampletaskorg

    Private Sub Sampletaskorg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAssignedName()
        AddHandler lblEVRPCMRGUCO.Click, AddressOf AssignedLabel_Click
        AddHandler lblEVRPCMRGUVCO.Click, AddressOf AssignedLabel_Click
        AddHandler lblEVRPCMRGUSEC.Click, AddressOf AssignedLabel_Click
        'AddHandler lblSRMAEMPORIUMCO.Click, AddressOf AssignedLabel_Click
        'AddHandler lblSRMAEMPORIUMVCO.Click, AddressOf AssignedLabel_Click
        'AddHandler lblSRMAEMPORIUMSEC.Click, AddressOf AssignedLabel_Click
    End Sub

    Private Sub AssignedLabel_Click(sender As Object, e As EventArgs)
        Dim lbl As Label = CType(sender, Label)
        If lbl.Tag IsNot Nothing Then
            Dim selectedPPSID As Integer = Convert.ToInt32(lbl.Tag)

            Dim form8 As New Form8()
            form8.LoadProfile(selectedPPSID)
            form8.Show()
        Else
            MessageBox.Show("No personnel assigned.")
        End If
    End Sub

    Private Sub LoadAssignedName()
        Dim connStr As String = "server=localhost;user id=root;password=;database=evrpc_db;"
        Using conn As New MySqlConnection(connStr)
            conn.Open()

            LoadAssignment(conn, "CTG", "Vertical", "EVRPC MRGU", "", "CO", lblEVRPCMRGUCO)
            LoadAssignment(conn, "CTG", "Vertical", "EVRPC MRGU", "", "VCO", lblEVRPCMRGUVCO)
            LoadAssignment(conn, "CTG", "Vertical", "EVRPC MRGU", "", "SEC", lblEVRPCMRGUSEC)

            'LoadAssignment(conn, "CTG", "Horizontal", "", "SRMA EMPOR", "CO", lblSRMAEMPORIUMCO)
            'LoadAssignment(conn, "CTG", "Horizontal", "", "SRMA EMPOR", "VCO", lblSRMAEMPORIUMVCO)
            'LoadAssignment(conn, "CTG", "Horizontal", "", "SRMA EMPOR", "SEC", lblSRMAEMPORIUMSEC)
        End Using
    End Sub

    Private Sub LoadAssignment(conn As MySqlConnection, category As String, categoryCTG As String, vertical As String, horizontal As String, position As String, outputLabel As Label, Optional limitToOne As Boolean = True)
        outputLabel.ForeColor = Color.Blue
        outputLabel.Font = New Font(outputLabel.Font, FontStyle.Underline)
        outputLabel.Cursor = Cursors.Hand
        Dim query As String = "SELECT PPS_ID, PPS_NAME FROM pps WHERE PPS_Category = @category AND PPS_CategoryCTG = @categoryCTG AND PPS_POSITION = @position"

        If categoryCTG = "Vertical" Then
            query &= " AND PPS_CTGVertical = @vertical"
        ElseIf categoryCTG = "Horizontal" Then
            query &= " AND PPS_CTGHorizontal = @horizontal"
        End If

        If limitToOne Then
            query &= " LIMIT 1"
        End If

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@category", category)
            cmd.Parameters.AddWithValue("@categoryCTG", categoryCTG)
            cmd.Parameters.AddWithValue("@position", position)
            cmd.Parameters.AddWithValue("@vertical", vertical)
            cmd.Parameters.AddWithValue("@horizontal", horizontal)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    outputLabel.Text = reader("PPS_NAME").ToString()
                    outputLabel.Tag = reader("PPS_ID")
                Else
                    outputLabel.Text = "(No " & position & " assigned)"
                    outputLabel.Tag = Nothing
                End If
            End Using
        End Using
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Form1 As New Form1()
        Form1.Show()
        Me.Close()
    End Sub

End Class
