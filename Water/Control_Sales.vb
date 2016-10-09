Imports MySql.Data.MySqlClient
Public Class Control_Sales
    Public dbdataset As New DataTable
    Private Sub Control_Sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Transaction_Table()
    End Sub
    Public Sub Load_Transaction_Table()
        dbdataset.Clear()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String
        Dim adapter As New MySqlDataAdapter
        Dim bsource As New BindingSource

        Try
            MySQLConn.Open()
            query = "SELECT transactionnum, customername, productname, productprice, date_format(transactiondate, '%Y-%m-%d') AS transactiondate FROM transac_table"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView_Transactions.DataSource = bsource
            adapter.Update(dbdataset)
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub Button_Filter_Click(sender As System.Object, e As System.EventArgs) Handles Button_Filter.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        If DateTimePicker_SalesStartDate.Value > DateTimePicker_SalesEndDate.Value Then
            MsgBox("Start date cannot be more than the End date!", MsgBoxStyle.Critical, SystemTitle)
        Else
            dbdataset.Clear()
            Dim query As String
            Dim adapter As New MySqlDataAdapter
            Dim bsource As New BindingSource
            Try
                MySQLConn.Open()
                query = "SELECT transactionnum, customername, productname, productprice, date_format(transactiondate, '%Y-%m-%d') AS transactiondate FROM transac_table WHERE transactiondate BETWEEN @startdate AND @enddate"
                comm = New MySqlCommand(query, MySQLConn)
                adapter.SelectCommand = comm
                adapter.SelectCommand.Parameters.AddWithValue("startdate", DateTimePicker_SalesStartDate.Text)
                adapter.SelectCommand.Parameters.AddWithValue("enddate", DateTimePicker_SalesEndDate.Text)
                adapter.Fill(dbdataset)
                bsource.DataSource = dbdataset
                DataGridView_Transactions.DataSource = dbdataset
                adapter.Update(dbdataset)
                MySQLConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub Button_ShowAll_Click(sender As System.Object, e As System.EventArgs) Handles Button_ShowAll.Click
        Load_Transaction_Table()
    End Sub

    Private Sub Button_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Print.Click
        PrintRange.ShowDialog()
    End Sub
End Class
