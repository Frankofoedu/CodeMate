Imports System.Speech.Recognition
Imports System.Threading
Imports System.Globalization
Imports System.Speech

Public Class WICSform1
    Public WithEvents rec As New Recognition.SpeechRecognitionEngine
    Dim rerec As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub WICSform1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        rec.RecognizeAsyncStop()
        rerec = False
    End Sub

    Private Sub WICSform1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Visible = True Then
            TableLayoutPanel1.Visible = True
        ElseIf Form2.Visible = True Then
            TableLayoutPanel2.Visible = True

        End If
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-GB")
        rec.SetInputToDefaultAudioDevice()
        Dim gram As New Recognition.SrgsGrammar.SrgsDocument
        Dim speak4me As New Recognition.SrgsGrammar.SrgsRule("command")
        'here you add all the words you want to say before you say your search word
        Dim commandList As New Recognition.SrgsGrammar.SrgsOneOf("code mate take me back")
        speak4me.Add(commandList)
        gram.Rules.Add(speak4me)
        gram.Root = speak4me
        rec.LoadGrammar(New Recognition.Grammar(gram))
        rec.RecognizeAsync()

    End Sub

    Private Sub rec_RecognizeCompleted(sender As Object, e As RecognizeCompletedEventArgs) Handles rec.RecognizeCompleted
        If rerec = True Then
            rec.RecognizeAsync()
        End If
    End Sub

    Private Sub rec_SpeechRecognized(sender As Object, e As SpeechRecognizedEventArgs) Handles rec.SpeechRecognized
        Select e.Result.Text
            Case "code mate take me back"
                Me.Close()
            Case Else
                rerec = True

        End Select

    End Sub
End Class