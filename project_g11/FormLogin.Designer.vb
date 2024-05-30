<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.Username = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.TextBox_login = New System.Windows.Forms.TextBox()
        Me.TextBox_password = New System.Windows.Forms.TextBox()
        Me.Button_login = New System.Windows.Forms.Button()
        Me.Button_close = New System.Windows.Forms.Button()
        Me.Picturelogin = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Picturelogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.BackColor = System.Drawing.Color.Transparent
        Me.Username.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Username.Location = New System.Drawing.Point(352, 429)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(89, 31)
        Me.Username.TabIndex = 1
        Me.Username.Text = "Username"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.BackColor = System.Drawing.Color.Transparent
        Me.Password.Font = New System.Drawing.Font("TH SarabunPSK", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Password.Location = New System.Drawing.Point(352, 472)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(81, 31)
        Me.Password.TabIndex = 2
        Me.Password.Text = "Password"
        '
        'TextBox_login
        '
        Me.TextBox_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox_login.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox_login.Location = New System.Drawing.Point(456, 434)
        Me.TextBox_login.Name = "TextBox_login"
        Me.TextBox_login.Size = New System.Drawing.Size(157, 23)
        Me.TextBox_login.TabIndex = 3
        '
        'TextBox_password
        '
        Me.TextBox_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox_password.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox_password.Location = New System.Drawing.Point(456, 472)
        Me.TextBox_password.Name = "TextBox_password"
        Me.TextBox_password.Size = New System.Drawing.Size(157, 23)
        Me.TextBox_password.TabIndex = 4
        Me.TextBox_password.UseSystemPasswordChar = True
        '
        'Button_login
        '
        Me.Button_login.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button_login.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_login.Location = New System.Drawing.Point(375, 538)
        Me.Button_login.Name = "Button_login"
        Me.Button_login.Size = New System.Drawing.Size(103, 45)
        Me.Button_login.TabIndex = 5
        Me.Button_login.Text = "Login"
        Me.Button_login.UseVisualStyleBackColor = False
        '
        'Button_close
        '
        Me.Button_close.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button_close.ForeColor = System.Drawing.Color.Snow
        Me.Button_close.Location = New System.Drawing.Point(513, 538)
        Me.Button_close.Name = "Button_close"
        Me.Button_close.Size = New System.Drawing.Size(100, 45)
        Me.Button_close.TabIndex = 6
        Me.Button_close.Text = "Close"
        Me.Button_close.UseVisualStyleBackColor = False
        '
        'Picturelogin
        '
        Me.Picturelogin.BackColor = System.Drawing.Color.Transparent
        Me.Picturelogin.Image = CType(resources.GetObject("Picturelogin.Image"), System.Drawing.Image)
        Me.Picturelogin.Location = New System.Drawing.Point(438, 231)
        Me.Picturelogin.Name = "Picturelogin"
        Me.Picturelogin.Size = New System.Drawing.Size(123, 118)
        Me.Picturelogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picturelogin.TabIndex = 7
        Me.Picturelogin.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("TH SarabunPSK", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(434, 370)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 45)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ลงชื่อเข้าใช้"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.BackgroundImage = Global.project_g11.My.Resources.Resources.พื้นหลังงงง
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 953)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Picturelogin)
        Me.Controls.Add(Me.Button_close)
        Me.Controls.Add(Me.Button_login)
        Me.Controls.Add(Me.TextBox_password)
        Me.Controls.Add(Me.TextBox_login)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Name = "FormLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "FormLogin"
        CType(Me.Picturelogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Username As Label
    Friend WithEvents Password As Label
    Friend WithEvents TextBox_login As TextBox
    Friend WithEvents TextBox_password As TextBox
    Friend WithEvents Button_login As Button
    Friend WithEvents Button_close As Button
    Friend WithEvents Picturelogin As PictureBox
    Friend WithEvents Label1 As Label
End Class
