Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class FormReportstaff
    Private connectionString As String = "Data Source=LAPTOP-L2CQBKP0\B6401290;Initial Catalog=wellmeadows_hospital;Integrated Security=True"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub FormReportstaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.Clear()
        Dim sqlDataAdapter = New SqlDataAdapter("SELECT * FROM view_sum_staff_in_wards", connectionString)
        Dim dataSet As DataSet = New DataSet()
        sqlDataAdapter.Fill(dataSet)

        Dim rprtDS1 = New ReportDataSource("sum_staffDataSet", dataSet.Tables.Item(0))
        ReportViewer1.LocalReport.DataSources.Add(rprtDS1)


        Dim sqlDataAdapterstaff_in = New SqlDataAdapter("SELECT * FROM view_staff_in_wards", connectionString)
        Dim dataSetstaffin As DataSet = New DataSet()
        sqlDataAdapterstaff_in.Fill(dataSetstaffin)

        Dim rprtDS2 = New ReportDataSource("staff_in_wardDataSet", dataSetstaffin.Tables.Item(0))
        ReportViewer1.LocalReport.DataSources.Add(rprtDS2)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class