Imports System.IO
Imports System.Data.SQLite
Imports System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder

Public Class Student
    Private db As New DBConnection
    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDisplayUserInfo.Text = Login.Usr.Text()
        If db.HasConnection() Then
            If db.SQLDS IsNot Nothing Then
                db.SQLDS.Clear()
            End If
            db.RunQuery("SELECT sName AS name, studentId AS id FROM student WHERE sUsername='" & Login.Usr.Text & "' ")
            name_id.Text = String.Format("Student Name: " & CType(db.SQLDS.Tables(0).Rows(0).Item("name"), String) & "     ID: " & CType(db.SQLDS.Tables(0).Rows(0).Item("id"), String))
        End If
        Dim i As Integer
        Dim label As LinkLabel
        Dim x As Integer = 14
        Dim y As Integer = 50
        Dim tp As TabPage = tabControl1.TabPages(1)
        If db.HasConnection() Then
            If db.SQLDS IsNot Nothing Then
                db.SQLDS.Clear()
            End If
            db.RunQuery("SELECT c.courseSubj AS Subject, c.courseNum AS CourseNum, r.className AS ClassName, t.tName AS Professor
                        FROM course c, classRoom r, teacher t, classroom_student u, student s
                        WHERE c.courseId=r.course_id AND t.teacherId=r.teacher_id AND s.studentId=u.student_id AND u.classroom_id=r.classId AND s.sUsername='" & Login.Usr.Text & "' ")
            For i = 0 To db.SQLDS.Tables(0).Rows.Count - 1
                y += 50
                label = New LinkLabel
                label.Name = "linklabel" & i
                label.Location = New Point(x, y)
                label.Size = New Size(700, 40)
                label.Font = New Font("Microsoft Sans Serif", 14)
                label.Text = String.Format(CType(db.SQLDS.Tables(0).Rows(i).Item("Subject"), String) & " " & CType(db.SQLDS.Tables(0).Rows(i).Item("CourseNum"), String) & " " & CType(db.SQLDS.Tables(0).Rows(i).Item("ClassName"), String) & ": " & CType(db.SQLDS.Tables(0).Rows(i).Item("Professor"), String))
                tp.Controls.Add(label)
                AddHandler label.LinkClicked, AddressOf label_LinckClicked
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Login.Show()

    End Sub

    Private Sub courseTab_Click(sender As Object, e As EventArgs) Handles courseTab.Click
        'If db.HasConnection() Then
        '    If db.SQLDS IsNot Nothing Then
        '        db.SQLDS.Clear()
        '    End If
        '    db.RunQuery("SELECT c.courseSubj AS Subject, c.courseNum AS CourseNum, r.className AS ClassName, t.tName AS Professor
        '                FROM course c, classRoom r, teacher t, classroom_student u, student s
        '                WHERE c.courseId=r.course_id AND t.teacherId=r.teacher_id AND s.studentId=u.student_id AND u.classroom_id=r.classId AND s.sUsername='" & Login.Usr.Text & "' ")
        '    courses.Text = String.Format("Subject: " & CType(db.SQLDS.Tables(0).Rows(0).Item("Subject"), String) & "Course Number: " & CType(db.SQLDS.Tables(0).Rows(0).Item("CourseNum"), String) & "Class Name: " & CType(db.SQLDS.Tables(0).Rows(0).Item("ClassName"), String) & "Professor: " & CType(db.SQLDS.Tables(0).Rows(0).Item("Professor"), String))
        'End If

    End Sub



    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblDisplayUserInfo.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


    Public Sub label_LinckClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Form5.Show()
        Me.Hide()
    End Sub
End Class