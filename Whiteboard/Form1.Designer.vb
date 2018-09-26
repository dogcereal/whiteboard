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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(474, 80)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WHITEBOARD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(233, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username :"
        '
        'Usr
        '
        Me.Usr.Location = New System.Drawing.Point(320, 126)
        Me.Usr.Name = "Usr"
        Me.Usr.Size = New System.Drawing.Size(100, 20)
        Me.Usr.TabIndex = 3
        '
        'Psswrd
        '
        Me.Psswrd.Location = New System.Drawing.Point(320, 165)
        Me.Psswrd.Name = "Psswrd"
        Me.Psswrd.Size = New System.Drawing.Size(100, 20)
        Me.Psswrd.TabIndex = 4
        Me.Psswrd.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(237, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password :"
        '
        'LoginBttn
        '
        Me.LoginBttn.Location = New System.Drawing.Point(261, 207)
        Me.LoginBttn.Name = "LoginBttn"
        Me.LoginBttn.Size = New System.Drawing.Size(100, 46)
        Me.LoginBttn.TabIndex = 5
        Me.LoginBttn.Text = "Login"
        Me.LoginBttn.UseVisualStyleBackColor = True
        '
        'ExitBttn
        '
        Me.ExitBttn.Location = New System.Drawing.Point(376, 207)
        Me.ExitBttn.Name = "ExitBttn"
        Me.ExitBttn.Size = New System.Drawing.Size(100, 46)
        Me.ExitBttn.TabIndex = 6
        Me.ExitBttn.Text = "Exit"
        Me.ExitBttn.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(699, 274)
        Me.Controls.Add(Me.ExitBttn)
        Me.Controls.Add(Me.LoginBttn)
        Me.Controls.Add(Me.Psswrd)
        Me.Controls.Add(Me.Usr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
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
End Class
