<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.OpenFileDialog_ChooseEmployeePicture = New System.Windows.Forms.OpenFileDialog()
        Me.B5_LogO = New System.Windows.Forms.Button()
        Me.B4_Sales = New System.Windows.Forms.Button()
        Me.B3_Inventory = New System.Windows.Forms.Button()
        Me.B2_Employee = New System.Windows.Forms.Button()
        Me.B1_Transaction = New System.Windows.Forms.Button()
        Me.Control_Sales1 = New Water.Control_Sales()
        Me.Control_Employee1 = New Water.Control_Employee()
        Me.Control_Transaction1 = New Water.Control_Transaction()
        Me.SuspendLayout()
        '
        'OpenFileDialog_ChooseEmployeePicture
        '
        Me.OpenFileDialog_ChooseEmployeePicture.FileName = "OpenFileDialog1"
        Me.OpenFileDialog_ChooseEmployeePicture.Filter = "JPG(*.jpg)|*.jpg|JPEG(*.jpeg)|*.jpeg|PNG(*.png)|*.png|BITMAP(*.bmp)|*.bmp"
        '
        'B5_LogO
        '
        Me.B5_LogO.BackgroundImage = Global.Water.My.Resources.Resources.power
        Me.B5_LogO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B5_LogO.Location = New System.Drawing.Point(4, 485)
        Me.B5_LogO.Margin = New System.Windows.Forms.Padding(4)
        Me.B5_LogO.Name = "B5_LogO"
        Me.B5_LogO.Size = New System.Drawing.Size(110, 102)
        Me.B5_LogO.TabIndex = 10
        Me.B5_LogO.Text = "Log-Out"
        Me.B5_LogO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B5_LogO.UseVisualStyleBackColor = True
        '
        'B4_Sales
        '
        Me.B4_Sales.BackgroundImage = Global.Water.My.Resources.Resources.sales
        Me.B4_Sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B4_Sales.Location = New System.Drawing.Point(4, 371)
        Me.B4_Sales.Margin = New System.Windows.Forms.Padding(4)
        Me.B4_Sales.Name = "B4_Sales"
        Me.B4_Sales.Size = New System.Drawing.Size(110, 91)
        Me.B4_Sales.TabIndex = 9
        Me.B4_Sales.Text = "Sales"
        Me.B4_Sales.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B4_Sales.UseVisualStyleBackColor = True
        '
        'B3_Inventory
        '
        Me.B3_Inventory.BackgroundImage = Global.Water.My.Resources.Resources.inv
        Me.B3_Inventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B3_Inventory.Location = New System.Drawing.Point(4, 249)
        Me.B3_Inventory.Margin = New System.Windows.Forms.Padding(4)
        Me.B3_Inventory.Name = "B3_Inventory"
        Me.B3_Inventory.Size = New System.Drawing.Size(110, 102)
        Me.B3_Inventory.TabIndex = 5
        Me.B3_Inventory.Text = "Inventory"
        Me.B3_Inventory.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B3_Inventory.UseVisualStyleBackColor = True
        '
        'B2_Employee
        '
        Me.B2_Employee.BackgroundImage = Global.Water.My.Resources.Resources.emp
        Me.B2_Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.B2_Employee.Location = New System.Drawing.Point(4, 141)
        Me.B2_Employee.Margin = New System.Windows.Forms.Padding(4)
        Me.B2_Employee.Name = "B2_Employee"
        Me.B2_Employee.Size = New System.Drawing.Size(110, 85)
        Me.B2_Employee.TabIndex = 2
        Me.B2_Employee.Text = "Employee"
        Me.B2_Employee.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B2_Employee.UseVisualStyleBackColor = True
        '
        'B1_Transaction
        '
        Me.B1_Transaction.BackgroundImage = Global.Water.My.Resources.Resources.home
        Me.B1_Transaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B1_Transaction.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B1_Transaction.Location = New System.Drawing.Point(4, 36)
        Me.B1_Transaction.Margin = New System.Windows.Forms.Padding(4)
        Me.B1_Transaction.Name = "B1_Transaction"
        Me.B1_Transaction.Size = New System.Drawing.Size(110, 84)
        Me.B1_Transaction.TabIndex = 1
        Me.B1_Transaction.Text = "Transaction"
        Me.B1_Transaction.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B1_Transaction.UseVisualStyleBackColor = True
        '
        'Control_Sales1
        '
        Me.Control_Sales1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Control_Sales1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Control_Sales1.Location = New System.Drawing.Point(138, 36)
        Me.Control_Sales1.Margin = New System.Windows.Forms.Padding(4)
        Me.Control_Sales1.Name = "Control_Sales1"
        Me.Control_Sales1.Size = New System.Drawing.Size(1007, 603)
        Me.Control_Sales1.TabIndex = 13
        '
        'Control_Employee1
        '
        Me.Control_Employee1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Control_Employee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Control_Employee1.Location = New System.Drawing.Point(138, 36)
        Me.Control_Employee1.Margin = New System.Windows.Forms.Padding(4)
        Me.Control_Employee1.Name = "Control_Employee1"
        Me.Control_Employee1.Size = New System.Drawing.Size(802, 589)
        Me.Control_Employee1.TabIndex = 12
        '
        'Control_Transaction1
        '
        Me.Control_Transaction1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Control_Transaction1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Control_Transaction1.Location = New System.Drawing.Point(138, 36)
        Me.Control_Transaction1.Margin = New System.Windows.Forms.Padding(4)
        Me.Control_Transaction1.Name = "Control_Transaction1"
        Me.Control_Transaction1.Size = New System.Drawing.Size(1079, 442)
        Me.Control_Transaction1.TabIndex = 11
        '
        'Form_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1334, 649)
        Me.Controls.Add(Me.Control_Sales1)
        Me.Controls.Add(Me.Control_Employee1)
        Me.Controls.Add(Me.Control_Transaction1)
        Me.Controls.Add(Me.B5_LogO)
        Me.Controls.Add(Me.B4_Sales)
        Me.Controls.Add(Me.B3_Inventory)
        Me.Controls.Add(Me.B2_Employee)
        Me.Controls.Add(Me.B1_Transaction)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_Home"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents B1_Transaction As System.Windows.Forms.Button
    Friend WithEvents B2_Employee As System.Windows.Forms.Button
    Friend WithEvents B3_Inventory As System.Windows.Forms.Button
    Friend WithEvents B4_Sales As System.Windows.Forms.Button
    Friend WithEvents B5_LogO As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog_ChooseEmployeePicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Control_Transaction1 As Water.Control_Transaction
    Friend WithEvents Control_Employee1 As Water.Control_Employee
    Friend WithEvents Control_Sales1 As Water.Control_Sales
End Class
