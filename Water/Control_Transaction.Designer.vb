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
        Me.productprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox_Products = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView_Cart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_TotalPrice
        '
        Me.Label_TotalPrice.AutoSize = True
        Me.Label_TotalPrice.Location = New System.Drawing.Point(532, 254)
        Me.Label_TotalPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_TotalPrice.Name = "Label_TotalPrice"
        Me.Label_TotalPrice.Size = New System.Drawing.Size(66, 18)
        Me.Label_TotalPrice.TabIndex = 22
        Me.Label_TotalPrice.Text = "Php.0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(445, 254)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 18)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Total Price"
        '
        'TextBox_CustomerName
        '
        Me.TextBox_CustomerName.Location = New System.Drawing.Point(143, 35)
        Me.TextBox_CustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_CustomerName.Name = "TextBox_CustomerName"
        Me.TextBox_CustomerName.Size = New System.Drawing.Size(199, 24)
        Me.TextBox_CustomerName.TabIndex = 20
        '
        'Label_TransactionNum
        '
        Me.Label_TransactionNum.AutoSize = True
        Me.Label_TransactionNum.Location = New System.Drawing.Point(149, 10)
        Me.Label_TransactionNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_TransactionNum.Name = "Label_TransactionNum"
        Me.Label_TransactionNum.Size = New System.Drawing.Size(161, 18)
        Me.Label_TransactionNum.TabIndex = 19
        Me.Label_TransactionNum.Text = "Label_TransactionNum"
        '
        'Button_AddToCart
        '
        Me.Button_AddToCart.Location = New System.Drawing.Point(14, 370)
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
        Me.Label_Price.Location = New System.Drawing.Point(26, 337)
        Me.Label_Price.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Price.Name = "Label_Price"
        Me.Label_Price.Size = New System.Drawing.Size(85, 18)
        Me.Label_Price.TabIndex = 17
        Me.Label_Price.Text = "Label_Price"
        '
        'Button_Checkout
        '
        Me.Button_Checkout.Location = New System.Drawing.Point(448, 282)
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
        Me.GroupBox2.Location = New System.Drawing.Point(435, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(426, 235)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cart"
        '
        'DataGridView_Cart
        '
        Me.DataGridView_Cart.AllowUserToAddRows = False
        Me.DataGridView_Cart.AllowUserToDeleteRows = False
        Me.DataGridView_Cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Cart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productname, Me.productprice})
        Me.DataGridView_Cart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Cart.Location = New System.Drawing.Point(4, 21)
        Me.DataGridView_Cart.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView_Cart.MultiSelect = False
        Me.DataGridView_Cart.Name = "DataGridView_Cart"
        Me.DataGridView_Cart.ReadOnly = True
        Me.DataGridView_Cart.RowHeadersVisible = False
        Me.DataGridView_Cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Cart.Size = New System.Drawing.Size(418, 210)
        Me.DataGridView_Cart.TabIndex = 0
        '
        'productname
        '
        Me.productname.HeaderText = "Product"
        Me.productname.Name = "productname"
        Me.productname.ReadOnly = True
        '
        'productprice
        '
        Me.productprice.HeaderText = "Price"
        Me.productprice.Name = "productprice"
        Me.productprice.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox_Products)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 78)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(300, 235)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Products"
        '
        'ListBox_Products
        '
        Me.ListBox_Products.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox_Products.FormattingEnabled = True
        Me.ListBox_Products.ItemHeight = 18
        Me.ListBox_Products.Location = New System.Drawing.Point(4, 21)
        Me.ListBox_Products.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox_Products.Name = "ListBox_Products"
        Me.ListBox_Products.Size = New System.Drawing.Size(292, 210)
        Me.ListBox_Products.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Customer Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Transaction No.:"
        '
        'Control_Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
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
    Friend WithEvents productname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox_Products As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
