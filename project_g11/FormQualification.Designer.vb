<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQualification
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
        Dim TypeLabel As System.Windows.Forms.Label
        Dim InstitutionLabel As System.Windows.Forms.Label
        Dim Graduation_DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormQualification))
        Me.Wellmeadows_hospitalDataSet = New project_g11.wellmeadows_hospitalDataSet()
        Me.QulificationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QulificationTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.qulificationTableAdapter()
        Me.TableAdapterManager = New project_g11.wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager()
        Me.qualification = New System.Windows.Forms.Label()
        Me.TextBoxsearch = New System.Windows.Forms.TextBox()
        Me.Buttonsearch = New System.Windows.Forms.Button()
        Me.StaffIDTextBox = New System.Windows.Forms.TextBox()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.InstitutionTextBox = New System.Windows.Forms.TextBox()
        Me.Graduation_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.qualificationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        StaffIDLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        InstitutionLabel = New System.Windows.Forms.Label()
        Graduation_DateLabel = New System.Windows.Forms.Label()
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QulificationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qualificationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.qualificationBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'StaffIDLabel
        '
        StaffIDLabel.AutoSize = True
        StaffIDLabel.BackColor = System.Drawing.Color.Transparent
        StaffIDLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        StaffIDLabel.Location = New System.Drawing.Point(160, 183)
        StaffIDLabel.Name = "StaffIDLabel"
        StaffIDLabel.Size = New System.Drawing.Size(71, 31)
        StaffIDLabel.TabIndex = 12
        StaffIDLabel.Text = "staff ID:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.BackColor = System.Drawing.Color.Transparent
        TypeLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        TypeLabel.Location = New System.Drawing.Point(180, 220)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(51, 31)
        TypeLabel.TabIndex = 14
        TypeLabel.Text = "type:"
        '
        'InstitutionLabel
        '
        InstitutionLabel.AutoSize = True
        InstitutionLabel.BackColor = System.Drawing.Color.Transparent
        InstitutionLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        InstitutionLabel.Location = New System.Drawing.Point(137, 264)
        InstitutionLabel.Name = "InstitutionLabel"
        InstitutionLabel.Size = New System.Drawing.Size(94, 31)
        InstitutionLabel.TabIndex = 16
        InstitutionLabel.Text = "institution:"
        '
        'Graduation_DateLabel
        '
        Graduation_DateLabel.AutoSize = True
        Graduation_DateLabel.BackColor = System.Drawing.Color.Transparent
        Graduation_DateLabel.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Graduation_DateLabel.Location = New System.Drawing.Point(93, 308)
        Graduation_DateLabel.Name = "Graduation_DateLabel"
        Graduation_DateLabel.Size = New System.Drawing.Size(138, 31)
        Graduation_DateLabel.TabIndex = 18
        Graduation_DateLabel.Text = "Graduation Date:"
        '
        'Wellmeadows_hospitalDataSet
        '
        Me.Wellmeadows_hospitalDataSet.DataSetName = "wellmeadows_hospitalDataSet"
        Me.Wellmeadows_hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QulificationBindingSource
        '
        Me.QulificationBindingSource.DataMember = "qulification"
        Me.QulificationBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'QulificationTableAdapter
        '
        Me.QulificationTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.qulificationTableAdapter = Me.QulificationTableAdapter
        Me.TableAdapterManager.roomTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.TreatmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = project_g11.wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.work_experienceTableAdapter = Nothing
        Me.TableAdapterManager.Work_inTableAdapter = Nothing
        '
        'qualification
        '
        Me.qualification.AutoSize = True
        Me.qualification.BackColor = System.Drawing.Color.Transparent
        Me.qualification.Font = New System.Drawing.Font("TH SarabunPSK", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.qualification.Location = New System.Drawing.Point(299, 96)
        Me.qualification.Name = "qualification"
        Me.qualification.Size = New System.Drawing.Size(132, 37)
        Me.qualification.TabIndex = 10
        Me.qualification.Text = "Qualification"
        '
        'TextBoxsearch
        '
        Me.TextBoxsearch.Location = New System.Drawing.Point(486, 103)
        Me.TextBoxsearch.Name = "TextBoxsearch"
        Me.TextBoxsearch.Size = New System.Drawing.Size(161, 22)
        Me.TextBoxsearch.TabIndex = 11
        '
        'Buttonsearch
        '
        Me.Buttonsearch.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Buttonsearch.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Buttonsearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Buttonsearch.Location = New System.Drawing.Point(673, 99)
        Me.Buttonsearch.Name = "Buttonsearch"
        Me.Buttonsearch.Size = New System.Drawing.Size(88, 31)
        Me.Buttonsearch.TabIndex = 12
        Me.Buttonsearch.Text = "Search"
        Me.Buttonsearch.UseVisualStyleBackColor = False
        '
        'StaffIDTextBox
        '
        Me.StaffIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QulificationBindingSource, "staffID", True))
        Me.StaffIDTextBox.Location = New System.Drawing.Point(279, 183)
        Me.StaffIDTextBox.Name = "StaffIDTextBox"
        Me.StaffIDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.StaffIDTextBox.TabIndex = 13
        '
        'TypeTextBox
        '
        Me.TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QulificationBindingSource, "type", True))
        Me.TypeTextBox.Location = New System.Drawing.Point(279, 229)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TypeTextBox.TabIndex = 15
        '
        'InstitutionTextBox
        '
        Me.InstitutionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QulificationBindingSource, "institution", True))
        Me.InstitutionTextBox.Location = New System.Drawing.Point(279, 273)
        Me.InstitutionTextBox.Name = "InstitutionTextBox"
        Me.InstitutionTextBox.Size = New System.Drawing.Size(200, 22)
        Me.InstitutionTextBox.TabIndex = 17
        '
        'Graduation_DateDateTimePicker
        '
        Me.Graduation_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.QulificationBindingSource, "Graduation_Date", True))
        Me.Graduation_DateDateTimePicker.Location = New System.Drawing.Point(279, 310)
        Me.Graduation_DateDateTimePicker.Name = "Graduation_DateDateTimePicker"
        Me.Graduation_DateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Graduation_DateDateTimePicker.TabIndex = 19
        '
        'qualificationBindingNavigator
        '
        Me.qualificationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.qualificationBindingNavigator.BindingSource = Me.QulificationBindingSource
        Me.qualificationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.qualificationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.qualificationBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.qualificationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WardsBindingNavigatorSaveItem})
        Me.qualificationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.qualificationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.qualificationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.qualificationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.qualificationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.qualificationBindingNavigator.Name = "qualificationBindingNavigator"
        Me.qualificationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.qualificationBindingNavigator.Size = New System.Drawing.Size(801, 27)
        Me.qualificationBindingNavigator.TabIndex = 20
        Me.qualificationBindingNavigator.Text = "BindingNavigator1"
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
        'FormQualification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.project_g11.My.Resources.Resources.พื้นหลังงงง
        Me.ClientSize = New System.Drawing.Size(801, 450)
        Me.Controls.Add(Me.qualificationBindingNavigator)
        Me.Controls.Add(StaffIDLabel)
        Me.Controls.Add(Me.StaffIDTextBox)
        Me.Controls.Add(TypeLabel)
        Me.Controls.Add(Me.TypeTextBox)
        Me.Controls.Add(InstitutionLabel)
        Me.Controls.Add(Me.InstitutionTextBox)
        Me.Controls.Add(Graduation_DateLabel)
        Me.Controls.Add(Me.Graduation_DateDateTimePicker)
        Me.Controls.Add(Me.Buttonsearch)
        Me.Controls.Add(Me.TextBoxsearch)
        Me.Controls.Add(Me.qualification)
        Me.Name = "FormQualification"
        Me.Text = "FormQualification"
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QulificationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qualificationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.qualificationBindingNavigator.ResumeLayout(False)
        Me.qualificationBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Wellmeadows_hospitalDataSet As wellmeadows_hospitalDataSet
    Friend WithEvents QulificationBindingSource As BindingSource
    Friend WithEvents QulificationTableAdapter As wellmeadows_hospitalDataSetTableAdapters.qulificationTableAdapter
    Friend WithEvents TableAdapterManager As wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents qualification As Label
    Friend WithEvents TextBoxsearch As TextBox
    Friend WithEvents Buttonsearch As Button
    Friend WithEvents StaffIDTextBox As TextBox
    Friend WithEvents TypeTextBox As TextBox
    Friend WithEvents InstitutionTextBox As TextBox
    Friend WithEvents Graduation_DateDateTimePicker As DateTimePicker
    Friend WithEvents qualificationBindingNavigator As BindingNavigator
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
End Class
