Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class FormMedication_report
    Private connectionString As String = "Data Source=LAPTOP-L2CQBKP0\B6401290;Initial Catalog=wellmeadows_hospital;Integrated Security=True"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub FormMedication_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.Clear()
        Dim sqlDataAdapter = New SqlDataAdapter("SELECT * FROM view_sum_medication", connectionString)
        Dim dataSet As DataSet = New DataSet()
        sqlDataAdapter.Fill(dataSet)

        Dim rprtDS1 = New ReportDataSource("sum_medicationDataSet", dataSet.Tables.Item(0))
        ReportViewer1.LocalReport.DataSources.Add(rprtDS1)


        Dim sqlDataAdaptermedication = New SqlDataAdapter("SELECT * FROM view_medication", connectionString)
        Dim dataSetmedicaiton As DataSet = New DataSet()
        sqlDataAdaptermedication.Fill(dataSetmedicaiton)

        Dim rprtDS2 = New ReportDataSource("medicationDataSet", dataSetmedicaiton.Tables.Item(0))
        ReportViewer1.LocalReport.DataSources.Add(rprtDS2)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class