Public Class tab2
    Dim txtfocus As Integer = 0

    Private Sub SToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RemoveTabToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ADDTABToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDTABToolStripMenuItem.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If WebBrowser1.CanGoBack Then
            WebBrowser1.GoBack()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If WebBrowser1.CanGoForward Then
            WebBrowser1.GoForward()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If WebBrowser1.IsBusy Then
            WebBrowser1.Stop()
            PictureBox1.Visible = False
            Parent.Text = "Stopped"
            PictureBox4.Image = My.Resources.Reload
        ElseIf Not WebBrowser1.IsBusy Then
            WebBrowser1.Refresh()
            PictureBox4.Image = My.Resources.close2
            btnGo.PerformClick()
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        WebBrowser1.Url = New Uri(My.Settings.Homepage)
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

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        txtfocus = 0
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

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
        If WorkArea.runclicked = True Then
            tab1.IsLoaded = True
        End If
    End Sub

    Private Sub tab2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        WorkArea.Enabled = True
    End Sub

    Private Sub tab2_Load(sender As Object, e As EventArgs) Handles Me.Load
        WorkArea.Enabled = False
    End Sub
    Private Sub WebBrowser1_DocumentCompleted_1(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Me.Text = WebBrowser1.DocumentTitle
        TextBox1.Text = WebBrowser1.Url.ToString
    End Sub

    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        PictureBox4.Image = My.Resources.close2
        PictureBox1.Visible = True
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        Me.Text = WebBrowser1.DocumentTitle
        PictureBox4.Image = My.Resources.Reload
        PictureBox1.Visible = False
        WorkArea.urltext = TextBox1.Text
    End Sub
End Class