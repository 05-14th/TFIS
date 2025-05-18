Public Class renewalForm
    Dim num As Integer
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

    Private Sub ForeverButton1_Click(sender As Object, e As EventArgs) Handles ForeverButton1.Click
        Try
            openConn("tfis_db")

            Dim query As String = String.Format("
                INSERT INTO tfis_renewal (
                    franchise_id,
                    submission_date,
                    renewal_status,
                    processing_date,
                    approval_date,
                    franchisee_id,
                    total_fee,
                    expiration_date,
                    renewal_type,
                    compliance_status,
                    renewal_fee,
                    penalty_fee,
                    renewal_number,
                    renewal_remarks
                ) VALUES (
                    '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7}, '{8}', '{9}', '{10}', {11}, {12}, {13}
                );", fi_txtbox.Text.Replace("'", "''"),
                     sd_dt.Value.ToString("yyyy-MM-dd"),
                     status_cb.SelectedItem.ToString().Replace("'", "''"),
                     pd_dt.Value.ToString("yyyy-MM-dd"),
                     ap_dt.Value.ToString("yyyy-MM-dd"),
                     num,
                     ap_txtbox.Text.Replace("'", "''"),
                     ed_dt.Value.ToString("yyyy-MM-dd"),
                     rt_cb.SelectedItem.ToString().Replace("'", "''"),
                     cs_txtbox.Text.Replace("'", "''"),
                     rf_txtbox.Text.Replace("'", "''"),
                     pf_txtbox.Text.Replace("'", "''"),
                     renewal_txtbox.Text.Replace("'", "''"),
                     rr_txtbox.Text.Replace("'", "''"))


            executeQuery(query)

            MessageBox.Show("Vehicle successfully inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ClearFormControls(Me)
            conn.Close()
        End Try
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

    Private Sub renewalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
