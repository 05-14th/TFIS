Imports MySql.Data.MySqlClient

Public Class vehicleForm
    Dim num As Integer

    Private Sub PopulateComboBox(query As String)
        Try
            readQuery(query)
            cb_owner.Items.Clear()
            While cmdRead.Read()
                If cmdRead.GetString("middle_name") = Nothing Then
                    cb_owner.Items.Add($"{cmdRead.GetString("last_name")}, {cmdRead.GetString("first_name")}")
                Else
                    cb_owner.Items.Add($"{cmdRead.GetString("last_name")}, {cmdRead.GetString("first_name")}, {cmdRead.GetString("middle_name")}")
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
            Dim vehicleSql As String = String.Format("
                INSERT INTO tfis_vehicle (
                    franchisee_id,
                    plate_number,
                    model,
                    color,
                    year_of_manufacture,
                    fuel_type,
                    transmission_type,
                    chassis_number,
                    engine_number,
                    official_receipt,
                    purchase_date,
                    mileage,
                    net_weight,
                    registration_expiry_date
                ) VALUES (
                    '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', {13}
                );",
                Convert.ToString(num),
                pn_txtbox.Text.Replace("'", "''"),
                model_txtbox.Text.Replace("'", "''"),
                color_txtbox.Text.Replace("'", "''"),
                ym_txtbox.Text.Replace("'", "''"),
                ft_type.SelectedItem.ToString().Replace("'", "''"),
                tt_cb.SelectedItem.ToString().Replace("'", "''"),
                cn_txtbox.Text.Replace("'", "''"),
                or_txtbox.Text.Replace("'", "''"),
                en_txtbox.Text.Replace("'", "''"),
                pd_dt.Value.ToString("yyyy-MM-dd"),
                mileage_txtbox.Text,
                nw_txtbox.Text,
                red_dt.Value.ToString("yyyy-MM-dd")
)

            executeQuery(vehicleSql)

            MessageBox.Show("Vehicle successfully inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ClearFormControls(Me)
            conn.Close()
        End Try
    End Sub

    Private Sub vehicleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComboBox("SELECT first_name,
                middle_name,
                last_name
        FROM tfis_franchisee;")
    End Sub

    Private Sub cb_owner_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_owner.SelectedIndexChanged
        Dim formattedName As String = cb_owner.SelectedItem.ToString().Replace("'", "''")
        Dim sql As String = $"SELECT franchisee_id FROM tfis_franchisee WHERE CONCAT(last_name, ', ', first_name, ', ', middle_name) = '{formattedName}'"

        readQuery(sql)
        If cmdRead.Read() Then
            num = Convert.ToInt32(cmdRead("franchisee_id"))
        End If
        cmdRead.Close()
    End Sub
End Class
