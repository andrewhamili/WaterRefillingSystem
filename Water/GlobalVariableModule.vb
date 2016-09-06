Imports MySql.Data.MySqlClient
Module GlobalVariableModule

    'MySQL variables
    Public MySQLConn As New MySqlConnection
    Public connstring As String = "server=localhost;username=root;password=root;database=final"
    Public comm As New MySqlCommand
    Public reader As MySqlDataReader

    'System variables
    Public SystemTitle As String = "Water Refilling Station"
    Public activeusername As String
    Public usertype As String
    '

End Module
