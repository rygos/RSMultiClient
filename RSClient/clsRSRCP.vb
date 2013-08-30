Imports Sehraf.RSRPC
Public Class clsRSRCP
    Public _rpc As New Sehraf.RSRPC.RSRPC(False)

    Public SystemStatusData As rsctrl.system.ResponseSystemStatus
    Public TransferListData As rsctrl.files.ResponseTransferList

    Private Structure strConInfo
        Dim Host As String
        Dim Port As UInteger
        Dim User As String
        Dim Pass As String
    End Structure

    Dim conInfo As strConInfo

    Public Sub GetSystemStatus()
        _rpc.SystemGetStatus()
        'System.Threading.Thread.Sleep(1000)
    End Sub

    Public Sub GetTransferList()
        _rpc.FilesGetTransferList(rsctrl.files.Direction.DIRECTION_DOWNLOAD)
    End Sub

    Public Sub New()

        _rpc.EventOccurred = CType([Delegate].Combine(_rpc.EventOccurred, New RSRPC.EventOccurredEvent(AddressOf EventFromThread)), RSRPC.EventOccurredEvent)
        _rpc.ReceivedMsg = CType([Delegate].Combine(_rpc.ReceivedMsg, New RSRPC.ReceivedMsgEvent(AddressOf ProcessMsgFromThread)), RSRPC.ReceivedMsgEvent)

    End Sub

    Public Function Disconnect(Optional ShutDown As Boolean = False) As Boolean
        _rpc.Disconnect(ShutDown)
        If _rpc.IsConnected Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function Connect(Host As String, Port As UInteger, User As String, Pass As String) As Boolean
        With conInfo
            .Host = Host
            .Port = Port
            .User = User
            .Pass = Pass
        End With

        If _rpc.Connect(conInfo.Host, conInfo.Port, conInfo.User, conInfo.Pass) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub EventFromThread(type As RSRPC.EventType, obj As Object)
        Select Case type
            Case RSRPC.EventType.[Error]
                System.Diagnostics.Debug.WriteLine("error")
                Exit Select
            Case RSRPC.EventType.Reconnect
                System.Diagnostics.Debug.WriteLine("reconnect")
                Exit Select
        End Select
    End Sub

    Private Sub ProcessMsgFromThread(msg As RSProtoBuffSSHMsg)
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

        ' check submsg
        If submsg <> CByte(rsctrl.system.ResponseMsgIds.MsgId_ResponseSystemStatus) Then
            Return
        End If

        ' check service
        Select Case service
            Case CUShort(rsctrl.core.PackageId.PEERS)

            Case CUShort(rsctrl.core.PackageId.SYSTEM)
                SystemStatusData = GetSystemStatusData(msg)
            Case CUShort(rsctrl.core.PackageId.CHAT)

            Case CUShort(rsctrl.core.PackageId.SEARCH)

            Case CUShort(rsctrl.core.PackageId.FILES)
                TransferListData = GetTransferListData(msg)
            Case CUShort(rsctrl.core.PackageId.STREAM)

            Case Else
                Return
        End Select

    End Sub

    Public Function GetTransferListData(msg As RSProtoBuffSSHMsg) As rsctrl.files.ResponseTransferList
        ' deserialize
        Dim response As New rsctrl.files.ResponseTransferList()
        Dim e As Exception = Nothing
        If Not RSProtoBuf.Deserialize(Of rsctrl.files.ResponseTransferList)(msg.ProtoBuffMsg, response, e) Then
            Debug.Print("ProcessSystemstatus: error deserializing " & e.Message)
        End If

        ' check if msg is good
        If response.status Is Nothing OrElse response.status.code <> rsctrl.core.Status.StatusCode.SUCCESS Then
            Return Nothing
        End If

        Return response
    End Function

    Public Function GetSystemStatusData(msg As RSProtoBuffSSHMsg) As rsctrl.system.ResponseSystemStatus

        ' deserialize
        Dim response As New rsctrl.system.ResponseSystemStatus()
        Dim e As Exception = Nothing
        If Not RSProtoBuf.Deserialize(Of rsctrl.system.ResponseSystemStatus)(msg.ProtoBuffMsg, response, e) Then
            Debug.Print("ProcessSystemstatus: error deserializing " & e.Message)
        End If

        ' check if msg is good
        If response.status Is Nothing OrElse response.status.code <> rsctrl.core.Status.StatusCode.SUCCESS Then
            Return Nothing
        End If

        Return response
    End Function
End Class
