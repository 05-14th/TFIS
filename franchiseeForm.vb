Imports MySql.Data.MySqlClient

Public Class franchiseeForm
    Private Sub ForeverButton3_Click(sender As Object, e As EventArgs) Handles ForeverButton3.Click
        Try
            openConn("tfis_db")

            ' 1. Get address info from form controls
            Dim barangay As String = brgy_txtbox.Text.Trim()
            Dim municipality As String = muni_txtbox.Text.Trim()
            Dim cityProvince As String = prov_txtbox.Text.Trim()
            Dim zipCode As String = zip_txtbox.Text.Trim()

            ' 2. Check if address exists
            Dim checkAddressSql As String = String.Format("
                SELECT address_id FROM tfis_address 
                WHERE barangay = '{0}' AND municipality = '{1}' AND city_province = '{2}' AND zip_code = '{3}';",
                barangay.Replace("'", "''"),
                municipality.Replace("'", "''"),
                cityProvince.Replace("'", "''"),
                zipCode.Replace("'", "''"))

            Dim addressId As String = ""

            readQuery(checkAddressSql)

            If cmdRead.Read() Then
                ' Address exists, use its ID
                addressId = cmdRead("address_id").ToString()
                cmdRead.Close()
            Else
                cmdRead.Close()
                ' Generate new address_id (GUID or auto-increment)
                Dim newAddressId As String = Guid.NewGuid().ToString("N")

                Dim insertAddressSql As String = String.Format("
                    INSERT INTO tfis_address (address_id, barangay, municipality, city_province, zip_code)
                    VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');",
                    newAddressId,
                    barangay.Replace("'", "''"),
                    municipality.Replace("'", "''"),
                    cityProvince.Replace("'", "''"),
                    zipCode.Replace("'", "''"))

                executeQuery(insertAddressSql)
                addressId = newAddressId ' Use the newly generated GUID
            End If

            ' 3. Insert franchisee with the correct address_id
            Dim franchiseeSql As String = String.Format("
                INSERT INTO tfis_franchisee (
                    franchisee_id,
                    first_name,
                    middle_name,
                    last_name,
                    phone_number,
                    gender,
                    date_of_birth,
                    valid_id,
                    model_year,
                    application_date,
                    franchisee_status,
                    franchisee_address,  
                    email,
                    age,
                    occupation
                ) VALUES (
                    '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', {13}, '{14}'
                );",
                fi_txtbox.Text.Replace("'", "''"),
                fn_txtbox.Text.Replace("'", "''"),
                mn_txtbox.Text.Replace("'", "''"),
                ln_txtbox.Text.Replace("'", "''"),
                pn_txtbox.Text.Replace("'", "''"),
                gender_txtbox.Text.Replace("'", "''"),
                birthdate_dt.Value.ToString("yyyy-MM-dd"),
                vi_txtbox.Text.Replace("'", "''"),
                model_txtbox.Text.Replace("'", "''") & " " & year_txtbox.Text.Replace("'", "''"),
                ad_dt.Value.ToString("yyyy-MM-dd"),
                status_cb.SelectedItem.ToString().Replace("'", "''"),
                addressId,
                email_txtbox.Text.Replace("'", "''"),
                Convert.ToInt32(age_txtbox.Text),
                occupation_txtbox.Text.Replace("'", "''"))

            executeQuery(franchiseeSql)

            MessageBox.Show("Franchisee successfully inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
End Class