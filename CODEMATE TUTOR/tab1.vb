Imports System.IO

Public Class tab1
    Public FName As String
    Public FPath As String
    Public IsSaved As Boolean = False
    Public IsLoaded As Boolean

    Private Sub NEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWToolStripMenuItem.Click
        Addfile.Show()
        IsSaved = False
    End Sub

    Public Sub save()
        Dim A As Integer
        A = WorkArea.TabControl2.TabPages.IndexOf(WorkArea.TabControl2.SelectedTab)

1:      Threading.Thread.Sleep(500)

        File.WriteAllText(WorkArea.newtab(WorkArea.newtabcount).FPath, WorkArea.newtab(A).pad.Text)
        On Error GoTo 1
        WorkArea.newtab(A).pad.SetSavePoint()

        IsSaved = True

    End Sub

    Private Sub OPENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPENToolStripMenuItem.Click
        Dim doc As String
        Dim A As Integer
        A = WorkArea.TabControl2.TabPages.IndexOf(WorkArea.TabControl2.SelectedTab)

        Try

            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.Title = "OPEN"
            dlg.Multiselect = False
            dlg.Filter = "All Files(*.*)| *.*| Text Files(*.rtf;*.txt)| *.rtf;*.txt| Hyper Text Files(*.html;*.htm)| *.html;*.htm| Stylesheets(*.css)| *.css| JavaScipt Files(*.js)| *.js| PHP files(*.php)| *.php"
            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                doc = File.ReadAllText(dlg.FileName)
                pad.Text = doc
                WorkArea.newtab(A).FName = Path.GetFileName(dlg.FileName)
                WorkArea.newtab(A).FPath = dlg.FileName
                WorkArea.mainFPath = WorkArea.newtab(A).FPath
                pad.SetSavePoint()
                IsSaved = True
                Parent.Text = WorkArea.newtab(WorkArea.newtabcount).FName
                If WorkArea.TextBox1.Text = "" Then
                    WorkArea.TextBox1.Text = WorkArea.newtab(A).FPath
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SAVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAVEToolStripMenuItem.Click
        Dim dlg As SaveFileDialog = New SaveFileDialog
        Dim A As Integer

        A = WorkArea.TabControl2.TabPages.IndexOf(WorkArea.TabControl2.SelectedTab)


        If WorkArea.newtab(A).FPath = "" Then
            SAVEASToolStripMenuItem1.PerformClick()
        Else
            save()
        End If
    End Sub


    Private Sub SAVEASToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SAVEASToolStripMenuItem1.Click
        Try

            Dim a As Integer
            a = WorkArea.TabControl2.TabPages.IndexOf(WorkArea.TabControl2.SelectedTab)

            Dim dlg As SaveFileDialog = New SaveFileDialog
            dlg.Title = "SAVE AS"
            dlg.Filter = "Text Files(*.txt;*.rtf)| *.txt;*.rtf| Hyper Text Files(*.html;*.htm)| *.html;*.htm| Stylesheets(*.css)| *.css| JavaScipt Files(*.js)| *.js| PHP files(*.php)| *.php"

            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                WorkArea.newtab(a).FPath = dlg.FileName
                save()
                WorkArea.newtab(a).FName = Path.GetFileName(dlg.FileName)
                WorkArea.newtab(a).pad.SetSavePoint()
                Parent.Text = WorkArea.newtab(a).FName
                If WorkArea.TextBox1.Text = "" Then
                    WorkArea.TextBox1.Text = WorkArea.newtab(a).FPath
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub CLOSETABToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLOSETABToolStripMenuItem.Click
        If WorkArea.TabControl2.TabCount = 1 Then
            WorkArea.newtabcount = -1
            Dim startpag As New TabPage
            Dim newtab2 As New WorkStart
            newtab2.Show()
            newtab2.Dock = DockStyle.Fill
            newtab2.TopLevel = False
            startpag.Controls.Add(newtab2)
            WorkArea.TabControl2.TabPages.Add(startpag)
            WorkArea.TabControl2.SelectedTab.Text = "StartPage"
        Else
            WorkArea.TabControl2.SelectedTab.Dispose()
        End If
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Dim rtn As Integer = MsgBox("Are you sure you want to EXIT?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Exit Confirmation")
        If rtn = vbYes Then
            WorkArea.Close()
        End If
    End Sub

    Private Sub REDOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REDOToolStripMenuItem.Click
        Dim a As Integer
        a = WorkArea.TabControl2.TabPages.IndexOf(WorkArea.TabControl2.SelectedTab)
        WorkArea.newtab(a).pad.Redo()
    End Sub

    Private Sub UNDOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UNDOToolStripMenuItem.Click
        Dim a As Integer
        a = WorkArea.TabControl2.TabPages.IndexOf(WorkArea.TabControl2.SelectedTab)
        WorkArea.newtab(a).pad.Undo()
    End Sub

    Private Sub BackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundToolStripMenuItem.Click
        Try
            Dim dlg As ColorDialog = New ColorDialog
            dlg.Color = pad.BackColor
            If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim a As Integer
                a = WorkArea.TabControl2.TabPages.IndexOf(WorkArea.TabControl2.SelectedTab)
                WorkArea.newtab(a).pad.BackColor = dlg.Color
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FONTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FONTToolStripMenuItem.Click
        Try
            Dim dlg As FontDialog = New FontDialog
            If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim a As Integer
                a = WorkArea.TabControl2.TabPages.IndexOf(WorkArea.TabControl2.SelectedTab)
                WorkArea.newtab(a).pad.Font = dlg.Font
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pad_TextChanged(sender As Object, e As EventArgs) Handles pad.TextChanged
        IsSaved = False
    End Sub
End Class