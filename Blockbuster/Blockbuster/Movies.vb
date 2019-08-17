Public Class Movies
    Public Property Title As String
    Public Property ReleaseDate As String
    Public Property QtyTotal As Integer
    Public Property QtyOnHand As Integer
    Public Property Rating As String
    Public Property Rented As String

    Sub New()
        Me.Title = "-1"
        Me.ReleaseDate = "-1"
        Me.QtyTotal = -1
        Me.QtyOnHand = -1
        Me.Rating = -1
        Me.Rented = "-1"
    End Sub

    Enum DurationType
        TwoDays
        OneWeek
        TwoWeeks
    End Enum

    Enum MovieType
        Attack_of_the_Killer_Tomatoes
        Elvira_Mistress_of_the_Dark
        Hunger_Games
        Pulp_Fiction
        Iron_Giant
        Reservoir_Dogs
        Resident_Evil
        Revenge_Of_the_Nerds
        Titan_A_E
        Star_Wars_A_New_Hope
    End Enum

    Public Sub New(args() As String)
        Me.Title = args(1)
        Me.ReleaseDate = args(2)
        Me.QtyTotal = Convert.ToInt32(args(3))
        Me.QtyOnHand = Convert.ToInt32(args(4))
        Me.Rating = args(5)
    End Sub

    Private ReadOnly myPrices(,) As Double = {{"3", "$6", "$9"},
                                 {"3", "$6", "$9"},
                                 {"3", "$6", "$9"},
                                 {"3", "$6", "$9"},
                                 {"3", "$6", "$9"},
                                 {"3", "$6", "$9"},
                                 {"3", "$6", "$9"},
                                 {"3", "$6", "$9"},
                                 {"3", "$6", "$9"},
                                 {"3", "$6", "$9"}}

    Public Function GetRentalPrices(ByVal Movie As MovieType, ByVal duration As DurationType) As Double
        Return myPrices(Movie, duration)
    End Function
End Class

