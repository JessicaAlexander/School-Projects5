Public Class AddRemoveInventory
    Private Sub AddRemoveInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Movie_Inventory' table. You can move, or remove it, as needed.
        Me.Movie_InventoryTableAdapter.Fill(Me.BlockbustersDataSet.Movie_Inventory)
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Movies' table. You can move, or remove it, as needed.
        Me.MoviesTableAdapter.Fill(Me.BlockbustersDataSet.Movies)
        'Me.MovieRentalTableAdapter.Fill(Me.MovieRentalDataSet.Movie)
        Me.MoviesTableAdapter.Fill(Me.BlockbustersDataSet.Movies)
    End Sub

    Private Sub MoviesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MoviesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BlockbustersDataSet)
    End Sub

    Private Sub AddRemoveInventoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.MoviesBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.MovieRentalDataSet)
        Me.TableAdapterManager.UpdateAll(Me.BlockbustersDataSet)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class