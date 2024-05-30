<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormWard
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
        Dim WardIDLabel As System.Windows.Forms.Label
        Dim WardnameLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim Total_roomLabel As System.Windows.Forms.Label
        Dim Tel_ExtnLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormWard))
        Me.Wellmeadows_hospitalDataSet = New project_g11.wellmeadows_hospitalDataSet()
        Me.WardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WardsTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.WardsTableAdapter()
        Me.TableAdapterManager = New project_g11.wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager()
        Me.WardsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.WardsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.WardIDTextBox = New System.Windows.Forms.TextBox()
        Me.WardnameTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Total_roomTextBox = New System.Windows.Forms.TextBox()
        Me.Tel_ExtnTextBox = New System.Windows.Forms.TextBox()
        Me.wardsearch = New System.Windows.Forms.Button()
        Me.textsearch = New System.Windows.Forms.TextBox()
        Me.Work_in_viewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Work_in_viewTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.Work_in_viewTableAdapter()
        Me.Work_in_viewDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shift = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        WardIDLabel = New System.Windows.Forms.Label()
        WardnameLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        Total_roomLabel = New System.Windows.Forms.Label()
        Tel_ExtnLabel = New System.Windows.Forms.Label()
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WardsBindingNavigator.SuspendLayout()
        CType(Me.Work_in_viewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Work_in_viewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WardIDLabel
        '
        WardIDLabel.AutoSize = True
        WardIDLabel.BackColor = System.Drawing.Color.Transparent
        WardIDLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        WardIDLabel.Location = New System.Drawing.Point(152, 185)
        WardIDLabel.Name = "WardIDLabel"
        WardIDLabel.Size = New System.Drawing.Size(76, 31)
        WardIDLabel.TabIndex = 1
        WardIDLabel.Text = "Ward ID:"
        '
        'WardnameLabel
        '
        WardnameLabel.AutoSize = True
        WardnameLabel.BackColor = System.Drawing.Color.Transparent
        WardnameLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        WardnameLabel.Location = New System.Drawing.Point(635, 185)
        WardnameLabel.Name = "WardnameLabel"
        WardnameLabel.Size = New System.Drawing.Size(104, 31)
        WardnameLabel.TabIndex = 3
        WardnameLabel.Text = "Ward Name:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.BackColor = System.Drawing.Color.Transparent
        LocationLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        LocationLabel.Location = New System.Drawing.Point(148, 241)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(80, 31)
        LocationLabel.TabIndex = 5
        LocationLabel.Text = "Location:"
        '
        'Total_roomLabel
        '
        Total_roomLabel.AutoSize = True
        Total_roomLabel.BackColor = System.Drawing.Color.Transparent
        Total_roomLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Total_roomLabel.Location = New System.Drawing.Point(635, 246)
        Total_roomLabel.Name = "Total_roomLabel"
        Total_roomLabel.Size = New System.Drawing.Size(102, 31)
        Total_roomLabel.TabIndex = 7
        Total_roomLabel.Text = "Total Room:"
        '
        'Tel_ExtnLabel
        '
        Tel_ExtnLabel.AutoSize = True
        Tel_ExtnLabel.BackColor = System.Drawing.Color.Transparent
        Tel_ExtnLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Tel_ExtnLabel.Location = New System.Drawing.Point(148, 302)
        Tel_ExtnLabel.Name = "Tel_ExtnLabel"
        Tel_ExtnLabel.Size = New System.Drawing.Size(78, 31)
        Tel_ExtnLabel.TabIndex = 9
        Tel_ExtnLabel.Text = "Tel Extn:"
        '
        'Wellmeadows_hospitalDataSet
        '
        Me.Wellmeadows_hospitalDataSet.DataSetName = "wellmeadows_hospitalDataSet"
        Me.Wellmeadows_hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WardsBindingSource
        '
        Me.WardsBindingSource.DataMember = "Wards"
        Me.WardsBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'WardsTableAdapter
        '
        Me.WardsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.roomTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.TreatmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = project_g11.wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardsTableAdapter = Me.WardsTableAdapter
        Me.TableAdapterManager.Work_inTableAdapter = Nothing
        '
        'WardsBindingNavigator
        '
        Me.WardsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WardsBindingNavigator.BindingSource = Me.WardsBindingSource
        Me.WardsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.WardsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WardsBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.WardsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WardsBindingNavigatorSaveItem})
        Me.WardsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WardsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WardsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WardsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WardsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WardsBindingNavigator.Name = "WardsBindingNavigator"
        Me.WardsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WardsBindingNavigator.Size = New System.Drawing.Size(1164, 27)
        Me.WardsBindingNavigator.TabIndex = 0
        Me.WardsBindingNavigator.Text = "BindingNavigator1"
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
        'WardsBindingNavigatorSaveItem
        '
        Me.WardsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WardsBindingNavigatorSaveItem.Image = CType(resources.GetObject("WardsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WardsBindingNavigatorSaveItem.Name = "WardsBindingNavigatorSaveItem"
        Me.WardsBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.WardsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'WardIDTextBox
        '
        Me.WardIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "wardID", True))
        Me.WardIDTextBox.Location = New System.Drawing.Point(269, 194)
        Me.WardIDTextBox.Name = "WardIDTextBox"
        Me.WardIDTextBox.Size = New System.Drawing.Size(300, 22)
        Me.WardIDTextBox.TabIndex = 2
        '
        'WardnameTextBox
        '
        Me.WardnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "wardname", True))
        Me.WardnameTextBox.Location = New System.Drawing.Point(772, 189)
        Me.WardnameTextBox.Name = "WardnameTextBox"
        Me.WardnameTextBox.Size = New System.Drawing.Size(300, 22)
        Me.WardnameTextBox.TabIndex = 4
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(269, 250)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(300, 22)
        Me.LocationTextBox.TabIndex = 6
        '
        'Total_roomTextBox
        '
        Me.Total_roomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "total_room", True))
        Me.Total_roomTextBox.Location = New System.Drawing.Point(772, 250)
        Me.Total_roomTextBox.Name = "Total_roomTextBox"
        Me.Total_roomTextBox.Size = New System.Drawing.Size(300, 22)
        Me.Total_roomTextBox.TabIndex = 8
        '
        'Tel_ExtnTextBox
        '
        Me.Tel_ExtnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "tel_Extn", True))
        Me.Tel_ExtnTextBox.Location = New System.Drawing.Point(269, 306)
        Me.Tel_ExtnTextBox.Name = "Tel_ExtnTextBox"
        Me.Tel_ExtnTextBox.Size = New System.Drawing.Size(300, 22)
        Me.Tel_ExtnTextBox.TabIndex = 10
        '
        'wardsearch
        '
        Me.wardsearch.BackColor = System.Drawing.Color.White
        Me.wardsearch.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.wardsearch.ForeColor = System.Drawing.Color.Black
        Me.wardsearch.Location = New System.Drawing.Point(1038, 18)
        Me.wardsearch.Name = "wardsearch"
        Me.wardsearch.Size = New System.Drawing.Size(114, 38)
        Me.wardsearch.TabIndex = 47
        Me.wardsearch.Text = "Search"
        Me.wardsearch.UseVisualStyleBackColor = False
        '
        'textsearch
        '
        Me.textsearch.BackColor = System.Drawing.SystemColors.Menu
        Me.textsearch.Location = New System.Drawing.Point(732, 26)
        Me.textsearch.Name = "textsearch"
        Me.textsearch.Size = New System.Drawing.Size(300, 22)
        Me.textsearch.TabIndex = 46
        '
        'Work_in_viewBindingSource
        '
        Me.Work_in_viewBindingSource.DataMember = "Work_in_view"
        Me.Work_in_viewBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'Work_in_viewTableAdapter
        '
        Me.Work_in_viewTableAdapter.ClearBeforeFill = True
        '
        'Work_in_viewDataGridView
        '
        Me.Work_in_viewDataGridView.AutoGenerateColumns = False
        Me.Work_in_viewDataGridView.BackgroundColor = System.Drawing.Color.Ivory
        Me.Work_in_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Work_in_viewDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Work_in_viewDataGridView.DataSource = Me.Work_in_viewBindingSource
        Me.Work_in_viewDataGridView.Location = New System.Drawing.Point(218, 377)
        Me.Work_in_viewDataGridView.Name = "Work_in_viewDataGridView"
        Me.Work_in_viewDataGridView.RowHeadersWidth = 51
        Me.Work_in_viewDataGridView.RowTemplate.Height = 24
        Me.Work_in_viewDataGridView.Size = New System.Drawing.Size(712, 220)
        Me.Work_in_viewDataGridView.TabIndex = 47
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "staffID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "staffID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "staffName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "staffName"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "wardID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "wardID"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "wardName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "wardName"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "shift"
        Me.DataGridViewTextBoxColumn5.HeaderText = "shift"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'shift
        '
        Me.shift.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.shift.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.shift.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.shift.Location = New System.Drawing.Point(493, 631)
        Me.shift.Name = "shift"
        Me.shift.Size = New System.Drawing.Size(208, 47)
        Me.shift.TabIndex = 48
        Me.shift.Text = "Shift"
        Me.shift.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.textsearch)
        Me.Panel1.Controls.Add(Me.wardsearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1164, 67)
        Me.Panel1.TabIndex = 49
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.project_g11.My.Resources.Resources.png_clipart_button_arrow_back_arrow_blue_trademark_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(30, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("TH SarabunPSK", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(552, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 37)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "ข้อมูล Ward"
        '
        'FormWard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.project_g11.My.Resources.Resources.พื้นหลังงงง
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1164, 753)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.shift)
        Me.Controls.Add(Me.Work_in_viewDataGridView)
        Me.Controls.Add(WardIDLabel)
        Me.Controls.Add(Me.WardIDTextBox)
        Me.Controls.Add(WardnameLabel)
        Me.Controls.Add(Me.WardnameTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Total_roomLabel)
        Me.Controls.Add(Me.Total_roomTextBox)
        Me.Controls.Add(Tel_ExtnLabel)
        Me.Controls.Add(Me.Tel_ExtnTextBox)
        Me.Controls.Add(Me.WardsBindingNavigator)
        Me.Name = "FormWard"
        Me.Text = "FormWard"
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WardsBindingNavigator.ResumeLayout(False)
        Me.WardsBindingNavigator.PerformLayout()
        CType(Me.Work_in_viewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Work_in_viewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Wellmeadows_hospitalDataSet As wellmeadows_hospitalDataSet
    Friend WithEvents WardsBindingSource As BindingSource
    Friend WithEvents WardsTableAdapter As wellmeadows_hospitalDataSetTableAdapters.WardsTableAdapter
    Friend WithEvents TableAdapterManager As wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WardsBindingNavigator As BindingNavigator
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
    Friend WithEvents WardsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents WardIDTextBox As TextBox
    Friend WithEvents WardnameTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents Total_roomTextBox As TextBox
    Friend WithEvents Tel_ExtnTextBox As TextBox
    Friend WithEvents wardsearch As Button
    Friend WithEvents textsearch As TextBox
    Friend WithEvents Work_in_viewBindingSource As BindingSource
    Friend WithEvents Work_in_viewTableAdapter As wellmeadows_hospitalDataSetTableAdapters.Work_in_viewTableAdapter
    Friend WithEvents Work_in_viewDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents shift As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
