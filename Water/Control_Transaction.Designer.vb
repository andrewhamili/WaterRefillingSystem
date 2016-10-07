<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control_Transaction
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label_TotalPrice = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_CustomerName = New System.Windows.Forms.TextBox()
        Me.Label_TransactionNum = New System.Windows.Forms.Label()
        Me.Button_AddToCart = New System.Windows.Forms.Button()
        Me.Label_Price = New System.Windows.Forms.Label()
        Me.Button_Checkout = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView_Cart = New System.Windows.Forms.DataGridView()
        Me.productname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Listbox_Products = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Reset = New System.Windows.Forms.Button()
        Me.CheckBox_Delivery = New System.Windows.Forms.CheckBox()
        Me.label_deliveryprice = New System.Windows.Forms.Label()
        Me.Timer_Delivery = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_quantity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button_CancelTransaction = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView_Cart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_TotalPrice
        '
        Me.Label_TotalPrice.AutoSize = True
        Me.Label_TotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TotalPrice.Location = New System.Drawing.Point(462, 238)
        Me.Label_TotalPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_TotalPrice.Name = "Label_TotalPrice"
        Me.Label_TotalPrice.Size = New System.Drawing.Size(74, 18)
        Me.Label_TotalPrice.TabIndex = 22
        Me.Label_TotalPrice.Text = "Php.0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(355, 238)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Total Price:"
        '
        'TextBox_CustomerName
        '
        Me.TextBox_CustomerName.Location = New System.Drawing.Point(132, 38)
        Me.TextBox_CustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_CustomerName.Name = "TextBox_CustomerName"
        Me.TextBox_CustomerName.Size = New System.Drawing.Size(184, 24)
        Me.TextBox_CustomerName.TabIndex = 20
        '
        'Label_TransactionNum
        '
        Me.Label_TransactionNum.AutoSize = True
        Me.Label_TransactionNum.Location = New System.Drawing.Point(136, 10)
        Me.Label_TransactionNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_TransactionNum.Name = "Label_TransactionNum"
        Me.Label_TransactionNum.Size = New System.Drawing.Size(161, 18)
        Me.Label_TransactionNum.TabIndex = 19
        Me.Label_TransactionNum.Text = "Label_TransactionNum"
        '
        'Button_AddToCart
        '
        Me.Button_AddToCart.Location = New System.Drawing.Point(17, 247)
        Me.Button_AddToCart.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_AddToCart.Name = "Button_AddToCart"
        Me.Button_AddToCart.Size = New System.Drawing.Size(105, 30)
        Me.Button_AddToCart.TabIndex = 18
        Me.Button_AddToCart.Text = "Add to Cart"
        Me.Button_AddToCart.UseVisualStyleBackColor = True
        '
        'Label_Price
        '
        Me.Label_Price.AutoSize = True
        Me.Label_Price.Location = New System.Drawing.Point(129, 198)
        Me.Label_Price.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Price.Name = "Label_Price"
        Me.Label_Price.Size = New System.Drawing.Size(85, 18)
        Me.Label_Price.TabIndex = 17
        Me.Label_Price.Text = "Label_Price"
        '
        'Button_Checkout
        '
        Me.Button_Checkout.Location = New System.Drawing.Point(797, 147)
        Me.Button_Checkout.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Checkout.Name = "Button_Checkout"
        Me.Button_Checkout.Size = New System.Drawing.Size(111, 31)
        Me.Button_Checkout.TabIndex = 16
        Me.Button_Checkout.Text = "Check-out"
        Me.Button_Checkout.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView_Cart)
        Me.GroupBox2.Location = New System.Drawing.Point(353, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(426, 220)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cart"
        '
        'DataGridView_Cart
        '
        Me.DataGridView_Cart.AllowUserToAddRows = False
        Me.DataGridView_Cart.AllowUserToDeleteRows = False
        Me.DataGridView_Cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Cart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productname, Me.Qty, Me.productprice})
        Me.DataGridView_Cart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Cart.Location = New System.Drawing.Point(4, 21)
        Me.DataGridView_Cart.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView_Cart.MultiSelect = False
        Me.DataGridView_Cart.Name = "DataGridView_Cart"
        Me.DataGridView_Cart.ReadOnly = True
        Me.DataGridView_Cart.RowHeadersVisible = False
        Me.DataGridView_Cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Cart.Size = New System.Drawing.Size(418, 195)
        Me.DataGridView_Cart.TabIndex = 0
        '
        'productname
        '
        Me.productname.HeaderText = "Product"
        Me.productname.Name = "productname"
        Me.productname.ReadOnly = True
        '
        'Qty
        '
        Me.Qty.HeaderText = "Quantity"
        Me.Qty.MinimumWidth = 10
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        '
        'productprice
        '
        Me.productprice.HeaderText = "Price"
        Me.productprice.Name = "productprice"
        Me.productprice.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Listbox_Products)
        Me.GroupBox1.Location = New System.Drawing.Point(132, 70)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(193, 62)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Products"
        '
        'Listbox_Products
        '
        Me.Listbox_Products.FormattingEnabled = True
        Me.Listbox_Products.Items.AddRange(New Object() {"1 Liter", "1Liter (Refill)", "10 Liter", "10 Liter (Refill)", "5 Gallon", "5 Gallon (Refil)", "500 mL", "500 mL (Refill)", "6 Liter", "6 Liter (Refill)"})
        Me.Listbox_Products.Location = New System.Drawing.Point(0, 22)
        Me.Listbox_Products.Name = "Listbox_Products"
        Me.Listbox_Products.Size = New System.Drawing.Size(188, 26)
        Me.Listbox_Products.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-2, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Customer Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Transaction # :"
        '
        'Button_Reset
        '
        Me.Button_Reset.Location = New System.Drawing.Point(797, 185)
        Me.Button_Reset.Name = "Button_Reset"
        Me.Button_Reset.Size = New System.Drawing.Size(100, 31)
        Me.Button_Reset.TabIndex = 23
        Me.Button_Reset.Text = "Reset"
        Me.Button_Reset.UseVisualStyleBackColor = True
        '
        'CheckBox_Delivery
        '
        Me.CheckBox_Delivery.AutoSize = True
        Me.CheckBox_Delivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Delivery.Location = New System.Drawing.Point(358, 259)
        Me.CheckBox_Delivery.Name = "CheckBox_Delivery"
        Me.CheckBox_Delivery.Size = New System.Drawing.Size(87, 22)
        Me.CheckBox_Delivery.TabIndex = 24
        Me.CheckBox_Delivery.Text = "Delivery"
        Me.CheckBox_Delivery.UseVisualStyleBackColor = True
        '
        'label_deliveryprice
        '
        Me.label_deliveryprice.AllowDrop = True
        Me.label_deliveryprice.AutoSize = True
        Me.label_deliveryprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_deliveryprice.Location = New System.Drawing.Point(462, 284)
        Me.label_deliveryprice.Name = "label_deliveryprice"
        Me.label_deliveryprice.Size = New System.Drawing.Size(74, 22)
        Me.label_deliveryprice.TabIndex = 25
        Me.label_deliveryprice.Text = "Php.5.00 "
        Me.label_deliveryprice.UseCompatibleTextRendering = True
        Me.label_deliveryprice.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Quantity: "
        '
        'TextBox_quantity
        '
        Me.TextBox_quantity.Location = New System.Drawing.Point(132, 143)
        Me.TextBox_quantity.Name = "TextBox_quantity"
        Me.TextBox_quantity.Size = New System.Drawing.Size(195, 24)
        Me.TextBox_quantity.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Products:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Price:"
        '
        'Button_CancelTransaction
        '
        Me.Button_CancelTransaction.Location = New System.Drawing.Point(139, 247)
        Me.Button_CancelTransaction.Name = "Button_CancelTransaction"
        Me.Button_CancelTransaction.Size = New System.Drawing.Size(75, 30)
        Me.Button_CancelTransaction.TabIndex = 30
        Me.Button_CancelTransaction.Text = "Cancel"
        Me.Button_CancelTransaction.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(339, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 18)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Delivery Fee:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(337, 314)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 18)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "TOTAL BILL :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(397, 343)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 18)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "VAT :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(356, 373)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 18)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "VATABLE :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(382, 401)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 18)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "CASH :"
        '
        'Control_Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button_CancelTransaction)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_quantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label_deliveryprice)
        Me.Controls.Add(Me.CheckBox_Delivery)
        Me.Controls.Add(Me.Button_Reset)
        Me.Controls.Add(Me.Label_TotalPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_CustomerName)
        Me.Controls.Add(Me.Label_TransactionNum)
        Me.Controls.Add(Me.Button_AddToCart)
        Me.Controls.Add(Me.Label_Price)
        Me.Controls.Add(Me.Button_Checkout)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Control_Transaction"
        Me.Size = New System.Drawing.Size(1007, 521)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView_Cart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_TotalPrice As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox_CustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label_TransactionNum As System.Windows.Forms.Label
    Friend WithEvents Button_AddToCart As System.Windows.Forms.Button
    Friend WithEvents Label_Price As System.Windows.Forms.Label
    Friend WithEvents Button_Checkout As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView_Cart As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_Reset As System.Windows.Forms.Button
    Friend WithEvents CheckBox_Delivery As System.Windows.Forms.CheckBox
    Friend WithEvents label_deliveryprice As System.Windows.Forms.Label
    Friend WithEvents Timer_Delivery As System.Windows.Forms.Timer
    Friend WithEvents Listbox_Products As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_quantity As System.Windows.Forms.TextBox
    Friend WithEvents productname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button_CancelTransaction As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
