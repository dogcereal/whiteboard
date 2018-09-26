Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ExitBttn_Click(sender As Object, e As EventArgs) Handles ExitBttn.Click
        Me.Close()
    End Sub

    Private Sub LoginBttn_Click(sender As Object, e As EventArgs) Handles LoginBttn.Click
        If (Usr.Text = "student" And Psswrd.Text = "password") Then
            Student.Show()
            Me.Hide()
            Usr.Clear()
            Psswrd.Clear()
            Usr.Select()

        ElseIf (Usr.Text = "professor" And Psswrd.Text = "password") Then
            Professor.Show()
            Me.Hide()
            Usr.Clear()
            Psswrd.Clear()
            Usr.Select()

        Else
            MessageBox.Show("Invalid Username or Password")
        End If
    End Sub

    Private Sub Usr_TextChanged(sender As Object, e As EventArgs) Handles Usr.TextChanged
        Usr.Focus()
    End Sub

    Private Sub Psswrd_TextChanged(sender As Object, e As EventArgs) Handles Psswrd.TextChanged
        Me.AcceptButton = LoginBttn
        LoginBttn.DialogResult = System.Windows.Forms.DialogResult.OK

    End Sub
End Class
