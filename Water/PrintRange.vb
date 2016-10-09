Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class PrintRange

    Private Sub PrintRange_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub PrintRange_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
    End Sub

    Private Sub PrintRange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Try
            MySQLConn.Open()
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1

            Dim datefrom As New ReportParameter("DateFrom", Form_Home.Control_Sales1.DateTimePicker_SalesStartDate.Value.ToString("MM-dd-yyyy"))
            Dim dateto As New ReportParameter("DateTo", Form_Home.Control_Sales1.DateTimePicker_SalesEndDate.Value.ToString("MM-dd-yyyy"))
            Dim prepare As New ReportParameter("PreparedBy", LoggedInName)

            adapter.SelectCommand = comm


            adapter.Fill(ds.Tables(0))
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\TransactionsByRange.rdlc"
            ReportViewer1.LocalReport.SetParameters(datefrom)
            ReportViewer1.LocalReport.SetParameters(dateto)
            ReportViewer1.LocalReport.SetParameters(prepare)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            ReportViewer1.DocumentMapCollapsed = True
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ReportViewer1.RefreshReport()
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 25
    End Sub
End Class