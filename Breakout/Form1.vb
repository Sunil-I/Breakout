Public Class form
    Private this = Me
    Private intDx As Integer = 4
    Private intDy As Integer = 10
    Private intScore As Integer = 0
    Private intSeconds As Integer = 30
    Private lives As Integer = 5
    'CREATE ARRAY FOR BRICKS' 
    Const MaxBricks As Integer = 3
    Private picBricks(MaxBricks + 1) As PictureBox

    Private Sub MoveBall()
        PicBall.Left = PicBall.Left + intDx
        PicBall.Top = PicBall.Top + intDy

        If PicBall.Top < 0 Then
            intDy = -intDy
        End If
        If PicBall.Left < 0 Then
            intDx = -intDx
        End If
        If PicBall.Right > this.Width Then
            intDx = -intDx
        End If
        If PicBall.Bottom > this.Height Then
            intDy = -intDy
            lives = lives - 1
            PicBall.Top = this.height / 2
            lbl_lives.Text = lives

        End If
    End Sub
    Private Sub game_ticker_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles game_ticker.Tick
        Call MoveBall()
        Call ballHit()
        Call BrickHit()
        Call GameChecker()
    End Sub

    Private Sub picBat_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, picBat.Click
        picBat.Left = e.X - picBat.Width / 2

    End Sub
    Private Sub ballHit()
        If PicBall.Bounds.IntersectsWith(picBat.Bounds) Then
            intDy = -intDy


            'center diff'
            Dim interceptbat As Integer = picBat.Left + picBat.Width / 2
            Dim interceptball As Integer = PicBall.Left + PicBall.Width / 2
            Dim intDiff As Integer = interceptball - interceptbat
            intDx = intDiff
        End If
    End Sub

    Private Sub form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        picBricks(0) = Brick
        picBricks(1) = Brick1
        picBricks(2) = Brick2
        picBricks(3) = Brick3

    End Sub
    Private Sub BrickHit()
        Dim i As Integer
        For i = 0 To MaxBricks
            If PicBall.Bounds.IntersectsWith(picBricks(i).Bounds) Then

                If picBricks(i).Visible = True Then
                    picBricks(i).Visible = False
                    intDy = -intDx
                    intScore = intScore + 1
                    lbl_score.Text = intScore + 1
                End If
            End If
        Next
    End Sub
    Private Sub Gamechecker()
        If lives = 0 Then
            Call endGame()
        End If
    End Sub
    Private Sub endGame()
        lives = 5
        intScore = 0
        lbl_lives.Text = lives
        lbl_score.Text = intScore
        game_ticker.Enabled = False
        MsgBox("game over")

    End Sub
End Class

