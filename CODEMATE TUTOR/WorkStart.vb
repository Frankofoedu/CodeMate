Imports System.IO

Public Class WorkStart
    Public startshown As Boolean
    Dim recentfilename As String
    Dim recentfilepath As String

    Private Sub btnNewProj_Click(sender As Object, e As EventArgs) Handles btnNewProj.Click
        Panel2.Visible = True
        Panel3.Visible = False
    End Sub

    Private Sub btnOldProj_Click(sender As Object, e As EventArgs) Handles btnOldProj.Click
        Panel3.Visible = True
        Panel2.Visible = False
    End Sub

    Private Sub btnProjFolder_Click(sender As Object, e As EventArgs) Handles btnProjFolder.Click
        Dim dlg As FolderBrowserDialog = New FolderBrowserDialog

        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Settings.ProjectsFolder = dlg.SelectedPath
            TextBox1.Text = My.Settings.ProjectsFolder
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Panel2.Visible = False
    End Sub

    Private Sub btnCreateProj_Click(sender As Object, e As EventArgs) Handles btnCreateProj.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            If TextBox1.Text = "" Then
                MsgBox("Select a FOLDER")
                btnProjFolder.Focus()
                Exit Sub
            ElseIf TextBox2.Text = "" Then
                MsgBox("Input PROJECT NAME")
                TextBox2.Focus()
                Exit Sub
            End If
        Else
            If My.Computer.FileSystem.DirectoryExists(TextBox1.Text & "\" & TextBox2.Text) = True Then
                MsgBox("A Folder with the same name exists in " & TextBox1.Text)
                TextBox2.Focus()
            Else
                WorkArea.projectpath = TextBox1.Text & "\" & TextBox2.Text
                My.Computer.FileSystem.CreateDirectory(WorkArea.projectpath)
                Addfile.Show()
                Addfile.GroupBox1.Enabled = False

                If ChkHTML1.Checked = True Then
                    Addfile.RadioButton1.Checked = True
                    Addfile.TextBox1.Text = "index.html"
                ElseIf ChkPHP1.Checked = True Then
                    Addfile.RadioButton2.Checked = True
                    Addfile.TextBox1.Text = "index.php"
                End If

            End If


        End If
        WorkArea.btnRun.Enabled = True
        WorkArea.PictureBox1.Enabled = True
        WorkArea.PictureBox2.Enabled = True
        WorkArea.PictureBox3.Enabled = True
        WorkArea.PictureBox4.Enabled = True
        WorkArea.PictureBox5.Enabled = True
        WorkArea.CheckBox1.Enabled = True

    End Sub

    Private Sub btnCanel1_Click(sender As Object, e As EventArgs) Handles btnCanel1.Click
        Panel3.Visible = False
    End Sub

    Private Sub bntOpen_Click(sender As Object, e As EventArgs) Handles bntOpen.Click
        If TextBox3.Text = "" Then
            MsgBox("Browse for a file first")
            Button4.Focus()
        Else

            Dim tab As New TabPage
            Dim doc As String
            Dim recent As String

            WorkArea.newtabcount += 1
            ReDim Preserve WorkArea.newtab(WorkArea.newtabcount)

            WorkArea.newtab(WorkArea.newtabcount) = New tab1

            doc = File.ReadAllText(TextBox3.Text)
            WorkArea.newtab(WorkArea.newtabcount).pad.Text = doc

            WorkArea.newtab(WorkArea.newtabcount).Show()
            WorkArea.newtab(WorkArea.newtabcount).Dock = DockStyle.Fill
            WorkArea.newtab(WorkArea.newtabcount).TopLevel = False
            tab.Controls.Add(WorkArea.newtab(WorkArea.newtabcount))
            WorkArea.TabControl2.TabPages.Add(tab)

            WorkArea.newtab(WorkArea.newtabcount).FName = Path.GetFileName(TextBox3.Text)
            WorkArea.newtab(WorkArea.newtabcount).FPath = TextBox3.Text
            WorkArea.mainFPath = WorkArea.newtab(WorkArea.newtabcount).FPath

            WorkArea.projectpath = Path.GetDirectoryName(TextBox3.Text)

            WorkArea.newtab(WorkArea.newtabcount).pad.SetSavePoint()
            WorkArea.TextBox1.Text = WorkArea.newtab(WorkArea.newtabcount).FPath

            recent = File.ReadAllText(recentpath)

            Dim newrecent As String = WorkArea.newtab(WorkArea.newtabcount).FName & " " & WorkArea.newtab(WorkArea.newtabcount).FPath

            If recent.Contains(newrecent) Then
                recent = Strings.Replace(recent, vbCrLf & newrecent & vbCrLf, vbCrLf)
            End If

            recent = newrecent & vbCrLf & recent

            File.WriteAllText(recentpath, recent)

            WorkArea.TabControl2.SelectedTab.Dispose()

            WorkArea.PictureBox1.Enabled = True
            WorkArea.PictureBox2.Enabled = True
            WorkArea.PictureBox3.Enabled = True
            WorkArea.PictureBox4.Enabled = True
            WorkArea.PictureBox5.Enabled = True
            WorkArea.btnRun.Enabled = True
            WorkArea.CheckBox1.Enabled = True

            WorkArea.TabControl2.SelectedTab.Text = WorkArea.newtab(WorkArea.newtabcount).FName
        End If
    End Sub

    Private Sub WorkStart_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        startshown = False
        WorkArea.PictureBox1.Enabled = True
        WorkArea.PictureBox2.Enabled = True
        WorkArea.PictureBox3.Enabled = True
        WorkArea.PictureBox4.Enabled = True
        WorkArea.PictureBox5.Enabled = True
        WorkArea.btnRun.Enabled = True
        WorkArea.CheckBox1.Enabled = True

    End Sub

    Private Sub WorkStart_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChkHTML.Checked = True
        Panel2.Visible = False
        Panel3.Visible = False

        TextBox1.Text = My.Settings.ProjectsFolder

        WorkArea.PictureBox1.Enabled = False
        WorkArea.PictureBox2.Enabled = False
        WorkArea.PictureBox3.Enabled = False
        WorkArea.PictureBox4.Enabled = False
        WorkArea.PictureBox5.Enabled = False
        WorkArea.btnRun.Enabled = False
        WorkArea.CheckBox1.Enabled = True

        Dim recentfolder = Application.StartupPath & "/recents/"

        If Not (Directory.Exists(recentfolder)) Then
            Directory.CreateDirectory(recentfolder)
        End If

        recentpath = Application.StartupPath & "/recents/" & curruser & ".txt"

        If Not (File.Exists(recentpath)) Then
            File.WriteAllText(recentpath, "")
        End If

        loadrecent()

        startshown = True

    End Sub

    Private Sub loadrecent()
        Dim recent As String
        Dim array(15) As String

        If Not File.Exists(recentpath) Then
            File.WriteAllText(recentpath, vbCrLf)
            Exit Sub
        Else
            recent = File.ReadAllText(recentpath)
            If recent = vbCrLf Then
                Exit Sub
            End If
            array = Split(recent, vbCrLf)

            ListBox1.Items.AddRange(array)

        End If
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        If ListBox1.SelectedItem = "" Or ListBox1.SelectedItem = " " Then
            Exit Sub
        End If
        Dim array(2) As String
        Dim text As String

        text = ListBox1.SelectedItem

        array = Split(text, " ")

        recentfilename = array(0)
        recentfilepath = array(1)

        openrecent()

    End Sub

    Private Sub openrecent()
        Dim doc As String
        Dim tab As New TabPage
        Dim recent As String

        WorkArea.newtabcount += 1
        ReDim Preserve WorkArea.newtab(WorkArea.newtabcount)

        WorkArea.newtab(WorkArea.newtabcount) = New tab1
        If File.Exists(recentfilepath) Then
            doc = File.ReadAllText(recentfilepath)
        Else
            MsgBox("This file has been deleted or moved.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        WorkArea.newtab(WorkArea.newtabcount).pad.Text = doc

        WorkArea.newtab(WorkArea.newtabcount).Show()
        WorkArea.newtab(WorkArea.newtabcount).Dock = DockStyle.Fill
        WorkArea.newtab(WorkArea.newtabcount).TopLevel = False
        tab.Controls.Add(WorkArea.newtab(WorkArea.newtabcount))
        WorkArea.TabControl2.TabPages.Add(tab)

        WorkArea.newtab(WorkArea.newtabcount).FName = recentfilename
        WorkArea.newtab(WorkArea.newtabcount).FPath = recentfilepath
        WorkArea.mainFPath = WorkArea.newtab(WorkArea.newtabcount).FPath


        recent = File.ReadAllText(recentpath)

        Dim newrecent As String = WorkArea.newtab(WorkArea.newtabcount).FName & " " & WorkArea.newtab(WorkArea.newtabcount).FPath

        If recent.Contains(newrecent) Then
            recent = Strings.Replace(recent, vbCrLf & newrecent & vbCrLf, vbCrLf)
        End If

        recent = newrecent & vbCrLf & recent

        File.WriteAllText(recentpath, recent)

        WorkArea.projectpath = Path.GetDirectoryName(recentfilepath)

        WorkArea.newtab(WorkArea.newtabcount).pad.SetSavePoint()
        WorkArea.TextBox1.Text = WorkArea.newtab(WorkArea.newtabcount).FPath

        WorkArea.TabControl2.SelectedTab.Dispose()

        WorkArea.PictureBox1.Enabled = True
        WorkArea.PictureBox2.Enabled = True
        WorkArea.PictureBox3.Enabled = True
        WorkArea.PictureBox4.Enabled = True
        WorkArea.PictureBox5.Enabled = True
        WorkArea.btnRun.Enabled = True
        WorkArea.CheckBox1.Enabled = True

        WorkArea.TabControl2.SelectedTab.Text = WorkArea.newtab(WorkArea.newtabcount).FName
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog
            If ChkHTML.Checked = True Then
                dlg.Title = "SELECT " & ChkHTML.Text
                dlg.Filter = "Hyper Text Files(*.html;*.htm)| *.html; *.htm"
            Else
                dlg.Title = "SELECT " & ChkPHP.Text
                dlg.Filter = "PHP files(*.php)| *.php"
            End If

            dlg.Multiselect = False

            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                TextBox3.Text = dlg.FileName
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class