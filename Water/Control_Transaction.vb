
Imports MySql.Data.MySqlClient
Public Class Control_Transaction
    Public TransactionNumber As New Random()
    Private Sub Control_Transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub ListBox_Products_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox_Products.SelectedIndexChanged
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

    Private Sub Button_AddToCart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_AddToCart.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
		 End If
        If TextBox_CustomerName.Text = "" Then
            MsgBox("Please enter the customer's name first!", MsgBoxStyle.Exclamation, SystemTitle)
        Else

            If ListBox_Products.Text = "" Then
                MsgBox("Please select a Product first!", MsgBoxStyle.Exclamation, SystemTitle)
            Else
                If ListBox_Products.Text = "" Then
                    MsgBox("Please select a Product first!", MsgBoxStyle.Exclamation, SystemTitle)
                Else

                    Dim query As String
                    Dim productname As String
                    Dim price As String
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
                            price = TextBox_quantity.Text
                        End While
                        MySQLConn.Close()
                        With DataGridView_Cart
                            .Rows.Add()
                            .Rows(Cart).Cells("productname").Value = productname
                            .Rows(Cart).Cells("Qty").Value = price
                            .Rows(Cart).Cells("productprice").Value = productprice
                            Cart += 1
                        End With
                        Load_Products()
                        Label_TotalPrice.Text = "Php." + FormatNumber(CDbl(CartPrice), 2)
                        DataGridView_Cart.FirstDisplayedScrollingRowIndex = DataGridView_Cart.RowCount - 1


                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        MySQLConn.Dispose()
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub Button_Checkout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Checkout.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Dim success As Boolean = False
        Dim transactiondate As Date = Now.ToString("yyyy-MM-dd")
        Dim rownumber As Integer = DataGridView_Cart.Rows.Count
        Dim counter As Integer = 0
        Dim query As String
        MySQLConn.ConnectionString = connstring
        If rownumber > 0 Then
            While counter <> rownumber
                Dim productname As String = DataGridView_Cart.Rows(counter).Cells("productname").Value
                Dim productprice As String = DataGridView_Cart.Rows(counter).Cells("productprice").Value
                success = False
                Try
                    MySQLConn.Open()
                    query = "INSERT INTO transac_table values(@transactionnum, @customername, @productname, @delivery, @productprice, @transactiondate)"
                    comm = New MySqlCommand(query, MySQLConn)
                    comm.Parameters.AddWithValue("transactionnum", Label_TransactionNum.Text)
                    comm.Parameters.AddWithValue("customername", TextBox_CustomerName.Text)
                    comm.Parameters.AddWithValue("productname", productname)
                    If CheckBox_Delivery.Checked = True Then
                        comm.Parameters.AddWithValue("delivery", "Yes")
                    Else
                        comm.Parameters.AddWithValue("delivery", "No")
                    End If
                    comm.Parameters.AddWithValue("productprice", productprice)
                    comm.Parameters.AddWithValue("transactiondate", transactiondate)
                    reader = comm.ExecuteReader
                    MySQLConn.Close()
                    success = True
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                counter = counter + 1
            End While
            Cart = 0
            CartPrice = 0
        Else
            MsgBox("The Cart is empty!", MsgBoxStyle.Exclamation, SystemTitle)

        End If
        If success = True Then
            MsgBox("The Transaction was successfully saved!", MsgBoxStyle.Information, SystemTitle)
            Button_Reset_Click()
        Else
            MsgBox("There was an error saving the transaction", MsgBoxStyle.Critical, SystemTitle)
        End If

    End Sub

    Public Sub Button_Reset_Click() Handles Button_Reset.Click
        TextBox_CustomerName.Text = ""
        Label_TransactionNum.Text = Now.ToString("yyyyHHmmss") + "" & TransactionNumber.Next(1, 1000000000)
        Cart = 0
        Load_Products()
        CartPrice = 0
        DataGridView_Cart.Rows.Clear()
        CheckBox_Delivery.Checked = False
        TextBox_CustomerName.Enabled = True
    End Sub

    Private Sub Timer_Delivery_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Delivery.Tick
        If CheckBox_Delivery.Checked = True Then
            label_deliveryprice.Visible = True
        Else
            label_deliveryprice.Visible = False
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub label_deliveryprice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles label_deliveryprice.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
End Class
