Imports Microsoft.Reporting.WinForms
Class PrintTransaction

    Private Sub PrintTransaction_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub PrintTransaction_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
    End Sub

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
            Dim PreparedBy As New ReportParameter("PreparedBy", LoggedInName)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\Receipt.rdlc"

            ReportViewer1.LocalReport.SetParameters(CustName)
            ReportViewer1.LocalReport.SetParameters(TransacNum)
            ReportViewer1.LocalReport.SetParameters(TransacDate)
            ReportViewer1.LocalReport.SetParameters(AmountDue)
            ReportViewer1.LocalReport.SetParameters(payment)
            ReportViewer1.LocalReport.SetParameters(PreparedBy)

            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", TransactionReceiptDataSet.Tables(2)))

            ReportViewer1.DocumentMapCollapsed = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ReportViewer1.RefreshReport()
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 25

    End Sub

End Class