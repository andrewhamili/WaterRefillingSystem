Public Class DeliveryDistance

    Private Sub Button_ConfirmDeliveryDistance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_ConfirmDeliveryDistance.Click
        If Radio_Near.Checked = True Then
            DeliveryPrice = 5
            Me.Dispose()
        ElseIf Radio_Far.Checked = True Then
            DeliveryPrice = 10
            Me.Dispose()
        Else
            MsgBox("Please choose the distance!", MsgBoxStyle.Critical, SystemTitle)
        End If
    End Sub
End Class