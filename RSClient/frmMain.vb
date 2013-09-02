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

    Public Sub Test()

    End Sub

    Private Sub frmMain_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        If chkAutoLogin.Checked = True Then
            SaveSetting("RSMC", "Login", "host", txtLoginHost.Text)
            SaveSetting("RSMC", "Login", "port", txtLoginPort.Text)
            SaveSetting("RSMC", "Login", "user", txtLoginUser.Text)
            SaveSetting("RSMC", "Login", "pass", txtLoginPass.Text)
        Else
            SaveSetting("RSMC", "Login", "host", "")
            SaveSetting("RSMC", "Login", "port", "")
            SaveSetting("RSMC", "Login", "user", "")
            SaveSetting("RSMC", "Login", "pass", "")
        End If

        con.Disconnect()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = wCap()

        txtLoginHost.Text = GetSetting("RSMC", "Login", "host")
        txtLoginPort.Text = GetSetting("RSMC", "Login", "port")
        txtLoginUser.Text = GetSetting("RSMC", "Login", "user")
        txtLoginPass.Text = GetSetting("RSMC", "Login", "pass")

        Me.DoubleBuffered = True
    End Sub

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click
        If txtLoginHost.Text = vbNullString Or txtLoginPort.Text = vbNullString Or txtLoginPass.Text = vbNullString Or txtLoginUser.Text = vbNullString Then
            MsgBox("Please enter all login informations.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If chkAutoLogin.Checked = True Then
            SaveSetting("RSMC", "Login", "host", txtLoginHost.Text)
            SaveSetting("RSMC", "Login", "port", txtLoginPort.Text)
            SaveSetting("RSMC", "Login", "user", txtLoginUser.Text)
            SaveSetting("RSMC", "Login", "pass", txtLoginPass.Text)
        Else
            SaveSetting("RSMC", "Login", "host", "")
            SaveSetting("RSMC", "Login", "port", "")
            SaveSetting("RSMC", "Login", "user", "")
            SaveSetting("RSMC", "Login", "pass", "")
        End If

        If cmdConnect.Text = "Connect" Then
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

        Select Case tcMain.SelectedIndex
            Case Is = 0
                Try
                    If con.GetSystemStatus() = 1 Then
                        tslblSysS.BackColor = Color.Green
                    Else
                        tslblSysS.BackColor = Color.Red
                    End If

                    lblNetStatus.Text = NetStatus2String(con.SystemStatusData.net_status)
                    lblPeersConnected.Text = con.SystemStatusData.no_connected
                    lblPeersSum.Text = con.SystemStatusData.no_peers
                    lblStatDown.Text = FormatBytesPerSec(con.SystemStatusData.bw_total.down * 1024)
                    lblStatUpload.Text = FormatBytesPerSec(con.SystemStatusData.bw_total.up * 1024)


                Catch ex As Exception
                    tslblSysS.BackColor = Color.Red
                End Try
            Case Is = 1
                Try
                    If con.GetTransferDLList() = 1 Then
                        tslblTLDL.BackColor = Color.Green
                    Else
                        tslblTLDL.BackColor = Color.Red
                    End If
                    Dim dlCachesCount As Integer
                    TLDirection = Direction.DIRECTION_DOWNLOAD
                    For Each item In con.TransferDLListData.transfers
                        UpdateFileTransfers(Direction.DIRECTION_DOWNLOAD, item.file.name, item.file.size, item.fraction, item.rate_kBs, item.state, item.file.hash)
                        If item.file.name = item.file.hash Then
                            dlCachesCount = dlCachesCount + 1
                        End If
                    Next
                    DeleteOldFileTransfers(Direction.DIRECTION_DOWNLOAD)
                    lblDLCache.Text = dlCachesCount
                    lblDLCount.Text = con.TransferDLListData.transfers.Count

                Catch ex As Exception
                    tslblTLDL.BackColor = Color.Red
                End Try
            Case Is = 2
                Try
                    If con.GetTransferULList() = 1 Then
                        tslblTLUL.BackColor = Color.Green
                    Else
                        tslblTLUL.BackColor = Color.Red
                    End If
                    Dim ulCachesCount As Integer
                    TLDirection = Direction.DIRECTION_UPLOAD
                    For Each item In con.TransferULListData.transfers
                        UpdateFileTransfers(Direction.DIRECTION_UPLOAD, item.file.name, item.file.size, item.fraction, item.rate_kBs, item.state, item.file.hash)
                        If item.file.name = item.file.hash Then
                            ulCachesCount = ulCachesCount + 1
                        End If
                    Next
                    DeleteOldFileTransfers(Direction.DIRECTION_UPLOAD)
                    lblULCaches.Text = ulCachesCount
                    lblULCount.Text = con.TransferULListData.transfers.Count
                Catch ex As Exception
                    tslblTLUL.BackColor = Color.Red
                End Try
        End Select

    End Sub

    Private Sub UpdateFileTransfers(Direction As Direction, filename As String, filesize As ULong, filefraction As Single, filerate As Single, filestate As UInteger, filehash As String)

        'Add new  Rows
        If Direction = rsctrl.files.Direction.DIRECTION_DOWNLOAD Then
            Dim tCount As Integer = 0
            For i = 0 To dgvDownloads.Rows.Count - 1
                If filehash = dgvDownloads.Rows(i).Cells(5).Value Then
                    dgvDownloads.Rows(i).Cells(2).Value = FormatPercent(filefraction, 1)
                    dgvDownloads.Rows(i).Cells(3).Value = FormatBytesPerSec(filerate * 1024)
                    dgvDownloads.Rows(i).Cells(4).Value = FileState2String(filestate)
                    tCount = tCount + 1
                End If
            Next
            If tCount = 0 Then
                dgvDownloads.Rows.Add(filename, FormatBytes(filesize), FormatPercent(filefraction, 1), FormatBytesPerSec(filerate * 1024), FileState2String(filestate), filehash)
            End If
        Else
            Dim tCount As Integer = 0
            For i = 0 To dgvUploads.Rows.Count - 1
                If filehash = dgvUploads.Rows(i).Cells(5).Value Then
                    dgvUploads.Rows(i).Cells(2).Value = FormatPercent(filefraction, 1)
                    dgvUploads.Rows(i).Cells(3).Value = FormatBytesPerSec(filerate * 1024)
                    dgvUploads.Rows(i).Cells(4).Value = FileState2String(filestate)
                    tCount = tCount + 1
                End If
            Next
            If tCount = 0 Then
                dgvUploads.Rows.Add(filename, FormatBytes(filesize), FormatPercent(filefraction, 1), FormatBytesPerSec(filerate * 1024), FileState2String(filestate), filehash)
            End If
        End If
    End Sub

    Private Sub DeleteOldFileTransfers(_direction As Direction)
        If _direction = rsctrl.files.Direction.DIRECTION_DOWNLOAD Then

            For i = 0 To dgvDownloads.Rows.Count - 1
                Dim tCount As Integer = 0
                For Each item In con.TransferDLListData.transfers
                    If item.file.hash = dgvDownloads.Rows(i).Cells(5).Value Then
                        tCount = tCount + 1
                    End If
                Next
                If tCount = 0 Then
                    dgvDownloads.Rows.RemoveAt(i)
                End If
            Next

        Else

            For i = 0 To dgvUploads.Rows.Count - 1
                Dim tCount As Integer = 0
                For Each item In con.TransferULListData.transfers
                    If item.file.hash = dgvUploads.Rows(i).Cells(5).Value Then
                        tCount = tCount + 1
                    End If
                Next
                If tCount = 0 Then
                    dgvUploads.Rows.RemoveAt(i)
                End If
            Next

        End If
    End Sub

End Class
