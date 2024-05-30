Imports System.Data.SqlClient
Imports project_g11.wellmeadows_hospitalDataSetTableAdapters

Public Class FormPatient
    Private connectionString As String = "Data Source=LAPTOP-L2CQBKP0\B6401290;Initial Catalog=wellmeadows_hospital;Integrated Security=True"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub FormPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.patient)
        SexText.Items.Add("ชาย")
        SexText.Items.Add("หญิง")
        ComboBoxstatus.Items.Add("โสด")
        ComboBoxstatus.Items.Add("สมรส")
    End Sub

    Private Sub PatientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PatientBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Wellmeadows_hospitalDataSet)
        Me.PatientTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.patient)
    End Sub

    Private Sub patientsearch_Click(sender As Object, e As EventArgs) Handles patientsearch.Click
        Try
            sqlConnection.Open()
            Dim nameSreach = textBoxsearch.Text
            Dim sql = "SELECT * FROM patient WHERE PatientName LIKE  '%" & nameSreach & "%' Or Next_of_kinName LIKE '%" & nameSreach & "%' "
            Dim cmd = sqlConnection.CreateCommand
            cmd.CommandText = sql



            Dim sqlReader = cmd.ExecuteReader()
            If sqlReader.HasRows Then
                Dim query As String = "PatientName LIKE  '%" & nameSreach & "%'  Or Next_of_kinName LIKE '%" & nameSreach & "%'"
                PatientBindingSource.Filter = query
            Else
                textBoxsearch.Text = "No patient Here!!!!"
                MsgBox("No patient  in hospital", "fail", MessageBoxButtons.RetryCancel)
            End If

            sqlConnection.Close()

        Catch ex As Exception
            MessageBox.Show("No patient  in hospital", "fail", CType(CStr(MessageBoxButtons.RetryCancel), MessageBoxButtons))

        End Try
        'Dim sForm As FormSearch
        'sForm = New FormSearch()
        'sForm.ShowDialog()
    End Sub

    Private Sub textBoxsearch_TextChanged(sender As Object, e As EventArgs) Handles textBoxsearch.TextChanged
        If textBoxsearch.Text Is "" Then
            PatientBindingSource.RemoveFilter()
            Me.PatientTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.patient)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        FormHome.Show()
    End Sub

    Private Sub ToolStripButtonEdit_Click(sender As Object, e As EventArgs)
        PatientBindingSource.EndEdit()
    End Sub
End Class