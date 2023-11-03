Public Class frmQuestion3

    Public Sub init()
        progressCount = 0
        tmrQuestion3.Enabled = True
        ProgressBarQ3.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False

    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnAnswer1.Checked Then
            playerScore = playerScore + 1
        End If

        frmHighScore.Show()
        frmHighScore.doScore()

        Me.Hide()
    End Sub

    Private Sub tmrQuestion3_Tick(sender As Object, e As EventArgs) Handles tmrQuestion3.Tick
        progressCount = progressCount + 1

        ProgressBarQ3.PerformStep()

        If progressCount = 10 Then
            tmrQuestion3.Enabled = False
            MsgBox("Too slow!")
            frmHighScore.Show()
            frmHighScore.doScore()
            Me.Hide()
        End If
    End Sub
End Class