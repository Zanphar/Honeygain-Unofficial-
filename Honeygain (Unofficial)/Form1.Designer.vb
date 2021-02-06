<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim Bloom1 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Dim Bloom2 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Dim Bloom3 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Dim Bloom4 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Dim Bloom5 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Dim Bloom6 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Dim Bloom7 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Dim Bloom8 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Dim Bloom9 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Dim Bloom10 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Dim Bloom11 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Dim Bloom12 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Dim Bloom13 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Dim Bloom14 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Dim Bloom15 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Dim Bloom16 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Dim Bloom17 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Dim Bloom18 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Dim Bloom19 As Honeygain__Unofficial_.Bloom = New Honeygain__Unofficial_.Bloom()
        Me.DelayURL = New System.Windows.Forms.Timer(Me.components)
        Me.DelayReload = New System.Windows.Forms.Timer(Me.components)
        Me.tControl = New Honeygain__Unofficial_.AresioTabControl()
        Me.tDashboard = New System.Windows.Forms.TabPage()
        Me.webDashboard = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.tSettings = New System.Windows.Forms.TabPage()
        Me.chkCenterStart = New System.Windows.Forms.CheckBox()
        Me.chWrnClose = New System.Windows.Forms.CheckBox()
        Me.chOnTop = New System.Windows.Forms.CheckBox()
        Me.tAbout = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AppDescript = New System.Windows.Forms.Label()
        Me.AppNameVer = New System.Windows.Forms.Label()
        Me.onOK = New Honeygain__Unofficial_.AresioButton()
        Me.MainTheme = New Honeygain__Unofficial_.FusionTheme()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.onClose = New Honeygain__Unofficial_.FusionButton()
        Me.tControl.SuspendLayout()
        Me.tDashboard.SuspendLayout()
        CType(Me.webDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tSettings.SuspendLayout()
        Me.tAbout.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainTheme.SuspendLayout()
        Me.SuspendLayout()
        '
        'DelayURL
        '
        '
        'DelayReload
        '
        '
        'tControl
        '
        Me.tControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tControl.Controls.Add(Me.tDashboard)
        Me.tControl.Controls.Add(Me.tSettings)
        Me.tControl.Controls.Add(Me.tAbout)
        Me.tControl.ItemSize = New System.Drawing.Size(77, 31)
        Me.tControl.Location = New System.Drawing.Point(12, 37)
        Me.tControl.Name = "tControl"
        Me.tControl.SelectedIndex = 0
        Me.tControl.Size = New System.Drawing.Size(1000, 719)
        Me.tControl.TabIndex = 0
        '
        'tDashboard
        '
        Me.tDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.tDashboard.Controls.Add(Me.webDashboard)
        Me.tDashboard.Location = New System.Drawing.Point(4, 35)
        Me.tDashboard.Name = "tDashboard"
        Me.tDashboard.Padding = New System.Windows.Forms.Padding(3)
        Me.tDashboard.Size = New System.Drawing.Size(992, 680)
        Me.tDashboard.TabIndex = 0
        Me.tDashboard.Text = "Dashboard"
        '
        'webDashboard
        '
        Me.webDashboard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webDashboard.BackColor = System.Drawing.Color.Gold
        Me.webDashboard.CreationProperties = Nothing
        Me.webDashboard.Location = New System.Drawing.Point(3, 3)
        Me.webDashboard.Name = "webDashboard"
        Me.webDashboard.Size = New System.Drawing.Size(1002, 681)
        Me.webDashboard.TabIndex = 4
        Me.webDashboard.ZoomFactor = 1.0R
        '
        'tSettings
        '
        Me.tSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.tSettings.Controls.Add(Me.chkCenterStart)
        Me.tSettings.Controls.Add(Me.chWrnClose)
        Me.tSettings.Controls.Add(Me.chOnTop)
        Me.tSettings.Location = New System.Drawing.Point(4, 35)
        Me.tSettings.Name = "tSettings"
        Me.tSettings.Size = New System.Drawing.Size(992, 680)
        Me.tSettings.TabIndex = 2
        Me.tSettings.Text = "Settings"
        '
        'chkCenterStart
        '
        Me.chkCenterStart.AutoSize = True
        Me.chkCenterStart.Location = New System.Drawing.Point(23, 139)
        Me.chkCenterStart.Name = "chkCenterStart"
        Me.chkCenterStart.Size = New System.Drawing.Size(310, 17)
        Me.chkCenterStart.TabIndex = 2
        Me.chkCenterStart.Text = "&Start in the center of the desktop on each launch."
        Me.chkCenterStart.UseVisualStyleBackColor = True
        '
        'chWrnClose
        '
        Me.chWrnClose.AutoSize = True
        Me.chWrnClose.Location = New System.Drawing.Point(23, 116)
        Me.chWrnClose.Name = "chWrnClose"
        Me.chWrnClose.Size = New System.Drawing.Size(232, 17)
        Me.chWrnClose.TabIndex = 1
        Me.chWrnClose.Text = "&Warn before closing this application."
        Me.chWrnClose.UseVisualStyleBackColor = True
        '
        'chOnTop
        '
        Me.chOnTop.AutoSize = True
        Me.chOnTop.Location = New System.Drawing.Point(23, 93)
        Me.chOnTop.Name = "chOnTop"
        Me.chOnTop.Size = New System.Drawing.Size(219, 17)
        Me.chOnTop.TabIndex = 0
        Me.chOnTop.Text = "&Keep on top of other applications."
        Me.chOnTop.UseVisualStyleBackColor = True
        '
        'tAbout
        '
        Me.tAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.tAbout.Controls.Add(Me.PictureBox1)
        Me.tAbout.Controls.Add(Me.AppDescript)
        Me.tAbout.Controls.Add(Me.AppNameVer)
        Me.tAbout.Controls.Add(Me.onOK)
        Me.tAbout.Location = New System.Drawing.Point(4, 35)
        Me.tAbout.Name = "tAbout"
        Me.tAbout.Padding = New System.Windows.Forms.Padding(3)
        Me.tAbout.Size = New System.Drawing.Size(992, 680)
        Me.tAbout.TabIndex = 1
        Me.tAbout.Text = "About"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(192, 92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(596, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'AppDescript
        '
        Me.AppDescript.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppDescript.Location = New System.Drawing.Point(189, 214)
        Me.AppDescript.Name = "AppDescript"
        Me.AppDescript.Size = New System.Drawing.Size(599, 90)
        Me.AppDescript.TabIndex = 3
        Me.AppDescript.Text = "Honeygain is the first-ever app that allows users to make money online by sharing" &
    " their internet connection. Users now can reach their networks' full potential b" &
    "y getting cash back to their wallets!"
        Me.AppDescript.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AppNameVer
        '
        Me.AppNameVer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppNameVer.Location = New System.Drawing.Point(189, 175)
        Me.AppNameVer.Name = "AppNameVer"
        Me.AppNameVer.Size = New System.Drawing.Size(599, 20)
        Me.AppNameVer.TabIndex = 2
        Me.AppNameVer.Text = "Honeygain (Unofficial) ###.###.###"
        Me.AppNameVer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'onOK
        '
        Me.onOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.onOK.Location = New System.Drawing.Point(459, 329)
        Me.onOK.Name = "onOK"
        Me.onOK.Size = New System.Drawing.Size(75, 23)
        Me.onOK.TabIndex = 0
        Me.onOK.Text = "Close"
        '
        'MainTheme
        '
        Me.MainTheme.BackColor = System.Drawing.Color.White
        Me.MainTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Bloom1.Name = "Sides"
        Bloom1.Value = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer))
        Bloom2.Name = "Gradient1"
        Bloom2.Value = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(55, Byte), Integer))
        Bloom3.Name = "Gradient2"
        Bloom3.Value = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer))
        Bloom4.Name = "Text"
        Bloom4.Value = System.Drawing.Color.White
        Bloom5.Name = "Back"
        Bloom5.Value = System.Drawing.Color.White
        Bloom6.Name = "Border1"
        Bloom6.Value = System.Drawing.Color.Black
        Bloom7.Name = "Border2"
        Bloom7.Value = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer))
        Bloom8.Name = "Border3"
        Bloom8.Value = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer))
        Bloom9.Name = "Border4"
        Bloom9.Value = System.Drawing.Color.Black
        Bloom10.Name = "Blend1"
        Bloom10.Value = System.Drawing.Color.Transparent
        Bloom11.Name = "Blend2"
        Bloom11.Value = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.MainTheme.Colors = New Honeygain__Unofficial_.Bloom() {Bloom1, Bloom2, Bloom3, Bloom4, Bloom5, Bloom6, Bloom7, Bloom8, Bloom9, Bloom10, Bloom11}
        Me.MainTheme.Controls.Add(Me.Label1)
        Me.MainTheme.Controls.Add(Me.onClose)
        Me.MainTheme.Controls.Add(Me.tControl)
        Me.MainTheme.Customization = "Mi8v/zc0NP8yLy////////////8AAAD/Pzw8/z88PP8AAAD/////AD88PP8="
        Me.MainTheme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTheme.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.MainTheme.Image = CType(resources.GetObject("MainTheme.Image"), System.Drawing.Image)
        Me.MainTheme.Location = New System.Drawing.Point(0, 0)
        Me.MainTheme.Movable = True
        Me.MainTheme.Name = "MainTheme"
        Me.MainTheme.NoRounding = False
        Me.MainTheme.Sizable = True
        Me.MainTheme.Size = New System.Drawing.Size(1024, 768)
        Me.MainTheme.SmartBounds = True
        Me.MainTheme.TabIndex = 1
        Me.MainTheme.Text = "Honeygain (Unofficial)"
        Me.MainTheme.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(597, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Copyright © 2021 Charles McDonald. All rights reserved."
        '
        'onClose
        '
        Bloom12.Name = "DownGradient1"
        Bloom12.Value = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(1, Byte), Integer))
        Bloom13.Name = "DownGradient2"
        Bloom13.Value = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(12, Byte), Integer))
        Bloom14.Name = "NoneGradient1"
        Bloom14.Value = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(12, Byte), Integer))
        Bloom15.Name = "NoneGradient2"
        Bloom15.Value = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(1, Byte), Integer))
        Bloom16.Name = "TextShade"
        Bloom16.Value = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Bloom17.Name = "Text"
        Bloom17.Value = System.Drawing.Color.White
        Bloom18.Name = "Border1"
        Bloom18.Value = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(19, Byte), Integer))
        Bloom19.Name = "Border2"
        Bloom19.Value = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.onClose.Colors = New Honeygain__Unofficial_.Bloom() {Bloom12, Bloom13, Bloom14, Bloom15, Bloom16, Bloom17, Bloom18, Bloom19}
        Me.onClose.Customization = "AX///wyv//8Mr///AX///wAAAB7/////E8X//wCF/v8="
        Me.onClose.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.onClose.Image = Nothing
        Me.onClose.Location = New System.Drawing.Point(937, 6)
        Me.onClose.Name = "onClose"
        Me.onClose.NoRounding = False
        Me.onClose.Size = New System.Drawing.Size(75, 23)
        Me.onClose.TabIndex = 1
        Me.onClose.Text = "X"
        Me.onClose.Transparent = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.MainTheme)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "="
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.tControl.ResumeLayout(False)
        Me.tDashboard.ResumeLayout(False)
        CType(Me.webDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tSettings.ResumeLayout(False)
        Me.tSettings.PerformLayout()
        Me.tAbout.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainTheme.ResumeLayout(False)
        Me.MainTheme.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents tControl As AresioTabControl
    Friend WithEvents tDashboard As TabPage
    Friend WithEvents tAbout As TabPage
    Friend WithEvents onOK As AresioButton
    Friend WithEvents AppNameVer As Label
    Friend WithEvents webDashboard As Microsoft.Web.WebView2.WinForms.WebView2

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Friend WithEvents DelayURL As Timer
    Friend WithEvents DelayReload As Timer
    Friend WithEvents AppDescript As Label
    Friend WithEvents MainTheme As FusionTheme
    Friend WithEvents onClose As FusionButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tSettings As TabPage
    Friend WithEvents chWrnClose As CheckBox
    Friend WithEvents chOnTop As CheckBox
    Friend WithEvents chkCenterStart As CheckBox
End Class
