Public Class game1
    Private source As PictureBox = Nothing
    Dim time As Integer = 1
    Dim score As Integer = 0
    Dim num_of_star As Integer
    Dim timeleft As Integer
    Dim ohtmltag As Image = My.Resources.Ohtmltag
    Dim oheadtag As Image = My.Resources.oheadtag
    Dim otitletag As Image = My.Resources.otitletag
    Dim obodytag As Image = My.Resources.obodytag
    Dim optag As Image = My.Resources.optag
    Dim oh1tag As Image = My.Resources.oh1tag
    Dim oh6tag As Image = My.Resources.oh6tag
    Dim oboldtag As Image = My.Resources.oboldtag
    Dim chtmltag As Image = My.Resources.chtmltag
    Dim cheadtag As Image = My.Resources.cheadtag
    Dim ctitletag As Image = My.Resources.ctitletag
    Dim cbodytag As Image = My.Resources.cbodytag
    Dim cptag As Image = My.Resources.cptag
    Dim ch1tag As Image = My.Resources.ch1tag
    Dim ch6tag As Image = My.Resources.ch6tag
    Dim cboldtag As Image = My.Resources.cboldtag
    Dim defaultbody As Image = My.Resources.DefaultBody
    Dim defaulttitle As Image = My.Resources.DefaultTitle
    Dim defaultP As Image = My.Resources.defaultp
    Dim defaultH As Image = My.Resources.defaulth1

    Private Sub game1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        center(level1)
        center(level2)
        center(Label2)
        For Each Gbox As GroupBox In Me.Controls.OfType(Of GroupBox)()
            For Each Pan As Panel In Gbox.Controls.OfType(Of Panel)()
                For Each PB As PictureBox In Pan.Controls.OfType(Of PictureBox)()
                    If Not (PB Is PictureBox1) Then
                        PB.AllowDrop = True
                        PB.BackColor = Color.White
                        AddHandler PB.MouseMove, AddressOf PBs_MouseMove
                        AddHandler PB.DragEnter, AddressOf PBs_DragEnter
                        AddHandler PB.DragDrop, AddressOf PBs_DragDrop
                        AddHandler PB.DragOver, AddressOf PBs_DragOver
                    End If
                Next
            Next
            For Each box As GroupBox In Gbox.Controls.OfType(Of GroupBox)()
                For Each PB As PictureBox In box.Controls.OfType(Of PictureBox)()
                    If Not (PB Is PictureBox1) Then
                        PB.AllowDrop = True
                        PB.BackColor = Color.White
                        AddHandler PB.MouseMove, AddressOf PBs_MouseMove
                        AddHandler PB.DragEnter, AddressOf PBs_DragEnter
                        AddHandler PB.DragDrop, AddressOf PBs_DragDrop
                        AddHandler PB.DragOver, AddressOf PBs_DragOver
                    End If
                Next
            Next
        Next
        synth.SpeakAsync("welcome to make the page.")
    End Sub

    Private Sub PBs_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim PB As PictureBox = DirectCast(sender, PictureBox)
        If Not IsNothing(PB.Image) AndAlso e.Button = Windows.Forms.MouseButtons.Left Then
            source = PB
            PB.DoDragDrop(PB.Image, DragDropEffects.Copy Or DragDropEffects.Move)
        End If
    End Sub

    Private Sub PBs_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            If My.Computer.Keyboard.CtrlKeyDown Then
                e.Effect = DragDropEffects.Move
            Else
                e.Effect = DragDropEffects.Copy
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub PBs_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
        Dim PB As PictureBox = DirectCast(sender, PictureBox)
        Dim tmpImage As Image = PB.Image
        If tmpImage Is Nothing Then

        End If
        'And source.GetContainerControl Is Controls.OfType(Of GroupBox)()
        If e.Effect = DragDropEffects.Copy Then
            If TypeOf PB.Parent Is GroupBox And TypeOf source.Parent Is GroupBox Then
                
            ElseIf TypeOf PB.Parent Is Panel And TypeOf source.Parent Is GroupBox Then
                PB.Image = e.Data.GetData(DataFormats.Bitmap)
            ElseIf TypeOf PB.Parent Is Panel And TypeOf source.Parent Is Panel Then
                PB.Image = e.Data.GetData(DataFormats.Bitmap)
                source.Image = tmpImage
            ElseIf TypeOf PB.Parent Is GroupBox And TypeOf source.Parent Is Panel Then

            End If

        End If
    End Sub

    Private Sub PBs_DragOver(ByVal sender As Object, ByVal e As DragEventArgs)

        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            If My.Computer.Keyboard.CtrlKeyDown Then
                e.Effect = DragDropEffects.Move
            Else
                e.Effect = DragDropEffects.Copy
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub getscore1()
        
        If PicBox1_1.Image Is imgbox1.Image Then
            score += 1
        End If
        If PicBox1_2.Image Is imgbox2.Image Then
            score += 1
        End If
        If PicBox1_3.Image Is imgbox3.Image Then
            score += 1
        End If
        If PicBox1_4.Image Is imgbox4.Image Then
            score += 1
        End If
        If PicBox1_5.Image Is imgbox5.Image Then
            score += 1
        End If
        If PicBox1_6.Image Is imgbox6.Image Then
            score += 1
        End If
        If PicBox1_7.Image Is imgbox7.Image Then
            score += 1
        End If
        If PicBox1_8.Image Is imgbox8.Image Then
            score += 1
        End If
        If PicBox1_9.Image Is imgbox9.Image Then
            score += 1
        End If
        If PicBox1_10.Image Is imgbox10.Image Then
            score += 1
        End If

        If timeleft > 10 Then
            timeleft = 10
        End If

        If score = 0 Then
        Else
            score = (score / 10) * 100
            If score > 100 Then
                score = 100
            End If
        End If

        If score >= 50 Then
            num_of_star = num_of_star + 1
        End If

        If score >= 100 Then
            num_of_star = num_of_star + 1
        End If

        If timeleft >= 10 Then
            num_of_star = num_of_star + 1
        End If

        showstar()

    End Sub

    Private Sub getscore2()
        If picbox2_1.Image Is imgbox2_1.Image Then
            score += 1
        End If
        If picbox2_2.Image Is imgbox2_2.Image Then
            score += 1
        End If
        If picbox2_3.Image Is imgbox2_3.Image Then
            score += 1
        End If
        If picbox2_4.Image Is imgbox2_4.Image Then
            score += 1
        End If
        If picbox2_5.Image Is imgbox2_5.Image Then
            score += 1
        End If
        If picbox2_6.Image Is imgbox2_6.Image Then
            score += 1
        End If
        If picbox2_7.Image Is imgbox2_7.Image Then
            score += 1
        End If
        If picbox2_8.Image Is imgbox2_8.Image Then
            score += 1
        End If
        If picbox2_9.Image Is imgbox2_9.Image Then
            score += 1
        End If
        If picbox2_10.Image Is imgbox2_10.Image Then
            score += 1
        End If
        If picbox2_11.Image Is imgbox2_11.Image Then
            score += 1
        End If
        If picbox2_12.Image Is imgbox2_12.Image Then
            score += 1
        End If
        If picbox2_13.Image Is imgbox2_13.Image Then
            score += 1
        End If
        If picbox2_14.Image Is imgbox2_14.Image Then
            score += 1
        End If

        If timeleft > 10 Then
            timeleft = 10
        End If

        If score = 0 Then
        Else
            score = (score / 14) * 100
        End If

        If score >= 50 Then
            num_of_star = num_of_star + 1
        End If

        If score >= 100 Then
            num_of_star = num_of_star + 1
        End If

        If timeleft >= 10 Then
            num_of_star = num_of_star + 1
        End If

        showstar()

    End Sub

    Private Sub showstar()
        If num_of_star = 0 Then
            PicStar1.Image = My.Resources.blackstar
            picStar2.Image = My.Resources.blackstar
            PicStar3.Image = My.Resources.blackstar
        ElseIf num_of_star = 1 Then
            PicStar1.Image = My.Resources.star
            picStar2.Image = My.Resources.blackstar
            PicStar3.Image = My.Resources.blackstar
        ElseIf num_of_star = 2 Then
            PicStar1.Image = My.Resources.star
            picStar2.Image = My.Resources.star
            PicStar3.Image = My.Resources.blackstar
        ElseIf num_of_star = 3 Then
            PicStar1.Image = My.Resources.star
            picStar2.Image = My.Resources.star
            PicStar3.Image = My.Resources.star
        End If
    End Sub

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick

        Label1.Text = time
        time = time + 1
        If Label1.Text = "60" Then
            btnStart.PerformClick()
        End If
    End Sub
    Dim fillcomplete As Boolean

    Private Sub submitchecker_Tick(sender As Object, e As EventArgs) Handles submitchecker.Tick
        If level1.Visible = True Then
            For Each pb As PictureBox In droppanel1.Controls.OfType(Of PictureBox)()
                If pb.Image Is Nothing Then
                    fillcomplete = False
                    Exit For
                Else
                    fillcomplete = True
                End If
            Next
            If fillcomplete = False Then
                btnStart.Enabled = False
            Else
                btnStart.Enabled = True
            End If
            If Label1.Text = "59" Then
                btnStart.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If btnStart.Text = "START GAME" Then
            If level1.Visible = True Then
                tipbox.Visible = False
                tagbox1.Enabled = True
                droppanel1.Enabled = True
                GameTimer.Start()
                submitchecker.Start()
                Label1.BackColor = Color.Lime
                btnStart.Text = "SUBMIT"
                btnStart.BackColor = Color.Lime
            ElseIf level2.Visible = True Then
                tipbox.Visible = False
                droppanel2.Enabled = True
                tagbox2.Enabled = True
                GameTimer.Start()
                submitchecker.Start()
                Label1.BackColor = Color.Lime
                btnStart.Text = "SUBMIT"
                btnStart.BackColor = Color.Lime
            End If

        Else
            GameTimer.Stop()
            If submitchecker.Enabled = True Then
                submitchecker.Stop()
            End If
            Label1.BackColor = Color.Red
            btnStart.Text = "SUBMIT"
            btnStart.BackColor = Color.Red
            btnStart.Enabled = False
            timeleft = 60 - Label1.Text

            If level1.Visible = True Then
                getscore1()
                tagbox1.Enabled = False
                droppanel1.Enabled = False
                lblscore1.Text = "YOUR SCORE IS " & score & "%"
                If score > 50 Then
                    lblscore1.BackColor = Color.Lime
                Else
                    lblscore1.BackColor = Color.Red
                End If
                score2.Visible = True
            ElseIf level2.Visible = True Then
                getscore2()
                tagbox2.Enabled = False
                droppanel2.Enabled = False
                lblscore2.Text = "YOUR SCORE IS " & score & "%"
                If score > 50 Then
                    lblscore2.BackColor = Color.Lime
                Else
                    lblscore2.BackColor = Color.Red
                End If
                showscore2.Visible = True
            End If

        End If
    End Sub

    Private Sub resetlevel1()
        For Each PB As PictureBox In droppanel1.Controls.OfType(Of PictureBox)()
            PB.Image = Nothing
        Next
        score = 0
        Label1.Text = "0"
        time = 0
        btnStart.Text = "START GAME"
        btnStart.Enabled = True
        score2.Visible = False
        starbox.Visible = False
        tipbox.Visible = True
    End Sub

    Private Sub btnretry1_Click(sender As Object, e As EventArgs) Handles btnretry1.Click
        resetlevel1()
    End Sub

    Private Sub btnNext1_Click(sender As Object, e As EventArgs) Handles btnNext1.Click
        resetlevel1()
        level1.Visible = False
        level2.Visible = True
    End Sub

    Private Sub picMMize_Click(sender As Object, e As EventArgs) Handles picMMize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub picMMize_MouseHover(sender As Object, e As EventArgs) Handles picMMize.MouseHover
        picMMize.Image = My.Resources.Resources.minimise1
    End Sub

    Private Sub picMMize_MouseLeave(sender As Object, e As EventArgs) Handles picMMize.MouseLeave
        picMMize.Image = My.Resources.Resources.minimise
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub lblscore1_VisibleChanged(sender As Object, e As EventArgs) Handles lblscore1.VisibleChanged
        center(lblscore1)
    End Sub

    Private Sub lblscore2_VisibleChanged(sender As Object, e As EventArgs) Handles lblscore2.VisibleChanged
        center(lblscore2)
    End Sub

    Private Sub LearnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LearnToolStripMenuItem.Click

        Form1.Show()
        Me.Close()
    End Sub

    Private Sub WorkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WorkToolStripMenuItem.Click
        WorkArea.Show()
        Me.Close()
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        
    End Sub
End Class