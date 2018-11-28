Imports System.Data.SQLite
Imports System.IO

Public Class Form5
    Private db As New DBConnection
    Dim MyLabels() As Label
    Dim MyLabels2() As Label
    Public total As Integer = Nothing

    Public Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DynamicLabels2()
        ClassGrade()
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

    Sub DynamicLabels2()
        Dim i As Integer
        Dim x As Integer = 5
        Dim y As Integer = 50
        Dim x2 As Integer = 280
        Dim y2 As Integer = 50
        Dim tp As TabPage = TabControl2.TabPages(1)
        If db.HasConnection() Then
            If db.SQLDS IsNot Nothing Then
                db.SQLDS.Clear()
            End If
            db.RunQuery("SELECT examName AS exam, examScore AS grade
                        FROM grades
                        WHERE student_id='" & Student.studentId & "' AND classroom_id ='" & Student.classId & "'
                        ORDER BY examName ASC")
            For i = 0 To db.SQLDS.Tables(0).Rows.Count - 1
                ReDim MyLabels(db.SQLDS.Tables(0).Rows.Count)
                ReDim MyLabels2(db.SQLDS.Tables(0).Rows.Count)
                y += 50
                y2 += 50
                With MyLabels(i)
                    MyLabels(i) = New Label()
                    MyLabels(i).Name = i.ToString
                    MyLabels(i).Location = New Point(x, y)
                    MyLabels(i).Size = New Size(700, 40)
                    MyLabels(i).Font = New Font("Microsoft Sans Serif", 14)
                    MyLabels(i).Text = String.Format(CType(db.SQLDS.Tables(0).Rows(i).Item("exam"), String))
                End With
                With MyLabels2(i)
                    MyLabels2(i) = New Label()
                    MyLabels2(i).Name = i.ToString
                    MyLabels2(i).Location = New Point(x2, y2)
                    MyLabels2(i).Size = New Size(700, 40)
                    MyLabels2(i).Font = New Font("Microsoft Sans Serif", 14)
                    MyLabels2(i).Text = String.Format(CType(db.SQLDS.Tables(0).Rows(i).Item("grade"), String))
                End With
                tp.Controls.Add(MyLabels(i))
                tp.Controls.Add(MyLabels2(i))
            Next
        End If
    End Sub

    Sub ClassGrade()
        If db.HasConnection() Then
            If db.SQLDS IsNot Nothing Then
                db.SQLDS.Clear()
            End If
            db.RunQuery("Select SUM(examScore) As gs, COUNT(*)*100 As total
                        FROM grades 
                        WHERE student_id='" & Student.studentId & "' AND classroom_id='" & Student.classId & "'")
            total = CType(db.SQLDS.Tables(0).Rows(0).Item("total"), Integer)
            If (total > 0) Then
                Label7.Text = String.Format(CType(db.SQLDS.Tables(0).Rows(0).Item("gs"), String) & "/" & CType(db.SQLDS.Tables(0).Rows(0).Item("total"), String))
            End If
        End If
    End Sub

    Public Sub go()
        Me.Form5_Load(Me, Nothing)
    End Sub

End Class