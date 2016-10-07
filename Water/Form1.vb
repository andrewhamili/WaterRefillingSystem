Imports MySql.Data.MySqlClient
Public Class Form_Home

    Private Sub Form_Home_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        B5_LogO.PerformClick()
    End Sub

    Private Sub Form_Home_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub

    Private Sub Form_Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control_Transaction1.Hide()
        Control_Sales1.Hide()
        Control_Employee1.Hide()
        UserControl11.Hide()
        UserControl_Maintenance1.Hide()
    End Sub
    Private Sub B5_LogO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B5_LogO.Click
        Dim p As Integer
        p = MsgBox("Are you sure you want to log out?", MsgBoxStyle.YesNo, "Alkaline Water Store")
        If p = 6 Then
            Me.Dispose()
            Form_LogIn.Show()
        End If
    End Sub
    Private Sub B1_Transaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1_Transaction.Click
        Control_Sales1.Hide()
        Control_Employee1.Hide()
        UserControl11.Hide()
        Control_Transaction1.Show()
        UserControl_Maintenance1.Hide()
        Control_Transaction1.Button_Reset_Click()
    End Sub
    Private Sub B2_Employee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2_Employee.Click
        Control_Sales1.Hide()
        Control_Employee1.Show()
        Control_Transaction1.Hide()
        UserControl11.Hide()
        UserControl_Maintenance1.Hide()
        Control_Employee1.Label_EmployeeFirstname.Text = ""
        Control_Employee1.Label_EmployeeMiddleName.Text = ""
        Control_Employee1.Label_EmployeeLastname.Text = ""
        Control_Employee1.Label_EmployeeAddress.Text = ""
        Control_Employee1.Label_EmployeeEmail.Text = ""
        Control_Employee1.Label_EmployeeContact.Text = ""
        Control_Employee1.Label_EmployeeContact.Text = ""
    End Sub

    Private Sub B3_Inventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3_Inventory.Click
        Control_Employee1.Hide()
        Control_Transaction1.Hide()
        Control_Sales1.Hide()
        UserControl11.Show()
        UserControl_Maintenance1.Hide()
    End Sub

    Private Sub B4_Sales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B4_Sales.Click
        Control_Employee1.Hide()
        Control_Transaction1.Hide()
        Control_Sales1.Show()
        UserControl11.Hide()
        UserControl_Maintenance1.Hide()
        Control_Sales1.Load_Transaction_Table()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Control_Employee1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Control_Employee1.Load

    End Sub

    Private Sub B6_Maintenance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B6_Maintenance.Click
        Control_Employee1.Hide()
        Control_Transaction1.Hide()
        Control_Sales1.Hide()
        UserControl11.Hide()
        Control_Sales1.Load_Transaction_Table()
        UserControl_Maintenance1.Show()
    End Sub
End Class





