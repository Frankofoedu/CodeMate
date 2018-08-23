Imports System.Speech.Recognition
Imports System.Speech
Imports System.Threading
Imports System.Globalization
Imports System.Speech.Synthesis
Imports System.IO

Module A_I
    Dim codemate = CreateObject("Sapi.spvoice")
    Public WithEvents reco As New Recognition.SpeechRecognitionEngine
    Public WithEvents conf_reco As New Recognition.SpeechRecognitionEngine
    Public synth As New SpeechSynthesizer
    Dim ends As Boolean = False
    Public pan2V As Boolean
    Public continue_reco As Boolean = True
    Dim conf_rec As String

    Public Sub launch_AI(commands() As String)
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-GB")
        reco.SetInputToDefaultAudioDevice()
        Dim gram As New Recognition.SrgsGrammar.SrgsDocument
        Dim speak4me As New Recognition.SrgsGrammar.SrgsRule("command")
        'here you add all the words you want to say before you say your search word
        Dim commandList As New Recognition.SrgsGrammar.SrgsOneOf(commands)
        speak4me.Add(commandList)
        gram.Rules.Add(speak4me)
        gram.Root = speak4me
        reco.LoadGrammar(New Recognition.Grammar(gram))
        reco.RecognizeAsync()
    End Sub
    Public Sub conf_AI()
        stop_AI()
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-GB")
        conf_reco.SetInputToDefaultAudioDevice()
        Dim gram As New Recognition.SrgsGrammar.SrgsDocument
        Dim speak4me As New Recognition.SrgsGrammar.SrgsRule("command")
        'here you add all the words you want to say before you say your search word
        Dim commandList As New Recognition.SrgsGrammar.SrgsOneOf("yes i do", "no i don't")
        speak4me.Add(commandList)
        gram.Rules.Add(speak4me)
        gram.Root = speak4me
        conf_reco.LoadGrammar(New Recognition.Grammar(gram))
        conf_reco.RecognizeAsync()
    End Sub
    Private Sub reco_RecognizeCompleted(sender As Object, e As RecognizeCompletedEventArgs) Handles reco.RecognizeCompleted
        If continue_reco = True Then
            reco.RecognizeAsync()
        End If
    End Sub


    Private Sub reco_SpeechRecognized(sender As Object, e As SpeechRecognizedEventArgs) Handles reco.SpeechRecognized
        Form1.TextBox1.Text = e.Result.Text

        Select Case e.Result.Text
            Case "code mate"
                synth.SpeakAsync("Hello, i am listening")
            Case "code mate how are you"
                synth.SpeakAsync("I am fine. and you")
            Case "code mate select user one"
                If WICSform1.Visible = False Then
                    If Form1.Panel1.Visible = True Then

                        If Form1.listUSERS.Items.Count >= 1 Then
                            synth.SpeakAsync("User one selected")
                            Form1.listUSERS.SelectedIndex = 0
                            Form1.listuserclicke()
                        Else
                            synth.SpeakAsync("I cannot find a user one")
                        End If
                    End If
                End If
            Case "code mate select user two"
                If WICSform1.Visible = False Then
                    If Form1.Panel1.Visible = True Then

                        If Form1.listUSERS.Items.Count >= 2 Then
                            synth.SpeakAsync("User two selected")
                            Form1.listUSERS.SelectedIndex = 1
                            Form1.listuserclicke()
                        Else
                            synth.SpeakAsync("I cannot find a user two")
                        End If
                    End If
                End If
            Case "code mate select user three"
                If WICSform1.Visible = False Then
                    If Form1.Panel1.Visible = True Then

                        If Form1.listUSERS.Items.Count >= 3 Then
                            synth.SpeakAsync("User three selected")
                            Form1.listUSERS.SelectedIndex = 2
                            Form1.listuserclicke()
                        Else
                            synth.SpeakAsync("I cannot find a user three")
                        End If
                    End If
                End If
            Case "code mate select user four"
                If WICSform1.Visible = False Then
                    If Form1.Panel1.Visible = True Then
                        If Form1.listUSERS.Items.Count >= 4 Then
                            synth.SpeakAsync("User four selected")
                            Form1.listUSERS.SelectedIndex = 3
                            Form1.listuserclicke()
                        Else
                            synth.SpeakAsync("I cannot find a user four")
                        End If
                    End If
                End If
            Case "code mate select user five"
                If WICSform1.Visible = False Then
                    If Form1.Panel1.Visible = True Then

                        If Form1.listUSERS.Items.Count >= 5 Then
                            synth.SpeakAsync("User five selected")
                            Form1.listUSERS.SelectedIndex = 4
                            Form1.listuserclicke()
                        Else
                            synth.SpeakAsync("I cannot find a user five")
                        End If
                    End If
                End If
            Case "code mate select user six"
                If WICSform1.Visible = False Then
                    If Form1.Panel1.Visible = True Then

                        If Form1.listUSERS.Items.Count >= 6 Then
                            synth.SpeakAsync("User six selected")
                            Form1.listUSERS.SelectedIndex = 5
                            Form1.listuserclicke()
                        Else
                            synth.SpeakAsync("I cannot find a user six")
                        End If
                    End If
                End If
            Case "code mate load current user"
                If WICSform1.Visible = False Then
                    If Form1.Panel1.Visible = True Then

                        If Form1.listUSERS.SelectedItem.ToString <> "" Then
                            synth.SpeakAsync("Loading information for current user")
                            select_user()
                        Else
                            synth.Speak("No user selected")
                        End If
                    End If
                End If
            Case "code mate delete current user"
                If WICSform1.Visible = False Then
                    If Form1.Panel1.Visible = True Then

                        If Form1.listUserClicked = False Then
                            synth.SpeakAsync("Select a User to be deleted")
                        Else
                            synth.Speak("Are you sure you want to delete current user?")
                            continue_reco = False
                            conf_rec = "Delete"
                            conf_AI()
                        End If
                    End If
                End If
            Case "code mate take me to class"
                If WICSform1.Visible = False Then
                    If pan2V = True Then
                        Form1.BtnTUT.PerformClick()
                    End If
                End If
            Case "code mate take me to work"
                If WICSform1.Visible = False Then
                    If pan2V = True Then
                        Form1.btnWork.PerformClick()
                    End If
                End If
            Case "code mate what can i say"
                If WICSform1.Visible = False Then
                    WICSform1.ShowDialog()
                End If
            Case "code mate i want to leave"
                synth.Speak("do you really want to exit code mate?")
                continue_reco = False
                conf_rec = "Exit"
                conf_AI()
        End Select
    End Sub
    Public Sub select_user()
        userpath = Application.StartupPath & "/users/" & curruser & ".txt"
        userinfo = File.ReadAllText(userpath)
        Form1.FullOutRight(Form1.Panel1)
        Form1.secpanel.Visible = True
        Form1.FullInLeft(Form1.secpanel)
    End Sub
    Public Sub stop_AI()
        reco.RecognizeAsyncStop()
        continue_reco = False
    End Sub
    Private Sub stop_conf_reco()
        conf_reco.RecognizeAsyncStop()
        ends = True
        continue_reco = True
        reco.RecognizeAsync()
    End Sub
    Private Sub conf_reco_RecognizeCompleted(sender As Object, e As RecognizeCompletedEventArgs) Handles conf_reco.RecognizeCompleted
        If ends = False Then
            conf_reco.RecognizeAsync()
        Else
            stop_conf_reco()
        End If
    End Sub

    Private Sub conf_reco_SpeechRecognized(sender As Object, e As SpeechRecognizedEventArgs) Handles conf_reco.SpeechRecognized
        Form1.TextBox1.Text = e.Result.Text

        Select Case e.Result.Text
            Case "yes i do"
                If conf_rec = "Delete" Then
                    synth.SpeakAsync("Deleted")
                    DeleteCurUser()
                    ends = True
                ElseIf conf_rec = "Exit" Then
                    ends = True
                    conf_reco.Dispose()
                    Form1.Close()
                End If
            Case "no i don't"
                If conf_rec = "Delete" Then
                    synth.SpeakAsync("No user deleted")
                    ends = True
                ElseIf conf_rec = "Exit" Then
                    synth.SpeakAsync("Welcome back")
                    ends = True
                End If
        End Select
    End Sub
End Module
