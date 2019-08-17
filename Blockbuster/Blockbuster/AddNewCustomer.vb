Public Class AddNewCustomer
    Private Sub btnSelectAndAdd_Click(sender As Object, e As EventArgs) Handles btnSelectAndAdd.Click
        Form1.MembershipsTableAdapter.InsertQuery(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtZipCode.Text, txtPhoneNumber.Text, txtActivationDate.Text, txtDateOfBirth.Text, txtAge.Text)
        Form1.MembershipsTableAdapter.Update(Form1.BlockbustersDataSet.Memberships)
        Form1.selectedCustomerID = Convert.ToInt32(txtMembershipID.Text)
        Form1.selectedCustomerLastName = (txtLastName.Text)
    End Sub
End Class