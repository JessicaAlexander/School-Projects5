<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Movie_TypeLabel As System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.CBDuration = New System.Windows.Forms.ComboBox()
        Me.dtpCalender = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalDue1 = New System.Windows.Forms.Label()
        Me.lblTax1 = New System.Windows.Forms.Label()
        Me.lblTotalRentalFee1 = New System.Windows.Forms.Label()
        Me.lblSubTotalDue = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotalRentalFee = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.btnCompleteRental = New System.Windows.Forms.Button()
        Me.BtnNewCust = New System.Windows.Forms.Button()
        Me.AddRemove = New System.Windows.Forms.Button()
        Me.Movie_IDTextBox = New System.Windows.Forms.TextBox()
        Me.MoviesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlockbustersDataSet = New Blockbuster.BlockbustersDataSet()
        Me.Movie_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.lblDueDate1 = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.InvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceTableAdapter = New Blockbuster.BlockbustersDataSetTableAdapters.InvoiceTableAdapter()
        Me.TableAdapterManager = New Blockbuster.BlockbustersDataSetTableAdapters.TableAdapterManager()
        Me.MembershipsTableAdapter = New Blockbuster.BlockbustersDataSetTableAdapters.MembershipsTableAdapter()
        Me.Movie_InventoryTableAdapter = New Blockbuster.BlockbustersDataSetTableAdapters.Movie_InventoryTableAdapter()
        Me.MoviesTableAdapter = New Blockbuster.BlockbustersDataSetTableAdapters.MoviesTableAdapter()
        Me.MembershipsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Movie_InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChkList_Movies = New System.Windows.Forms.ListBox()
        Movie_TypeLabel = New System.Windows.Forms.Label()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlockbustersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembershipsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movie_InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Movie_TypeLabel
        '
        Movie_TypeLabel.AutoSize = True
        Movie_TypeLabel.Location = New System.Drawing.Point(858, 202)
        Movie_TypeLabel.Name = "Movie_TypeLabel"
        Movie_TypeLabel.Size = New System.Drawing.Size(85, 17)
        Movie_TypeLabel.TabIndex = 105
        Movie_TypeLabel.Text = "Movie Type:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(497, 86)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(42, 17)
        Me.lblDate.TabIndex = 69
        Me.lblDate.Text = "Date:"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(289, 86)
        Me.lblDuration.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(66, 17)
        Me.lblDuration.TabIndex = 68
        Me.lblDuration.Text = "Duration:"
        '
        'CBDuration
        '
        Me.CBDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBDuration.FormattingEnabled = True
        Me.CBDuration.Location = New System.Drawing.Point(289, 108)
        Me.CBDuration.Margin = New System.Windows.Forms.Padding(4)
        Me.CBDuration.Name = "CBDuration"
        Me.CBDuration.Size = New System.Drawing.Size(140, 24)
        Me.CBDuration.TabIndex = 67
        '
        'dtpCalender
        '
        Me.dtpCalender.Location = New System.Drawing.Point(500, 109)
        Me.dtpCalender.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpCalender.Name = "dtpCalender"
        Me.dtpCalender.Size = New System.Drawing.Size(259, 22)
        Me.dtpCalender.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Movies:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Handwriting", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(211, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(382, 43)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Blockbuster Movies"
        '
        'lblTotalDue1
        '
        Me.lblTotalDue1.Location = New System.Drawing.Point(622, 261)
        Me.lblTotalDue1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalDue1.Name = "lblTotalDue1"
        Me.lblTotalDue1.Size = New System.Drawing.Size(88, 15)
        Me.lblTotalDue1.TabIndex = 95
        '
        'lblTax1
        '
        Me.lblTax1.Location = New System.Drawing.Point(622, 221)
        Me.lblTax1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTax1.Name = "lblTax1"
        Me.lblTax1.Size = New System.Drawing.Size(88, 15)
        Me.lblTax1.TabIndex = 94
        '
        'lblTotalRentalFee1
        '
        Me.lblTotalRentalFee1.Location = New System.Drawing.Point(622, 176)
        Me.lblTotalRentalFee1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalRentalFee1.Name = "lblTotalRentalFee1"
        Me.lblTotalRentalFee1.Size = New System.Drawing.Size(88, 15)
        Me.lblTotalRentalFee1.TabIndex = 92
        '
        'lblSubTotalDue
        '
        Me.lblSubTotalDue.AutoSize = True
        Me.lblSubTotalDue.Location = New System.Drawing.Point(510, 259)
        Me.lblSubTotalDue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubTotalDue.Name = "lblSubTotalDue"
        Me.lblSubTotalDue.Size = New System.Drawing.Size(74, 17)
        Me.lblSubTotalDue.TabIndex = 91
        Me.lblSubTotalDue.Text = "Total Due:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(510, 222)
        Me.lblTax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(35, 17)
        Me.lblTax.TabIndex = 90
        Me.lblTax.Text = "Tax:"
        '
        'lblTotalRentalFee
        '
        Me.lblTotalRentalFee.AutoSize = True
        Me.lblTotalRentalFee.Location = New System.Drawing.Point(510, 176)
        Me.lblTotalRentalFee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalRentalFee.Name = "lblTotalRentalFee"
        Me.lblTotalRentalFee.Size = New System.Drawing.Size(117, 17)
        Me.lblTotalRentalFee.TabIndex = 88
        Me.lblTotalRentalFee.Text = "Total Rental Fee:"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(409, 387)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(88, 26)
        Me.BtnExit.TabIndex = 99
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(292, 387)
        Me.BtnCalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(88, 26)
        Me.BtnCalculate.TabIndex = 98
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Location = New System.Drawing.Point(530, 387)
        Me.btnSearchCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(105, 26)
        Me.btnSearchCustomer.TabIndex = 103
        Me.btnSearchCustomer.Text = "Search Customer"
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'btnCompleteRental
        '
        Me.btnCompleteRental.Location = New System.Drawing.Point(625, 336)
        Me.btnCompleteRental.Name = "btnCompleteRental"
        Me.btnCompleteRental.Size = New System.Drawing.Size(111, 37)
        Me.btnCompleteRental.TabIndex = 102
        Me.btnCompleteRental.Text = "Complete Rental"
        Me.btnCompleteRental.UseVisualStyleBackColor = True
        '
        'BtnNewCust
        '
        Me.BtnNewCust.Location = New System.Drawing.Point(644, 387)
        Me.BtnNewCust.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNewCust.Name = "BtnNewCust"
        Me.BtnNewCust.Size = New System.Drawing.Size(105, 26)
        Me.BtnNewCust.TabIndex = 101
        Me.BtnNewCust.Text = "New Customer"
        Me.BtnNewCust.UseVisualStyleBackColor = True
        '
        'AddRemove
        '
        Me.AddRemove.Location = New System.Drawing.Point(27, 387)
        Me.AddRemove.Name = "AddRemove"
        Me.AddRemove.Size = New System.Drawing.Size(107, 26)
        Me.AddRemove.TabIndex = 104
        Me.AddRemove.Text = "Add/Remove"
        Me.AddRemove.UseVisualStyleBackColor = True
        '
        'Movie_IDTextBox
        '
        Me.Movie_IDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.Movie_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Movie_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Movie ID", True))
        Me.Movie_IDTextBox.Location = New System.Drawing.Point(835, 138)
        Me.Movie_IDTextBox.Name = "Movie_IDTextBox"
        Me.Movie_IDTextBox.Size = New System.Drawing.Size(100, 15)
        Me.Movie_IDTextBox.TabIndex = 105
        '
        'MoviesBindingSource
        '
        Me.MoviesBindingSource.DataMember = "Movies"
        Me.MoviesBindingSource.DataSource = Me.BlockbustersDataSet
        '
        'BlockbustersDataSet
        '
        Me.BlockbustersDataSet.DataSetName = "BlockbustersDataSet"
        Me.BlockbustersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Movie_TypeTextBox
        '
        Me.Movie_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Movie Type", True))
        Me.Movie_TypeTextBox.Location = New System.Drawing.Point(949, 199)
        Me.Movie_TypeTextBox.Name = "Movie_TypeTextBox"
        Me.Movie_TypeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Movie_TypeTextBox.TabIndex = 106
        '
        'lblDueDate1
        '
        Me.lblDueDate1.Location = New System.Drawing.Point(622, 295)
        Me.lblDueDate1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDueDate1.Name = "lblDueDate1"
        Me.lblDueDate1.Size = New System.Drawing.Size(88, 15)
        Me.lblDueDate1.TabIndex = 108
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Location = New System.Drawing.Point(510, 295)
        Me.lblDueDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(72, 17)
        Me.lblDueDate.TabIndex = 107
        Me.lblDueDate.Text = "Due Date:"
        '
        'InvoiceBindingSource
        '
        Me.InvoiceBindingSource.DataMember = "Invoice"
        Me.InvoiceBindingSource.DataSource = Me.BlockbustersDataSet
        '
        'InvoiceTableAdapter
        '
        Me.InvoiceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.InvoiceTableAdapter = Me.InvoiceTableAdapter
        Me.TableAdapterManager.MembershipsTableAdapter = Me.MembershipsTableAdapter
        Me.TableAdapterManager.Movie_InventoryTableAdapter = Me.Movie_InventoryTableAdapter
        Me.TableAdapterManager.Movies1TableAdapter = Nothing
        Me.TableAdapterManager.MoviesTableAdapter = Me.MoviesTableAdapter
        Me.TableAdapterManager.OverDue_MembersTableAdapter = Nothing
        Me.TableAdapterManager.RentalsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Blockbuster.BlockbustersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MembershipsTableAdapter
        '
        Me.MembershipsTableAdapter.ClearBeforeFill = True
        '
        'Movie_InventoryTableAdapter
        '
        Me.Movie_InventoryTableAdapter.ClearBeforeFill = True
        '
        'MoviesTableAdapter
        '
        Me.MoviesTableAdapter.ClearBeforeFill = True
        '
        'MembershipsBindingSource
        '
        Me.MembershipsBindingSource.DataMember = "Memberships"
        Me.MembershipsBindingSource.DataSource = Me.BlockbustersDataSet
        '
        'Movie_InventoryBindingSource
        '
        Me.Movie_InventoryBindingSource.DataMember = "Movie Inventory"
        Me.Movie_InventoryBindingSource.DataSource = Me.BlockbustersDataSet
        '
        'RentalsBindingSource
        '
        Me.RentalsBindingSource.DataMember = "Rentals"
        Me.RentalsBindingSource.DataSource = Me.BlockbustersDataSet
        '
        'ChkList_Movies
        '
        Me.ChkList_Movies.DataSource = Me.MoviesBindingSource
        Me.ChkList_Movies.DisplayMember = "Title"
        Me.ChkList_Movies.FormattingEnabled = True
        Me.ChkList_Movies.ItemHeight = 16
        Me.ChkList_Movies.Location = New System.Drawing.Point(27, 106)
        Me.ChkList_Movies.Name = "ChkList_Movies"
        Me.ChkList_Movies.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ChkList_Movies.Size = New System.Drawing.Size(255, 212)
        Me.ChkList_Movies.Sorted = True
        Me.ChkList_Movies.TabIndex = 109
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 438)
        Me.Controls.Add(Me.ChkList_Movies)
        Me.Controls.Add(Me.lblDueDate1)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Movie_TypeLabel)
        Me.Controls.Add(Me.Movie_TypeTextBox)
        Me.Controls.Add(Me.Movie_IDTextBox)
        Me.Controls.Add(Me.AddRemove)
        Me.Controls.Add(Me.btnSearchCustomer)
        Me.Controls.Add(Me.btnCompleteRental)
        Me.Controls.Add(Me.BtnNewCust)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.lblTotalDue1)
        Me.Controls.Add(Me.lblTax1)
        Me.Controls.Add(Me.lblTotalRentalFee1)
        Me.Controls.Add(Me.lblSubTotalDue)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblTotalRentalFee)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.CBDuration)
        Me.Controls.Add(Me.dtpCalender)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlockbustersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembershipsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movie_InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDate As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents CBDuration As ComboBox
    Friend WithEvents dtpCalender As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BlockbustersDataSet As BlockbustersDataSet
    Friend WithEvents InvoiceBindingSource As BindingSource
    Friend WithEvents InvoiceTableAdapter As BlockbustersDataSetTableAdapters.InvoiceTableAdapter
    Friend WithEvents TableAdapterManager As BlockbustersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MembershipsTableAdapter As BlockbustersDataSetTableAdapters.MembershipsTableAdapter
    Friend WithEvents MembershipsBindingSource As BindingSource
    Friend WithEvents Movie_InventoryTableAdapter As BlockbustersDataSetTableAdapters.Movie_InventoryTableAdapter
    Friend WithEvents Movie_InventoryBindingSource As BindingSource
    Friend WithEvents MoviesTableAdapter As BlockbustersDataSetTableAdapters.MoviesTableAdapter
    Friend WithEvents MoviesBindingSource As BindingSource
    Friend WithEvents RentalsBindingSource As BindingSource
    Friend WithEvents lblTotalDue1 As Label
    Friend WithEvents lblTax1 As Label
    Friend WithEvents lblTotalRentalFee1 As Label
    Friend WithEvents lblSubTotalDue As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotalRentalFee As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents btnSearchCustomer As Button
    Friend WithEvents btnCompleteRental As Button
    Friend WithEvents BtnNewCust As Button
    Friend WithEvents AddRemove As Button
    Friend WithEvents Movie_IDTextBox As TextBox
    Friend WithEvents Movie_TypeTextBox As TextBox
    Friend WithEvents lblDueDate1 As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents ChkList_Movies As ListBox
End Class
