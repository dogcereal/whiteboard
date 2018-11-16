Imports System.Data.SQLite

Public Class DBConnection

    Private SQLcmd As SQLiteCommand
    Public SQLDA As SQLiteDataAdapter
    Public SQLDS As DataSet

    Dim location As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Dim fileName As String = "LMS.db"
    Dim fullPath As String = System.IO.Path.Combine(location, fileName)
    Public connectionString As String = String.Format("Data Source = {0}", fullPath)
    Private SQLcon As New SQLiteConnection(connectionString)

    Public Sub createDataBase()
        If Not duplicateDatabase(fullPath) Then
            SQLcon.Open()
            Dim createTable As String = "CREATE TABLE IF Not EXISTS `teacher` (
	                                        `teacherId`	INTEGER Not NULL PRIMARY KEY AUTOINCREMENT,
	                                        `tName`	TEXT Not NULL,
	                                        `tEmail`	TEXT DEFAULT 'N/A',
	                                        `tPhone`	INTEGER DEFAULT '--',
	                                        `tAbout`	TEXT
                                        );
                                        CREATE TABLE IF Not EXISTS `teach_classroom` (
	                                        `teacher_id`	INTEGER,
	                                        `classroom_id`	INTEGER,
	                                        FOREIGN KEY(`teacher_id`) REFERENCES `teacher`(`teacherId`),
	                                        FOREIGN KEY(`classroom_id`) REFERENCES `classRoom`(`classId`)
                                        );
                                        CREATE TABLE IF Not EXISTS `student` (
	                                        `studentId`	INTEGER Not NULL PRIMARY KEY AUTOINCREMENT,
	                                        `sName`	TEXT Not NULL,
	                                        `sUsername`	TEXT Not NULL UNIQUE,
	                                        `sPass`	TEXT Not NULL,
	                                        `sEmail`	TEXT
                                        );
                                        CREATE TABLE IF Not EXISTS `course` (
	                                        `courseId`	INTEGER Not NULL PRIMARY KEY AUTOINCREMENT,
	                                        `courseSubj`	TEXT Not NULL,
	                                        `courseNum`	INTEGER Not NULL,
	                                        `courseAbout`	TEXT
                                        );
                                        CREATE TABLE IF Not EXISTS `classroom_student` (
	                                        `student_id`	INTEGER,
	                                        `classroom_id`	INTEGER,
	                                        FOREIGN KEY(`student_id`) REFERENCES `student`(`studentId`)
                                        );
                                        CREATE TABLE IF Not EXISTS `classRoom` (
	                                        `classId`	INTEGER Not NULL,
	                                        `className`	INTEGER Not NULL,
	                                        `course_id`	INTEGER,
	                                        `teacher_id`	INTEGER,
	                                        `days`	TEXT DEFAULT 'TBA',
	                                        FOREIGN KEY(`teacher_id`) REFERENCES `teacher`(`teacherId`),
	                                        PRIMARY KEY(`classId`),
                                            FOREIGN KEY(`course_id`) REFERENCES `course`(`courseId`)
                                        );
                                        CREATE View `student_schedule` As Select DISTINCT s.studentId, s.sName, c.className, c.days
                                        From student s, classRoom c, classroom_student b
                                        Where s.studentId = b.student_id And c.classId = b.classroom_id And s.studentId = 3;
                                        CREATE View `scheduleClasses` As Select r.courseSubj, r.courseNum, c.className, c.days, t.tName
                                        From classRoom c, course r, teacher t
                                        Where r.courseId = c.course_id And t.teacherId = c.teacher_id;
                                        "



            Dim cmd As New SQLiteCommand(createTable, SQLcon)
            cmd.ExecuteNonQuery()
            SQLcon.Close()
        End If
    End Sub

    Private Function duplicateDatabase(fullPath As String) As Boolean
        Return System.IO.File.Exists(fullPath)
    End Function

    Public Function HasConnection() As Boolean
        Try
            SQLcon.Open()
            SQLcon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function

    Public Sub RunQuery(Query As String)
        Try
            SQLcon.Open()
            'CREATE COMMAND
            SQLcmd = New SQLiteCommand(Query, SQLcon)

            'FILL DATASET
            SQLDA = New SQLiteDataAdapter(SQLcmd)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)

            SQLcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

            'MAKE SURE CONNECTION IS CLOSED 
            If SQLcon.State = ConnectionState.Open Then
                SQLcon.Close()
            End If
        End Try
    End Sub

End Class
