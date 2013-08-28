Imports rsctrl.system

Public Class frmMain
    Dim con As New clsConnection("banncity.de", 8080, "ryg", "Skymaster2")

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click
        If con.Connect = True Then
            tmrTick.Enabled = True
            MsgBox("YAY")
        Else
            tmrTick.Enabled = False
            MsgBox("NOPE")
        End If
    End Sub

    Private Sub frmMain_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        con.DisConnect()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub UpdateSystemStatus(msg As ResponseSystemStatus)
        MsgBox(msg.status)
    End Sub

    Private Sub cmdTest_Click(sender As Object, e As EventArgs) Handles cmdTest.Click
        con.getServerStatus()
    End Sub
End Class
