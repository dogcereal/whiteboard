<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.homeTab = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.courseTab = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gradeTab = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDisplayUserInfo = New System.Windows.Forms.Label()
        Me.currentUser = New System.Windows.Forms.Label()
        Me.name_id = New System.Windows.Forms.Label()
        Me.tabControl1.SuspendLayout()
        Me.homeTab.SuspendLayout()
        Me.courseTab.SuspendLayout()
        Me.gradeTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.AccessibleName = ""
        Me.tabControl1.Controls.Add(Me.homeTab)
        Me.tabControl1.Controls.Add(Me.courseTab)
        Me.tabControl1.Controls.Add(Me.gradeTab)
        Me.tabControl1.Location = New System.Drawing.Point(2, 62)
        Me.tabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(1208, 714)
        Me.tabControl1.TabIndex = 0
        '
        'homeTab
        '
        Me.homeTab.BackgroundImage = Global.Whiteboard.My.Resources.Resources.inBox_BG
        Me.homeTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.homeTab.Controls.Add(Me.Label3)
        Me.homeTab.Location = New System.Drawing.Point(4, 29)
        Me.homeTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.homeTab.Name = "homeTab"
        Me.homeTab.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.homeTab.Size = New System.Drawing.Size(1200, 681)
        Me.homeTab.TabIndex = 0
        Me.homeTab.Text = "Home"
        Me.homeTab.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(309, 46)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Announcements"
        '
        'courseTab
        '
        Me.courseTab.BackgroundImage = Global.Whiteboard.My.Resources.Resources.inBox_BG
        Me.courseTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.courseTab.Controls.Add(Me.Label2)
        Me.courseTab.Location = New System.Drawing.Point(4, 29)
        Me.courseTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.courseTab.Name = "courseTab"
        Me.courseTab.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.courseTab.Size = New System.Drawing.Size(1200, 681)
        Me.courseTab.TabIndex = 1
        Me.courseTab.Text = "Courses"
        Me.courseTab.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 46)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "My Courses"
        '
        'gradeTab
        '
        Me.gradeTab.BackgroundImage = Global.Whiteboard.My.Resources.Resources.inBox_BG
        Me.gradeTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gradeTab.Controls.Add(Me.Button2)
        Me.gradeTab.Controls.Add(Me.Label4)
        Me.gradeTab.Location = New System.Drawing.Point(4, 29)
        Me.gradeTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gradeTab.Name = "gradeTab"
        Me.gradeTab.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gradeTab.Size = New System.Drawing.Size(1200, 681)
        Me.gradeTab.TabIndex = 2
        Me.gradeTab.Text = "Grades"
        Me.gradeTab.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 626)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 35)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Calculate GPA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 46)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "My Grades"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1066, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WhiteBoard"
        '
        'lblDisplayUserInfo
        '
        Me.lblDisplayUserInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayUserInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayUserInfo.Location = New System.Drawing.Point(272, 16)
        Me.lblDisplayUserInfo.Name = "lblDisplayUserInfo"
        Me.lblDisplayUserInfo.Size = New System.Drawing.Size(177, 41)
        Me.lblDisplayUserInfo.TabIndex = 2
        Me.lblDisplayUserInfo.Text = "user info here"
        Me.lblDisplayUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'currentUser
        '
        Me.currentUser.BackColor = System.Drawing.Color.Transparent
        Me.currentUser.Location = New System.Drawing.Point(203, 16)
        Me.currentUser.Name = "currentUser"
        Me.currentUser.Size = New System.Drawing.Size(74, 41)
        Me.currentUser.TabIndex = 3
        Me.currentUser.Text = "User:"
        Me.currentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'name_id
        '
        Me.name_id.BackColor = System.Drawing.Color.Transparent
        Me.name_id.Location = New System.Drawing.Point(439, 9)
        Me.name_id.Name = "name_id"
        Me.name_id.Size = New System.Drawing.Size(585, 62)
        Me.name_id.TabIndex = 4
        Me.name_id.Text = "Label5"
        Me.name_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Whiteboard.My.Resources.Resources.login_BG
        Me.ClientSize = New System.Drawing.Size(1210, 775)
        Me.Controls.Add(Me.name_id)
        Me.Controls.Add(Me.currentUser)
        Me.Controls.Add(Me.lblDisplayUserInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Student"
        Me.Text = "Form2"
        Me.tabControl1.ResumeLayout(False)
        Me.homeTab.ResumeLayout(False)
        Me.homeTab.PerformLayout()
        Me.courseTab.ResumeLayout(False)
        Me.courseTab.PerformLayout()
        Me.gradeTab.ResumeLayout(False)
        Me.gradeTab.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tabControl1 As TabControl
    Friend WithEvents homeTab As TabPage
    Friend WithEvents courseTab As TabPage
    Friend WithEvents gradeTab As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Public WithEvents lblDisplayUserInfo As Label
    Friend WithEvents currentUser As Label
    Friend WithEvents name_id As Label
End Class
