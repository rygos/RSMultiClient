Imports Renci.SshNet
Imports System.Xml

Public Class frmMain
    Dim con As New process

    Dim TickCount As UInteger

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
                    dgvDownloads.Rows.Clear()
                    For Each item In con.TransferDLListData.transfers
                        dgvDownloads.Rows.Add(item.file.name, FormatBytes(item.file.size), FormatPercent(item.fraction, 1), FormatBytesPerSec(item.rate_kBs * 1024), FileState2String(item.state), item.file.hash)
                        If item.file.name = item.file.hash Then
                            dlCachesCount = dlCachesCount + 1
                        End If
                    Next
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
                    dgvUploads.Rows.Clear()
                    For Each item In con.TransferULListData.transfers
                        dgvUploads.Rows.Add(item.file.name, FormatBytes(item.file.size), FormatPercent(item.fraction, 1), FormatBytesPerSec(item.rate_kBs * 1024), FileState2String(item.state), item.file.hash)
                        If item.file.name = item.file.hash Then
                            ulCachesCount = ulCachesCount + 1
                        End If
                    Next
                    lblULCaches.Text = ulCachesCount
                    lblULCount.Text = con.TransferULListData.transfers.Count
                Catch ex As Exception
                    tslblTLUL.BackColor = Color.Red
                End Try
        End Select

    End Sub

End Class
