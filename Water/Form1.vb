Imports MySql.Data.MySqlClient
Public Class Form_Home

    Private Sub Form_Home_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        B5_LogO.PerformClick()
    End Sub

    Private Sub Form_Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control_Employee1.Hide()
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
        Control_Employee1.Hide()
    End Sub
    Private Sub B2_Employee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2_Employee.Click
        Control_Employee1.Show()
    End Sub

    Private Sub B3_Inventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3_Inventory.Click
        Control_Employee1.Hide()
    End Sub

    Private Sub B4_Sales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B4_Sales.Click
        Control_Employee1.Hide()
    End Sub
End Class





