<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control_Sales
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView_Transactions = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button_ShowAll = New System.Windows.Forms.Button()
        Me.Button_Filter = New System.Windows.Forms.Button()
        Me.DateTimePicker_SalesEndDate = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_SalesStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView_Transactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView_Transactions)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 209)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(774, 351)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transactions"
        '
        'DataGridView_Transactions
        '
        Me.DataGridView_Transactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Transactions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Transactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView_Transactions.Location = New System.Drawing.Point(6, 22)
        Me.DataGridView_Transactions.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView_Transactions.Name = "DataGridView_Transactions"
        Me.DataGridView_Transactions.RowHeadersVisible = False
        Me.DataGridView_Transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Transactions.Size = New System.Drawing.Size(762, 324)
        Me.DataGridView_Transactions.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button_ShowAll)
        Me.GroupBox4.Controls.Add(Me.Button_Filter)
        Me.GroupBox4.Controls.Add(Me.DateTimePicker_SalesEndDate)
        Me.GroupBox4.Controls.Add(Me.DateTimePicker_SalesStartDate)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(774, 159)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Date Range"
        '
        'Button_ShowAll
        '
        Me.Button_ShowAll.Location = New System.Drawing.Point(618, 78)
        Me.Button_ShowAll.Name = "Button_ShowAll"
        Me.Button_ShowAll.Size = New System.Drawing.Size(132, 23)
        Me.Button_ShowAll.TabIndex = 18
        Me.Button_ShowAll.Text = "Show All"
        Me.Button_ShowAll.UseVisualStyleBackColor = True
        '
        'Button_Filter
        '
        Me.Button_Filter.Location = New System.Drawing.Point(499, 76)
        Me.Button_Filter.Name = "Button_Filter"
        Me.Button_Filter.Size = New System.Drawing.Size(100, 23)
        Me.Button_Filter.TabIndex = 17
        Me.Button_Filter.Text = "Filter"
        Me.Button_Filter.UseVisualStyleBackColor = True
        '
        'DateTimePicker_SalesEndDate
        '
        Me.DateTimePicker_SalesEndDate.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker_SalesEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_SalesEndDate.Location = New System.Drawing.Point(387, 75)
        Me.DateTimePicker_SalesEndDate.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker_SalesEndDate.Name = "DateTimePicker_SalesEndDate"
        Me.DateTimePicker_SalesEndDate.Size = New System.Drawing.Size(104, 24)
        Me.DateTimePicker_SalesEndDate.TabIndex = 16
        '
        'DateTimePicker_SalesStartDate
        '
        Me.DateTimePicker_SalesStartDate.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker_SalesStartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker_SalesStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_SalesStartDate.Location = New System.Drawing.Point(129, 76)
        Me.DateTimePicker_SalesStartDate.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker_SalesStartDate.Name = "DateTimePicker_SalesStartDate"
        Me.DateTimePicker_SalesStartDate.Size = New System.Drawing.Size(103, 24)
        Me.DateTimePicker_SalesStartDate.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(293, 80)
        Me.Label18.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 18)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "End Date:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 80)
        Me.Label19.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 18)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Start Date:"
        '
        'Control_Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Control_Sales"
        Me.Size = New System.Drawing.Size(797, 572)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView_Transactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView_Transactions As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker_SalesEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker_SalesStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button_Filter As System.Windows.Forms.Button
    Friend WithEvents Button_ShowAll As System.Windows.Forms.Button

End Class
