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
        Me.courseTab = New System.Windows.Forms.TabPage()
        Me.gradeTab = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
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
        Me.tabControl1.Location = New System.Drawing.Point(1, 40)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(436, 458)
        Me.tabControl1.TabIndex = 0
        '
        'homeTab
        '
        Me.homeTab.Controls.Add(Me.Label3)
        Me.homeTab.Location = New System.Drawing.Point(4, 22)
        Me.homeTab.Name = "homeTab"
        Me.homeTab.Padding = New System.Windows.Forms.Padding(3)
        Me.homeTab.Size = New System.Drawing.Size(428, 432)
        Me.homeTab.TabIndex = 0
        Me.homeTab.Text = "Home"
        Me.homeTab.UseVisualStyleBackColor = True
        '
        'courseTab
        '
        Me.courseTab.Controls.Add(Me.Label2)
        Me.courseTab.Controls.Add(Me.ComboBox1)
        Me.courseTab.Location = New System.Drawing.Point(4, 22)
        Me.courseTab.Name = "courseTab"
        Me.courseTab.Padding = New System.Windows.Forms.Padding(3)
        Me.courseTab.Size = New System.Drawing.Size(428, 432)
        Me.courseTab.TabIndex = 1
        Me.courseTab.Text = "Courses"
        Me.courseTab.UseVisualStyleBackColor = True
        '
        'gradeTab
        '
        Me.gradeTab.Controls.Add(Me.ComboBox2)
        Me.gradeTab.Controls.Add(Me.Label4)
        Me.gradeTab.Location = New System.Drawing.Point(4, 22)
        Me.gradeTab.Name = "gradeTab"
        Me.gradeTab.Padding = New System.Windows.Forms.Padding(3)
        Me.gradeTab.Size = New System.Drawing.Size(428, 432)
        Me.gradeTab.TabIndex = 2
        Me.gradeTab.Text = "Grades"
        Me.gradeTab.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(355, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WhiteBoard"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(7, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "Select Course"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "My Courses"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 33)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Announcements"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 33)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "My Grades"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(7, 48)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 1
        Me.ComboBox2.Text = "Select Course"
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 425)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tabControl1)
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
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
End Class
