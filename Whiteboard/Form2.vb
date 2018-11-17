Imports System.IO
Imports System.Data.SQLite

Public Class Student
    Private db As New DBConnection
    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDisplayUserInfo.Text = Login.Usr.Text()
        If db.HasConnection() Then
            Dim sQ As String = "SELECT sName, studentId
                                From student Where sUsername ='" & Login.Usr.Text & "' "
            If db.SQLDS IsNot Nothing Then
                db.SQLDS.Clear()
            End If
            db.RunQuery("SELECT sName AS name, studentId AS id FROM student WHERE sUsername='" & Login.Usr.Text & "' ")
            name_id.Text = String.Format("Student Name: " & CType(db.SQLDS.Tables(0).Rows(0).Item("name"), String) & "     ID: " & CType(db.SQLDS.Tables(0).Rows(0).Item("id"), String) & "'")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Login.Show()

    End Sub

    Private Sub courseTab_Click(sender As Object, e As EventArgs) Handles courseTab.Click
        If db.HasConnection() Then
            db.RunQuery("SELECT r.term AS term, c.courseSubj AS subj, c.courseNum AS cnum, r.className AS class, t.tName AS proff, r.days AS days
                        FROM classRoom r, course c, teacher t, student, classroom_student
                        WHERE student.studentId=classroom_student.student_id AND r.classId=classroom_student.classroom_id AND t.teacherId=r.teacher_id AND c.courseId=r.course_id AND student.studentId='" & CType(db.SQLDS.Tables(0).Rows(0).Item("id"), String) & "'")

            courses.Text = String.Format(" " & CType(db.SQLDS.Tables(0).Rows(0).Item("term"), String) & CType(db.SQLDS.Tables(0).Rows(0).Item("subj"), String) & CType(db.SQLDS.Tables(0).Rows(0).Item("cnum"), String) & CType(db.SQLDS.Tables(0).Rows(0).Item("class"), String) & CType(db.SQLDS.Tables(0).Rows(0).Item("professor"), String) & CType(db.SQLDS.Tables(0).Rows(0).Item("days"), String))
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblDisplayUserInfo.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class