Imports MySql.Data.MySqlClient

Public Class PrintTransaction

    Private Sub PrintTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open()
            Dim ds As New DataSet1

            Dim adapter As New MySqlDataAdapter
            comm = New MySqlCommand("SELECT DISTINCT productname, product FROM transac_table WHERE transactionnum='" & CurrentTransactionNumber & "'", MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(ds.Tables(1))
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\Report2.rdlc"
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(1)))

            ReportViewer1.DocumentMapCollapsed = True
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ReportViewer1.RefreshReport()
    End Sub
End Class