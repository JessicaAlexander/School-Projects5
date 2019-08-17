<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CheckOut
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
        Me.txbBalance = New System.Windows.Forms.TextBox()
        Me.txbTax = New System.Windows.Forms.TextBox()
        Me.txbSubtotal = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblBalanceDue = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.txbExpMonth = New System.Windows.Forms.TextBox()
        Me.txbCreditCardNumber = New System.Windows.Forms.TextBox()
        Me.tbxCRVCode = New System.Windows.Forms.TextBox()
        Me.txbExpYear = New System.Windows.Forms.TextBox()
        Me.txbNameOnCard = New System.Windows.Forms.TextBox()
        Me.lblCRVCode = New System.Windows.Forms.Label()
        Me.lblExpYear = New System.Windows.Forms.Label()
        Me.lblExpMonth = New System.Windows.Forms.Label()
        Me.lblCreditCardNumber = New System.Windows.Forms.Label()
        Me.lblNameOnCard = New System.Windows.Forms.Label()
        Me.rbPayPal = New System.Windows.Forms.RadioButton()
        Me.rbCheck = New System.Windows.Forms.RadioButton()
        Me.rbCredit = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstRentalItems = New System.Windows.Forms.ListBox()
        Me.lblCustomerInformation = New System.Windows.Forms.Label()
        Me.lblRentalItems = New System.Windows.Forms.Label()
        Me.txbName = New System.Windows.Forms.TextBox()
        Me.txbDate = New System.Windows.Forms.TextBox()
        Me.txbMemberID = New System.Windows.Forms.TextBox()
        Me.tbxAddress = New System.Windows.Forms.TextBox()
        Me.txbCity = New System.Windows.Forms.TextBox()
        Me.txbState = New System.Windows.Forms.TextBox()
        Me.txbZipCode = New System.Windows.Forms.TextBox()
        Me.txbPhone = New System.Windows.Forms.TextBox()
        Me.txbInvoice = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lblInvoice = New System.Windows.Forms.Label()
        Me.BlockbustersDataSet = New Blockbuster.BlockbustersDataSet()
        Me.InvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceTableAdapter = New Blockbuster.BlockbustersDataSetTableAdapters.InvoiceTableAdapter()
        Me.TableAdapterManager = New Blockbuster.BlockbustersDataSetTableAdapters.TableAdapterManager()
        Me.MembershipsTableAdapter = New Blockbuster.BlockbustersDataSetTableAdapters.MembershipsTableAdapter()
        Me.Movie_InventoryTableAdapter = New Blockbuster.BlockbustersDataSetTableAdapters.Movie_InventoryTableAdapter()
        Me.MoviesTableAdapter = New Blockbuster.BlockbustersDataSetTableAdapters.MoviesTableAdapter()
        Me.MembershipsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Movie_InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoviesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OverDue_MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalsTableAdapter = New Blockbuster.BlockbustersDataSetTableAdapters.RentalsTableAdapter()
        Me.InvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BlockbustersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembershipsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movie_InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OverDue_MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txbBalance
        '
        Me.txbBalance.Location = New System.Drawing.Point(644, 809)
        Me.txbBalance.Name = "txbBalance"
        Me.txbBalance.Size = New System.Drawing.Size(100, 22)
        Me.txbBalance.TabIndex = 151
        '
        'txbTax
        '
        Me.txbTax.Location = New System.Drawing.Point(644, 757)
        Me.txbTax.Name = "txbTax"
        Me.txbTax.Size = New System.Drawing.Size(100, 22)
        Me.txbTax.TabIndex = 148
        '
        'txbSubtotal
        '
        Me.txbSubtotal.Location = New System.Drawing.Point(644, 706)
        Me.txbSubtotal.Name = "txbSubtotal"
        Me.txbSubtotal.Size = New System.Drawing.Size(100, 22)
        Me.txbSubtotal.TabIndex = 147
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(736, 912)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 146
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblBalanceDue
        '
        Me.lblBalanceDue.AutoSize = True
        Me.lblBalanceDue.Location = New System.Drawing.Point(545, 814)
        Me.lblBalanceDue.Name = "lblBalanceDue"
        Me.lblBalanceDue.Size = New System.Drawing.Size(93, 17)
        Me.lblBalanceDue.TabIndex = 145
        Me.lblBalanceDue.Text = "Balance Due:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(545, 760)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(35, 17)
        Me.lblTax.TabIndex = 144
        Me.lblTax.Text = "Tax:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(545, 707)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(64, 17)
        Me.lblSubtotal.TabIndex = 141
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'txbExpMonth
        '
        Me.txbExpMonth.Location = New System.Drawing.Point(95, 831)
        Me.txbExpMonth.Name = "txbExpMonth"
        Me.txbExpMonth.Size = New System.Drawing.Size(100, 22)
        Me.txbExpMonth.TabIndex = 140
        '
        'txbCreditCardNumber
        '
        Me.txbCreditCardNumber.Location = New System.Drawing.Point(153, 793)
        Me.txbCreditCardNumber.Name = "txbCreditCardNumber"
        Me.txbCreditCardNumber.Size = New System.Drawing.Size(258, 22)
        Me.txbCreditCardNumber.TabIndex = 139
        '
        'tbxCRVCode
        '
        Me.tbxCRVCode.Location = New System.Drawing.Point(93, 877)
        Me.tbxCRVCode.Name = "tbxCRVCode"
        Me.tbxCRVCode.Size = New System.Drawing.Size(100, 22)
        Me.tbxCRVCode.TabIndex = 138
        '
        'txbExpYear
        '
        Me.txbExpYear.Location = New System.Drawing.Point(305, 834)
        Me.txbExpYear.Name = "txbExpYear"
        Me.txbExpYear.Size = New System.Drawing.Size(100, 22)
        Me.txbExpYear.TabIndex = 137
        '
        'txbNameOnCard
        '
        Me.txbNameOnCard.Location = New System.Drawing.Point(153, 757)
        Me.txbNameOnCard.Name = "txbNameOnCard"
        Me.txbNameOnCard.Size = New System.Drawing.Size(258, 22)
        Me.txbNameOnCard.TabIndex = 136
        '
        'lblCRVCode
        '
        Me.lblCRVCode.AutoSize = True
        Me.lblCRVCode.Location = New System.Drawing.Point(14, 877)
        Me.lblCRVCode.Name = "lblCRVCode"
        Me.lblCRVCode.Size = New System.Drawing.Size(73, 17)
        Me.lblCRVCode.TabIndex = 135
        Me.lblCRVCode.Text = "CRV Code"
        '
        'lblExpYear
        '
        Me.lblExpYear.AutoSize = True
        Me.lblExpYear.Location = New System.Drawing.Point(232, 834)
        Me.lblExpYear.Name = "lblExpYear"
        Me.lblExpYear.Size = New System.Drawing.Size(69, 17)
        Me.lblExpYear.TabIndex = 134
        Me.lblExpYear.Text = "Exp. Year"
        '
        'lblExpMonth
        '
        Me.lblExpMonth.AutoSize = True
        Me.lblExpMonth.Location = New System.Drawing.Point(14, 834)
        Me.lblExpMonth.Name = "lblExpMonth"
        Me.lblExpMonth.Size = New System.Drawing.Size(78, 17)
        Me.lblExpMonth.TabIndex = 133
        Me.lblExpMonth.Text = "Exp. Month"
        '
        'lblCreditCardNumber
        '
        Me.lblCreditCardNumber.AutoSize = True
        Me.lblCreditCardNumber.Location = New System.Drawing.Point(14, 796)
        Me.lblCreditCardNumber.Name = "lblCreditCardNumber"
        Me.lblCreditCardNumber.Size = New System.Drawing.Size(133, 17)
        Me.lblCreditCardNumber.TabIndex = 132
        Me.lblCreditCardNumber.Text = "Credit Card Number"
        '
        'lblNameOnCard
        '
        Me.lblNameOnCard.AutoSize = True
        Me.lblNameOnCard.Location = New System.Drawing.Point(12, 757)
        Me.lblNameOnCard.Name = "lblNameOnCard"
        Me.lblNameOnCard.Size = New System.Drawing.Size(102, 17)
        Me.lblNameOnCard.TabIndex = 131
        Me.lblNameOnCard.Text = "Name On Card"
        '
        'rbPayPal
        '
        Me.rbPayPal.AutoSize = True
        Me.rbPayPal.Location = New System.Drawing.Point(194, 707)
        Me.rbPayPal.Name = "rbPayPal"
        Me.rbPayPal.Size = New System.Drawing.Size(73, 21)
        Me.rbPayPal.TabIndex = 130
        Me.rbPayPal.TabStop = True
        Me.rbPayPal.Text = "PayPal"
        Me.rbPayPal.UseVisualStyleBackColor = True
        '
        'rbCheck
        '
        Me.rbCheck.AutoSize = True
        Me.rbCheck.Location = New System.Drawing.Point(95, 707)
        Me.rbCheck.Name = "rbCheck"
        Me.rbCheck.Size = New System.Drawing.Size(68, 21)
        Me.rbCheck.TabIndex = 129
        Me.rbCheck.TabStop = True
        Me.rbCheck.Text = "Check"
        Me.rbCheck.UseVisualStyleBackColor = True
        '
        'rbCredit
        '
        Me.rbCredit.AutoSize = True
        Me.rbCredit.Location = New System.Drawing.Point(13, 707)
        Me.rbCredit.Name = "rbCredit"
        Me.rbCredit.Size = New System.Drawing.Size(66, 21)
        Me.rbCredit.TabIndex = 128
        Me.rbCredit.TabStop = True
        Me.rbCredit.Text = "Credit"
        Me.rbCredit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 687)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 20)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Payment Information"
        '
        'lstRentalItems
        '
        Me.lstRentalItems.DisplayMember = "Invoice Number"
        Me.lstRentalItems.FormattingEnabled = True
        Me.lstRentalItems.ItemHeight = 16
        Me.lstRentalItems.Location = New System.Drawing.Point(2, 350)
        Me.lstRentalItems.Name = "lstRentalItems"
        Me.lstRentalItems.Size = New System.Drawing.Size(802, 324)
        Me.lstRentalItems.TabIndex = 126
        Me.lstRentalItems.ValueMember = "Invoice Number"
        '
        'lblCustomerInformation
        '
        Me.lblCustomerInformation.AutoSize = True
        Me.lblCustomerInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerInformation.Location = New System.Drawing.Point(12, 57)
        Me.lblCustomerInformation.Name = "lblCustomerInformation"
        Me.lblCustomerInformation.Size = New System.Drawing.Size(218, 25)
        Me.lblCustomerInformation.TabIndex = 125
        Me.lblCustomerInformation.Text = "Customer Information"
        '
        'lblRentalItems
        '
        Me.lblRentalItems.AutoSize = True
        Me.lblRentalItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalItems.Location = New System.Drawing.Point(350, 322)
        Me.lblRentalItems.Name = "lblRentalItems"
        Me.lblRentalItems.Size = New System.Drawing.Size(131, 25)
        Me.lblRentalItems.TabIndex = 124
        Me.lblRentalItems.Text = "Rental Items"
        '
        'txbName
        '
        Me.txbName.Location = New System.Drawing.Point(253, 107)
        Me.txbName.Name = "txbName"
        Me.txbName.Size = New System.Drawing.Size(379, 22)
        Me.txbName.TabIndex = 123
        '
        'txbDate
        '
        Me.txbDate.Location = New System.Drawing.Point(670, 9)
        Me.txbDate.Name = "txbDate"
        Me.txbDate.Size = New System.Drawing.Size(118, 22)
        Me.txbDate.TabIndex = 122
        '
        'txbMemberID
        '
        Me.txbMemberID.Location = New System.Drawing.Point(15, 107)
        Me.txbMemberID.Name = "txbMemberID"
        Me.txbMemberID.Size = New System.Drawing.Size(162, 22)
        Me.txbMemberID.TabIndex = 121
        '
        'tbxAddress
        '
        Me.tbxAddress.Location = New System.Drawing.Point(15, 187)
        Me.tbxAddress.Name = "tbxAddress"
        Me.tbxAddress.Size = New System.Drawing.Size(332, 22)
        Me.tbxAddress.TabIndex = 120
        '
        'txbCity
        '
        Me.txbCity.Location = New System.Drawing.Point(383, 187)
        Me.txbCity.Name = "txbCity"
        Me.txbCity.Size = New System.Drawing.Size(133, 22)
        Me.txbCity.TabIndex = 119
        '
        'txbState
        '
        Me.txbState.Location = New System.Drawing.Point(568, 187)
        Me.txbState.Name = "txbState"
        Me.txbState.Size = New System.Drawing.Size(51, 22)
        Me.txbState.TabIndex = 118
        '
        'txbZipCode
        '
        Me.txbZipCode.Location = New System.Drawing.Point(670, 187)
        Me.txbZipCode.Name = "txbZipCode"
        Me.txbZipCode.Size = New System.Drawing.Size(100, 22)
        Me.txbZipCode.TabIndex = 117
        '
        'txbPhone
        '
        Me.txbPhone.Location = New System.Drawing.Point(15, 262)
        Me.txbPhone.Name = "txbPhone"
        Me.txbPhone.Size = New System.Drawing.Size(100, 22)
        Me.txbPhone.TabIndex = 116
        '
        'txbInvoice
        '
        Me.txbInvoice.Location = New System.Drawing.Point(82, 4)
        Me.txbInvoice.Name = "txbInvoice"
        Me.txbInvoice.Size = New System.Drawing.Size(167, 22)
        Me.txbInvoice.TabIndex = 115
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(12, 242)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(49, 17)
        Me.lblPhone.TabIndex = 114
        Me.lblPhone.Text = "Phone"
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Location = New System.Drawing.Point(667, 167)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(65, 17)
        Me.lblZipCode.TabIndex = 113
        Me.lblZipCode.Text = "Zip Code"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(565, 167)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(41, 17)
        Me.lblState.TabIndex = 112
        Me.lblState.Text = "State"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(380, 167)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(31, 17)
        Me.lblCity.TabIndex = 111
        Me.lblCity.Text = "City"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(12, 167)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(60, 17)
        Me.lblAddress.TabIndex = 110
        Me.lblAddress.Text = "Address"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(613, 12)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(38, 17)
        Me.lblDate.TabIndex = 109
        Me.lblDate.Text = "Date"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(256, 87)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 108
        Me.lblName.Text = "Name"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Location = New System.Drawing.Point(12, 87)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(85, 17)
        Me.lblCustomerID.TabIndex = 107
        Me.lblCustomerID.Text = "Customer ID"
        '
        'lblInvoice
        '
        Me.lblInvoice.AutoSize = True
        Me.lblInvoice.Location = New System.Drawing.Point(12, 9)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(64, 17)
        Me.lblInvoice.TabIndex = 106
        Me.lblInvoice.Text = "Invoice #"
        '
        'BlockbustersDataSet
        '
        Me.BlockbustersDataSet.DataSetName = "BlockbustersDataSet"
        Me.BlockbustersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'MoviesBindingSource
        '
        Me.MoviesBindingSource.DataMember = "Movies"
        Me.MoviesBindingSource.DataSource = Me.BlockbustersDataSet
        '
        'OverDue_MembersBindingSource
        '
        Me.OverDue_MembersBindingSource.DataMember = "OverDue Members"
        Me.OverDue_MembersBindingSource.DataSource = Me.BlockbustersDataSet
        '
        'RentalsBindingSource
        '
        Me.RentalsBindingSource.DataMember = "Rentals"
        Me.RentalsBindingSource.DataSource = Me.BlockbustersDataSet
        '
        'RentalsTableAdapter
        '
        Me.RentalsTableAdapter.ClearBeforeFill = True
        '
        'InvoicesBindingSource
        '
        Me.InvoicesBindingSource.DataMember = "Invoices"
        '
        'CheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1127, 1055)
        Me.Controls.Add(Me.txbBalance)
        Me.Controls.Add(Me.txbTax)
        Me.Controls.Add(Me.txbSubtotal)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblBalanceDue)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.txbExpMonth)
        Me.Controls.Add(Me.txbCreditCardNumber)
        Me.Controls.Add(Me.tbxCRVCode)
        Me.Controls.Add(Me.txbExpYear)
        Me.Controls.Add(Me.txbNameOnCard)
        Me.Controls.Add(Me.lblCRVCode)
        Me.Controls.Add(Me.lblExpYear)
        Me.Controls.Add(Me.lblExpMonth)
        Me.Controls.Add(Me.lblCreditCardNumber)
        Me.Controls.Add(Me.lblNameOnCard)
        Me.Controls.Add(Me.rbPayPal)
        Me.Controls.Add(Me.rbCheck)
        Me.Controls.Add(Me.rbCredit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstRentalItems)
        Me.Controls.Add(Me.lblCustomerInformation)
        Me.Controls.Add(Me.lblRentalItems)
        Me.Controls.Add(Me.txbName)
        Me.Controls.Add(Me.txbDate)
        Me.Controls.Add(Me.txbMemberID)
        Me.Controls.Add(Me.tbxAddress)
        Me.Controls.Add(Me.txbCity)
        Me.Controls.Add(Me.txbState)
        Me.Controls.Add(Me.txbZipCode)
        Me.Controls.Add(Me.txbPhone)
        Me.Controls.Add(Me.txbInvoice)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblZipCode)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.lblInvoice)
        Me.Name = "CheckOut"
        Me.Text = "CheckOut"
        CType(Me.BlockbustersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembershipsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movie_InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OverDue_MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txbBalance As TextBox
    Friend WithEvents txbTax As TextBox
    Friend WithEvents txbSubtotal As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents lblBalanceDue As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents txbExpMonth As TextBox
    Friend WithEvents txbCreditCardNumber As TextBox
    Friend WithEvents tbxCRVCode As TextBox
    Friend WithEvents txbExpYear As TextBox
    Friend WithEvents txbNameOnCard As TextBox
    Friend WithEvents lblCRVCode As Label
    Friend WithEvents lblExpYear As Label
    Friend WithEvents lblExpMonth As Label
    Friend WithEvents lblCreditCardNumber As Label
    Friend WithEvents lblNameOnCard As Label
    Friend WithEvents rbPayPal As RadioButton
    Friend WithEvents rbCheck As RadioButton
    Friend WithEvents rbCredit As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lstRentalItems As ListBox
    Friend WithEvents lblCustomerInformation As Label
    Friend WithEvents lblRentalItems As Label
    Friend WithEvents txbName As TextBox
    Friend WithEvents txbDate As TextBox
    Friend WithEvents txbMemberID As TextBox
    Friend WithEvents tbxAddress As TextBox
    Friend WithEvents txbCity As TextBox
    Friend WithEvents txbState As TextBox
    Friend WithEvents txbZipCode As TextBox
    Friend WithEvents txbPhone As TextBox
    Friend WithEvents txbInvoice As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblZipCode As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents lblInvoice As Label
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
    Friend WithEvents OverDue_MembersBindingSource As BindingSource
    Friend WithEvents RentalsBindingSource As BindingSource
    Friend WithEvents RentalsTableAdapter As BlockbustersDataSetTableAdapters.RentalsTableAdapter
    Friend WithEvents InvoicesBindingSource As BindingSource
End Class
