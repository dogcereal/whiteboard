Imports System.IO
Imports System.Data.SQLite
Imports System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder

Public Class Student
    Public classId As String = Nothing
    Dim MyLabel() As LinkLabel
    Dim MyLabels() As Label
    Private db As New DBConnection
    Public studentId As Integer = Nothing
    Public Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDisplayUserInfo.Text = Login.Usr.Text()
        If db.HasConnection() Then
            If db.SQLDS IsNot Nothing Then
                db.SQLDS.Clear()
            End If
            db.RunQuery("SELECT sName AS name, studentId AS id FROM student WHERE sUsername='" & Login.Usr.Text & "' ")
            name_id.Text = String.Format("Student Name: " & CType(db.SQLDS.Tables(0).Rows(0).Item("name"), String) & "     ID: " & CType(db.SQLDS.Tables(0).Rows(0).Item("id"), String))
            studentId = CType(db.SQLDS.Tables(0).Rows(0).Item("id"), Integer)
        End If
        Announcements()
        GradeForClass()
        DynamicLabels()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Login.Show()

    End Sub

    Sub Announcements()
        Dim i As Integer
        Dim x As Integer = 5
        Dim y As Integer = 50
        Dim tp As TabPage = tabControl1.TabPages(0)
        If db.HasConnection() Then
            If db.SQLDS IsNot Nothing Then
                db.SQLDS.Clear()
            End If
            db.RunQuery("SELECT DISTINCT c.className, a.message 
                        FROM announcements a, classroom_student, classroom c
                        WHERE c.classId=a.classId AND student_id ='" & studentId & "'")
            For i = 0 To db.SQLDS.Tables(0).Rows.Count - 1
                ReDim MyLabels(db.SQLDS.Tables(0).Rows.Count)
                y += 50
                With MyLabels(i)
                    MyLabels(i) = New Label()
                    MyLabels(i).Name = i.ToString
                    MyLabels(i).Location = New Point(x, y)
                    MyLabels(i).Size = New Size(700, 40)
                    MyLabels(i).Font = New Font("Microsoft Sans Serif", 14)
                    MyLabels(i).Text = String.Format(CType(db.SQLDS.Tables(0).Rows(i).Item("className"), String) & ": " & CType(db.SQLDS.Tables(0).Rows(i).Item("message"), String))
                End With
                tp.Controls.Add(MyLabels(i))
            Next
        End If
    End Sub

    Sub DynamicLabels()
        Dim i As Integer
        Dim x As Integer = 14
        Dim y As Integer = 50
        Dim tp As TabPage = tabControl1.TabPages(1)
        If db.HasConnection() Then
            If db.SQLDS IsNot Nothing Then
                db.SQLDS.Clear()
            End If
            db.RunQuery("SELECT c.courseSubj AS Subject, c.courseNum AS CourseNum, r.className AS ClassName, t.tName AS Professor, r.classId
                        FROM course c, classRoom r, teacher t, classroom_student u, student s
                        WHERE c.courseId=r.course_id AND t.teacherId=r.teacher_id AND s.studentId=u.student_id AND u.classroom_id=r.classId AND s.sUsername='" & Login.Usr.Text & "' ")
            For i = 0 To db.SQLDS.Tables(0).Rows.Count - 1
                ReDim MyLabel(db.SQLDS.Tables(0).Rows.Count)
                y += 50
                With MyLabel(i)
                    MyLabel(i) = New LinkLabel()
                    MyLabel(i).Name = i.ToString
                    MyLabel(i).Location = New Point(x, y)
                    MyLabel(i).Size = New Size(700, 40)
                    MyLabel(i).Font = New Font("Microsoft Sans Serif", 14)
                    MyLabel(i).Text = String.Format(CType(db.SQLDS.Tables(0).Rows(i).Item("Subject"), String) & " " & CType(db.SQLDS.Tables(0).Rows(i).Item("CourseNum"), String) & " " & CType(db.SQLDS.Tables(0).Rows(i).Item("ClassName"), String) & ": " & CType(db.SQLDS.Tables(0).Rows(i).Item("Professor"), String))
                    AddHandler MyLabel(i).LinkClicked, AddressOf label_LinkClicked
                End With
                tp.Controls.Add(MyLabel(i))
            Next
        End If
    End Sub

    Sub GradeForClass()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblDisplayUserInfo.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Public Sub label_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim lbl As LinkLabel = CType(sender, LinkLabel)
        Dim labelname As String = DirectCast(sender, LinkLabel).Name
        Dim index As Integer = Convert.ToInt32(labelname)
        classId = String.Format(CType(db.SQLDS.Tables(0).Rows(index).Item("classId"), String))
        Form5.go()
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class