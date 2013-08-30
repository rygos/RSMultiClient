Imports Renci.SshNet
Imports System.Xml

Public Class frmMain
    Dim con As New clsRSRCP
    Public Sub Test()

    End Sub

    Private Sub frmMain_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        con.Disconnect()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
    End Sub

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click
        If txtLoginHost.Text = vbNullString Or txtLoginPort.Text = vbNullString Or txtLoginPass.Text = vbNullString Or txtLoginUser.Text = vbNullString Then
            MsgBox("Please enter all login informations.", MsgBoxStyle.Critical)
            Exit Sub
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
        Me.Text = tmrTick.Interval
        Try
            Select Case tcMain.SelectedIndex
                Case 0 'Setup Tab
                    con.GetSystemStatus()

                    lblNetStatus.Text = NetStatus2String(con.SystemStatusData.net_status)
                    lblPeersConnected.Text = con.SystemStatusData.no_connected
                    lblPeersSum.Text = con.SystemStatusData.no_peers
                    lblStatDown.Text = FormatBytesPerSec(con.SystemStatusData.bw_total.down * 1024)
                    lblStatUpload.Text = FormatBytesPerSec(con.SystemStatusData.bw_total.up * 1024)
                    Debug.Print(con.SystemStatusData.bw_total.name)
                Case 1
                    con.GetTransferList()

                    lvDownList.SuspendLayout()
                    lvDownList.Items.Clear()
                    For Each item In con.TransferListData.transfers
                        lvwAddItem(lvDownList, item.file.name, item.file.size, item.state)
                    Next
                    lvDownList.ResumeLayout()
            End Select
        Catch ex As Exception

        End Try

    End Sub
End Class
