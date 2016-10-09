<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Maintenance
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label_StockOnHand = New System.Windows.Forms.Label()
        Me.Label_quantity = New System.Windows.Forms.Label()
        Me.ComboBox_ProductName = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button_AddStocks = New System.Windows.Forms.Button()
        Me.TextBox_NewStock = New System.Windows.Forms.TextBox()
        Me.Label_Stock = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_Save)
        Me.GroupBox1.Controls.Add(Me.Label_StockOnHand)
        Me.GroupBox1.Controls.Add(Me.Label_quantity)
        Me.GroupBox1.Controls.Add(Me.ComboBox_ProductName)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Button_AddStocks)
        Me.GroupBox1.Controls.Add(Me.TextBox_NewStock)
        Me.GroupBox1.Controls.Add(Me.Label_Stock)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 287)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Products"
        '
        'Label_StockOnHand
        '
        Me.Label_StockOnHand.AutoSize = True
        Me.Label_StockOnHand.Location = New System.Drawing.Point(197, 129)
        Me.Label_StockOnHand.Name = "Label_StockOnHand"
        Me.Label_StockOnHand.Size = New System.Drawing.Size(227, 25)
        Me.Label_StockOnHand.TabIndex = 10
        Me.Label_StockOnHand.Text = "Label_StockOnHand"
        Me.Label_StockOnHand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_quantity
        '
        Me.Label_quantity.AutoSize = True
        Me.Label_quantity.Location = New System.Drawing.Point(197, 83)
        Me.Label_quantity.Name = "Label_quantity"
        Me.Label_quantity.Size = New System.Drawing.Size(167, 25)
        Me.Label_quantity.TabIndex = 9
        Me.Label_quantity.Text = "Label_quantity"
        Me.Label_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox_ProductName
        '
        Me.ComboBox_ProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_ProductName.FormattingEnabled = True
        Me.ComboBox_ProductName.Location = New System.Drawing.Point(184, 20)
        Me.ComboBox_ProductName.Name = "ComboBox_ProductName"
        Me.ComboBox_ProductName.Size = New System.Drawing.Size(145, 33)
        Me.ComboBox_ProductName.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 20)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Product Name"
        '
        'Button_AddStocks
        '
        Me.Button_AddStocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_AddStocks.Location = New System.Drawing.Point(184, 166)
        Me.Button_AddStocks.Name = "Button_AddStocks"
        Me.Button_AddStocks.Size = New System.Drawing.Size(155, 54)
        Me.Button_AddStocks.TabIndex = 3
        Me.Button_AddStocks.Text = "Add Stocks"
        Me.Button_AddStocks.UseVisualStyleBackColor = True
        '
        'TextBox_NewStock
        '
        Me.TextBox_NewStock.Location = New System.Drawing.Point(184, 177)
        Me.TextBox_NewStock.Name = "TextBox_NewStock"
        Me.TextBox_NewStock.Size = New System.Drawing.Size(145, 31)
        Me.TextBox_NewStock.TabIndex = 6
        '
        'Label_Stock
        '
        Me.Label_Stock.AutoSize = True
        Me.Label_Stock.Location = New System.Drawing.Point(27, 177)
        Me.Label_Stock.Name = "Label_Stock"
        Me.Label_Stock.Size = New System.Drawing.Size(137, 25)
        Me.Label_Stock.TabIndex = 3
        Me.Label_Stock.Text = "New Stock: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Stockonhand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Quantity of Product"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 25)
        Me.Label2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(38, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 321)
        Me.Panel1.TabIndex = 13
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(194, 238)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(145, 43)
        Me.Button_Save.TabIndex = 11
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'UserControl_Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UserControl_Maintenance"
        Me.Size = New System.Drawing.Size(767, 425)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_NewStock As System.Windows.Forms.TextBox
    Friend WithEvents Label_Stock As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button_AddStocks As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox_ProductName As System.Windows.Forms.ComboBox
    Friend WithEvents Label_StockOnHand As System.Windows.Forms.Label
    Friend WithEvents Label_quantity As System.Windows.Forms.Label
    Friend WithEvents Button_Save As System.Windows.Forms.Button

End Class
