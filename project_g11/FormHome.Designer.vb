<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHome
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
        Me.Picturelogo = New System.Windows.Forms.PictureBox()
        Me.Picturestaff = New System.Windows.Forms.PictureBox()
        Me.PicturePatient = New System.Windows.Forms.PictureBox()
        Me.PictureMedication = New System.Windows.Forms.PictureBox()
        Me.Pictureward = New System.Windows.Forms.PictureBox()
        Me.PictureTreatment = New System.Windows.Forms.PictureBox()
        Me.TableALLpic = New System.Windows.Forms.TableLayoutPanel()
        Me.name_hospital = New System.Windows.Forms.Label()
        Me.Picturecoler = New System.Windows.Forms.PictureBox()
        Me.label_staff = New System.Windows.Forms.Label()
        Me.Label_patient = New System.Windows.Forms.Label()
        Me.Label_medicine = New System.Windows.Forms.Label()
        Me.Label_ward = New System.Windows.Forms.Label()
        Me.Label_Treatment = New System.Windows.Forms.Label()
        CType(Me.Picturelogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picturestaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePatient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureMedication, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pictureward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureTreatment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableALLpic.SuspendLayout()
        CType(Me.Picturecoler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picturelogo
        '
        Me.Picturelogo.BackColor = System.Drawing.Color.MediumPurple
        Me.Picturelogo.Image = Global.project_g11.My.Resources.Resources._8eb7301f02db8e5f58b8471f425a2871_hd_removebg_preview1
        Me.Picturelogo.Location = New System.Drawing.Point(26, 12)
        Me.Picturelogo.Name = "Picturelogo"
        Me.Picturelogo.Size = New System.Drawing.Size(135, 104)
        Me.Picturelogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picturelogo.TabIndex = 1
        Me.Picturelogo.TabStop = False
        '
        'Picturestaff
        '
        Me.Picturestaff.BackColor = System.Drawing.Color.Transparent
        Me.Picturestaff.Image = Global.project_g11.My.Resources.Resources.staff_removebg_preview1
        Me.Picturestaff.Location = New System.Drawing.Point(3, 3)
        Me.Picturestaff.Name = "Picturestaff"
        Me.Picturestaff.Size = New System.Drawing.Size(162, 114)
        Me.Picturestaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picturestaff.TabIndex = 0
        Me.Picturestaff.TabStop = False
        '
        'PicturePatient
        '
        Me.PicturePatient.Image = Global.project_g11.My.Resources.Resources.pa
        Me.PicturePatient.Location = New System.Drawing.Point(3, 123)
        Me.PicturePatient.Name = "PicturePatient"
        Me.PicturePatient.Size = New System.Drawing.Size(162, 114)
        Me.PicturePatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicturePatient.TabIndex = 2
        Me.PicturePatient.TabStop = False
        '
        'PictureMedication
        '
        Me.PictureMedication.Image = Global.project_g11.My.Resources.Resources.R_removebg_preview
        Me.PictureMedication.Location = New System.Drawing.Point(3, 243)
        Me.PictureMedication.Name = "PictureMedication"
        Me.PictureMedication.Size = New System.Drawing.Size(162, 114)
        Me.PictureMedication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureMedication.TabIndex = 3
        Me.PictureMedication.TabStop = False
        '
        'Pictureward
        '
        Me.Pictureward.Image = Global.project_g11.My.Resources.Resources.ward
        Me.Pictureward.Location = New System.Drawing.Point(3, 363)
        Me.Pictureward.Name = "Pictureward"
        Me.Pictureward.Size = New System.Drawing.Size(162, 114)
        Me.Pictureward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pictureward.TabIndex = 4
        Me.Pictureward.TabStop = False
        '
        'PictureTreatment
        '
        Me.PictureTreatment.Image = Global.project_g11.My.Resources.Resources.tr
        Me.PictureTreatment.Location = New System.Drawing.Point(3, 483)
        Me.PictureTreatment.Name = "PictureTreatment"
        Me.PictureTreatment.Size = New System.Drawing.Size(162, 115)
        Me.PictureTreatment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureTreatment.TabIndex = 5
        Me.PictureTreatment.TabStop = False
        '
        'TableALLpic
        '
        Me.TableALLpic.ColumnCount = 1
        Me.TableALLpic.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableALLpic.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableALLpic.Controls.Add(Me.PicturePatient, 0, 1)
        Me.TableALLpic.Controls.Add(Me.PictureTreatment, 0, 4)
        Me.TableALLpic.Controls.Add(Me.Picturestaff, 0, 0)
        Me.TableALLpic.Controls.Add(Me.Pictureward, 0, 3)
        Me.TableALLpic.Controls.Add(Me.PictureMedication, 0, 2)
        Me.TableALLpic.Location = New System.Drawing.Point(362, 184)
        Me.TableALLpic.Name = "TableALLpic"
        Me.TableALLpic.RowCount = 5
        Me.TableALLpic.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableALLpic.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableALLpic.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableALLpic.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableALLpic.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableALLpic.Size = New System.Drawing.Size(168, 601)
        Me.TableALLpic.TabIndex = 6
        '
        'name_hospital
        '
        Me.name_hospital.AutoSize = True
        Me.name_hospital.BackColor = System.Drawing.Color.MediumPurple
        Me.name_hospital.Font = New System.Drawing.Font("TH SarabunPSK", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.name_hospital.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.name_hospital.Location = New System.Drawing.Point(180, 9)
        Me.name_hospital.Name = "name_hospital"
        Me.name_hospital.Size = New System.Drawing.Size(625, 105)
        Me.name_hospital.TabIndex = 7
        Me.name_hospital.Text = "Wellmeadows Hospital"
        '
        'Picturecoler
        '
        Me.Picturecoler.BackColor = System.Drawing.Color.MediumPurple
        Me.Picturecoler.Dock = System.Windows.Forms.DockStyle.Top
        Me.Picturecoler.Location = New System.Drawing.Point(0, 0)
        Me.Picturecoler.Name = "Picturecoler"
        Me.Picturecoler.Size = New System.Drawing.Size(982, 117)
        Me.Picturecoler.TabIndex = 8
        Me.Picturecoler.TabStop = False
        '
        'label_staff
        '
        Me.label_staff.AutoSize = True
        Me.label_staff.BackColor = System.Drawing.Color.Transparent
        Me.label_staff.Font = New System.Drawing.Font("Mogra", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_staff.Location = New System.Drawing.Point(572, 225)
        Me.label_staff.Name = "label_staff"
        Me.label_staff.Size = New System.Drawing.Size(115, 44)
        Me.label_staff.TabIndex = 9
        Me.label_staff.Text = "STAFF"
        '
        'Label_patient
        '
        Me.Label_patient.AutoSize = True
        Me.Label_patient.BackColor = System.Drawing.Color.Transparent
        Me.Label_patient.Font = New System.Drawing.Font("Mogra", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_patient.Location = New System.Drawing.Point(177, 334)
        Me.Label_patient.Name = "Label_patient"
        Me.Label_patient.Size = New System.Drawing.Size(154, 44)
        Me.Label_patient.TabIndex = 10
        Me.Label_patient.Text = "PATIENT"
        '
        'Label_medicine
        '
        Me.Label_medicine.AutoSize = True
        Me.Label_medicine.BackColor = System.Drawing.Color.Transparent
        Me.Label_medicine.Font = New System.Drawing.Font("Mogra", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_medicine.Location = New System.Drawing.Point(572, 469)
        Me.Label_medicine.Name = "Label_medicine"
        Me.Label_medicine.Size = New System.Drawing.Size(211, 44)
        Me.Label_medicine.TabIndex = 11
        Me.Label_medicine.Text = "MEDICATION"
        '
        'Label_ward
        '
        Me.Label_ward.AutoSize = True
        Me.Label_ward.BackColor = System.Drawing.Color.Transparent
        Me.Label_ward.Font = New System.Drawing.Font("Mogra", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ward.Location = New System.Drawing.Point(222, 586)
        Me.Label_ward.Name = "Label_ward"
        Me.Label_ward.Size = New System.Drawing.Size(109, 44)
        Me.Label_ward.TabIndex = 12
        Me.Label_ward.Text = "WARD"
        '
        'Label_Treatment
        '
        Me.Label_Treatment.AutoSize = True
        Me.Label_Treatment.BackColor = System.Drawing.Color.Transparent
        Me.Label_Treatment.Font = New System.Drawing.Font("Mogra", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Treatment.Location = New System.Drawing.Point(572, 703)
        Me.Label_Treatment.Name = "Label_Treatment"
        Me.Label_Treatment.Size = New System.Drawing.Size(212, 44)
        Me.Label_Treatment.TabIndex = 13
        Me.Label_Treatment.Text = "TREATMENT"
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.project_g11.My.Resources.Resources.พื้นหลังงงง
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 953)
        Me.Controls.Add(Me.Label_Treatment)
        Me.Controls.Add(Me.Label_ward)
        Me.Controls.Add(Me.Label_medicine)
        Me.Controls.Add(Me.Label_patient)
        Me.Controls.Add(Me.label_staff)
        Me.Controls.Add(Me.TableALLpic)
        Me.Controls.Add(Me.Picturelogo)
        Me.Controls.Add(Me.name_hospital)
        Me.Controls.Add(Me.Picturecoler)
        Me.Name = "FormHome"
        Me.Text = "FormHome"
        CType(Me.Picturelogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picturestaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePatient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureMedication, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pictureward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureTreatment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableALLpic.ResumeLayout(False)
        CType(Me.Picturecoler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Picturestaff As PictureBox
    Friend WithEvents Picturelogo As PictureBox
    Friend WithEvents PicturePatient As PictureBox
    Friend WithEvents PictureMedication As PictureBox
    Friend WithEvents Pictureward As PictureBox
    Friend WithEvents PictureTreatment As PictureBox
    Friend WithEvents TableALLpic As TableLayoutPanel
    Friend WithEvents name_hospital As Label
    Friend WithEvents Picturecoler As PictureBox
    Friend WithEvents label_staff As Label
    Friend WithEvents Label_patient As Label
    Friend WithEvents Label_medicine As Label
    Friend WithEvents Label_ward As Label
    Friend WithEvents Label_Treatment As Label
End Class
