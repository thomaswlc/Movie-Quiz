﻿Public Class frmMain
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        playerScore = 0
        playerName = txtPlayerName.Text
        frmQuestion1.Show()
        frmQuestion1.init()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Public Sub playTrack(ByVal track As String)

        wmpQuiz.Ctlcontrols.stop()
        wmpQuiz.URL = track
        wmpQuiz.Ctlcontrols.play()
    End Sub
    Public Sub stopTrack()
        wmpQuiz.Ctlcontrols.stop()
    End Sub
End Class