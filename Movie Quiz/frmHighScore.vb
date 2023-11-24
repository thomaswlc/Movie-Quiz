Public Class frmHighScore
    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        frmMain.Show()
        Me.Hide()
    End Sub
    Public Sub doScore()
        If playerScore < 1 Then
            lblMessage.Text = "Sorry, your score was not good enough!"
        Else
            lblMessage.Text = "Congratulatons! Your score will be added to the Hall of Fame!"
            lstHighScore.Items.Add(playerName & vbTab & playerScore)
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub frmHighScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
