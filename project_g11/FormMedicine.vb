Imports System.Data.SqlClient

Public Class FormMedicine
    Private connectionString As String = "Data Source=LAPTOP-L2CQBKP0\B6401290;Initial Catalog=wellmeadows_hospital;Integrated Security=True"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub MedicineBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MedicineBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MedicineBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Wellmeadows_hospitalDataSet)
        Me.MedicineTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.medicine)
    End Sub

    Private Sub FormMedicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.medicine' table. You can move, or remove it, as needed.
        Me.MedicineTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.medicine)

    End Sub

    Private Sub btbmedcine_Click(sender As Object, e As EventArgs) Handles btbmedcine.Click
        Try
            sqlConnection.Open()
            Dim nameSreach = textsearch.Text
            Dim sql = "SELECT * FROM medicine WHERE drugID LIKE  '%" & nameSreach & "%' Or drug_name LIKE  '%" & nameSreach & "%' Or descriptions LIKE '%" & nameSreach & "%' "
            Dim cmd = sqlConnection.CreateCommand
            cmd.CommandText = sql



            Dim sqlReader = cmd.ExecuteReader()
            If sqlReader.HasRows Then
                Dim query As String = "drugID LIKE  '%" & nameSreach & "%' Or drug_name LIKE  '%" & nameSreach & "%' Or descriptions LIKE '%" & nameSreach & "%'"
                MedicineBindingSource.Filter = query
            Else
                textsearch.Text = "No medicine stock Here!!!!"
                'MsgBox("No staff work in hospital", "fail", MessageBoxButtons.RetryCancel)
            End If

            sqlConnection.Close()

        Catch ex As Exception
            MessageBox.Show("No medicine stock in hospital", "fail", CType(CStr(MessageBoxButtons.RetryCancel), MessageBoxButtons))

        End Try

        'Dim sForm As SearchMedicine
        'sForm = New SearchMedicine()
        'sForm.ShowDialog()
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        FormHome.Show()
    End Sub

    Private Sub textsearch_TextChanged(sender As Object, e As EventArgs) Handles textsearch.TextChanged
        If textsearch.Text Is "" Then
            MedicineBindingSource.RemoveFilter()
            Me.MedicineTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.medicine)
        End If
    End Sub
End Class