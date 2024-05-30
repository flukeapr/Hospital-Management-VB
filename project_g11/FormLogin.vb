Public Class FormLogin

    Private Sub Button_login_Click(sender As Object, e As EventArgs) Handles Button_login.Click
        If TextBox_login.Text = "admin" And TextBox_password.Text = "123456" Then
            MsgBox(" ยินดีต้อนรับสู่ระบบ ")
            TextBox_login.Text = ""
            TextBox_password.Text = ""
            'ใส่formที่ต้องการลิ้ง  .Show()
            FormHome.Show()
            Me.Hide()
        Else
            MsgBox(" กรุณาตรวจสอบข้อมูลอีกครั้ง ")
            TextBox_login.Text = ""
            TextBox_password.Text = ""
        End If
    End Sub

    Private Sub Button_close_Click(sender As Object, e As EventArgs) Handles Button_close.Click
        Me.Close()
    End Sub

    Private Sub TextBox_login_TextChanged(sender As Object, e As EventArgs) Handles TextBox_login.TextChanged

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Username_Click(sender As Object, e As EventArgs) Handles Username.Click

    End Sub

    Private Sub Picturelogin_Click(sender As Object, e As EventArgs) Handles Picturelogin.Click

    End Sub
End Class