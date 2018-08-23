Imports System.IO
Public Class openfile

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog
            If ChkHTML.Checked = True Then
                dlg.Title = "SELECT HTML FILE"
                dlg.Filter = "Hyper Text Files(*.html;*.htm)| *.html; *.htm"
            ElseIf ChkPHP.Checked = True Then
                dlg.Title = "SELECT PHP FILE"
                dlg.Filter = "PHP files(*.php)| *.php"
            ElseIf ChkCSS.Checked = True Then
                dlg.Title = "SELECT CSS FILE"
                dlg.Filter = "CSS files(*.css)| *.css"
            ElseIf ChkJS.Checked = True Then
                dlg.Title = "SELECT JAVA SCRIPT FILE"
                dlg.Filter = "JS files(*.js)| *.js"
            ElseIf ChkOTHERS.Checked =
                dlg.Title = "SELECT OTHER FILE" Then
                dlg.Filter = "ALL files(*.*)| *.*"

            End If

            dlg.Multiselect = False

            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                TextBox3.Text = dlg.FileName
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If TextBox3.Text = "" Then
            MsgBox("Browse for a file first")
            btnOpen.Focus()
        Else

            Dim tab As New TabPage
            Dim doc As String
            Dim recent As String

            WorkArea.newtabcount += 1
            ReDim Preserve WorkArea.newtab(WorkArea.newtabcount)
            WorkArea.newtab(WorkArea.newtabcount) = tab1

            doc = File.ReadAllText(TextBox3.Text)
            WorkArea.newtab(WorkArea.newtabcount).pad.Text = doc

            WorkArea.newtab(WorkArea.newtabcount).Show()
            WorkArea.newtab(WorkArea.newtabcount).Dock = DockStyle.Fill
            WorkArea.newtab(WorkArea.newtabcount).TopLevel = False
            tab.Controls.Add(WorkArea.newtab(WorkArea.newtabcount))
            WorkArea.TabControl2.TabPages.Add(tab)

            WorkArea.newtab(WorkArea.newtabcount).FName = Path.GetFileName(TextBox3.Text)
            WorkArea.newtab(WorkArea.newtabcount).FPath = TextBox3.Text

            If WorkArea.TextBox1.Text = "" Then
                WorkArea.projectpath = Path.GetDirectoryName(TextBox3.Text)
            End If

            WorkArea.TabControl2.SelectedTab = tab
            WorkArea.TabControl2.SelectedTab.Text = WorkArea.newtab(WorkArea.newtabcount).FName
            If ChkHTML.Checked = True Then
                WorkArea.newtab(WorkArea.newtabcount).pad.LexerLanguage = "Html"
            ElseIf ChkJS.Checked = True Then
                WorkArea.newtab(WorkArea.newtabcount).pad.LexerLanguage = "cpp"
            End If


            recent = File.ReadAllText(recentpath)

            Dim newrecent As String = WorkArea.newtab(WorkArea.newtabcount).FName & " " & WorkArea.newtab(WorkArea.newtabcount).FPath

            If recent.Contains(newrecent) Then
                recent = Strings.Replace(recent, vbCrLf & newrecent & vbCrLf, vbCrLf)
            End If

            recent = newrecent & vbCrLf & recent

            File.WriteAllText(recentpath, recent)

            Me.Close()

        End If
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
End Class