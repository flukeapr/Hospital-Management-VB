Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing

Public Class Formworkin
    Private connectionString As String = "Data Source=LAPTOP-L2CQBKP0\B6401290;Initial Catalog=wellmeadows_hospital;Integrated Security=True"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub Work_inBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Work_inBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Wellmeadows_hospitalDataSet)
        Me.Work_inTableAdapter.Fill(Wellmeadows_hospitalDataSet.Work_in)
    End Sub

    Private Sub Formworkinvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_hospitalDataSet.Work_in' table. You can move, or remove it, as needed.
        Me.Work_inTableAdapter.Fill(Me.Wellmeadows_hospitalDataSet.Work_in)
        shiftText.Items.Add("กลางวัน")
        shiftText.Items.Add("กลางคืน")
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click

        Dim staffid = StaffIDTextBox.Text
        Dim wardid = WardIDTextBox.Text
        Dim shift = shiftText.Text
        Dim sql = "INSERT INTO Work_in (staffID,wardID,shift)
                    VALUES('" & staffid & "','" & wardid & "','" & shift & "')
                           "
        Using sqlCommand As New SqlCommand(sql, sqlConnection)
            sqlConnection.Open()

            sqlCommand.ExecuteNonQuery()
            sqlConnection.Close()
        End Using

        loadDataGrdwork()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim anythingSearch = TextBox_anything.Text
        Dim sqlStatement As String = "SELECT * FROM view_search_shift WHERE staffName LIKE '%" & anythingSearch & "%' Or wardName LIKE '%" & anythingSearch & "%' "
        Debug.Write(sqlStatement)
        Dim cmd = sqlConnection.CreateCommand
        cmd.CommandText = sqlStatement
        sqlConnection.Open()
        Dim sqlReader = cmd.ExecuteReader()


        If sqlReader.Read() Then
            If Not IsDBNull(sqlReader(2)) Then
                Dim value1 As String = sqlReader.Item("staffID")
                Dim value2 As String = sqlReader.Item("staffName")
                Dim concatS As String = value1 & ": " & value2
                Dim value3 As String = sqlReader.Item("wardID")
                Dim value4 As String = sqlReader.Item("wardName")
                Dim concatW As String = value3 & ": " & value4

                Label2.Text = concatW
                Label1.Text = concatS
            Else
                Dim value1 As String = sqlReader.Item("staffID")
                Dim value2 As String = sqlReader.Item("staffName")
                Dim concatS As String = value1 & ": " & value2
                Dim value3 As String = " "
                Dim value4 As String = " "
                Dim concatW As String = value3 & ": " & value4
                Label2.Text = concatW
                Label1.Text = concatS
            End If
        End If



        '  Label2.Text = sqlReader.Item("wardName")
        sqlReader.Close()
        sqlConnection.Close()

    End Sub

    Private Sub TextBox_anything_TextChanged(sender As Object, e As EventArgs) Handles TextBox_anything.TextChanged

    End Sub

    Private Sub shiftText_SelectedIndexChanged(sender As Object, e As EventArgs) Handles shiftText.SelectedIndexChanged

    End Sub

    Private Sub loadDataGrdwork()
        If TypeOf FormWard.Work_in_viewDgv Is DataGridView Then
            Dim sql = "SELECT * FROM Work_in_view"
            Dim sqlAdapter = New SqlDataAdapter(sql, connectionString)
            Dim dataTable As DataTable = New DataTable()
            sqlAdapter.Fill(dataTable)
            FormWard.Work_in_viewBindingSource.DataSource = dataTable
        End If
    End Sub

    Private Sub searchby_Click(sender As Object, e As EventArgs) Handles searchby.Click

    End Sub
End Class