Imports MySql.Data.MySqlClient
Public Class Control_Transaction
    Public TransactionNumber As New Random()
    Private Sub Control_Transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Products()
        Label_Price.Text = ""
        Label_TransactionNum.Text = Now.ToString("yyyyHHmmss") + TransactionNumber.Next(1, 1000000000)
        Label_TotalPrice.Text = "Php." + FormatNumber(CDbl(CartPrice), 2)
    End Sub
    Public Sub Load_Products()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String
        Try
            MySQLConn.Open()
            query = "SELECT * FROM producttable WHERE productquantity > 0 ORDER BY productname ASC"
            comm = New mysqlcommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                ListBox_Products.Items.Remove(reader.GetString("productname"))
                ListBox_Products.Items.Add(reader.GetString("productname"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub ListBox_Products_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox_Products.SelectedIndexChanged
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Dim query As String
        Try
            MySQLConn.Open()
            query = "SELECT * FROM producttable WHERE productname=@selected"
            comm = New MySqlCommand(query, MySQLConn)
            comm.Parameters.AddWithValue("selected", ListBox_Products.Text)
            reader = comm.ExecuteReader
            While reader.Read
                Label_Price.Text = "Php." + reader.GetString("productprice")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub Button_AddToCart_Click(sender As System.Object, e As System.EventArgs) Handles Button_AddToCart.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        If ListBox_Products.Text = "" Then
            MsgBox("Please select a Product first!", MsgBoxStyle.Exclamation, SystemTitle)
        Else
            Dim query As String
            Dim productname As String
            Dim productprice As Integer
            TextBox_CustomerName.Enabled = False
            Try
                MySQLConn.Open()
                query = "SELECT * FROM producttable WHERE productname=@selected"
                comm = New MySqlCommand(query, MySQLConn)
                comm.Parameters.AddWithValue("selected", ListBox_Products.Text)
                reader = comm.ExecuteReader
                Dim count As Integer = 1
                'If DataGridView_Cart.RowCount >= 0 Then
                '    count = DataGridView_Cart.RowCount
                'End If
                While reader.Read
                    productname = reader.GetString("productname")
                    productprice = reader.GetInt32("productprice")
                    CartPrice = CartPrice + productprice
                End While
                MySQLConn.Close()
                With DataGridView_Cart
                    .Rows.Add()
                    .Rows(Cart).Cells("productname").Value = productname
                    .Rows(Cart).Cells("productprice").Value = productprice
                    Cart += 1
                End With
                ListBox_Products.ClearSelected()
                Load_Products()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        End If
        Label_TotalPrice.Text = "Php." + FormatNumber(CDbl(CartPrice), 2)
        DataGridView_Cart.FirstDisplayedScrollingRowIndex = DataGridView_Cart.RowCount - 1
    End Sub

    Private Sub Button_Checkout_Click(sender As System.Object, e As System.EventArgs) Handles Button_Checkout.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
    End Sub
End Class
