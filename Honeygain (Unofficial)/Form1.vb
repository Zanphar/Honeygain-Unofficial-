' Honeygain (Unofficial) for Windows
' 
' This software is not meant to be anything special excep as a front-end to access
' the Honeygain Dashboard quickly and securely.
' 
' Copyright © 2021 Charles McDonald. All rights reserved.

Imports System.ComponentModel

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NotifyIcon1.Visible = False

        DelayURL.Interval = 100
        DelayURL.Enabled = True
        DelayReload.Interval = 600000
        DelayReload.Enabled = True
        AppNameVer.Text = String.Format("Honeygain (Unofficial) {0}.{1}.{2}.{3}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
        AppDescript.Text = String.Format("Honeygain is the first-ever app that allows users to make money online by sharing their internet connection. Users now can reach their networks' full potential by getting cash back to their wallets!")

        Try
            chOnTop.Checked = My.Settings.TopMost
            chWrnClose.Checked = My.Settings.WarnClose
            chkCenterStart.Checked = My.Settings.AppCenter
        Catch ex As Exception

        End Try

        For Each arg As String In My.Application.CommandLineArgs
            Select Case Trim(LCase(arg))
                Case "/nogui" '.ToLower
                    Application.Exit()
                Case "/help"
                    Process.Start("http://www.chware.net/")
            End Select
        Next

        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            'NotifyIcon1.BalloonTipText = ""
            'NotifyIcon1.BalloonTipTitle = ""
            NotifyIcon1.Visible = True
            NotifyIcon1.ShowBalloonTip(0)
            NotifyIcon1.Visible = True
        End If

    End Sub

    Private Sub onOK_Click(sender As Object, e As EventArgs) Handles onOK.Click
        Try
            Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadURL()
        webDashboard.Source = New Uri("https://dashboard.honeygain.com/")
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            If chWrnClose.Checked = True Then
                If MessageBox.Show("Are you sure you want to close this program?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    e.Cancel = True
                End If
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DelayURL_Tick(sender As Object, e As EventArgs) Handles DelayURL.Tick
        LoadURL()
        DelayURL.Enabled = False
        DelayURL.Stop()
    End Sub

    Private Sub DelayReload_Tick(sender As Object, e As EventArgs) Handles DelayReload.Tick
        LoadURL()
    End Sub

    Private Sub FusionButton1_Click(sender As Object, e As EventArgs) Handles onClose.Click
        Try
            Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Try
            Process.Start("http://www.chware.net/")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ChangeAndPersistSettings()

        My.Settings.LastChanged = DateAndTime.Today

        If chOnTop.Checked = True Then
            My.Settings.TopMost = True
            Me.TopMost = True
        Else
            My.Settings.TopMost = False
            Me.TopMost = False
        End If

        If chWrnClose.Checked = True Then
            My.Settings.WarnClose = True
        Else
            My.Settings.WarnClose = False
        End If

        If chkCenterStart.Checked = True Then
            My.Settings.AppCenter = True
            Me.CenterToScreen()
        Else
            My.Settings.AppCenter = False
        End If
        My.Settings.Save()
    End Sub

    Private Sub chWrnClose_CheckedChanged(sender As Object, e As EventArgs) Handles chWrnClose.CheckedChanged
        Try
            If chWrnClose.Checked = True Then
                chWrnClose.Checked = True
                My.Settings.WarnClose = True
            Else
                chWrnClose.Checked = False
                My.Settings.WarnClose = False
            End If
            My.Settings.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles chOnTop.CheckedChanged
        Try
            If chOnTop.Checked = True Then
                chOnTop.Checked = True
                Me.TopMost = True
                My.Settings.TopMost = True
            Else
                chOnTop.Checked = False
                Me.TopMost = False
                My.Settings.TopMost = False
            End If
            My.Settings.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkCenterStart_CheckedChanged(sender As Object, e As EventArgs) Handles chkCenterStart.CheckedChanged
        Try
            If chkCenterStart.Checked = True Then
                chkCenterStart.Checked = True
                My.Settings.AppCenter = True
                Me.CenterToScreen()
            Else
                chkCenterStart.Checked = False
                My.Settings.AppCenter = False
            End If
            My.Settings.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Try
            Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        Try
            Me.Show()
            NotifyIcon1.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub onMinimize_Click(sender As Object, e As EventArgs) Handles onMinimize.Click
        Try
            Me.Hide()
            NotifyIcon1.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
