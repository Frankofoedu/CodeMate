Imports System.IO

Public Class Form1
    Dim currentX, currentY As Integer
    Dim currheight, currwidth As Integer
    Dim blTxtNewShown As Boolean = False
    Public mycommands(13) As String
    Public listUserClicked As Boolean = False
    Dim currimage As String
    Dim _mousedown As Boolean
    Dim startpt As Point
    Public VRlaunched As Boolean = False

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        stop_AI()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pan1X = Panel1.Top
        pan1Y = Panel1.Left
        pan1Height = Panel1.Height
        pan1Width = Panel1.Width

        txtnewX = txtNEWUSER.Top
        txtnewY = txtNEWUSER.Left
        txtnewHeight = txtNEWUSER.Height
        txtnewWidth = txtNEWUSER.Width

        FullInRight(Panel1)
        center(PictureBox3)
        loaduserlist()

        If listUSERS.Items.Count = 0 Then
            btnNEW.PerformClick()
        End If

        If AI_on = True Then
            CheckBox1.Checked = True
        End If

        synth.SpeakAsync("Welcome to code mate. You can log in or create a new user")
    End Sub

    Public Sub FullInRight(ctrl As Control)
        ctrl.Visible = True

        currentX = ctrl.Top
        currentY = ctrl.Left
        currheight = ctrl.Height
        currwidth = ctrl.Width

        'Dim buff As Integer = Me.Width - currentY
        ctrl.Left = Me.Width

        'For y As Integer = 1 To buff Step 2
        '    ctrl.Left = Me.Width - y
        '    Threading.Thread.Sleep(1)
        'Next
        endpoint = Me.Width - currentY
        SIanimationtype = "fullinright"
        CurAnimCtrl = ctrl
        slideinanimationtimer.Start()

    End Sub
    Dim CurAnimCtrl As Control
    Dim SIanimationtype As String
    Dim SOanimationtype As String
    Dim endpoint As Integer
    Dim curpoint As Integer = 1

    Private Sub animationtimer_Tick(sender As Object, e As EventArgs) Handles slideinanimationtimer.Tick
        If SIanimationtype = "fullinright" Then
            If curpoint >= endpoint Then
                slideinanimationtimer.Stop()
                Exit Sub
            End If
            CurAnimCtrl.SetBounds(Me.Width - curpoint, CurAnimCtrl.Top, CurAnimCtrl.Width, CurAnimCtrl.Height)
            'CurAnimCtrl.Left = Me.Width - curpoint
            curpoint += 8

        ElseIf SIanimationtype = "fullinleft" Then

            If curpoint >= endpoint Then
                slideinanimationtimer.Stop()
                Exit Sub
            End If
            CurAnimCtrl.SetBounds(curpoint, CurAnimCtrl.Top, CurAnimCtrl.Width, CurAnimCtrl.Height)
            'CurAnimCtrl.Left = curpoint
            curpoint += 8

        End If

    End Sub

    Private Sub slideoutanimationTimer_Tick(sender As Object, e As EventArgs) Handles slideoutanimationTimer.Tick
        If SOanimationtype = "fulloutright" Then

            If curpoint >= endpoint Then
                slideinanimationtimer.Stop()
                Exit Sub
            End If

            CurAnimCtrl.Left = curpoint
            curpoint += 8
        End If
    End Sub
    Public Sub FullOutRight(ctrl As Control)

        currentX = ctrl.Top
        currentY = ctrl.Left
        currheight = ctrl.Height
        currwidth = ctrl.Width

        'Dim buff As Integer = Me.Width - currentY
        'ctrl.Left = Me.Width

        'For y As Integer = 1 To buff Step 2
        '    ctrl.Left = currentY + y
        '    Threading.Thread.Sleep(1)
        'Next
        'ctrl.Visible = False
        endpoint = Me.Width
        curpoint = Me.Width - currentY
        SOanimationtype = "fulloutright"
        CurAnimCtrl = ctrl
        slideinanimationtimer.Start()
    End Sub

    Public Sub FullInLeft(ctrl As Control)
        ctrl.Visible = True

        currentX = ctrl.Top
        currentY = ctrl.Left
        currheight = ctrl.Height
        currwidth = ctrl.Width

        'Dim buff As Integer = Me.Width - currentY
        ctrl.Left = Me.Width - (Me.Width + currwidth)

        'For y As Integer = 1 To currentY Step 2
        '    ctrl.Left = y
        '    Threading.Thread.Sleep(1)
        'Next
        endpoint = currentY
        curpoint = 1
        SIanimationtype = "fullinleft"
        CurAnimCtrl = ctrl
        slideinanimationtimer.Start()
    End Sub


    Public Sub FullOutLeft(ctrl As Control)

        currentX = ctrl.Top
        currentY = ctrl.Left
        currheight = ctrl.Height
        currwidth = ctrl.Width

        Dim buff As Integer = Me.Width - currentY
        ctrl.Left = Me.Width

        For y As Integer = 1 To buff Step 2
            ctrl.Left = Me.Width - y
            Threading.Thread.Sleep(1)
        Next
        ctrl.Visible = False
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtNEWUSER.Visible = False Then
            If listUSERS.SelectedItem.ToString <> "" Then
                userpath = Application.StartupPath & "/users/" & curruser & ".txt"
                userinfo = File.ReadAllText(userpath)
                Panel1.Visible = False
                secpanel.Visible = True
                FullInRight(secpanel)
            Else
                MsgBox("Select a User or Create a New User.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Else
            If txtNEWUSER.Text = "" Or txtNEWUSER.Text = "NEW" Then
                MsgBox("Input a Username!", MsgBoxStyle.Critical)
                Exit Sub
            Else
                curruser = txtNEWUSER.Text

                slideoutright(txtNEWUSER, 2)
                txtNEWUSER.Visible = False

                userpath = Application.StartupPath & "/users/" & curruser & ".txt"
                userinfo = "username=" & curruser & vbCrLf & "currchapter=newuser"
                File.WriteAllText(userpath, userinfo)
                'FullOutRight(Panel1)
                Panel1.Visible = False
                secpanel.Visible = True
                FullInLeft(secpanel)
            End If

        End If
    End Sub

    Private Sub btnNEW_Click(sender As Object, e As EventArgs) Handles btnNEW.Click
        txtNEWUSER.Visible = True
        RndSlideIn(txtNEWUSER, 2)
        txtNEWUSER.Text = "INPUT YOUR USERNAME HERE (NEW USERS)"
        txtNEWUSER.Focus()
        blTxtNewShown = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        slideoutright(txtNEWUSER, 2)

    End Sub

    Private Sub txtNEWUSER_TextChanged(sender As Object, e As EventArgs) Handles txtNEWUSER.TextChanged
        If txtNEWUSER.Text = "INPUT YOUR USERNAME HERE (NEW USERS)" Then
            txtNEWUSER.ForeColor = Color.Black

        End If
        If btnOK.Enabled = False Then
            btnOK.Enabled = True
        End If

        txtNEWUSER.Text = UCase(txtNEWUSER.Text)
    End Sub

    Private Sub Panel2_VisibleChanged(sender As Object, e As EventArgs) Handles secpanel.VisibleChanged
        If secpanel.Visible = True Then
            Label2.Text = "Welcome " & UCase(curruser) & "." & vbCrLf & vbCrLf & "What do you want to do today?"
            synth.SpeakAsync(Label2.Text)
            pan2V = True
        End If

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs)
        slideoutleft(Panel1, 2)
    End Sub

    Private Sub BtnTUT_Click(sender As Object, e As EventArgs) Handles BtnTUT.Click
        Form2.Show()
        Me.Close()

    End Sub

    Private Sub listUSERS_Click(sender As Object, e As EventArgs) Handles listUSERS.Click
        listuserclicke()

    End Sub
    Public Sub listuserclicke()
        btnOK.Enabled = True
        btnDELETE.Enabled = True
        listUserClicked = True

        If txtNEWUSER.Visible = True Then
            If txtNEWUSER.Text <> "INPUT YOUR USERNAME HERE (NEW USERS)" Then
                txtNEWUSER.Text = "INPUT YOUR USERNAME HERE (NEW USERS)"
                txtNEWUSER.ForeColor = Color.LightGray
                blTxtNewShown = False
            End If
            slideoutright(txtNEWUSER, 2)
            txtNEWUSER.Visible = False
        End If

        curruser = listUSERS.SelectedItem.ToString
    End Sub
    Private Sub btnDELETE_Click(sender As Object, e As EventArgs) Handles btnDELETE.Click
        If txtNEWUSER.Visible = True Then
            If txtNEWUSER.Text <> "INPUT YOUR USERNAME HERE (NEW USERS)" Then
                txtNEWUSER.Text = "INPUT YOUR USERNAME HERE (NEW USERS)"
                txtNEWUSER.ForeColor = Color.LightGray
                blTxtNewShown = False
            End If
            slideoutright(txtNEWUSER, 2)
            txtNEWUSER.Visible = False
        End If

        If listUSERS.SelectedItem.ToString <> "" Then
            Dim rtn As Integer = MsgBox("Are you sure you want to delete selected user?", MsgBoxStyle.YesNo, "Delete User")
            If rtn = vbYes Then
                DeleteCurUser()
            End If
        Else
            MsgBox("Select a User to delete.", MsgBoxStyle.Critical)
            Exit Sub
        End If
    End Sub

    Private Sub btnWork_Click(sender As Object, e As EventArgs) Handles btnWork.Click
        WorkArea.Show()
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            If VRlaunched = False Then
                mycommands(0) = "code mate"
                mycommands(1) = "code mate how are you"
                mycommands(2) = "code mate select user one"
                mycommands(3) = "code mate select user two"
                mycommands(4) = "code mate select user three"
                mycommands(5) = "code mate select user four"
                mycommands(6) = "code mate select user five"
                mycommands(7) = "code mate select user six"
                mycommands(8) = "code mate load current user"
                mycommands(9) = "code mate delete current user"
                mycommands(10) = "code mate take me to class"
                mycommands(11) = "code mate take me to work"
                mycommands(12) = "code mate what can i say"
                mycommands(13) = "code mate i want to leave"
                launch_AI(mycommands)
                AI_on = True
                VRlaunched = True
            Else
                continue_reco = True
                AI_on = True
                reco.RecognizeAsync()
            End If
        Else
            stop_AI()
            AI_on = False

        End If
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

    Private Sub Panel5_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel5.MouseDown
        _mousedown = True
        startpt = e.Location
    End Sub

    Private Sub Panel5_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel5.MouseMove
        If _mousedown = True Then
            Dim currpos As Point = PointToScreen(e.Location)
            Location = New Point(currpos.X - startpt.X, currpos.Y - startpt.Y)
        End If
    End Sub

    Private Sub Panel5_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel5.MouseUp
        _mousedown = False
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        browsemain.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        game1.Show()
        Me.Close()
    End Sub

End Class
