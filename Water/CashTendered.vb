Public Class CashTender
    Public ButtonClick As Boolean = False
    Private Sub TextBox_CashTendered_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_CashTendered.KeyPress

        If TextBox_CashTendered.Text.Contains(".") Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        Else
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")

        End If


    End Sub

    Private Sub TextBox_CashTendered_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TextBox_CashTendered.PreviewKeyDown
        If e.KeyCode = Keys.Back Then
            If TextBox_CashTendered.Text.Length > 0 Then
                TextBox_CashTendered.Text = TextBox_CashTendered.Text.Substring(0, TextBox_CashTendered.Text.Length - 1)
                TextBox_CashTendered.Select(TextBox_CashTendered.Text.Length, 0)
            End If
        End If
    End Sub

    Private Sub Button_Proceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Proceed.Click
        If String.IsNullOrEmpty(TextBox_CashTendered.Text) Then
            MsgBox("Please enter the Amount!", MsgBoxStyle.Critical, SystemTitle)
        Else
            If CDbl(TextBox_CashTendered.Text) < CartPrice Then
                MsgBox("We cannot accept insufficient payments", MsgBoxStyle.Critical, SystemTitle)
            Else
                ButtonClick = True
                CashTendered = TextBox_CashTendered.Text
                Me.Dispose()
            End If
        End If
        
    End Sub

    Private Sub CashTender_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If ButtonClick = True Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub
End Class