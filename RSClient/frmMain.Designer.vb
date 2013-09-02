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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblULCaches = New System.Windows.Forms.Label()
        Me.lblDLCache = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblULCount = New System.Windows.Forms.Label()
        Me.lblDLCount = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPeersSum = New System.Windows.Forms.Label()
        Me.lblStatDown = New System.Windows.Forms.Label()
        Me.lblStatUpload = New System.Windows.Forms.Label()
        Me.lblPeersConnected = New System.Windows.Forms.Label()
        Me.lblNetStatus = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkAutoLogin = New System.Windows.Forms.CheckBox()
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
        Me.dgvDownloads = New System.Windows.Forms.DataGridView()
        Me.colFileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFileSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFinished = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHash = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvUploads = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tmrTick = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslblSysS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslblTLDL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslblTLUL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tcMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDownloads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvUploads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcMain
        '
        Me.tcMain.Controls.Add(Me.TabPage1)
        Me.tcMain.Controls.Add(Me.TabPage2)
        Me.tcMain.Controls.Add(Me.TabPage3)
        Me.tcMain.Location = New System.Drawing.Point(12, 12)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(824, 524)
        Me.tcMain.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.cmdTest)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(816, 498)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Setup"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblULCaches)
        Me.GroupBox3.Controls.Add(Me.lblDLCache)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.lblULCount)
        Me.GroupBox3.Controls.Add(Me.lblDLCount)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 187)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(429, 77)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Statistics"
        '
        'lblULCaches
        '
        Me.lblULCaches.AutoSize = True
        Me.lblULCaches.Location = New System.Drawing.Point(316, 48)
        Me.lblULCaches.Name = "lblULCaches"
        Me.lblULCaches.Size = New System.Drawing.Size(10, 13)
        Me.lblULCaches.TabIndex = 10
        Me.lblULCaches.Text = "-"
        '
        'lblDLCache
        '
        Me.lblDLCache.AutoSize = True
        Me.lblDLCache.Location = New System.Drawing.Point(316, 22)
        Me.lblDLCache.Name = "lblDLCache"
        Me.lblDLCache.Size = New System.Drawing.Size(10, 13)
        Me.lblDLCache.TabIndex = 9
        Me.lblDLCache.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(212, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Caches:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(212, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Caches:"
        '
        'lblULCount
        '
        Me.lblULCount.AutoSize = True
        Me.lblULCount.Location = New System.Drawing.Point(91, 48)
        Me.lblULCount.Name = "lblULCount"
        Me.lblULCount.Size = New System.Drawing.Size(10, 13)
        Me.lblULCount.TabIndex = 6
        Me.lblULCount.Text = "-"
        '
        'lblDLCount
        '
        Me.lblDLCount.AutoSize = True
        Me.lblDLCount.Location = New System.Drawing.Point(91, 22)
        Me.lblDLCount.Name = "lblDLCount"
        Me.lblDLCount.Size = New System.Drawing.Size(10, 13)
        Me.lblDLCount.TabIndex = 5
        Me.lblDLCount.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Uploads:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Donwloads:"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(141, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "of"
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
        Me.GroupBox1.Controls.Add(Me.chkAutoLogin)
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
        Me.GroupBox1.Size = New System.Drawing.Size(200, 175)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'chkAutoLogin
        '
        Me.chkAutoLogin.AutoSize = True
        Me.chkAutoLogin.Location = New System.Drawing.Point(94, 152)
        Me.chkAutoLogin.Name = "chkAutoLogin"
        Me.chkAutoLogin.Size = New System.Drawing.Size(70, 17)
        Me.chkAutoLogin.TabIndex = 10
        Me.chkAutoLogin.Text = "Autologin"
        Me.chkAutoLogin.UseVisualStyleBackColor = True
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
        Me.txtLoginPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
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
        Me.cmdTest.Location = New System.Drawing.Point(677, 469)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(75, 23)
        Me.cmdTest.TabIndex = 1
        Me.cmdTest.Text = "Test"
        Me.cmdTest.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvDownloads)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(816, 498)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "FileDownloads"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvDownloads
        '
        Me.dgvDownloads.AllowUserToAddRows = False
        Me.dgvDownloads.AllowUserToDeleteRows = False
        Me.dgvDownloads.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDownloads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDownloads.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFileName, Me.colFileSize, Me.colFinished, Me.colRate, Me.colState, Me.colHash})
        Me.dgvDownloads.Location = New System.Drawing.Point(3, 3)
        Me.dgvDownloads.MultiSelect = False
        Me.dgvDownloads.Name = "dgvDownloads"
        Me.dgvDownloads.Size = New System.Drawing.Size(810, 450)
        Me.dgvDownloads.TabIndex = 0
        '
        'colFileName
        '
        Me.colFileName.HeaderText = "Filename"
        Me.colFileName.Name = "colFileName"
        Me.colFileName.Width = 74
        '
        'colFileSize
        '
        Me.colFileSize.HeaderText = "Filesize"
        Me.colFileSize.Name = "colFileSize"
        Me.colFileSize.Width = 66
        '
        'colFinished
        '
        Me.colFinished.HeaderText = "Finished"
        Me.colFinished.Name = "colFinished"
        Me.colFinished.Width = 71
        '
        'colRate
        '
        Me.colRate.HeaderText = "Rate (KiB/s)"
        Me.colRate.Name = "colRate"
        Me.colRate.ReadOnly = True
        Me.colRate.Width = 90
        '
        'colState
        '
        Me.colState.HeaderText = "State"
        Me.colState.Name = "colState"
        Me.colState.Width = 57
        '
        'colHash
        '
        Me.colHash.HeaderText = "Hash"
        Me.colHash.Name = "colHash"
        Me.colHash.Width = 57
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvUploads)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(816, 498)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "FileUploads"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvUploads
        '
        Me.dgvUploads.AllowUserToAddRows = False
        Me.dgvUploads.AllowUserToDeleteRows = False
        Me.dgvUploads.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvUploads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUploads.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgvUploads.Location = New System.Drawing.Point(3, 3)
        Me.dgvUploads.MultiSelect = False
        Me.dgvUploads.Name = "dgvUploads"
        Me.dgvUploads.Size = New System.Drawing.Size(810, 450)
        Me.dgvUploads.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Filename"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 74
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Filesize"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 66
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Finished"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 71
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Rate (KiB/s)"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "State"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 57
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Hash"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 57
        '
        'tmrTick
        '
        Me.tmrTick.Interval = 1000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslblSysS, Me.tslblTLDL, Me.tslblTLUL})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 547)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(848, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslblSysS
        '
        Me.tslblSysS.Name = "tslblSysS"
        Me.tslblSysS.Size = New System.Drawing.Size(30, 17)
        Me.tslblSysS.Text = "SysS"
        '
        'tslblTLDL
        '
        Me.tslblTLDL.Name = "tslblTLDL"
        Me.tslblTLDL.Size = New System.Drawing.Size(34, 17)
        Me.tslblTLDL.Text = "TLDL"
        '
        'tslblTLUL
        '
        Me.tslblTLUL.Name = "tslblTLUL"
        Me.tslblTLUL.Size = New System.Drawing.Size(34, 17)
        Me.tslblTLUL.Text = "TLUL"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 569)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tcMain)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.tcMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvDownloads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvUploads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dgvDownloads As System.Windows.Forms.DataGridView
    Friend WithEvents colFileName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFileSize As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFinished As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHash As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblULCaches As System.Windows.Forms.Label
    Friend WithEvents lblDLCache As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblULCount As System.Windows.Forms.Label
    Friend WithEvents lblDLCount As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgvUploads As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkAutoLogin As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tslblSysS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslblTLDL As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslblTLUL As System.Windows.Forms.ToolStripStatusLabel

End Class
