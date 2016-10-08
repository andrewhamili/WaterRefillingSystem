Imports MySql.Data.MySqlClient
Public Class UserControl1

    Public query As String

    Public Sub Load_Transaction_Table()

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring

        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            MySQLConn.Open()
            query = "SELECT transactionnum, customername, productname, quantity, productprice, date_format(transactiondate, '%Y-%m-%d') AS transactiondate FROM transac_table;"
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

    Public Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim dbdataset As New DataTable
        Dim adapter As New MySqlDataAdapter
        Dim bsource As New BindingSource

        Try
            MySQLConn.Open()
            query = "SELECT transactionnum, customername, productname, quantity, productprice, date_format(transactiondate, '%Y-%m-%d') AS transactiondate FROM transac_table WHERE transactiondate=@datechosen;"
            comm = New MySqlCommand(query, MySQLConn)
            comm.Parameters.AddWithValue("datechosen", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
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
    Public Sub load_items()
        'dbdataset.Clear()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring
        Dim dbdataset As New DataTable
        Dim adapter As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Try
            MySQLConn.Open()
            query = "SELECT productname as 'Product Name', count(productname) as 'Items sold' FROM transac_table GROUP BY productname ORDER BY count(productname) DESC;"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView_Item.DataSource = bsource
            adapter.Update(dbdataset)
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TabPage1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage1.Enter
        Load_Transaction_Table()
        Compute_TotalPrice()
        Label2.Show()
        LabelTotal.Show()
    End Sub

    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        load_items()
        Label2.Hide()
        LabelTotal.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print.ShowDialog()
    End Sub
    Public Sub Compute_TotalPrice()
        Dim total As Integer
        For i As Integer = 0 To DataGridView_Transactions.RowCount - 1
            total += DataGridView_Transactions.Rows(i).Cells(4).Value
        Next
        LabelTotal.Text = total
    End Sub
End Class
