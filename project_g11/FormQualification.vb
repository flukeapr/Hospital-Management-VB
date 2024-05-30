Imports System.Data.SqlClient

Public Class FormQualification
    Private connectionString As String = "Data Source=LAPTOP-L2CQBKP0\B6401290;Initial Catalog=wellmeadows_hospital;Integrated Security=True"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub QulificationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.QulificationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Wellmeadows_hospitalDataSet)
        Me.QulificationTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.qulification)
    End Sub

    Private Sub FormQualification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.qulification' table. You can move, or remove it, as needed.
        Me.QulificationTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.qulification)

    End Sub

    Private Sub Buttonsearch_Click(sender As Object, e As EventArgs) Handles Buttonsearch.Click
        Try


            sqlConnection.Open()
            Dim nameSreach = TextBoxsearch.Text
            Dim sql = "SELECT * FROM qulification WHERE staffID LIKE  '%" & nameSreach & "%'  "
            Dim cmd = sqlConnection.CreateCommand
            cmd.CommandText = sql

            Dim sqlReader = cmd.ExecuteReader()
            If sqlReader.HasRows Then
                Dim query As String = "staffID LIKE  '%" & nameSreach & "%'"
                QulificationBindingSource.Filter = query


            Else
                TextBoxsearch.Text = "No staff Here!!!!"
                'MsgBox("No staff work in hospital", "fail", MessageBoxButtons.RetryCancel)
            End If

            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show("No staff work in hospital", "fail", CType(CStr(MessageBoxButtons.RetryCancel), MessageBoxButtons))

        End Try
    End Sub

    Private Sub TextBoxsearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxsearch.TextChanged
        If TextBoxsearch.Text Is "" Then
            QulificationBindingSource.RemoveFilter()
            Me.QulificationTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.qulification)
        End If
    End Sub

    Private Sub WardsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles WardsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.QulificationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Wellmeadows_hospitalDataSet)
        Me.QulificationTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.qulification)
    End Sub
End Class