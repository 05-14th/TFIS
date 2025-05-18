Public Class franchiseForm
    Dim franchisee_num As Integer
    Dim vehicle_num As Integer
    Dim route_num As Integer
    Private Sub PopulateFranchiseeCB(query As String)
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

    Private Sub PopulateOtherCB(query As String, cb As ComboBox, identifier As String)
        Try
            readQuery(query)
            cb.Items.Clear()
            While cmdRead.Read()
                cb.Items.Add($"{cmdRead.GetString(identifier)}")
            End While
            cmdRead.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub franchisee_save_Click(sender As Object, e As EventArgs) Handles franchisee_save.Click
        Try
            openConn("tfis_db")

            Dim query As String = String.Format("
                INSERT INTO tfis_franchise (
                    franchisee_id
                    vehicle_id,
                    route_id,
                    franchise_type,
                    franchise_status,
                    issue_date,
                    expiration_date,
                    total_violations,
                    last_renewal_date,
                    fee_paid,
                    area,
                    association,
                    license_number,
                    franchise_duration
                ) VALUES (
                    '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', {8}, '{9}', '{10}', '{11}', '{12}', '{13}'
                );", franchisee_num, 
                     vehicle_num, 
                     route_num, 
                     ft_cb.SelectedItem.ToString().Replace("'", "''"), 
                     status_cb.SelectedItem.ToString().Replace("'", "''"),
                     di_dt.Value.ToString("yyyy-MM-dd"), 
                     ed_dt.Value.ToString("yyyy-MM-dd"), 
                     tv_txtbox.Text, lrd_dt.Value.ToString("yyyy-MM-dd"),
                     ap_txtbox.Text.Replace("'", "''"), 
                     area_cb.SelectedItem.ToString().Replace("'", "''"), 
                     assoc_txtbox.Text.Replace("'", "''"), 
                     ln_txtbox.Text.Replace("'", "''"), 
                     fd_txtbox.Text.Replace("'", "''"))


            executeQuery(query)

            MessageBox.Show("Vehicle successfully inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ClearFormControls(Me)
            conn.Close()
        End Try
    End Sub

    Private Sub vehicleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateFranchiseeCB("SELECT first_name, middle_name, last_name FROM tfis_franchisee;")
        PopulateOtherCB("SELECT plate_number FROM tfis_vehicle", vehicle_cb, "plate_number")
        PopulateOtherCB("SELECT route_name FROM tfis_route", route_cb, "route_name")
    End Sub

    Private Sub franchisee_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles franchisee_cb.SelectedIndexChanged
        Dim formattedName As String = franchisee_cb.SelectedItem.ToString().Replace("'", "''")
        Dim sql As String = $"SELECT franchisee_id FROM tfis_franchisee WHERE CONCAT(last_name, ', ', first_name, ', ', middle_name) = '{formattedName}'"

        readQuery(sql)
        If cmdRead.Read() Then
            franchisee_num = Convert.ToInt32(cmdRead("franchisee_id"))
        End If
        cmdRead.Close()
    End Sub

    Private Sub route_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles route_cb.SelectedIndexChanged
        Dim route As String = route_cb.SelectedItem.ToString().Replace("'", "''")
        Dim routeSql As String = $"SELECT route_id FROM tfis_route WHERE route_name = '{route}'"

        readQuery(routeSql)
        If cmdRead.Read() Then
            route_num = Convert.ToInt32(cmdRead("route_id"))
        End If
        cmdRead.Close()
    End Sub

    Private Sub vehicle_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vehicle_cb.SelectedIndexChanged
        Dim vehicle As String = vehicle_cb.SelectedItem.ToString().Replace("'", "''")
        Dim vechicleSql As String = $"SELECT vehicle_id FROM tfis_vehicle WHERE plate_number = '{vehicle}'"

        readQuery(vechicleSql)
        If cmdRead.Read() Then
            vehicle_num = Convert.ToInt32(cmdRead("vehicle_id"))
        End If
        cmdRead.Close()
    End Sub
End Class
