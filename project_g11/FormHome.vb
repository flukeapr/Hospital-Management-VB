Public Class FormHome
    Private Sub Staff_Click(sender As Object, e As EventArgs)
        Dim sForm As FormMain
        sForm = New FormMain()
        sForm.ShowDialog()
    End Sub

    Private Sub Patient_Click(sender As Object, e As EventArgs)
        Dim sForm As FormPatient

        sForm = New FormPatient()
        sForm.ShowDialog()
    End Sub

    Private Sub Medication_Click(sender As Object, e As EventArgs)
        Dim sForm As FormMedicine
        sForm = New FormMedicine()
        sForm.ShowDialog()
    End Sub

    Private Sub Wards_Click(sender As Object, e As EventArgs)
        Dim sForm As FormWard
        sForm = New FormWard()
        sForm.ShowDialog()
    End Sub

    Private Sub Treatment_Click(sender As Object, e As EventArgs)
        Dim sForm As FormTreatment
        sForm = New FormTreatment()
        sForm.ShowDialog()
    End Sub

    Private Sub Picturestaff_Click(sender As Object, e As EventArgs) Handles Picturestaff.Click
        Dim sForm As FormMain
        sForm = New FormMain()
        sForm.ShowDialog()
    End Sub

    Private Sub PicturePatient_Click(sender As Object, e As EventArgs) Handles PicturePatient.Click
        Dim sForm As FormPatient

        sForm = New FormPatient()
        sForm.ShowDialog()
    End Sub

    Private Sub PictureMedication_Click(sender As Object, e As EventArgs) Handles PictureMedication.Click
        Dim sForm As FormMedicine
        sForm = New FormMedicine()
        sForm.ShowDialog()
    End Sub

    Private Sub Pictureward_Click_1(sender As Object, e As EventArgs) Handles Pictureward.Click
        Dim sForm As FormWard
        sForm = New FormWard()
        sForm.ShowDialog()
    End Sub

    Private Sub PictureTreatment_Click(sender As Object, e As EventArgs) Handles PictureTreatment.Click
        Dim sForm As FormTreatment
        sForm = New FormTreatment()
        sForm.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles name_hospital.Click

    End Sub

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Picturelogo_Click(sender As Object, e As EventArgs) Handles Picturelogo.Click
        Me.Hide()
        FormLogin.Show()

    End Sub
End Class