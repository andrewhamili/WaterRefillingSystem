﻿Imports MySql.Data.MySqlClient
Module GlobalVariableModule
    Public MySQLConn As New MySqlConnection
    Public connstring As String = "server=localhost;username=root;password=root;database=final"
    Public comm As New MySqlCommand
    Public reader As MySqlDataReader

End Module
