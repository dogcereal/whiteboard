<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Usr = New System.Windows.Forms.TextBox()
        Me.Psswrd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LoginBttn = New System.Windows.Forms.Button()
        Me.ExitBttn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 50.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(278, 122)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(603, 135)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WhiteBoard"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(404, 312)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username :"
        '
        'Usr
        '
        Me.Usr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Usr.Location = New System.Drawing.Point(393, 365)
        Me.Usr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Usr.Name = "Usr"
        Me.Usr.Size = New System.Drawing.Size(382, 35)
        Me.Usr.TabIndex = 3
        '
        'Psswrd
        '
        Me.Psswrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Psswrd.Location = New System.Drawing.Point(393, 489)
        Me.Psswrd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Psswrd.Name = "Psswrd"
        Me.Psswrd.Size = New System.Drawing.Size(382, 35)
        Me.Psswrd.TabIndex = 4
        Me.Psswrd.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(404, 437)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password :"
        '
        'LoginBttn
        '
        Me.LoginBttn.Location = New System.Drawing.Point(423, 575)
        Me.LoginBttn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LoginBttn.Name = "LoginBttn"
        Me.LoginBttn.Size = New System.Drawing.Size(150, 71)
        Me.LoginBttn.TabIndex = 5
        Me.LoginBttn.Text = "Login"
        Me.LoginBttn.UseVisualStyleBackColor = True
        '
        'ExitBttn
        '
        Me.ExitBttn.Location = New System.Drawing.Point(597, 575)
        Me.ExitBttn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ExitBttn.Name = "ExitBttn"
        Me.ExitBttn.Size = New System.Drawing.Size(150, 71)
        Me.ExitBttn.TabIndex = 6
        Me.ExitBttn.Text = "Register"
        Me.ExitBttn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(620, 551)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "New Student?"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.BackgroundImage = Global.Whiteboard.My.Resources.Resources.login_BG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1210, 775)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ExitBttn)
        Me.Controls.Add(Me.LoginBttn)
        Me.Controls.Add(Me.Psswrd)
        Me.Controls.Add(Me.Usr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Usr As TextBox
    Friend WithEvents Psswrd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LoginBttn As Button
    Friend WithEvents ExitBttn As Button
    Friend WithEvents Label4 As Label
End Class
