Imports System.Data.SqlClient
Imports Microsoft.Reporting.Map.WebForms.BingMaps

Public Class FormApply
    Private connectionString As String = "Data Source=LAPTOP-L2CQBKP0\B6401290;Initial Catalog=wellmeadows_hospital;Integrated Security=True"
    Dim sqlConnection As New SqlConnection(connectionString)


    Private Sub FormApply_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.bed' table. You can move, or remove it, as needed.
        Me.BedTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.bed)
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.room' table. You can move, or remove it, as needed.
        Me.RoomTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.room)
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.Wards' table. You can move, or remove it, as needed.
        Try
            Me.WardsTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.Wards)
        Catch ex As Exception

        End Try

        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.patient)
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.apply_wards' table. You can move, or remove it, as needed.
        Me.Apply_wardsTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.apply_wards)

    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        Dim apply_wardsID = Apply_wardsIDTextBox.Text
        Dim wardid = WardIDComboBox.Text
        Dim locationd = LocationComboBox.Text
        Dim PatientID = PatientIDComboBox.Text
        Dim PatientName = PatientNameComboBox.Text
        Dim Room_ID = Room_IDComboBox.Text
        Dim Bed_numbe = Bed_numberComboBox.Text
        Dim selectedDateS As DateTime = Start_dateDateTimePicker.Value
        Dim selectedDateF As DateTime = Finish_dateDateTimePicker.Value
        Dim connection As String = connectionString
        Dim sql As String = "INSERT INTO apply_wards (apply_wardsID,wardID,patientID,patientName,room_ID,bed_number,location,start_date,finish_date)
                    VALUES('" & apply_wardsID & "','" & wardid & "','" & PatientID & "','" & PatientName & "','" & Room_ID & "','" & Bed_numbe & "','" & locationd & "',@DateValueS,@DateValueF)
                           "
        Dim nullfinishdatesql As String = "INSERT INTO apply_wards (apply_wardsID,wardID,patientID,patientName,room_ID,bed_number,location,start_date)
                    VALUES('" & apply_wardsID & "','" & wardid & "','" & PatientID & "','" & PatientName & "','" & Room_ID & "','" & Bed_numbe & "','" & locationd & "',@DateValueS)
                           "
        Using sqlConnection As New SqlConnection(connectionString)
            If CheckBox1.Checked = True Then
                Dim sqlCommand As New SqlCommand(sql, sqlConnection)
                sqlCommand.Parameters.AddWithValue("@DateValueS", selectedDateS)
                sqlCommand.Parameters.AddWithValue("@DateValueF", selectedDateF)
                sqlConnection.Open()
                sqlCommand.ExecuteNonQuery()
                sqlConnection.Close()
            Else
                Dim sqlCommand As New SqlCommand(nullfinishdatesql, sqlConnection)
                sqlCommand.Parameters.AddWithValue("@DateValueS", selectedDateS)
                sqlCommand.Parameters.AddWithValue("@DateValueF", selectedDateF)
                sqlConnection.Open()
                sqlCommand.ExecuteNonQuery()
                sqlConnection.Close()
            End If

        End Using
        loadDataGrdapply()
        Me.Close()
    End Sub

    Private Sub loadDataGrdapply()
        If TypeOf FormTreatment.apply_dgv Is DataGridView Then
            Dim sql = "SELECT * FROM apply_wards"
            Dim sqlAdapter = New SqlDataAdapter(sql, connectionString)
            Dim dataTable As DataTable = New DataTable()
            sqlAdapter.Fill(dataTable)
            FormTreatment.Apply_wardsBindingSource.DataSource = dataTable
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Finish_dateDateTimePicker.Visible = True
        Else
            Finish_dateDateTimePicker.Visible = False
        End If
    End Sub
End Class