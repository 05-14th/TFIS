Imports System.Net

Public Class routeAssignForm
    Dim num As Integer

    Private Sub PopulateComboBox(query As String)
        Try
            readQuery(query)
            franchisee_cb.Items.Clear()
            While cmdRead.Read()
                If cmdRead.GetString("middle_name") = Nothing Then
                    franchisee_cb.Items.Add($"{cmdRead.GetString("last_name")}, {cmdRead.GetString("first_name")}")
                Else
                    franchisee_cb.Items.Add($"{cmdRead.GetString("last_name")}, {cmdRead.GetString("first_name")}, {cmdRead.GetString("middle_name")}")
                End If
            End While
            cmdRead.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ForeverButton1_Click(sender As Object, e As EventArgs) Handles ForeverButton1.Click
        Try
            openConn("tfis_db")

            ' 3. Insert franchisee with the correct address_id
            Dim query As String = String.Format("
                INSERT INTO tfis_vehicle (
                    route_name,
                    start_point,
                    end_point,
                    distance,
                    estimated_travel_time,
                    operating_hours,
                    frequency,
                    allowed_vehicle_type,
                    maximum_passenger_capacity,
                    fare_structure,
                    assigned_franchisee,
                    date_assigned,
                    renewal_date,
                    route_status
                ) VALUES (
                    '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', {13}
                );", rn_txtbox.Text.Replace("'", "''"),
                     sp_txtbox.Text.Replace("'", "''"),
                     ep_txtbox.Text.Replace("'", "''"),
                     distance_txtbox.Text.Replace("'", "''"),
                     ett_txtbox.Text.Replace("'", "''"),
                     oh_txtbox.Text.Replace("'", "''"),
                     frequency_txtbox.Text.Replace("'", "''"),
                     vt_cb.SelectedItem().ToString.Replace("'", "''"),
                     mpc_txtbox.Text.Replace("'", "''"),
                     fare_txtbox.Text.Replace("'", "''"),
                     num,
                     doa_dt.Value.ToString("yyyy-MM-dd"),
                     rd_dt.Value.ToString("yyyy-MM-dd"),
                     status_cb.SelectedItem.ToString().Replace("'", "''"))

            executeQuery(query)

            MessageBox.Show("Vehicle successfully inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ClearFormControls(Me)
            conn.Close()
        End Try
    End Sub

    Private Sub routeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComboBox("SELECT first_name,
                middle_name,
                last_name
        FROM tfis_franchisee;")
    End Sub

    Private Sub franchisee_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles franchisee_cb.SelectedIndexChanged
        Dim formattedName As String = franchisee_cb.SelectedItem.ToString().Replace("'", "''")
        Dim sql As String = $"SELECT franchisee_id FROM tfis_franchisee WHERE CONCAT(last_name, ', ', first_name, ', ', middle_name) = '{formattedName}'"

        readQuery(sql)
        If cmdRead.Read() Then
            num = Convert.ToInt32(cmdRead("franchisee_id"))
        End If
        cmdRead.Close()
    End Sub
End Class
