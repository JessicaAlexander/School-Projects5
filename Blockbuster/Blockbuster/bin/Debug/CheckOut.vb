Public Class CheckOut
    Dim rentDate As Date = Form1.startDate
    Dim dueDate As Date = Form1.DueDate
    Dim invNum As Integer
    Dim Title As String
    Dim custID As Integer
    Dim subTotal As Double = Form1.subtotal
    Dim tax As Double = Form1.Tax
    Dim rentalFee As Double = Form1.RentalFee
    Dim myList As List(Of RentedMovies) = Form1.itemsList
    Dim durTime As Integer = Form1.NumOfDays
    Dim MovieID As Integer
    Dim Totalrental As String
    Dim balance As Double = Form1.Total
    Dim payType As String = String.Empty
    Dim movies As Movies
    Private Sub CheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Rentals' table. You can move, or remove it, as needed.
        Me.RentalsTableAdapter.Fill(Me.BlockbustersDataSet.Rentals)
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Movies' table. You can move, or remove it, as needed.
        Me.MoviesTableAdapter.Fill(Me.BlockbustersDataSet.Movies)
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Movie_Inventory' table. You can move, or remove it, as needed.
        Me.Movie_InventoryTableAdapter.Fill(Me.BlockbustersDataSet.Movie_Inventory)
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Memberships' table. You can move, or remove it, as needed.
        Me.MembershipsTableAdapter.Fill(Me.BlockbustersDataSet.Memberships)
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Invoice' table. You can move, or remove it, as needed.
        Me.InvoiceTableAdapter.Fill(Me.BlockbustersDataSet.Invoice)

        Dim description As String

        custID = Form1.selectedCustomerID
        txbMemberID.Text = custID.ToString()

        txbDate.Text = rentDate.ToString()
        Me.MembershipsTableAdapter.FillByID(Me.BlockbustersDataSet.Memberships, custID)

        invNum = CInt(Me.InvoiceTableAdapter.InvoiceCountQuery() + 1)
        txbInvoice.Text = invNum.ToString()


        Dim firstName As String = DirectCast(MembershipsBindingSource.Current, DataRowView).Item("FirstName").ToString
        Dim lastName As String = DirectCast(MembershipsBindingSource.Current, DataRowView).Item("LastName").ToString

        txbName.Text = firstName & " " & lastName
        tbxAddress.Text = DirectCast(MembershipsBindingSource.Current, DataRowView).Item("Address").ToString
        txbCity.Text = DirectCast(MembershipsBindingSource.Current, DataRowView).Item("City").ToString
        txbState.Text = DirectCast(MembershipsBindingSource.Current, DataRowView).Item("State").ToString
        txbZipCode.Text = DirectCast(MembershipsBindingSource.Current, DataRowView).Item("ZipCode").ToString
        txbPhone.Text = DirectCast(MembershipsBindingSource.Current, DataRowView).Item("PhoneNumber").ToString

        lstRentalItems.Items.Clear()
        For Each item As RentedMovies In myList
            description = Me.MoviesTableAdapter.FillByTitleByID(Me.BlockbustersDataSet.Movies, item.MovieID).ToString()
            lstRentalItems.Items.Add(item.MovieID.ToString() & "       " & item.Description & "       " & item.RentalFee.ToString("c2"))
        Next

        txbSubtotal.Text = subTotal.ToString("c2")
        txbTax.Text = tax.ToString("c2")

        txbBalance.Text = balance.ToString("c2")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs)
        Me.InvoiceTableAdapter.InsertQuery(custID, Title, rentDate, dueDate, "CC", Convert.ToDecimal(balance))
        Dim iNum As Integer = CInt(Me.InvoiceTableAdapter.InsertQuery(custID, Title, rentDate, dueDate, "CC", Convert.ToDecimal(rentalFee)))
        myList = Form1.itemsList
        For Each item As RentedMovies In myList
            Me.RentalsTableAdapter.RentedMoviesInsertQuery(iNum, MovieID, durTime, rentalFee)
        Next
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    End Class