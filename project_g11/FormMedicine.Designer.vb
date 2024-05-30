<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMedicine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StaffIDLabel As System.Windows.Forms.Label
        Dim StaffNameLabel As System.Windows.Forms.Label
        Dim DrugIDLabel As System.Windows.Forms.Label
        Dim Drug_nameLabel As System.Windows.Forms.Label
        Dim Method_of_administrationLabel As System.Windows.Forms.Label
        Dim DescriptionsLabel As System.Windows.Forms.Label
        Dim EattimeLabel As System.Windows.Forms.Label
        Dim DosageLabel As System.Windows.Forms.Label
        Dim Cost_per_unitLabel As System.Windows.Forms.Label
        Dim Quantity_in_stockLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMedicine))
        Me.Wellmeadows_hospitalDataSet = New project_g11.wellmeadows_hospitalDataSet()
        Me.MedicineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicineTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.medicineTableAdapter()
        Me.TableAdapterManager = New project_g11.wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager()
        Me.MedicineBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MedicineBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StaffIDTextBox = New System.Windows.Forms.TextBox()
        Me.StaffNameTextBox = New System.Windows.Forms.TextBox()
        Me.DrugIDTextBox = New System.Windows.Forms.TextBox()
        Me.Drug_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Method_of_administrationTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionsTextBox = New System.Windows.Forms.TextBox()
        Me.EattimeTextBox = New System.Windows.Forms.TextBox()
        Me.DosageTextBox = New System.Windows.Forms.TextBox()
        Me.Cost_per_unitTextBox = New System.Windows.Forms.TextBox()
        Me.Quantity_in_stockTextBox = New System.Windows.Forms.TextBox()
        Me.btbmedcine = New System.Windows.Forms.Button()
        Me.textsearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        StaffIDLabel = New System.Windows.Forms.Label()
        StaffNameLabel = New System.Windows.Forms.Label()
        DrugIDLabel = New System.Windows.Forms.Label()
        Drug_nameLabel = New System.Windows.Forms.Label()
        Method_of_administrationLabel = New System.Windows.Forms.Label()
        DescriptionsLabel = New System.Windows.Forms.Label()
        EattimeLabel = New System.Windows.Forms.Label()
        DosageLabel = New System.Windows.Forms.Label()
        Cost_per_unitLabel = New System.Windows.Forms.Label()
        Quantity_in_stockLabel = New System.Windows.Forms.Label()
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MedicineBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StaffIDLabel
        '
        StaffIDLabel.AutoSize = True
        StaffIDLabel.BackColor = System.Drawing.Color.Transparent
        StaffIDLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        StaffIDLabel.Location = New System.Drawing.Point(211, 513)
        StaffIDLabel.Name = "StaffIDLabel"
        StaffIDLabel.Size = New System.Drawing.Size(72, 31)
        StaffIDLabel.TabIndex = 1
        StaffIDLabel.Text = "Staff ID:"
        '
        'StaffNameLabel
        '
        StaffNameLabel.AutoSize = True
        StaffNameLabel.BackColor = System.Drawing.Color.Transparent
        StaffNameLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        StaffNameLabel.Location = New System.Drawing.Point(692, 518)
        StaffNameLabel.Name = "StaffNameLabel"
        StaffNameLabel.Size = New System.Drawing.Size(100, 31)
        StaffNameLabel.TabIndex = 3
        StaffNameLabel.Text = "Staff Name:"
        '
        'DrugIDLabel
        '
        DrugIDLabel.AutoSize = True
        DrugIDLabel.BackColor = System.Drawing.Color.Transparent
        DrugIDLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DrugIDLabel.Location = New System.Drawing.Point(212, 171)
        DrugIDLabel.Name = "DrugIDLabel"
        DrugIDLabel.Size = New System.Drawing.Size(73, 31)
        DrugIDLabel.TabIndex = 5
        DrugIDLabel.Text = "Drug ID:"
        '
        'Drug_nameLabel
        '
        Drug_nameLabel.AutoSize = True
        Drug_nameLabel.BackColor = System.Drawing.Color.Transparent
        Drug_nameLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Drug_nameLabel.Location = New System.Drawing.Point(692, 171)
        Drug_nameLabel.Name = "Drug_nameLabel"
        Drug_nameLabel.Size = New System.Drawing.Size(101, 31)
        Drug_nameLabel.TabIndex = 7
        Drug_nameLabel.Text = "Drug Name:"
        '
        'Method_of_administrationLabel
        '
        Method_of_administrationLabel.AutoSize = True
        Method_of_administrationLabel.BackColor = System.Drawing.Color.Transparent
        Method_of_administrationLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Method_of_administrationLabel.Location = New System.Drawing.Point(76, 214)
        Method_of_administrationLabel.Name = "Method_of_administrationLabel"
        Method_of_administrationLabel.Size = New System.Drawing.Size(209, 31)
        Method_of_administrationLabel.TabIndex = 9
        Method_of_administrationLabel.Text = "Method of Administration:"
        '
        'DescriptionsLabel
        '
        DescriptionsLabel.AutoSize = True
        DescriptionsLabel.BackColor = System.Drawing.Color.Transparent
        DescriptionsLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DescriptionsLabel.Location = New System.Drawing.Point(174, 309)
        DescriptionsLabel.Name = "DescriptionsLabel"
        DescriptionsLabel.Size = New System.Drawing.Size(109, 31)
        DescriptionsLabel.TabIndex = 11
        DescriptionsLabel.Text = "Descriptions:"
        '
        'EattimeLabel
        '
        EattimeLabel.AutoSize = True
        EattimeLabel.BackColor = System.Drawing.Color.Transparent
        EattimeLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        EattimeLabel.Location = New System.Drawing.Point(208, 356)
        EattimeLabel.Name = "EattimeLabel"
        EattimeLabel.Size = New System.Drawing.Size(74, 31)
        EattimeLabel.TabIndex = 13
        EattimeLabel.Text = "Eattime:"
        '
        'DosageLabel
        '
        DosageLabel.AutoSize = True
        DosageLabel.BackColor = System.Drawing.Color.Transparent
        DosageLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DosageLabel.Location = New System.Drawing.Point(722, 221)
        DosageLabel.Name = "DosageLabel"
        DosageLabel.Size = New System.Drawing.Size(70, 31)
        DosageLabel.TabIndex = 15
        DosageLabel.Text = "Dosage:"
        '
        'Cost_per_unitLabel
        '
        Cost_per_unitLabel.AutoSize = True
        Cost_per_unitLabel.BackColor = System.Drawing.Color.Transparent
        Cost_per_unitLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Cost_per_unitLabel.Location = New System.Drawing.Point(169, 264)
        Cost_per_unitLabel.Name = "Cost_per_unitLabel"
        Cost_per_unitLabel.Size = New System.Drawing.Size(115, 31)
        Cost_per_unitLabel.TabIndex = 17
        Cost_per_unitLabel.Text = "Cost Per Unit:"
        '
        'Quantity_in_stockLabel
        '
        Quantity_in_stockLabel.AutoSize = True
        Quantity_in_stockLabel.BackColor = System.Drawing.Color.Transparent
        Quantity_in_stockLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Quantity_in_stockLabel.Location = New System.Drawing.Point(647, 271)
        Quantity_in_stockLabel.Name = "Quantity_in_stockLabel"
        Quantity_in_stockLabel.Size = New System.Drawing.Size(145, 31)
        Quantity_in_stockLabel.TabIndex = 19
        Quantity_in_stockLabel.Text = "Quantity in Stock:"
        '
        'Wellmeadows_hospitalDataSet
        '
        Me.Wellmeadows_hospitalDataSet.DataSetName = "wellmeadows_hospitalDataSet"
        Me.Wellmeadows_hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicineBindingSource
        '
        Me.MedicineBindingSource.DataMember = "medicine"
        Me.MedicineBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'MedicineTableAdapter
        '
        Me.MedicineTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.admitted_wardTableAdapter = Nothing
        Me.TableAdapterManager.apply_wardsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bedTableAdapter = Nothing
        Me.TableAdapterManager.MedicationTableAdapter = Nothing
        Me.TableAdapterManager.medicineTableAdapter = Me.MedicineTableAdapter
        Me.TableAdapterManager.patientTableAdapter = Nothing
        Me.TableAdapterManager.qulificationTableAdapter = Nothing
        Me.TableAdapterManager.roomTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.TreatmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = project_g11.wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.work_experienceTableAdapter = Nothing
        Me.TableAdapterManager.Work_inTableAdapter = Nothing
        '
        'MedicineBindingNavigator
        '
        Me.MedicineBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MedicineBindingNavigator.BindingSource = Me.MedicineBindingSource
        Me.MedicineBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MedicineBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MedicineBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MedicineBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MedicineBindingNavigatorSaveItem})
        Me.MedicineBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MedicineBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MedicineBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MedicineBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MedicineBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MedicineBindingNavigator.Name = "MedicineBindingNavigator"
        Me.MedicineBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MedicineBindingNavigator.Size = New System.Drawing.Size(1365, 27)
        Me.MedicineBindingNavigator.TabIndex = 0
        Me.MedicineBindingNavigator.Text = "BindingNavigator1"
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
        'MedicineBindingNavigatorSaveItem
        '
        Me.MedicineBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MedicineBindingNavigatorSaveItem.Image = CType(resources.GetObject("MedicineBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MedicineBindingNavigatorSaveItem.Name = "MedicineBindingNavigatorSaveItem"
        Me.MedicineBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.MedicineBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StaffIDTextBox
        '
        Me.StaffIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "staffID", True))
        Me.StaffIDTextBox.Location = New System.Drawing.Point(329, 522)
        Me.StaffIDTextBox.Name = "StaffIDTextBox"
        Me.StaffIDTextBox.Size = New System.Drawing.Size(258, 22)
        Me.StaffIDTextBox.TabIndex = 2
        '
        'StaffNameTextBox
        '
        Me.StaffNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "staffName", True))
        Me.StaffNameTextBox.Location = New System.Drawing.Point(815, 522)
        Me.StaffNameTextBox.Name = "StaffNameTextBox"
        Me.StaffNameTextBox.Size = New System.Drawing.Size(258, 22)
        Me.StaffNameTextBox.TabIndex = 4
        '
        'DrugIDTextBox
        '
        Me.DrugIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "drugID", True))
        Me.DrugIDTextBox.Location = New System.Drawing.Point(329, 177)
        Me.DrugIDTextBox.Name = "DrugIDTextBox"
        Me.DrugIDTextBox.Size = New System.Drawing.Size(258, 22)
        Me.DrugIDTextBox.TabIndex = 6
        '
        'Drug_nameTextBox
        '
        Me.Drug_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "drug_name", True))
        Me.Drug_nameTextBox.Location = New System.Drawing.Point(815, 180)
        Me.Drug_nameTextBox.Name = "Drug_nameTextBox"
        Me.Drug_nameTextBox.Size = New System.Drawing.Size(258, 22)
        Me.Drug_nameTextBox.TabIndex = 8
        '
        'Method_of_administrationTextBox
        '
        Me.Method_of_administrationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "method_of_administration", True))
        Me.Method_of_administrationTextBox.Location = New System.Drawing.Point(329, 218)
        Me.Method_of_administrationTextBox.Name = "Method_of_administrationTextBox"
        Me.Method_of_administrationTextBox.Size = New System.Drawing.Size(258, 22)
        Me.Method_of_administrationTextBox.TabIndex = 10
        '
        'DescriptionsTextBox
        '
        Me.DescriptionsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "descriptions", True))
        Me.DescriptionsTextBox.Location = New System.Drawing.Point(329, 313)
        Me.DescriptionsTextBox.Name = "DescriptionsTextBox"
        Me.DescriptionsTextBox.Size = New System.Drawing.Size(744, 22)
        Me.DescriptionsTextBox.TabIndex = 12
        '
        'EattimeTextBox
        '
        Me.EattimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "Eattime", True))
        Me.EattimeTextBox.Location = New System.Drawing.Point(329, 360)
        Me.EattimeTextBox.Name = "EattimeTextBox"
        Me.EattimeTextBox.Size = New System.Drawing.Size(744, 22)
        Me.EattimeTextBox.TabIndex = 14
        '
        'DosageTextBox
        '
        Me.DosageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "dosage", True))
        Me.DosageTextBox.Location = New System.Drawing.Point(815, 221)
        Me.DosageTextBox.Name = "DosageTextBox"
        Me.DosageTextBox.Size = New System.Drawing.Size(258, 22)
        Me.DosageTextBox.TabIndex = 16
        '
        'Cost_per_unitTextBox
        '
        Me.Cost_per_unitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "cost_per_unit", True))
        Me.Cost_per_unitTextBox.Location = New System.Drawing.Point(329, 268)
        Me.Cost_per_unitTextBox.Name = "Cost_per_unitTextBox"
        Me.Cost_per_unitTextBox.Size = New System.Drawing.Size(258, 22)
        Me.Cost_per_unitTextBox.TabIndex = 18
        '
        'Quantity_in_stockTextBox
        '
        Me.Quantity_in_stockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "quantity_in_stock", True))
        Me.Quantity_in_stockTextBox.Location = New System.Drawing.Point(815, 271)
        Me.Quantity_in_stockTextBox.Name = "Quantity_in_stockTextBox"
        Me.Quantity_in_stockTextBox.Size = New System.Drawing.Size(258, 22)
        Me.Quantity_in_stockTextBox.TabIndex = 20
        '
        'btbmedcine
        '
        Me.btbmedcine.BackColor = System.Drawing.Color.White
        Me.btbmedcine.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btbmedcine.ForeColor = System.Drawing.Color.Black
        Me.btbmedcine.Location = New System.Drawing.Point(1144, 22)
        Me.btbmedcine.Name = "btbmedcine"
        Me.btbmedcine.Size = New System.Drawing.Size(114, 38)
        Me.btbmedcine.TabIndex = 47
        Me.btbmedcine.Text = "Search"
        Me.btbmedcine.UseVisualStyleBackColor = False
        '
        'textsearch
        '
        Me.textsearch.BackColor = System.Drawing.SystemColors.Menu
        Me.textsearch.Location = New System.Drawing.Point(815, 30)
        Me.textsearch.Name = "textsearch"
        Me.textsearch.Size = New System.Drawing.Size(299, 22)
        Me.textsearch.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("TH SarabunPSK", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(557, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 45)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "คลังข้อมูลยา"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.textsearch)
        Me.Panel1.Controls.Add(Me.btbmedcine)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1365, 80)
        Me.Panel1.TabIndex = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.project_g11.My.Resources.Resources.png_clipart_button_arrow_back_arrow_blue_trademark_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(82, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("TH SarabunPSK", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(512, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 45)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "เจ้าหน้าที่กรอกข้อมูลยา"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 412)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1395, 78)
        Me.Panel2.TabIndex = 51
        '
        'FormMedicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.project_g11.My.Resources.Resources.พื้นหลังงงง
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1365, 790)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(StaffIDLabel)
        Me.Controls.Add(Me.StaffIDTextBox)
        Me.Controls.Add(StaffNameLabel)
        Me.Controls.Add(Me.StaffNameTextBox)
        Me.Controls.Add(DrugIDLabel)
        Me.Controls.Add(Me.DrugIDTextBox)
        Me.Controls.Add(Drug_nameLabel)
        Me.Controls.Add(Me.Drug_nameTextBox)
        Me.Controls.Add(Method_of_administrationLabel)
        Me.Controls.Add(Me.Method_of_administrationTextBox)
        Me.Controls.Add(DescriptionsLabel)
        Me.Controls.Add(Me.DescriptionsTextBox)
        Me.Controls.Add(EattimeLabel)
        Me.Controls.Add(Me.EattimeTextBox)
        Me.Controls.Add(DosageLabel)
        Me.Controls.Add(Me.DosageTextBox)
        Me.Controls.Add(Cost_per_unitLabel)
        Me.Controls.Add(Me.Cost_per_unitTextBox)
        Me.Controls.Add(Quantity_in_stockLabel)
        Me.Controls.Add(Me.Quantity_in_stockTextBox)
        Me.Controls.Add(Me.MedicineBindingNavigator)
        Me.Name = "FormMedicine"
        Me.Text = "FormMedicine"
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicineBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MedicineBindingNavigator.ResumeLayout(False)
        Me.MedicineBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Wellmeadows_hospitalDataSet As wellmeadows_hospitalDataSet
    Friend WithEvents MedicineBindingSource As BindingSource
    Friend WithEvents MedicineTableAdapter As wellmeadows_hospitalDataSetTableAdapters.medicineTableAdapter
    Friend WithEvents TableAdapterManager As wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MedicineBindingNavigator As BindingNavigator
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
    Friend WithEvents MedicineBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents StaffIDTextBox As TextBox
    Friend WithEvents StaffNameTextBox As TextBox
    Friend WithEvents DrugIDTextBox As TextBox
    Friend WithEvents Drug_nameTextBox As TextBox
    Friend WithEvents Method_of_administrationTextBox As TextBox
    Friend WithEvents DescriptionsTextBox As TextBox
    Friend WithEvents EattimeTextBox As TextBox
    Friend WithEvents DosageTextBox As TextBox
    Friend WithEvents Cost_per_unitTextBox As TextBox
    Friend WithEvents Quantity_in_stockTextBox As TextBox
    Friend WithEvents btbmedcine As Button
    Friend WithEvents textsearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
