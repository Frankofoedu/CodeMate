Imports System.Speech.Recognition
Imports System.Speech
Imports System.Threading
Imports System.Globalization
Imports System.IO

Module form2_AI
    Public WithEvents reco2 As New Recognition.SpeechRecognitionEngine
    Public WithEvents conf_reco2 As New Recognition.SpeechRecognitionEngine
    Public continue_reco2 As Boolean = True
    Dim ends As String

    Public Sub launchForm2_AI(commands() As String)
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-GB")
        reco2.SetInputToDefaultAudioDevice()
        Dim gram As New Recognition.SrgsGrammar.SrgsDocument
        Dim speak4me As New Recognition.SrgsGrammar.SrgsRule("command")
        'here you add all the words you want to say before you say your search word
        Dim commandList As New Recognition.SrgsGrammar.SrgsOneOf(commands)
        speak4me.Add(commandList)
        gram.Rules.Add(speak4me)
        gram.Root = speak4me
        reco2.LoadGrammar(New Recognition.Grammar(gram))
        reco2.RecognizeAsync()
    End Sub

    Public Sub conf_form2_AI()
        stop_form2_AI()
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
        conf_reco2.LoadGrammar(New Recognition.Grammar(gram))
        conf_reco2.RecognizeAsync()
    End Sub

    Private Sub reco2_RecognizeCompleted(sender As Object, e As RecognizeCompletedEventArgs) Handles reco2.RecognizeCompleted
        If continue_reco2 = True Then
            reco2.RecognizeAsync()
        End If
    End Sub

    Private Sub reco2_SpeechRecognized(sender As Object, e As SpeechRecognizedEventArgs) Handles reco2.SpeechRecognized

        Form2.TextBox1.Text = e.Result.Text

        Select Case e.Result.Text
            Case "code mate"
                synth.SpeakAsync("Hello, i am listening")
            Case "code mate how are you"
                synth.SpeakAsync("I am fine")
            Case "code mate next chapter"
                If Form2.BtnNext.Enabled = True Then
                    synth.SpeakAsync("going to next chapter")
                    Form2.BtnNext.PerformClick()
                Else
                    synth.SpeakAsync("no next chapter")
                End If
            Case "code mate previous chapter"
                If Form2.BtnPrev.Enabled = True Then
                    synth.SpeakAsync("going to previous chapter")
                    Form2.BtnPrev.PerformClick()
                Else
                    synth.SpeakAsync("no previous chapter")
                End If
            Case "code mate what can i say"
                WICSform1.ShowDialog()
            Case "code mate display do it your self"
                synth.SpeakAsync("displaying")
                Form2.btnLoadHTML.PerformClick()
            Case "code mate log me out"
                Form2.comand = "LEAVE"
                synth.Speak("do you really want to be logged out?")
                continue_reco2 = False
                conf_form2_AI()
            Case "code mate i want to leave"
                synth.Speak("do you really want to exit code mate?")
                Form2.comand = "EXIT"
                continue_reco2 = False
                conf_form2_AI()
            Case "code mate read to me"
                If Form2.btnread.Text = "READ" Then
                    Form2.btnread.PerformClick()
                End If
            Case "code mate stop reading"
                If Form2.btnread.Text = "STOP" Then
                    Form2.btnread.PerformClick()
                End If
            Case "code mate pause reading"
                If Form2.btnpause.Visible = True Then
                    If Form2.btnpause.Text = "PAUSE" Then
                        Form2.btnpause.PerformClick()
                    End If
                End If
            Case "code mate resume reading"
                If Form2.btnpause.Visible = True Then
                    If Form2.btnpause.Text = "RESUME" Then
                        Form2.btnpause.PerformClick()
                    End If
                End If

        End Select
    End Sub

    Public Sub stop_form2_AI()
        reco2.RecognizeAsyncStop()
        continue_reco2 = False
    End Sub

    Private Sub stop_conf_reco2()
        conf_reco2.RecognizeAsyncStop()
        ends = True
        continue_reco2 = True
        reco2.RecognizeAsync()
    End Sub

    Private Sub conf_reco2_RecognizeCompleted(sender As Object, e As RecognizeCompletedEventArgs) Handles conf_reco2.RecognizeCompleted
        If ends = False Then
            conf_reco2.RecognizeAsync()
        Else
            stop_conf_reco2()
        End If
    End Sub

    Private Sub conf_reco2_SpeechRecognized(sender As Object, e As SpeechRecognizedEventArgs) Handles conf_reco2.SpeechRecognized
        Form2.TextBox1.Text = e.Result.Text

        Select Case e.Result.Text
            Case "yes i do"
                If Form2.comand = "EXIT" Then
                    ends = True
                    conf_reco2.Dispose()
                    Form2.Close()
                Else
                    ends = True
                    Form2.Button1.PerformClick()
                    conf_reco2.Dispose()
                    AI_on = True
                End If
            Case "no i don't"
                    synth.SpeakAsync("Welcome back")
                    ends = True
        End Select
    End Sub
End Module
