Public Class browsetab

    Dim txtfocus As Integer = 0

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        settings.Show()
    End Sub
    Private Sub tab_Load(sender As Object, e As EventArgs) Handles Me.Load
        WebBrowser1.Url = New Uri(My.Settings.Homepage)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        WebBrowser1.Url = New Uri(My.Settings.Homepage)
    End Sub



    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".org") Or TextBox1.Text.Contains(".ng") Or TextBox1.Text.Contains("localhost") Or TextBox1.Text.Contains("c:") Or TextBox1.Text.Contains("C:") Then
            Try
                WebBrowser1.Url = New Uri(TextBox1.Text)
            Catch ex As System.UriFormatException
                If TextBox1.Text.Contains("www.") Or TextBox1.Text.Contains("localhost") Then
                    WebBrowser1.Url = New Uri("http://" + TextBox1.Text)
                    TextBox1.Text = "http://" + TextBox1.Text
                ElseIf Not TextBox1.Text.Contains("www.") And TextBox1.Text.Contains("localhost") Then
                    WebBrowser1.Url = New Uri("http://www." + TextBox1.Text)
                    TextBox1.Text = "http://www." + TextBox1.Text
                End If
            End Try
        Else
            If My.Settings.SearchEngine = 1 Then
                WebBrowser1.Url = New Uri("https://www.google.com/search?q=" + TextBox1.Text)
                TextBox1.Text = "https://www.google.com/search?q=" + TextBox1.Text
            ElseIf My.Settings.SearchEngine = 2 Then
                WebBrowser1.Url = New Uri("http://www.youtube.com/results?search_query=" + TextBox1.Text)
                TextBox1.Text = "http://www.youtube.com/results?search_query=" + TextBox1.Text
            ElseIf My.Settings.SearchEngine = 3 Then
                WebBrowser1.Url = New Uri("https://search.yahoo.com/search?ei=UTF-8&fr=crmas&p=" + TextBox1.Text)
                TextBox1.Text = "https://search.yahoo.com/search?ei=UTF-8&fr=crmas&p=" + TextBox1.Text
            ElseIf My.Settings.SearchEngine = 4 Then
                WebBrowser1.Url = New Uri("http://www.bing.com/search?q=" + TextBox1.Text)
                TextBox1.Text = "http://www.bing.com/search?q=" + TextBox1.Text
            ElseIf My.Settings.SearchEngine = 5 Then
                WebBrowser1.Url = New Uri("http://www.ask.com/web?q=" + TextBox1.Text)
                TextBox1.Text = "http://www.ask.com/web?q=" + TextBox1.Text
            ElseIf My.Settings.SearchEngine = 6 Then
                WebBrowser1.Url = New Uri(My.Settings.CustomSearch + TextBox1.Text)
            End If

        End If
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If WebBrowser1.CanGoBack Then
            WebBrowser1.GoBack()
        End If
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        If WebBrowser1.CanGoForward Then
            WebBrowser1.GoForward()
        End If
    End Sub

    Private Sub btnXnR_Click(sender As Object, e As EventArgs) Handles btnXnR.Click
        If WebBrowser1.IsBusy Then
            WebBrowser1.Stop()
            PictureBox1.Visible = False
            Parent.Text = "Stopped"
            btnXnR.Text = "R"
        ElseIf Not WebBrowser1.IsBusy Then
            WebBrowser1.Refresh()
            btnXnR.Text = "X"
            btnGo.PerformClick()
        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click

        If txtfocus = 0 Then
            TextBox1.SelectAll()
        End If
        txtfocus = 1

    End Sub

    Private Sub TextBox1_DoubleClick(sender As Object, e As EventArgs) Handles TextBox1.DoubleClick
        txtfocus = 0
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnGo.PerformClick()
        End If

    End Sub

    Private Sub AddTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTabToolStripMenuItem.Click

        Dim tab As New TabPage
        Dim newtab As New browsetab
        newtab.Show()
        newtab.Dock = DockStyle.Fill
        newtab.TopLevel = False
        tab.Controls.Add(newtab)
        browsemain.TabControl1.TabPages.Add(tab)
        browsemain.TabControl1.SelectedTab = tab

    End Sub

    Private Sub RemoveTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveTabToolStripMenuItem.Click

        If browsemain.TabControl1.TabCount = 1 Then

            Dim tab As New TabPage
            Dim newtab As New browsetab
            newtab.Show()
            newtab.Dock = DockStyle.Fill
            newtab.TopLevel = False
            tab.Controls.Add(newtab)
            browsemain.TabControl1.SelectedTab.Dispose()
            browsemain.TabControl1.TabPages.Add(tab)
            browsemain.TabControl1.SelectedTab = tab
        Else
            browsemain.TabControl1.SelectedTab.Dispose()
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        txtfocus = 0
    End Sub

    Private Sub btnlisten_Click(sender As Object, e As EventArgs) Handles btnlisten.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        If browsemain.Visible = True Then
            RemoveTabToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        btnXnR.Text = "X"
        PictureBox1.Visible = True
    End Sub

    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        TextBox1.Text = WebBrowser1.Url.ToString
        btnXnR.Text = "R"
        'Parent.Text = WebBrowser1.Title
        PictureBox1.Visible = False
    End Sub
End Class