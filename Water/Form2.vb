Imports MySql.Data.MySqlClient
Class Form_LogIn

    Public attempt As Integer

    Private Sub Button_Go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Go.Click
        MySQLConn.ConnectionString = connstring
        If attempt < 3 Then

            Dim query As String
            Try
                MySQLConn.Open()
                query = "SELECT * FROM logintable where username=@username and password=sha2(@password, 512)"
                comm = New MySqlCommand(query, MySQLConn)
                comm.Parameters.AddWithValue("username", txtbox_username.Text)
                comm.Parameters.AddWithValue("password", Txtbox_Password.Text)
                reader = comm.ExecuteReader
                Dim count As Integer
                While reader.Read
                    activeusername = reader.GetString("username")
                    usertype = reader.GetString("usertype")
                    count += 1
                End While
                If count > 0 Then
                    txtbox_username.Text = ""
                    Txtbox_Password.Text = ""
                    Form_Home.Show()
                    Me.Hide()
                Else
                    MsgBox("Incorrect Username/Password.", MsgBoxStyle.Critical, SystemTitle)
                    attempt += 1
                End If
                MySQLConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            If attempt = 3 Then
                MsgBox("You have reached the maximum attempts allowed to Log-in. System will now exit.", MsgBoxStyle.Critical, SystemTitle)
                Application.ExitThread()
            End If
        End If
        
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Cancel.Click

        End

    End Sub

    Private Sub Form_LogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AcceptButton = Button_Go
        CancelButton = Button_Cancel
    End Sub
End Class


