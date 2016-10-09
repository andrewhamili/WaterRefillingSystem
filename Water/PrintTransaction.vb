Imports Microsoft.Reporting.WinForms
Class PrintTransaction

    Private Sub PrintTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Try
            Dim CustName As New ReportParameter("CustomerName", Form_Home.Control_Transaction1.TextBox_CustomerName.Text)
            Dim TransacNum As New ReportParameter("TransactionNumber", CurrentTransactionNumber)
            Dim TransacDate As New ReportParameter("TransactionDate", Date.Now.ToString("MMMMMMMM dd, yyyy"))
            Dim AmountDue As New ReportParameter("AmountDue", CartPrice)
            Dim payment As New ReportParameter("Payment", CashTendered)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\Report2.rdlc"

            ReportViewer1.LocalReport.SetParameters(CustName)
            ReportViewer1.LocalReport.SetParameters(TransacNum)
            ReportViewer1.LocalReport.SetParameters(TransacDate)
            ReportViewer1.LocalReport.SetParameters(AmountDue)
            ReportViewer1.LocalReport.SetParameters(payment)

            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", TransactionReceiptDataSet.Tables(2)))

            ReportViewer1.DocumentMapCollapsed = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ReportViewer1.RefreshReport()
    End Sub
End Class