<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTreatment
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
        Me.Apply_wardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wellmeadows_hospitalDataSet = New project_g11.wellmeadows_hospitalDataSet()
        Me.View_medicationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.View_medicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Apply_wardsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Staff_report = New System.Windows.Forms.Button()
        Me.Medication = New System.Windows.Forms.Button()
        Me.patient_report = New System.Windows.Forms.Button()
        Me.Medication_report = New System.Windows.Forms.Button()
        Me.Apply_wardsTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.apply_wardsTableAdapter()
        Me.TableAdapterManager = New project_g11.wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager()
        Me.View_medicationTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.view_medicationTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Apply_wardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_medicationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_medicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Apply_wardsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Apply_wardsBindingSource
        '
        Me.Apply_wardsBindingSource.DataMember = "apply_wards"
        Me.Apply_wardsBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'Wellmeadows_hospitalDataSet
        '
        Me.Wellmeadows_hospitalDataSet.DataSetName = "wellmeadows_hospitalDataSet"
        Me.Wellmeadows_hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_medicationDataGridView
        '
        Me.View_medicationDataGridView.AutoGenerateColumns = False
        Me.View_medicationDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.View_medicationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_medicationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.View_medicationDataGridView.DataSource = Me.View_medicationBindingSource
        Me.View_medicationDataGridView.Location = New System.Drawing.Point(37, 471)
        Me.View_medicationDataGridView.Name = "View_medicationDataGridView"
        Me.View_medicationDataGridView.RowHeadersWidth = 51
        Me.View_medicationDataGridView.RowTemplate.Height = 24
        Me.View_medicationDataGridView.Size = New System.Drawing.Size(1185, 220)
        Me.View_medicationDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "staffID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "staffID"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "staffName"
        Me.DataGridViewTextBoxColumn11.HeaderText = "staffName"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "patientID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "patientID"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "patientName"
        Me.DataGridViewTextBoxColumn13.HeaderText = "patientName"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "drugID"
        Me.DataGridViewTextBoxColumn14.HeaderText = "drugID"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "drug_name"
        Me.DataGridViewTextBoxColumn15.HeaderText = "drug_name"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 125
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "descriptions"
        Me.DataGridViewTextBoxColumn16.HeaderText = "descriptions"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "dosage"
        Me.DataGridViewTextBoxColumn17.HeaderText = "dosage"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 125
        '
        'View_medicationBindingSource
        '
        Me.View_medicationBindingSource.DataMember = "view_medication"
        Me.View_medicationBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'Apply_wardsDataGridView
        '
        Me.Apply_wardsDataGridView.AutoGenerateColumns = False
        Me.Apply_wardsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Apply_wardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Apply_wardsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Apply_wardsDataGridView.DataSource = Me.Apply_wardsBindingSource
        Me.Apply_wardsDataGridView.Location = New System.Drawing.Point(37, 162)
        Me.Apply_wardsDataGridView.Name = "Apply_wardsDataGridView"
        Me.Apply_wardsDataGridView.RowHeadersWidth = 51
        Me.Apply_wardsDataGridView.RowTemplate.Height = 24
        Me.Apply_wardsDataGridView.Size = New System.Drawing.Size(1185, 220)
        Me.Apply_wardsDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "apply_wardsID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "apply_wardsID"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "patientID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "patientID"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "patientName"
        Me.DataGridViewTextBoxColumn9.HeaderText = "patientName"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "room_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "room_ID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "bed_number"
        Me.DataGridViewTextBoxColumn3.HeaderText = "bed_number"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "location"
        Me.DataGridViewTextBoxColumn4.HeaderText = "location"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "start_date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "start_date"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "finish_date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "finish_date"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("TH SarabunPSK", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Apply Wards"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("TH SarabunPSK", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 421)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Medication "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button1.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Window
        Me.Button1.Location = New System.Drawing.Point(1104, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 41)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Apply Wards"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Staff_report
        '
        Me.Staff_report.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Staff_report.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Staff_report.Location = New System.Drawing.Point(182, 724)
        Me.Staff_report.Name = "Staff_report"
        Me.Staff_report.Size = New System.Drawing.Size(158, 48)
        Me.Staff_report.TabIndex = 6
        Me.Staff_report.Text = "Staff Report"
        Me.Staff_report.UseVisualStyleBackColor = False
        '
        'Medication
        '
        Me.Medication.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Medication.Font = New System.Drawing.Font("TH SarabunPSK", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Medication.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Medication.Location = New System.Drawing.Point(1097, 421)
        Me.Medication.Name = "Medication"
        Me.Medication.Size = New System.Drawing.Size(125, 44)
        Me.Medication.TabIndex = 49
        Me.Medication.Text = "Medication"
        Me.Medication.UseVisualStyleBackColor = False
        '
        'patient_report
        '
        Me.patient_report.BackColor = System.Drawing.Color.PaleTurquoise
        Me.patient_report.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.patient_report.Location = New System.Drawing.Point(493, 724)
        Me.patient_report.Name = "patient_report"
        Me.patient_report.Size = New System.Drawing.Size(200, 48)
        Me.patient_report.TabIndex = 50
        Me.patient_report.Text = "Patient Report"
        Me.patient_report.UseVisualStyleBackColor = False
        '
        'Medication_report
        '
        Me.Medication_report.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Medication_report.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Medication_report.Location = New System.Drawing.Point(795, 724)
        Me.Medication_report.Name = "Medication_report"
        Me.Medication_report.Size = New System.Drawing.Size(183, 48)
        Me.Medication_report.TabIndex = 51
        Me.Medication_report.Text = "Medication Report"
        Me.Medication_report.UseVisualStyleBackColor = False
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
        'View_medicationTableAdapter
        '
        Me.View_medicationTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.project_g11.My.Resources.Resources.png_clipart_button_arrow_back_arrow_blue_trademark_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(26, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'FormTreatment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.BackgroundImage = Global.project_g11.My.Resources.Resources.พื้นหลังงงง
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1282, 837)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Medication_report)
        Me.Controls.Add(Me.patient_report)
        Me.Controls.Add(Me.Medication)
        Me.Controls.Add(Me.Staff_report)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Apply_wardsDataGridView)
        Me.Controls.Add(Me.View_medicationDataGridView)
        Me.Name = "FormTreatment"
        Me.Text = "FormTreatment"
        CType(Me.Apply_wardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_medicationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_medicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Apply_wardsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Wellmeadows_hospitalDataSet As wellmeadows_hospitalDataSet
    Friend WithEvents Apply_wardsBindingSource As BindingSource
    Friend WithEvents Apply_wardsTableAdapter As wellmeadows_hospitalDataSetTableAdapters.apply_wardsTableAdapter
    Friend WithEvents TableAdapterManager As wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents View_medicationBindingSource As BindingSource
    Friend WithEvents View_medicationTableAdapter As wellmeadows_hospitalDataSetTableAdapters.view_medicationTableAdapter
    Friend WithEvents View_medicationDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents Apply_wardsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Staff_report As Button
    Friend WithEvents Medication As Button
    Friend WithEvents patient_report As Button
    Friend WithEvents Medication_report As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
