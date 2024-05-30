Imports System.Data.SqlClient
Public Class FormSearch
    Dim sqlConnection As New SqlConnection("Data Source=Localhost\B6401290;Initial Catalog=wellmeadows_hospital;Integrated Security=True")
    Dim tablePatient As New DataTable
    Public PatientName As String
    Public PatientID As String


    Private Sub SearchPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlStatement As String = "SELECT * FROM patient WHERE PatientName LIKE '%" & TextBox1.Text & "%' Or  PatientID Like '%" & TextBox1.Text & "%' Or Next_of_kinName Like '%" & TextBox1.Text & "%'"
        Dim sqlCommand As New SqlCommand(sqlStatement, sqlConnection)
        Dim sqlReader As SqlDataReader

        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        tablePatient.Load(sqlReader)

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = tablePatient
        DataGridView1.Refresh()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class