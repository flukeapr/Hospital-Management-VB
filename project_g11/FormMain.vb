Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml

Public Class FormMain
    Private connectionString As String = "Data Source=LAPTOP-L2CQBKP0\B6401290;Initial Catalog=wellmeadows_hospital;Integrated Security=True"
    Dim sqlConnection As New SqlConnection(connectionString)
    Public staff_BD As DataTable = New DataTable


    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Wellmeadows_hospitalDataSet)
        Me.StaffTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.staff)
    End Sub
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.qulification' table. You can move, or remove it, as needed.
        Me.QulificationTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.qulification)
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.Medication' table. You can move, or remove it, as needed.
        Me.MedicationTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.Medication)
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.Work_in_view' table. You can move, or remove it, as needed.
        Me.Work_in_viewTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.Work_in_view)
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.Work_in' table. You can move, or remove it, as needed.
        Me.Work_inTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.Work_in)
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet1.apply_wards' table. You can move, or remove it, as needed.
        'Me.Apply_wardsTableAdapter1.Fill(Me.Wellmeadows_hospitalDataSet1.apply_wards)
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.apply_wards' table. You can move, or remove it, as needed.
        'Me.Apply_wardsTableAdapter1.Fill(Me.Wellmeadows_hospitalDataSet1.apply_wards)
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.apply_wards' table. You can move, or remove it, as needed.
        'Me.Apply_wardsTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.apply_wards)
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.patient' table. You can move, or remove it, as needed.


        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.staff)
        SexComboBox.Items.Add("ชาย")
        SexComboBox.Items.Add("หญิง")
        PositiontpyeComboBox.Items.Add("P")
        PositiontpyeComboBox.Items.Add("T")
        PaidComboBox.Items.Add("M")
        PaidComboBox.Items.Add("W")

        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.patient' table. You can move, or remove it, as needed.
        Me.MedicineTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.medicine)

        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.Wards' table. You can move, or remove it, as needed.
        Try
            Me.WardsTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.Wards)
        Catch ex As Exception
        End Try
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.patient' table. You can move, or remove it, as needed.
        Try
            Me.TreatmentTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.Treatment)
        Catch ex As Exception
        End Try
        Me.Apply_wardsTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.apply_wards)

        'StaffBindingSource.DataSource = staff_BD
    End Sub


    Private Sub loadDataStaff()
        Dim sql = "SELECT * FROM staff"
        Dim cmd = sqlConnection.CreateCommand
        cmd.CommandText = sql
        sqlConnection.Open()
    End Sub
    Private Sub loadDataPatient()
        Dim sql = "SELECT * FROM patient"
        Dim cmd = sqlConnection.CreateCommand
        cmd.CommandText = sql
        sqlConnection.Open()
    End Sub


    Private Sub staffsearch_Click(sender As Object, e As EventArgs)

        'Dim sForm As SearchSataff
        'sForm = New SearchSataff()
        'sForm.ShowDialog()

        'Dim idSearch = textstaffName.Text
        'Dim sqlStatement As String = "SELECT * FROM staff WHERE staffName LIKE '%" & idSearch & "%' "
        ''Dim SELECT * FROM staff WHERE [name] Like '% = 'โชคชัย%''
        'Debug.Write(sqlStatement)
        'Dim cmd = sqlConnection.CreateCommand
        'cmd.CommandText = sqlStatement
        'sqlConnection.Open()
        'Dim sqlReader = cmd.ExecuteReader()
        'Do While sqlReader.Read()
        '    StaffIDTextBox.Text = sqlReader.Item("staffID")
        '    StaffNameTextBox.Text = sqlReader.Item("staffName")
        '    WardIDTextBox.Text = sqlReader.Item("wardID")
        '    SexComboBox.Text = sqlReader.Item("sex")
        '    AddressTextBox.Text = sqlReader.Item("Address")
        '    BirthdateDateTimePicker.Text = sqlReader.Item("birthdate")
        '    TelTextBox.Text = sqlReader.Item("tel")
        '    PositionTextBox.Text = sqlReader.Item("position")
        '    NINTextBox.Text = sqlReader.Item("NIN")
        '    HoursTextBox.Text = sqlReader.Item("hours")
        '    SalaryTextBox.Text = sqlReader.Item("Salary")
        '    PositiontpyeComboBox.Text = sqlReader.Item("positiontpye")
        '    PaidComboBox.Text = sqlReader.Item("paid")
        '    TypeTextBox.Text = sqlReader.Item("type")
        '    InstitutionTextBox.Text = sqlReader.Item("institution")
        '    Graduation_DateDateTimePicker.Text = sqlReader.Item("Graduation_Date")
        '    OrganizationTextBox.Text = sqlReader.Item("Organization")
        '    Position_pastTextBox.Text = sqlReader.Item("position_past")
        '    Start_dateDateTimePicker.Text = sqlReader.Item("Start_date")
        '    Finish_dateDateTimePicker.Text = sqlReader.Item("Finish_date")
        'Loop
        'sqlReader.Close()
        'sqlConnection.Close()

    End Sub

    Private Sub patientsearch_Click(sender As Object, e As EventArgs)
        Dim sForm As FormSearch
        sForm = New FormSearch()
        sForm.ShowDialog()

        'Dim idSearch = textpatientName.Text
        'Dim sqlStatement As String = "SELECT * FROM patient WHERE [patientName] LIKE '%" & idSearch & "%' "
        ''Dim sql = "SELECT * FROM patient WHERE patientName  = '" & idSearch & " ' "
        'Dim cmd = sqlConnection.CreateCommand
        'Debug.Write(sqlStatement)
        'cmd.CommandText = sqlStatement
        'sqlConnection.Open()
        'Dim sqlReader = cmd.ExecuteReader()
        'Do While sqlReader.Read()
        '    PatientIDTextBox.Text = sqlReader.Item("patientID")
        '    PatientNameTextBox.Text = sqlReader.Item("patientName")
        '    PatientSex.Text = sqlReader.Item("sex")
        '    BirthdateDateTimePicker1.Text = sqlReader.Item("birthdate")
        '    Patient_AddressTextBox.Text = sqlReader.Item("patient_Address")
        '    Maritall_statusTextBox.Text = sqlReader.Item("maritall_status")
        '    Patient_telTextBox.Text = sqlReader.Item("patient_tel")
        '    Date_admissionDateTimePicker.Text = sqlReader.Item("date_admission")
        '    Next_of_kinNameTextBox.Text = sqlReader.Item("Next_of_kinName")
        '    RelationshipTextBox.Text = sqlReader.Item("relationship")
        '    Next_of_kin_AddressTextBox.Text = sqlReader.Item("Next_of_kin_Address")
        '    Next_of_kin_telTextBox.Text = sqlReader.Item("Next_of_kin_tel")
        '    DoctorNameTextBox.Text = sqlReader.Item("doctorName")
        '    ClinicNoTextBox.Text = sqlReader.Item("clinicNo")
        '    Doctor_AddressTextBox.Text = sqlReader.Item("doctor_Address")
        '    Doctor_telTextBox.Text = sqlReader.Item("doctor_tel")

        'Loop
        'sqlReader.Close()
        'sqlConnection.Close()

    End Sub

    'Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
    '    'Me.Validate()
    '    'Me.PatientBindingSource.EndEdit()
    '    'Me.TableAdapterManager.UpdateAll(Me.Wellmeadows_hospitalDataSet)

    '    Dim sqlInsert As String = "INSERT INTO patient (patientID, patientName, patient_Address, birthdate, sex, maritall_status, patient_tel, date_admission, Next_of_kinName, relationship, Next_of_kin_Address, Next_of_kin_tel, doctorName, clinicNo, doctor_Address, doctor_tel) VALUES("
    '    sqlInsert &= PatientIDTextBox.Text & ", " & PatientNameTextBox.Text & ", " & PatientSex.Text & ", " & BirthdateDateTimePicker1.Text & ", " & Patient_AddressTextBox.Text & ", '"
    '    sqlInsert &= Maritall_statusTextBox.Text & " , " & Patient_telTextBox.Text & ", " & Date_admissionDateTimePicker.Text & ", " & Next_of_kinNameTextBox.Text & ", '"
    '    sqlInsert &= RelationshipTextBox.Text & " , " & Next_of_kin_AddressTextBox.Text & ", " & Next_of_kin_telTextBox.Text & ", " & DoctorNameTextBox.Text & ",'"
    '    sqlInsert &= ClinicNoTextBox.Text & " , " & Doctor_AddressTextBox.Text & ",  " & Doctor_telTextBox.Text & " ')"
    '    Dim sqlCommand As New SqlCommand(sqlInsert, sqlConnection)
    '    sqlConnection.Open()
    '    sqlCommand.ExecuteNonQuery()
    '    sqlConnection.Close()


    '    Me.TableAdapterManager.UpdateAll(Wellmeadows_hospitalDataSet)
    '    Me.PatientTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.patient)

    'End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MedicineBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Wellmeadows_hospitalDataSet)
    End Sub


    Private Sub ToolStripButton15_Click(sender As Object, e As EventArgs)
        Me.Validate()
        'Me.WardsBindingSource1.EndEdit()
        Me.WardsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Wellmeadows_hospitalDataSet)
    End Sub


    Private Sub ToolStripButton22_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TreatmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Wellmeadows_hospitalDataSet)
    End Sub


    Private Sub DrugIDTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DrugIDLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SexLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PatientComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub StaffNameTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub StaffIDTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RelationshipLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FillBySexToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.StaffTableAdapter.FillBySex(Me.Wellmeadows_hospitalDataSet.staff)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub






    Private Sub Quantity_in_stockLabel_Click(sender As Object, e As EventArgs)

    End Sub

    'Private Sub wardsearch_Click(sender As Object, e As EventArgs)
    '    Dim idSearch = textwardID.Text
    '    Dim sql = "SELECT * FROM Wards WHERE wardID Like  '%" & idSearch & "%'  Or wardName Like '%" & idSearch & "%'"
    '    Dim cmd = sqlConnection.CreateCommand
    '    cmd.CommandText = sql
    '    sqlConnection.Open()
    '    Dim sqlReader = cmd.ExecuteReader()
    '    Do While sqlReader.Read()
    '        WardIDTextBox1.Text = sqlReader.Item("wardID")
    '        WardnameTextBox.Text = sqlReader.Item("wardname")
    '        Total_roomTextBox.Text = sqlReader.Item("total_room")
    '        Tel_ExtnTextBox.Text = sqlReader.Item("tel_Extn")
    '        LocationTextBox.Text = sqlReader.Item("location")
    '    Loop
    '    sqlReader.Close()
    '    sqlConnection.Close()

    'End Sub

    Private Sub btbmedcine_Click(sender As Object, e As EventArgs)
        'Dim idSearch = textdrugID.Text
        ''Dim sql = "SELECT * FROM medicine WHERE drugID  = '" & idSearch & " ' "
        'Dim sqlStatement As String = "SELECT * FROM medicine WHERE [drug_Name] LIKE '%" & idSearch & "%' "
        'Dim cmd = sqlConnection.CreateCommand
        'Debug.Write(sqlStatement)
        'cmd.CommandText = sqlStatement
        'sqlConnection.Open()
        'Dim sqlReader = cmd.ExecuteReader()
        'Do While sqlReader.Read()
        '    StaffIDTextBox1.Text = sqlReader.Item("staffID")
        '    StaffNameTextBox1.Text = sqlReader.Item("staffName")
        '    DrugIDTextBox.Text = sqlReader.Item("drugID")
        '    Drug_nameTextBox.Text = sqlReader.Item("drug_name")
        '    DescriptionsTextBox.Text = sqlReader.Item("descriptions")
        '    Method_of_administrationTextBox.Text = sqlReader.Item("method_of_administration")
        '    DosageTextBox.Text = sqlReader.Item("dosage")
        '    EattimeTextBox.Text = sqlReader.Item("Eattime")
        '    Cost_per_unitTextBox.Text = sqlReader.Item("cost_per_unit")
        '    Quantity_in_stockTextBox.Text = sqlReader.Item("quantity_in_stock")
        '    Cost_per_unitTextBox.Text = sqlReader.Item("cost per unit")

        'Loop
        'sqlReader.Close()
        'sqlConnection.Close()

        Dim sForm As SearchMedicine
        sForm = New SearchMedicine()
        sForm.ShowDialog()

    End Sub



    Private Sub medication_Click(sender As Object, e As EventArgs)
        Dim sForm As FormMedication
        sForm = New FormMedication()
        sForm.ShowDialog()
    End Sub

    Private Sub textwardID_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub staffsearch_Click_1(sender As Object, e As EventArgs) Handles staffsearch.Click
        'Dim sForm As SearchSataff
        'sForm = New SearchSataff()
        'sForm.ShowDialog()
        Try


            sqlConnection.Open()
            Dim nameSreach = textBoxsearch.Text
            Dim sql = "SELECT * FROM staff WHERE staffName LIKE  '%" & nameSreach & "%' Or position LIKE '%" & nameSreach & "%' Or staffID LIKE '%" & nameSreach & "%' "
            Dim cmd = sqlConnection.CreateCommand
            cmd.CommandText = sql

            Dim sqlReader = cmd.ExecuteReader()
            If sqlReader.HasRows Then
                Dim query As String = "staffName LIKE  '%" & nameSreach & "%'  Or position LIKE '%" & nameSreach & "%' Or staffID LIKE '%" & nameSreach & "%'"
                StaffBindingSource.Filter = query


            Else
                textBoxsearch.Text = "No staff Here!!!!"
                MsgBox("No staff work in hospital", "fail", MessageBoxButtons.RetryCancel)
            End If

            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show("No staff work in hospital", "fail", CType(CStr(MessageBoxButtons.RetryCancel), MessageBoxButtons))

        End Try
    End Sub

    Private Sub StaffBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles StaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Wellmeadows_hospitalDataSet)
        Me.StaffTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.staff)
    End Sub

    Private Sub Picturecoler2_Paint(sender As Object, e As PaintEventArgs) Handles Picturecoler2.Paint

    End Sub

    Private Sub textBoxsearch_TextChanged(sender As Object, e As EventArgs) Handles textBoxsearch.TextChanged
        If textBoxsearch.Text Is "" Then
            StaffBindingSource.RemoveFilter()
            Me.StaffTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.staff)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        FormHome.Show()
    End Sub

    Private Sub experience_Click(sender As Object, e As EventArgs) Handles experience.Click
        FormExperience.ShowDialog()
    End Sub

    Private Sub qualification_Click(sender As Object, e As EventArgs) Handles qualification.Click
        FormQualification.ShowDialog()
    End Sub
End Class