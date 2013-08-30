Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Imports Sehraf.RSRPC

Namespace test
    Class clsTest
        Public Shared _rpc As New RSRPC(False)

        Public Shared Sub DoThings()

            _rpc.EventOccurred = CType([Delegate].Combine(_rpc.EventOccurred, New RSRPC.EventOccurredEvent(AddressOf EventFromThread)), RSRPC.EventOccurredEvent)
            _rpc.ReceivedMsg = CType([Delegate].Combine(_rpc.ReceivedMsg, New RSRPC.ReceivedMsgEvent(AddressOf ProcessMsgFromThread)), RSRPC.ReceivedMsgEvent)

            _rpc.Connect("banncity.de", 8080, "ryg", "Skymaster2")

            If Not _rpc.IsConnected Then
                Debug.Print("can't connect")
                Return
            End If

            For i As Byte = 0 To 9
                Debug.Print("requestion system status")
                _rpc.SystemGetStatus()
                System.Threading.Thread.Sleep(1000)
            Next

            _rpc.Disconnect()
        End Sub

        Private Shared Sub EventFromThread(type As RSRPC.EventType, obj As Object)
            Select Case type
                Case RSRPC.EventType.[Error]
                    System.Diagnostics.Debug.WriteLine("error")
                    Exit Select
                Case RSRPC.EventType.Reconnect
                    System.Diagnostics.Debug.WriteLine("reconnect")
                    Exit Select
            End Select
        End Sub


        Private Shared Sub ProcessMsgFromThread(msg As RSProtoBuffSSHMsg)
            Debug.Print("got msg")

            ' check is msg is response
            If Not RSProtoBuf.IsRpcMsgIdResponse(msg.MsgID) Then
                Return
            End If

            Dim extension As Byte = RSProtoBuf.GetRpcMsgIdExtension(msg.MsgID)
            Dim service As UShort = RSProtoBuf.GetRpcMsgIdService(msg.MsgID)
            Dim submsg As Byte = RSProtoBuf.GetRpcMsgIdSubMsg(msg.MsgID)

            Debug.Print(extension & service & submsg)

            ' check extension
            If extension <> CByte(rsctrl.core.ExtensionId.CORE) Then
                Return
            End If

            ' check service
            If service <> CUShort(rsctrl.core.PackageId.SYSTEM) Then
                Return
            End If

            ' check submsg
            If submsg <> CByte(rsctrl.system.ResponseMsgIds.MsgId_ResponseSystemStatus) Then
                Return
            End If

            ' deserialize
            Dim response As New rsctrl.system.ResponseSystemStatus()
            Dim e As Exception
            If Not RSProtoBuf.Deserialize(Of rsctrl.system.ResponseSystemStatus)(msg.ProtoBuffMsg, response, e) Then
                Debug.Print("ProcessSystemstatus: error deserializing " & e.Message)
            End If

            ' check if msg is good
            If response.status Is Nothing OrElse response.status.code <> rsctrl.core.Status.StatusCode.SUCCESS Then
                Return
            End If

            Debug.Print("Systemstatus: ")
            Debug.Print(" -- peers: " & response.no_peers)
            Debug.Print(" -- online: " & response.no_connected)
            Debug.Print(" -- netstatus: " & response.net_status)
        End Sub
    End Class
End Namespace