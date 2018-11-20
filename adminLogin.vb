Imports System.Data.SQLite
Imports System.IO

Public Class adminLogin
    Private db As New DBConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsAuthenticated(adminUser.Text.Trim, adminPass.Text.Trim) Then
            Admin.Show()
            Me.Hide()
            adminUser.Clear()
            adminPass.Clear()
            adminUser.Select()
        Else
            MsgBox("Incorrect username/password")
        End If
    End Sub

    Private Function IsAuthenticated(username As String, password As String) As Boolean
        Dim IsValidUser As Boolean = False
        Dim userInfo As DataRow = Nothing
        Dim query As String = "SELECT * FROM admin WHERE adUser = @username"

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
                            If userInfo("adPass").Equals(password) Then
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class