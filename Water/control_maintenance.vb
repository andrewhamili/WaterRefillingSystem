Imports MySql.Data.MySqlClient

Public Class UserControl_Maintenance




    Private Sub UserControl_Maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Products()
        Label_quantity.Text = ""
        Label_StockOnHand.Text = ""
        Label_Stock.Hide()
        Button_Save.Hide()

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

    Private Sub Button_AddStocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_AddStocks.Click
        Button_AddStocks.Hide()
        ComboBox_ProductName.Enabled = False
        Label_Stock.Show()
        Button_Save.Show()
    End Sub

    Private Sub Button_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Save.Click
        If TextBox_NewStock.Text = "0" Or TextBox_NewStock.Text = "" Then
            MsgBox("Nothing to add", MsgBoxStyle.Information, SystemTitle)
            Button_AddStocks.Show()
            Label_Stock.Hide()
            Button_Save.Hide()
            ComboBox_ProductName.Enabled = True
            Label_quantity.Text = ""
            Label_StockOnHand.Text = ""
        Else
            If MySQLConn.State = ConnectionState.Open Then
                MySQLConn.Close()
            End If
            MySQLConn.ConnectionString = connstring
            Try
                MySQLConn.Open()
                comm = New MySqlCommand("UPDATE producttable set productquantity=@newquantity WHERE productname=@selectedproduct", MySQLConn)
                comm.Parameters.AddWithValue("newquantity", CInt(TextBox_NewStock.Text) + CInt(Label_quantity.Text))
                comm.Parameters.AddWithValue("selectedproduct", ComboBox_ProductName.Text)
                reader = comm.ExecuteReader
                MySQLConn.Close()
                MsgBox("The Product has been successfully updated!", MsgBoxStyle.Information, SystemTitle)
                Button_AddStocks.Show()
                Label_Stock.Hide()
                Button_Save.Hide()
                ComboBox_ProductName.Enabled = True
                Label_quantity.Text = ""
                Label_StockOnHand.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        End If
        
    End Sub

    Private Sub TextBox_NewStock_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox_NewStock.TextChanged
        Dim charactersAllowed As String = "1234567890"
        Dim theText As String = TextBox_NewStock.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextBox_NewStock.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TextBox_NewStock.Text.Length - 1
            Letter = TextBox_NewStock.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        TextBox_NewStock.Text = theText
        TextBox_NewStock.Select(SelectionIndex - Change, 0)
    End Sub
End Class
