
Imports System.Speech.Recognition
Imports System.Speech
Imports System.Threading
Imports System.Globalization

Public Class WorkArea

    Dim _mousedown As Boolean
    Dim startpt As Point
    Dim currimage As String
    Public runclicked As Boolean = False
    Public urltext As String
    Public mainFPath As String
    Public newtab() As tab1
    Public newtabcount As Integer = -1
    Public projectpath As String
    Dim chkbox_chkd As Boolean = False
    Dim cont_work_reco As Boolean = True
    Dim ends As Boolean

    Dim WithEvents reco_workarea As New Recognition.SpeechRecognitionEngine
    Dim WithEvents conf_work_reco As New Recognition.SpeechRecognitionEngine

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

    Private Sub WorkArea_Load(sender As Object, e As EventArgs) Handles Me.Load

        currimage = "My.Resources.Resources.retoredown1"
        _mousedown = False
        Dim startpag As New TabPage
        Dim newtab2 As New WorkStart
        newtab2.Show()
        newtab2.Dock = DockStyle.Fill
        newtab2.TopLevel = False
        startpag.Controls.Add(newtab2)
        TabControl2.TabPages.Add(startpag)
        TabControl2.SelectedTab.Text = "StartPage"

        If AI_on = True Then
            CheckBox1.Checked = True
        End If
    End Sub

    Private Sub NEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWToolStripMenuItem.Click
        Dim a As Integer
        a = TabControl2.TabPages.IndexOf(TabControl2.SelectedTab)
        newtab(a).NEWToolStripMenuItem.PerformClick()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

1:      For a As Integer = 0 To TabControl2.TabCount - 1
            TabControl2.SelectTab(a)
            On Error GoTo 1
            newtab(a).SAVEToolStripMenuItem.PerformClick()
        Next

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim A As Integer
        A = TabControl2.TabPages.IndexOf(TabControl2.SelectedTab)
        newtab(A).SAVEToolStripMenuItem.PerformClick()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        NEWToolStripMenuItem.PerformClick()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        openfile.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim a As Integer
        a = TabControl2.TabPages.IndexOf(TabControl2.SelectedTab)
        newtab(a).pad.Redo()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim a As Integer
        a = TabControl2.TabPages.IndexOf(TabControl2.SelectedTab)
        newtab(a).pad.Undo()
    End Sub

    Private Sub OPENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPENToolStripMenuItem.Click
        openfile.Show()
    End Sub

    Private Sub SAVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAVEToolStripMenuItem.Click
        Dim a As Integer
        a = TabControl2.TabPages.IndexOf(TabControl2.SelectedTab)
        newtab(a).SAVEToolStripMenuItem.PerformClick()
    End Sub

    Private Sub SAVEASToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SAVEASToolStripMenuItem1.Click
        Dim a As Integer
        a = TabControl2.TabPages.IndexOf(TabControl2.SelectedTab)
        newtab(a).SAVEASToolStripMenuItem1.PerformClick()
    End Sub

    Private Sub CLOSETABToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLOSETABToolStripMenuItem.Click
        Dim a As Integer
        a = TabControl2.TabPages.IndexOf(TabControl2.SelectedTab)
        newtab(a).CLOSETABToolStripMenuItem.PerformClick()

    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Dim rtn As Integer = MsgBox("Are you sure you want to close", MsgBoxStyle.YesNo)
        If rtn = vbYes Then
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub UNDOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UNDOToolStripMenuItem.Click
        Dim a As Integer
        a = TabControl2.TabPages.IndexOf(TabControl2.SelectedTab)
        newtab(a).pad.Undo()
    End Sub

    Private Sub REDOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REDOToolStripMenuItem.Click
        Dim a As Integer
        a = TabControl2.TabPages.IndexOf(TabControl2.SelectedTab)
        newtab(a).pad.Redo()
    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundToolStripMenuItem.Click
        Dim a As Integer
        a = TabControl2.TabPages.IndexOf(TabControl2.SelectedTab)
        newtab(a).BackgroundToolStripMenuItem.PerformClick()
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
1:      For a As Integer = 0 To TabControl2.TabCount - 1
            TabControl2.SelectTab(a)
            On Error GoTo 1
            newtab(a).SAVEToolStripMenuItem.PerformClick()
        Next

        Threading.Thread.Sleep(2000)

        browsetab.Show()
        browsetab.TextBox1.Text = TextBox1.Text
        browsetab.btnGo.PerformClick()
        runclicked = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            If chkbox_chkd = False Then
                Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-GB")
                reco_workarea.SetInputToDefaultAudioDevice()
                Dim gram As New Recognition.SrgsGrammar.SrgsDocument
                Dim speak4me As New Recognition.SrgsGrammar.SrgsRule("command")
                'here you add all the words you want to say before you say your search word
                Dim commandList As New Recognition.SrgsGrammar.SrgsOneOf("code mate add new file", "code mate ­display result", "code mate load existing file", "code mate save all file",
                                                                         "code mate save current file", "code mate undo action", "code mate redo action", "code mate i want to leave")
                speak4me.Add(commandList)
                gram.Rules.Add(speak4me)
                gram.Root = speak4me
                reco_workarea.LoadGrammar(New Recognition.Grammar(gram))
                reco_workarea.RecognizeAsync()
                cont_work_reco = True
                chkbox_chkd = True
                AI_on = True

            Else
                reco_workarea.RecognizeAsync()
                cont_work_reco = True
                AI_on = True

            End If
        Else
            reco_workarea.RecognizeAsyncStop()
            cont_work_reco = False
            AI_on = False

        End If
    End Sub

    Private Sub reco_workarea_RecognizeCompleted(sender As Object, e As RecognizeCompletedEventArgs) Handles reco_workarea.RecognizeCompleted
        If cont_work_reco = True Then
            reco_workarea.RecognizeAsync()
        End If
    End Sub

    Private Sub reco_workarea_SpeechRecognized(sender As Object, e As SpeechRecognizedEventArgs) Handles reco_workarea.SpeechRecognized
        TextBox2.Text = e.Result.Text

        Select Case e.Result.Text
            Case "code mate ­display result"
                Button1.PerformClick()
            Case "code mate add new file"
                NEWToolStripMenuItem.PerformClick()
            Case "code mate load existing file"
                openfile.Show()
            Case "code mate save all file"
1:              For a As Integer = 0 To TabControl2.TabCount - 1
                    TabControl2.SelectTab(a)
                    On Error GoTo 1
                    newtab(a).SAVEToolStripMenuItem.PerformClick()
                Next
            Case "code mate save current file"
                Dim A As Integer
                A = TabControl2.TabPages.IndexOf(TabControl2.SelectedTab)
                newtab(A).SAVEToolStripMenuItem.PerformClick()
            Case "code mate undo action"
                Dim a As Integer
                a = TabControl2.TabPages.IndexOf(TabControl2.SelectedTab)
                newtab(a).pad.Undo()
            Case "code mate redo action"
                Dim a As Integer
                a = TabControl2.TabPages.IndexOf(TabControl2.SelectedTab)
                newtab(a).pad.Redo()
                'Case "code mate i want to leave"
                '    Me.Close()
        End Select
    End Sub

    Public Sub conf_work_AI()
        reco_workarea.RecognizeAsyncStop()
        cont_work_reco = False

        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-GB")
        conf_reco2.SetInputToDefaultAudioDevice()
        Dim gram As New Recognition.SrgsGrammar.SrgsDocument
        Dim speak4me As New Recognition.SrgsGrammar.SrgsRule("command")
        'here you add all the words you want to say before you say your search word
        Dim commandList As New Recognition.SrgsGrammar.SrgsOneOf("yes i do", "no i don't")
        speak4me.Add(commandList)
        gram.Rules.Add(speak4me)
        gram.Root = speak4me
        conf_work_reco.LoadGrammar(New Recognition.Grammar(gram))
        conf_work_reco.RecognizeAsync()
    End Sub

    Private Sub stop_conf_reco2()
        conf_reco2.RecognizeAsyncStop()
        ends = True
        continue_reco2 = True
        reco2.RecognizeAsync()
    End Sub

    Private Sub conf_work_reco_RecognizeCompleted(sender As Object, e As RecognizeCompletedEventArgs) Handles conf_work_reco.RecognizeCompleted
        If ends = False Then
            conf_reco2.RecognizeAsync()
        Else
            stop_conf_reco2()
        End If
    End Sub

    Private Sub conf_work_reco_SpeechRecognized(sender As Object, e As SpeechRecognizedEventArgs) Handles conf_work_reco.SpeechRecognized
        Form1.TextBox1.Text = e.Result.Text

        Select Case e.Result.Text
            Case "yes i do"
                ends = True
                conf_reco.Dispose()
                Form2.Close()
            Case "no i don't"
                synth.SpeakAsync("Welcome back")
                ends = True
        End Select
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Static x As Integer
        If x = 1 Then
            GroupBox5.Visible = False
            x = 0
        Else
            GroupBox5.Visible = True
            slideInRight(GroupBox5, 1)
            x = 1
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form2.Show()
        Me.Close()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        game1.Show()
        Me.Show()

    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        Label2.BackColor = Color.Teal
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover
        Label4.BackColor = Color.Teal
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.BackColor = Color.DarkSlateGray
    End Sub
End Class