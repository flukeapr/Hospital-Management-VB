Imports System.Data.SqlClient

Public Class FormExperience
    Private connectionString As String = "Data Source=LAPTOP-L2CQBKP0\B6401290;Initial Catalog=wellmeadows_hospital;Integrated Security=True"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub Work_experienceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Work_experienceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Work_experienceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Wellmeadows_hospitalDataSet)
        Me.Work_experienceTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.work_experience)
    End Sub

    Private Sub FormExperience_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.work_experience' table. You can move, or remove it, as needed.
        Me.Work_experienceTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.work_experience)

    End Sub

    Private Sub Buttonsearch_Click(sender As Object, e As EventArgs) Handles Buttonsearch.Click
        Try


            SqlConnection.Open()
            Dim nameSreach = TextBoxsearch.Text
            Dim sql = "SELECT * FROM work_experience WHERE staffID LIKE  '%" & nameSreach & "%'  "
            Dim cmd = SqlConnection.CreateCommand
            cmd.CommandText = sql

            Dim sqlReader = cmd.ExecuteReader()
            If sqlReader.HasRows Then
                Dim query As String = "staffID LIKE  '%" & nameSreach & "%'"
                Work_experienceBindingSource.Filter = query


            Else
                TextBoxsearch.Text = "No staff Here!!!!"
                'MsgBox("No staff work in hospital", "fail", MessageBoxButtons.RetryCancel)
            End If

            SqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show("No staff work in hospital", "fail", CType(CStr(MessageBoxButtons.RetryCancel), MessageBoxButtons))

        End Try
    End Sub

    Private Sub TextBoxsearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxsearch.TextChanged
        If TextBoxsearch.Text Is "" Then
            Work_experienceBindingSource.RemoveFilter()
            Me.Work_experienceTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.work_experience)
        End If
    End Sub
End Class