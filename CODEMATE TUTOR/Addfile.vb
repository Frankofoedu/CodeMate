Imports System.IO

Public Class Addfile

    Private Sub Addfile_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        WorkArea.Enabled = True
    End Sub

    Private Sub Addfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WorkArea.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim rtn As Integer = MsgBox("Are you sure you want to close", MsgBoxStyle.YesNo)
        If rtn = vbYes Then
            Me.Close()
            WorkArea.Enabled = True
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click


        If TextBox1.Text = "" Then
            MsgBox("Input FILE NAME")
            TextBox1.Focus()
            Exit Sub
        Else
            Dim tab As New TabPage
            Dim doc As String = " "
            Dim recent As String

            WorkArea.newtabcount += 1
            ReDim Preserve WorkArea.newtab(WorkArea.newtabcount)

            WorkArea.newtab(WorkArea.newtabcount) = New tab1

            If RadioButton1.Checked = True Then

                WorkArea.newtab(WorkArea.newtabcount).FName = Path.GetFileName(WorkArea.projectpath & "\" & TextBox1.Text)
                WorkArea.newtab(WorkArea.newtabcount).FPath = WorkArea.projectpath & "\" & TextBox1.Text

                doc = "<HTML>" & vbCrLf & vbTab & "<HEAD>" & vbCrLf & vbTab & vbTab & "<TITLE> </TITLE>" & vbCrLf & vbTab & "</HEAD>" & vbCrLf & vbTab & "<BODY>" & vbCrLf & vbTab & "</BODY>" & vbCrLf & "</HTML>"
                WorkArea.newtab(WorkArea.newtabcount).pad.Text = doc
                WorkArea.newtab(WorkArea.newtabcount).pad.LexerLanguage = "Html"
            ElseIf RadioButton2.Checked = True Then
                WorkArea.newtab(WorkArea.newtabcount).FName = Path.GetFileName(WorkArea.projectpath & "\" & TextBox1.Text)
                WorkArea.newtab(WorkArea.newtabcount).FPath = WorkArea.projectpath & "\" & TextBox1.Text

                WorkArea.newtab(WorkArea.newtabcount).pad.Text = doc
                WorkArea.newtab(WorkArea.newtabcount).pad.LexerLanguage = "Php"
            ElseIf RadioButton3.Checked = True Then
                If My.Computer.FileSystem.DirectoryExists(WorkArea.projectpath & "\styles") = True Then
                    WorkArea.newtab(WorkArea.newtabcount).FName = Path.GetFileName(WorkArea.projectpath & "\styles" & "\" & TextBox1.Text)
                    WorkArea.newtab(WorkArea.newtabcount).FPath = WorkArea.projectpath & "\styles" & "\" & TextBox1.Text
                Else
                    My.Computer.FileSystem.CreateDirectory(WorkArea.projectpath & "\styles")

                    WorkArea.newtab(WorkArea.newtabcount).FName = Path.GetFileName(WorkArea.projectpath & "\styles" & "\" & TextBox1.Text)
                    WorkArea.newtab(WorkArea.newtabcount).FPath = WorkArea.projectpath & "\styles" & "\" & TextBox1.Text

                    WorkArea.newtab(WorkArea.newtabcount).pad.Text = doc
                    WorkArea.newtab(WorkArea.newtabcount).pad.LexerLanguage = "Css"
                End If
            ElseIf RadioButton4.Checked = True Then
                If My.Computer.FileSystem.DirectoryExists(WorkArea.projectpath & "\javascripts") = True Then
                    WorkArea.newtab(WorkArea.newtabcount).FName = Path.GetFileName(WorkArea.projectpath & "\javascripts" & "\" & TextBox1.Text)
                    WorkArea.newtab(WorkArea.newtabcount).FPath = WorkArea.projectpath & "\javascripts" & "\" & TextBox1.Text
                Else
                    My.Computer.FileSystem.CreateDirectory(WorkArea.projectpath & "\javascripts")

                    WorkArea.newtab(WorkArea.newtabcount).FName = Path.GetFileName(WorkArea.projectpath & "\javascripts" & "\" & TextBox1.Text)
                    WorkArea.newtab(WorkArea.newtabcount).FPath = WorkArea.projectpath & "\javascripts" & "\" & TextBox1.Text

                    WorkArea.newtab(WorkArea.newtabcount).pad.Text = doc
                    WorkArea.newtab(WorkArea.newtabcount).pad.LexerLanguage = "Cpp"
                End If
            Else
                WorkArea.newtab(WorkArea.newtabcount).FName = Path.GetFileName(WorkArea.projectpath & "\" & TextBox1.Text)
                WorkArea.newtab(WorkArea.newtabcount).FPath = WorkArea.projectpath & "\" & TextBox1.Text
                WorkArea.newtab(WorkArea.newtabcount).pad.Text = doc
            End If

            WorkArea.mainFPath = WorkArea.newtab(WorkArea.newtabcount).FPath
            If WorkArea.TextBox1.Text = "" Then
                WorkArea.TextBox1.Text = WorkArea.newtab(WorkArea.newtabcount).FPath
            End If

            'If File.Exists(WorkArea.newtab(WorkArea.newtabcount).FPath) Then
            'Else
            '    Dim fs As FileStream = File.Create(WorkArea.newtab(WorkArea.newtabcount).FPath, 100000, FileOptions.Asynchronous)
            'End If

            'File.WriteAllText(workarea.newtab(workarea.newtabcount).FPath, workarea.newtab(workarea.newtabcount).pad.Text)

            WorkArea.newtab(WorkArea.newtabcount).pad.SetSavePoint()

            WorkArea.newtab(WorkArea.newtabcount).Show()
            WorkArea.newtab(WorkArea.newtabcount).Dock = DockStyle.Fill
            WorkArea.newtab(WorkArea.newtabcount).TopLevel = False
            tab.Controls.Add(WorkArea.newtab(WorkArea.newtabcount))
            WorkArea.TabControl2.TabPages.Add(tab)

            If GroupBox1.Enabled = False Then
                WorkArea.TabControl2.SelectedTab.Dispose()
            Else
                WorkArea.TabControl2.SelectedTab = tab
            End If

            recent = File.ReadAllText(recentpath)

            Dim newrecent As String = WorkArea.newtab(WorkArea.newtabcount).FName & " " & WorkArea.newtab(WorkArea.newtabcount).FPath

            If recent.Contains(newrecent) Then
                recent = Strings.Replace(recent, vbCrLf & newrecent & vbCrLf, vbCrLf)
            End If

            recent = newrecent & vbCrLf & recent

            File.WriteAllText(recentpath, recent)

            WorkArea.TabControl2.SelectedTab.Text = WorkArea.newtab(WorkArea.newtabcount).FName
            Me.Close()

        End If

    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If RadioButton1.Checked = True Then
            If TextBox1.Text.Contains(".html") Or TextBox1.Text.Contains(".htm") Or TextBox1.Text.Contains(".HTML") Or TextBox1.Text.Contains(".HTM") Then
            Else
                TextBox1.Text = TextBox1.Text & ".htm"
            End If
        ElseIf RadioButton2.Checked = True Then
            If Not TextBox1.Text.Contains(".php") Or Not TextBox1.Text.Contains(".PHP") Then
                TextBox1.Text = TextBox1.Text & ".php"
            End If
        ElseIf RadioButton3.Checked = True Then
            If Not TextBox1.Text.Contains(".css") Or Not TextBox1.Text.Contains(".CSS") Then
                TextBox1.Text = TextBox1.Text & ".css"
            End If
        ElseIf RadioButton4.Checked = True Then
            If Not TextBox1.Text.Contains(".js") Or Not TextBox1.Text.Contains(".JS") Then
                TextBox1.Text = TextBox1.Text & ".js"
            End If
        ElseIf RadioButton5.Checked = True Then
            If Not TextBox1.Text.Contains(".") Then
                MsgBox("Specify file type")
                TextBox1.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

End Class