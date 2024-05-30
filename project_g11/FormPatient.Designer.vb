<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPatient
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
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim PatientNameLabel As System.Windows.Forms.Label
        Dim Patient_AddressLabel As System.Windows.Forms.Label
        Dim BirthdateLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim Maritall_statusLabel As System.Windows.Forms.Label
        Dim Patient_telLabel As System.Windows.Forms.Label
        Dim Date_admissionLabel As System.Windows.Forms.Label
        Dim Next_of_kinNameLabel1 As System.Windows.Forms.Label
        Dim RelationshipLabel1 As System.Windows.Forms.Label
        Dim Next_of_kin_AddressLabel1 As System.Windows.Forms.Label
        Dim Next_of_kin_telLabel1 As System.Windows.Forms.Label
        Dim DoctorNameLabel1 As System.Windows.Forms.Label
        Dim ClinicNoLabel1 As System.Windows.Forms.Label
        Dim Doctor_AddressLabel1 As System.Windows.Forms.Label
        Dim Doctor_telLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPatient))
        Me.patientsearch = New System.Windows.Forms.Button()
        Me.Location_Doctor_Details = New System.Windows.Forms.Label()
        Me.Next_of_kin = New System.Windows.Forms.Label()
        Me.Wellmeadows_hospitalDataSet = New project_g11.wellmeadows_hospitalDataSet()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.patientTableAdapter()
        Me.TableAdapterManager = New project_g11.wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager()
        Me.PatientBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PatientBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.PatientNameTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.BirthdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Patient_telTextBox = New System.Windows.Forms.TextBox()
        Me.Date_admissionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Next_of_kinNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.RelationshipTextBox1 = New System.Windows.Forms.TextBox()
        Me.Next_of_kin_AddressTextBox1 = New System.Windows.Forms.TextBox()
        Me.Next_of_kin_telTextBox1 = New System.Windows.Forms.TextBox()
        Me.DoctorNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.ClinicNoTextBox1 = New System.Windows.Forms.TextBox()
        Me.Doctor_AddressTextBox1 = New System.Windows.Forms.TextBox()
        Me.Doctor_telTextBox1 = New System.Windows.Forms.TextBox()
        Me.SexText = New System.Windows.Forms.ComboBox()
        Me.Panelcoler5 = New System.Windows.Forms.Panel()
        Me.textBoxsearch = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBoxstatus = New System.Windows.Forms.ComboBox()
        PatientIDLabel = New System.Windows.Forms.Label()
        PatientNameLabel = New System.Windows.Forms.Label()
        Patient_AddressLabel = New System.Windows.Forms.Label()
        BirthdateLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        Maritall_statusLabel = New System.Windows.Forms.Label()
        Patient_telLabel = New System.Windows.Forms.Label()
        Date_admissionLabel = New System.Windows.Forms.Label()
        Next_of_kinNameLabel1 = New System.Windows.Forms.Label()
        RelationshipLabel1 = New System.Windows.Forms.Label()
        Next_of_kin_AddressLabel1 = New System.Windows.Forms.Label()
        Next_of_kin_telLabel1 = New System.Windows.Forms.Label()
        DoctorNameLabel1 = New System.Windows.Forms.Label()
        ClinicNoLabel1 = New System.Windows.Forms.Label()
        Doctor_AddressLabel1 = New System.Windows.Forms.Label()
        Doctor_telLabel1 = New System.Windows.Forms.Label()
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientBindingNavigator.SuspendLayout()
        Me.Panelcoler5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.BackColor = System.Drawing.Color.Transparent
        PatientIDLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        PatientIDLabel.Location = New System.Drawing.Point(139, 167)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(90, 31)
        PatientIDLabel.TabIndex = 85
        PatientIDLabel.Text = "Patient ID:"
        '
        'PatientNameLabel
        '
        PatientNameLabel.AutoSize = True
        PatientNameLabel.BackColor = System.Drawing.Color.Transparent
        PatientNameLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        PatientNameLabel.Location = New System.Drawing.Point(564, 167)
        PatientNameLabel.Name = "PatientNameLabel"
        PatientNameLabel.Size = New System.Drawing.Size(118, 31)
        PatientNameLabel.TabIndex = 87
        PatientNameLabel.Text = "Patient Name:"
        '
        'Patient_AddressLabel
        '
        Patient_AddressLabel.AutoSize = True
        Patient_AddressLabel.BackColor = System.Drawing.Color.Transparent
        Patient_AddressLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Patient_AddressLabel.Location = New System.Drawing.Point(95, 208)
        Patient_AddressLabel.Name = "Patient_AddressLabel"
        Patient_AddressLabel.Size = New System.Drawing.Size(134, 31)
        Patient_AddressLabel.TabIndex = 89
        Patient_AddressLabel.Text = "Patient Address:"
        '
        'BirthdateLabel
        '
        BirthdateLabel.AutoSize = True
        BirthdateLabel.BackColor = System.Drawing.Color.Transparent
        BirthdateLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        BirthdateLabel.Location = New System.Drawing.Point(564, 217)
        BirthdateLabel.Name = "BirthdateLabel"
        BirthdateLabel.Size = New System.Drawing.Size(92, 31)
        BirthdateLabel.TabIndex = 91
        BirthdateLabel.Text = "Birth Date:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.BackColor = System.Drawing.Color.Transparent
        SexLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        SexLabel.Location = New System.Drawing.Point(185, 256)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(43, 31)
        SexLabel.TabIndex = 93
        SexLabel.Text = "Sex:"
        '
        'Maritall_statusLabel
        '
        Maritall_statusLabel.AutoSize = True
        Maritall_statusLabel.BackColor = System.Drawing.Color.Transparent
        Maritall_statusLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Maritall_statusLabel.Location = New System.Drawing.Point(564, 256)
        Maritall_statusLabel.Name = "Maritall_statusLabel"
        Maritall_statusLabel.Size = New System.Drawing.Size(123, 31)
        Maritall_statusLabel.TabIndex = 95
        Maritall_statusLabel.Text = "Maritall Status:"
        '
        'Patient_telLabel
        '
        Patient_telLabel.AutoSize = True
        Patient_telLabel.BackColor = System.Drawing.Color.Transparent
        Patient_telLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Patient_telLabel.Location = New System.Drawing.Point(131, 300)
        Patient_telLabel.Name = "Patient_telLabel"
        Patient_telLabel.Size = New System.Drawing.Size(98, 31)
        Patient_telLabel.TabIndex = 97
        Patient_telLabel.Text = "Patient Tel:"
        '
        'Date_admissionLabel
        '
        Date_admissionLabel.AutoSize = True
        Date_admissionLabel.BackColor = System.Drawing.Color.Transparent
        Date_admissionLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Date_admissionLabel.Location = New System.Drawing.Point(564, 300)
        Date_admissionLabel.Name = "Date_admissionLabel"
        Date_admissionLabel.Size = New System.Drawing.Size(133, 31)
        Date_admissionLabel.TabIndex = 99
        Date_admissionLabel.Text = "Date Admission:"
        '
        'Next_of_kinNameLabel1
        '
        Next_of_kinNameLabel1.AutoSize = True
        Next_of_kinNameLabel1.BackColor = System.Drawing.Color.Transparent
        Next_of_kinNameLabel1.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Next_of_kinNameLabel1.Location = New System.Drawing.Point(80, 542)
        Next_of_kinNameLabel1.Name = "Next_of_kinNameLabel1"
        Next_of_kinNameLabel1.Size = New System.Drawing.Size(148, 31)
        Next_of_kinNameLabel1.TabIndex = 101
        Next_of_kinNameLabel1.Text = "Next of Kin Name:"
        '
        'RelationshipLabel1
        '
        RelationshipLabel1.AutoSize = True
        RelationshipLabel1.BackColor = System.Drawing.Color.Transparent
        RelationshipLabel1.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        RelationshipLabel1.Location = New System.Drawing.Point(80, 586)
        RelationshipLabel1.Name = "RelationshipLabel1"
        RelationshipLabel1.Size = New System.Drawing.Size(115, 31)
        RelationshipLabel1.TabIndex = 103
        RelationshipLabel1.Text = "Relation Ship:"
        '
        'Next_of_kin_AddressLabel1
        '
        Next_of_kin_AddressLabel1.AutoSize = True
        Next_of_kin_AddressLabel1.BackColor = System.Drawing.Color.Transparent
        Next_of_kin_AddressLabel1.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Next_of_kin_AddressLabel1.Location = New System.Drawing.Point(80, 631)
        Next_of_kin_AddressLabel1.Name = "Next_of_kin_AddressLabel1"
        Next_of_kin_AddressLabel1.Size = New System.Drawing.Size(164, 31)
        Next_of_kin_AddressLabel1.TabIndex = 105
        Next_of_kin_AddressLabel1.Text = "Next of Kin Address:"
        '
        'Next_of_kin_telLabel1
        '
        Next_of_kin_telLabel1.AutoSize = True
        Next_of_kin_telLabel1.BackColor = System.Drawing.Color.Transparent
        Next_of_kin_telLabel1.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Next_of_kin_telLabel1.Location = New System.Drawing.Point(80, 672)
        Next_of_kin_telLabel1.Name = "Next_of_kin_telLabel1"
        Next_of_kin_telLabel1.Size = New System.Drawing.Size(128, 31)
        Next_of_kin_telLabel1.TabIndex = 107
        Next_of_kin_telLabel1.Text = "Next of Kin Tel:"
        '
        'DoctorNameLabel1
        '
        DoctorNameLabel1.AutoSize = True
        DoctorNameLabel1.BackColor = System.Drawing.Color.Transparent
        DoctorNameLabel1.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DoctorNameLabel1.Location = New System.Drawing.Point(564, 542)
        DoctorNameLabel1.Name = "DoctorNameLabel1"
        DoctorNameLabel1.Size = New System.Drawing.Size(115, 31)
        DoctorNameLabel1.TabIndex = 109
        DoctorNameLabel1.Text = "Doctor Name:"
        '
        'ClinicNoLabel1
        '
        ClinicNoLabel1.AutoSize = True
        ClinicNoLabel1.BackColor = System.Drawing.Color.Transparent
        ClinicNoLabel1.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        ClinicNoLabel1.Location = New System.Drawing.Point(564, 586)
        ClinicNoLabel1.Name = "ClinicNoLabel1"
        ClinicNoLabel1.Size = New System.Drawing.Size(84, 31)
        ClinicNoLabel1.TabIndex = 111
        ClinicNoLabel1.Text = "Clinic No:"
        '
        'Doctor_AddressLabel1
        '
        Doctor_AddressLabel1.AutoSize = True
        Doctor_AddressLabel1.BackColor = System.Drawing.Color.Transparent
        Doctor_AddressLabel1.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Doctor_AddressLabel1.Location = New System.Drawing.Point(564, 631)
        Doctor_AddressLabel1.Name = "Doctor_AddressLabel1"
        Doctor_AddressLabel1.Size = New System.Drawing.Size(131, 31)
        Doctor_AddressLabel1.TabIndex = 113
        Doctor_AddressLabel1.Text = "Doctor Address:"
        '
        'Doctor_telLabel1
        '
        Doctor_telLabel1.AutoSize = True
        Doctor_telLabel1.BackColor = System.Drawing.Color.Transparent
        Doctor_telLabel1.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Doctor_telLabel1.Location = New System.Drawing.Point(564, 672)
        Doctor_telLabel1.Name = "Doctor_telLabel1"
        Doctor_telLabel1.Size = New System.Drawing.Size(95, 31)
        Doctor_telLabel1.TabIndex = 115
        Doctor_telLabel1.Text = "Doctor Tel:"
        '
        'patientsearch
        '
        Me.patientsearch.BackColor = System.Drawing.Color.Transparent
        Me.patientsearch.ForeColor = System.Drawing.Color.Black
        Me.patientsearch.Location = New System.Drawing.Point(1036, 15)
        Me.patientsearch.Name = "patientsearch"
        Me.patientsearch.Size = New System.Drawing.Size(114, 38)
        Me.patientsearch.TabIndex = 65
        Me.patientsearch.Text = "Search"
        Me.patientsearch.UseVisualStyleBackColor = False
        '
        'Location_Doctor_Details
        '
        Me.Location_Doctor_Details.AutoSize = True
        Me.Location_Doctor_Details.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Location_Doctor_Details.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Location_Doctor_Details.Location = New System.Drawing.Point(661, 18)
        Me.Location_Doctor_Details.Name = "Location_Doctor_Details"
        Me.Location_Doctor_Details.Size = New System.Drawing.Size(178, 40)
        Me.Location_Doctor_Details.TabIndex = 84
        Me.Location_Doctor_Details.Text = "ข้อมูลแพทย์ผู้รักษา"
        '
        'Next_of_kin
        '
        Me.Next_of_kin.AutoSize = True
        Me.Next_of_kin.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Next_of_kin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Next_of_kin.Location = New System.Drawing.Point(218, 18)
        Me.Next_of_kin.Name = "Next_of_kin"
        Me.Next_of_kin.Size = New System.Drawing.Size(157, 40)
        Me.Next_of_kin.TabIndex = 83
        Me.Next_of_kin.Text = "ข้อมูลญาติผู้ป่วย"
        '
        'Wellmeadows_hospitalDataSet
        '
        Me.Wellmeadows_hospitalDataSet.DataSetName = "wellmeadows_hospitalDataSet"
        Me.Wellmeadows_hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "patient"
        Me.PatientBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'PatientTableAdapter
        '
        Me.PatientTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.admitted_wardTableAdapter = Nothing
        Me.TableAdapterManager.apply_wardsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bedTableAdapter = Nothing
        Me.TableAdapterManager.MedicationTableAdapter = Nothing
        Me.TableAdapterManager.medicineTableAdapter = Nothing
        Me.TableAdapterManager.patientTableAdapter = Me.PatientTableAdapter
        Me.TableAdapterManager.qulificationTableAdapter = Nothing
        Me.TableAdapterManager.roomTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.TreatmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = project_g11.wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.work_experienceTableAdapter = Nothing
        Me.TableAdapterManager.Work_inTableAdapter = Nothing
        '
        'PatientBindingNavigator
        '
        Me.PatientBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PatientBindingNavigator.BindingSource = Me.PatientBindingSource
        Me.PatientBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PatientBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PatientBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PatientBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PatientBindingNavigatorSaveItem})
        Me.PatientBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PatientBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PatientBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PatientBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PatientBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PatientBindingNavigator.Name = "PatientBindingNavigator"
        Me.PatientBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PatientBindingNavigator.Size = New System.Drawing.Size(1443, 27)
        Me.PatientBindingNavigator.TabIndex = 85
        Me.PatientBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'PatientBindingNavigatorSaveItem
        '
        Me.PatientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PatientBindingNavigatorSaveItem.Image = CType(resources.GetObject("PatientBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PatientBindingNavigatorSaveItem.Name = "PatientBindingNavigatorSaveItem"
        Me.PatientBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.PatientBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "patientID", True))
        Me.PatientIDTextBox.Location = New System.Drawing.Point(250, 171)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.Size = New System.Drawing.Size(275, 22)
        Me.PatientIDTextBox.TabIndex = 86
        '
        'PatientNameTextBox
        '
        Me.PatientNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "patientName", True))
        Me.PatientNameTextBox.Location = New System.Drawing.Point(722, 171)
        Me.PatientNameTextBox.Name = "PatientNameTextBox"
        Me.PatientNameTextBox.Size = New System.Drawing.Size(271, 22)
        Me.PatientNameTextBox.TabIndex = 88
        '
        'Patient_AddressTextBox
        '
        Me.Patient_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "patient_Address", True))
        Me.Patient_AddressTextBox.Location = New System.Drawing.Point(250, 217)
        Me.Patient_AddressTextBox.Name = "Patient_AddressTextBox"
        Me.Patient_AddressTextBox.Size = New System.Drawing.Size(275, 22)
        Me.Patient_AddressTextBox.TabIndex = 90
        '
        'BirthdateDateTimePicker
        '
        Me.BirthdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientBindingSource, "birthdate", True))
        Me.BirthdateDateTimePicker.Location = New System.Drawing.Point(722, 217)
        Me.BirthdateDateTimePicker.Name = "BirthdateDateTimePicker"
        Me.BirthdateDateTimePicker.Size = New System.Drawing.Size(271, 22)
        Me.BirthdateDateTimePicker.TabIndex = 92
        '
        'Patient_telTextBox
        '
        Me.Patient_telTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "patient_tel", True))
        Me.Patient_telTextBox.Location = New System.Drawing.Point(250, 304)
        Me.Patient_telTextBox.Name = "Patient_telTextBox"
        Me.Patient_telTextBox.Size = New System.Drawing.Size(275, 22)
        Me.Patient_telTextBox.TabIndex = 98
        '
        'Date_admissionDateTimePicker
        '
        Me.Date_admissionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientBindingSource, "date_admission", True))
        Me.Date_admissionDateTimePicker.Location = New System.Drawing.Point(722, 304)
        Me.Date_admissionDateTimePicker.Name = "Date_admissionDateTimePicker"
        Me.Date_admissionDateTimePicker.Size = New System.Drawing.Size(271, 22)
        Me.Date_admissionDateTimePicker.TabIndex = 100
        '
        'Next_of_kinNameTextBox1
        '
        Me.Next_of_kinNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Next_of_kinName", True))
        Me.Next_of_kinNameTextBox1.Location = New System.Drawing.Point(250, 542)
        Me.Next_of_kinNameTextBox1.Name = "Next_of_kinNameTextBox1"
        Me.Next_of_kinNameTextBox1.Size = New System.Drawing.Size(275, 22)
        Me.Next_of_kinNameTextBox1.TabIndex = 102
        '
        'RelationshipTextBox1
        '
        Me.RelationshipTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "relationship", True))
        Me.RelationshipTextBox1.Location = New System.Drawing.Point(250, 586)
        Me.RelationshipTextBox1.Name = "RelationshipTextBox1"
        Me.RelationshipTextBox1.Size = New System.Drawing.Size(275, 22)
        Me.RelationshipTextBox1.TabIndex = 104
        '
        'Next_of_kin_AddressTextBox1
        '
        Me.Next_of_kin_AddressTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Next_of_kin_Address", True))
        Me.Next_of_kin_AddressTextBox1.Location = New System.Drawing.Point(250, 631)
        Me.Next_of_kin_AddressTextBox1.Name = "Next_of_kin_AddressTextBox1"
        Me.Next_of_kin_AddressTextBox1.Size = New System.Drawing.Size(275, 22)
        Me.Next_of_kin_AddressTextBox1.TabIndex = 106
        '
        'Next_of_kin_telTextBox1
        '
        Me.Next_of_kin_telTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Next_of_kin_tel", True))
        Me.Next_of_kin_telTextBox1.Location = New System.Drawing.Point(250, 672)
        Me.Next_of_kin_telTextBox1.Name = "Next_of_kin_telTextBox1"
        Me.Next_of_kin_telTextBox1.Size = New System.Drawing.Size(275, 22)
        Me.Next_of_kin_telTextBox1.TabIndex = 108
        '
        'DoctorNameTextBox1
        '
        Me.DoctorNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "doctorName", True))
        Me.DoctorNameTextBox1.Location = New System.Drawing.Point(722, 542)
        Me.DoctorNameTextBox1.Name = "DoctorNameTextBox1"
        Me.DoctorNameTextBox1.Size = New System.Drawing.Size(271, 22)
        Me.DoctorNameTextBox1.TabIndex = 110
        '
        'ClinicNoTextBox1
        '
        Me.ClinicNoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "clinicNo", True))
        Me.ClinicNoTextBox1.Location = New System.Drawing.Point(722, 586)
        Me.ClinicNoTextBox1.Name = "ClinicNoTextBox1"
        Me.ClinicNoTextBox1.Size = New System.Drawing.Size(271, 22)
        Me.ClinicNoTextBox1.TabIndex = 112
        '
        'Doctor_AddressTextBox1
        '
        Me.Doctor_AddressTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "doctor_Address", True))
        Me.Doctor_AddressTextBox1.Location = New System.Drawing.Point(722, 631)
        Me.Doctor_AddressTextBox1.Name = "Doctor_AddressTextBox1"
        Me.Doctor_AddressTextBox1.Size = New System.Drawing.Size(271, 22)
        Me.Doctor_AddressTextBox1.TabIndex = 114
        '
        'Doctor_telTextBox1
        '
        Me.Doctor_telTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "doctor_tel", True))
        Me.Doctor_telTextBox1.Location = New System.Drawing.Point(722, 672)
        Me.Doctor_telTextBox1.Name = "Doctor_telTextBox1"
        Me.Doctor_telTextBox1.Size = New System.Drawing.Size(271, 22)
        Me.Doctor_telTextBox1.TabIndex = 116
        '
        'SexText
        '
        Me.SexText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "sex", True))
        Me.SexText.FormattingEnabled = True
        Me.SexText.Location = New System.Drawing.Point(250, 260)
        Me.SexText.Name = "SexText"
        Me.SexText.Size = New System.Drawing.Size(275, 24)
        Me.SexText.TabIndex = 118
        '
        'Panelcoler5
        '
        Me.Panelcoler5.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panelcoler5.Controls.Add(Me.textBoxsearch)
        Me.Panelcoler5.Controls.Add(Me.PictureBox1)
        Me.Panelcoler5.Controls.Add(Me.Label1)
        Me.Panelcoler5.Controls.Add(Me.patientsearch)
        Me.Panelcoler5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panelcoler5.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Panelcoler5.Location = New System.Drawing.Point(0, 27)
        Me.Panelcoler5.Name = "Panelcoler5"
        Me.Panelcoler5.Size = New System.Drawing.Size(1443, 75)
        Me.Panelcoler5.TabIndex = 119
        '
        'textBoxsearch
        '
        Me.textBoxsearch.BackColor = System.Drawing.SystemColors.Menu
        Me.textBoxsearch.Location = New System.Drawing.Point(722, 23)
        Me.textBoxsearch.Multiline = True
        Me.textBoxsearch.Name = "textBoxsearch"
        Me.textBoxsearch.Size = New System.Drawing.Size(300, 26)
        Me.textBoxsearch.TabIndex = 121
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.project_g11.My.Resources.Resources.png_clipart_button_arrow_back_arrow_blue_trademark_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(65, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 86
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(455, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 40)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "ข้อมูลผู้ป่วย"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel1.Controls.Add(Me.Location_Doctor_Details)
        Me.Panel1.Controls.Add(Me.Next_of_kin)
        Me.Panel1.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel1.Location = New System.Drawing.Point(0, 434)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1443, 75)
        Me.Panel1.TabIndex = 120
        '
        'ComboBoxstatus
        '
        Me.ComboBoxstatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "maritall_status", True))
        Me.ComboBoxstatus.FormattingEnabled = True
        Me.ComboBoxstatus.Location = New System.Drawing.Point(722, 263)
        Me.ComboBoxstatus.Name = "ComboBoxstatus"
        Me.ComboBoxstatus.Size = New System.Drawing.Size(271, 24)
        Me.ComboBoxstatus.TabIndex = 121
        '
        'FormPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.project_g11.My.Resources.Resources.พื้นหลังงงง
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1443, 942)
        Me.Controls.Add(Me.ComboBoxstatus)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panelcoler5)
        Me.Controls.Add(Me.SexText)
        Me.Controls.Add(PatientIDLabel)
        Me.Controls.Add(Me.PatientIDTextBox)
        Me.Controls.Add(PatientNameLabel)
        Me.Controls.Add(Me.PatientNameTextBox)
        Me.Controls.Add(Patient_AddressLabel)
        Me.Controls.Add(Me.Patient_AddressTextBox)
        Me.Controls.Add(BirthdateLabel)
        Me.Controls.Add(Me.BirthdateDateTimePicker)
        Me.Controls.Add(SexLabel)
        Me.Controls.Add(Maritall_statusLabel)
        Me.Controls.Add(Patient_telLabel)
        Me.Controls.Add(Me.Patient_telTextBox)
        Me.Controls.Add(Date_admissionLabel)
        Me.Controls.Add(Me.Date_admissionDateTimePicker)
        Me.Controls.Add(Next_of_kinNameLabel1)
        Me.Controls.Add(Me.Next_of_kinNameTextBox1)
        Me.Controls.Add(RelationshipLabel1)
        Me.Controls.Add(Me.RelationshipTextBox1)
        Me.Controls.Add(Next_of_kin_AddressLabel1)
        Me.Controls.Add(Me.Next_of_kin_AddressTextBox1)
        Me.Controls.Add(Next_of_kin_telLabel1)
        Me.Controls.Add(Me.Next_of_kin_telTextBox1)
        Me.Controls.Add(DoctorNameLabel1)
        Me.Controls.Add(Me.DoctorNameTextBox1)
        Me.Controls.Add(ClinicNoLabel1)
        Me.Controls.Add(Me.ClinicNoTextBox1)
        Me.Controls.Add(Doctor_AddressLabel1)
        Me.Controls.Add(Me.Doctor_AddressTextBox1)
        Me.Controls.Add(Doctor_telLabel1)
        Me.Controls.Add(Me.Doctor_telTextBox1)
        Me.Controls.Add(Me.PatientBindingNavigator)
        Me.Name = "FormPatient"
        Me.Text = "FormPatient"
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientBindingNavigator.ResumeLayout(False)
        Me.PatientBindingNavigator.PerformLayout()
        Me.Panelcoler5.ResumeLayout(False)
        Me.Panelcoler5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents patientsearch As Button
    Friend WithEvents Location_Doctor_Details As Label
    Friend WithEvents Next_of_kin As Label
    Friend WithEvents Wellmeadows_hospitalDataSet As wellmeadows_hospitalDataSet
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PatientTableAdapter As wellmeadows_hospitalDataSetTableAdapters.patientTableAdapter
    Friend WithEvents TableAdapterManager As wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PatientBindingNavigator As BindingNavigator
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
    Friend WithEvents PatientBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PatientIDTextBox As TextBox
    Friend WithEvents PatientNameTextBox As TextBox
    Friend WithEvents Patient_AddressTextBox As TextBox
    Friend WithEvents BirthdateDateTimePicker As DateTimePicker
    Friend WithEvents Patient_telTextBox As TextBox
    Friend WithEvents Date_admissionDateTimePicker As DateTimePicker
    Friend WithEvents Next_of_kinNameTextBox1 As TextBox
    Friend WithEvents RelationshipTextBox1 As TextBox
    Friend WithEvents Next_of_kin_AddressTextBox1 As TextBox
    Friend WithEvents Next_of_kin_telTextBox1 As TextBox
    Friend WithEvents DoctorNameTextBox1 As TextBox
    Friend WithEvents ClinicNoTextBox1 As TextBox
    Friend WithEvents Doctor_AddressTextBox1 As TextBox
    Friend WithEvents Doctor_telTextBox1 As TextBox
    Friend WithEvents SexText As ComboBox
    Friend WithEvents Panelcoler5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents textBoxsearch As TextBox
    Friend WithEvents ComboBoxstatus As ComboBox
End Class
