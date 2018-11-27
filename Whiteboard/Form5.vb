Imports System.Data.SQLite
Imports System.IO

Public Class Form5
    Private db As New DBConnection
    Dim MyLabel() As Label

    Public Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DynamicLabels()
        If db.HasConnection() Then
            If db.SQLDS IsNot Nothing Then
                db.SQLDS.Clear()
            End If
            db.RunQuery("SELECT c.courseSubj AS sub, c.courseNum AS cn, r.className AS class, t.tName AS teacher, r.term, r.days, r.location
                        FROM course c, classroom r, teacher t
                        WHERE c.courseId=r.course_id AND t.teacherId=r.teacher_id AND r.classId='" & Student.classId & "'")
            Label1.Text = String.Format("" & CType(db.SQLDS.Tables(0).Rows(0).Item("sub"), String) & " " & CType(db.SQLDS.Tables(0).Rows(0).Item("cn"), String) & " " & CType(db.SQLDS.Tables(0).Rows(0).Item("class"), String))
            Label2.Text = String.Format("Professor:" & Environment.NewLine & CType(db.SQLDS.Tables(0).Rows(0).Item("teacher"), String))
            Label3.Text = String.Format("Term: " & Environment.NewLine & CType(db.SQLDS.Tables(0).Rows(0).Item("term"), String))
            Label4.Text = String.Format("Days: " & Environment.NewLine & CType(db.SQLDS.Tables(0).Rows(0).Item("days"), String))
            Label5.Text = String.Format("Location: " & Environment.NewLine & CType(db.SQLDS.Tables(0).Rows(0).Item("location"), String))
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Student.Show()
        Me.Controls.Clear()
        InitializeComponent()
        Me.Hide()
    End Sub

    Sub DynamicLabels()
        Dim i As Integer
        Dim x As Integer = 300
        Dim y As Integer = 200
        Dim tp As TabPage = TabControl2.TabPages(1)
        If db.HasConnection() Then
            If db.SQLDS IsNot Nothing Then
                db.SQLDS.Clear()
            End If
            db.RunQuery("SELECT g.examName AS exam, g.examScore score
                        From student s, grades g, classroom r
                        Where s.studentId=g.student_id AND r.classId=g.classroom_id AND s.sUsername='" & Login.Usr.Text & "' AND r.classId ='" & Student.classId & "' ")
            For i = 0 To db.SQLDS.Tables(0).Rows.Count - 1
                ReDim MyLabel(db.SQLDS.Tables(0).Rows.Count)
                y += 50
                With MyLabel(i)
                    MyLabel(i) = New Label()
                    MyLabel(i).Name = i.ToString
                    MyLabel(i).Location = New Point(x, y)
                    MyLabel(i).Size = New Size(700, 40)
                    MyLabel(i).Font = New Font("Microsoft Sans Serif", 14)
                    MyLabel(i).Text = String.Format(CType(db.SQLDS.Tables(0).Rows(i).Item("exam"), String) & "      " & CType(db.SQLDS.Tables(0).Rows(i).Item("score"), String))
                End With
                tp.Controls.Add(MyLabel(i))
            Next
        End If
    End Sub

    Public Sub go()
        Me.Form5_Load(Me, Nothing)
    End Sub

End Class