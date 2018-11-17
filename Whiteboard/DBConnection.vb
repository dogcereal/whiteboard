Imports System.Data.SQLite
Imports System.IO

Public Class DBConnection

    Public SQLcmd As SQLiteCommand
    Public SQLDA As SQLiteDataAdapter
    Public SQLDS As DataSet
    Public SQLreader As SQLiteDataReader
    Public connectionString As String = String.Format("Data Source={0};Version=3;",
                                                       Directory.GetCurrentDirectory() & "\" & "LMS.db")
    Private SQLcon As New SQLiteConnection(connectionString)

    Public Function HasConnection() As Boolean
        Try
            SQLcon.Open()
            SQLcon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Sub RunQuery(Query As String)
        Try
            SQLcon.Open()
            SQLcmd = New SQLiteCommand(Query, SQLcon)
            SQLDA = New SQLiteDataAdapter(SQLcmd)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)
            SQLcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQLcon.State = ConnectionState.Open Then
                SQLcon.Close()
            End If
        End Try
    End Sub

End Class
