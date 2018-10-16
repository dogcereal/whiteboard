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
        Me.PageTitle = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tools = New System.Windows.Forms.Label()
        Me.CoursesLink = New System.Windows.Forms.Label()
        Me.GradesLink = New System.Windows.Forms.Label()
        Me.SemesterTitle = New System.Windows.Forms.Label()
        Me.Course1 = New System.Windows.Forms.Label()
        Me.Course2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PageTitle
        '
        Me.PageTitle.AutoSize = True
        Me.PageTitle.BackColor = System.Drawing.Color.Transparent
        Me.PageTitle.Font = New System.Drawing.Font("Yu Gothic Light", 22.0!, System.Drawing.FontStyle.Italic)
        Me.PageTitle.ForeColor = System.Drawing.SystemColors.Highlight
        Me.PageTitle.Location = New System.Drawing.Point(12, 19)
        Me.PageTitle.Name = "PageTitle"
        Me.PageTitle.Size = New System.Drawing.Size(351, 39)
        Me.PageTitle.TabIndex = 0
        Me.PageTitle.Text = "WhiteBoard - My Courses"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(690, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.Tools.TabIndex = 2
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
        Me.CoursesLink.TabIndex = 3
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
        Me.GradesLink.TabIndex = 4
        Me.GradesLink.Text = "My Grades"
        '
        'SemesterTitle
        '
        Me.SemesterTitle.AutoSize = True
        Me.SemesterTitle.BackColor = System.Drawing.Color.Transparent
        Me.SemesterTitle.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SemesterTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SemesterTitle.Location = New System.Drawing.Point(205, 116)
        Me.SemesterTitle.Name = "SemesterTitle"
        Me.SemesterTitle.Size = New System.Drawing.Size(131, 39)
        Me.SemesterTitle.TabIndex = 5
        Me.SemesterTitle.Text = "Fall 2018"
        '
        'Course1
        '
        Me.Course1.AutoSize = True
        Me.Course1.BackColor = System.Drawing.Color.Transparent
        Me.Course1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Course1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Course1.Location = New System.Drawing.Point(225, 172)
        Me.Course1.Name = "Course1"
        Me.Course1.Size = New System.Drawing.Size(433, 26)
        Me.Course1.TabIndex = 6
        Me.Course1.Text = "MATH 3301 - Peters, G [Mo/We 2:30PM-3:45PM]"
        '
        'Course2
        '
        Me.Course2.AutoSize = True
        Me.Course2.BackColor = System.Drawing.Color.Transparent
        Me.Course2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Course2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Course2.Location = New System.Drawing.Point(225, 220)
        Me.Course2.Name = "Course2"
        Me.Course2.Size = New System.Drawing.Size(459, 26)
        Me.Course2.TabIndex = 7
        Me.Course2.Text = "TCOM 3302 - Harrison, M [Mo/We 4:00PM-5:15PM]"
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.BackgroundImage = Global.Whiteboard.My.Resources.Resources.Student_BG
        Me.ClientSize = New System.Drawing.Size(807, 504)
        Me.Controls.Add(Me.Course2)
        Me.Controls.Add(Me.Course1)
        Me.Controls.Add(Me.SemesterTitle)
        Me.Controls.Add(Me.GradesLink)
        Me.Controls.Add(Me.CoursesLink)
        Me.Controls.Add(Me.Tools)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PageTitle)
        Me.MaximizeBox = False
        Me.Name = "Student"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "My Courses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PageTitle As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Tools As Label
    Friend WithEvents CoursesLink As Label
    Friend WithEvents GradesLink As Label
    Friend WithEvents SemesterTitle As Label
    Friend WithEvents Course1 As Label
    Friend WithEvents Course2 As Label
End Class
