<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseInfo
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PageTitle = New System.Windows.Forms.Label()
        Me.Tools = New System.Windows.Forms.Label()
        Me.CoursesLink = New System.Windows.Forms.Label()
        Me.GradesLink = New System.Windows.Forms.Label()
        Me.AnnouncementTitle = New System.Windows.Forms.Label()
        Me.Announcement1 = New System.Windows.Forms.Label()
        Me.ContentTitle = New System.Windows.Forms.Label()
        Me.AssListLink = New System.Windows.Forms.Label()
        Me.GradedAssLink = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(690, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PageTitle
        '
        Me.PageTitle.AutoSize = True
        Me.PageTitle.BackColor = System.Drawing.Color.Transparent
        Me.PageTitle.Font = New System.Drawing.Font("Yu Gothic Light", 22.0!, System.Drawing.FontStyle.Italic)
        Me.PageTitle.ForeColor = System.Drawing.SystemColors.Highlight
        Me.PageTitle.Location = New System.Drawing.Point(12, 19)
        Me.PageTitle.Name = "PageTitle"
        Me.PageTitle.Size = New System.Drawing.Size(444, 39)
        Me.PageTitle.TabIndex = 2
        Me.PageTitle.Text = "WhiteBoard - Course Information"
        '
        'Tools
        '
        Me.Tools.AutoSize = True
        Me.Tools.BackColor = System.Drawing.Color.Transparent
        Me.Tools.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tools.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Tools.Location = New System.Drawing.Point(37, 106)
        Me.Tools.Name = "Tools"
        Me.Tools.Size = New System.Drawing.Size(84, 39)
        Me.Tools.TabIndex = 3
        Me.Tools.Text = "Tools"
        '
        'CoursesLink
        '
        Me.CoursesLink.AutoSize = True
        Me.CoursesLink.BackColor = System.Drawing.Color.Transparent
        Me.CoursesLink.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoursesLink.ForeColor = System.Drawing.SystemColors.Highlight
        Me.CoursesLink.Location = New System.Drawing.Point(39, 172)
        Me.CoursesLink.Name = "CoursesLink"
        Me.CoursesLink.Size = New System.Drawing.Size(111, 26)
        Me.CoursesLink.TabIndex = 4
        Me.CoursesLink.Text = "My Courses"
        '
        'GradesLink
        '
        Me.GradesLink.AutoSize = True
        Me.GradesLink.BackColor = System.Drawing.Color.Transparent
        Me.GradesLink.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradesLink.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GradesLink.Location = New System.Drawing.Point(39, 209)
        Me.GradesLink.Name = "GradesLink"
        Me.GradesLink.Size = New System.Drawing.Size(104, 26)
        Me.GradesLink.TabIndex = 5
        Me.GradesLink.Text = "My Grades"
        '
        'AnnouncementTitle
        '
        Me.AnnouncementTitle.AutoSize = True
        Me.AnnouncementTitle.BackColor = System.Drawing.Color.Transparent
        Me.AnnouncementTitle.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnnouncementTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AnnouncementTitle.Location = New System.Drawing.Point(205, 116)
        Me.AnnouncementTitle.Name = "AnnouncementTitle"
        Me.AnnouncementTitle.Size = New System.Drawing.Size(234, 39)
        Me.AnnouncementTitle.TabIndex = 6
        Me.AnnouncementTitle.Text = "Announcements"
        '
        'Announcement1
        '
        Me.Announcement1.AutoSize = True
        Me.Announcement1.BackColor = System.Drawing.Color.Transparent
        Me.Announcement1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Announcement1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Announcement1.Location = New System.Drawing.Point(225, 172)
        Me.Announcement1.Name = "Announcement1"
        Me.Announcement1.Size = New System.Drawing.Size(187, 26)
        Me.Announcement1.TabIndex = 7
        Me.Announcement1.Text = "Classroom change!!!"
        '
        'ContentTitle
        '
        Me.ContentTitle.AutoSize = True
        Me.ContentTitle.BackColor = System.Drawing.Color.Transparent
        Me.ContentTitle.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ContentTitle.Location = New System.Drawing.Point(205, 229)
        Me.ContentTitle.Name = "ContentTitle"
        Me.ContentTitle.Size = New System.Drawing.Size(220, 39)
        Me.ContentTitle.TabIndex = 8
        Me.ContentTitle.Text = "Course Content"
        '
        'AssListLink
        '
        Me.AssListLink.AutoSize = True
        Me.AssListLink.BackColor = System.Drawing.Color.Transparent
        Me.AssListLink.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssListLink.ForeColor = System.Drawing.SystemColors.Highlight
        Me.AssListLink.Location = New System.Drawing.Point(225, 287)
        Me.AssListLink.Name = "AssListLink"
        Me.AssListLink.Size = New System.Drawing.Size(153, 26)
        Me.AssListLink.TabIndex = 9
        Me.AssListLink.Text = "Assignments List"
        '
        'GradedAssLink
        '
        Me.GradedAssLink.AutoSize = True
        Me.GradedAssLink.BackColor = System.Drawing.Color.Transparent
        Me.GradedAssLink.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradedAssLink.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GradedAssLink.Location = New System.Drawing.Point(225, 333)
        Me.GradedAssLink.Name = "GradedAssLink"
        Me.GradedAssLink.Size = New System.Drawing.Size(186, 26)
        Me.GradedAssLink.TabIndex = 10
        Me.GradedAssLink.Text = "Graded Assignments"
        '
        'CourseInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.BackgroundImage = Global.Whiteboard.My.Resources.Resources.Student_BG
        Me.ClientSize = New System.Drawing.Size(807, 504)
        Me.Controls.Add(Me.GradedAssLink)
        Me.Controls.Add(Me.AssListLink)
        Me.Controls.Add(Me.ContentTitle)
        Me.Controls.Add(Me.Announcement1)
        Me.Controls.Add(Me.AnnouncementTitle)
        Me.Controls.Add(Me.GradesLink)
        Me.Controls.Add(Me.CoursesLink)
        Me.Controls.Add(Me.Tools)
        Me.Controls.Add(Me.PageTitle)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.Name = "CourseInfo"
        Me.Text = "Course Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents PageTitle As Label
    Friend WithEvents Tools As Label
    Friend WithEvents CoursesLink As Label
    Friend WithEvents GradesLink As Label
    Friend WithEvents AnnouncementTitle As Label
    Friend WithEvents Announcement1 As Label
    Friend WithEvents ContentTitle As Label
    Friend WithEvents AssListLink As Label
    Friend WithEvents GradedAssLink As Label
End Class
