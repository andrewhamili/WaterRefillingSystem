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
            query = "SELECT transactionnum AS 'Transaction Number', customername AS 'Customer Name', productname AS 'Product Name', productprice AS 'Price', delivery as 'Delivery', transactiondate AS 'Date' FROM transac_table;"
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
            query = "SELECT transactionnum AS 'Transaction Number', customername AS 'Customer Name', productname AS 'Product Name', productprice AS 'Price', delivery as 'Delivery', transactiondate AS 'Date' FROM transac_table WHERE transactiondate=@datechosen;"
            comm = New MySqlCommand(query, MySQLConn)
            comm.Parameters.AddWithValue("datechosen", DateTimePicker1.Value.ToString("yy-MM-dd"))
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
        'If MySQLConn.State = ConnectionState.Open.Open Then

        'End If



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
    End Sub

    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        load_items()
    End Sub

    Private Sub DataGridView_Transactions_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Transactions.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Print.ShowDialog()
    End Sub

    Private Sub UserControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
