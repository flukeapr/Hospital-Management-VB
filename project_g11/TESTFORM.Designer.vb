<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TESTFORM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StaffIDLabel As System.Windows.Forms.Label
        Dim StaffNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim BirthdateLabel As System.Windows.Forms.Label
        Dim TelLabel As System.Windows.Forms.Label
        Dim NINLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim WardIDLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim HoursLabel As System.Windows.Forms.Label
        Dim PaidLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim InstitutionLabel As System.Windows.Forms.Label
        Dim Graduation_DateLabel As System.Windows.Forms.Label
        Dim OrganizationLabel As System.Windows.Forms.Label
        Dim Position_pastLabel As System.Windows.Forms.Label
        Dim Start_dateLabel As System.Windows.Forms.Label
        Dim Finish_dateLabel As System.Windows.Forms.Label
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim PatientNameLabel As System.Windows.Forms.Label
        Dim Patient_AddressLabel As System.Windows.Forms.Label
        Dim BirthdateLabel1 As System.Windows.Forms.Label
        Dim SexLabel1 As System.Windows.Forms.Label
        Dim Maritall_statusLabel As System.Windows.Forms.Label
        Dim Patient_telLabel As System.Windows.Forms.Label
        Dim Date_admissionLabel As System.Windows.Forms.Label
        Dim Next_of_kinNameLabel As System.Windows.Forms.Label
        Dim RelationshipLabel As System.Windows.Forms.Label
        Dim Next_of_kin_AddressLabel As System.Windows.Forms.Label
        Dim Next_of_kin_telLabel As System.Windows.Forms.Label
        Dim DoctorNameLabel As System.Windows.Forms.Label
        Dim ClinicNoLabel As System.Windows.Forms.Label
        Dim Doctor_AddressLabel As System.Windows.Forms.Label
        Dim Doctor_telLabel As System.Windows.Forms.Label
        Dim DrugIDLabel As System.Windows.Forms.Label
        Dim StaffIDLabel1 As System.Windows.Forms.Label
        Dim Drug_nameLabel As System.Windows.Forms.Label
        Dim Method_of_administrationLabel As System.Windows.Forms.Label
        Dim Reorder_levelLabel As System.Windows.Forms.Label
        Dim DosageLabel As System.Windows.Forms.Label
        Dim Total_drugLabel As System.Windows.Forms.Label
        Dim Cost_per_unitLabel As System.Windows.Forms.Label
        Dim Quantity_in_stockLabel As System.Windows.Forms.Label
        Dim DescriptionsLabel As System.Windows.Forms.Label
        Dim WardIDLabel1 As System.Windows.Forms.Label
        Dim WardnameLabel As System.Windows.Forms.Label
        Dim Tel_extnLabel As System.Windows.Forms.Label
        Dim RoomIDLabel As System.Windows.Forms.Label
        Dim Total_bedLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim TreatmentIDLabel As System.Windows.Forms.Label
        Dim PatientIDLabel1 As System.Windows.Forms.Label
        Dim StaffIDLabel2 As System.Windows.Forms.Label
        Dim DrugIDLabel1 As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim Date_timeLabel As System.Windows.Forms.Label
        Dim SexLabel2 As System.Windows.Forms.Label
        Dim PaidLabel1 As System.Windows.Forms.Label
        Dim PositiontpyeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PositiontpyeComboBox = New System.Windows.Forms.ComboBox()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wellmeadows_hospitalDataSet = New project_g11.wellmeadows_hospitalDataSet()
        Me.PaidComboBox = New System.Windows.Forms.ComboBox()
        Me.SexComboBox = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.staffsearch = New System.Windows.Forms.Button()
        Me.textstaffName = New System.Windows.Forms.TextBox()
        Me.Experience_work = New System.Windows.Forms.Label()
        Me.Qualifications = New System.Windows.Forms.Label()
        Me.StaffBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StaffBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StaffIDTextBox = New System.Windows.Forms.TextBox()
        Me.StaffNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.BirthdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TelTextBox = New System.Windows.Forms.TextBox()
        Me.NINTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.WardIDTextBox = New System.Windows.Forms.TextBox()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.HoursTextBox = New System.Windows.Forms.TextBox()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.InstitutionTextBox = New System.Windows.Forms.TextBox()
        Me.Graduation_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OrganizationTextBox = New System.Windows.Forms.TextBox()
        Me.Position_pastTextBox = New System.Windows.Forms.TextBox()
        Me.Start_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Finish_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.patient = New System.Windows.Forms.TabPage()
        Me.PatientSex = New System.Windows.Forms.ComboBox()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Location_Doctor_Details = New System.Windows.Forms.Label()
        Me.Next_of_kin = New System.Windows.Forms.Label()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.patientsearch = New System.Windows.Forms.Button()
        Me.textpatientName = New System.Windows.Forms.TextBox()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.PatientNameTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.BirthdateDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Maritall_statusTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_telTextBox = New System.Windows.Forms.TextBox()
        Me.Date_admissionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Next_of_kinNameTextBox = New System.Windows.Forms.TextBox()
        Me.RelationshipTextBox = New System.Windows.Forms.TextBox()
        Me.Next_of_kin_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Next_of_kin_telTextBox = New System.Windows.Forms.TextBox()
        Me.DoctorNameTextBox = New System.Windows.Forms.TextBox()
        Me.ClinicNoTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_telTextBox = New System.Windows.Forms.TextBox()
        Me.medcinesearch = New System.Windows.Forms.TabPage()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.MedicineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.btbmedcine = New System.Windows.Forms.Button()
        Me.textdrugID = New System.Windows.Forms.TextBox()
        Me.DrugIDTextBox = New System.Windows.Forms.TextBox()
        Me.StaffIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.Drug_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Method_of_administrationTextBox = New System.Windows.Forms.TextBox()
        Me.Reorder_levelTextBox = New System.Windows.Forms.TextBox()
        Me.DosageTextBox = New System.Windows.Forms.TextBox()
        Me.Total_drugTextBox = New System.Windows.Forms.TextBox()
        Me.Cost_per_unitTextBox = New System.Windows.Forms.TextBox()
        Me.Quantity_in_stockTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionsTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.WardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.wardsearch = New System.Windows.Forms.Button()
        Me.textwardID = New System.Windows.Forms.TextBox()
        Me.WardIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.WardnameTextBox = New System.Windows.Forms.TextBox()
        Me.RoomIDTextBox = New System.Windows.Forms.TextBox()
        Me.Total_bedTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Amitted_ward = New System.Windows.Forms.Label()
        Me.Admitted_wardDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Admitted_wardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator4 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton16 = New System.Windows.Forms.ToolStripButton()
        Me.TreatmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton17 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton18 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton19 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton20 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton21 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton22 = New System.Windows.Forms.ToolStripButton()
        Me.TreatmentIDTextBox = New System.Windows.Forms.TextBox()
        Me.PatientIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.StaffIDTextBox2 = New System.Windows.Forms.TextBox()
        Me.DrugIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Date_timeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PatientBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.staffTableAdapter()
        Me.TableAdapterManager = New project_g11.wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager()
        Me.PatientTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.patientTableAdapter()
        Me.MedicineTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.medicineTableAdapter()
        Me.WardsTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.WardsTableAdapter()
        Me.TreatmentTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.TreatmentTableAdapter()
        Me.Admitted_wardTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.admitted_wardTableAdapter()
        Me.PatientBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        StaffIDLabel = New System.Windows.Forms.Label()
        StaffNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        BirthdateLabel = New System.Windows.Forms.Label()
        TelLabel = New System.Windows.Forms.Label()
        NINLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        WardIDLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        HoursLabel = New System.Windows.Forms.Label()
        PaidLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        InstitutionLabel = New System.Windows.Forms.Label()
        Graduation_DateLabel = New System.Windows.Forms.Label()
        OrganizationLabel = New System.Windows.Forms.Label()
        Position_pastLabel = New System.Windows.Forms.Label()
        Start_dateLabel = New System.Windows.Forms.Label()
        Finish_dateLabel = New System.Windows.Forms.Label()
        PatientIDLabel = New System.Windows.Forms.Label()
        PatientNameLabel = New System.Windows.Forms.Label()
        Patient_AddressLabel = New System.Windows.Forms.Label()
        BirthdateLabel1 = New System.Windows.Forms.Label()
        SexLabel1 = New System.Windows.Forms.Label()
        Maritall_statusLabel = New System.Windows.Forms.Label()
        Patient_telLabel = New System.Windows.Forms.Label()
        Date_admissionLabel = New System.Windows.Forms.Label()
        Next_of_kinNameLabel = New System.Windows.Forms.Label()
        RelationshipLabel = New System.Windows.Forms.Label()
        Next_of_kin_AddressLabel = New System.Windows.Forms.Label()
        Next_of_kin_telLabel = New System.Windows.Forms.Label()
        DoctorNameLabel = New System.Windows.Forms.Label()
        ClinicNoLabel = New System.Windows.Forms.Label()
        Doctor_AddressLabel = New System.Windows.Forms.Label()
        Doctor_telLabel = New System.Windows.Forms.Label()
        DrugIDLabel = New System.Windows.Forms.Label()
        StaffIDLabel1 = New System.Windows.Forms.Label()
        Drug_nameLabel = New System.Windows.Forms.Label()
        Method_of_administrationLabel = New System.Windows.Forms.Label()
        Reorder_levelLabel = New System.Windows.Forms.Label()
        DosageLabel = New System.Windows.Forms.Label()
        Total_drugLabel = New System.Windows.Forms.Label()
        Cost_per_unitLabel = New System.Windows.Forms.Label()
        Quantity_in_stockLabel = New System.Windows.Forms.Label()
        DescriptionsLabel = New System.Windows.Forms.Label()
        WardIDLabel1 = New System.Windows.Forms.Label()
        WardnameLabel = New System.Windows.Forms.Label()
        Tel_extnLabel = New System.Windows.Forms.Label()
        RoomIDLabel = New System.Windows.Forms.Label()
        Total_bedLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        TreatmentIDLabel = New System.Windows.Forms.Label()
        PatientIDLabel1 = New System.Windows.Forms.Label()
        StaffIDLabel2 = New System.Windows.Forms.Label()
        DrugIDLabel1 = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        Date_timeLabel = New System.Windows.Forms.Label()
        SexLabel2 = New System.Windows.Forms.Label()
        PaidLabel1 = New System.Windows.Forms.Label()
        PositiontpyeLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StaffBindingNavigator.SuspendLayout()
        Me.patient.SuspendLayout()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.medcinesearch.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.Admitted_wardDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Admitted_wardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator4.SuspendLayout()
        CType(Me.TreatmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StaffIDLabel
        '
        StaffIDLabel.AutoSize = True
        StaffIDLabel.Location = New System.Drawing.Point(48, 185)
        StaffIDLabel.Name = "StaffIDLabel"
        StaffIDLabel.Size = New System.Drawing.Size(71, 31)
        StaffIDLabel.TabIndex = 0
        StaffIDLabel.Text = "staff ID:"
        '
        'StaffNameLabel
        '
        StaffNameLabel.AutoSize = True
        StaffNameLabel.Location = New System.Drawing.Point(559, 188)
        StaffNameLabel.Name = "StaffNameLabel"
        StaffNameLabel.Size = New System.Drawing.Size(99, 31)
        StaffNameLabel.TabIndex = 2
        StaffNameLabel.Text = "staff Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(48, 305)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(77, 31)
        AddressLabel.TabIndex = 6
        AddressLabel.Text = "Address:"
        '
        'BirthdateLabel
        '
        BirthdateLabel.AutoSize = True
        BirthdateLabel.Location = New System.Drawing.Point(48, 387)
        BirthdateLabel.Name = "BirthdateLabel"
        BirthdateLabel.Size = New System.Drawing.Size(87, 31)
        BirthdateLabel.TabIndex = 8
        BirthdateLabel.Text = "birthdate:"
        '
        'TelLabel
        '
        TelLabel.AutoSize = True
        TelLabel.Location = New System.Drawing.Point(559, 372)
        TelLabel.Name = "TelLabel"
        TelLabel.Size = New System.Drawing.Size(38, 31)
        TelLabel.TabIndex = 10
        TelLabel.Text = "tel:"
        '
        'NINLabel
        '
        NINLabel.AutoSize = True
        NINLabel.Location = New System.Drawing.Point(559, 446)
        NINLabel.Name = "NINLabel"
        NINLabel.Size = New System.Drawing.Size(44, 31)
        NINLabel.TabIndex = 12
        NINLabel.Text = "NIN:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(48, 449)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(77, 31)
        PositionLabel.TabIndex = 14
        PositionLabel.Text = "position:"
        '
        'WardIDLabel
        '
        WardIDLabel.AutoSize = True
        WardIDLabel.Location = New System.Drawing.Point(48, 246)
        WardIDLabel.Name = "WardIDLabel"
        WardIDLabel.Size = New System.Drawing.Size(73, 31)
        WardIDLabel.TabIndex = 16
        WardIDLabel.Text = "ward ID:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Location = New System.Drawing.Point(559, 526)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(61, 31)
        SalaryLabel.TabIndex = 18
        SalaryLabel.Text = "Salary:"
        '
        'HoursLabel
        '
        HoursLabel.AutoSize = True
        HoursLabel.Location = New System.Drawing.Point(48, 519)
        HoursLabel.Name = "HoursLabel"
        HoursLabel.Size = New System.Drawing.Size(60, 31)
        HoursLabel.TabIndex = 20
        HoursLabel.Text = "hours:"
        '
        'PaidLabel
        '
        PaidLabel.AutoSize = True
        PaidLabel.Location = New System.Drawing.Point(559, 601)
        PaidLabel.Name = "PaidLabel"
        PaidLabel.Size = New System.Drawing.Size(0, 31)
        PaidLabel.TabIndex = 22
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(48, 662)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(51, 31)
        TypeLabel.TabIndex = 26
        TypeLabel.Text = "type:"
        '
        'InstitutionLabel
        '
        InstitutionLabel.AutoSize = True
        InstitutionLabel.Location = New System.Drawing.Point(48, 791)
        InstitutionLabel.Name = "InstitutionLabel"
        InstitutionLabel.Size = New System.Drawing.Size(94, 31)
        InstitutionLabel.TabIndex = 28
        InstitutionLabel.Text = "institution:"
        '
        'Graduation_DateLabel
        '
        Graduation_DateLabel.AutoSize = True
        Graduation_DateLabel.Location = New System.Drawing.Point(546, 795)
        Graduation_DateLabel.Name = "Graduation_DateLabel"
        Graduation_DateLabel.Size = New System.Drawing.Size(138, 31)
        Graduation_DateLabel.TabIndex = 30
        Graduation_DateLabel.Text = "Graduation Date:"
        '
        'OrganizationLabel
        '
        OrganizationLabel.AutoSize = True
        OrganizationLabel.Location = New System.Drawing.Point(63, 893)
        OrganizationLabel.Name = "OrganizationLabel"
        OrganizationLabel.Size = New System.Drawing.Size(108, 31)
        OrganizationLabel.TabIndex = 32
        OrganizationLabel.Text = "organization:"
        '
        'Position_pastLabel
        '
        Position_pastLabel.AutoSize = True
        Position_pastLabel.Location = New System.Drawing.Point(561, 893)
        Position_pastLabel.Name = "Position_pastLabel"
        Position_pastLabel.Size = New System.Drawing.Size(113, 31)
        Position_pastLabel.TabIndex = 34
        Position_pastLabel.Text = "position past:"
        '
        'Start_dateLabel
        '
        Start_dateLabel.AutoSize = True
        Start_dateLabel.Location = New System.Drawing.Point(65, 949)
        Start_dateLabel.Name = "Start_dateLabel"
        Start_dateLabel.Size = New System.Drawing.Size(89, 31)
        Start_dateLabel.TabIndex = 36
        Start_dateLabel.Text = "start date:"
        '
        'Finish_dateLabel
        '
        Finish_dateLabel.AutoSize = True
        Finish_dateLabel.Location = New System.Drawing.Point(561, 946)
        Finish_dateLabel.Name = "Finish_dateLabel"
        Finish_dateLabel.Size = New System.Drawing.Size(96, 31)
        Finish_dateLabel.TabIndex = 38
        Finish_dateLabel.Text = "finish date:"
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.Location = New System.Drawing.Point(112, 109)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(91, 31)
        PatientIDLabel.TabIndex = 0
        PatientIDLabel.Text = "patient ID:"
        '
        'PatientNameLabel
        '
        PatientNameLabel.AutoSize = True
        PatientNameLabel.Location = New System.Drawing.Point(623, 102)
        PatientNameLabel.Name = "PatientNameLabel"
        PatientNameLabel.Size = New System.Drawing.Size(119, 31)
        PatientNameLabel.TabIndex = 2
        PatientNameLabel.Text = "patient Name:"
        '
        'Patient_AddressLabel
        '
        Patient_AddressLabel.AutoSize = True
        Patient_AddressLabel.Location = New System.Drawing.Point(112, 240)
        Patient_AddressLabel.Name = "Patient_AddressLabel"
        Patient_AddressLabel.Size = New System.Drawing.Size(135, 31)
        Patient_AddressLabel.TabIndex = 4
        Patient_AddressLabel.Text = "patient Address:"
        '
        'BirthdateLabel1
        '
        BirthdateLabel1.AutoSize = True
        BirthdateLabel1.Location = New System.Drawing.Point(632, 185)
        BirthdateLabel1.Name = "BirthdateLabel1"
        BirthdateLabel1.Size = New System.Drawing.Size(87, 31)
        BirthdateLabel1.TabIndex = 6
        BirthdateLabel1.Text = "birthdate:"
        '
        'SexLabel1
        '
        SexLabel1.AutoSize = True
        SexLabel1.Location = New System.Drawing.Point(112, 185)
        SexLabel1.Name = "SexLabel1"
        SexLabel1.Size = New System.Drawing.Size(42, 31)
        SexLabel1.TabIndex = 8
        SexLabel1.Text = "sex:"
        'AddHandler SexLabel1.Click, AddressOf Me.SexLabel1_Click
        '
        'Maritall_statusLabel
        '
        Maritall_statusLabel.AutoSize = True
        Maritall_statusLabel.Location = New System.Drawing.Point(112, 309)
        Maritall_statusLabel.Name = "Maritall_statusLabel"
        Maritall_statusLabel.Size = New System.Drawing.Size(124, 31)
        Maritall_statusLabel.TabIndex = 10
        Maritall_statusLabel.Text = "maritall status:"
        '
        'Patient_telLabel
        '
        Patient_telLabel.AutoSize = True
        Patient_telLabel.Location = New System.Drawing.Point(623, 305)
        Patient_telLabel.Name = "Patient_telLabel"
        Patient_telLabel.Size = New System.Drawing.Size(96, 31)
        Patient_telLabel.TabIndex = 12
        Patient_telLabel.Text = "patient tel:"
        '
        'Date_admissionLabel
        '
        Date_admissionLabel.AutoSize = True
        Date_admissionLabel.Location = New System.Drawing.Point(112, 363)
        Date_admissionLabel.Name = "Date_admissionLabel"
        Date_admissionLabel.Size = New System.Drawing.Size(130, 31)
        Date_admissionLabel.TabIndex = 14
        Date_admissionLabel.Text = "date admission:"
        '
        'Next_of_kinNameLabel
        '
        Next_of_kinNameLabel.AutoSize = True
        Next_of_kinNameLabel.Location = New System.Drawing.Point(112, 486)
        Next_of_kinNameLabel.Name = "Next_of_kinNameLabel"
        Next_of_kinNameLabel.Size = New System.Drawing.Size(147, 31)
        Next_of_kinNameLabel.TabIndex = 16
        Next_of_kinNameLabel.Text = "Next of kin Name:"
        '
        'RelationshipLabel
        '
        RelationshipLabel.AutoSize = True
        RelationshipLabel.Location = New System.Drawing.Point(623, 489)
        RelationshipLabel.Name = "RelationshipLabel"
        RelationshipLabel.Size = New System.Drawing.Size(106, 31)
        RelationshipLabel.TabIndex = 18
        RelationshipLabel.Text = "relationship:"
        '
        'Next_of_kin_AddressLabel
        '
        Next_of_kin_AddressLabel.AutoSize = True
        Next_of_kin_AddressLabel.Location = New System.Drawing.Point(112, 547)
        Next_of_kin_AddressLabel.Name = "Next_of_kin_AddressLabel"
        Next_of_kin_AddressLabel.Size = New System.Drawing.Size(163, 31)
        Next_of_kin_AddressLabel.TabIndex = 20
        Next_of_kin_AddressLabel.Text = "Next of kin Address:"
        '
        'Next_of_kin_telLabel
        '
        Next_of_kin_telLabel.AutoSize = True
        Next_of_kin_telLabel.Location = New System.Drawing.Point(112, 611)
        Next_of_kin_telLabel.Name = "Next_of_kin_telLabel"
        Next_of_kin_telLabel.Size = New System.Drawing.Size(124, 31)
        Next_of_kin_telLabel.TabIndex = 22
        Next_of_kin_telLabel.Text = "Next of kin tel:"
        '
        'DoctorNameLabel
        '
        DoctorNameLabel.AutoSize = True
        DoctorNameLabel.Location = New System.Drawing.Point(112, 739)
        DoctorNameLabel.Name = "DoctorNameLabel"
        DoctorNameLabel.Size = New System.Drawing.Size(114, 31)
        DoctorNameLabel.TabIndex = 24
        DoctorNameLabel.Text = "doctor Name:"
        '
        'ClinicNoLabel
        '
        ClinicNoLabel.AutoSize = True
        ClinicNoLabel.Location = New System.Drawing.Point(623, 735)
        ClinicNoLabel.Name = "ClinicNoLabel"
        ClinicNoLabel.Size = New System.Drawing.Size(82, 31)
        ClinicNoLabel.TabIndex = 26
        ClinicNoLabel.Text = "clinic No:"
        '
        'Doctor_AddressLabel
        '
        Doctor_AddressLabel.AutoSize = True
        Doctor_AddressLabel.Location = New System.Drawing.Point(112, 811)
        Doctor_AddressLabel.Name = "Doctor_AddressLabel"
        Doctor_AddressLabel.Size = New System.Drawing.Size(130, 31)
        Doctor_AddressLabel.TabIndex = 28
        Doctor_AddressLabel.Text = "doctor Address:"
        '
        'Doctor_telLabel
        '
        Doctor_telLabel.AutoSize = True
        Doctor_telLabel.Location = New System.Drawing.Point(112, 883)
        Doctor_telLabel.Name = "Doctor_telLabel"
        Doctor_telLabel.Size = New System.Drawing.Size(91, 31)
        Doctor_telLabel.TabIndex = 30
        Doctor_telLabel.Text = "doctor tel:"
        '
        'DrugIDLabel
        '
        DrugIDLabel.AutoSize = True
        DrugIDLabel.Location = New System.Drawing.Point(63, 198)
        DrugIDLabel.Name = "DrugIDLabel"
        DrugIDLabel.Size = New System.Drawing.Size(72, 31)
        DrugIDLabel.TabIndex = 0
        DrugIDLabel.Text = "drug ID:"
        '
        'StaffIDLabel1
        '
        StaffIDLabel1.AutoSize = True
        StaffIDLabel1.Location = New System.Drawing.Point(63, 132)
        StaffIDLabel1.Name = "StaffIDLabel1"
        StaffIDLabel1.Size = New System.Drawing.Size(71, 31)
        StaffIDLabel1.TabIndex = 2
        StaffIDLabel1.Text = "staff ID:"
        '
        'Drug_nameLabel
        '
        Drug_nameLabel.AutoSize = True
        Drug_nameLabel.Location = New System.Drawing.Point(637, 201)
        Drug_nameLabel.Name = "Drug_nameLabel"
        Drug_nameLabel.Size = New System.Drawing.Size(99, 31)
        Drug_nameLabel.TabIndex = 4
        Drug_nameLabel.Text = "drug name:"
        '
        'Method_of_administrationLabel
        '
        Method_of_administrationLabel.AutoSize = True
        Method_of_administrationLabel.Location = New System.Drawing.Point(63, 256)
        Method_of_administrationLabel.Name = "Method_of_administrationLabel"
        Method_of_administrationLabel.Size = New System.Drawing.Size(209, 31)
        Method_of_administrationLabel.TabIndex = 6
        Method_of_administrationLabel.Text = "method of administration:"
        '
        'Reorder_levelLabel
        '
        Reorder_levelLabel.AutoSize = True
        Reorder_levelLabel.Location = New System.Drawing.Point(637, 268)
        Reorder_levelLabel.Name = "Reorder_levelLabel"
        Reorder_levelLabel.Size = New System.Drawing.Size(114, 31)
        Reorder_levelLabel.TabIndex = 8
        Reorder_levelLabel.Text = "reorder level:"
        '
        'DosageLabel
        '
        DosageLabel.AutoSize = True
        DosageLabel.Location = New System.Drawing.Point(63, 320)
        DosageLabel.Name = "DosageLabel"
        DosageLabel.Size = New System.Drawing.Size(69, 31)
        DosageLabel.TabIndex = 10
        DosageLabel.Text = "dosage:"
        '
        'Total_drugLabel
        '
        Total_drugLabel.AutoSize = True
        Total_drugLabel.Location = New System.Drawing.Point(637, 323)
        Total_drugLabel.Name = "Total_drugLabel"
        Total_drugLabel.Size = New System.Drawing.Size(91, 31)
        Total_drugLabel.TabIndex = 12
        Total_drugLabel.Text = "total drug:"
        '
        'Cost_per_unitLabel
        '
        Cost_per_unitLabel.AutoSize = True
        Cost_per_unitLabel.Location = New System.Drawing.Point(63, 382)
        Cost_per_unitLabel.Name = "Cost_per_unitLabel"
        Cost_per_unitLabel.Size = New System.Drawing.Size(113, 31)
        Cost_per_unitLabel.TabIndex = 14
        Cost_per_unitLabel.Text = "cost per unit:"
        '
        'Quantity_in_stockLabel
        '
        Quantity_in_stockLabel.AutoSize = True
        Quantity_in_stockLabel.Location = New System.Drawing.Point(637, 385)
        Quantity_in_stockLabel.Name = "Quantity_in_stockLabel"
        Quantity_in_stockLabel.Size = New System.Drawing.Size(142, 31)
        Quantity_in_stockLabel.TabIndex = 16
        Quantity_in_stockLabel.Text = "quantity in stock:"
        '
        'DescriptionsLabel
        '
        DescriptionsLabel.AutoSize = True
        DescriptionsLabel.Location = New System.Drawing.Point(63, 460)
        DescriptionsLabel.Name = "DescriptionsLabel"
        DescriptionsLabel.Size = New System.Drawing.Size(108, 31)
        DescriptionsLabel.TabIndex = 18
        DescriptionsLabel.Text = "descriptions:"
        '
        'WardIDLabel1
        '
        WardIDLabel1.AutoSize = True
        WardIDLabel1.Location = New System.Drawing.Point(140, 120)
        WardIDLabel1.Name = "WardIDLabel1"
        WardIDLabel1.Size = New System.Drawing.Size(73, 31)
        WardIDLabel1.TabIndex = 0
        WardIDLabel1.Text = "ward ID:"
        '
        'WardnameLabel
        '
        WardnameLabel.AutoSize = True
        WardnameLabel.Location = New System.Drawing.Point(585, 123)
        WardnameLabel.Name = "WardnameLabel"
        WardnameLabel.Size = New System.Drawing.Size(95, 31)
        WardnameLabel.TabIndex = 2
        WardnameLabel.Text = "wardname:"
        '
        'Tel_extnLabel
        '
        Tel_extnLabel.AutoSize = True
        Tel_extnLabel.Location = New System.Drawing.Point(585, 281)
        Tel_extnLabel.Name = "Tel_extnLabel"
        Tel_extnLabel.Size = New System.Drawing.Size(76, 31)
        Tel_extnLabel.TabIndex = 4
        Tel_extnLabel.Text = "tel extn:"
        '
        'RoomIDLabel
        '
        RoomIDLabel.AutoSize = True
        RoomIDLabel.Location = New System.Drawing.Point(140, 203)
        RoomIDLabel.Name = "RoomIDLabel"
        RoomIDLabel.Size = New System.Drawing.Size(77, 31)
        RoomIDLabel.TabIndex = 6
        RoomIDLabel.Text = "room ID:"
        '
        'Total_bedLabel
        '
        Total_bedLabel.AutoSize = True
        Total_bedLabel.Location = New System.Drawing.Point(585, 203)
        Total_bedLabel.Name = "Total_bedLabel"
        Total_bedLabel.Size = New System.Drawing.Size(86, 31)
        Total_bedLabel.TabIndex = 8
        Total_bedLabel.Text = "total bed:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Location = New System.Drawing.Point(140, 285)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(77, 31)
        LocationLabel.TabIndex = 10
        LocationLabel.Text = "location:"
        '
        'TreatmentIDLabel
        '
        TreatmentIDLabel.AutoSize = True
        TreatmentIDLabel.Location = New System.Drawing.Point(99, 78)
        TreatmentIDLabel.Name = "TreatmentIDLabel"
        TreatmentIDLabel.Size = New System.Drawing.Size(113, 31)
        TreatmentIDLabel.TabIndex = 0
        TreatmentIDLabel.Text = "treatment ID:"
        '
        'PatientIDLabel1
        '
        PatientIDLabel1.AutoSize = True
        PatientIDLabel1.Location = New System.Drawing.Point(99, 122)
        PatientIDLabel1.Name = "PatientIDLabel1"
        PatientIDLabel1.Size = New System.Drawing.Size(91, 31)
        PatientIDLabel1.TabIndex = 2
        PatientIDLabel1.Text = "patient ID:"
        '
        'StaffIDLabel2
        '
        StaffIDLabel2.AutoSize = True
        StaffIDLabel2.Location = New System.Drawing.Point(99, 166)
        StaffIDLabel2.Name = "StaffIDLabel2"
        StaffIDLabel2.Size = New System.Drawing.Size(71, 31)
        StaffIDLabel2.TabIndex = 4
        StaffIDLabel2.Text = "staff ID:"
        '
        'DrugIDLabel1
        '
        DrugIDLabel1.AutoSize = True
        DrugIDLabel1.Location = New System.Drawing.Point(99, 210)
        DrugIDLabel1.Name = "DrugIDLabel1"
        DrugIDLabel1.Size = New System.Drawing.Size(72, 31)
        DrugIDLabel1.TabIndex = 6
        DrugIDLabel1.Text = "drug ID:"
        'AddHandler DrugIDLabel1.Click, AddressOf Me.DrugIDLabel1_Click
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(99, 309)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(52, 31)
        TotalLabel.TabIndex = 8
        TotalLabel.Text = "total:"
        '
        'Date_timeLabel
        '
        Date_timeLabel.AutoSize = True
        Date_timeLabel.Location = New System.Drawing.Point(99, 354)
        Date_timeLabel.Name = "Date_timeLabel"
        Date_timeLabel.Size = New System.Drawing.Size(90, 31)
        Date_timeLabel.TabIndex = 10
        Date_timeLabel.Text = "date time:"
        '
        'SexLabel2
        '
        SexLabel2.AutoSize = True
        SexLabel2.Location = New System.Drawing.Point(559, 246)
        SexLabel2.Name = "SexLabel2"
        SexLabel2.Size = New System.Drawing.Size(42, 31)
        SexLabel2.TabIndex = 47
        SexLabel2.Text = "sex:"
        '
        'PaidLabel1
        '
        PaidLabel1.AutoSize = True
        PaidLabel1.Location = New System.Drawing.Point(559, 606)
        PaidLabel1.Name = "PaidLabel1"
        PaidLabel1.Size = New System.Drawing.Size(50, 31)
        PaidLabel1.TabIndex = 48
        PaidLabel1.Text = "paid:"
        '
        'PositiontpyeLabel
        '
        PositiontpyeLabel.AutoSize = True
        PositiontpyeLabel.Location = New System.Drawing.Point(48, 593)
        PositiontpyeLabel.Name = "PositiontpyeLabel"
        PositiontpyeLabel.Size = New System.Drawing.Size(110, 31)
        PositiontpyeLabel.TabIndex = 49
        PositiontpyeLabel.Text = "positiontpye:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.patient)
        Me.TabControl1.Controls.Add(Me.medcinesearch)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1423, 1051)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage1.Controls.Add(PositiontpyeLabel)
        Me.TabPage1.Controls.Add(Me.PositiontpyeComboBox)
        Me.TabPage1.Controls.Add(PaidLabel1)
        Me.TabPage1.Controls.Add(Me.PaidComboBox)
        Me.TabPage1.Controls.Add(SexLabel2)
        Me.TabPage1.Controls.Add(Me.SexComboBox)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.staffsearch)
        Me.TabPage1.Controls.Add(Me.textstaffName)
        Me.TabPage1.Controls.Add(Me.Experience_work)
        Me.TabPage1.Controls.Add(Me.Qualifications)
        Me.TabPage1.Controls.Add(Me.StaffBindingNavigator)
        Me.TabPage1.Controls.Add(StaffIDLabel)
        Me.TabPage1.Controls.Add(Me.StaffIDTextBox)
        Me.TabPage1.Controls.Add(StaffNameLabel)
        Me.TabPage1.Controls.Add(Me.StaffNameTextBox)
        Me.TabPage1.Controls.Add(AddressLabel)
        Me.TabPage1.Controls.Add(Me.AddressTextBox)
        Me.TabPage1.Controls.Add(BirthdateLabel)
        Me.TabPage1.Controls.Add(Me.BirthdateDateTimePicker)
        Me.TabPage1.Controls.Add(TelLabel)
        Me.TabPage1.Controls.Add(Me.TelTextBox)
        Me.TabPage1.Controls.Add(NINLabel)
        Me.TabPage1.Controls.Add(Me.NINTextBox)
        Me.TabPage1.Controls.Add(PositionLabel)
        Me.TabPage1.Controls.Add(Me.PositionTextBox)
        Me.TabPage1.Controls.Add(WardIDLabel)
        Me.TabPage1.Controls.Add(Me.WardIDTextBox)
        Me.TabPage1.Controls.Add(SalaryLabel)
        Me.TabPage1.Controls.Add(Me.SalaryTextBox)
        Me.TabPage1.Controls.Add(HoursLabel)
        Me.TabPage1.Controls.Add(Me.HoursTextBox)
        Me.TabPage1.Controls.Add(PaidLabel)
        Me.TabPage1.Controls.Add(TypeLabel)
        Me.TabPage1.Controls.Add(Me.TypeTextBox)
        Me.TabPage1.Controls.Add(InstitutionLabel)
        Me.TabPage1.Controls.Add(Me.InstitutionTextBox)
        Me.TabPage1.Controls.Add(Graduation_DateLabel)
        Me.TabPage1.Controls.Add(Me.Graduation_DateDateTimePicker)
        Me.TabPage1.Controls.Add(OrganizationLabel)
        Me.TabPage1.Controls.Add(Me.OrganizationTextBox)
        Me.TabPage1.Controls.Add(Position_pastLabel)
        Me.TabPage1.Controls.Add(Me.Position_pastTextBox)
        Me.TabPage1.Controls.Add(Start_dateLabel)
        Me.TabPage1.Controls.Add(Me.Start_dateDateTimePicker)
        Me.TabPage1.Controls.Add(Finish_dateLabel)
        Me.TabPage1.Controls.Add(Me.Finish_dateDateTimePicker)
        Me.TabPage1.Location = New System.Drawing.Point(4, 40)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1415, 1007)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Staff"
        '
        'PositiontpyeComboBox
        '
        Me.PositiontpyeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "positiontpye", True))
        Me.PositiontpyeComboBox.FormattingEnabled = True
        Me.PositiontpyeComboBox.Location = New System.Drawing.Point(192, 593)
        Me.PositiontpyeComboBox.Name = "PositiontpyeComboBox"
        Me.PositiontpyeComboBox.Size = New System.Drawing.Size(258, 39)
        Me.PositiontpyeComboBox.TabIndex = 50
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "staff"
        Me.StaffBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'Wellmeadows_hospitalDataSet
        '
        Me.Wellmeadows_hospitalDataSet.DataSetName = "wellmeadows_hospitalDataSet"
        Me.Wellmeadows_hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaidComboBox
        '
        Me.PaidComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "paid", True))
        Me.PaidComboBox.FormattingEnabled = True
        Me.PaidComboBox.Location = New System.Drawing.Point(703, 598)
        Me.PaidComboBox.Name = "PaidComboBox"
        Me.PaidComboBox.Size = New System.Drawing.Size(301, 39)
        Me.PaidComboBox.TabIndex = 49
        '
        'SexComboBox
        '
        Me.SexComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "sex", True))
        Me.SexComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.StaffBindingSource, "sex", True))
        Me.SexComboBox.FormattingEnabled = True
        Me.SexComboBox.Location = New System.Drawing.Point(703, 246)
        Me.SexComboBox.Name = "SexComboBox"
        Me.SexComboBox.Size = New System.Drawing.Size(298, 39)
        Me.SexComboBox.TabIndex = 48
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(731, 120)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(273, 38)
        Me.TextBox3.TabIndex = 46
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(731, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(273, 38)
        Me.TextBox2.TabIndex = 45
        '
        'staffsearch
        '
        Me.staffsearch.BackColor = System.Drawing.Color.LightGray
        Me.staffsearch.ForeColor = System.Drawing.Color.Black
        Me.staffsearch.Location = New System.Drawing.Point(1017, 11)
        Me.staffsearch.Name = "staffsearch"
        Me.staffsearch.Size = New System.Drawing.Size(114, 38)
        Me.staffsearch.TabIndex = 43
        Me.staffsearch.Text = "Search"
        Me.staffsearch.UseVisualStyleBackColor = False
        '
        'textstaffName
        '
        Me.textstaffName.BackColor = System.Drawing.SystemColors.Menu
        Me.textstaffName.Location = New System.Drawing.Point(731, 11)
        Me.textstaffName.Name = "textstaffName"
        Me.textstaffName.Size = New System.Drawing.Size(271, 38)
        Me.textstaffName.TabIndex = 42
        '
        'Experience_work
        '
        Me.Experience_work.AutoSize = True
        Me.Experience_work.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Experience_work.Location = New System.Drawing.Point(24, 834)
        Me.Experience_work.Name = "Experience_work"
        Me.Experience_work.Size = New System.Drawing.Size(173, 40)
        Me.Experience_work.TabIndex = 41
        Me.Experience_work.Text = "Experience work"
        '
        'Qualifications
        '
        Me.Qualifications.AutoSize = True
        Me.Qualifications.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Qualifications.Location = New System.Drawing.Point(9, 737)
        Me.Qualifications.Name = "Qualifications"
        Me.Qualifications.Size = New System.Drawing.Size(149, 40)
        Me.Qualifications.TabIndex = 40
        Me.Qualifications.Text = "Qualifications"
        '
        'StaffBindingNavigator
        '
        Me.StaffBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StaffBindingNavigator.BindingSource = Me.StaffBindingSource
        Me.StaffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StaffBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StaffBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.StaffBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StaffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StaffBindingNavigatorSaveItem})
        Me.StaffBindingNavigator.Location = New System.Drawing.Point(5, 3)
        Me.StaffBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StaffBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StaffBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StaffBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StaffBindingNavigator.Name = "StaffBindingNavigator"
        Me.StaffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StaffBindingNavigator.Size = New System.Drawing.Size(331, 27)
        Me.StaffBindingNavigator.TabIndex = 1
        Me.StaffBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Leelawadee UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'StaffBindingNavigatorSaveItem
        '
        Me.StaffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StaffBindingNavigatorSaveItem.Image = CType(resources.GetObject("StaffBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StaffBindingNavigatorSaveItem.Name = "StaffBindingNavigatorSaveItem"
        Me.StaffBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.StaffBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StaffIDTextBox
        '
        Me.StaffIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "staffID", True))
        Me.StaffIDTextBox.Location = New System.Drawing.Point(192, 182)
        Me.StaffIDTextBox.Name = "StaffIDTextBox"
        Me.StaffIDTextBox.Size = New System.Drawing.Size(258, 38)
        Me.StaffIDTextBox.TabIndex = 1
        '
        'StaffNameTextBox
        '
        Me.StaffNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "staffName", True))
        Me.StaffNameTextBox.Location = New System.Drawing.Point(703, 185)
        Me.StaffNameTextBox.Name = "StaffNameTextBox"
        Me.StaffNameTextBox.Size = New System.Drawing.Size(298, 38)
        Me.StaffNameTextBox.TabIndex = 3
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(192, 302)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(809, 38)
        Me.AddressTextBox.TabIndex = 7
        '
        'BirthdateDateTimePicker
        '
        Me.BirthdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "birthdate", True))
        Me.BirthdateDateTimePicker.Location = New System.Drawing.Point(192, 383)
        Me.BirthdateDateTimePicker.Name = "BirthdateDateTimePicker"
        Me.BirthdateDateTimePicker.Size = New System.Drawing.Size(298, 38)
        Me.BirthdateDateTimePicker.TabIndex = 9
        '
        'TelTextBox
        '
        Me.TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "tel", True))
        Me.TelTextBox.Location = New System.Drawing.Point(703, 365)
        Me.TelTextBox.Name = "TelTextBox"
        Me.TelTextBox.Size = New System.Drawing.Size(298, 38)
        Me.TelTextBox.TabIndex = 11
        '
        'NINTextBox
        '
        Me.NINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "NIN", True))
        Me.NINTextBox.Location = New System.Drawing.Point(703, 439)
        Me.NINTextBox.Name = "NINTextBox"
        Me.NINTextBox.Size = New System.Drawing.Size(298, 38)
        Me.NINTextBox.TabIndex = 13
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "position", True))
        Me.PositionTextBox.Location = New System.Drawing.Point(192, 446)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(258, 38)
        Me.PositionTextBox.TabIndex = 15
        '
        'WardIDTextBox
        '
        Me.WardIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "wardID", True))
        Me.WardIDTextBox.Location = New System.Drawing.Point(192, 243)
        Me.WardIDTextBox.Name = "WardIDTextBox"
        Me.WardIDTextBox.Size = New System.Drawing.Size(258, 38)
        Me.WardIDTextBox.TabIndex = 17
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Salary", True))
        Me.SalaryTextBox.Location = New System.Drawing.Point(703, 519)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(298, 38)
        Me.SalaryTextBox.TabIndex = 19
        '
        'HoursTextBox
        '
        Me.HoursTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "hours", True))
        Me.HoursTextBox.Location = New System.Drawing.Point(192, 516)
        Me.HoursTextBox.Name = "HoursTextBox"
        Me.HoursTextBox.Size = New System.Drawing.Size(258, 38)
        Me.HoursTextBox.TabIndex = 21
        '
        'TypeTextBox
        '
        Me.TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "type", True))
        Me.TypeTextBox.Location = New System.Drawing.Point(192, 659)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(258, 38)
        Me.TypeTextBox.TabIndex = 27
        '
        'InstitutionTextBox
        '
        Me.InstitutionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "institution", True))
        Me.InstitutionTextBox.Location = New System.Drawing.Point(192, 788)
        Me.InstitutionTextBox.Name = "InstitutionTextBox"
        Me.InstitutionTextBox.Size = New System.Drawing.Size(258, 38)
        Me.InstitutionTextBox.TabIndex = 29
        '
        'Graduation_DateDateTimePicker
        '
        Me.Graduation_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "Graduation_Date", True))
        Me.Graduation_DateDateTimePicker.Location = New System.Drawing.Point(704, 791)
        Me.Graduation_DateDateTimePicker.Name = "Graduation_DateDateTimePicker"
        Me.Graduation_DateDateTimePicker.Size = New System.Drawing.Size(298, 38)
        Me.Graduation_DateDateTimePicker.TabIndex = 31
        '
        'OrganizationTextBox
        '
        Me.OrganizationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "organization", True))
        Me.OrganizationTextBox.Location = New System.Drawing.Point(207, 886)
        Me.OrganizationTextBox.Name = "OrganizationTextBox"
        Me.OrganizationTextBox.Size = New System.Drawing.Size(267, 38)
        Me.OrganizationTextBox.TabIndex = 33
        '
        'Position_pastTextBox
        '
        Me.Position_pastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "position_past", True))
        Me.Position_pastTextBox.Location = New System.Drawing.Point(719, 886)
        Me.Position_pastTextBox.Name = "Position_pastTextBox"
        Me.Position_pastTextBox.Size = New System.Drawing.Size(298, 38)
        Me.Position_pastTextBox.TabIndex = 35
        '
        'Start_dateDateTimePicker
        '
        Me.Start_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "start_date", True))
        Me.Start_dateDateTimePicker.Location = New System.Drawing.Point(209, 946)
        Me.Start_dateDateTimePicker.Name = "Start_dateDateTimePicker"
        Me.Start_dateDateTimePicker.Size = New System.Drawing.Size(267, 38)
        Me.Start_dateDateTimePicker.TabIndex = 37
        '
        'Finish_dateDateTimePicker
        '
        Me.Finish_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "finish_date", True))
        Me.Finish_dateDateTimePicker.Location = New System.Drawing.Point(719, 949)
        Me.Finish_dateDateTimePicker.Name = "Finish_dateDateTimePicker"
        Me.Finish_dateDateTimePicker.Size = New System.Drawing.Size(299, 38)
        Me.Finish_dateDateTimePicker.TabIndex = 39
        '
        'patient
        '
        Me.patient.Controls.Add(Me.PatientSex)
        Me.patient.Controls.Add(Me.Location_Doctor_Details)
        Me.patient.Controls.Add(Me.Next_of_kin)
        Me.patient.Controls.Add(Me.BindingNavigator1)
        Me.patient.Controls.Add(Me.patientsearch)
        Me.patient.Controls.Add(Me.textpatientName)
        Me.patient.Controls.Add(PatientIDLabel)
        Me.patient.Controls.Add(Me.PatientIDTextBox)
        Me.patient.Controls.Add(PatientNameLabel)
        Me.patient.Controls.Add(Me.PatientNameTextBox)
        Me.patient.Controls.Add(Patient_AddressLabel)
        Me.patient.Controls.Add(Me.Patient_AddressTextBox)
        Me.patient.Controls.Add(BirthdateLabel1)
        Me.patient.Controls.Add(Me.BirthdateDateTimePicker1)
        Me.patient.Controls.Add(SexLabel1)
        Me.patient.Controls.Add(Maritall_statusLabel)
        Me.patient.Controls.Add(Me.Maritall_statusTextBox)
        Me.patient.Controls.Add(Patient_telLabel)
        Me.patient.Controls.Add(Me.Patient_telTextBox)
        Me.patient.Controls.Add(Date_admissionLabel)
        Me.patient.Controls.Add(Me.Date_admissionDateTimePicker)
        Me.patient.Controls.Add(Next_of_kinNameLabel)
        Me.patient.Controls.Add(Me.Next_of_kinNameTextBox)
        Me.patient.Controls.Add(RelationshipLabel)
        Me.patient.Controls.Add(Me.RelationshipTextBox)
        Me.patient.Controls.Add(Next_of_kin_AddressLabel)
        Me.patient.Controls.Add(Me.Next_of_kin_AddressTextBox)
        Me.patient.Controls.Add(Next_of_kin_telLabel)
        Me.patient.Controls.Add(Me.Next_of_kin_telTextBox)
        Me.patient.Controls.Add(DoctorNameLabel)
        Me.patient.Controls.Add(Me.DoctorNameTextBox)
        Me.patient.Controls.Add(ClinicNoLabel)
        Me.patient.Controls.Add(Me.ClinicNoTextBox)
        Me.patient.Controls.Add(Doctor_AddressLabel)
        Me.patient.Controls.Add(Me.Doctor_AddressTextBox)
        Me.patient.Controls.Add(Doctor_telLabel)
        Me.patient.Controls.Add(Me.Doctor_telTextBox)
        Me.patient.Location = New System.Drawing.Point(4, 40)
        Me.patient.Name = "patient"
        Me.patient.Padding = New System.Windows.Forms.Padding(3)
        Me.patient.Size = New System.Drawing.Size(1415, 1007)
        Me.patient.TabIndex = 1
        Me.patient.Text = "Patient"
        Me.patient.UseVisualStyleBackColor = True
        '
        'PatientSex
        '
        Me.PatientSex.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PatientBindingSource, "sex", True))
        Me.PatientSex.FormattingEnabled = True
        Me.PatientSex.Location = New System.Drawing.Point(281, 177)
        Me.PatientSex.Name = "PatientSex"
        Me.PatientSex.Size = New System.Drawing.Size(230, 39)
        Me.PatientSex.TabIndex = 48
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "patient"
        Me.PatientBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'Location_Doctor_Details
        '
        Me.Location_Doctor_Details.AutoSize = True
        Me.Location_Doctor_Details.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Location_Doctor_Details.Location = New System.Drawing.Point(40, 672)
        Me.Location_Doctor_Details.Name = "Location_Doctor_Details"
        Me.Location_Doctor_Details.Size = New System.Drawing.Size(245, 40)
        Me.Location_Doctor_Details.TabIndex = 48
        Me.Location_Doctor_Details.Text = "Location Doctor Details"
        '
        'Next_of_kin
        '
        Me.Next_of_kin.AutoSize = True
        Me.Next_of_kin.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Next_of_kin.Location = New System.Drawing.Point(40, 433)
        Me.Next_of_kin.Name = "Next_of_kin"
        Me.Next_of_kin.Size = New System.Drawing.Size(124, 40)
        Me.Next_of_kin.TabIndex = 47
        Me.Next_of_kin.Text = "Next of kin"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BindingSource = Me.PatientBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(1409, 27)
        Me.BindingNavigator1.TabIndex = 46
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Font = New System.Drawing.Font("Leelawadee UI", 9.0!)
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton1.Text = "Save Data"
        '
        'patientsearch
        '
        Me.patientsearch.BackColor = System.Drawing.Color.LightGray
        Me.patientsearch.ForeColor = System.Drawing.Color.Black
        Me.patientsearch.Location = New System.Drawing.Point(1045, 33)
        Me.patientsearch.Name = "patientsearch"
        Me.patientsearch.Size = New System.Drawing.Size(114, 38)
        Me.patientsearch.TabIndex = 45
        Me.patientsearch.Text = "Search"
        Me.patientsearch.UseVisualStyleBackColor = False
        '
        'textpatientName
        '
        Me.textpatientName.BackColor = System.Drawing.SystemColors.Menu
        Me.textpatientName.Location = New System.Drawing.Point(594, 33)
        Me.textpatientName.Name = "textpatientName"
        Me.textpatientName.Size = New System.Drawing.Size(436, 38)
        Me.textpatientName.TabIndex = 44
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "patientID", True))
        Me.PatientIDTextBox.Location = New System.Drawing.Point(281, 102)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.Size = New System.Drawing.Size(235, 38)
        Me.PatientIDTextBox.TabIndex = 1
        '
        'PatientNameTextBox
        '
        Me.PatientNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "patientName", True))
        Me.PatientNameTextBox.Location = New System.Drawing.Point(792, 102)
        Me.PatientNameTextBox.Name = "PatientNameTextBox"
        Me.PatientNameTextBox.Size = New System.Drawing.Size(314, 38)
        Me.PatientNameTextBox.TabIndex = 3
        '
        'Patient_AddressTextBox
        '
        Me.Patient_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "patient_Address", True))
        Me.Patient_AddressTextBox.Location = New System.Drawing.Point(281, 240)
        Me.Patient_AddressTextBox.Name = "Patient_AddressTextBox"
        Me.Patient_AddressTextBox.Size = New System.Drawing.Size(830, 38)
        Me.Patient_AddressTextBox.TabIndex = 5
        '
        'BirthdateDateTimePicker1
        '
        Me.BirthdateDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientBindingSource, "birthdate", True))
        Me.BirthdateDateTimePicker1.Location = New System.Drawing.Point(792, 178)
        Me.BirthdateDateTimePicker1.Name = "BirthdateDateTimePicker1"
        Me.BirthdateDateTimePicker1.Size = New System.Drawing.Size(314, 38)
        Me.BirthdateDateTimePicker1.TabIndex = 7
        '
        'Maritall_statusTextBox
        '
        Me.Maritall_statusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "maritall_status", True))
        Me.Maritall_statusTextBox.Location = New System.Drawing.Point(281, 302)
        Me.Maritall_statusTextBox.Name = "Maritall_statusTextBox"
        Me.Maritall_statusTextBox.Size = New System.Drawing.Size(230, 38)
        Me.Maritall_statusTextBox.TabIndex = 11
        '
        'Patient_telTextBox
        '
        Me.Patient_telTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "patient_tel", True))
        Me.Patient_telTextBox.Location = New System.Drawing.Point(792, 302)
        Me.Patient_telTextBox.Name = "Patient_telTextBox"
        Me.Patient_telTextBox.Size = New System.Drawing.Size(314, 38)
        Me.Patient_telTextBox.TabIndex = 13
        '
        'Date_admissionDateTimePicker
        '
        Me.Date_admissionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientBindingSource, "date_admission", True))
        Me.Date_admissionDateTimePicker.Location = New System.Drawing.Point(281, 363)
        Me.Date_admissionDateTimePicker.Name = "Date_admissionDateTimePicker"
        Me.Date_admissionDateTimePicker.Size = New System.Drawing.Size(230, 38)
        Me.Date_admissionDateTimePicker.TabIndex = 15
        '
        'Next_of_kinNameTextBox
        '
        Me.Next_of_kinNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Next_of_kinName", True))
        Me.Next_of_kinNameTextBox.Location = New System.Drawing.Point(294, 486)
        Me.Next_of_kinNameTextBox.Name = "Next_of_kinNameTextBox"
        Me.Next_of_kinNameTextBox.Size = New System.Drawing.Size(230, 38)
        Me.Next_of_kinNameTextBox.TabIndex = 17
        '
        'RelationshipTextBox
        '
        Me.RelationshipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "relationship", True))
        Me.RelationshipTextBox.Location = New System.Drawing.Point(792, 486)
        Me.RelationshipTextBox.Name = "RelationshipTextBox"
        Me.RelationshipTextBox.Size = New System.Drawing.Size(314, 38)
        Me.RelationshipTextBox.TabIndex = 19
        '
        'Next_of_kin_AddressTextBox
        '
        Me.Next_of_kin_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Next_of_kin_Address", True))
        Me.Next_of_kin_AddressTextBox.Location = New System.Drawing.Point(294, 544)
        Me.Next_of_kin_AddressTextBox.Name = "Next_of_kin_AddressTextBox"
        Me.Next_of_kin_AddressTextBox.Size = New System.Drawing.Size(825, 38)
        Me.Next_of_kin_AddressTextBox.TabIndex = 21
        '
        'Next_of_kin_telTextBox
        '
        Me.Next_of_kin_telTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Next_of_kin_tel", True))
        Me.Next_of_kin_telTextBox.Location = New System.Drawing.Point(294, 608)
        Me.Next_of_kin_telTextBox.Name = "Next_of_kin_telTextBox"
        Me.Next_of_kin_telTextBox.Size = New System.Drawing.Size(230, 38)
        Me.Next_of_kin_telTextBox.TabIndex = 23
        '
        'DoctorNameTextBox
        '
        Me.DoctorNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "doctorName", True))
        Me.DoctorNameTextBox.Location = New System.Drawing.Point(281, 729)
        Me.DoctorNameTextBox.Name = "DoctorNameTextBox"
        Me.DoctorNameTextBox.Size = New System.Drawing.Size(230, 38)
        Me.DoctorNameTextBox.TabIndex = 25
        '
        'ClinicNoTextBox
        '
        Me.ClinicNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "clinicNo", True))
        Me.ClinicNoTextBox.Location = New System.Drawing.Point(740, 729)
        Me.ClinicNoTextBox.Name = "ClinicNoTextBox"
        Me.ClinicNoTextBox.Size = New System.Drawing.Size(314, 38)
        Me.ClinicNoTextBox.TabIndex = 27
        '
        'Doctor_AddressTextBox
        '
        Me.Doctor_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "doctor_Address", True))
        Me.Doctor_AddressTextBox.Location = New System.Drawing.Point(281, 804)
        Me.Doctor_AddressTextBox.Name = "Doctor_AddressTextBox"
        Me.Doctor_AddressTextBox.Size = New System.Drawing.Size(825, 38)
        Me.Doctor_AddressTextBox.TabIndex = 29
        '
        'Doctor_telTextBox
        '
        Me.Doctor_telTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "doctor_tel", True))
        Me.Doctor_telTextBox.Location = New System.Drawing.Point(281, 883)
        Me.Doctor_telTextBox.Name = "Doctor_telTextBox"
        Me.Doctor_telTextBox.Size = New System.Drawing.Size(230, 38)
        Me.Doctor_telTextBox.TabIndex = 31
        '
        'medcinesearch
        '
        Me.medcinesearch.Controls.Add(Me.BindingNavigator2)
        Me.medcinesearch.Controls.Add(Me.btbmedcine)
        Me.medcinesearch.Controls.Add(Me.textdrugID)
        Me.medcinesearch.Controls.Add(DrugIDLabel)
        Me.medcinesearch.Controls.Add(Me.DrugIDTextBox)
        Me.medcinesearch.Controls.Add(StaffIDLabel1)
        Me.medcinesearch.Controls.Add(Me.StaffIDTextBox1)
        Me.medcinesearch.Controls.Add(Drug_nameLabel)
        Me.medcinesearch.Controls.Add(Me.Drug_nameTextBox)
        Me.medcinesearch.Controls.Add(Method_of_administrationLabel)
        Me.medcinesearch.Controls.Add(Me.Method_of_administrationTextBox)
        Me.medcinesearch.Controls.Add(Reorder_levelLabel)
        Me.medcinesearch.Controls.Add(Me.Reorder_levelTextBox)
        Me.medcinesearch.Controls.Add(DosageLabel)
        Me.medcinesearch.Controls.Add(Me.DosageTextBox)
        Me.medcinesearch.Controls.Add(Total_drugLabel)
        Me.medcinesearch.Controls.Add(Me.Total_drugTextBox)
        Me.medcinesearch.Controls.Add(Cost_per_unitLabel)
        Me.medcinesearch.Controls.Add(Me.Cost_per_unitTextBox)
        Me.medcinesearch.Controls.Add(Quantity_in_stockLabel)
        Me.medcinesearch.Controls.Add(Me.Quantity_in_stockTextBox)
        Me.medcinesearch.Controls.Add(DescriptionsLabel)
        Me.medcinesearch.Controls.Add(Me.DescriptionsTextBox)
        Me.medcinesearch.Location = New System.Drawing.Point(4, 40)
        Me.medcinesearch.Name = "medcinesearch"
        Me.medcinesearch.Size = New System.Drawing.Size(1415, 1007)
        Me.medcinesearch.TabIndex = 2
        Me.medcinesearch.Text = "Medicine"
        Me.medcinesearch.UseVisualStyleBackColor = True
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.ToolStripButton2
        Me.BindingNavigator2.BindingSource = Me.MedicineBindingSource
        Me.BindingNavigator2.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator2.DeleteItem = Me.ToolStripButton3
        Me.BindingNavigator2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripSeparator3, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton8})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.ToolStripButton4
        Me.BindingNavigator2.MoveLastItem = Me.ToolStripButton7
        Me.BindingNavigator2.MoveNextItem = Me.ToolStripButton6
        Me.BindingNavigator2.MovePreviousItem = Me.ToolStripButton5
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator2.Size = New System.Drawing.Size(1415, 27)
        Me.BindingNavigator2.TabIndex = 47
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton2.Text = "Add new"
        '
        'MedicineBindingSource
        '
        Me.MedicineBindingSource.DataMember = "medicine"
        Me.MedicineBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(45, 24)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton3.Text = "Delete"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton4.Text = "Move first"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton5.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Leelawadee UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 27)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton6.Text = "Move next"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton7.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton7.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton8.Text = "Save Data"
        '
        'btbmedcine
        '
        Me.btbmedcine.BackColor = System.Drawing.Color.LightGray
        Me.btbmedcine.ForeColor = System.Drawing.Color.Black
        Me.btbmedcine.Location = New System.Drawing.Point(1074, 39)
        Me.btbmedcine.Name = "btbmedcine"
        Me.btbmedcine.Size = New System.Drawing.Size(114, 38)
        Me.btbmedcine.TabIndex = 45
        Me.btbmedcine.Text = "Search"
        Me.btbmedcine.UseVisualStyleBackColor = False
        '
        'textdrugID
        '
        Me.textdrugID.BackColor = System.Drawing.SystemColors.Menu
        Me.textdrugID.Location = New System.Drawing.Point(623, 39)
        Me.textdrugID.Name = "textdrugID"
        Me.textdrugID.Size = New System.Drawing.Size(436, 38)
        Me.textdrugID.TabIndex = 44
        '
        'DrugIDTextBox
        '
        Me.DrugIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "drugID", True))
        Me.DrugIDTextBox.Location = New System.Drawing.Point(278, 195)
        Me.DrugIDTextBox.Name = "DrugIDTextBox"
        Me.DrugIDTextBox.Size = New System.Drawing.Size(270, 38)
        Me.DrugIDTextBox.TabIndex = 1
        '
        'StaffIDTextBox1
        '
        Me.StaffIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "staffID", True))
        Me.StaffIDTextBox1.Location = New System.Drawing.Point(278, 132)
        Me.StaffIDTextBox1.Name = "StaffIDTextBox1"
        Me.StaffIDTextBox1.Size = New System.Drawing.Size(270, 38)
        Me.StaffIDTextBox1.TabIndex = 3
        '
        'Drug_nameTextBox
        '
        Me.Drug_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "drug_name", True))
        Me.Drug_nameTextBox.Location = New System.Drawing.Point(852, 198)
        Me.Drug_nameTextBox.Name = "Drug_nameTextBox"
        Me.Drug_nameTextBox.Size = New System.Drawing.Size(267, 38)
        Me.Drug_nameTextBox.TabIndex = 5
        '
        'Method_of_administrationTextBox
        '
        Me.Method_of_administrationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "method_of_administration", True))
        Me.Method_of_administrationTextBox.Location = New System.Drawing.Point(278, 253)
        Me.Method_of_administrationTextBox.Name = "Method_of_administrationTextBox"
        Me.Method_of_administrationTextBox.Size = New System.Drawing.Size(270, 38)
        Me.Method_of_administrationTextBox.TabIndex = 7
        '
        'Reorder_levelTextBox
        '
        Me.Reorder_levelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "reorder_level", True))
        Me.Reorder_levelTextBox.Location = New System.Drawing.Point(852, 265)
        Me.Reorder_levelTextBox.Name = "Reorder_levelTextBox"
        Me.Reorder_levelTextBox.Size = New System.Drawing.Size(267, 38)
        Me.Reorder_levelTextBox.TabIndex = 9
        '
        'DosageTextBox
        '
        Me.DosageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "dosage", True))
        Me.DosageTextBox.Location = New System.Drawing.Point(278, 317)
        Me.DosageTextBox.Name = "DosageTextBox"
        Me.DosageTextBox.Size = New System.Drawing.Size(270, 38)
        Me.DosageTextBox.TabIndex = 11
        '
        'Total_drugTextBox
        '
        Me.Total_drugTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "total_drug", True))
        Me.Total_drugTextBox.Location = New System.Drawing.Point(852, 320)
        Me.Total_drugTextBox.Name = "Total_drugTextBox"
        Me.Total_drugTextBox.Size = New System.Drawing.Size(267, 38)
        Me.Total_drugTextBox.TabIndex = 13
        '
        'Cost_per_unitTextBox
        '
        Me.Cost_per_unitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "cost_per_unit", True))
        Me.Cost_per_unitTextBox.Location = New System.Drawing.Point(278, 379)
        Me.Cost_per_unitTextBox.Name = "Cost_per_unitTextBox"
        Me.Cost_per_unitTextBox.Size = New System.Drawing.Size(270, 38)
        Me.Cost_per_unitTextBox.TabIndex = 15
        '
        'Quantity_in_stockTextBox
        '
        Me.Quantity_in_stockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "quantity_in_stock", True))
        Me.Quantity_in_stockTextBox.Location = New System.Drawing.Point(852, 382)
        Me.Quantity_in_stockTextBox.Name = "Quantity_in_stockTextBox"
        Me.Quantity_in_stockTextBox.Size = New System.Drawing.Size(267, 38)
        Me.Quantity_in_stockTextBox.TabIndex = 17
        '
        'DescriptionsTextBox
        '
        Me.DescriptionsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "descriptions", True))
        Me.DescriptionsTextBox.Location = New System.Drawing.Point(278, 457)
        Me.DescriptionsTextBox.Name = "DescriptionsTextBox"
        Me.DescriptionsTextBox.Size = New System.Drawing.Size(841, 38)
        Me.DescriptionsTextBox.TabIndex = 19
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.BindingNavigator3)
        Me.TabPage4.Controls.Add(Me.wardsearch)
        Me.TabPage4.Controls.Add(Me.textwardID)
        Me.TabPage4.Controls.Add(WardIDLabel1)
        Me.TabPage4.Controls.Add(Me.WardIDTextBox1)
        Me.TabPage4.Controls.Add(WardnameLabel)
        Me.TabPage4.Controls.Add(Me.WardnameTextBox)
        Me.TabPage4.Controls.Add(Tel_extnLabel)
        Me.TabPage4.Controls.Add(RoomIDLabel)
        Me.TabPage4.Controls.Add(Me.RoomIDTextBox)
        Me.TabPage4.Controls.Add(Total_bedLabel)
        Me.TabPage4.Controls.Add(Me.Total_bedTextBox)
        Me.TabPage4.Controls.Add(LocationLabel)
        Me.TabPage4.Controls.Add(Me.LocationTextBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 40)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1415, 1007)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Ward"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Me.ToolStripButton9
        Me.BindingNavigator3.BindingSource = Me.WardsBindingSource
        Me.BindingNavigator3.CountItem = Me.ToolStripLabel2
        Me.BindingNavigator3.DeleteItem = Me.ToolStripButton10
        Me.BindingNavigator3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton11, Me.ToolStripButton12, Me.ToolStripSeparator4, Me.ToolStripTextBox2, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton13, Me.ToolStripButton14, Me.ToolStripSeparator6, Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripButton15})
        Me.BindingNavigator3.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator3.MoveFirstItem = Me.ToolStripButton11
        Me.BindingNavigator3.MoveLastItem = Me.ToolStripButton14
        Me.BindingNavigator3.MoveNextItem = Me.ToolStripButton13
        Me.BindingNavigator3.MovePreviousItem = Me.ToolStripButton12
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.ToolStripTextBox2
        Me.BindingNavigator3.Size = New System.Drawing.Size(1415, 27)
        Me.BindingNavigator3.TabIndex = 47
        Me.BindingNavigator3.Text = "BindingNavigator3"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton9.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton9.Text = "Add new"
        '
        'WardsBindingSource
        '
        Me.WardsBindingSource.DataMember = "Wards"
        Me.WardsBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(45, 24)
        Me.ToolStripLabel2.Text = "of {0}"
        Me.ToolStripLabel2.ToolTipText = "Total number of items"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton10.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton10.Text = "Delete"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton11.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton11.Text = "Move first"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton12.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton12.Text = "Move previous"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.AccessibleName = "Position"
        Me.ToolStripTextBox2.AutoSize = False
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Leelawadee UI", 9.0!)
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(50, 27)
        Me.ToolStripTextBox2.Text = "0"
        Me.ToolStripTextBox2.ToolTipText = "Current position"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton13.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton13.Text = "Move next"
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton14.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton14.Text = "Move last"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), System.Drawing.Image)
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton15.Text = "Save Data"
        '
        'wardsearch
        '
        Me.wardsearch.BackColor = System.Drawing.Color.LightGray
        Me.wardsearch.ForeColor = System.Drawing.Color.Black
        Me.wardsearch.Location = New System.Drawing.Point(1042, 39)
        Me.wardsearch.Name = "wardsearch"
        Me.wardsearch.Size = New System.Drawing.Size(114, 38)
        Me.wardsearch.TabIndex = 45
        Me.wardsearch.Text = "Search"
        Me.wardsearch.UseVisualStyleBackColor = False
        '
        'textwardID
        '
        Me.textwardID.BackColor = System.Drawing.SystemColors.Menu
        Me.textwardID.Location = New System.Drawing.Point(591, 39)
        Me.textwardID.Name = "textwardID"
        Me.textwardID.Size = New System.Drawing.Size(436, 38)
        Me.textwardID.TabIndex = 44
        '
        'WardIDTextBox1
        '
        Me.WardIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "wardID", True))
        Me.WardIDTextBox1.Location = New System.Drawing.Point(241, 117)
        Me.WardIDTextBox1.Name = "WardIDTextBox1"
        Me.WardIDTextBox1.Size = New System.Drawing.Size(226, 38)
        Me.WardIDTextBox1.TabIndex = 1
        '
        'WardnameTextBox
        '
        Me.WardnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "wardname", True))
        Me.WardnameTextBox.Location = New System.Drawing.Point(686, 120)
        Me.WardnameTextBox.Name = "WardnameTextBox"
        Me.WardnameTextBox.Size = New System.Drawing.Size(237, 38)
        Me.WardnameTextBox.TabIndex = 3
        '
        'RoomIDTextBox
        '
        Me.RoomIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "room_ID", True))
        Me.RoomIDTextBox.Location = New System.Drawing.Point(241, 200)
        Me.RoomIDTextBox.Name = "RoomIDTextBox"
        Me.RoomIDTextBox.Size = New System.Drawing.Size(226, 38)
        Me.RoomIDTextBox.TabIndex = 7
        '
        'Total_bedTextBox
        '
        Me.Total_bedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "total_bed", True))
        Me.Total_bedTextBox.Location = New System.Drawing.Point(686, 200)
        Me.Total_bedTextBox.Name = "Total_bedTextBox"
        Me.Total_bedTextBox.Size = New System.Drawing.Size(237, 38)
        Me.Total_bedTextBox.TabIndex = 9
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(241, 282)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(226, 38)
        Me.LocationTextBox.TabIndex = 11
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Button6)
        Me.TabPage5.Controls.Add(Me.Button5)
        Me.TabPage5.Controls.Add(Me.Button4)
        Me.TabPage5.Controls.Add(Me.Button3)
        Me.TabPage5.Controls.Add(Me.Button2)
        Me.TabPage5.Controls.Add(Me.Button1)
        Me.TabPage5.Controls.Add(Me.TextBox1)
        Me.TabPage5.Controls.Add(Me.Label2)
        Me.TabPage5.Controls.Add(Me.Label1)
        Me.TabPage5.Controls.Add(Me.Amitted_ward)
        Me.TabPage5.Controls.Add(Me.Admitted_wardDataGridView)
        Me.TabPage5.Controls.Add(Me.BindingNavigator4)
        Me.TabPage5.Controls.Add(TreatmentIDLabel)
        Me.TabPage5.Controls.Add(Me.TreatmentIDTextBox)
        Me.TabPage5.Controls.Add(PatientIDLabel1)
        Me.TabPage5.Controls.Add(Me.PatientIDTextBox1)
        Me.TabPage5.Controls.Add(StaffIDLabel2)
        Me.TabPage5.Controls.Add(Me.StaffIDTextBox2)
        Me.TabPage5.Controls.Add(DrugIDLabel1)
        Me.TabPage5.Controls.Add(Me.DrugIDTextBox1)
        Me.TabPage5.Controls.Add(TotalLabel)
        Me.TabPage5.Controls.Add(Me.TotalTextBox)
        Me.TabPage5.Controls.Add(Date_timeLabel)
        Me.TabPage5.Controls.Add(Me.Date_timeDateTimePicker)
        Me.TabPage5.Location = New System.Drawing.Point(4, 40)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1415, 1007)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Treatment"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(526, 404)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(67, 44)
        Me.Button6.TabIndex = 57
        Me.Button6.Text = "บันทึก"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(445, 403)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 45)
        Me.Button5.TabIndex = 56
        Me.Button5.Text = "เพิ่ม "
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(275, 403)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 45)
        Me.Button4.TabIndex = 55
        Me.Button4.Text = "ลบ"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(359, 403)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 45)
        Me.Button3.TabIndex = 54
        Me.Button3.Text = "แก้ไข"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(175, 403)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 45)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(80, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 45)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(218, 256)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(344, 38)
        Me.TextBox1.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 31)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "drug name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 31)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Label1"
        '
        'Amitted_ward
        '
        Me.Amitted_ward.AutoSize = True
        Me.Amitted_ward.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Amitted_ward.Location = New System.Drawing.Point(21, 531)
        Me.Amitted_ward.Name = "Amitted_ward"
        Me.Amitted_ward.Size = New System.Drawing.Size(148, 40)
        Me.Amitted_ward.TabIndex = 48
        Me.Amitted_ward.Text = "Amitted ward"
        '
        'Admitted_wardDataGridView
        '
        Me.Admitted_wardDataGridView.AutoGenerateColumns = False
        Me.Admitted_wardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Admitted_wardDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Admitted_wardDataGridView.DataSource = Me.Admitted_wardBindingSource
        Me.Admitted_wardDataGridView.Location = New System.Drawing.Point(28, 574)
        Me.Admitted_wardDataGridView.Name = "Admitted_wardDataGridView"
        Me.Admitted_wardDataGridView.RowHeadersWidth = 51
        Me.Admitted_wardDataGridView.RowTemplate.Height = 24
        Me.Admitted_wardDataGridView.Size = New System.Drawing.Size(1281, 220)
        Me.Admitted_wardDataGridView.TabIndex = 47
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "wardID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "wardID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "patientID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "patientID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "patientName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "patientName"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "roomID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "roomID"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "bedID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "bedID"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "staffID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "staffID"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "staffName"
        Me.DataGridViewTextBoxColumn7.HeaderText = "staffName"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "drugID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "drugID"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "date_admission"
        Me.DataGridViewTextBoxColumn9.HeaderText = "date_admission"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "date_leave"
        Me.DataGridViewTextBoxColumn10.HeaderText = "date_leave"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "date_Appointment"
        Me.DataGridViewTextBoxColumn11.HeaderText = "date_Appointment"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'Admitted_wardBindingSource
        '
        Me.Admitted_wardBindingSource.DataMember = "admitted_ward"
        Me.Admitted_wardBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'BindingNavigator4
        '
        Me.BindingNavigator4.AddNewItem = Me.ToolStripButton16
        Me.BindingNavigator4.BindingSource = Me.TreatmentBindingSource
        Me.BindingNavigator4.CountItem = Me.ToolStripLabel3
        Me.BindingNavigator4.DeleteItem = Me.ToolStripButton17
        Me.BindingNavigator4.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton18, Me.ToolStripButton19, Me.ToolStripSeparator7, Me.ToolStripTextBox3, Me.ToolStripLabel3, Me.ToolStripSeparator8, Me.ToolStripButton20, Me.ToolStripButton21, Me.ToolStripSeparator9, Me.ToolStripButton16, Me.ToolStripButton17, Me.ToolStripButton22})
        Me.BindingNavigator4.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator4.MoveFirstItem = Me.ToolStripButton18
        Me.BindingNavigator4.MoveLastItem = Me.ToolStripButton21
        Me.BindingNavigator4.MoveNextItem = Me.ToolStripButton20
        Me.BindingNavigator4.MovePreviousItem = Me.ToolStripButton19
        Me.BindingNavigator4.Name = "BindingNavigator4"
        Me.BindingNavigator4.PositionItem = Me.ToolStripTextBox3
        Me.BindingNavigator4.Size = New System.Drawing.Size(1415, 27)
        Me.BindingNavigator4.TabIndex = 47
        Me.BindingNavigator4.Text = "BindingNavigator4"
        '
        'ToolStripButton16
        '
        Me.ToolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton16.Image = CType(resources.GetObject("ToolStripButton16.Image"), System.Drawing.Image)
        Me.ToolStripButton16.Name = "ToolStripButton16"
        Me.ToolStripButton16.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton16.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton16.Text = "Add new"
        '
        'TreatmentBindingSource
        '
        Me.TreatmentBindingSource.DataMember = "Treatment"
        Me.TreatmentBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(45, 24)
        Me.ToolStripLabel3.Text = "of {0}"
        Me.ToolStripLabel3.ToolTipText = "Total number of items"
        '
        'ToolStripButton17
        '
        Me.ToolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton17.Image = CType(resources.GetObject("ToolStripButton17.Image"), System.Drawing.Image)
        Me.ToolStripButton17.Name = "ToolStripButton17"
        Me.ToolStripButton17.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton17.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton17.Text = "Delete"
        '
        'ToolStripButton18
        '
        Me.ToolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton18.Image = CType(resources.GetObject("ToolStripButton18.Image"), System.Drawing.Image)
        Me.ToolStripButton18.Name = "ToolStripButton18"
        Me.ToolStripButton18.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton18.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton18.Text = "Move first"
        '
        'ToolStripButton19
        '
        Me.ToolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton19.Image = CType(resources.GetObject("ToolStripButton19.Image"), System.Drawing.Image)
        Me.ToolStripButton19.Name = "ToolStripButton19"
        Me.ToolStripButton19.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton19.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton19.Text = "Move previous"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.AccessibleName = "Position"
        Me.ToolStripTextBox3.AutoSize = False
        Me.ToolStripTextBox3.Font = New System.Drawing.Font("Leelawadee UI", 9.0!)
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(50, 27)
        Me.ToolStripTextBox3.Text = "0"
        Me.ToolStripTextBox3.ToolTipText = "Current position"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton20
        '
        Me.ToolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton20.Image = CType(resources.GetObject("ToolStripButton20.Image"), System.Drawing.Image)
        Me.ToolStripButton20.Name = "ToolStripButton20"
        Me.ToolStripButton20.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton20.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton20.Text = "Move next"
        '
        'ToolStripButton21
        '
        Me.ToolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton21.Image = CType(resources.GetObject("ToolStripButton21.Image"), System.Drawing.Image)
        Me.ToolStripButton21.Name = "ToolStripButton21"
        Me.ToolStripButton21.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton21.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton21.Text = "Move last"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton22
        '
        Me.ToolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton22.Image = CType(resources.GetObject("ToolStripButton22.Image"), System.Drawing.Image)
        Me.ToolStripButton22.Name = "ToolStripButton22"
        Me.ToolStripButton22.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton22.Text = "Save Data"
        '
        'TreatmentIDTextBox
        '
        Me.TreatmentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TreatmentBindingSource, "treatmentID", True))
        Me.TreatmentIDTextBox.Location = New System.Drawing.Point(218, 75)
        Me.TreatmentIDTextBox.Name = "TreatmentIDTextBox"
        Me.TreatmentIDTextBox.Size = New System.Drawing.Size(344, 38)
        Me.TreatmentIDTextBox.TabIndex = 1
        '
        'PatientIDTextBox1
        '
        Me.PatientIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TreatmentBindingSource, "patientID", True))
        Me.PatientIDTextBox1.Location = New System.Drawing.Point(218, 119)
        Me.PatientIDTextBox1.Name = "PatientIDTextBox1"
        Me.PatientIDTextBox1.Size = New System.Drawing.Size(344, 38)
        Me.PatientIDTextBox1.TabIndex = 3
        '
        'StaffIDTextBox2
        '
        Me.StaffIDTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TreatmentBindingSource, "staffID", True))
        Me.StaffIDTextBox2.Location = New System.Drawing.Point(218, 163)
        Me.StaffIDTextBox2.Name = "StaffIDTextBox2"
        Me.StaffIDTextBox2.Size = New System.Drawing.Size(344, 38)
        Me.StaffIDTextBox2.TabIndex = 5
        '
        'DrugIDTextBox1
        '
        Me.DrugIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TreatmentBindingSource, "drugID", True))
        Me.DrugIDTextBox1.Location = New System.Drawing.Point(218, 207)
        Me.DrugIDTextBox1.Name = "DrugIDTextBox1"
        Me.DrugIDTextBox1.Size = New System.Drawing.Size(344, 38)
        Me.DrugIDTextBox1.TabIndex = 7
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TreatmentBindingSource, "total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(218, 306)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(344, 38)
        Me.TotalTextBox.TabIndex = 9
        '
        'Date_timeDateTimePicker
        '
        Me.Date_timeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TreatmentBindingSource, "date_time", True))
        Me.Date_timeDateTimePicker.Location = New System.Drawing.Point(218, 350)
        Me.Date_timeDateTimePicker.Name = "Date_timeDateTimePicker"
        Me.Date_timeDateTimePicker.Size = New System.Drawing.Size(344, 38)
        Me.Date_timeDateTimePicker.TabIndex = 11
        '
        'PatientBindingSource1
        '
        Me.PatientBindingSource1.DataMember = "patient"
        Me.PatientBindingSource1.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.admitted_wardTableAdapter = Nothing
        Me.TableAdapterManager.apply_wardsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.medicineTableAdapter = Nothing
        Me.TableAdapterManager.patientTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.TreatmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = project_g11.wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        '
        'PatientTableAdapter
        '
        Me.PatientTableAdapter.ClearBeforeFill = True
        '
        'MedicineTableAdapter
        '
        Me.MedicineTableAdapter.ClearBeforeFill = True
        '
        'WardsTableAdapter
        '
        Me.WardsTableAdapter.ClearBeforeFill = True
        '
        'TreatmentTableAdapter
        '
        Me.TreatmentTableAdapter.ClearBeforeFill = True
        '
        'Admitted_wardTableAdapter
        '
        Me.Admitted_wardTableAdapter.ClearBeforeFill = True
        '
        'PatientBindingSource2
        '
        Me.PatientBindingSource2.DataMember = "patient"
        Me.PatientBindingSource2.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'StaffBindingSource1
        '
        Me.StaffBindingSource1.DataMember = "staff"
        Me.StaffBindingSource1.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1423, 1051)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormMain"
        Me.Text = "FormMain"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StaffBindingNavigator.ResumeLayout(False)
        Me.StaffBindingNavigator.PerformLayout()
        Me.patient.ResumeLayout(False)
        Me.patient.PerformLayout()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.medcinesearch.ResumeLayout(False)
        Me.medcinesearch.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.Admitted_wardDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Admitted_wardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator4.ResumeLayout(False)
        Me.BindingNavigator4.PerformLayout()
        CType(Me.TreatmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents patient As TabPage
    Friend WithEvents medcinesearch As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Wellmeadows_hospitalDataSet As wellmeadows_hospitalDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As wellmeadows_hospitalDataSetTableAdapters.staffTableAdapter
    Friend WithEvents TableAdapterManager As wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents StaffBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents StaffIDTextBox As TextBox
    Friend WithEvents StaffNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents BirthdateDateTimePicker As DateTimePicker
    Friend WithEvents TelTextBox As TextBox
    Friend WithEvents NINTextBox As TextBox
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents WardIDTextBox As TextBox
    Friend WithEvents SalaryTextBox As TextBox
    Friend WithEvents HoursTextBox As TextBox
    Friend WithEvents TypeTextBox As TextBox
    Friend WithEvents InstitutionTextBox As TextBox
    Friend WithEvents Graduation_DateDateTimePicker As DateTimePicker
    Friend WithEvents OrganizationTextBox As TextBox
    Friend WithEvents Position_pastTextBox As TextBox
    Friend WithEvents Start_dateDateTimePicker As DateTimePicker
    Friend WithEvents Finish_dateDateTimePicker As DateTimePicker
    Friend WithEvents Qualifications As Label
    Friend WithEvents Experience_work As Label
    Friend WithEvents staffsearch As Button
    Friend WithEvents textstaffName As TextBox
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PatientTableAdapter As wellmeadows_hospitalDataSetTableAdapters.patientTableAdapter
    Friend WithEvents PatientIDTextBox As TextBox
    Friend WithEvents PatientNameTextBox As TextBox
    Friend WithEvents Patient_AddressTextBox As TextBox
    Friend WithEvents BirthdateDateTimePicker1 As DateTimePicker
    Friend WithEvents Maritall_statusTextBox As TextBox
    Friend WithEvents Patient_telTextBox As TextBox
    Friend WithEvents Date_admissionDateTimePicker As DateTimePicker
    Friend WithEvents Next_of_kinNameTextBox As TextBox
    Friend WithEvents RelationshipTextBox As TextBox
    Friend WithEvents Next_of_kin_AddressTextBox As TextBox
    Friend WithEvents Next_of_kin_telTextBox As TextBox
    Friend WithEvents DoctorNameTextBox As TextBox
    Friend WithEvents ClinicNoTextBox As TextBox
    Friend WithEvents Doctor_AddressTextBox As TextBox
    Friend WithEvents Doctor_telTextBox As TextBox
    Friend WithEvents MedicineBindingSource As BindingSource
    Friend WithEvents MedicineTableAdapter As wellmeadows_hospitalDataSetTableAdapters.medicineTableAdapter
    Friend WithEvents DrugIDTextBox As TextBox
    Friend WithEvents StaffIDTextBox1 As TextBox
    Friend WithEvents Drug_nameTextBox As TextBox
    Friend WithEvents Method_of_administrationTextBox As TextBox
    Friend WithEvents Reorder_levelTextBox As TextBox
    Friend WithEvents DosageTextBox As TextBox
    Friend WithEvents Total_drugTextBox As TextBox
    Friend WithEvents Cost_per_unitTextBox As TextBox
    Friend WithEvents Quantity_in_stockTextBox As TextBox
    Friend WithEvents DescriptionsTextBox As TextBox
    Friend WithEvents WardsBindingSource As BindingSource
    Friend WithEvents WardsTableAdapter As wellmeadows_hospitalDataSetTableAdapters.WardsTableAdapter
    Friend WithEvents WardIDTextBox1 As TextBox
    Friend WithEvents WardnameTextBox As TextBox
    Friend WithEvents RoomIDTextBox As TextBox
    Friend WithEvents Total_bedTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents TreatmentBindingSource As BindingSource
    Friend WithEvents TreatmentTableAdapter As wellmeadows_hospitalDataSetTableAdapters.TreatmentTableAdapter
    Friend WithEvents patientsearch As Button
    Friend WithEvents textpatientName As TextBox
    Friend WithEvents btbmedcine As Button
    Friend WithEvents textdrugID As TextBox
    Friend WithEvents wardsearch As Button
    Friend WithEvents textwardID As TextBox
    Friend WithEvents TreatmentIDTextBox As TextBox
    Friend WithEvents PatientIDTextBox1 As TextBox
    Friend WithEvents StaffIDTextBox2 As TextBox
    Friend WithEvents DrugIDTextBox1 As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents Date_timeDateTimePicker As DateTimePicker
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents BindingNavigator3 As BindingNavigator
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripButton10 As ToolStripButton
    Friend WithEvents ToolStripButton11 As ToolStripButton
    Friend WithEvents ToolStripButton12 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton13 As ToolStripButton
    Friend WithEvents ToolStripButton14 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButton15 As ToolStripButton
    Friend WithEvents BindingNavigator4 As BindingNavigator
    Friend WithEvents ToolStripButton16 As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripButton17 As ToolStripButton
    Friend WithEvents ToolStripButton18 As ToolStripButton
    Friend WithEvents ToolStripButton19 As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox3 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripButton20 As ToolStripButton
    Friend WithEvents ToolStripButton21 As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ToolStripButton22 As ToolStripButton
    Friend WithEvents Location_Doctor_Details As Label
    Friend WithEvents Next_of_kin As Label
    Friend WithEvents Admitted_wardBindingSource As BindingSource
    Friend WithEvents Admitted_wardTableAdapter As wellmeadows_hospitalDataSetTableAdapters.admitted_wardTableAdapter
    Friend WithEvents Amitted_ward As Label
    Friend WithEvents Admitted_wardDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents PatientSex As ComboBox
    Friend WithEvents PatientBindingSource1 As BindingSource
    Friend WithEvents PatientBindingSource2 As BindingSource
    Friend WithEvents StaffBindingSource1 As BindingSource
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents SexComboBox As ComboBox
    Friend WithEvents PaidComboBox As ComboBox
    Friend WithEvents PositiontpyeComboBox As ComboBox
End Class
