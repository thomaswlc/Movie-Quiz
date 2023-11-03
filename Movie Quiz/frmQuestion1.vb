Public Class frmQuestion1

    Public Sub init()
        progressCount = 0
        tmrQuestion1.Enabled = True
        ProgressBarQ1.Value = 0
        frmMain.playTrack("Question 1.mp3")
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnAnswer3.Checked Then
            playerScore = playerScore + 1
        End If

        frmMain.stopTrack()
        frmQuestion2.Show()

        Me.Hide()
    End Sub

    Private Sub tmrQuestion1_Tick(sender As Object, e As EventArgs) Handles tmrQuestion1.Tick
        progressCount = progressCount + 1

        ProgressBarQ1.PerformStep()

        If progressCount = 10 Then
            tmrQuestion1.Enabled = False
            MsgBox("Too slow!")
            frmMain.stopTrack()
            frmQuestion2.Show()
            frmQuestion2.init()
            Me.Hide()
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnAnswer3_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer3.CheckedChanged

    End Sub
End Class