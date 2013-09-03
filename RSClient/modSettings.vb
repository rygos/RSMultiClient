Module modSettings
    Public Sub OptionsSave()
        My.Settings("host") = frmMain.txtLoginHost
        My.Settings("port") = frmMain.txtLoginPort
        My.Settings("user") = frmMain.txtLoginUser
        My.Settings("pass") = frmMain.txtLoginPass
        My.Settings("auto") = frmMain.chkAutoLogin.Checked
        My.Settings.Save()
    End Sub

    Public Sub OptionsLoad()
        Try
            With frmMain
                .txtLoginHost.Text = My.Settings("host")
                .txtLoginPort.Text = My.Settings("port")
                .txtLoginUser.Text = My.Settings("user")
                .txtLoginPass.Text = My.Settings("pass")
                .chkAutoLogin.Checked = My.Settings("auto")
            End With
        Catch ex As Exception

        End Try

    End Sub
End Module
