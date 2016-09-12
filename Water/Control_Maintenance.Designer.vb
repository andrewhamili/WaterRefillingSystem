<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control_Maintenance
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
        Me.Panel_MaintenaceProductSales = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.TextBox_MaintenanceProdPrice = New System.Windows.Forms.TextBox()
        Me.TextBox_MaintenanceProdQuantity = New System.Windows.Forms.TextBox()
        Me.TextBox_MaintenanceProdName = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Button_ProductMaintenanceDelete = New System.Windows.Forms.Button()
        Me.Button_ProductMaintenanceEdit = New System.Windows.Forms.Button()
        Me.Button_ProductMaintenanceAdd = New System.Windows.Forms.Button()
        Me.GroupBox_Product = New System.Windows.Forms.GroupBox()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel_MaintenaceProductSales.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Product.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_MaintenaceProductSales
        '
        Me.Panel_MaintenaceProductSales.Controls.Add(Me.Label34)
        Me.Panel_MaintenaceProductSales.Controls.Add(Me.GroupBox5)
        Me.Panel_MaintenaceProductSales.Controls.Add(Me.TextBox_MaintenanceProdPrice)
        Me.Panel_MaintenaceProductSales.Controls.Add(Me.TextBox_MaintenanceProdQuantity)
        Me.Panel_MaintenaceProductSales.Controls.Add(Me.TextBox_MaintenanceProdName)
        Me.Panel_MaintenaceProductSales.Controls.Add(Me.Label33)
        Me.Panel_MaintenaceProductSales.Controls.Add(Me.Label32)
        Me.Panel_MaintenaceProductSales.Controls.Add(Me.Label31)
        Me.Panel_MaintenaceProductSales.Controls.Add(Me.Button_ProductMaintenanceDelete)
        Me.Panel_MaintenaceProductSales.Controls.Add(Me.Button_ProductMaintenanceEdit)
        Me.Panel_MaintenaceProductSales.Controls.Add(Me.Button_ProductMaintenanceAdd)
        Me.Panel_MaintenaceProductSales.Controls.Add(Me.GroupBox_Product)
        Me.Panel_MaintenaceProductSales.Controls.Add(Me.Label17)
        Me.Panel_MaintenaceProductSales.Location = New System.Drawing.Point(12, 12)
        Me.Panel_MaintenaceProductSales.Name = "Panel_MaintenaceProductSales"
        Me.Panel_MaintenaceProductSales.Size = New System.Drawing.Size(418, 586)
        Me.Panel_MaintenaceProductSales.TabIndex = 15
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.White
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(30, 299)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(61, 24)
        Me.Label34.TabIndex = 12
        Me.Label34.Text = "Sales"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView5)
        Me.GroupBox5.Location = New System.Drawing.Point(19, 337)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(381, 100)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GroupBox_Sales"
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView5.Location = New System.Drawing.Point(3, 20)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(375, 77)
        Me.DataGridView5.TabIndex = 0
        '
        'TextBox_MaintenanceProdPrice
        '
        Me.TextBox_MaintenanceProdPrice.Location = New System.Drawing.Point(149, 255)
        Me.TextBox_MaintenanceProdPrice.Name = "TextBox_MaintenanceProdPrice"
        Me.TextBox_MaintenanceProdPrice.Size = New System.Drawing.Size(153, 24)
        Me.TextBox_MaintenanceProdPrice.TabIndex = 10
        '
        'TextBox_MaintenanceProdQuantity
        '
        Me.TextBox_MaintenanceProdQuantity.Location = New System.Drawing.Point(149, 225)
        Me.TextBox_MaintenanceProdQuantity.Name = "TextBox_MaintenanceProdQuantity"
        Me.TextBox_MaintenanceProdQuantity.Size = New System.Drawing.Size(153, 24)
        Me.TextBox_MaintenanceProdQuantity.TabIndex = 9
        '
        'TextBox_MaintenanceProdName
        '
        Me.TextBox_MaintenanceProdName.Location = New System.Drawing.Point(149, 197)
        Me.TextBox_MaintenanceProdName.Name = "TextBox_MaintenanceProdName"
        Me.TextBox_MaintenanceProdName.Size = New System.Drawing.Size(153, 24)
        Me.TextBox_MaintenanceProdName.TabIndex = 8
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.Lime
        Me.Label33.Location = New System.Drawing.Point(101, 260)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(42, 18)
        Me.Label33.TabIndex = 7
        Me.Label33.Text = "Price"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.Lime
        Me.Label32.Location = New System.Drawing.Point(81, 233)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(62, 18)
        Me.Label32.TabIndex = 6
        Me.Label32.Text = "Quantity"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.Lime
        Me.Label31.Location = New System.Drawing.Point(39, 203)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(104, 18)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = "Product Name"
        '
        'Button_ProductMaintenanceDelete
        '
        Me.Button_ProductMaintenanceDelete.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Button_ProductMaintenanceDelete.Location = New System.Drawing.Point(325, 253)
        Me.Button_ProductMaintenanceDelete.Name = "Button_ProductMaintenanceDelete"
        Me.Button_ProductMaintenanceDelete.Size = New System.Drawing.Size(75, 23)
        Me.Button_ProductMaintenanceDelete.TabIndex = 4
        Me.Button_ProductMaintenanceDelete.Text = "Delete"
        Me.Button_ProductMaintenanceDelete.UseVisualStyleBackColor = True
        '
        'Button_ProductMaintenanceEdit
        '
        Me.Button_ProductMaintenanceEdit.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Button_ProductMaintenanceEdit.Location = New System.Drawing.Point(325, 224)
        Me.Button_ProductMaintenanceEdit.Name = "Button_ProductMaintenanceEdit"
        Me.Button_ProductMaintenanceEdit.Size = New System.Drawing.Size(75, 23)
        Me.Button_ProductMaintenanceEdit.TabIndex = 3
        Me.Button_ProductMaintenanceEdit.Text = "Edit"
        Me.Button_ProductMaintenanceEdit.UseVisualStyleBackColor = True
        '
        'Button_ProductMaintenanceAdd
        '
        Me.Button_ProductMaintenanceAdd.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Button_ProductMaintenanceAdd.Location = New System.Drawing.Point(325, 195)
        Me.Button_ProductMaintenanceAdd.Name = "Button_ProductMaintenanceAdd"
        Me.Button_ProductMaintenanceAdd.Size = New System.Drawing.Size(75, 23)
        Me.Button_ProductMaintenanceAdd.TabIndex = 2
        Me.Button_ProductMaintenanceAdd.Text = "Add"
        Me.Button_ProductMaintenanceAdd.UseVisualStyleBackColor = True
        '
        'GroupBox_Product
        '
        Me.GroupBox_Product.Controls.Add(Me.DataGridView4)
        Me.GroupBox_Product.Location = New System.Drawing.Point(22, 78)
        Me.GroupBox_Product.Name = "GroupBox_Product"
        Me.GroupBox_Product.Size = New System.Drawing.Size(384, 100)
        Me.GroupBox_Product.TabIndex = 1
        Me.GroupBox_Product.TabStop = False
        Me.GroupBox_Product.Text = "GroupBox_Product"
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView4.Location = New System.Drawing.Point(3, 20)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(378, 77)
        Me.DataGridView4.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Lime
        Me.Label17.Location = New System.Drawing.Point(110, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(235, 25)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Product Maintenance"
        '
        'Control_Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel_MaintenaceProductSales)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Control_Maintenance"
        Me.Size = New System.Drawing.Size(445, 615)
        Me.Panel_MaintenaceProductSales.ResumeLayout(False)
        Me.Panel_MaintenaceProductSales.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Product.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_MaintenaceProductSales As System.Windows.Forms.Panel
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox_MaintenanceProdPrice As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_MaintenanceProdQuantity As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_MaintenanceProdName As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Button_ProductMaintenanceDelete As System.Windows.Forms.Button
    Friend WithEvents Button_ProductMaintenanceEdit As System.Windows.Forms.Button
    Friend WithEvents Button_ProductMaintenanceAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox_Product As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As System.Windows.Forms.Label

End Class
