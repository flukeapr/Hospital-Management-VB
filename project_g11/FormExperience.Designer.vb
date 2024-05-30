<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExperience
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
        Dim OrganizationLabel As System.Windows.Forms.Label
        Dim Position_pastLabel As System.Windows.Forms.Label
        Dim Start_dateLabel As System.Windows.Forms.Label
        Dim Finish_dateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormExperience))
        Me.Wellmeadows_hospitalDataSet = New project_g11.wellmeadows_hospitalDataSet()
        Me.Work_experienceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Work_experienceTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.work_experienceTableAdapter()
        Me.TableAdapterManager = New project_g11.wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager()
        Me.Work_experienceBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Work_experienceBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StaffIDTextBox = New System.Windows.Forms.TextBox()
        Me.OrganizationTextBox = New System.Windows.Forms.TextBox()
        Me.Position_pastTextBox = New System.Windows.Forms.TextBox()
        Me.Start_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Finish_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.experience = New System.Windows.Forms.Label()
        Me.TextBoxsearch = New System.Windows.Forms.TextBox()
        Me.Buttonsearch = New System.Windows.Forms.Button()
        StaffIDLabel = New System.Windows.Forms.Label()
        OrganizationLabel = New System.Windows.Forms.Label()
        Position_pastLabel = New System.Windows.Forms.Label()
        Start_dateLabel = New System.Windows.Forms.Label()
        Finish_dateLabel = New System.Windows.Forms.Label()
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Work_experienceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Work_experienceBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Work_experienceBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'StaffIDLabel
        '
        StaffIDLabel.AutoSize = True
        StaffIDLabel.BackColor = System.Drawing.Color.Transparent
        StaffIDLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        StaffIDLabel.Location = New System.Drawing.Point(178, 131)
        StaffIDLabel.Name = "StaffIDLabel"
        StaffIDLabel.Size = New System.Drawing.Size(72, 31)
        StaffIDLabel.TabIndex = 1
        StaffIDLabel.Text = "Staff ID:"
        '
        'OrganizationLabel
        '
        OrganizationLabel.AutoSize = True
        OrganizationLabel.BackColor = System.Drawing.Color.Transparent
        OrganizationLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        OrganizationLabel.Location = New System.Drawing.Point(141, 173)
        OrganizationLabel.Name = "OrganizationLabel"
        OrganizationLabel.Size = New System.Drawing.Size(111, 31)
        OrganizationLabel.TabIndex = 3
        OrganizationLabel.Text = "Organization:"
        '
        'Position_pastLabel
        '
        Position_pastLabel.AutoSize = True
        Position_pastLabel.BackColor = System.Drawing.Color.Transparent
        Position_pastLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Position_pastLabel.Location = New System.Drawing.Point(136, 208)
        Position_pastLabel.Name = "Position_pastLabel"
        Position_pastLabel.Size = New System.Drawing.Size(111, 31)
        Position_pastLabel.TabIndex = 5
        Position_pastLabel.Text = "Position Past:"
        '
        'Start_dateLabel
        '
        Start_dateLabel.AutoSize = True
        Start_dateLabel.BackColor = System.Drawing.Color.Transparent
        Start_dateLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Start_dateLabel.Location = New System.Drawing.Point(160, 254)
        Start_dateLabel.Name = "Start_dateLabel"
        Start_dateLabel.Size = New System.Drawing.Size(91, 31)
        Start_dateLabel.TabIndex = 7
        Start_dateLabel.Text = "Start Date:"
        '
        'Finish_dateLabel
        '
        Finish_dateLabel.AutoSize = True
        Finish_dateLabel.BackColor = System.Drawing.Color.Transparent
        Finish_dateLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Finish_dateLabel.Location = New System.Drawing.Point(153, 295)
        Finish_dateLabel.Name = "Finish_dateLabel"
        Finish_dateLabel.Size = New System.Drawing.Size(100, 31)
        Finish_dateLabel.TabIndex = 9
        Finish_dateLabel.Text = "Finish Date:"
        '
        'Wellmeadows_hospitalDataSet
        '
        Me.Wellmeadows_hospitalDataSet.DataSetName = "wellmeadows_hospitalDataSet"
        Me.Wellmeadows_hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Work_experienceBindingSource
        '
        Me.Work_experienceBindingSource.DataMember = "work_experience"
        Me.Work_experienceBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'Work_experienceTableAdapter
        '
        Me.Work_experienceTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.TreatmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = project_g11.wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.work_experienceTableAdapter = Me.Work_experienceTableAdapter
        Me.TableAdapterManager.Work_inTableAdapter = Nothing
        '
        'Work_experienceBindingNavigator
        '
        Me.Work_experienceBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Work_experienceBindingNavigator.BindingSource = Me.Work_experienceBindingSource
        Me.Work_experienceBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Work_experienceBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Work_experienceBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Work_experienceBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Work_experienceBindingNavigatorSaveItem})
        Me.Work_experienceBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Work_experienceBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Work_experienceBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Work_experienceBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Work_experienceBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Work_experienceBindingNavigator.Name = "Work_experienceBindingNavigator"
        Me.Work_experienceBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Work_experienceBindingNavigator.Size = New System.Drawing.Size(800, 31)
        Me.Work_experienceBindingNavigator.TabIndex = 0
        Me.Work_experienceBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
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
        'Work_experienceBindingNavigatorSaveItem
        '
        Me.Work_experienceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Work_experienceBindingNavigatorSaveItem.Image = CType(resources.GetObject("Work_experienceBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Work_experienceBindingNavigatorSaveItem.Name = "Work_experienceBindingNavigatorSaveItem"
        Me.Work_experienceBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.Work_experienceBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StaffIDTextBox
        '
        Me.StaffIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Work_experienceBindingSource, "staffID", True))
        Me.StaffIDTextBox.Location = New System.Drawing.Point(292, 135)
        Me.StaffIDTextBox.Name = "StaffIDTextBox"
        Me.StaffIDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.StaffIDTextBox.TabIndex = 2
        '
        'OrganizationTextBox
        '
        Me.OrganizationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Work_experienceBindingSource, "organization", True))
        Me.OrganizationTextBox.Location = New System.Drawing.Point(292, 173)
        Me.OrganizationTextBox.Name = "OrganizationTextBox"
        Me.OrganizationTextBox.Size = New System.Drawing.Size(200, 22)
        Me.OrganizationTextBox.TabIndex = 4
        '
        'Position_pastTextBox
        '
        Me.Position_pastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Work_experienceBindingSource, "position_past", True))
        Me.Position_pastTextBox.Location = New System.Drawing.Point(292, 212)
        Me.Position_pastTextBox.Name = "Position_pastTextBox"
        Me.Position_pastTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Position_pastTextBox.TabIndex = 6
        '
        'Start_dateDateTimePicker
        '
        Me.Start_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Work_experienceBindingSource, "start_date", True))
        Me.Start_dateDateTimePicker.Location = New System.Drawing.Point(292, 256)
        Me.Start_dateDateTimePicker.Name = "Start_dateDateTimePicker"
        Me.Start_dateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Start_dateDateTimePicker.TabIndex = 8
        '
        'Finish_dateDateTimePicker
        '
        Me.Finish_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Work_experienceBindingSource, "finish_date", True))
        Me.Finish_dateDateTimePicker.Location = New System.Drawing.Point(292, 295)
        Me.Finish_dateDateTimePicker.Name = "Finish_dateDateTimePicker"
        Me.Finish_dateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Finish_dateDateTimePicker.TabIndex = 10
        '
        'experience
        '
        Me.experience.AutoSize = True
        Me.experience.BackColor = System.Drawing.Color.Transparent
        Me.experience.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.experience.Location = New System.Drawing.Point(285, 49)
        Me.experience.Name = "experience"
        Me.experience.Size = New System.Drawing.Size(122, 40)
        Me.experience.TabIndex = 11
        Me.experience.Text = "Experience"
        '
        'TextBoxsearch
        '
        Me.TextBoxsearch.Location = New System.Drawing.Point(475, 59)
        Me.TextBoxsearch.Name = "TextBoxsearch"
        Me.TextBoxsearch.Size = New System.Drawing.Size(161, 22)
        Me.TextBoxsearch.TabIndex = 12
        '
        'Buttonsearch
        '
        Me.Buttonsearch.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Buttonsearch.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Buttonsearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Buttonsearch.Location = New System.Drawing.Point(642, 52)
        Me.Buttonsearch.Name = "Buttonsearch"
        Me.Buttonsearch.Size = New System.Drawing.Size(88, 37)
        Me.Buttonsearch.TabIndex = 13
        Me.Buttonsearch.Text = "Search"
        Me.Buttonsearch.UseVisualStyleBackColor = False
        '
        'FormExperience
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.project_g11.My.Resources.Resources.พื้นหลังงงง
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Buttonsearch)
        Me.Controls.Add(Me.TextBoxsearch)
        Me.Controls.Add(Me.experience)
        Me.Controls.Add(StaffIDLabel)
        Me.Controls.Add(Me.StaffIDTextBox)
        Me.Controls.Add(OrganizationLabel)
        Me.Controls.Add(Me.OrganizationTextBox)
        Me.Controls.Add(Position_pastLabel)
        Me.Controls.Add(Me.Position_pastTextBox)
        Me.Controls.Add(Start_dateLabel)
        Me.Controls.Add(Me.Start_dateDateTimePicker)
        Me.Controls.Add(Finish_dateLabel)
        Me.Controls.Add(Me.Finish_dateDateTimePicker)
        Me.Controls.Add(Me.Work_experienceBindingNavigator)
        Me.Name = "FormExperience"
        Me.Text = "FormExperience"
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Work_experienceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Work_experienceBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Work_experienceBindingNavigator.ResumeLayout(False)
        Me.Work_experienceBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Wellmeadows_hospitalDataSet As wellmeadows_hospitalDataSet
    Friend WithEvents Work_experienceBindingSource As BindingSource
    Friend WithEvents Work_experienceTableAdapter As wellmeadows_hospitalDataSetTableAdapters.work_experienceTableAdapter
    Friend WithEvents TableAdapterManager As wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Work_experienceBindingNavigator As BindingNavigator
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
    Friend WithEvents Work_experienceBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents StaffIDTextBox As TextBox
    Friend WithEvents OrganizationTextBox As TextBox
    Friend WithEvents Position_pastTextBox As TextBox
    Friend WithEvents Start_dateDateTimePicker As DateTimePicker
    Friend WithEvents Finish_dateDateTimePicker As DateTimePicker
    Friend WithEvents experience As Label
    Friend WithEvents TextBoxsearch As TextBox
    Friend WithEvents Buttonsearch As Button
End Class
