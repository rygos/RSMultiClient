Module modMisc
    Public Function wCap() As String
        Return Application.ProductName & " - " & Application.ProductVersion
    End Function

    Public Function FormatBytes(ByVal dblbytes As Double, Optional ByVal strFormated As String = "0.00") As String
        Dim arrPosForm() As String = {"B", "KiB", "MiB", "GiB", _
            "TiB", "PiB", "ExiB", "ZiB", "YiB"}
        For i As Integer = arrPosForm.Length - 1 To 0 Step -1
            If dblbytes > 1024 ^ i Then
                dblbytes /= 1024 ^ i
                Return dblbytes.ToString(strFormated) & " " & _
                    arrPosForm(i)
            End If
        Next i

        Return dblbytes.ToString(strFormated) & " Bytes"
    End Function

    Public Function FormatBytesPerSec(ByVal dblbytes As Double, Optional ByVal strFormated As String = "0.00") As String
        Dim arrPosForm() As String = {"B/s", "KiB/s", "MiB/s", "GiB/s", _
            "TiB/s", "PiB/s", "ExiB/s", "ZiB/s", "YiB/s"}
        For i As Integer = arrPosForm.Length - 1 To 0 Step -1
            If dblbytes > 1024 ^ i Then
                dblbytes /= 1024 ^ i
                Return dblbytes.ToString(strFormated) & " " & _
                    arrPosForm(i)
            End If
        Next i

        Return dblbytes.ToString(strFormated) & " Bytes"
    End Function

    Public Function FileState2String(FileStateID As Integer) As String
        Select Case FileStateID
            Case 1
                Return "Failed"
            Case 2
                Return "Okay"
            Case 3
                Return "Paused"
            Case 4
                Return "Queued"
            Case 5
                Return "Waiting"
            Case 6
                Return "Downloading"
            Case 7
                Return "Checking Hash"
            Case 8
                Return "Complete"
            Case Else
                Return "oO - N/A State"
        End Select
    End Function

    Public Function NetStatus2String(netStatusID As UInteger) As String
        Select Case netStatusID
            Case 0
                Return "BAD: Unknown"
            Case 1
                Return "BAD: Offline"
            Case 2
                Return "BAD: symmetric NAT"
            Case 3
                Return "BAD: No DHT, NATted"
            Case 4
                Return "Warning: Restart"
            Case 5
                Return "Warning: NATted"
            Case 6
                Return "Warning: No DHT"
            Case 7
                Return "Good!"
            Case 8
                Return "Adv. Forward"
            Case Else
                Return "UNK: Unkown"
        End Select
    End Function

    Public Function SplitString(ByVal strText As String, ByVal strChars As String, ByVal Mode As Integer) As String

        ' String in zwei Teile splitten
        ' und entweder linken Teil (Mode = 1)
        ' oder rechten Teil (Mode = 2) zurückgeben

        Dim sPos As Long

        sPos = InStr(strText, strChars)
        If sPos > 0 Then
            ' strChars ist in strText enthalten
            If Mode = 1 Then
                ' linke Teilstring zurückgeben
                SplitString = Left$(strText, sPos - 1)
            Else
                ' rechten Teilstring zurückgeben
                SplitString = Mid$(strText, sPos + Len(strChars))
            End If
        Else
            ' strChars ist in strText nicht enthalten
            SplitString = ""
        End If
    End Function

    ''' <summary>
    ''' Fügt dem ListView eine komplette Datenzeile hinzu
    ''' </summary>
    ''' <param name="lvw">ListView-Control</param>
    ''' <param name="Text">Parameterliste der einzelnen Zellenwerte</param>
    Public Sub lvwAddItem(ByVal lvw As ListView, ByVal ParamArray Text() As String)
        With lvw.Items
            .Add(New ListViewItem(Text))
        End With
    End Sub
End Module
