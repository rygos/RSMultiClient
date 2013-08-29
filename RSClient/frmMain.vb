Imports rsctrl.system
Imports Renci.SshNet

Public Class frmMain
    Dim con As New clsConnection("banncity.de", 8080, "ryg", "Skymaster2")

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click
        If con.Connect = True Then
            tmrTick.Enabled = True
            lblConState.Text = "Connected"
        Else
            tmrTick.Enabled = False
            lblConState.Text = "Disconnected"
        End If
    End Sub

    Private Sub frmMain_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        con.DisConnect()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblConState.Text = "Disconnected"
    End Sub

    Public Sub UpdateSystemStatus(msg As ResponseSystemStatus)
        MsgBox(msg.status)
    End Sub

    Private Sub cmdTest_Click(sender As Object, e As EventArgs) Handles cmdTest.Click
        con.getServerStatus()
    End Sub
End Class
