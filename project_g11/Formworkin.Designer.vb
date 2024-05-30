<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formworkin
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
        Dim WardIDLabel As System.Windows.Forms.Label
        Dim ShiftLabel As System.Windows.Forms.Label
        Me.Wellmeadows_hospitalDataSet = New project_g11.wellmeadows_hospitalDataSet()
        Me.Work_inBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Work_inTableAdapter = New project_g11.wellmeadows_hospitalDataSetTableAdapters.Work_inTableAdapter()
        Me.TableAdapterManager = New project_g11.wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager()
        Me.StaffIDTextBox = New System.Windows.Forms.TextBox()
        Me.WardIDTextBox = New System.Windows.Forms.TextBox()
        Me.shiftText = New System.Windows.Forms.ComboBox()
        Me.save = New System.Windows.Forms.Button()
        Me.TextBox_anything = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.searchby = New System.Windows.Forms.Label()
        StaffIDLabel = New System.Windows.Forms.Label()
        WardIDLabel = New System.Windows.Forms.Label()
        ShiftLabel = New System.Windows.Forms.Label()
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Work_inBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StaffIDLabel
        '
        StaffIDLabel.AutoSize = True
        StaffIDLabel.BackColor = System.Drawing.Color.Transparent
        StaffIDLabel.Font = New System.Drawing.Font("TH SarabunPSK", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        StaffIDLabel.Location = New System.Drawing.Point(73, 189)
        StaffIDLabel.Name = "StaffIDLabel"
        StaffIDLabel.Size = New System.Drawing.Size(87, 37)
        StaffIDLabel.TabIndex = 3
        StaffIDLabel.Text = "Staff ID:"
        '
        'WardIDLabel
        '
        WardIDLabel.AutoSize = True
        WardIDLabel.BackColor = System.Drawing.Color.Transparent
        WardIDLabel.Font = New System.Drawing.Font("TH SarabunPSK", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        WardIDLabel.Location = New System.Drawing.Point(394, 189)
        WardIDLabel.Name = "WardIDLabel"
        WardIDLabel.Size = New System.Drawing.Size(92, 37)
        WardIDLabel.TabIndex = 5
        WardIDLabel.Text = "Ward ID:"
        '
        'ShiftLabel
        '
        ShiftLabel.AutoSize = True
        ShiftLabel.BackColor = System.Drawing.Color.Transparent
        ShiftLabel.Font = New System.Drawing.Font("TH SarabunPSK", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        ShiftLabel.Location = New System.Drawing.Point(97, 239)
        ShiftLabel.Name = "ShiftLabel"
        ShiftLabel.Size = New System.Drawing.Size(63, 37)
        ShiftLabel.TabIndex = 7
        ShiftLabel.Text = "Shift:"
        '
        'Wellmeadows_hospitalDataSet
        '
        Me.Wellmeadows_hospitalDataSet.DataSetName = "wellmeadows_hospitalDataSet"
        Me.Wellmeadows_hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.work_experienceTableAdapter = Nothing
        Me.TableAdapterManager.Work_inTableAdapter = Me.Work_inTableAdapter
        '
        'StaffIDTextBox
        '
        Me.StaffIDTextBox.Location = New System.Drawing.Point(169, 196)
        Me.StaffIDTextBox.Name = "StaffIDTextBox"
        Me.StaffIDTextBox.Size = New System.Drawing.Size(168, 22)
        Me.StaffIDTextBox.TabIndex = 4
        '
        'WardIDTextBox
        '
        Me.WardIDTextBox.Location = New System.Drawing.Point(495, 196)
        Me.WardIDTextBox.Name = "WardIDTextBox"
        Me.WardIDTextBox.Size = New System.Drawing.Size(168, 22)
        Me.WardIDTextBox.TabIndex = 6
        '
        'shiftText
        '
        Me.shiftText.FormattingEnabled = True
        Me.shiftText.Location = New System.Drawing.Point(169, 249)
        Me.shiftText.Name = "shiftText"
        Me.shiftText.Size = New System.Drawing.Size(168, 24)
        Me.shiftText.TabIndex = 9
        '
        'save
        '
        Me.save.BackColor = System.Drawing.Color.Moccasin
        Me.save.Font = New System.Drawing.Font("TH SarabunPSK", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.save.Location = New System.Drawing.Point(540, 281)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(123, 51)
        Me.save.TabIndex = 10
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = False
        '
        'TextBox_anything
        '
        Me.TextBox_anything.Location = New System.Drawing.Point(576, 128)
        Me.TextBox_anything.Name = "TextBox_anything"
        Me.TextBox_anything.Size = New System.Drawing.Size(163, 22)
        Me.TextBox_anything.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button1.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(745, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 35)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(492, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(492, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(2, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(836, 64)
        Me.Panel1.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("TH SarabunPSK", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(282, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 45)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "ช่วงเวลาการเข้าทำงาน"
        '
        'searchby
        '
        Me.searchby.AutoSize = True
        Me.searchby.BackColor = System.Drawing.Color.Transparent
        Me.searchby.Font = New System.Drawing.Font("TH SarabunPSK", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.searchby.Location = New System.Drawing.Point(222, 121)
        Me.searchby.Name = "searchby"
        Me.searchby.Size = New System.Drawing.Size(337, 37)
        Me.searchby.TabIndex = 16
        Me.searchby.Text = "Search By StaffName or WardName:"
        '
        'Formworkin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImage = Global.project_g11.My.Resources.Resources.พื้นหลังงงง
        Me.ClientSize = New System.Drawing.Size(944, 477)
        Me.Controls.Add(Me.searchby)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_anything)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.shiftText)
        Me.Controls.Add(StaffIDLabel)
        Me.Controls.Add(Me.StaffIDTextBox)
        Me.Controls.Add(WardIDLabel)
        Me.Controls.Add(Me.WardIDTextBox)
        Me.Controls.Add(ShiftLabel)
        Me.Name = "Formworkin"
        Me.Text = "Formworkin"
        CType(Me.Wellmeadows_hospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Work_inBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Wellmeadows_hospitalDataSet As wellmeadows_hospitalDataSet
    Friend WithEvents Work_inBindingSource As BindingSource
    Friend WithEvents Work_inTableAdapter As wellmeadows_hospitalDataSetTableAdapters.Work_inTableAdapter
    Friend WithEvents TableAdapterManager As wellmeadows_hospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffIDTextBox As TextBox
    Friend WithEvents WardIDTextBox As TextBox
    Friend WithEvents shiftText As ComboBox
    Friend WithEvents save As Button
    Friend WithEvents TextBox_anything As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents searchby As Label
End Class
