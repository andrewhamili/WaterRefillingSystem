Imports MySql.Data.MySqlClient
Class Form_LogIn


    Private Sub Button_Go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Go.Click
        MySQLConn.ConnectionString = connstring
        Dim query As String
        Try
            MySQLConn.Open()
            query = "SELECT * FROM logintable where username='" & txtbox_username.Text & "' and password='" & Txtbox_Password.Text & "'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer
            While reader.Read
                count += 1
            End While
            If count > 0 Then
                Form1.Show()
                Me.Hide()
            Else
                MsgBox("Wrong")
            End If
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class


