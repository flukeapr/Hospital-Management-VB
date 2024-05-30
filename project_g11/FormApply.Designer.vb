<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormApply
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
        Dim Apply_wardsIDLabel As System.Windows.Forms.Label
        Dim WardIDLabel As System.Windows.Forms.Label
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim PatientNameLabel As System.Windows.Forms.Label
        Dim Bed_numberLabel As System.Windows.Forms.Label
        Dim Room_IDLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim Start_dateLabel As System.Windows.Forms.Label
        Me.Wellmeadows_hospitalDataSet = New project_g11.wellmeadows_hospitalDataSet()
        Me.Apply_wardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Apply_wardsTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.apply_wardsTableAdapter()
        Me.TableAdapterManager = New project_g11.wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager()
        Me.Apply_wardsIDTextBox = New System.Windows.Forms.TextBox()
        Me.WardIDComboBox = New System.Windows.Forms.ComboBox()
        Me.WardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowshospitalDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientIDComboBox = New System.Windows.Forms.ComboBox()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Bed_numberComboBox = New System.Windows.Forms.ComboBox()
        Me.BedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Room_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocationComboBox = New System.Windows.Forms.ComboBox()
        Me.Start_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Finish_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PatientTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.patientTableAdapter()
        Me.WardsTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.WardsTableAdapter()
        Me.RoomTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.roomTableAdapter()
        Me.BedTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.bedTableAdapter()
        Me.Button_save = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Apply_wardsIDLabel = New System.Windows.Forms.Label()
        WardIDLabel = New System.Windows.Forms.Label()
        PatientIDLabel = New System.Windows.Forms.Label()
        PatientNameLabel = New System.Windows.Forms.Label()
        Bed_numberLabel = New System.Windows.Forms.Label()
        Room_IDLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        Start_dateLabel = New System.Windows.Forms.Label()
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Apply_wardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowshospitalDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Apply_wardsIDLabel
        '
        Apply_wardsIDLabel.AutoSize = True
        Apply_wardsIDLabel.BackColor = System.Drawing.Color.Transparent
        Apply_wardsIDLabel.Location = New System.Drawing.Point(420, 64)
        Apply_wardsIDLabel.Name = "Apply_wardsIDLabel"
        Apply_wardsIDLabel.Size = New System.Drawing.Size(104, 16)
        Apply_wardsIDLabel.TabIndex = 2
        Apply_wardsIDLabel.Text = "Apply Wards ID:"
        '
        'WardIDLabel
        '
        WardIDLabel.AutoSize = True
        WardIDLabel.BackColor = System.Drawing.Color.Transparent
        WardIDLabel.Location = New System.Drawing.Point(251, 116)
        WardIDLabel.Name = "WardIDLabel"
        WardIDLabel.Size = New System.Drawing.Size(59, 16)
        WardIDLabel.TabIndex = 4
        WardIDLabel.Text = "Ward ID:"
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.BackColor = System.Drawing.Color.Transparent
        PatientIDLabel.Location = New System.Drawing.Point(247, 161)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(67, 16)
        PatientIDLabel.TabIndex = 5
        PatientIDLabel.Text = "Patient ID:"
        '
        'PatientNameLabel
        '
        PatientNameLabel.AutoSize = True
        PatientNameLabel.BackColor = System.Drawing.Color.Transparent
        PatientNameLabel.Location = New System.Drawing.Point(630, 164)
        PatientNameLabel.Name = "PatientNameLabel"
        PatientNameLabel.Size = New System.Drawing.Size(91, 16)
        PatientNameLabel.TabIndex = 7
        PatientNameLabel.Text = "Patient Name:"
        '
        'Bed_numberLabel
        '
        Bed_numberLabel.AutoSize = True
        Bed_numberLabel.BackColor = System.Drawing.Color.Transparent
        Bed_numberLabel.Location = New System.Drawing.Point(630, 216)
        Bed_numberLabel.Name = "Bed_numberLabel"
        Bed_numberLabel.Size = New System.Drawing.Size(86, 16)
        Bed_numberLabel.TabIndex = 9
        Bed_numberLabel.Text = "Bed Number:"
        '
        'Room_IDLabel
        '
        Room_IDLabel.AutoSize = True
        Room_IDLabel.BackColor = System.Drawing.Color.Transparent
        Room_IDLabel.Location = New System.Drawing.Point(247, 216)
        Room_IDLabel.Name = "Room_IDLabel"
        Room_IDLabel.Size = New System.Drawing.Size(63, 16)
        Room_IDLabel.TabIndex = 11
        Room_IDLabel.Text = "Room ID:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.BackColor = System.Drawing.Color.Transparent
        LocationLabel.Location = New System.Drawing.Point(655, 116)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(61, 16)
        LocationLabel.TabIndex = 13
        LocationLabel.Text = "Location:"
        '
        'Start_dateLabel
        '
        Start_dateLabel.AutoSize = True
        Start_dateLabel.BackColor = System.Drawing.Color.Transparent
        Start_dateLabel.Location = New System.Drawing.Point(241, 267)
        Start_dateLabel.Name = "Start_dateLabel"
        Start_dateLabel.Size = New System.Drawing.Size(69, 16)
        Start_dateLabel.TabIndex = 15
        Start_dateLabel.Text = "Start Date:"
        '
        'Wellmeadows_hospitalDataSet
        '
        Me.Wellmeadows_hospitalDataSet.DataSetName = "wellmeadows_hospitalDataSet"
        Me.Wellmeadows_hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Apply_wardsBindingSource
        '
        Me.Apply_wardsBindingSource.DataMember = "apply_wards"
        Me.Apply_wardsBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'Apply_wardsTableAdapter
        '
        Me.Apply_wardsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.admitted_wardTableAdapter = Nothing
        Me.TableAdapterManager.apply_wardsTableAdapter = Me.Apply_wardsTableAdapter
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
        Me.TableAdapterManager.work_experienceTableAdapter = Nothing
        Me.TableAdapterManager.Work_inTableAdapter = Nothing
        '
        'Apply_wardsIDTextBox
        '
        Me.Apply_wardsIDTextBox.Location = New System.Drawing.Point(534, 64)
        Me.Apply_wardsIDTextBox.Name = "Apply_wardsIDTextBox"
        Me.Apply_wardsIDTextBox.Size = New System.Drawing.Size(121, 22)
        Me.Apply_wardsIDTextBox.TabIndex = 3
        '
        'WardIDComboBox
        '
        Me.WardIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "wardID", True))
        Me.WardIDComboBox.DataSource = Me.WardsBindingSource
        Me.WardIDComboBox.DisplayMember = "wardID"
        Me.WardIDComboBox.FormattingEnabled = True
        Me.WardIDComboBox.Location = New System.Drawing.Point(319, 113)
        Me.WardIDComboBox.Name = "WardIDComboBox"
        Me.WardIDComboBox.Size = New System.Drawing.Size(205, 24)
        Me.WardIDComboBox.TabIndex = 5
        Me.WardIDComboBox.ValueMember = "wardID"
        '
        'WardsBindingSource
        '
        Me.WardsBindingSource.DataMember = "Wards"
        Me.WardsBindingSource.DataSource = Me.WellmeadowshospitalDataSetBindingSource
        '
        'WellmeadowshospitalDataSetBindingSource
        '
        Me.WellmeadowshospitalDataSetBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        Me.WellmeadowshospitalDataSetBindingSource.Position = 0
        '
        'PatientIDComboBox
        '
        Me.PatientIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Apply_wardsBindingSource, "patientID", True))
        Me.PatientIDComboBox.DataSource = Me.PatientBindingSource
        Me.PatientIDComboBox.DisplayMember = "patientID"
        Me.PatientIDComboBox.FormattingEnabled = True
        Me.PatientIDComboBox.Location = New System.Drawing.Point(319, 158)
        Me.PatientIDComboBox.Name = "PatientIDComboBox"
        Me.PatientIDComboBox.Size = New System.Drawing.Size(205, 24)
        Me.PatientIDComboBox.TabIndex = 6
        Me.PatientIDComboBox.ValueMember = "patientID"
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "patient"
        Me.PatientBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'PatientNameComboBox
        '
        Me.PatientNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Apply_wardsBindingSource, "patientName", True))
        Me.PatientNameComboBox.DataSource = Me.PatientBindingSource
        Me.PatientNameComboBox.DisplayMember = "patientName"
        Me.PatientNameComboBox.FormattingEnabled = True
        Me.PatientNameComboBox.Location = New System.Drawing.Point(726, 161)
        Me.PatientNameComboBox.Name = "PatientNameComboBox"
        Me.PatientNameComboBox.Size = New System.Drawing.Size(200, 24)
        Me.PatientNameComboBox.TabIndex = 8
        Me.PatientNameComboBox.ValueMember = "patientName"
        '
        'Bed_numberComboBox
        '
        Me.Bed_numberComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Apply_wardsBindingSource, "bed_number", True))
        Me.Bed_numberComboBox.DataSource = Me.BedBindingSource
        Me.Bed_numberComboBox.DisplayMember = "bed_number"
        Me.Bed_numberComboBox.FormattingEnabled = True
        Me.Bed_numberComboBox.Location = New System.Drawing.Point(726, 213)
        Me.Bed_numberComboBox.Name = "Bed_numberComboBox"
        Me.Bed_numberComboBox.Size = New System.Drawing.Size(200, 24)
        Me.Bed_numberComboBox.TabIndex = 10
        Me.Bed_numberComboBox.ValueMember = "bed_number"
        '
        'BedBindingSource
        '
        Me.BedBindingSource.DataMember = "bed"
        Me.BedBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'Room_IDComboBox
        '
        Me.Room_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Apply_wardsBindingSource, "room_ID", True))
        Me.Room_IDComboBox.DataSource = Me.RoomBindingSource
        Me.Room_IDComboBox.DisplayMember = "room_ID"
        Me.Room_IDComboBox.FormattingEnabled = True
        Me.Room_IDComboBox.Location = New System.Drawing.Point(319, 213)
        Me.Room_IDComboBox.Name = "Room_IDComboBox"
        Me.Room_IDComboBox.Size = New System.Drawing.Size(205, 24)
        Me.Room_IDComboBox.TabIndex = 12
        Me.Room_IDComboBox.ValueMember = "room_ID"
        '
        'RoomBindingSource
        '
        Me.RoomBindingSource.DataMember = "room"
        Me.RoomBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'LocationComboBox
        '
        Me.LocationComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardsBindingSource, "location", True))
        Me.LocationComboBox.DataSource = Me.WardsBindingSource
        Me.LocationComboBox.DisplayMember = "location"
        Me.LocationComboBox.FormattingEnabled = True
        Me.LocationComboBox.Location = New System.Drawing.Point(726, 113)
        Me.LocationComboBox.Name = "LocationComboBox"
        Me.LocationComboBox.Size = New System.Drawing.Size(200, 24)
        Me.LocationComboBox.TabIndex = 14
        Me.LocationComboBox.ValueMember = "location"
        '
        'Start_dateDateTimePicker
        '
        Me.Start_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Apply_wardsBindingSource, "start_date", True))
        Me.Start_dateDateTimePicker.Location = New System.Drawing.Point(319, 262)
        Me.Start_dateDateTimePicker.Name = "Start_dateDateTimePicker"
        Me.Start_dateDateTimePicker.Size = New System.Drawing.Size(205, 22)
        Me.Start_dateDateTimePicker.TabIndex = 16
        '
        'Finish_dateDateTimePicker
        '
        Me.Finish_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Apply_wardsBindingSource, "finish_date", True))
        Me.Finish_dateDateTimePicker.Location = New System.Drawing.Point(726, 262)
        Me.Finish_dateDateTimePicker.Name = "Finish_dateDateTimePicker"
        Me.Finish_dateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Finish_dateDateTimePicker.TabIndex = 18
        Me.Finish_dateDateTimePicker.Visible = False
        '
        'PatientTableAdapter
        '
        Me.PatientTableAdapter.ClearBeforeFill = True
        '
        'WardsTableAdapter
        '
        Me.WardsTableAdapter.ClearBeforeFill = True
        '
        'RoomTableAdapter
        '
        Me.RoomTableAdapter.ClearBeforeFill = True
        '
        'BedTableAdapter
        '
        Me.BedTableAdapter.ClearBeforeFill = True
        '
        'Button_save
        '
        Me.Button_save.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button_save.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_save.Location = New System.Drawing.Point(534, 326)
        Me.Button_save.Name = "Button_save"
        Me.Button_save.Size = New System.Drawing.Size(75, 41)
        Me.Button_save.TabIndex = 19
        Me.Button_save.Text = "Save"
        Me.Button_save.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(624, 266)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 20)
        Me.CheckBox1.TabIndex = 20
        Me.CheckBox1.Text = "Finish Date"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'FormApply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.project_g11.My.Resources.Resources.พื้นหลังงงง
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1146, 450)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button_save)
        Me.Controls.Add(Me.Finish_dateDateTimePicker)
        Me.Controls.Add(Start_dateLabel)
        Me.Controls.Add(Me.Start_dateDateTimePicker)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationComboBox)
        Me.Controls.Add(Room_IDLabel)
        Me.Controls.Add(Me.Room_IDComboBox)
        Me.Controls.Add(Bed_numberLabel)
        Me.Controls.Add(Me.Bed_numberComboBox)
        Me.Controls.Add(PatientNameLabel)
        Me.Controls.Add(Me.PatientNameComboBox)
        Me.Controls.Add(PatientIDLabel)
        Me.Controls.Add(Me.PatientIDComboBox)
        Me.Controls.Add(WardIDLabel)
        Me.Controls.Add(Me.WardIDComboBox)
        Me.Controls.Add(Apply_wardsIDLabel)
        Me.Controls.Add(Me.Apply_wardsIDTextBox)
        Me.Name = "FormApply"
        Me.Text = "FormApply"
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Apply_wardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowshospitalDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Wellmeadows_hospitalDataSet As wellmeadows_hospitalDataSet
    Friend WithEvents Apply_wardsBindingSource As BindingSource
    Friend WithEvents Apply_wardsTableAdapter As wellmeadows_hospitalDataSetTableAdapters.apply_wardsTableAdapter
    Friend WithEvents TableAdapterManager As wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Apply_wardsIDTextBox As TextBox
    Friend WithEvents WardIDComboBox As ComboBox
    Friend WithEvents PatientIDComboBox As ComboBox
    Friend WithEvents PatientNameComboBox As ComboBox
    Friend WithEvents Bed_numberComboBox As ComboBox
    Friend WithEvents Room_IDComboBox As ComboBox
    Friend WithEvents LocationComboBox As ComboBox
    Friend WithEvents Start_dateDateTimePicker As DateTimePicker
    Friend WithEvents Finish_dateDateTimePicker As DateTimePicker
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PatientTableAdapter As wellmeadows_hospitalDataSetTableAdapters.patientTableAdapter
    Friend WithEvents WellmeadowshospitalDataSetBindingSource As BindingSource
    Friend WithEvents WardsBindingSource As BindingSource
    Friend WithEvents WardsTableAdapter As wellmeadows_hospitalDataSetTableAdapters.WardsTableAdapter
    Friend WithEvents RoomBindingSource As BindingSource
    Friend WithEvents RoomTableAdapter As wellmeadows_hospitalDataSetTableAdapters.roomTableAdapter
    Friend WithEvents BedBindingSource As BindingSource
    Friend WithEvents BedTableAdapter As wellmeadows_hospitalDataSetTableAdapters.bedTableAdapter
    Friend WithEvents Button_save As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
