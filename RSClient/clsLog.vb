Imports System.IO

Public Class clsLog
    Dim FilePath As String

    Public Sub New(sFilePath As String)
        FilePath = sFilePath
    End Sub

    Public Sub Log(sText As String)
        Dim s As StreamWriter

        If File.Exists(FilePath) = False Then
            File.Create(FilePath).Close()
        End If

        s = New StreamWriter(FilePath, True)
        s.WriteLine(Now & " - " & sText)
        s.Flush()
        s.Close()

    End Sub
End Class
