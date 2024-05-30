Imports System.Data.SqlClient

Public Class SearchMedicine
    Dim sqlConnection As New SqlConnection("Data Source=Localhost\B6401290;Initial Catalog=wellmeadows_hospital;Integrated Security=True")
    Dim tablemedicine As New DataTable
    Public medicineName As String
    Public medicineID As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sqlStatement As String = "SELECT * FROM medicine WHERE drug_name LIKE '%" & txtmedicine.Text & "%' Or drugID Like '%" & txtmedicine.Text & "%' Or descriptions Like '%" & txtmedicine.Text & "%'"
        Dim sqlCommand As New SqlCommand(sqlStatement, sqlConnection)
        Dim sqlReader As SqlDataReader


        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        tablemedicine.Load(sqlReader)

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = tablemedicine
        DataGridView1.Refresh()

    End Sub
End Class