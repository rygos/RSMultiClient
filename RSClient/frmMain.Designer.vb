<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPeersSum = New System.Windows.Forms.Label()
        Me.lblStatDown = New System.Windows.Forms.Label()
        Me.lblStatUpload = New System.Windows.Forms.Label()
        Me.lblPeersConnected = New System.Windows.Forms.Label()
        Me.lblNetStatus = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmdConnect = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLoginPass = New System.Windows.Forms.TextBox()
        Me.txtLoginUser = New System.Windows.Forms.TextBox()
        Me.txtLoginPort = New System.Windows.Forms.TextBox()
        Me.txtLoginHost = New System.Windows.Forms.TextBox()
        Me.cmdTest = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tmrTick = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lvDownList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tcMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcMain
        '
        Me.tcMain.Controls.Add(Me.TabPage1)
        Me.tcMain.Controls.Add(Me.TabPage2)
        Me.tcMain.Location = New System.Drawing.Point(12, 12)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(628, 419)
        Me.tcMain.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.cmdTest)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(620, 393)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Setup"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblPeersSum)
        Me.GroupBox2.Controls.Add(Me.lblStatDown)
        Me.GroupBox2.Controls.Add(Me.lblStatUpload)
        Me.GroupBox2.Controls.Add(Me.lblPeersConnected)
        Me.GroupBox2.Controls.Add(Me.lblNetStatus)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(212, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 156)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "System Informations"
        '
        'lblPeersSum
        '
        Me.lblPeersSum.AutoSize = True
        Me.lblPeersSum.Location = New System.Drawing.Point(161, 48)
        Me.lblPeersSum.Name = "lblPeersSum"
        Me.lblPeersSum.Size = New System.Drawing.Size(13, 13)
        Me.lblPeersSum.TabIndex = 8
        Me.lblPeersSum.Text = "0"
        '
        'lblStatDown
        '
        Me.lblStatDown.AutoSize = True
        Me.lblStatDown.Location = New System.Drawing.Point(110, 100)
        Me.lblStatDown.Name = "lblStatDown"
        Me.lblStatDown.Size = New System.Drawing.Size(48, 13)
        Me.lblStatDown.TabIndex = 7
        Me.lblStatDown.Text = "0,00 B/s"
        '
        'lblStatUpload
        '
        Me.lblStatUpload.AutoSize = True
        Me.lblStatUpload.Location = New System.Drawing.Point(110, 74)
        Me.lblStatUpload.Name = "lblStatUpload"
        Me.lblStatUpload.Size = New System.Drawing.Size(48, 13)
        Me.lblStatUpload.TabIndex = 6
        Me.lblStatUpload.Text = "0,00 B/s"
        '
        'lblPeersConnected
        '
        Me.lblPeersConnected.AutoSize = True
        Me.lblPeersConnected.Location = New System.Drawing.Point(110, 48)
        Me.lblPeersConnected.Name = "lblPeersConnected"
        Me.lblPeersConnected.Size = New System.Drawing.Size(13, 13)
        Me.lblPeersConnected.TabIndex = 5
        Me.lblPeersConnected.Text = "0"
        '
        'lblNetStatus
        '
        Me.lblNetStatus.AutoSize = True
        Me.lblNetStatus.Location = New System.Drawing.Point(110, 22)
        Me.lblNetStatus.Name = "lblNetStatus"
        Me.lblNetStatus.Size = New System.Drawing.Size(16, 13)
        Me.lblNetStatus.TabIndex = 4
        Me.lblNetStatus.Text = "..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Up/Down:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Peers:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Network:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.cmdConnect)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtLoginPass)
        Me.GroupBox1.Controls.Add(Me.txtLoginUser)
        Me.GroupBox1.Controls.Add(Me.txtLoginPort)
        Me.GroupBox1.Controls.Add(Me.txtLoginHost)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 156)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(94, 126)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(100, 23)
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.Text = "-----"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdConnect
        '
        Me.cmdConnect.Location = New System.Drawing.Point(9, 126)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(75, 23)
        Me.cmdConnect.TabIndex = 8
        Me.cmdConnect.Text = "Connect"
        Me.cmdConnect.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "User:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Port:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Host:"
        '
        'txtLoginPass
        '
        Me.txtLoginPass.Location = New System.Drawing.Point(94, 97)
        Me.txtLoginPass.Name = "txtLoginPass"
        Me.txtLoginPass.Size = New System.Drawing.Size(100, 20)
        Me.txtLoginPass.TabIndex = 3
        '
        'txtLoginUser
        '
        Me.txtLoginUser.Location = New System.Drawing.Point(94, 71)
        Me.txtLoginUser.Name = "txtLoginUser"
        Me.txtLoginUser.Size = New System.Drawing.Size(100, 20)
        Me.txtLoginUser.TabIndex = 2
        '
        'txtLoginPort
        '
        Me.txtLoginPort.Location = New System.Drawing.Point(94, 45)
        Me.txtLoginPort.Name = "txtLoginPort"
        Me.txtLoginPort.Size = New System.Drawing.Size(100, 20)
        Me.txtLoginPort.TabIndex = 1
        '
        'txtLoginHost
        '
        Me.txtLoginHost.Location = New System.Drawing.Point(94, 19)
        Me.txtLoginHost.Name = "txtLoginHost"
        Me.txtLoginHost.Size = New System.Drawing.Size(100, 20)
        Me.txtLoginHost.TabIndex = 0
        '
        'cmdTest
        '
        Me.cmdTest.Location = New System.Drawing.Point(539, 364)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(75, 23)
        Me.cmdTest.TabIndex = 1
        Me.cmdTest.Text = "Test"
        Me.cmdTest.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvDownList)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(620, 393)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Files"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tmrTick
        '
        Me.tmrTick.Interval = 1000
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(141, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "of"
        '
        'lvDownList
        '
        Me.lvDownList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvDownList.Location = New System.Drawing.Point(6, 6)
        Me.lvDownList.Name = "lvDownList"
        Me.lvDownList.Size = New System.Drawing.Size(608, 381)
        Me.lvDownList.TabIndex = 0
        Me.lvDownList.UseCompatibleStateImageBehavior = False
        Me.lvDownList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Filename"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Filesize"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "State"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 443)
        Me.Controls.Add(Me.tcMain)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.tcMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcMain As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tmrTick As System.Windows.Forms.Timer
    Friend WithEvents cmdTest As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cmdConnect As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLoginPass As System.Windows.Forms.TextBox
    Friend WithEvents txtLoginUser As System.Windows.Forms.TextBox
    Friend WithEvents txtLoginPort As System.Windows.Forms.TextBox
    Friend WithEvents txtLoginHost As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatDown As System.Windows.Forms.Label
    Friend WithEvents lblStatUpload As System.Windows.Forms.Label
    Friend WithEvents lblPeersConnected As System.Windows.Forms.Label
    Friend WithEvents lblNetStatus As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblPeersSum As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lvDownList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader

End Class
