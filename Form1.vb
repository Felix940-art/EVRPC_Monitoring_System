Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbCategoryCTG.Visible = False
        cbCTGVertical.Visible = False
        cbCTGHorizontal.Visible = False
    End Sub

    Private otherDataBytes As Byte() = Nothing
    Private osintDataBytes As Byte() = Nothing
    Public CurrentPPSID As String
    Public FamilyMembers As New List(Of List(Of String))
    Private Sub BtnAddFamilyMember_Click(sender As Object, e As EventArgs) Handles btnAddFamilyMember.Click
        If String.IsNullOrEmpty(CurrentPPSID) Then
            MessageBox.Show("Please save the personality record first before adding data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim form2 As New Form2 With {
            .CurrentPPSID = CurrentPPSID
        }
        form2.ShowDialog()
    End Sub

    Private Sub BtnAddAdministrativeCrimRecord_Click(sender As Object, e As EventArgs) Handles btnAddAdministrativeCrimRecord.Click
        Dim form4 As New Form4()

        form4.ShowDialog()

        If form4.AdministrativeCriminalRecordData IsNot Nothing AndAlso form4.AdministrativeCriminalRecordData.Count > 0 Then
            Dim connStr As String = "server=localhost;user id=root;password=;database=evrpc_db;"
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                For Each rowData In form4.AdministrativeCriminalRecordData
                    Dim query As String = "INSERT INTO pps_administrativecrimrecord" &
                    "(PPS_ACRCasenumber, PPS_ACRCasetitle, PPS_ACRRemarks) " &
                    "VALUES (@casenumber, @casetitle, @remarks)"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@casenumber", rowData(0))
                        cmd.Parameters.AddWithValue("@casetitle", rowData(1))
                        cmd.Parameters.AddWithValue("@remarks", rowData(2))

                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using
            MessageBox.Show("Data saved.")
        End If

        Me.Show()
    End Sub

    Private Sub BtnAddCoursesTrngUndertaken_Click(sender As Object, e As EventArgs) Handles btnAddCoursesTrngUndertaken.Click
        Dim form5 As New Form5()

        form5.ShowDialog()

        If form5.CoursesTrainingUndertakenData IsNot Nothing AndAlso form5.CoursesTrainingUndertakenData.Count > 0 Then
            Dim connStr As String = "server=localhost;user id=root;password=;database=evrpc_db;"
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                For Each rowData In form5.CoursesTrainingUndertakenData
                    Dim query As String = "INSERT INTO pps_coursestrainingundertaken " &
                    "(PPS_CTUDate, PPS_CTUCourseTrng) " &
                    "VALUES (@date, @coursetrng)"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@date", rowData(0))
                        cmd.Parameters.AddWithValue("@coursetrng", rowData(1))

                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using
            MessageBox.Show("Data saved.")
        End If

        Me.Show()
    End Sub

    Private Sub BtnAddAssociatedPersonalities_Click(sender As Object, e As EventArgs) Handles btnAddAssociatedPersonalities.Click
        Dim form6 As New Form6()

        form6.ShowDialog()

        If form6.AssociatedPersonalitiesData IsNot Nothing AndAlso form6.AssociatedPersonalitiesData.Count > 0 Then
            Dim connStr As String = "server=localhost;user id=root;password=;database=evrpc_db;"
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                For Each rowData In form6.AssociatedPersonalitiesData
                    Dim query As String = "INSERT INTO pps_associatedpersonalities " &
                    "(PPS_APName, PPS_APPosition, PPS_APOrganization, PPS_APAssociation_Relationship) " &
                    "VALUES (@name, @position, @organization, @association)"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@name", rowData(0))
                        cmd.Parameters.AddWithValue("@position", rowData(1))
                        cmd.Parameters.AddWithValue("@organization", rowData(2))
                        cmd.Parameters.AddWithValue("@association", rowData(3))

                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using
            MessageBox.Show("Data saved.")
        End If

        Me.Show()
    End Sub

    Private Sub BtnAddOrganizationsAffiliated_Click(sender As Object, e As EventArgs) Handles btnAddOrganizationsAffiliated.Click
        Dim form7 As New Form7_PPS()
        form7.ShowDialog()

        If form7.OrganizationsAffiliatedData IsNot Nothing AndAlso form7.OrganizationsAffiliatedData.Count > 0 Then
            Dim connStr As String = "server=localhost;user id=root;password=;database=evrpc_db;"
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                For Each rowData In form7.OrganizationsAffiliatedData
                    If rowData.Count < 4 Then Continue For ' safety check

                    Dim query As String = "INSERT INTO pps_organizationsaffiliated " &
                    "(PPS_OAOrganization, PPS_OADescription, PPS_OANatureofAff, PPS_OARemarks, PPS_ID) " &
                    "VALUES (@organization, @description, @natureofaff, @remarks, @pps_id)"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@organization", rowData(0))
                        cmd.Parameters.AddWithValue("@description", rowData(1))
                        cmd.Parameters.AddWithValue("@natureofaff", rowData(2))
                        cmd.Parameters.AddWithValue("@remarks", rowData(3))
                        cmd.Parameters.AddWithValue("@pps_id", CurrentPPSID)

                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using

            MessageBox.Show("Data saved.")
        End If
    End Sub

    Private Sub CbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged
        If cbCategory.SelectedItem IsNot Nothing Then
            Dim selectedValue As String = cbCategory.SelectedItem.ToString()

            If selectedValue = "CTG" Then
                cbCategoryCTG.Visible = True
            Else

                cbCategoryCTG.Visible = False
                cbCTGVertical.Visible = False
                cbCTGHorizontal.Visible = False
            End If
        End If
    End Sub

    Private Sub CbCategoryCTG_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoryCTG.SelectedIndexChanged
        If cbCategoryCTG.SelectedItem IsNot Nothing Then
            Dim selectedValue As String = cbCategoryCTG.SelectedItem.ToString().ToUpper()

            Select Case selectedValue
                Case "VERTICAL"
                    cbCTGVertical.Visible = True
                    cbCTGHorizontal.Visible = False
                Case "HORIZONTAL"
                    cbCTGVertical.Visible = False
                    cbCTGHorizontal.Visible = True
                Case Else
                    cbCTGVertical.Visible = False
                    cbCTGHorizontal.Visible = False
            End Select
        End If
    End Sub

    Private Sub BtnUploadPicture_Click(sender As Object, e As EventArgs) Handles btnUploadPicture.Click
        Dim openFile As New OpenFileDialog With {
     .Title = "Select a Photo",
     .Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp",
     .Multiselect = False
 }

        If openFile.ShowDialog() = DialogResult.OK Then
            pPersonalityPicture.Image = Image.FromFile(openFile.FileName)
            pPersonalityPicture.SizeMode = PictureBoxSizeMode.StretchImage

            MessageBox.Show("Photo uploaded successfully.", "Upload Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnAddOSINTData_Click(sender As Object, e As EventArgs) Handles btnAddOSINTData.Click
        Dim openFile As New OpenFileDialog With {
        .Title = "Select a File",
        .Filter = "All Files (*.*)|*.*",
        .Multiselect = False
    }

        If openFile.ShowDialog() = DialogResult.OK Then

            MessageBox.Show("File uploaded successfully.", "Upload Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnAddOtherData_Click(sender As Object, e As EventArgs) Handles btnAddOtherData.Click
        Dim openFile As New OpenFileDialog With {
        .Title = "Select File",
        .Filter = "All Files (*.*)|*.*",
        .Multiselect = False
    }

        If openFile.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFile.FileName
            Dim fileBytes() As Byte = IO.File.ReadAllBytes(filePath)

            Dim connStr As String = "server=localhost;user id=root;password=;database=evrpc_db;"
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                Dim query As String = "UPDATE pps SET PPS_OtherData = @fileData WHERE PPS_ID = @ppsID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fileData", fileBytes)
                    cmd.Parameters.AddWithValue("@ppsID", CurrentPPSID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("File uploaded successfully to PPS_OtherData.", "Upload Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnSavePersonality_Click(sender As Object, e As EventArgs) Handles btnSavePersonality.Click
        If pPersonalityPicture.Image Is Nothing Then
            MessageBox.Show("Please upload a picture before saving.", "Picture Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim pictureBytes As Byte()
        Using ms As New MemoryStream()
            pPersonalityPicture.Image.Save(ms, Imaging.ImageFormat.Jpeg)
            pictureBytes = ms.ToArray()
        End Using

        If pictureBytes Is Nothing OrElse pictureBytes.Length = 0 Then
            MessageBox.Show("Picture conversion failed. Please reselect image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim ConnStr As String = "server=localhost;user id=root;password=;database=evrpc_db;"
        Using conn As New MySqlConnection(ConnStr)
            Try
                conn.Open()

                Dim query As String = "
                INSERT INTO pps (
                    PPS_NAME, PPS_ALIAS_AKA, PPS_POSITION, PPS_AGE, PPS_CIVIL_STATUS, PPS_SEX, PPS_ADDRESS,
                    PPS_ETHNICITY, PPS_RELIGION, PPS_NATIONALITY, PPS_E_RECORDS, PPS_CONTACTINFO, PPS_HEIGHT,
                    PPS_WEIGHT, PPS_HAIRCOLOR, PPS_EYESCOLOR, PPS_BODYBUILD, PPS_BLOODTYPE, PPS_OTHERIDENMARKS,
                    PPS_COMPLEXION, PPS_SCHELEM, PPS_SCHHSCH, PPS_SCHCOLL, PPS_ADDELEM, PPS_ADDHSCH, PPS_ADDCOLL,
                    PPS_DATERECRUITED, PPS_ADDRECRUITED, PPS_OTHER_INFO, PPS_Category, PPS_CategoryCTG,
                    PPS_CTGVertical, PPS_CTGHorizontal, PPS_Picture, PPS_OtherData, PPS_OSINTData)
                VALUES (
                    @name, @alias_aka, @position, @age, @civil_status, @sex, @address,
                    @ethnicity, @religion, @nationality, @e_records, @contact_info, @height,
                    @weight, @hair_color, @eyes_color, @body_build, @blood_type, @other_marks,
                    @complexion, @school_elementary, @school_highschool, @school_college,
                    @address_elementary, @address_highschool, @address_college, @date_recruited,
                    @address_recruited, @other_info, @category, @categoryCTG,
                    @CTGVertical, @CTGHorizontal, @picture, @otherdata, @osintdata)"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@name", tbName.Text)
                    cmd.Parameters.AddWithValue("@alias_aka", tbALIAS_AKA.Text)
                    cmd.Parameters.AddWithValue("@position", cbPosition.Text)
                    cmd.Parameters.AddWithValue("@age", tbAge.Text)
                    cmd.Parameters.AddWithValue("@civil_status", tbCivilStatus.Text)
                    cmd.Parameters.AddWithValue("@sex", tbSex.Text)
                    cmd.Parameters.AddWithValue("@address", tbAddress.Text)
                    cmd.Parameters.AddWithValue("@ethnicity", tbEthnicity.Text)
                    cmd.Parameters.AddWithValue("@religion", tbReligion.Text)
                    cmd.Parameters.AddWithValue("@nationality", tbNationality.Text)
                    cmd.Parameters.AddWithValue("@e_records", tbE_Records.Text)
                    cmd.Parameters.AddWithValue("@contact_info", tbContactInfo.Text)
                    cmd.Parameters.AddWithValue("@height", tbHeight.Text)
                    cmd.Parameters.AddWithValue("@weight", tbWeight.Text)
                    cmd.Parameters.AddWithValue("@hair_color", tbHairColor.Text)
                    cmd.Parameters.AddWithValue("@eyes_color", tbEyesColor.Text)
                    cmd.Parameters.AddWithValue("@body_build", tbBodyBuild.Text)
                    cmd.Parameters.AddWithValue("@blood_type", tbBloodType.Text)
                    cmd.Parameters.AddWithValue("@other_marks", tbOtherMarks.Text)
                    cmd.Parameters.AddWithValue("@complexion", tbComplexion.Text)
                    cmd.Parameters.AddWithValue("@school_elementary", tbSchoolElementary.Text)
                    cmd.Parameters.AddWithValue("@school_highschool", tbSchoolHighSchool.Text)
                    cmd.Parameters.AddWithValue("@school_college", tbSchoolCollege.Text)
                    cmd.Parameters.AddWithValue("@address_elementary", tbAddressElementary.Text)
                    cmd.Parameters.AddWithValue("@address_highschool", tbAddressHighSchool.Text)
                    cmd.Parameters.AddWithValue("@address_college", tbAddressCollege.Text)
                    cmd.Parameters.AddWithValue("@date_recruited", tbDateRecruited.Text)
                    cmd.Parameters.AddWithValue("@address_recruited", tbAddressRecruited.Text)
                    cmd.Parameters.AddWithValue("@other_info", tbOtherSignificantInfo.Text)
                    cmd.Parameters.AddWithValue("@category", cbCategory.Text)
                    cmd.Parameters.AddWithValue("@categoryCTG", cbCategoryCTG.Text)
                    cmd.Parameters.AddWithValue("@CTGVertical", cbCTGVertical.Text)
                    cmd.Parameters.AddWithValue("@CTGHorizontal", cbCTGHorizontal.Text)
                    cmd.Parameters.AddWithValue("@picture", pictureBytes)

                    If otherDataBytes IsNot Nothing Then
                        cmd.Parameters.AddWithValue("@otherdata", otherDataBytes)
                    Else
                        cmd.Parameters.AddWithValue("@otherdata", DBNull.Value)
                    End If

                    If osintDataBytes IsNot Nothing Then
                        cmd.Parameters.AddWithValue("@osintdata", osintDataBytes)
                    Else
                        cmd.Parameters.AddWithValue("@osintdata", DBNull.Value)
                    End If

                    cmd.ExecuteNonQuery()

                    CurrentPPSID = cmd.LastInsertedId.ToString()

                    MessageBox.Show("New personality saved.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End Using
            Catch ex As Exception
                MessageBox.Show("Error saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub LoadPPS(ByVal PPS_ID As String)
        Dim connStr As String = "server=localhost;user id=root;password=;database=evrpc_db;"
        Using conn As New MySqlConnection(connStr)
            conn.Open()

            Dim query As String = "SELECT ... FROM pps WHERE PPS_ID = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", PPS_ID)

            End Using

            Dim familyQuery As String = "SELECT Name, Relationship, Age, Occupation FROM pps_familymembers WHERE PPS_ID = @id"
            Using familyCmd As New MySqlCommand(familyQuery, conn)
                familyCmd.Parameters.AddWithValue("@id", PPS_ID)

                Dim adapter As New MySqlDataAdapter(familyCmd)
                Dim familyTable As New DataTable()
                adapter.Fill(familyTable)

                Dim form2 As New Form2 With {
                    .CurrentPPSID = PPS_ID
                }
                form2.LoadFamilyMembers(PPS_ID)
                form2.ShowDialog()
            End Using
        End Using
    End Sub
    Private Function AllTextBoxesFilled(container As Control) As Boolean
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is TextBox Then
                Dim tb As TextBox = CType(ctrl, TextBox)
                If String.IsNullOrWhiteSpace(tb.Text) Then
                    tb.Focus()
                    Return False
                End If
            ElseIf ctrl.HasChildren Then

                If Not AllTextBoxesFilled(ctrl) Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Private Sub BtnTO_Click(sender As Object, e As EventArgs) Handles btnTO.Click
        Sampletaskorg.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancelPersonality_Click(sender As Object, e As EventArgs) Handles btnCancelPersonality.Click
        Me.Close()
    End Sub
End Class
