Imports MySql.Data.MySqlClient
Public Class Control_Employee

    Public dbdataset As New DataTable
    Public changepictureindicator As Boolean = False
    Public UsernameEdit As String

    Private Sub Control_Employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel_EmployeeMain.Show()
        Panel_EmployeeManager.Hide()
        Load_Employees()
    End Sub
    Public Sub Load_Employees()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Dim query As String
        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open()
            query = "SELECT username FROM logintable"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                ListBox_EmployeeList.Items.Remove(reader.GetString("username"))
                ListBox_EmployeeList.Items.Add(reader.GetString("username"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button_ChoosePicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_ChoosePicture.Click
        If OpenFileDialog_ChooseEmployeePicture.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBox_ChooseEmployeePicture.Image = Image.FromFile(OpenFileDialog_ChooseEmployeePicture.FileName)
            changepictureindicator = True
        End If
    End Sub
    Private Sub Button_SaveEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_SaveEmployee.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim mstream As New System.IO.MemoryStream()
        PictureBox_ChooseEmployeePicture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer
        mstream.Close()

        Dim message As String = ""

        If changepictureindicator = False Then
            MsgBox("Please choose a picture!", MsgBoxStyle.Exclamation, SystemTitle)
        Else
            Dim query As String
            If TextBox_LastName.Text = "" Or TextBox_FirstName.Text = "" Or TextBox_FirstName.Text = "" Or TextBox_Address.Text = "" Or TextBox_Email.Text = "" Or TextBox_ContactNum.Text = "" Or TextBox_EmployeePassword.Text = "" Then
                MsgBox("Please fill up all Fields!", MsgBoxStyle.Exclamation, SystemTitle)
            Else
                Try
                    MySQLConn.Open()
                    If EmployeeAction = "edit" Then
                        query = "update logintable set fname=@firstname, mname=@middlename, lname=@lastname, address=@address, contact=@contact, email=@email, password=sha2(@password, 512), usertype=@usertype, image=@image WHERE username=@usernametoedit"
                        comm = New MySqlCommand(query, MySQLConn)
                        comm.Parameters.AddWithValue("lastname", TextBox_LastName.Text)
                        comm.Parameters.AddWithValue("firstname", TextBox_FirstName.Text)
                        comm.Parameters.AddWithValue("middlename", TextBox_MiddleName.Text)
                        comm.Parameters.AddWithValue("address", TextBox_Address.Text)
                        comm.Parameters.AddWithValue("contact", TextBox_ContactNum.Text)
                        comm.Parameters.AddWithValue("email", TextBox_Email.Text)
                        comm.Parameters.AddWithValue("password", TextBox_EmployeePassword.Text)
                        comm.Parameters.AddWithValue("usertype", ComboBox_Usertype.Text)
                        comm.Parameters.AddWithValue("image", arrImage)
                        comm.Parameters.AddWithValue("usernametoedit", UsernameEdit)
                        message = "Updated"
                    Else
                        query = "INSERT INTO logintable values(@firstname, @middlename, @lastname, @address, @contact, @email, @username,   sha2(@password, 512), @usertype, @image)"
                        comm = New MySqlCommand(query, MySQLConn)
                        comm.Parameters.AddWithValue("lastname", TextBox_LastName.Text)
                        comm.Parameters.AddWithValue("firstname", TextBox_FirstName.Text)
                        comm.Parameters.AddWithValue("middlename", TextBox_MiddleName.Text)
                        comm.Parameters.AddWithValue("address", TextBox_Address.Text)
                        comm.Parameters.AddWithValue("contact", TextBox_ContactNum.Text)
                        comm.Parameters.AddWithValue("email", TextBox_Email.Text)
                        comm.Parameters.AddWithValue("password", TextBox_EmployeePassword.Text)
                        comm.Parameters.AddWithValue("usertype", ComboBox_Usertype.Text)
                        comm.Parameters.AddWithValue("username", TextBox_Username.Text)
                        comm.Parameters.AddWithValue("image", arrImage)
                        message = "Registered"
                    End If

                    reader = comm.ExecuteReader
                    MySQLConn.Close()
                    MsgBox(message, MsgBoxStyle.Information, SystemTitle)


                    Panel_EmployeeManager.Hide()
                    Panel_EmployeeMain.Show()
                    Load_Employees()
                    TextBox_Username.Enabled = True
                    changepictureindicator = False


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        End If

    End Sub

    Private Sub Button_CancelEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_CancelEmployee.Click
        TextBox_Username.Enabled = True
        changepictureindicator = False
        Panel_EmployeeManager.Hide()
        Panel_EmployeeMain.Show()
    End Sub

    Private Sub ListBox_EmployeeList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox_EmployeeList.SelectedIndexChanged
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String
        Dim arrImage As Byte()

        Try
            MySQLConn.Open()
            query = "SELECT * FROM logintable WHERE username='" & ListBox_EmployeeList.Text & "'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                Label_EmployeeLastname.Text = reader.GetString("lname")
                Label_EmployeeFirstname.Text = reader.GetString("fname")
                Label_EmployeeMiddleName.Text = reader.GetString("mname")
                Label_EmployeeAddress.Text = reader.GetString("address")
                Label_EmployeeContact.Text = reader.GetString("contact")
                Label_EmployeeEmail.Text = reader.GetString("email")
                Label_EmployeeUsertype.Text = reader.GetString("usertype")
                arrImage = reader.Item("image")
                Dim mstream As New System.IO.MemoryStream(arrImage)
                PictureBox_EmployeePicture.Image = Image.FromStream(mstream)
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button_EditEmployee_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_EditEmployee.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Dim query As String


        If ListBox_EmployeeList.Text = "" Then
            MsgBox("Please select an Employee First!", MsgBoxStyle.Exclamation, SystemTitle)
        Else
            TextBox_LastName.Text = Label_EmployeeLastname.Text
            TextBox_FirstName.Text = Label_EmployeeFirstname.Text
            TextBox_MiddleName.Text = Label_EmployeeMiddleName.Text
            TextBox_Address.Text = Label_EmployeeAddress.Text
            TextBox_Email.Text = Label_EmployeeEmail.Text
            TextBox_ContactNum.Text = Label_EmployeeContact.Text
            TextBox_Username.Text = ListBox_EmployeeList.Text
            PictureBox_ChooseEmployeePicture.Image = PictureBox_EmployeePicture.Image
            Panel_EmployeeManager.Show()
            Panel_EmployeeMain.Hide()
            EmployeeAction = "edit"
            changepictureindicator = True
            TextBox_Username.Enabled = False
            UsernameEdit = ListBox_EmployeeList.Text
            ListBox_EmployeeList.ClearSelected()
        End If
    End Sub

    Private Sub Button_AddEmployee_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_AddEmployee.Click
        TextBox_FirstName.Text = ""
        TextBox_MiddleName.Text = ""
        TextBox_LastName.Text = ""
        TextBox_Address.Text = ""
        TextBox_ContactNum.Text = ""
        TextBox_Email.Text = ""
        TextBox_Username.Text = ""
        PictureBox_ChooseEmployeePicture.Image = My.Resources.male_image
        TextBox_EmployeePassword.Text = ""
        Panel_EmployeeMain.Hide()
        Panel_EmployeeManager.Show()

    End Sub

    Private Sub Button_DeleteEmployee_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button_DeleteEmployee.Click
        If ListBox_EmployeeList.Text = "" Then
            MsgBox("Please select an Employee first!", MsgBoxStyle.Exclamation, SystemTitle)
        Else
            Dim ans As Integer = MsgBox("Are you sure?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, SystemTitle)
            If ans = 6 Then

                If MySQLConn.State = ConnectionState.Open Then
                    MySQLConn.Close()
                End If

                MySQLConn.ConnectionString = connstring
                Dim query As String

                If ListBox_EmployeeList.Text = activeusername Then
                    MsgBox("You cannot delete your account. Use another account with a privilege to delete.", MsgBoxStyle.Exclamation, SystemTitle)
                Else
                    Try
                        MySQLConn.Open()
                        query = "DELETE FROM logintable WHERE username=@username"
                        comm = New MySqlCommand(query, MySQLConn)
                        comm.Parameters.AddWithValue("username", ListBox_EmployeeList.Text)
                        reader = comm.ExecuteReader
                        MySQLConn.Close()
                        MsgBox("Successfully deleted " & ListBox_EmployeeList.Text & ".", MsgBoxStyle.Information, SystemTitle)
                        ListBox_EmployeeList.ClearSelected()
                        ListBox_EmployeeList.Items.Clear()
                        Load_Employees()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
            End If

    End Sub
End Class
