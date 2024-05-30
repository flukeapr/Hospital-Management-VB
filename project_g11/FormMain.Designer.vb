<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Dim PositiontpyeLabel As System.Windows.Forms.Label
        Dim PaidLabel1 As System.Windows.Forms.Label
        Dim SexLabel2 As System.Windows.Forms.Label
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.Staff = New System.Windows.Forms.TabPage()
        Me.experience = New System.Windows.Forms.Button()
        Me.qualification = New System.Windows.Forms.Button()
        Me.Picturecoler2 = New System.Windows.Forms.Panel()
        Me.textBoxsearch = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.staffdetails = New System.Windows.Forms.Label()
        Me.staffsearch = New System.Windows.Forms.Button()
        Me.PositiontpyeComboBox = New System.Windows.Forms.ComboBox()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wellmeadows_hospitalDataSet = New project_g11.wellmeadows_hospitalDataSet()
        Me.PaidComboBox = New System.Windows.Forms.ComboBox()
        Me.SexComboBox = New System.Windows.Forms.ComboBox()
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
        Me.Apply_wardsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.QulificationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Work_in_viewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Apply_wardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TreatmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Admitted_wardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Apply_wardsTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.apply_wardsTableAdapter()
        Me.Work_inBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Work_inTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.Work_inTableAdapter()
        Me.Work_in_viewTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.Work_in_viewTableAdapter()
        Me.MedicationTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.MedicationTableAdapter()
        Me.MedicationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.QulificationTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.qulificationTableAdapter()
        PositiontpyeLabel = New System.Windows.Forms.Label()
        PaidLabel1 = New System.Windows.Forms.Label()
        SexLabel2 = New System.Windows.Forms.Label()
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
        Me.TabControl.SuspendLayout()
        Me.Staff.SuspendLayout()
        Me.Picturecoler2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StaffBindingNavigator.SuspendLayout()
        CType(Me.Apply_wardsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QulificationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Work_in_viewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Apply_wardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreatmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Admitted_wardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Work_inBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PositiontpyeLabel
        '
        PositiontpyeLabel.AutoSize = True
        PositiontpyeLabel.BackColor = System.Drawing.Color.Transparent
        PositiontpyeLabel.Location = New System.Drawing.Point(117, 448)
        PositiontpyeLabel.Name = "PositiontpyeLabel"
        PositiontpyeLabel.Size = New System.Drawing.Size(117, 31)
        PositiontpyeLabel.TabIndex = 49
        PositiontpyeLabel.Text = "Position Type:"
        '
        'PaidLabel1
        '
        PaidLabel1.AutoSize = True
        PaidLabel1.BackColor = System.Drawing.Color.Transparent
        PaidLabel1.Location = New System.Drawing.Point(696, 456)
        PaidLabel1.Name = "PaidLabel1"
        PaidLabel1.Size = New System.Drawing.Size(49, 31)
        PaidLabel1.TabIndex = 48
        PaidLabel1.Text = "Paid:"
        '
        'SexLabel2
        '
        SexLabel2.AutoSize = True
        SexLabel2.BackColor = System.Drawing.Color.Transparent
        SexLabel2.Location = New System.Drawing.Point(704, 187)
        SexLabel2.Name = "SexLabel2"
        SexLabel2.Size = New System.Drawing.Size(43, 31)
        SexLabel2.TabIndex = 47
        SexLabel2.Text = "Sex:"
        '
        'StaffIDLabel
        '
        StaffIDLabel.AutoSize = True
        StaffIDLabel.BackColor = System.Drawing.Color.Transparent
        StaffIDLabel.Location = New System.Drawing.Point(153, 142)
        StaffIDLabel.Name = "StaffIDLabel"
        StaffIDLabel.Size = New System.Drawing.Size(72, 31)
        StaffIDLabel.TabIndex = 0
        StaffIDLabel.Text = "Staff ID:"
        '
        'StaffNameLabel
        '
        StaffNameLabel.AutoSize = True
        StaffNameLabel.BackColor = System.Drawing.Color.Transparent
        StaffNameLabel.Location = New System.Drawing.Point(647, 146)
        StaffNameLabel.Name = "StaffNameLabel"
        StaffNameLabel.Size = New System.Drawing.Size(100, 31)
        StaffNameLabel.TabIndex = 2
        StaffNameLabel.Text = "Staff Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.Transparent
        AddressLabel.Location = New System.Drawing.Point(146, 234)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(77, 31)
        AddressLabel.TabIndex = 6
        AddressLabel.Text = "Address:"
        '
        'BirthdateLabel
        '
        BirthdateLabel.AutoSize = True
        BirthdateLabel.BackColor = System.Drawing.Color.Transparent
        BirthdateLabel.Location = New System.Drawing.Point(139, 288)
        BirthdateLabel.Name = "BirthdateLabel"
        BirthdateLabel.Size = New System.Drawing.Size(92, 31)
        BirthdateLabel.TabIndex = 8
        BirthdateLabel.Text = "Birth Date:"
        '
        'TelLabel
        '
        TelLabel.AutoSize = True
        TelLabel.BackColor = System.Drawing.Color.Transparent
        TelLabel.Location = New System.Drawing.Point(704, 295)
        TelLabel.Name = "TelLabel"
        TelLabel.Size = New System.Drawing.Size(41, 31)
        TelLabel.TabIndex = 10
        TelLabel.Text = "Tel:"
        '
        'NINLabel
        '
        NINLabel.AutoSize = True
        NINLabel.BackColor = System.Drawing.Color.Transparent
        NINLabel.Location = New System.Drawing.Point(701, 351)
        NINLabel.Name = "NINLabel"
        NINLabel.Size = New System.Drawing.Size(44, 31)
        NINLabel.TabIndex = 12
        NINLabel.Text = "NIN:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.BackColor = System.Drawing.Color.Transparent
        PositionLabel.Location = New System.Drawing.Point(150, 347)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(76, 31)
        PositionLabel.TabIndex = 14
        PositionLabel.Text = "Position:"
        '
        'WardIDLabel
        '
        WardIDLabel.AutoSize = True
        WardIDLabel.BackColor = System.Drawing.Color.Transparent
        WardIDLabel.Location = New System.Drawing.Point(149, 189)
        WardIDLabel.Name = "WardIDLabel"
        WardIDLabel.Size = New System.Drawing.Size(76, 31)
        WardIDLabel.TabIndex = 16
        WardIDLabel.Text = "Ward ID:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.BackColor = System.Drawing.Color.Transparent
        SalaryLabel.Location = New System.Drawing.Point(684, 401)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(61, 31)
        SalaryLabel.TabIndex = 18
        SalaryLabel.Text = "Salary:"
        '
        'HoursLabel
        '
        HoursLabel.AutoSize = True
        HoursLabel.BackColor = System.Drawing.Color.Transparent
        HoursLabel.Location = New System.Drawing.Point(165, 401)
        HoursLabel.Name = "HoursLabel"
        HoursLabel.Size = New System.Drawing.Size(61, 31)
        HoursLabel.TabIndex = 20
        HoursLabel.Text = "Hours:"
        '
        'PaidLabel
        '
        PaidLabel.AutoSize = True
        PaidLabel.Location = New System.Drawing.Point(648, 443)
        PaidLabel.Name = "PaidLabel"
        PaidLabel.Size = New System.Drawing.Size(0, 31)
        PaidLabel.TabIndex = 22
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.Staff)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1268, 667)
        Me.TabControl.TabIndex = 0
        '
        'Staff
        '
        Me.Staff.AutoScroll = True
        Me.Staff.BackColor = System.Drawing.SystemColors.Control
        Me.Staff.BackgroundImage = Global.project_g11.My.Resources.Resources.พื้นหลังงงง
        Me.Staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Staff.Controls.Add(Me.experience)
        Me.Staff.Controls.Add(Me.qualification)
        Me.Staff.Controls.Add(Me.Picturecoler2)
        Me.Staff.Controls.Add(PositiontpyeLabel)
        Me.Staff.Controls.Add(Me.PositiontpyeComboBox)
        Me.Staff.Controls.Add(PaidLabel1)
        Me.Staff.Controls.Add(Me.PaidComboBox)
        Me.Staff.Controls.Add(SexLabel2)
        Me.Staff.Controls.Add(Me.SexComboBox)
        Me.Staff.Controls.Add(Me.StaffBindingNavigator)
        Me.Staff.Controls.Add(StaffIDLabel)
        Me.Staff.Controls.Add(Me.StaffIDTextBox)
        Me.Staff.Controls.Add(StaffNameLabel)
        Me.Staff.Controls.Add(Me.StaffNameTextBox)
        Me.Staff.Controls.Add(AddressLabel)
        Me.Staff.Controls.Add(Me.AddressTextBox)
        Me.Staff.Controls.Add(BirthdateLabel)
        Me.Staff.Controls.Add(Me.BirthdateDateTimePicker)
        Me.Staff.Controls.Add(TelLabel)
        Me.Staff.Controls.Add(Me.TelTextBox)
        Me.Staff.Controls.Add(NINLabel)
        Me.Staff.Controls.Add(Me.NINTextBox)
        Me.Staff.Controls.Add(PositionLabel)
        Me.Staff.Controls.Add(Me.PositionTextBox)
        Me.Staff.Controls.Add(WardIDLabel)
        Me.Staff.Controls.Add(Me.WardIDTextBox)
        Me.Staff.Controls.Add(SalaryLabel)
        Me.Staff.Controls.Add(Me.SalaryTextBox)
        Me.Staff.Controls.Add(HoursLabel)
        Me.Staff.Controls.Add(Me.HoursTextBox)
        Me.Staff.Controls.Add(PaidLabel)
        Me.Staff.Location = New System.Drawing.Point(4, 40)
        Me.Staff.Name = "Staff"
        Me.Staff.Padding = New System.Windows.Forms.Padding(3)
        Me.Staff.Size = New System.Drawing.Size(1260, 623)
        Me.Staff.TabIndex = 1
        Me.Staff.Text = "Staff"
        '
        'experience
        '
        Me.experience.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.experience.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.experience.Location = New System.Drawing.Point(795, 521)
        Me.experience.Name = "experience"
        Me.experience.Size = New System.Drawing.Size(261, 38)
        Me.experience.TabIndex = 57
        Me.experience.Text = "ประสบการณ์(Experience Work)"
        Me.experience.UseVisualStyleBackColor = False
        '
        'qualification
        '
        Me.qualification.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.qualification.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.qualification.Location = New System.Drawing.Point(283, 521)
        Me.qualification.Name = "qualification"
        Me.qualification.Size = New System.Drawing.Size(261, 38)
        Me.qualification.TabIndex = 56
        Me.qualification.Text = "การศึกษา(Qualifications)"
        Me.qualification.UseVisualStyleBackColor = False
        '
        'Picturecoler2
        '
        Me.Picturecoler2.BackColor = System.Drawing.Color.MediumOrchid
        Me.Picturecoler2.Controls.Add(Me.textBoxsearch)
        Me.Picturecoler2.Controls.Add(Me.PictureBox1)
        Me.Picturecoler2.Controls.Add(Me.staffdetails)
        Me.Picturecoler2.Controls.Add(Me.staffsearch)
        Me.Picturecoler2.Location = New System.Drawing.Point(5, 33)
        Me.Picturecoler2.Name = "Picturecoler2"
        Me.Picturecoler2.Size = New System.Drawing.Size(1409, 100)
        Me.Picturecoler2.TabIndex = 52
        '
        'textBoxsearch
        '
        Me.textBoxsearch.BackColor = System.Drawing.SystemColors.Menu
        Me.textBoxsearch.Location = New System.Drawing.Point(928, 31)
        Me.textBoxsearch.Name = "textBoxsearch"
        Me.textBoxsearch.Size = New System.Drawing.Size(300, 38)
        Me.textBoxsearch.TabIndex = 47
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.project_g11.My.Resources.Resources.png_clipart_button_arrow_back_arrow_blue_trademark_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(51, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'staffdetails
        '
        Me.staffdetails.AutoSize = True
        Me.staffdetails.Font = New System.Drawing.Font("TH SarabunPSK", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.staffdetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.staffdetails.Location = New System.Drawing.Point(459, 24)
        Me.staffdetails.Name = "staffdetails"
        Me.staffdetails.Size = New System.Drawing.Size(359, 53)
        Me.staffdetails.TabIndex = 51
        Me.staffdetails.Text = "ข้อมูลพนักงาน(Staff Details)"
        '
        'staffsearch
        '
        Me.staffsearch.BackColor = System.Drawing.Color.GhostWhite
        Me.staffsearch.ForeColor = System.Drawing.Color.Black
        Me.staffsearch.Location = New System.Drawing.Point(1234, 24)
        Me.staffsearch.Name = "staffsearch"
        Me.staffsearch.Size = New System.Drawing.Size(130, 50)
        Me.staffsearch.TabIndex = 43
        Me.staffsearch.Text = "Search"
        Me.staffsearch.UseVisualStyleBackColor = False
        '
        'PositiontpyeComboBox
        '
        Me.PositiontpyeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "positiontpye", True))
        Me.PositiontpyeComboBox.FormattingEnabled = True
        Me.PositiontpyeComboBox.Location = New System.Drawing.Point(284, 448)
        Me.PositiontpyeComboBox.Name = "PositiontpyeComboBox"
        Me.PositiontpyeComboBox.Size = New System.Drawing.Size(290, 39)
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
        Me.PaidComboBox.Location = New System.Drawing.Point(792, 448)
        Me.PaidComboBox.Name = "PaidComboBox"
        Me.PaidComboBox.Size = New System.Drawing.Size(298, 39)
        Me.PaidComboBox.TabIndex = 49
        '
        'SexComboBox
        '
        Me.SexComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "sex", True))
        Me.SexComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.StaffBindingSource, "sex", True))
        Me.SexComboBox.FormattingEnabled = True
        Me.SexComboBox.Location = New System.Drawing.Point(794, 186)
        Me.SexComboBox.Name = "SexComboBox"
        Me.SexComboBox.Size = New System.Drawing.Size(298, 39)
        Me.SexComboBox.TabIndex = 48
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
        Me.StaffIDTextBox.Location = New System.Drawing.Point(283, 143)
        Me.StaffIDTextBox.Name = "StaffIDTextBox"
        Me.StaffIDTextBox.Size = New System.Drawing.Size(290, 38)
        Me.StaffIDTextBox.TabIndex = 1
        '
        'StaffNameTextBox
        '
        Me.StaffNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "staffName", True))
        Me.StaffNameTextBox.Location = New System.Drawing.Point(795, 139)
        Me.StaffNameTextBox.Name = "StaffNameTextBox"
        Me.StaffNameTextBox.Size = New System.Drawing.Size(298, 38)
        Me.StaffNameTextBox.TabIndex = 3
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(284, 234)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(809, 38)
        Me.AddressTextBox.TabIndex = 7
        '
        'BirthdateDateTimePicker
        '
        Me.BirthdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "birthdate", True))
        Me.BirthdateDateTimePicker.Location = New System.Drawing.Point(283, 288)
        Me.BirthdateDateTimePicker.Name = "BirthdateDateTimePicker"
        Me.BirthdateDateTimePicker.Size = New System.Drawing.Size(290, 38)
        Me.BirthdateDateTimePicker.TabIndex = 9
        '
        'TelTextBox
        '
        Me.TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "tel", True))
        Me.TelTextBox.Location = New System.Drawing.Point(791, 288)
        Me.TelTextBox.Name = "TelTextBox"
        Me.TelTextBox.Size = New System.Drawing.Size(298, 38)
        Me.TelTextBox.TabIndex = 11
        '
        'NINTextBox
        '
        Me.NINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "NIN", True))
        Me.NINTextBox.Location = New System.Drawing.Point(792, 340)
        Me.NINTextBox.Name = "NINTextBox"
        Me.NINTextBox.Size = New System.Drawing.Size(298, 38)
        Me.NINTextBox.TabIndex = 13
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "position", True))
        Me.PositionTextBox.Location = New System.Drawing.Point(284, 344)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(290, 38)
        Me.PositionTextBox.TabIndex = 15
        '
        'WardIDTextBox
        '
        Me.WardIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "wardID", True))
        Me.WardIDTextBox.Location = New System.Drawing.Point(283, 187)
        Me.WardIDTextBox.Name = "WardIDTextBox"
        Me.WardIDTextBox.Size = New System.Drawing.Size(290, 38)
        Me.WardIDTextBox.TabIndex = 17
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Salary", True))
        Me.SalaryTextBox.Location = New System.Drawing.Point(792, 394)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(298, 38)
        Me.SalaryTextBox.TabIndex = 19
        '
        'HoursTextBox
        '
        Me.HoursTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "hours", True))
        Me.HoursTextBox.Location = New System.Drawing.Point(284, 398)
        Me.HoursTextBox.Name = "HoursTextBox"
        Me.HoursTextBox.Size = New System.Drawing.Size(290, 38)
        Me.HoursTextBox.TabIndex = 21
        '
        'QulificationBindingSource
        '
        Me.QulificationBindingSource.DataMember = "qulification"
        Me.QulificationBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "patient"
        Me.PatientBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'MedicineBindingSource
        '
        Me.MedicineBindingSource.DataMember = "medicine"
        Me.MedicineBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'Work_in_viewBindingSource
        '
        Me.Work_in_viewBindingSource.DataMember = "Work_in_view"
        Me.Work_in_viewBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'WardsBindingSource
        '
        Me.WardsBindingSource.DataMember = "Wards"
        Me.WardsBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'Apply_wardsBindingSource
        '
        Me.Apply_wardsBindingSource.DataMember = "apply_wards"
        Me.Apply_wardsBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'TreatmentBindingSource
        '
        Me.TreatmentBindingSource.DataMember = "Treatment"
        Me.TreatmentBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'MedicationBindingSource
        '
        Me.MedicationBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        Me.MedicationBindingSource.Position = 0
        '
        'Admitted_wardBindingSource
        '
        Me.Admitted_wardBindingSource.DataMember = "admitted_ward"
        Me.Admitted_wardBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
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
        Me.TableAdapterManager.bedTableAdapter = Nothing
        Me.TableAdapterManager.MedicationTableAdapter = Nothing
        Me.TableAdapterManager.medicineTableAdapter = Nothing
        Me.TableAdapterManager.patientTableAdapter = Nothing
        Me.TableAdapterManager.qulificationTableAdapter = Nothing
        Me.TableAdapterManager.roomTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.TreatmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = project_g11.wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.work_experienceTableAdapter = Nothing
        Me.TableAdapterManager.Work_inTableAdapter = Nothing
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
        'Apply_wardsTableAdapter
        '
        Me.Apply_wardsTableAdapter.ClearBeforeFill = True
        '
        'Work_inBindingSource
        '
        Me.Work_inBindingSource.DataMember = "Work_in"
        Me.Work_inBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'Work_inTableAdapter
        '
        Me.Work_inTableAdapter.ClearBeforeFill = True
        '
        'Work_in_viewTableAdapter
        '
        Me.Work_in_viewTableAdapter.ClearBeforeFill = True
        '
        'MedicationTableAdapter
        '
        Me.MedicationTableAdapter.ClearBeforeFill = True
        '
        'MedicationBindingSource1
        '
        Me.MedicationBindingSource1.DataMember = "Medication"
        Me.MedicationBindingSource1.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'QulificationTableAdapter
        '
        Me.QulificationTableAdapter.ClearBeforeFill = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 667)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "FormMain"
        Me.Text = "FormStaff"
        Me.TabControl.ResumeLayout(False)
        Me.Staff.ResumeLayout(False)
        Me.Staff.PerformLayout()
        Me.Picturecoler2.ResumeLayout(False)
        Me.Picturecoler2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StaffBindingNavigator.ResumeLayout(False)
        Me.StaffBindingNavigator.PerformLayout()
        CType(Me.Apply_wardsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QulificationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Work_in_viewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Apply_wardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreatmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Admitted_wardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Work_inBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents Wellmeadows_hospitalDataSet As wellmeadows_hospitalDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As wellmeadows_hospitalDataSetTableAdapters.staffTableAdapter
    Friend WithEvents TableAdapterManager As wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PatientTableAdapter As wellmeadows_hospitalDataSetTableAdapters.patientTableAdapter
    Friend WithEvents MedicineBindingSource As BindingSource
    Friend WithEvents MedicineTableAdapter As wellmeadows_hospitalDataSetTableAdapters.medicineTableAdapter
    Friend WithEvents WardsBindingSource As BindingSource
    Friend WithEvents WardsTableAdapter As wellmeadows_hospitalDataSetTableAdapters.WardsTableAdapter
    Friend WithEvents TreatmentBindingSource As BindingSource
    Friend WithEvents TreatmentTableAdapter As wellmeadows_hospitalDataSetTableAdapters.TreatmentTableAdapter
    Friend WithEvents Admitted_wardBindingSource As BindingSource
    Friend WithEvents Admitted_wardTableAdapter As wellmeadows_hospitalDataSetTableAdapters.admitted_wardTableAdapter
    Friend WithEvents PatientBindingSource1 As BindingSource
    Friend WithEvents PatientBindingSource2 As BindingSource
    Friend WithEvents StaffBindingSource1 As BindingSource
    Friend WithEvents Apply_wardsBindingSource As BindingSource
    Friend WithEvents Apply_wardsTableAdapter As wellmeadows_hospitalDataSetTableAdapters.apply_wardsTableAdapter

    Friend WithEvents Apply_wardsBindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Work_inBindingSource As BindingSource
    Friend WithEvents Work_inTableAdapter As wellmeadows_hospitalDataSetTableAdapters.Work_inTableAdapter
    Friend WithEvents Work_in_viewBindingSource As BindingSource
    Friend WithEvents Work_in_viewTableAdapter As wellmeadows_hospitalDataSetTableAdapters.Work_in_viewTableAdapter
    Friend WithEvents MedicationBindingSource As BindingSource
    Friend WithEvents MedicationTableAdapter As wellmeadows_hospitalDataSetTableAdapters.MedicationTableAdapter
    Friend WithEvents MedicationBindingSource1 As BindingSource
    Friend WithEvents Staff As TabPage
    Friend WithEvents PositiontpyeComboBox As ComboBox
    Friend WithEvents PaidComboBox As ComboBox
    Friend WithEvents SexComboBox As ComboBox
    Friend WithEvents staffsearch As Button
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
    Friend WithEvents staffdetails As Label
    Friend WithEvents Picturecoler2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents textBoxsearch As TextBox
    Friend WithEvents QulificationBindingSource As BindingSource
    Friend WithEvents QulificationTableAdapter As wellmeadows_hospitalDataSetTableAdapters.qulificationTableAdapter
    Friend WithEvents experience As Button
    Friend WithEvents qualification As Button
End Class
