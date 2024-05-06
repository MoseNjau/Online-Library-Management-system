Imports MySql.Data.MySqlClient

Public Class SignUpForm

    Private connectionString As String = "server=localhost;user=root;password=;database=dblibrary;"

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim loginForm As New LoginForm1()
        loginForm.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Username As String = UsernameTextBox.Text
        Dim Email As String = EmailTextBox.Text
        Dim Password As String = PasswordTextBox.Text
        Dim confirmPassword As String = ConfirmPasswordTextBox.Text

        If String.IsNullOrWhiteSpace(Username) OrElse String.IsNullOrWhiteSpace(Email) OrElse String.IsNullOrWhiteSpace(Password) OrElse String.IsNullOrWhiteSpace(confirmPassword) Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Password <> confirmPassword Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Insert user data into database
        Try
            Using connection As New MySqlConnection(connectionString)
                Dim query As String = "INSERT INTO tbluser (Username, Email, Password) VALUES (@Username, @Email, @Password)"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", Username)
                    command.Parameters.AddWithValue("@Email", Email)
                    command.Parameters.AddWithValue("@Password", Password) ' Store password without hashing
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Clear text boxes after successful sign up
                        UsernameTextBox.Clear()
                        EmailTextBox.Clear()
                        PasswordTextBox.Clear()
                        ConfirmPasswordTextBox.Clear()
                    Else
                        MessageBox.Show("Sign up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while signing up: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class
