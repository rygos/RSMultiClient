Imports Sehraf.RSRPC
Imports rsctrl.system

Public Class clsConnection

    Public Structure strConInfo
        Dim sHost As String
        Dim iPort As Integer
        Dim sUser As String
        Dim sPass As String
    End Structure

    Dim ConInfo As strConInfo
    Dim RPC As New RSRPC(False)

    Sub New(sHost As String, iPort As Integer, sUser As String, sPass As String)
        With ConInfo
            .sHost = sHost
            .iPort = iPort
            .sUser = sUser
            .sPass = sPass
        End With
    End Sub

    Public Function Connect() As Boolean
        Dim result As Boolean
        Try
            If RPC.Connect(ConInfo.sHost, ConInfo.iPort, ConInfo.sUser, ConInfo.sPass) = True Then
                result = True
            Else
                result = False
            End If
        Catch ex As Exception
            result = False
        End Try

        Return result
    End Function

    Public Sub DisConnect()
        Try
            If RPC.IsConnected = True Then
                RPC.Disconnect()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Function getServerStatus()
        RPC.SystemGetStatus()

    End Function

End Class
