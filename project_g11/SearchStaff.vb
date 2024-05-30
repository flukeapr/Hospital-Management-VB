Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SearchSataff
    Dim sqlConnection As New SqlConnection("Data Source=Localhost\B6401290;Initial Catalog=wellmeadows_hospital;Integrated Security=True")
    Dim tablestaff As New DataTable
    Public staffName As String
    Public staffID As String
    Public position As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlStatement As String = "SELECT * FROM staff WHERE position LIKE '%" & txtstaff.Text & "%' Or  staffID Like '%" & txtstaff.Text & "%' Or  staffName Like '%" & txtstaff.Text & "%'"
        Dim sqlCommand As New SqlCommand(sqlStatement, sqlConnection)
        Dim sqlReader As SqlDataReader
        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()
        tablestaff.Load(sqlReader)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = tablestaff
        DataGridView1.Refresh()

    End Sub

    Private Sub SearchSataff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class