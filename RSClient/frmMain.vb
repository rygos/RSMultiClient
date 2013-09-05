Imports Renci.SshNet
Imports System.Xml
Imports rsctrl.files
Imports System.IO

Public Class frmMain
    Dim con As New process
    Dim TickCount As UInteger
    Dim TLDirection As Direction
    Dim TLDLcompare As rsctrl.files.ResponseTransferList
    Dim TLULcompare As rsctrl.files.ResponseTransferList
    Dim log As New clsLog(Application.StartupPath & "\log.txt")

    Public Sub Test()

    End Sub

    Private Sub frmMain_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        If chkAutoLogin.Checked = True Then
            OptionsSave()
        Else
            My.Settings("pass") = vbNullString
        End If

        con.Disconnect()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = wCap()

        OptionsLoad()

        Me.DoubleBuffered = True

        AddHandler con.SystemStatusEvent, AddressOf RefreshGUISystemStatus
        AddHandler con.TransferListDLEvent, AddressOf RefreshGUITLDL
        AddHandler con.TransferListULEvent, AddressOf RefreshGUITLUL

    End Sub

    Private Sub RefreshGUITLDL()
        'Transferlist Download
        Try
            Dim dlCachesCount As Integer
            TLDirection = Direction.DIRECTION_DOWNLOAD
            lvTLDL.Invoke(Sub() lvTLDL.BeginUpdate())
            For Each item In con.TransferListData.transfers
                UpdateFileTransfers(Direction.DIRECTION_DOWNLOAD, item.file.name, item.file.size, item.fraction, item.rate_kBs, item.state, item.file.hash)
                If item.file.name = item.file.hash Then
                    dlCachesCount = dlCachesCount + 1
                End If
            Next
            DeleteOldFileTransfers(Direction.DIRECTION_DOWNLOAD)
            lblDLCache.Invoke(Sub() lblDLCache.Text = dlCachesCount)
            lblDLCount.Invoke(Sub() lblDLCount.Text = con.TransferListData.transfers.Count)

            With lvTLDL
                .Invoke(Sub() .EndUpdate())
            End With

        Catch ex As Exception
            log.Log("RefreshGUITLDL MSG- " & ex.Message)
            log.Log("RefreshGUITLDL ST- " & ex.StackTrace)
        End Try
    End Sub

    Private Sub RefreshGUITLUL()
        'Transferlist Upload
        Try
            Dim ulCachesCount As Integer
            TLDirection = Direction.DIRECTION_UPLOAD
            lvTLUL.Invoke(Sub() lvTLUL.BeginUpdate())
            For Each item In con.TransferListData.transfers
                UpdateFileTransfers(Direction.DIRECTION_UPLOAD, item.file.name, item.file.size, item.fraction, item.rate_kBs, item.state, item.file.hash)
                If item.file.name = item.file.hash Then
                    ulCachesCount = ulCachesCount + 1
                End If
            Next
            DeleteOldFileTransfers(Direction.DIRECTION_UPLOAD)
            lblULCaches.Invoke(Sub() lblULCaches.Text = ulCachesCount)
            lblULCount.Invoke(Sub() lblULCount.Text = con.TransferListData.transfers.Count)

            With lvTLUL
                .Invoke(Sub() .EndUpdate())
            End With

        Catch ex As Exception
            log.Log("RefreshGUITLUL MSG- " & ex.Message)
            log.Log("RefreshGUITLUL ST- " & ex.StackTrace)
        End Try
    End Sub

    Private Sub RefreshGUISystemStatus()
        'SystemStatus (Setup)
        lblNetStatus.Invoke(Sub() lblNetStatus.Text = NetStatus2String(con.SystemStatusData.net_status))
        lblPeersConnected.Invoke(Sub() lblPeersConnected.Text = con.SystemStatusData.no_connected)
        lblPeersSum.Invoke(Sub() lblPeersSum.Text = con.SystemStatusData.no_peers)
        lblStatDown.Invoke(Sub() lblStatDown.Text = FormatBytesPerSec(con.SystemStatusData.bw_total.down * 1024))
        lblStatUpload.Invoke(Sub() lblStatUpload.Text = FormatBytesPerSec(con.SystemStatusData.bw_total.up * 1024))
    End Sub

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click

        If cmdConnect.Text = "Connect" Then
            If txtLoginHost.Text = vbNullString Or txtLoginPort.Text = vbNullString Or txtLoginPass.Text = vbNullString Or txtLoginUser.Text = vbNullString Then
                MsgBox("Please enter all login informations.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If con.Connect(txtLoginHost.Text, CUInt(txtLoginPort.Text), txtLoginUser.Text, txtLoginPass.Text) = True Then
                lblStatus.BackColor = Color.Green
                lblStatus.Text = "CONNECTED"
                cmdConnect.Text = "Disconnect"
                tmrTick.Enabled = True
            Else
                lblStatus.BackColor = Color.Red
                lblStatus.Text = "OFFLINE"
                cmdConnect.Text = "Connect"
                tmrTick.Enabled = False
            End If
        Else
            If con.Disconnect Then
                lblStatus.BackColor = Color.Red
                lblStatus.Text = "OFFLINE"
                cmdConnect.Text = "Connect"
                tmrTick.Enabled = False
            Else
                lblStatus.BackColor = Color.Green
                lblStatus.Text = "CONNECTED"
                cmdConnect.Text = "Disconnect"
                tmrTick.Enabled = True
            End If
        End If

    End Sub

    Private Sub tmrTick_Tick(sender As Object, e As EventArgs) Handles tmrTick.Tick
        con.GetSystemStatus()
        con.GetTransferDLList()
        con.GetTransferULList()
    End Sub

    Private Sub UpdateFileTransfers(Direction As Direction, filename As String, filesize As ULong, filefraction As Single, filerate As Single, filestate As UInteger, filehash As String)
        Try
            If Direction = rsctrl.files.Direction.DIRECTION_DOWNLOAD Then
                Dim tCount As Integer = 0
                For i = 0 To lvTLDL.Items.Count - 1
                    Dim ix As Integer = i
                    Dim temp As String
                    lvTLDL.Invoke(Sub() temp = lvTLDL.Items(ix).SubItems(5).Text)
                    If filehash = temp Then
                        lvTLDL.Invoke(Sub() lvTLDL.Items(ix).SubItems(2).Text = FormatPercent(filefraction, 1))
                        lvTLDL.Invoke(Sub() lvTLDL.Items(ix).SubItems(3).Text = FormatBytesPerSec(filerate * 1024))
                        lvTLDL.Invoke(Sub() lvTLDL.Items(ix).SubItems(4).Text = FileState2String(filestate))
                        tCount = tCount + 1
                    End If
                Next
                If tCount = 0 Then
                    Dim lwi As New ListViewItem
                    lwi.Text = filename
                    lwi.SubItems.Add(FormatBytes(filesize))
                    lwi.SubItems.Add(FormatPercent(filefraction))
                    lwi.SubItems.Add(FormatBytesPerSec(filerate * 1024))
                    lwi.SubItems.Add(FileState2String(filestate))
                    lwi.SubItems.Add(filehash)

                    lvTLDL.Invoke(Sub() lvTLDL.Items.Add(lwi))
                End If

            Else
                Dim tCount As Integer = 0
                For i = 0 To lvTLUL.Items.Count - 1
                    Dim ix As Integer = i
                    Dim temp As String
                    lvTLUL.Invoke(Sub() temp = lvTLUL.Items(ix).SubItems(5).Text)
                    If filehash = temp Then
                        lvTLUL.Invoke(Sub() lvTLUL.Items(ix).SubItems(2).Text = FormatPercent(filefraction, 1))
                        lvTLUL.Invoke(Sub() lvTLUL.Items(ix).SubItems(3).Text = FormatBytesPerSec(filerate * 1024))
                        lvTLUL.Invoke(Sub() lvTLUL.Items(ix).SubItems(4).Text = FileState2String(filestate))
                        tCount = tCount + 1
                    End If
                Next
                If tCount = 0 Then
                    Dim lwi As New ListViewItem
                    lwi.Text = filename
                    lwi.SubItems.Add(FormatBytes(filesize))
                    lwi.SubItems.Add(FormatPercent(filefraction))
                    lwi.SubItems.Add(FormatBytesPerSec(filerate * 1024))
                    lwi.SubItems.Add(FileState2String(filestate))
                    lwi.SubItems.Add(filehash)

                    lvTLUL.Invoke(Sub() lvTLUL.Items.Add(lwi))
                End If
            End If
        Catch ex As Exception
            log.Log("UpdateFileTransfers MSG- " & ex.Message)
            log.Log("UpdateFileTransfers ST- " & ex.StackTrace)
        End Try

    End Sub

    Private Sub DeleteOldFileTransfers(_direction As Direction)
        If _direction = rsctrl.files.Direction.DIRECTION_DOWNLOAD Then
            Try
                For i = 0 To lvTLDL.Items.Count - 1
                    Dim tCount As Integer = 0
                    Dim ix As Integer
                    For Each item In con.TransferListData.transfers
                        Dim temp As String
                        lvTLDL.Invoke(Sub() temp = lvTLDL.Items(ix).SubItems(5).Text)
                        If item.file.hash = temp Then
                            tCount = tCount + 1
                        End If
                    Next
                    If tCount = 0 Then
                        lvTLDL.Invoke(Sub() lvTLDL.Items.RemoveAt(ix))
                        Return
                    End If
                Next
            Catch ex As Exception

            End Try
        Else
            Try
                For i = 0 To lvTLUL.Items.Count - 1
                    Dim tCount As Integer = 0
                    Dim ix As Integer = i
                    For Each item In con.TransferListData.transfers
                        Dim temp As String
                        lvTLUL.Invoke(Sub() temp = lvTLUL.Items(ix).SubItems(5).Text)
                        If temp = item.file.hash Then
                            tCount = tCount + 1
                        End If
                    Next
                    If tCount = 0 Then
                        lvTLUL.Invoke(Sub() lvTLUL.Items.RemoveAt(ix))
                        Return
                    End If
                Next
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub cmdTest_Click(sender As Object, e As EventArgs)
        OptionsLoad()
    End Sub

    Private Sub cmdTest_Click_1(sender As Object, e As EventArgs) Handles cmdTest.Click
        lvTLDL.Refresh()
        lvTLUL.Refresh()
    End Sub
End Class
