<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMedication
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
        Dim StaffIDLabel4 As System.Windows.Forms.Label
        Dim PatientIDLabel3 As System.Windows.Forms.Label
        Dim DrugIDLabel3 As System.Windows.Forms.Label
        Dim StaffIDLabel3 As System.Windows.Forms.Label
        Dim PatientIDLabel2 As System.Windows.Forms.Label
        Dim DrugIDLabel2 As System.Windows.Forms.Label
        Me.Button_save = New System.Windows.Forms.Button()
        Me.StaffIDTextBox4 = New System.Windows.Forms.TextBox()
        Me.PatientIDTextBox3 = New System.Windows.Forms.TextBox()
        Me.DrugIDTextBox3 = New System.Windows.Forms.TextBox()
        Me.DataGridView_drug = New System.Windows.Forms.DataGridView()
        Me.DrugID1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drug_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descriptions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dosage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.StaffIDTextBox3 = New System.Windows.Forms.TextBox()
        Me.PatientIDTextBox2 = New System.Windows.Forms.TextBox()
        Me.DrugIDTextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Wellmeadows_hospitalDataSet = New project_g11.wellmeadows_hospitalDataSet()
        Me.MedicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicationTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.MedicationTableAdapter()
        Me.TableAdapterManager = New project_g11.wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager()
        Me.DataGridViewaddtoDB = New System.Windows.Forms.DataGridView()
        Me.staffID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.patientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drugid2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Buttonadd = New System.Windows.Forms.Button()
        StaffIDLabel4 = New System.Windows.Forms.Label()
        PatientIDLabel3 = New System.Windows.Forms.Label()
        DrugIDLabel3 = New System.Windows.Forms.Label()
        StaffIDLabel3 = New System.Windows.Forms.Label()
        PatientIDLabel2 = New System.Windows.Forms.Label()
        DrugIDLabel2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView_drug, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewaddtoDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StaffIDLabel4
        '
        StaffIDLabel4.AutoSize = True
        StaffIDLabel4.BackColor = System.Drawing.Color.Transparent
        StaffIDLabel4.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        StaffIDLabel4.Location = New System.Drawing.Point(484, 469)
        StaffIDLabel4.Name = "StaffIDLabel4"
        StaffIDLabel4.Size = New System.Drawing.Size(72, 31)
        StaffIDLabel4.TabIndex = 30
        StaffIDLabel4.Text = "Staff ID:"
        '
        'PatientIDLabel3
        '
        PatientIDLabel3.AutoSize = True
        PatientIDLabel3.BackColor = System.Drawing.Color.Transparent
        PatientIDLabel3.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        PatientIDLabel3.Location = New System.Drawing.Point(466, 509)
        PatientIDLabel3.Name = "PatientIDLabel3"
        PatientIDLabel3.Size = New System.Drawing.Size(90, 31)
        PatientIDLabel3.TabIndex = 32
        PatientIDLabel3.Text = "Patient ID:"
        '
        'DrugIDLabel3
        '
        DrugIDLabel3.AutoSize = True
        DrugIDLabel3.BackColor = System.Drawing.Color.Transparent
        DrugIDLabel3.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DrugIDLabel3.Location = New System.Drawing.Point(483, 557)
        DrugIDLabel3.Name = "DrugIDLabel3"
        DrugIDLabel3.Size = New System.Drawing.Size(73, 31)
        DrugIDLabel3.TabIndex = 34
        DrugIDLabel3.Text = "Drug ID:"
        '
        'StaffIDLabel3
        '
        StaffIDLabel3.AutoSize = True
        StaffIDLabel3.BackColor = System.Drawing.Color.Transparent
        StaffIDLabel3.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        StaffIDLabel3.Location = New System.Drawing.Point(448, 137)
        StaffIDLabel3.Name = "StaffIDLabel3"
        StaffIDLabel3.Size = New System.Drawing.Size(100, 31)
        StaffIDLabel3.TabIndex = 20
        StaffIDLabel3.Text = "Staff Name:"
        '
        'PatientIDLabel2
        '
        PatientIDLabel2.AutoSize = True
        PatientIDLabel2.BackColor = System.Drawing.Color.Transparent
        PatientIDLabel2.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        PatientIDLabel2.Location = New System.Drawing.Point(447, 185)
        PatientIDLabel2.Name = "PatientIDLabel2"
        PatientIDLabel2.Size = New System.Drawing.Size(118, 31)
        PatientIDLabel2.TabIndex = 22
        PatientIDLabel2.Text = "Patient Name:"
        '
        'DrugIDLabel2
        '
        DrugIDLabel2.AutoSize = True
        DrugIDLabel2.BackColor = System.Drawing.Color.Transparent
        DrugIDLabel2.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DrugIDLabel2.Location = New System.Drawing.Point(448, 232)
        DrugIDLabel2.Name = "DrugIDLabel2"
        DrugIDLabel2.Size = New System.Drawing.Size(101, 31)
        DrugIDLabel2.TabIndex = 24
        DrugIDLabel2.Text = "Drug Name:"
        '
        'Button_save
        '
        Me.Button_save.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button_save.Font = New System.Drawing.Font("TH SarabunPSK", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button_save.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button_save.Location = New System.Drawing.Point(612, 842)
        Me.Button_save.Name = "Button_save"
        Me.Button_save.Size = New System.Drawing.Size(146, 43)
        Me.Button_save.TabIndex = 36
        Me.Button_save.Text = "Save"
        Me.Button_save.UseVisualStyleBackColor = False
        '
        'StaffIDTextBox4
        '
        Me.StaffIDTextBox4.Enabled = False
        Me.StaffIDTextBox4.Location = New System.Drawing.Point(572, 472)
        Me.StaffIDTextBox4.Name = "StaffIDTextBox4"
        Me.StaffIDTextBox4.Size = New System.Drawing.Size(283, 22)
        Me.StaffIDTextBox4.TabIndex = 31
        '
        'PatientIDTextBox3
        '
        Me.PatientIDTextBox3.Enabled = False
        Me.PatientIDTextBox3.Location = New System.Drawing.Point(572, 516)
        Me.PatientIDTextBox3.Name = "PatientIDTextBox3"
        Me.PatientIDTextBox3.Size = New System.Drawing.Size(283, 22)
        Me.PatientIDTextBox3.TabIndex = 33
        '
        'DrugIDTextBox3
        '
        Me.DrugIDTextBox3.Enabled = False
        Me.DrugIDTextBox3.Location = New System.Drawing.Point(572, 560)
        Me.DrugIDTextBox3.Name = "DrugIDTextBox3"
        Me.DrugIDTextBox3.Size = New System.Drawing.Size(283, 22)
        Me.DrugIDTextBox3.TabIndex = 35
        '
        'DataGridView_drug
        '
        Me.DataGridView_drug.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridView_drug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_drug.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DrugID1, Me.drug_name, Me.descriptions, Me.dosage})
        Me.DataGridView_drug.Location = New System.Drawing.Point(289, 303)
        Me.DataGridView_drug.Name = "DataGridView_drug"
        Me.DataGridView_drug.RowHeadersWidth = 51
        Me.DataGridView_drug.RowTemplate.Height = 24
        Me.DataGridView_drug.Size = New System.Drawing.Size(779, 93)
        Me.DataGridView_drug.TabIndex = 29
        '
        'DrugID1
        '
        Me.DrugID1.HeaderText = "DrugID"
        Me.DrugID1.MinimumWidth = 6
        Me.DrugID1.Name = "DrugID1"
        Me.DrugID1.Width = 125
        '
        'drug_name
        '
        Me.drug_name.HeaderText = "Drug Name"
        Me.drug_name.MinimumWidth = 6
        Me.drug_name.Name = "drug_name"
        Me.drug_name.Width = 125
        '
        'descriptions
        '
        Me.descriptions.HeaderText = "Descriptions"
        Me.descriptions.MinimumWidth = 6
        Me.descriptions.Name = "descriptions"
        Me.descriptions.Width = 125
        '
        'dosage
        '
        Me.dosage.HeaderText = "Dosage"
        Me.dosage.MinimumWidth = 6
        Me.dosage.Name = "dosage"
        Me.dosage.Width = 125
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.LavenderBlush
        Me.Button9.Location = New System.Drawing.Point(798, 233)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(166, 35)
        Me.Button9.TabIndex = 28
        Me.Button9.Text = "SEARCH DRUG"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Thistle
        Me.Button8.Location = New System.Drawing.Point(798, 183)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(166, 35)
        Me.Button8.TabIndex = 27
        Me.Button8.Text = "SEARCH PATIENT"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Plum
        Me.Button7.Location = New System.Drawing.Point(798, 135)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(166, 35)
        Me.Button7.TabIndex = 26
        Me.Button7.Text = "SEARCH STAFF"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'StaffIDTextBox3
        '
        Me.StaffIDTextBox3.Location = New System.Drawing.Point(572, 144)
        Me.StaffIDTextBox3.Name = "StaffIDTextBox3"
        Me.StaffIDTextBox3.Size = New System.Drawing.Size(205, 22)
        Me.StaffIDTextBox3.TabIndex = 21
        '
        'PatientIDTextBox2
        '
        Me.PatientIDTextBox2.Location = New System.Drawing.Point(572, 188)
        Me.PatientIDTextBox2.Name = "PatientIDTextBox2"
        Me.PatientIDTextBox2.Size = New System.Drawing.Size(205, 22)
        Me.PatientIDTextBox2.TabIndex = 23
        '
        'DrugIDTextBox2
        '
        Me.DrugIDTextBox2.Location = New System.Drawing.Point(572, 239)
        Me.DrugIDTextBox2.Name = "DrugIDTextBox2"
        Me.DrugIDTextBox2.Size = New System.Drawing.Size(205, 22)
        Me.DrugIDTextBox2.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1374, 100)
        Me.Panel1.TabIndex = 37
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.project_g11.My.Resources.Resources.png_clipart_button_arrow_back_arrow_blue_trademark_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(57, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("TH SarabunPSK", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(602, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 50)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "จ่ายยา"
        '
        'Wellmeadows_hospitalDataSet
        '
        Me.Wellmeadows_hospitalDataSet.DataSetName = "wellmeadows_hospitalDataSet"
        Me.Wellmeadows_hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicationBindingSource
        '
        Me.MedicationBindingSource.DataMember = "Medication"
        Me.MedicationBindingSource.DataSource = Me.Wellmeadows_hospitalDataSet
        '
        'MedicationTableAdapter
        '
        Me.MedicationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.admitted_wardTableAdapter = Nothing
        Me.TableAdapterManager.apply_wardsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bedTableAdapter = Nothing
        Me.TableAdapterManager.MedicationTableAdapter = Me.MedicationTableAdapter
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
        'DataGridViewaddtoDB
        '
        Me.DataGridViewaddtoDB.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridViewaddtoDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewaddtoDB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.staffID, Me.patientID, Me.drugid2})
        Me.DataGridViewaddtoDB.GridColor = System.Drawing.SystemColors.Info
        Me.DataGridViewaddtoDB.Location = New System.Drawing.Point(289, 669)
        Me.DataGridViewaddtoDB.Name = "DataGridViewaddtoDB"
        Me.DataGridViewaddtoDB.RowHeadersWidth = 51
        Me.DataGridViewaddtoDB.RowTemplate.Height = 24
        Me.DataGridViewaddtoDB.Size = New System.Drawing.Size(698, 150)
        Me.DataGridViewaddtoDB.TabIndex = 39
        '
        'staffID
        '
        Me.staffID.HeaderText = "staffID"
        Me.staffID.MinimumWidth = 6
        Me.staffID.Name = "staffID"
        Me.staffID.Width = 125
        '
        'patientID
        '
        Me.patientID.HeaderText = "patientID"
        Me.patientID.MinimumWidth = 6
        Me.patientID.Name = "patientID"
        Me.patientID.Width = 125
        '
        'drugid2
        '
        Me.drugid2.HeaderText = "drugID"
        Me.drugid2.MinimumWidth = 6
        Me.drugid2.Name = "drugid2"
        Me.drugid2.Width = 125
        '
        'Buttonadd
        '
        Me.Buttonadd.BackColor = System.Drawing.Color.Thistle
        Me.Buttonadd.Font = New System.Drawing.Font("TH SarabunPSK", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Buttonadd.Location = New System.Drawing.Point(608, 597)
        Me.Buttonadd.Name = "Buttonadd"
        Me.Buttonadd.Size = New System.Drawing.Size(150, 42)
        Me.Buttonadd.TabIndex = 40
        Me.Buttonadd.Text = "Add"
        Me.Buttonadd.UseVisualStyleBackColor = False
        '
        'FormMedication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.project_g11.My.Resources.Resources.พื้นหลังงงง
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1395, 964)
        Me.Controls.Add(Me.Buttonadd)
        Me.Controls.Add(Me.DataGridViewaddtoDB)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button_save)
        Me.Controls.Add(StaffIDLabel4)
        Me.Controls.Add(Me.StaffIDTextBox4)
        Me.Controls.Add(PatientIDLabel3)
        Me.Controls.Add(Me.PatientIDTextBox3)
        Me.Controls.Add(DrugIDLabel3)
        Me.Controls.Add(Me.DrugIDTextBox3)
        Me.Controls.Add(Me.DataGridView_drug)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(StaffIDLabel3)
        Me.Controls.Add(Me.StaffIDTextBox3)
        Me.Controls.Add(PatientIDLabel2)
        Me.Controls.Add(Me.PatientIDTextBox2)
        Me.Controls.Add(DrugIDLabel2)
        Me.Controls.Add(Me.DrugIDTextBox2)
        Me.Name = "FormMedication"
        Me.Text = "FormMedication"
        CType(Me.DataGridView_drug, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewaddtoDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_save As Button
    Friend WithEvents StaffIDTextBox4 As TextBox
    Friend WithEvents PatientIDTextBox3 As TextBox
    Friend WithEvents DrugIDTextBox3 As TextBox
    Friend WithEvents DataGridView_drug As DataGridView
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents StaffIDTextBox3 As TextBox
    Friend WithEvents PatientIDTextBox2 As TextBox
    Friend WithEvents DrugIDTextBox2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Wellmeadows_hospitalDataSet As wellmeadows_hospitalDataSet
    Friend WithEvents MedicationBindingSource As BindingSource
    Friend WithEvents MedicationTableAdapter As wellmeadows_hospitalDataSetTableAdapters.MedicationTableAdapter
    Friend WithEvents TableAdapterManager As wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DrugID1 As DataGridViewTextBoxColumn
    Friend WithEvents drug_name As DataGridViewTextBoxColumn
    Friend WithEvents descriptions As DataGridViewTextBoxColumn
    Friend WithEvents dosage As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewaddtoDB As DataGridView
    Friend WithEvents Buttonadd As Button
    Friend WithEvents staffID As DataGridViewTextBoxColumn
    Friend WithEvents patientID As DataGridViewTextBoxColumn
    Friend WithEvents drugid2 As DataGridViewTextBoxColumn
End Class
