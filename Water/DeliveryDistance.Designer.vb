<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeliveryDistance
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Radio_Near = New System.Windows.Forms.RadioButton()
        Me.Radio_Far = New System.Windows.Forms.RadioButton()
        Me.Button_ConfirmDeliveryDistance = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose the Customer's distance from this shop."
        '
        'Radio_Near
        '
        Me.Radio_Near.AutoSize = True
        Me.Radio_Near.Location = New System.Drawing.Point(12, 42)
        Me.Radio_Near.Name = "Radio_Near"
        Me.Radio_Near.Size = New System.Drawing.Size(197, 22)
        Me.Radio_Near.TabIndex = 1
        Me.Radio_Near.TabStop = True
        Me.Radio_Near.Text = "Near (Additional Php.5.00)"
        Me.Radio_Near.UseVisualStyleBackColor = True
        '
        'Radio_Far
        '
        Me.Radio_Far.AutoSize = True
        Me.Radio_Far.Location = New System.Drawing.Point(12, 79)
        Me.Radio_Far.Name = "Radio_Far"
        Me.Radio_Far.Size = New System.Drawing.Size(195, 22)
        Me.Radio_Far.TabIndex = 2
        Me.Radio_Far.TabStop = True
        Me.Radio_Far.Text = "Far (Additional Php.10.00)"
        Me.Radio_Far.UseVisualStyleBackColor = True
        '
        'Button_ConfirmDeliveryDistance
        '
        Me.Button_ConfirmDeliveryDistance.Location = New System.Drawing.Point(224, 52)
        Me.Button_ConfirmDeliveryDistance.Name = "Button_ConfirmDeliveryDistance"
        Me.Button_ConfirmDeliveryDistance.Size = New System.Drawing.Size(108, 36)
        Me.Button_ConfirmDeliveryDistance.TabIndex = 3
        Me.Button_ConfirmDeliveryDistance.Text = "Confirm"
        Me.Button_ConfirmDeliveryDistance.UseVisualStyleBackColor = True
        '
        'DeliveryDistance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 116)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_ConfirmDeliveryDistance)
        Me.Controls.Add(Me.Radio_Far)
        Me.Controls.Add(Me.Radio_Near)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DeliveryDistance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeliveryDistance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Radio_Near As System.Windows.Forms.RadioButton
    Friend WithEvents Radio_Far As System.Windows.Forms.RadioButton
    Friend WithEvents Button_ConfirmDeliveryDistance As System.Windows.Forms.Button
End Class
