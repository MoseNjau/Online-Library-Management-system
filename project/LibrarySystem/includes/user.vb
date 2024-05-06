Imports MySql.Data.MySqlClient

Module user
    Public con As MySqlConnection = mysqldb()

    Public Sub visibleMenu()
        With Form1
            .btnBooks.Enabled = True
            .btnBorrower.Enabled = False
            .btnUser.Enabled = False
            .btnCategories.Enabled = False
            .btnLogs.Enabled = False
            .btnBorrow.Enabled = False
            .btnOverdue.Enabled = False
            .btnReports.Enabled = False
            .btnReturn.Enabled = False
            .tsLogin.Image = Bitmap.FromFile(Application.StartupPath & "/Logo/lock.jpg")
        End With
    End Sub

    Public Sub Login(ByVal username As String, ByVal password As String)
        Try
            con.Open()

            ' Using parameterized query to prevent SQL injection
            Dim query As String = "SELECT * FROM `tbluser` WHERE Username = @Username AND Password = @Password"
            Dim command As New MySqlCommand(query, con)
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@Password", password)

            ' Execute the query
            Using reader As MySqlDataReader = command.ExecuteReader()
                ' Check if the user exists
                If reader.Read() Then
                    Dim userRole As String = reader("UserRole").ToString()

                    ' Enable buttons and set login status based on user role
                    With Form1
                        .btnBooks.Enabled = True
                        .btnBorrower.Enabled = True
                        .btnCategories.Enabled = True
                        .btnLogs.Enabled = True
                        .btnBorrow.Enabled = True
                        .btnOverdue.Enabled = True
                        .btnReports.Enabled = True
                        .btnReturn.Enabled = True
                        .btnUser.Enabled = True
                        .tsLogin.Text = "Logout"
                        .tsLogin.Image = Bitmap.FromFile(Application.StartupPath & "/Logo/unlock.jpg")
                    End With

                    ' Close the login form
                    LoginForm1.Close()
                    Form1.SignUpButton.Visible = False
                    Form1.Guna2Button1.Visible = False

                    ' Set user information in the main form
                    Form1.UserIdToolStripStatus.Text = reader("UserId").ToString()
                    Form1.UserToolStripStatus.Text = username
                    Form1.StatusStrip1.Visible = True

                    ' Insert login log
                    Dim sql As String = "INSERT INTO `tbllogs` (`UserId`, `LogDate`, `LogMode`) VALUES (@UserId, Now(), 'Logged in')"
                    Using logCommand As New MySqlCommand(sql, con)
                        logCommand.Parameters.AddWithValue("@UserId", reader("UserId").ToString())
                        logCommand.ExecuteNonQuery()
                    End Using
                Else
                    MsgBox("Account does not exist!", MsgBoxStyle.Information)
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred while logging in: " & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub append(ByVal sql As String, ByVal field As String, ByVal txt As Object)
        reloadtxt(sql)
        Try
            Dim r As DataRow
            txt.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txt.AutoCompleteCustomSource.Add(r.Item(field).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
