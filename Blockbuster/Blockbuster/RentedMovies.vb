Public Class RentedMovies
    Public Property MovieID As Int64
    Public Property RentalFee As Double
    Public Property Description As String

    Sub New(movieID As Int64, desc As String, fee As Double)
        MovieID = movieID
        RentalFee = fee
        Description = desc
    End Sub

    Sub New()
        MovieID = 0
        RentalFee = 0.0
    End Sub
End Class