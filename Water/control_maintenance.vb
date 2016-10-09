Imports MySql.Data.MySqlClient

Public Class UserControl_Maintenance




    Private Sub UserControl_Maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Products()
        Label_quantity.Text = ""
        Label_StockOnHand.Text = ""
    End Sub
    Public Sub Load_Products()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT * FROM producttable WHERE productname NOT LIKE '%Refill%';", MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                ComboBox_ProductName.Items.Remove(reader.GetString("productname"))
                ComboBox_ProductName.Items.Add(reader.GetString("productname"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub ComboBox_ProductName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_ProductName.SelectedIndexChanged
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT productquantity FROM producttable WHERE productname=@selectedproductname", MySQLConn)
            comm.Parameters.AddWithValue("selectedproductname", ComboBox_ProductName.Text)
            reader = comm.ExecuteReader
            While reader.Read
                Label_quantity.Text = reader.GetString("productquantity")
            End While
            MySQLConn.Close()
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT COALESCE(sum(quantity), 0) AS total FROM transac_table WHERE productname=@selectedproductname", MySQLConn)
            comm.Parameters.AddWithValue("selectedproductname", ComboBox_ProductName.Text)
            reader = comm.ExecuteReader
            While reader.Read
                Label_StockOnHand.Text = CInt(Label_quantity.Text) - reader.GetString("total")
            End While
            MySQLConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
End Class
