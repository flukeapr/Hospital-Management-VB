Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class FormReport

    Private connectionString As String = "Data Source=LAPTOP-L2CQBKP0\B6401290;Initial Catalog=wellmeadows_hospital;Integrated Security=True"
        Dim sqlConnection As New SqlConnection(connectionString)
        Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load


            Me.ReportViewer1.Clear()
        Dim sqlDataAdapter = New SqlDataAdapter("SELECT * FROM view_apply_wards", connectionString)
        Dim dataSet As DataSet = New DataSet()
            sqlDataAdapter.Fill(dataSet)

        Dim rprtDS1 = New ReportDataSource("apply_wardDataSet", dataSet.Tables.Item(0))
        ReportViewer1.LocalReport.DataSources.Add(rprtDS1)

        Dim sqlDataAdapterSumpatient = New SqlDataAdapter("SELECT * FROM view_sum_patient", connectionString)
        Dim dataSetSumpatient As DataSet = New DataSet()
        sqlDataAdapterSumpatient.Fill(dataSetSumpatient)

        Dim rprtDS2 = New ReportDataSource("sum_patient_DataSet", dataSetSumpatient.Tables.Item(0))
        ReportViewer1.LocalReport.DataSources.Add(rprtDS2)

        Dim sqlDataAdapterstaff = New SqlDataAdapter("SELECT * FROM staff", connectionString)
        Dim dataSetstaff As DataSet = New DataSet()
        sqlDataAdapterstaff.Fill(dataSetstaff)

        Dim rprtDS3 = New ReportDataSource("DataSet1", dataSetSumpatient.Tables.Item(0))
        ReportViewer1.LocalReport.DataSources.Add(rprtDS3)

        Me.ReportViewer1.RefreshReport()
        End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub
End Class
