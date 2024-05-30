Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class FormTreatment
    Private connectionString As String = "Data Source=LAPTOP-L2CQBKP0\B6401290;Initial Catalog=wellmeadows_hospital;Integrated Security=True"
    Dim sqlConnection As New SqlConnection(connectionString)

    Public apply_dgv As DataGridView
    Public medication_dgv As DataGridView
    Private Sub Apply_wardsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Apply_wardsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Wellmeadows_hospitalDataSet)

    End Sub

    Private Sub FormTreatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.view_medication' table. You can move, or remove it, as needed.
        Me.View_medicationTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.view_medication)
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.apply_wards' table. You can move, or remove it, as needed.
        Try
            Me.Apply_wardsTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.apply_wards)
        Catch ex As Exception
        End Try
        apply_dgv = Apply_wardsDataGridView
        medication_dgv = View_medicationDataGridView
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sForm As FormApply

        sForm = New FormApply()
        sForm.ShowDialog()
    End Sub

    Private Sub report_Click(sender As Object, e As EventArgs) Handles Staff_report.Click
        FormReportstaff.ShowDialog()
    End Sub

    Private Sub Apply_wardsDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles Apply_wardsDataGridView.DoubleClick
        Dim result As DialogResult
        result = MessageBox.Show("you need to delete datail", "yes or no", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            If Apply_wardsDataGridView.ColumnCount > 0 Then

                Dim applyID = Apply_wardsDataGridView.SelectedCells(0).Value.ToString
                Dim sql = "DELETE  FROM apply_wards WHERE apply_wardsID = '" & applyID & "'"
                Dim sqlCmd = sqlConnection.CreateCommand
                sqlCmd.CommandText = sql
                sqlConnection.Open()
                sqlCmd.ExecuteNonQuery()
                sqlConnection.Close()
                Apply_wardsDataGridView.Rows.Remove(Apply_wardsDataGridView.SelectedRows(0))
                loadDataGrdapply()

            End If
        End If
    End Sub

    Private Sub loadDataGrdapply()
        Dim sql = "SELECT * FROM apply_wards"
        Dim sqlAdapter = New SqlDataAdapter(sql, connectionString)
        Dim dataTable As DataTable = New DataTable()
        sqlAdapter.Fill(dataTable)
        Apply_wardsBindingSource.DataSource = dataTable

    End Sub

    Private Sub Medication_Click(sender As Object, e As EventArgs) Handles Medication.Click
        Dim sForm As FormMedication
        sForm = New FormMedication()
        sForm.ShowDialog()
    End Sub

    Private Sub View_medicationDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles View_medicationDataGridView.DoubleClick
        Dim result As DialogResult
        result = MessageBox.Show("you need to delete datail", "yes or no", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            If View_medicationDataGridView.ColumnCount > 0 Then

                Dim sID = View_medicationDataGridView.SelectedCells(0).Value.ToString
                Dim pID = View_medicationDataGridView.SelectedCells(2).Value.ToString
                Dim dID = View_medicationDataGridView.SelectedCells(4).Value.ToString
                Dim sql = "DELETE  FROM Medication WHERE staffID = '" & sID & "' AND patientID = '" & pID & "' AND drugID = '" & dID & "'"
                Dim sqlCmd = sqlConnection.CreateCommand
                sqlCmd.CommandText = sql
                sqlConnection.Open()
                sqlCmd.ExecuteNonQuery()
                sqlConnection.Close()
                View_medicationDataGridView.Rows.Remove(View_medicationDataGridView.SelectedRows(0))
                loadDataGrdmedication()

            End If
        End If
    End Sub

    Private Sub loadDataGrdmedication()
        Dim sql = "SELECT * FROM view_medication"
        Dim sqlAdapter = New SqlDataAdapter(sql, connectionString)
        Dim dataTable As DataTable = New DataTable()
        sqlAdapter.Fill(dataTable)
        View_medicationBindingSource.DataSource = dataTable

    End Sub

    Private Sub patient_report_Click(sender As Object, e As EventArgs) Handles patient_report.Click
        FormReport.ShowDialog()

    End Sub

    Private Sub Medication_report_Click(sender As Object, e As EventArgs) Handles Medication_report.Click
        FormMedication_report.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        FormHome.Show()
    End Sub
End Class