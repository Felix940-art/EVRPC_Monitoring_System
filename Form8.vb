Imports System.IO
Imports System.Net
Imports MySql.Data.MySqlClient

Public Class Form8
    Private Class ListItem
        Public Property Name As String
        Public Property Path As String

        Public Sub New(name As String, path As String)
            Me.Name = name
            Me.Path = path
        End Sub

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    Private CurrentPPSID As Integer

    Public Sub LoadProfile(ppsID As Integer)
        CurrentPPSID = ppsID
    End Sub
    Public Class EmbeddedDocument
        Public Property Name As String
        Public Property Data As Byte()

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class
    Private Sub LoadOtherDataFromBlob(ppsID As Integer)
        lbOtherData.Items.Clear()

        Dim connStr As String = "server=localhost;user id=root;password=;database=evrpc_db;"
        Dim query As String = "SELECT PPS_OtherData FROM pps WHERE PPS_ID = @ppsID"

        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ppsID", ppsID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() AndAlso Not IsDBNull(reader("PPS_OtherData")) Then

                        Dim bytes() As Byte = CType(reader("PPS_OtherData"), Byte())
                        Dim tempPath As String = IO.Path.GetTempFileName() & ".pdf"
                        IO.File.WriteAllBytes(tempPath, bytes)

                        lbOtherData.Items.Add(New ListItem("Other Document", tempPath))
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub LoadOtherDataFromPPS()
        lbOtherData.Items.Clear()

        Dim connStr As String = "server=localhost;user id=root;password=;database=evrpc_db;"
        Dim query As String = "SELECT PPS_OtherData FROM pps WHERE PPS_ID = @ppsID"

        Using conn As New MySqlConnection(connStr)
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ppsID", CurrentPPSID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() AndAlso Not IsDBNull(reader("PPS_OtherData")) Then
                        Dim docBytes As Byte() = CType(reader("PPS_OtherData"), Byte())
                        Dim docItem As New EmbeddedDocument With {
                        .Name = "Other Data Document",
                        .Data = docBytes
                    }
                        lbOtherData.Items.Add(docItem)
                    End If
                End Using
            End Using
        End Using
    End Sub


    Private Sub LoadOSINTData(ppsID As Integer)
        lbOSINTData.Items.Clear()

        Dim connStr As String = "server=localhost;user id=root;password=;database=evrpc_db;"
        Dim query As String = "SELECT PPS_OSINTData FROM pps WHERE PPS_ID = @ppsID"

        Using conn As New MySqlConnection(connStr)
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ppsID", ppsID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim data As String = reader("PPS_OSINTData").ToString()

                        If Not String.IsNullOrEmpty(data) Then
                            Dim entries = data.Split(New String() {Environment.NewLine, ";"}, StringSplitOptions.RemoveEmptyEntries)

                            For Each line In entries
                                If line.Contains("::") Then
                                    Dim parts = line.Split(New String() {"::"}, StringSplitOptions.None)
                                    lbOSINTData.Items.Add(New ListItem(parts(0).Trim(), parts(1).Trim()))
                                Else
                                    lbOSINTData.Items.Add(New ListItem(line.Trim(), ""))
                                End If
                            Next
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub SetAllTextBoxesReadOnly(container As Control)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).ReadOnly = True
            ElseIf ctrl.HasChildren Then
                SetAllTextBoxesReadOnly(ctrl)
            End If
        Next
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOSINTData(CurrentPPSID)
        SetAllTextBoxesReadOnly(Me)

        Dim connStr As String = "server=localhost;user id=root;password=;database=evrpc_db;"
        Using conn As New MySqlConnection(connStr)
            conn.Open()

            Dim query As String =
        "SELECT PPS_NAME, PPS_ALIAS_AKA, PPS_POSITION, PPS_AGE, PPS_CIVIL_STATUS, PPS_ADDRESS, " &
        "PPS_ETHNICITY, PPS_RELIGION, PPS_NATIONALITY, PPS_E_RECORDS, PPS_CONTACTINFO, PPS_HEIGHT, PPS_WEIGHT, " &
        "PPS_HAIRCOLOR, PPS_EYESCOLOR, PPS_BODYBUILD, PPS_BLOODTYPE, PPS_OTHERIDENMARKS, PPS_COMPLEXION, " &
        "PPS_SCHELEM, PPS_SCHHSCH, PPS_SCHCOLL, PPS_ADDELEM, PPS_ADDHSCH, PPS_ADDCOLL, PPS_DATERECRUITED, " &
        "PPS_ADDRECRUITED, PPS_OTHER_INFO, PPS_Picture FROM pps WHERE PPS_ID = @id"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", CurrentPPSID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        tbName.Text = reader("PPS_NAME").ToString()
                        tbALIAS_AKA.Text = reader("PPS_ALIAS_AKA").ToString()
                        tbPosition.Text = reader("PPS_POSITION").ToString()
                        tbAge.Text = reader("PPS_AGE").ToString()
                        tbCivilStatus.Text = reader("PPS_CIVIL_STATUS").ToString()
                        tbAddress.Text = reader("PPS_ADDRESS").ToString()
                        tbEthnicity.Text = reader("PPS_ETHNICITY").ToString()
                        tbReligion.Text = reader("PPS_RELIGION").ToString()
                        tbNationality.Text = reader("PPS_NATIONALITY").ToString()
                        tbE_Records.Text = reader("PPS_E_RECORDS").ToString()
                        tbContactInfo.Text = reader("PPS_CONTACTINFO").ToString()
                        tbHeight.Text = reader("PPS_HEIGHT").ToString()
                        tbWeight.Text = reader("PPS_WEIGHT").ToString()
                        tbHairColor.Text = reader("PPS_HAIRCOLOR").ToString()
                        tbEyesColor.Text = reader("PPS_EYESCOLOR").ToString()
                        tbBodyBuild.Text = reader("PPS_BODYBUILD").ToString()
                        tbBloodType.Text = reader("PPS_BLOODTYPE").ToString()
                        tbOtherMarks.Text = reader("PPS_OTHERIDENMARKS").ToString()
                        tbComplexion.Text = reader("PPS_COMPLEXION").ToString()
                        tbSchoolElementary.Text = reader("PPS_SCHELEM").ToString()
                        tbSchoolHighSchool.Text = reader("PPS_SCHHSCH").ToString()
                        tbSchoolCollege.Text = reader("PPS_SCHCOLL").ToString()
                        tbAddressElementary.Text = reader("PPS_ADDELEM").ToString()
                        tbAddressHighSchool.Text = reader("PPS_ADDHSCH").ToString()
                        tbAddressCollege.Text = reader("PPS_ADDCOLL").ToString()
                        tbDateRecruited.Text = reader("PPS_DATERECRUITED").ToString()
                        tbAddressRecruited.Text = reader("PPS_ADDRECRUITED").ToString()
                        tbOtherSignificantInfo.Text = reader("PPS_OTHER_INFO").ToString()

                        If Not IsDBNull(reader("PPS_Picture")) Then
                            Dim imgBytes() As Byte = CType(reader("PPS_Picture"), Byte())
                            Using ms As New MemoryStream(imgBytes)
                                pPersonalityPicture.Image = Image.FromStream(ms)
                                pPersonalityPicture.SizeMode = PictureBoxSizeMode.StretchImage
                            End Using
                        Else
                            pPersonalityPicture.Image = Nothing
                        End If
                    Else
                        MessageBox.Show("No record found for ID: " & CurrentPPSID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub LbOtherData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbOtherData.SelectedIndexChanged
        If lbOtherData.SelectedItem IsNot Nothing Then
            Dim item As ListItem = CType(lbOtherData.SelectedItem, ListItem)
            If IO.File.Exists(item.Path) Then
                Process.Start(item.Path)
            Else
                MessageBox.Show("File not found.")
            End If
        End If
    End Sub

    Private Sub LbOSINTData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbOSINTData.SelectedIndexChanged
        If lbOSINTData.SelectedItem IsNot Nothing Then
            Dim selectedItem As ListItem = CType(lbOSINTData.SelectedItem, ListItem)

            If IO.File.Exists(selectedItem.Path) Then
                Process.Start(selectedItem.Path)
            Else
                MessageBox.Show("File not found: " & selectedItem.Path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Sampletaskorg As New Sampletaskorg()
        Sampletaskorg.Show()
        Me.Close()
    End Sub

End Class