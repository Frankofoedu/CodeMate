Imports System.IO

Public Class Form2
    Dim tutorialspath As String
    Dim CurChapterPath As String
    Dim curChapter As String
    Dim currimage As String
    Dim _mousedown As Boolean
    Dim startpt As Point
    Public mycommands(11) As String
    Public VRlaunched As Boolean = False
    Public comand As String

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim buffe() As String = Split(userinfo, vbCrLf)

        userinfo = buffe(0) & vbCrLf & "currchapter=" & curChapter & vbCrLf

        File.WriteAllText(userpath, userinfo)

        stop_form2_AI()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        panTutX = 110
        panTutY = 233
        panTutHeight = 560
        panTutWidth = 730

        Cursor = Cursors.WaitCursor

        'RndSlideIn(mainTUTpanel, 5)
        FullInRight(GroupBox2)
        FullInLeft(GroupBox1)

        mainTUTpanel.Visible = True

        Dim padtext As String
        padtext = "<html>" & vbCrLf & vbTab & "<head>" & vbCrLf & vbTab & "</head>" & vbCrLf & vbTab & "<body>" & vbCrLf & vbTab & vbTab & "my name is " _
            & curruser & vbCrLf & vbTab & "</body>" & vbCrLf & "</html>"

        GroupBox2.Visible = True
        GroupBox1.Visible = True

        Dim buffe() As String = Split(userinfo, vbCrLf)
        Dim buffe2() As String = Split(buffe(1), "=")

        Dim testdir As String = Application.StartupPath & "/users/" & curruser

        If Not Directory.Exists(testdir) Then
            Directory.CreateDirectory(testdir)
        End If

        testpath = Application.StartupPath & "/users/" & curruser & "/" & curruser & ".html"

        If buffe2(1) = "newuser" Then
            curChapter = "Introduction"
            pad.Text = padtext
            File.WriteAllText(testpath, padtext)
            WebBrowser2.Url = New Uri(testpath)
            Label1.Text = WebBrowser2.DocumentTitle
        ElseIf File.Exists(testpath) Then
            curChapter = buffe2(1)
            pad.Text = File.ReadAllText(testpath)
            WebBrowser2.Url = New Uri(testpath)
            Label1.Text = WebBrowser2.DocumentTitle
        Else
            curChapter = "Introduction"
            pad.Text = padtext
            File.WriteAllText(testpath, padtext)
            WebBrowser2.Url = New Uri(testpath)
            Label1.Text = WebBrowser2.DocumentTitle
        End If

        CurChapterPath = Application.StartupPath & "/tutorials/html/" & curChapter & ".html"
        WebBrowser1.Url = New Uri(CurChapterPath)
        Label1.Text = WebBrowser2.DocumentTitle

        listChapters.SelectedItem = curChapter

        Cursor = Cursors.Default

        If AI_on = True Then
            CheckBox1.Checked = True
        End If

        center(PictureBox3)

        synth.SpeakAsync("welcome to the learning area. Here, you can read through the chapters and practice in the do it yourself area")
    End Sub


    Private Sub GroupBox1_VisibleChanged(sender As Object, e As EventArgs) Handles GroupBox1.VisibleChanged
        If GroupBox1.Visible = True Then
            tutorialspath = Application.StartupPath & "\tutorials\html\"
            Dim dir As New DirectoryInfo(tutorialspath)
            Dim direc As FileInfo() = dir.GetFiles("*.html")
            Dim dr As FileInfo

            For Each dr In direc
                Dim x() As String = Split(dr.ToString, ".")
                listChapters.Items.Add(x(0))
            Next
        End If
    End Sub

    Private Sub listChapters_Click(sender As Object, e As EventArgs) Handles listChapters.Click
        curChapter = listChapters.SelectedItem.ToString
        CurChapterPath = tutorialspath & curChapter & ".html"
        WebBrowser1.Url = New Uri(CurChapterPath)
    End Sub

    Private Sub btnLoadHTML_Click(sender As Object, e As EventArgs) Handles btnLoadHTML.Click

        File.WriteAllText(testpath, pad.Text)

        WebBrowser2.Url = New Uri(testpath)
        Label1.Text = WebBrowser2.DocumentTitle
    End Sub

    Private Sub listChapters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listChapters.SelectedIndexChanged
        If listChapters.SelectedIndex = listChapters.Items.Count - 1 Then
            BtnNext.Enabled = False
            BtnPrev.Enabled = True
        ElseIf listChapters.SelectedIndex = 0 Then
            BtnPrev.Enabled = False
            BtnNext.Enabled = True
        Else
            BtnPrev.Enabled = True
            BtnNext.Enabled = True
        End If
    End Sub

    Public Sub FullInRight(ctrl As Control)

        currentX = ctrl.Top
        currentY = ctrl.Left
        currheight = ctrl.Height
        currwidth = ctrl.Width

        Dim buff As Integer = Me.Width - currentY
        ctrl.Left = Me.Width

        For y As Integer = 1 To buff Step 5
            ctrl.Left = Me.Width - y
            Threading.Thread.Sleep(1)
        Next

    End Sub

    Public Sub FullInLeft(ctrl As Control)

        currentX = ctrl.Top
        currentY = ctrl.Left
        currheight = ctrl.Height
        currwidth = ctrl.Width

        Dim buff As Integer = Me.Width - currentY
        ctrl.Left = Me.Width - (Me.Width + currwidth)

        For y As Integer = 1 To currentY Step 5
            ctrl.Left = y
            Threading.Thread.Sleep(1)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub picRestoreDown_Click(sender As Object, e As EventArgs) Handles picRestoreDown.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            picRestoreDown.Image = My.Resources.Resources.maximize1
            currimage = "My.Resources.Resources.mazimize1"
            ToolTip1.SetToolTip(picRestoreDown, "Maximise")

        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            picRestoreDown.Image = My.Resources.Resources.retoredown1
            currimage = "My.Resources.Resources.retoredown1"
            ToolTip1.SetToolTip(picRestoreDown, "Restore Down")
        End If
    End Sub

    Private Sub picRestoreDown_MouseHover(sender As Object, e As EventArgs) Handles picRestoreDown.MouseHover
        If currimage = "My.Resources.Resources.retoredown1" Then
            picRestoreDown.Image = My.Resources.Resources.retoredown
            currimage = "My.Resources.Resources.retoredown"
        ElseIf currimage = "My.Resources.Resources.mazimize1" Then
            picRestoreDown.Image = My.Resources.Resources.maximize
            currimage = "My.Resources.Resources.mazimize"
        End If
    End Sub

    Private Sub picRestoreDown_MouseLeave(sender As Object, e As EventArgs) Handles picRestoreDown.MouseLeave
        If currimage = "My.Resources.Resources.retoredown" Then
            picRestoreDown.Image = My.Resources.Resources.retoredown1
            currimage = "My.Resources.Resources.retoredown1"
        ElseIf currimage = "My.Resources.Resources.mazimize" Then
            picRestoreDown.Image = My.Resources.Resources.maximize1
            currimage = "My.Resources.Resources.mazimize1"
        End If
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

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Dim rtn As Integer = MsgBox("Are you sure you want to close", MsgBoxStyle.YesNo)
        If rtn = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub picClose_MouseHover(sender As Object, e As EventArgs) Handles picClose.MouseHover
        picClose.Image = My.Resources.Resources.close
    End Sub

    Private Sub picClose_MouseLeave(sender As Object, e As EventArgs) Handles picClose.MouseLeave
        picClose.Image = My.Resources.Resources.close1
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        _mousedown = True
        startpt = e.Location
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If _mousedown = True Then
            Dim currpos As Point = PointToScreen(e.Location)
            Location = New Point(currpos.X - startpt.X, currpos.Y - startpt.Y)
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        _mousedown = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            If VRlaunched = False Then
                mycommands(0) = "code mate"
                mycommands(1) = "code mate how are you"
                mycommands(2) = "code mate log me out"
                mycommands(3) = "code mate what can i say"
                mycommands(4) = "code mate i want to leave"
                mycommands(5) = "code mate next chapter"
                mycommands(6) = "code mate previous chapter"
                mycommands(7) = "code mate display do it your self"
                mycommands(8) = "code mate read to me"
                mycommands(9) = "code mate stop reading"
                mycommands(10) = "code mate pause reading"
                mycommands(11) = "code mate resume reading"

                launchForm2_AI(mycommands)
                AI_on = True
                VRlaunched = True
            Else
                reco2.RecognizeAsyncStop()
                continue_reco2 = True
                AI_on = True
                reco2.RecognizeAsync()
            End If
        Else
            stop_AI()
            AI_on = False
        End If

    End Sub

    Private Sub BtnPrev_Click_1(sender As Object, e As EventArgs) Handles BtnPrev.Click
        listChapters.SelectedIndex -= 1

        curChapter = listChapters.SelectedItem.ToString
        CurChapterPath = tutorialspath & curChapter & ".html"
        WebBrowser1.Url = New Uri(CurChapterPath)

    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click

        listChapters.SelectedIndex += 1

        curChapter = listChapters.SelectedItem.ToString
        CurChapterPath = tutorialspath & curChapter & ".html"
        WebBrowser1.Url = New Uri(CurChapterPath)

    End Sub

    Private Sub btnread_Click(sender As Object, e As EventArgs) Handles btnread.Click

        audiopath = tutorialspath & curChapter & ".txt"
        Dim audiostream As String = File.ReadAllText(audiopath)
        If btnread.Text = "READ" Then
            synth.SpeakAsync(audiostream)
            btnread.Text = "STOP"
            btnpause.Visible = True
        Else
            btnread.Text = "READ"
            synth.SpeakAsyncCancelAll()
            btnpause.Visible = False
        End If

    End Sub

    Private Sub btnpause_Click(sender As Object, e As EventArgs) Handles btnpause.Click
        If btnpause.Text = "PAUSE" Then
            synth.Pause()
            btnpause.Text = "RESUME"
        Else
            synth.Resume()
            btnpause.Text = "PAUSE"
        End If
    End Sub

    Private Sub WorkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WorkToolStripMenuItem.Click
        WorkArea.Show()
        Me.Close()
    End Sub

    Private Sub LearnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LearnToolStripMenuItem.Click

        Form1.Show()
        Me.Close()
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        game1.Show()
        Me.Close()
    End Sub
End Class