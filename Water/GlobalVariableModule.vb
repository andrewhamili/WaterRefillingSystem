Imports MySql.Data.MySqlClient
Module GlobalVariableModule

    'MySQL variables
    Public MySQLConn As New MySqlConnection
    Public connstring As String = "server=localhost;username=root;password=root;database=final"
    Public comm As New MySqlCommand
    Public reader As MySqlDataReader

    'System variables
    Public SystemTitle As String = "Water Refilling Station"
    Public LoggedInName As String
    Public activeusername As String
    Public usertype As String

    Public EmployeeAction As String


    Public Cart As Integer = 0
    Public CartPrice As Integer
    Public DeliveryPrice As Integer

    Public CurrentTransactionNumber As String
    Public TransactionReceiptDataSet As New DataSet1
    Public CashTendered As Double

End Module


