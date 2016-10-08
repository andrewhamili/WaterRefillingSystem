Imports MySql.Data.MySqlClient

Public Class UserControl_Maintenance




    Private Sub UserControl_Maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Products()
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
End Class
