Imports Microsoft.VisualBasic.FileSystem
Public Class frmLogin
    Dim Username As String 'Makes Username something that can store information
    Dim Password As String 'Makes Password something that can store information
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Username = txtUsername.Text 'Stores the inputted information from the Username textbox on the form in the Username string
        Password = txtPassword.Text 'Stores the inputted information from the Password textbox on the form in the Password string
        FileOpen(1, "UserInfo.txt", OpenMode.Output) 'Opens a file that allows for the Username and Password to be written inside
        WriteLine(1, Username) 'Putting the Username into the file
        WriteLine(1, Password) 'Putting the Password into the file
        FileClose(1)
        txtUsername.Text = "" 'Once registration is complete, the Username is removed from the textbox
        txtPassword.Text = "" 'Once registration is complete, the Password is removed from the textbox
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        FileOpen(1, "UserInfo.txt", OpenMode.Input) 'Opens the file allowing for the registered information to be used
        Input(1, Username) 'Reads what the Username is
        Input(1, Password) 'Reads what the Password is
        FileClose(1)
        If txtUsername.Text = "" Or txtPassword.Text = "" Then 'Checks if the Username or Password are filled
            MessageBox.Show("Missing Username/Password") 'If either Username or Password are not filled then a message is shown to inform the user of such
        ElseIf txtUsername.Text <> Username Or txtPassword.Text <> Password Then 'Checks if the Username or Passoword are what was stored in the registration file
            MessageBox.Show("Incorrect Username/Password") 'If either Username or Password are not correct then a message is shown to inform the user of such
        End If

        If txtUsername.Text = Username And txtPassword.Text = Password Then 'Checks if the Username and Password are correct
            Form1.Show() 'If both Username and Password are correct then a Form is opened
        End If
        txtUsername.Text = "" 'Once registration is complete, the Username is removed from the textbox
        txtPassword.Text = "" 'Once registration is complete, the Password is removed from the textbox
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Cancel.Show()
        Me.Close()
    End Sub
End Class
