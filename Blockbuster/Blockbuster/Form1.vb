Public Class Form1
    Public mov
    Public itemsList As New List(Of RentedMovies)
    Public Total As Double
    Public Tax As Double
    Public RentalFee As Double
    Public NumOfDays As Integer
    Public startDate As Date
    Public DueDate As Date
    Public subtotal As Double = 0
    Public movieID As Integer
    Public rentalPrices As New Movies
    Public desc As String
    Public selectedCustomerID As Integer
    Public selectedCustomerLastName As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Movies' table. You can move, or remove it, as needed.
        Me.MoviesTableAdapter.Fill(Me.BlockbustersDataSet.Movies)
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Movie_Inventory' table. You can move, or remove it, as needed.
        Me.Movie_InventoryTableAdapter.Fill(Me.BlockbustersDataSet.Movie_Inventory)
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Memberships' table. You can move, or remove it, as needed.
        Me.MembershipsTableAdapter.Fill(Me.BlockbustersDataSet.Memberships)
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Invoice' table. You can move, or remove it, as needed.
        Me.InvoiceTableAdapter.Fill(Me.BlockbustersDataSet.Invoice)


        CBDuration.Items.Add("TwoDays")
        CBDuration.Items.Add("OneWeek")
        CBDuration.Items.Add("TwoWeeks")
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        If Not CBDuration.Text.Equals(String.Empty) Then

            If ChkList_Movies.SelectedIndices.Count > 0 Then

                Dim duration As Movies.MovieType = CType(CBDuration.SelectedIndex, Movies.MovieType)
                Dim mov As Movies.MovieType

                For Each Index As Integer In ChkList_Movies.SelectedIndices
                    If Index >= 0 And Index <= 4 Then
                        mov = CType(Movies.MovieType.Attack_of_the_Killer_Tomatoes, Movies.MovieType)
                    ElseIf Index >= 5 And Index <= 9 Then
                        mov = CType(Movies.MovieType.Elvira_Mistress_of_the_Dark, Movies.MovieType)
                    ElseIf Index >= 10 And Index <= 14 Then
                        mov = CType(Movies.MovieType.Hunger_Games, Movies.MovieType)
                    ElseIf Index >= 15 And Index <= 19 Then
                        mov = CType(Movies.MovieType.Pulp_Fiction, Movies.MovieType)
                    ElseIf Index >= 20 And Index <= 24 Then
                        mov = CType(Movies.MovieType.Iron_Giant, Movies.MovieType)
                    ElseIf Index >= 25 And Index <= 29 Then
                        mov = CType(Movies.MovieType.Reservoir_Dogs, Movies.MovieType)
                    ElseIf Index >= 30 And Index <= 34 Then
                        mov = CType(Movies.MovieType.Resident_Evil, Movies.MovieType)
                    ElseIf Index >= 35 And Index <= 39 Then
                        mov = CType(Movies.MovieType.Revenge_Of_the_Nerds, Movies.MovieType)
                    ElseIf Index >= 40 And Index <= 44 Then
                        mov = CType(Movies.MovieType.Titan_A_E, Movies.MovieType)
                    ElseIf Index >= 45 And Index <= 50 Then
                        mov = CType(Movies.MovieType.Star_Wars_A_New_Hope, Movies.MovieType)
                    Else
                    End If

                    Me.MoviesTableAdapter.FillByTitleByID(Me.BlockbustersDataSet.Movies, Index + 1)
                    If Not String.IsNullOrEmpty(Movie_IDTextBox.Text) Then
                        movieID = Convert.ToInt32(Movie_IDTextBox.Text)
                        Me.MoviesTableAdapter.UpdateRentalStatus(movieID)
                        RentalFee = rentalPrices.GetRentalPrices(mov, duration)
                        subtotal += rentalPrices.GetRentalPrices(mov, duration)
                        desc = Movie_TypeTextBox.Text
                        Dim anItem As New RentedMovies(Index + 1, desc, RentalFee)
                        itemsList.Add(anItem)
                    Else
                        MessageBox.Show("No " & Index + 1 & " are available at this time.", "Unavialable for Rent")
                    End If
                Next Index
                lblTotalRentalFee1.Text = subtotal.ToString("C2")

                Tax = subtotal * 0.0825
                lblTax1.Text = Tax.ToString("C2")

                Total = subtotal + Tax
                lblTotalDue1.Text = Total.ToString("C2")

                RentalFee = (subtotal + Tax)

                startDate = dtpCalender.Value
                Select Case (CBDuration.SelectedIndex)
                    Case 0
                        DueDate = startDate.AddDays(2)
                        NumOfDays = 2
                    Case 1
                        DueDate = startDate.AddDays(7)
                        NumOfDays = 7
                    Case 2
                        DueDate = startDate.AddDays(14)
                        NumOfDays = 14
                End Select
                lblDueDate1.Text = DueDate

            Else
                MessageBox.Show("Please Select A Movie!")
            End If
        Else
            MessageBox.Show("Please select a duration!")
        End If
    End Sub

    Private Sub BtnNewCust_Click(sender As Object, e As EventArgs) Handles BtnNewCust.Click
        AddNewCustomer.Show()
    End Sub

    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        searchCustomers.Show()
    End Sub

    Private Sub btnCompleteRental_Click(sender As Object, e As EventArgs) Handles btnCompleteRental.Click
        CheckOut.Show()
    End Sub

    Private Sub AddRemove_Click(sender As Object, e As EventArgs) Handles AddRemove.Click
        AddRemoveInventory.Show()
    End Sub
End Class
