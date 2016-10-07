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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.B6_Maintenance = New System.Windows.Forms.Button()
        Me.B5_LogO = New System.Windows.Forms.Button()
        Me.B4_Sales = New System.Windows.Forms.Button()
        Me.B3_Inventory = New System.Windows.Forms.Button()
        Me.B2_Employee = New System.Windows.Forms.Button()
        Me.B1_Transaction = New System.Windows.Forms.Button()
        Me.UserControl_Maintenance1 = New Water.UserControl_Maintenance()
        Me.UserControl11 = New Water.UserControl1()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Transaction"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Employee"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Inventory"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 398)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Sales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 582)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Log-Out"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1, 490)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Maintenance"
        '
        'B6_Maintenance
        '
        Me.B6_Maintenance.BackgroundImage = Global.Water.My.Resources.Resources.Drop
        Me.B6_Maintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.B6_Maintenance.Location = New System.Drawing.Point(2, 421)
        Me.B6_Maintenance.Name = "B6_Maintenance"
        Me.B6_Maintenance.Size = New System.Drawing.Size(107, 79)
        Me.B6_Maintenance.TabIndex = 22
        Me.B6_Maintenance.UseVisualStyleBackColor = True
        '
        'B5_LogO
        '
        Me.B5_LogO.BackgroundImage = Global.Water.My.Resources.Resources.power
        Me.B5_LogO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B5_LogO.Location = New System.Drawing.Point(-1, 516)
        Me.B5_LogO.Margin = New System.Windows.Forms.Padding(4)
        Me.B5_LogO.Name = "B5_LogO"
        Me.B5_LogO.Size = New System.Drawing.Size(110, 71)
        Me.B5_LogO.TabIndex = 10
        Me.B5_LogO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B5_LogO.UseVisualStyleBackColor = True
        '
        'B4_Sales
        '
        Me.B4_Sales.BackgroundImage = Global.Water.My.Resources.Resources.sales
        Me.B4_Sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B4_Sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B4_Sales.Location = New System.Drawing.Point(2, 316)
        Me.B4_Sales.Margin = New System.Windows.Forms.Padding(4)
        Me.B4_Sales.Name = "B4_Sales"
        Me.B4_Sales.Size = New System.Drawing.Size(110, 91)
        Me.B4_Sales.TabIndex = 9
        Me.B4_Sales.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.B4_Sales.UseVisualStyleBackColor = True
        '
        'B3_Inventory
        '
        Me.B3_Inventory.BackgroundImage = Global.Water.My.Resources.Resources.inv
        Me.B3_Inventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B3_Inventory.Location = New System.Drawing.Point(2, 206)
        Me.B3_Inventory.Margin = New System.Windows.Forms.Padding(4)
        Me.B3_Inventory.Name = "B3_Inventory"
        Me.B3_Inventory.Size = New System.Drawing.Size(110, 93)
        Me.B3_Inventory.TabIndex = 5
        Me.B3_Inventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.B3_Inventory.UseVisualStyleBackColor = True
        '
        'B2_Employee
        '
        Me.B2_Employee.BackgroundImage = Global.Water.My.Resources.Resources.emp
        Me.B2_Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.B2_Employee.Location = New System.Drawing.Point(2, 107)
        Me.B2_Employee.Margin = New System.Windows.Forms.Padding(4)
        Me.B2_Employee.Name = "B2_Employee"
        Me.B2_Employee.Size = New System.Drawing.Size(110, 85)
        Me.B2_Employee.TabIndex = 2
        Me.B2_Employee.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.B2_Employee.UseVisualStyleBackColor = True
        '
        'B1_Transaction
        '
        Me.B1_Transaction.BackgroundImage = Global.Water.My.Resources.Resources.home
        Me.B1_Transaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B1_Transaction.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.B1_Transaction.Location = New System.Drawing.Point(4, 2)
        Me.B1_Transaction.Margin = New System.Windows.Forms.Padding(4)
        Me.B1_Transaction.Name = "B1_Transaction"
        Me.B1_Transaction.Size = New System.Drawing.Size(108, 88)
        Me.B1_Transaction.TabIndex = 1
        Me.B1_Transaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.B1_Transaction.UseVisualStyleBackColor = True
        '
        'UserControl_Maintenance1
        '
        Me.UserControl_Maintenance1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.UserControl_Maintenance1.Location = New System.Drawing.Point(159, 36)
        Me.UserControl_Maintenance1.Margin = New System.Windows.Forms.Padding(4)
        Me.UserControl_Maintenance1.Name = "UserControl_Maintenance1"
        Me.UserControl_Maintenance1.Size = New System.Drawing.Size(1090, 595)
        Me.UserControl_Maintenance1.TabIndex = 25
        '
        'UserControl11
        '
        Me.UserControl11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.UserControl11.Location = New System.Drawing.Point(175, 36)
        Me.UserControl11.Margin = New System.Windows.Forms.Padding(4)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(1149, 464)
        Me.UserControl11.TabIndex = 24
        '
        'Control_Sales1
        '
        Me.Control_Sales1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Control_Sales1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Control_Sales1.Location = New System.Drawing.Point(175, 36)
        Me.Control_Sales1.Margin = New System.Windows.Forms.Padding(4)
        Me.Control_Sales1.Name = "Control_Sales1"
        Me.Control_Sales1.Size = New System.Drawing.Size(830, 537)
        Me.Control_Sales1.TabIndex = 13
        '
        'Control_Employee1
        '
        Me.Control_Employee1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Control_Employee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Control_Employee1.Location = New System.Drawing.Point(138, 36)
        Me.Control_Employee1.Margin = New System.Windows.Forms.Padding(4)
        Me.Control_Employee1.Name = "Control_Employee1"
        Me.Control_Employee1.Size = New System.Drawing.Size(672, 551)
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
        Me.ClientSize = New System.Drawing.Size(1334, 685)
        Me.Controls.Add(Me.UserControl_Maintenance1)
        Me.Controls.Add(Me.UserControl11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.B6_Maintenance)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
        Me.PerformLayout()

    End Sub
    Friend WithEvents B1_Transaction As System.Windows.Forms.Button
    Friend WithEvents B2_Employee As System.Windows.Forms.Button
    Friend WithEvents B3_Inventory As System.Windows.Forms.Button
    Friend WithEvents B4_Sales As System.Windows.Forms.Button
    Friend WithEvents B5_LogO As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog_ChooseEmployeePicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Control_Employee1 As Water.Control_Employee
    Friend WithEvents Control_Sales1 As Water.Control_Sales
    Friend WithEvents Control_Transaction1 As Water.Control_Transaction
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents B6_Maintenance As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents UserControl11 As Water.UserControl1
    Friend WithEvents UserControl_Maintenance1 As Water.UserControl_Maintenance
End Class
