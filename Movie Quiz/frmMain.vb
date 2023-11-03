Public Class frmMain
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

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

        Public Sub stopTrack()
        wmpQuiz.Ctlcontrols.stop()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class