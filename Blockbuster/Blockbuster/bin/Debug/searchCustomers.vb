Public Class searchCustomers
    Public custID As Integer = 0
    Private Sub searchCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Invoice' table. You can move, or remove it, as needed.
        Me.InvoiceTableAdapter.Fill(Me.BlockbustersDataSet.Invoice)
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Invoice' table. You can move, or remove it, as needed.
        Me.InvoiceTableAdapter.Fill(Me.BlockbustersDataSet.Invoice)
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Memberships' table. You can move, or remove it, as needed.
        Me.MembershipsTableAdapter.Fill(Me.BlockbustersDataSet.Memberships)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If radMembershipID.Checked = True Then
            Try
                Me.MembershipsTableAdapter.FillByID(Me.BlockbustersDataSet.Memberships, CType(txtSearch.Text, Integer))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf radLastName.Checked = True Then
            Try
                Me.MembershipsTableAdapter.FillByName(Me.BlockbustersDataSet.Memberships, CType(txtSearch.Text, String))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("Please Select a Search Criteria")
        End If
    End Sub

    Private Sub btnSelectCustomer_Click(sender As Object, e As EventArgs) Handles btnSelectCustomer.Click
        Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
        Form1.selectedCustomerID = Convert.ToInt32(row.Cells(0).Value.ToString)
        MsgBox(Form1.selectedCustomerID)
        Form1.selectedCustomerLastName = row.Cells(2).Value.ToString
        CheckOut.Show()
    End Sub
End Class