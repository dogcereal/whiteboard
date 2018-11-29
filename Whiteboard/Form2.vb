Imports System.IO
Imports System.Data.SQLite
Imports System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder

Public Class Student
    Dim GPA As Double = 0
    Public classId As String = Nothing
    Dim MyLabel() As LinkLabel
    Dim MyLabels() As Label
    Dim GradeLabel() As Label
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

    Private Function LetterGrade(avg As Integer) As String
        If avg > 90 Then
            Return "A"
        ElseIf avg > 80 Then
            Return "B"
        ElseIf avg > 70 Then
            Return "C"
        ElseIf avg > 60 Then
            Return "D"
        Else
            Return "F"
        End If
    End Function


    Sub GradeForClass()
        Dim i As Integer
        Dim x As Integer = 14
        Dim y As Integer = 50
        Dim tp As TabPage = tabControl1.TabPages(2)
        If db.HasConnection() Then
            If db.SQLDS IsNot Nothing Then
                db.SQLDS.Clear()
            End If
            db.RunQuery("SELECT classroom_id AS id, courseSubj AS sub, courseNum AS num
                        FROM classroom_student
                        INNER JOIN classRoom on classroom_student.classroom_id=classRoom.classId
                        INNER JOIN course on classroom.course_id=course.courseId
                        WHERE student_id='" & studentId & "'")
            Dim ClassArr(db.SQLDS.Tables(0).Rows.Count) As Integer
            Dim SubjectArr(db.SQLDS.Tables(0).Rows.Count) As String
            Dim CourseArr(db.SQLDS.Tables(0).Rows.Count) As String
            For i = 0 To db.SQLDS.Tables(0).Rows.Count - 1
                ClassArr(i) = CType(db.SQLDS.Tables(0).Rows(i).Item("id"), Integer)
                SubjectArr(i) = CType(db.SQLDS.Tables(0).Rows(i).Item("sub"), String)
                CourseArr(i) = CType(db.SQLDS.Tables(0).Rows(i).Item("num"), String)
            Next
            db.SQLDS.Clear()
            For i = 0 To ClassArr.Length - 2
                db.SQLDS.Clear()
                db.RunQuery("SELECT AVG(examScore) AS grade
                            FROM grades
                            WHERE student_id='" & studentId & "' AND classroom_id='" & ClassArr(i) & "'")
                ReDim GradeLabel(ClassArr.Length)
                y += 50
                With GradeLabel(i)
                    GradeLabel(i) = New Label()
                    GradeLabel(i).Name = i.ToString
                    GradeLabel(i).Location = New Point(x, y)
                    GradeLabel(i).Size = New Size(700, 40)
                    GradeLabel(i).Font = New Font("Microsoft Sans Serif", 14)
                    GradeLabel(i).Text = String.Format(CType(SubjectArr(i), String) & " " & CType(CourseArr(i), String) & ": " & LetterGrade(CType(db.SQLDS.Tables(0).Rows(0).Item("grade"), Integer)))
                End With
                tp.Controls.Add(GradeLabel(i))
            Next
        End If
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

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer
        If db.HasConnection() Then
            If db.SQLDS IsNot Nothing Then
                db.SQLDS.Clear()
            End If
            db.RunQuery("SELECT classroom.classId AS id, course.courseCredits AS 'credit'
                        FROM classRoom
                        INNER JOIN course ON classRoom.course_id=course.courseId
                        INNER JOIN classroom_student ON classroom.classId=classroom_student.classroom_id
                        WHERE classroom_student.student_id='" & studentId & "'")
            Dim Credit(db.SQLDS.Tables(0).Rows.Count - 1) As Integer
            Dim ClassId(db.SQLDS.Tables(0).Rows.Count - 1) As Double
            Dim Grades(db.SQLDS.Tables(0).Rows.Count - 1) As Double
            Dim Score(db.SQLDS.Tables(0).Rows.Count - 1) As Double
            Dim SumScores As Double = 0
            Dim SumCredits As Double = 0
            For i = 0 To db.SQLDS.Tables(0).Rows.Count - 1
                Credit(i) = CType(db.SQLDS.Tables(0).Rows(0).Item("credit"), Integer)
                ClassId(i) = CType(db.SQLDS.Tables(0).Rows(i).Item("id"), Double)
            Next
            db.SQLDS.Clear()
            For i = 0 To ClassId.Length - 1
                db.SQLDS.Clear()
                db.RunQuery("SELECT AVG(examScore) AS score
                            FROM grades
                            WHERE student_id='" & studentId & "' AND classroom_id='" & ClassId(i) & "'")
                Grades(i) = CType(db.SQLDS.Tables(0).Rows(i).Item("score"), Double)
            Next
            For i = 0 To ClassId.Length - 1
                Score(i) = (Grades(i) * 0.04) * Credit(i)
            Next
            For i = 0 To ClassId.Length - 1
                SumScores += Score(i)
                SumCredits += Credit(i)
            Next
            GPA = (SumScores) / (SumCredits)
        End If
        MsgBox("Current GPA: " & CType(GPA, String))
    End Sub
End Class