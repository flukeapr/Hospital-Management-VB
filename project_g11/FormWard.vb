Imports System.Data.SqlClient
Imports project_g11.wellmeadows_hospitalDataSetTableAdapters

Public Class FormWard
    Private connectionString As String = "Data Source=LAPTOP-L2CQBKP0\B6401290;Initial Catalog=wellmeadows_hospital;Integrated Security=True"
    Dim sqlConnection As New SqlConnection(connectionString)
    Public Work_in_viewDgv As DataGridView

    Private Sub WardsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles WardsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WardsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Wellmeadows_hospitalDataSet)
        Me.WardsTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.Wards)
    End Sub

    Private Sub FormWard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.Work_in_view' table. You can move, or remove it, as needed.
        Me.Work_in_viewTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.Work_in_view)
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.Wards' table. You can move, or remove it, as needed.
        Try
            Me.WardsTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.Wards)
        Catch ex As Exception
        End Try
        Try
            Work_in_viewDgv = Work_in_viewDataGridView
        Catch ex As Exception
        End Try

    End Sub

    Private Sub wardsearch_Click(sender As Object, e As EventArgs) Handles wardsearch.Click
        Try
            sqlConnection.Open()
            Dim nameSreach = textsearch.Text
            Dim sql = "SELECT * FROM Wards WHERE wardID LIKE '%" & nameSreach & "%' Or wardname LIKE  '%" & nameSreach & "%' "
            Dim cmd = sqlConnection.CreateCommand
            cmd.CommandText = sql



            Dim sqlReader = cmd.ExecuteReader()
            If sqlReader.HasRows Then
                Dim query As String = "wardID LIKE '%" & nameSreach & "%' Or wardname LIKE  '%" & nameSreach & "%'  "
                WardsBindingSource.Filter = query
            Else
                textsearch.Text = "No wards in hospital!!!!"
                MsgBox("No wards in hospital!!!!", "fail", MessageBoxButtons.RetryCancel)
            End If

            sqlConnection.Close()

        Catch ex As Exception
            MessageBox.Show("No wards in hospital", "fail", CType(CStr(MessageBoxButtons.RetryCancel), MessageBoxButtons))

        End Try
    End Sub

    Private Sub shift_Click(sender As Object, e As EventArgs) Handles shift.Click
        Dim sForm As Formworkin
        sForm = New Formworkin()
        sForm.ShowDialog()
    End Sub

    Private Sub textsearch_TextChanged(sender As Object, e As EventArgs) Handles textsearch.TextChanged
        If textsearch.Text Is "" Then
            WardsBindingSource.RemoveFilter()
            Me.WardsTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.Wards)
        End If
    End Sub

    Private Sub Work_in_viewDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles Work_in_viewDataGridView.DoubleClick
        Dim result As DialogResult
        result = MessageBox.Show("you need to delete datail?", "yes or no", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            If Work_in_viewDataGridView.ColumnCount > 0 Then

                Dim staffid = Work_in_viewDataGridView.SelectedCells(0).Value.ToString
                Dim wardid = Work_in_viewDataGridView.SelectedCells(2).Value.ToString
                Dim sql = "DELETE  FROM Work_in WHERE staffID = '" & staffid & "' AND wardID = '" & wardid & "'"
                Dim sqlCmd = sqlConnection.CreateCommand
                sqlCmd.CommandText = sql
                sqlConnection.Open()
                sqlCmd.ExecuteNonQuery()
                sqlConnection.Close()
                Work_in_viewDataGridView.Rows.Remove(Work_in_viewDataGridView.SelectedRows(0))
                loadDataGrd()

            End If
        End If
    End Sub

    Private Sub loadDataGrd()
        Dim sql = "SELECT * FROM Work_in_view"
        Dim sqlAdapter = New SqlDataAdapter(sql, connectionString)
        Dim dataTable As DataTable = New DataTable()
        sqlAdapter.Fill(dataTable)
        Work_in_viewBindingSource.DataSource = dataTable

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        FormHome.Show()
    End Sub
End Class