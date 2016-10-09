<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashTender
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
        Me.TextBox_CashTendered = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Proceed = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox_CashTendered
        '
        Me.TextBox_CashTendered.Location = New System.Drawing.Point(62, 6)
        Me.TextBox_CashTendered.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_CashTendered.Name = "TextBox_CashTendered"
        Me.TextBox_CashTendered.Size = New System.Drawing.Size(98, 24)
        Me.TextBox_CashTendered.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cash"
        '
        'Button_Proceed
        '
        Me.Button_Proceed.Location = New System.Drawing.Point(174, 5)
        Me.Button_Proceed.Name = "Button_Proceed"
        Me.Button_Proceed.Size = New System.Drawing.Size(75, 26)
        Me.Button_Proceed.TabIndex = 2
        Me.Button_Proceed.Text = "Proceed"
        Me.Button_Proceed.UseVisualStyleBackColor = True
        '
        'CashTender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 37)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_Proceed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_CashTendered)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CashTender"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Tendered"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_CashTendered As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_Proceed As System.Windows.Forms.Button
End Class
