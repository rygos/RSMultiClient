
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports System.IO

Imports Sehraf.RSRPC

Imports rsctrl.chat
Imports rsctrl.core
Imports rsctrl.files
'using rsctrl.gxs;
'using rsctrl.msgs;
Imports rsctrl.peers
Imports rsctrl.search
Imports rsctrl.stream
Imports rsctrl.system

Friend Class clsProcessor

    Const DEBUG As Boolean = False
    Const pattern As String = "<.*?>"

    Friend Sub Reset()

    End Sub

    Public Shared Function RemoteTags(inputString As String) As String
        Return Regex.Replace(inputString, pattern, String.Empty)
    End Function

    Public Shared Function conv_Date2Timestam(date2 As DateTime) As Double
        Dim date1 As New DateTime(1970, 1, 1, 0, 0, 0, _
            0)
        Dim ts As New TimeSpan(date2.Ticks - date1.Ticks)
        Return ts.TotalSeconds
    End Function

    Public Shared Function conv_Timestamp2Date(Timestamp As Double) As DateTime
        Dim dateTime As New DateTime(1970, 1, 1, 0, 0, 0, _
            0)
        dateTime = dateTime.AddSeconds(Timestamp)
        Return dateTime
    End Function

    Public Shared Function BuildSizeString(size As ULong) As String
        Dim counter As Byte = 0
        Dim sizef As Single = size
        While sizef > 1024
            counter += 1
            sizef /= 1024
        End While
        Dim s As String = ""
        Select Case counter
            Case 0
                s = "B"
                Exit Select
            Case 1
                s = "KiB"
                Exit Select
            Case 2
                s = "MiB"
                Exit Select
            Case 3
                s = "GiB"
                Exit Select
            Case 4
                s = "TiB"
                Exit Select
            Case 5
                s = "PiB"
                Exit Select
            Case Else
                s = "too damn high"
                Exit Select
        End Select
        Return [String].Format("{0:0.00}", sizef) & s
    End Function

    'public static string GetRandomInsult()
    '{
    '    string fileName = Settings.InsultListFileName;
    '    string[] list = System.IO.File.ReadAllLines(fileName);

    '    Random rnd = new Random(DateTime.UtcNow.Millisecond);
    '    int random = rnd.Next(list.Length - 1);

    '    return list[random];
    '}

    Friend Sub ProcessMsg(msg As RSProtoBuffSSHMsg)
        Dim extension As Byte = RSProtoBuf.GetRpcMsgIdExtension(msg.MsgID)
        Dim service As UShort = RSProtoBuf.GetRpcMsgIdService(msg.MsgID)
        System.Diagnostics.Debug.WriteLineIf(DEBUG, "Processing Msg " + msg.ReqID + " .....")
        System.Diagnostics.Debug.WriteLineIf(DEBUG, "ext: " + extension + " - service: " + service + " - submsg: " + RSProtoBuf.GetRpcMsgIdSubMsg(msg.MsgID))
        'System.Diagnostics.Debug.WriteLineIf(true, "Processing Msg " + msg.ReqID + " .....");
        'System.Diagnostics.Debug.WriteLineIf(true, "ext: " + extension + " - service: " + service + " - submsg: " + RSProtoBuf.GetRpcMsgIdSubMsg(msg.MsgID));
        '_gui.tb_out.AppendText(" -> " + msg.ReqID + "\n");
        Select Case extension
            Case CByte(rsctrl.core.ExtensionId.CORE)
                Select Case service
                    Case CUShort(PackageId.SYSTEM)
                        ProcessSystem(msg)
                        Exit Select
                    Case Else

                        System.Diagnostics.Debug.WriteLineIf(DEBUG, "ProcessMsg: unknown service " + service)
                        Exit Select
                End Select
                ' service
                Exit Select
            Case Else
                System.Diagnostics.Debug.WriteLineIf(DEBUG, "ProcessMsg: unknown extension " + extension)
                Exit Select
        End Select
        ' extension
        System.Diagnostics.Debug.WriteLineIf(DEBUG, "##########################################")
    End Sub

    ' ---------- system ----------
    Private Sub ProcessSystem(msg As RSProtoBuffSSHMsg)
        Dim submsg As Byte = RSProtoBuf.GetRpcMsgIdSubMsg(msg.MsgID)
        Select Case submsg
            Case CByte(rsctrl.system.ResponseMsgIds.MsgId_ResponseSystemStatus)
                ProcessSystemStatus(msg)
                Exit Select
            Case Else
                System.Diagnostics.Debug.WriteLineIf(DEBUG, "ProcessSystem: unknown submsg " + submsg)
                Exit Select
        End Select
    End Sub

    Private Sub ProcessSystemStatus(msg As RSProtoBuffSSHMsg)
        Dim response As New ResponseSystemStatus()
        Dim e As Exception
        If RSProtoBuf.Deserialize(Of ResponseSystemStatus)(msg.ProtoBuffMsg, response, e) Then
            frmMain.UpdateSystemStatus(response)
        Else
            System.Diagnostics.Debug.WriteLine("ProcessSystemstatus: error deserializing " + e.Message)
        End If
    End Sub

End Class

