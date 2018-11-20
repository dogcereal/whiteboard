Imports System.IO
Imports System.Data.SQLite

Public Class Login
    Public db As New DBConnection

    Private Sub LoginBttn_Click(sender As Object, e As EventArgs) Handles LoginBttn.Click
        If IsAuthenticated(Usr.Text.Trim, Psswrd.Text.Trim) Then
            Student.Show()
            Me.Hide()
            Usr.Clear()
            Psswrd.Clear()
            Usr.Select()

        Else
            MsgBox("Incorrect username/password")
        End If

    End Sub

    Private Function IsAuthenticated(username As String, password As String) As Boolean
        Dim IsValidUser As Boolean = False
        Dim userInfo As DataRow = Nothing
        Dim query As String = "SELECT * FROM student WHERE sUsername = @username"

        Try
            Using conn As New SQLiteConnection(db.connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.CommandText = query
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            userInfo = dt.Rows(0)
                            If userInfo("sPass").Equals(password) Then
                                IsValidUser = True
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return IsValidUser
    End Function


    Private Sub Usr_TextChanged(sender As Object, e As EventArgs) Handles Usr.TextChanged
        Usr.Focus()
    End Sub

    Private Sub Psswrd_TextChanged(sender As Object, e As EventArgs) Handles Psswrd.TextChanged
        Me.AcceptButton = LoginBttn
        LoginBttn.DialogResult = System.Windows.Forms.DialogResult.OK

    End Sub

    Private Sub ExitBttn_Click(sender As Object, e As EventArgs) Handles ExitBttn.Click
        adminLogin.Show()
        Me.Hide()
    End Sub
End Class
