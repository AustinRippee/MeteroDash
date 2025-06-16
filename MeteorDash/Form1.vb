Public Class Form1
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData

            Case Keys.Right
                pbxSpaceShip.Left += 133
                If pbxSpaceShip.Left < 0 Then
                    pbxSpaceShip.Left = 0
                End If
                If pbxSpaceShip.Left > 800 Then
                    pbxSpaceShip.Left = 800
                End If
                Return True


            Case Keys.Left
                pbxSpaceShip.Left -= 133
                If pbxSpaceShip.Left < 0 Then
                    pbxSpaceShip.Left = 0
                End If
                If pbxSpaceShip.Left > 800 Then
                    pbxSpaceShip.Left = 800
                End If
                Return True

        End Select

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Dim rock As Integer
    Dim speed As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rock1.Visible = False
        rock2.Visible = False
        rock3.Visible = False
        rock4.Visible = False
        rock5.Visible = False
        rock6.Visible = False
        rock7.Visible = False
        pbxSpaceShip.Visible = False
        lblLives.Visible = False
        lblLivesText.Visible = False
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click


        lblTitle.Visible = False
        btnPlay.Visible = False
        pbxSpaceShip.Visible = True
        lblLives.Visible = True
        lblLivesText.Visible = True
        lblLives.Text = "3"
        startRocks()



    End Sub
    Private Sub startRocks()
        'rock 1
        speed = CInt(Int((200 * Rnd()) + 200))
        rock1.Visible = True
        rock1.Top = 0
        timerRock1.Interval = speed
        timerRock1.Start()

        'rock 2
        speed = CInt(Int((200 * Rnd()) + 200))
        rock2.Visible = True
        rock2.Top = 0
        timerRock2.Interval = speed
        timerRock2.Start()
        'rock3
        speed = CInt(Int((200 * Rnd()) + 200))
        rock3.Visible = True
        rock3.Top = 0
        timerRock3.Interval = speed
        timerRock3.Start()
        'rock 4
        speed = CInt(Int((200 * Rnd()) + 200))
        rock4.Visible = True
        rock4.Top = 0
        timerRock4.Interval = speed
        timerRock4.Start()
        'rock 5
        speed = CInt(Int((200 * Rnd()) + 200))
        rock5.Visible = True
        rock5.Top = 0
        timerRock5.Interval = speed
        timerRock5.Start()
        'rock 6
        speed = CInt(Int((200 * Rnd()) + 200))
        rock6.Visible = True
        rock6.Top = 0
        timerRock6.Interval = speed
        timerRock6.Start()
        'rock 7
        speed = CInt(Int((200 * Rnd()) + 200))
        rock7.Visible = True
        rock7.Top = 0
        timerRock7.Interval = speed
        timerRock7.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timerRock1.Tick
        rock1.Top = rock1.Top + 20
        If rock1.Top >= 800 Then
            rock1.Top = 0
            speed = CInt(Int((200 * Rnd()) + 200))
            timerRock1.Interval = speed


        End If

        If rock1.Bounds.IntersectsWith(pbxSpaceShip.Bounds) Then
            timerRock1.Stop()
            timerRock2.Stop()
            timerRock3.Stop()
            timerRock4.Stop()
            timerRock5.Stop()
            timerRock6.Stop()
            timerRock7.Stop()
            If lblLives.Text = "3" Then
                MsgBox("You now have 2 lives remaining")
                lblLives.Text = "2"
            ElseIf lblLives.Text = "2" Then
                MsgBox("You now have 1 life remaining")
                lblLives.Text = "1"
            ElseIf lblLives.Text = "1" Then
                lblLives.Text = "0"
                MsgBox("You Lose")
                Me.Close()
            End If
            startRocks()
        End If

    End Sub

    Private Sub timerRock2_Tick(sender As Object, e As EventArgs) Handles timerRock2.Tick
        rock2.Top = rock2.Top + 20
        If rock2.Top >= 800 Then
            rock2.Top = 0
            speed = CInt(Int((200 * Rnd()) + 200))
            timerRock2.Interval = speed
        End If
        If rock2.Bounds.IntersectsWith(pbxSpaceShip.Bounds) Then
            timerRock1.Stop()
            timerRock2.Stop()
            timerRock3.Stop()
            timerRock4.Stop()
            timerRock5.Stop()
            timerRock6.Stop()
            timerRock7.Stop()
            If lblLives.Text = "3" Then
                MsgBox("You now have 2 lives remaining")
                lblLives.Text = "2"
            ElseIf lblLives.Text = "2" Then
                MsgBox("You now have 1 life remaining")
                lblLives.Text = "1"
            ElseIf lblLives.Text = "1" Then
                lblLives.Text = "0"
                MsgBox("You Lose")
                Me.Close()
            End If
            startRocks()
        End If
    End Sub

    Private Sub timerRock3_Tick(sender As Object, e As EventArgs) Handles timerRock3.Tick
        rock3.Top = rock3.Top + 20
        If rock3.Top >= 800 Then
            rock3.Top = 0
            speed = CInt(Int((200 * Rnd()) + 200))
            timerRock3.Interval = speed
        End If
        If rock3.Bounds.IntersectsWith(pbxSpaceShip.Bounds) Then
            timerRock1.Stop()
            timerRock2.Stop()
            timerRock3.Stop()
            timerRock4.Stop()
            timerRock5.Stop()
            timerRock6.Stop()
            timerRock7.Stop()
            If lblLives.Text = "3" Then
                MsgBox("You now have 2 lives remaining")
                lblLives.Text = "2"
            ElseIf lblLives.Text = "2" Then
                MsgBox("You now have 1 life remaining")
                lblLives.Text = "1"
            ElseIf lblLives.Text = "1" Then
                lblLives.Text = "0"
                MsgBox("You Lose")
                Me.Close()
            End If
            startRocks()
        End If
    End Sub

    Private Sub timerRock4_Tick(sender As Object, e As EventArgs) Handles timerRock4.Tick
        rock4.Top = rock4.Top + 20
        If rock4.Top >= 800 Then
            rock4.Top = 0
            speed = CInt(Int((200 * Rnd()) + 200))
            timerRock4.Interval = speed
        End If
        If rock4.Bounds.IntersectsWith(pbxSpaceShip.Bounds) Then
            timerRock1.Stop()
            timerRock2.Stop()
            timerRock3.Stop()
            timerRock4.Stop()
            timerRock5.Stop()
            timerRock6.Stop()
            timerRock7.Stop()
            If lblLives.Text = "3" Then
                MsgBox("You now have 2 lives remaining")
                lblLives.Text = "2"
            ElseIf lblLives.Text = "2" Then
                MsgBox("You now have 1 life remaining")
                lblLives.Text = "1"
            ElseIf lblLives.Text = "1" Then
                lblLives.Text = "0"
                MsgBox("You Lose")
                Me.Close()
            End If
            startRocks()
        End If
    End Sub

    Private Sub timerRock5_Tick(sender As Object, e As EventArgs) Handles timerRock5.Tick
        rock5.Top = rock5.Top + 20
        If rock5.Top >= 800 Then
            rock5.Top = 0
            speed = CInt(Int((200 * Rnd()) + 200))
            timerRock5.Interval = speed
        End If
        If rock5.Bounds.IntersectsWith(pbxSpaceShip.Bounds) Then
            timerRock1.Stop()
            timerRock2.Stop()
            timerRock3.Stop()
            timerRock4.Stop()
            timerRock5.Stop()
            timerRock6.Stop()
            timerRock7.Stop()
            If lblLives.Text = "3" Then
                MsgBox("You now have 2 lives remaining")
                lblLives.Text = "2"
            ElseIf lblLives.Text = "2" Then
                MsgBox("You now have 1 life remaining")
                lblLives.Text = "1"
            ElseIf lblLives.Text = "1" Then
                lblLives.Text = "0"
                MsgBox("You Lose")
                Me.Close()
            End If
            startRocks()
        End If
    End Sub

    Private Sub timerRock6_Tick(sender As Object, e As EventArgs) Handles timerRock6.Tick
        rock6.Top = rock6.Top + 20
        If rock6.Top >= 800 Then
            rock6.Top = 0
            speed = CInt(Int((200 * Rnd()) + 200))
            timerRock6.Interval = speed
        End If
        If rock6.Bounds.IntersectsWith(pbxSpaceShip.Bounds) Then
            timerRock1.Stop()
            timerRock2.Stop()
            timerRock3.Stop()
            timerRock4.Stop()
            timerRock5.Stop()
            timerRock6.Stop()
            timerRock7.Stop()
            If lblLives.Text = "3" Then
                MsgBox("You now have 2 lives remaining")
                lblLives.Text = "2"
            ElseIf lblLives.Text = "2" Then
                MsgBox("You now have 1 life remaining")
                lblLives.Text = "1"
            ElseIf lblLives.Text = "1" Then
                lblLives.Text = "0"
                MsgBox("You Lose")
                Me.Close()
            End If
            startRocks()
        End If
    End Sub

    Private Sub timerRock7_Tick(sender As Object, e As EventArgs) Handles timerRock7.Tick
        rock7.Top = rock7.Top + 20
        If rock7.Top >= 800 Then
            rock7.Top = 0
            speed = CInt(Int((200 * Rnd()) + 200))
            timerRock7.Interval = speed
        End If
        If rock7.Bounds.IntersectsWith(pbxSpaceShip.Bounds) Then
            timerRock1.Stop()
            timerRock2.Stop()
            timerRock3.Stop()
            timerRock4.Stop()
            timerRock5.Stop()
            timerRock6.Stop()
            timerRock7.Stop()
            If lblLives.Text = "3" Then
                MsgBox("You now have 2 lives remaining")
                lblLives.Text = "2"
            ElseIf lblLives.Text = "2" Then
                MsgBox("You now have 1 life remaining")
                lblLives.Text = "1"
            ElseIf lblLives.Text = "1" Then
                lblLives.Text = "0"
                MsgBox("You Lose")
                Me.Close()
            End If
            startRocks()
        End If
    End Sub
End Class
