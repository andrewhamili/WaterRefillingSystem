
Imports MySql.Data.MySqlClient
Public Class Control_Transaction
    Public TransactionNumber As New Random()
    Public OneLstockOnHand As Integer
    Public OneLQuantity As Integer

    Public SixLstockOnHand As Integer
    Public SixLQuantity As Integer

    Public TenLstockOnHand As Integer
    Public TenLQuantity As Integer

    Public FiveHundredLstockOnHand As Integer
    Public FiveHundredLQuantity As Integer

    Public FiveGstockOnHand As Integer
    Public FiveGQuantity As Integer
    Private Sub Control_Transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Load_Products()
        Label_Price.Text = ""
        Label_TransactionNum.Text = Now.ToString("yyyyHHmmss") + TransactionNumber.Next(1, 10000)
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
        If Listbox_Products.Text.Contains("Refill") Then
            TextBox_quantity.Enabled = False
        Else
            TextBox_quantity.Enabled = True
        End If
    End Sub

    Private Sub Button_AddToCart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_AddToCart.Click
        If Format(CInt(TextBox_quantity.Text)) > 0 Then
            If MySQLConn.State = ConnectionState.Open Then
                MySQLConn.Close()
            End If
            If TextBox_CustomerName.Text = "" Then
                MsgBox("Please enter the customer's name first!", MsgBoxStyle.Exclamation, SystemTitle)
            Else

                If Listbox_Products.Text = "" Then
                    MsgBox("Please select a Product first!", MsgBoxStyle.Exclamation, SystemTitle)
                Else
                    If Listbox_Products.Text = "" Then
                        MsgBox("Please select a Product first!", MsgBoxStyle.Exclamation, SystemTitle)
                    Else

                        Dim query As String
                        Dim productname As String
                        Dim quantity As String
                        Dim productprice As Integer

                        


                        TextBox_CustomerName.Enabled = False
                        Try
                            MySQLConn.Open()
                            query = "SELECT * FROM producttable WHERE productname=@selected"
                            comm = New MySqlCommand(query, MySQLConn)
                            comm.Parameters.AddWithValue("selected", Listbox_Products.Text)
                            reader = comm.ExecuteReader
                            Dim count As Integer = 1
                            'If DataGridView_Cart.RowCount >= 0 Then
                            '    count = DataGridView_Cart.RowCount
                            'End If
                            While reader.Read
                                productname = reader.GetString("productname")
                                productprice = reader.GetInt32("productprice")
                                quantity = TextBox_quantity.Text

                            End While
                            MySQLConn.Close()
                            Dim tempquantity As Integer
                            Dim tempstockonhand As Integer
                            MySQLConn.Open()
                            comm = New MySqlCommand("SELECT productquantity FROM producttable WHERE productname=@selected", MySQLConn)
                            comm.Parameters.AddWithValue("selected", Listbox_Products.Text)
                            reader = comm.ExecuteReader
                            While reader.Read
                                tempquantity = reader.GetString("productquantity")
                            End While
                            MySQLConn.Close()
                            MySQLConn.Open()
                            comm = New MySqlCommand("SELECT COALESCE(sum(quantity), 0) AS total FROM transac_table WHERE productname=@selected", MySQLConn)
                            comm.Parameters.AddWithValue("selected", Listbox_Products.Text)
                            reader = comm.ExecuteReader
                            While reader.Read
                                tempstockonhand = tempquantity - reader.GetInt32("total")
                            End While
                            MySQLConn.Close()
                            If quantity > tempstockonhand Then
                                MsgBox("We do not have enough quantity of this product. We only have " & tempstockonhand & " left.", MsgBoxStyle.Critical, SystemTitle)
                            Else
                                With DataGridView_Cart
                                    .Rows.Add()
                                    .Rows(Cart).Cells("productname").Value = productname
                                    .Rows(Cart).Cells("Qty").Value = quantity
                                    .Rows(Cart).Cells("productprice").Value = productprice * quantity
                                    Cart += 1
                                    CartPrice = CartPrice + productprice * quantity
                                End With
                                Load_Products()
                                Label_TotalPrice.Text = "Php." + FormatNumber(CDbl(CartPrice), 2)
                                DataGridView_Cart.FirstDisplayedScrollingRowIndex = DataGridView_Cart.RowCount - 1
                            End If




                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            MySQLConn.Dispose()
                        End Try
                    End If
                End If
            End If
        Else
            MsgBox("You have entered an invalid Quantity! Please Double Check.", MsgBoxStyle.Critical, SystemTitle)
        End If
        TextBox_quantity.Text = 1
    End Sub

    Public Sub Button_Checkout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Checkout.Click


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
            Dim deliver As DialogResult = MsgBox("Is it for Delivery?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, SystemTitle)
            If deliver = DialogResult.Yes Then
                DeliveryDistance.ShowDialog()
                With DataGridView_Cart
                    .Rows.Add()
                    .Rows(Cart).Cells("productname").Value = "Delivery"
                    .Rows(Cart).Cells("Qty").Value = 0
                    .Rows(Cart).Cells("productprice").Value = DeliveryPrice
                    Cart += 1
                    rownumber += 1
                End With
            End If
            While counter <> rownumber
                Dim productname As String = DataGridView_Cart.Rows(counter).Cells("productname").Value
                Dim quantity As String = DataGridView_Cart.Rows(counter).Cells("Qty").Value
                Dim productprice As String = DataGridView_Cart.Rows(counter).Cells("productprice").Value
                success = False
                Try
                    MySQLConn.Open()
                    query = "INSERT INTO transac_table values(@transactionnum, @customername, @productname, @quantity, @productprice, @transactiondate)"
                    comm = New MySqlCommand(query, MySQLConn)
                    comm.Parameters.AddWithValue("transactionnum", Label_TransactionNum.Text)
                    comm.Parameters.AddWithValue("customername", TextBox_CustomerName.Text)
                    comm.Parameters.AddWithValue("productname", productname)
                    comm.Parameters.AddWithValue("quantity", quantity)
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
        Else
            MsgBox("The Cart is empty!", MsgBoxStyle.Exclamation, SystemTitle)

        End If
        If success = True Then
Tender:
            
            PrepareTransactionReceipt()
            CashTender.ShowDialog()
            CurrentTransactionNumber = Label_TransactionNum.Text
            PrintTransaction.ShowDialog()
            MsgBox("The Transaction was successfully saved!", MsgBoxStyle.Information, SystemTitle)
            Button_Reset_Click()
        Else
            MsgBox("There was an error saving the transaction", MsgBoxStyle.Critical, SystemTitle)
        End If
        Button_Reset_Click()
        Cart = 0
        CartPrice = 0
    End Sub

    Public Sub Button_Reset_Click() Handles Button_Reset.Click
        TextBox_CustomerName.Text = ""
        TextBox_quantity.Text = 1
        Label_TransactionNum.Text = Now.ToString("yyyyHHmmss") + "" & TransactionNumber.Next(1, 10000)
        Cart = 0
        Load_Products()
        CartPrice = 0
        DataGridView_Cart.Rows.Clear()
        TextBox_CustomerName.Enabled = True
    End Sub
    Public Sub PrepareTransactionReceipt()
        Try
            '' Add Table
            'ds.Tables.Add("Test")

            '' Add Columns
            'Dim col As DataColumn
            'For Each dgvCol As DataGridViewColumn In DataGridView1.Columns
            '    col = New DataColumn(dgvCol.Name)
            '    ds.Tables("Invoices").Columns.Add(col)
            'Next

            ' Rows from the datagridview
            Dim row As DataRow
            Dim colcount As Integer = DataGridView_Cart.Columns.Count - 1
            For i As Integer = 0 To DataGridView_Cart.Rows.Count - 1
                row = TransactionReceiptDataSet.Tables(2).Rows.Add
                For Each column As DataGridViewColumn In DataGridView_Cart.Columns
                    row.Item(column.Index) = DataGridView_Cart.Rows.Item(i).Cells(column.Index).Value
                Next
            Next

        Catch ex As Exception

            MsgBox("CRITICAL ERROR : Exception caught while converting dataGridView to DataSet (dgvtods).. " & Chr(10) & ex.Message)
        End Try
    End Sub

    Private Sub Button_CancelTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_CancelTransaction.Click
        Button_Reset.PerformClick()
    End Sub
    Public Sub GetTotalStockOnHand()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT productquantity FROM producttable", MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                OneLQuantity = reader.GetString("")
            End While
        Catch ex As Exception

        End Try
    End Sub
End Class
