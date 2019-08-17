Public Class Customer

    Public CustID As Integer
    Public FirstName As String
    Public LastName As String
    Public Phone As String
    Public Address As String
    Public City As String
    Public State As String
    Public Zip As String

    Sub New()
        'CustomerID = adapter.GetData.Count + 1
        CustID = 0
        FirstName = String.Empty
        LastName = String.Empty
        Phone = String.Empty
        Address = String.Empty
        City = String.Empty
        State = String.Empty
        Zip = String.Empty
    End Sub

    Sub New(CustIDNew As Integer,
            FirstNameNew As String, LastNameNew As String,
            PhoneNew As String,
            AddressNew As String, CityNew As String, StateNew As String, ZipNew As String)
        'CustomerID = adapter.GetData.Count + 1
        CustID = CustIDNew
        FirstName = FirstNameNew
        LastName = LastNameNew
        Phone = PhoneNew
        Address = AddressNew
        City = CityNew
        State = StateNew
        Zip = ZipNew
    End Sub

End Class
