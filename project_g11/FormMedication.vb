Imports System.Data.SqlClient
Imports System.Xml
Imports project_g11.wellmeadows_hospitalDataSetTableAdapters

Public Class FormMedication
    Private connectionString As String = "Data Source=LAPTOP-L2CQBKP0\B6401290;Initial Catalog=wellmeadows_hospital;Integrated Security=True"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TypeOf FormMain.staff_BD Is DataTable Then
            Dim idSearch = StaffIDTextBox3.Text
            Dim sqlStatement As String = "SELECT * FROM staff WHERE staffName LIKE '%" & idSearch & "%' "
            Debug.Write(sqlStatement)
            Dim cmd = sqlConnection.CreateCommand
            cmd.CommandText = sqlStatement
            sqlConnection.Open()
            Dim sqlReader = cmd.ExecuteReader()
            If sqlReader.HasRows Then
                sqlReader.Read()
                StaffIDTextBox4.Text = sqlReader.Item("staffID")
            Else
                MessageBox.Show("No staff in hospital", "fail", CType(CStr(MessageBoxButtons.RetryCancel), MessageBoxButtons))
            End If
            sqlReader.Close()
                sqlConnection.Close()
            End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim idSearch = PatientIDTextBox2.Text
        Dim sqlStatement As String = "SELECT * FROM patient WHERE patientName LIKE '%" & idSearch & "%' "
        Debug.Write(sqlStatement)
        Dim cmd = sqlConnection.CreateCommand
        cmd.CommandText = sqlStatement
        sqlConnection.Open()
        Dim sqlReader = cmd.ExecuteReader()
        If sqlReader.HasRows Then
            sqlReader.Read()
            PatientIDTextBox3.Text = sqlReader.Item("patientID")
        Else
            MessageBox.Show("No patient in hospital", "fail", CType(CStr(MessageBoxButtons.RetryCancel), MessageBoxButtons))
        End If
        sqlReader.Close()
        sqlConnection.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Dim idSearch = DrugIDTextBox2.Text

        Dim sqlStatement As String = "SELECT * FROM medicine WHERE drug_name LIKE '%" & idSearch & "%' Or descriptions LIKE '%" & idSearch & "%'"
        Debug.Write(sqlStatement)
        Dim cmd = sqlConnection.CreateCommand
        cmd.CommandText = sqlStatement
        sqlConnection.Open()
        Dim sqlReader = cmd.ExecuteReader()
        If sqlReader.HasRows Then
            sqlReader.Read()
            DrugIDTextBox3.Text = sqlReader.Item("drugID")
            Dim Dname = sqlReader.Item("drug_name")
            Dim DID = DrugIDTextBox3.Text
            Dim Descriptions = sqlReader.Item("descriptions")
            Dim dosage = sqlReader.Item("dosage")
            Dim row As String() = {DID, Dname, Descriptions, dosage}
            DataGridView_drug.Rows.Add(row)
        Else
            MessageBox.Show("No drug stock in hospital", "fail", CType(CStr(MessageBoxButtons.RetryCancel), MessageBoxButtons))
        End If
        sqlReader.Close()
        sqlConnection.Close()
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        sqlConnection.Open()
        Dim sqlcmd = sqlConnection.CreateCommand
        For Each row As DataGridViewRow In DataGridViewaddtoDB.Rows
            Dim staffid = row.Cells(0).Value
            Dim patientid = row.Cells(1).Value
            Dim drugid = row.Cells(2).Value
            Dim sql = "INSERT INTO Medication (staffID,patientID,drugID)
                    VALUES('" & staffid & "','" & patientid & "','" & drugid & "')
                           "
            Dim sqlCommand As New SqlCommand(sql, sqlConnection)
            sqlcmd.CommandText = sql
            Try
                sqlcmd.ExecuteNonQuery()
            Catch ex As Exception
            End Try
        Next
        sqlConnection.Close()
        loadDataGrd()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        FormTreatment.Show()
    End Sub

    Private Sub MedicationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MedicationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Wellmeadows_hospitalDataSet)

    End Sub

    Private Sub FormMedication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.Medication' table. You can move, or remove it, as needed.
        Me.MedicationTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.Medication)

    End Sub

    'Private Sub DrugIDTextBox2_TextChanged(sender As Object, e As EventArgs) Handles DrugIDTextBox2.TextChanged
    '    If DrugIDTextBox2.Text Is "" Then
    '        DataGridView_drug.Rows.Clear()
    '        DrugIDTextBox3.Text = ""

    '    End If
    'End Sub

    'Private Sub PatientIDTextBox2_TextChanged(sender As Object, e As EventArgs) Handles PatientIDTextBox2.TextChanged
    '    If PatientIDTextBox2.Text Is "" Then
    '        PatientIDTextBox3.Text = ""

    '    End If
    'End Sub

    'Private Sub StaffIDTextBox3_TextChanged(sender As Object, e As EventArgs) Handles StaffIDTextBox3.TextChanged
    '    If StaffIDTextBox3.Text Is "" Then
    '        StaffIDTextBox4.Text = ""

    '    End If

    'End Sub

    Private Sub Buttonadd_Click(sender As Object, e As EventArgs) Handles Buttonadd.Click
        Dim Sid = StaffIDTextBox4.Text
        Dim Pid = PatientIDTextBox3.Text
        Dim Did = DrugIDTextBox3.Text
        Dim row As String() = {Sid, Pid, Did}
        DataGridViewaddtoDB.Rows.Add(row)
    End Sub

    Private Sub DataGridViewaddtoDB_DoubleClick(sender As Object, e As EventArgs) Handles DataGridViewaddtoDB.DoubleClick
        Dim result As DialogResult
        result = MessageBox.Show("you need to delete datail", "yes or no", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            If DataGridViewaddtoDB.ColumnCount > 0 Then
                DataGridViewaddtoDB.Rows.Remove(DataGridViewaddtoDB.SelectedRows(0))


            End If
        End If
    End Sub
    Private Sub loadDataGrd()
        If TypeOf FormTreatment.medication_dgv Is DataGridView Then
            Dim sql = "SELECT * FROM view_medication"
            Dim sqlAdapter = New SqlDataAdapter(sql, connectionString)
            Dim dataTable As DataTable = New DataTable()
            sqlAdapter.Fill(dataTable)
            FormTreatment.View_medicationBindingSource.DataSource = dataTable
        End If
    End Sub

End Class