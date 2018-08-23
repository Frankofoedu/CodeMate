Public Class settings

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.Homepage

        If My.Settings.SearchEngine = 1 Then
            RadioButton1.Checked = True
        ElseIf My.Settings.SearchEngine = 2 Then
            RadioButton2.Checked = True
        ElseIf My.Settings.SearchEngine = 3 Then
            RadioButton3.Checked = True
        ElseIf My.Settings.SearchEngine = 4 Then
            RadioButton4.Checked = True
        ElseIf My.Settings.SearchEngine = 5 Then
            RadioButton5.Checked = True
        ElseIf My.Settings.SearchEngine = 6 Then
            RadioButton6.Checked = True
        End If
        TextBox2.Text = My.Settings.CustomSearch

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".org") Or TextBox1.Text.Contains(".ng") Or TextBox1.Text.Contains("localhost/") Then
            If TextBox1.Text.Contains("http://www.") Or TextBox1.Text.Contains("https://www.") Then
                My.Settings.Homepage = TextBox1.Text
            ElseIf Not TextBox1.Text.Contains("http://www.") Or TextBox1.Text.Contains("https://www.") Then
                If TextBox1.Text.Contains("www.") Or TextBox1.Text.Contains("localhost/") Then
                    My.Settings.Homepage = "http://" + TextBox1.Text
                ElseIf Not TextBox1.Text.Contains("www.") Or TextBox1.Text.Contains("localhost/") Then
                    My.Settings.Homepage = "http://www." + TextBox1.Text
                End If
            End If
            MsgBox("Done..." + vbCrLf + "Your new home is '" + My.Settings.Homepage + "'")
            TextBox1.Text = My.Settings.Homepage
        Else
            MsgBox("Please input a Valid url")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.Homepage = "http://www.google.com"
        TextBox1.Text = My.Settings.Homepage
        MsgBox("Done...")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        My.Settings.SearchEngine = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        My.Settings.SearchEngine = 2
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        My.Settings.SearchEngine = 3
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        My.Settings.SearchEngine = 4
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        My.Settings.SearchEngine = 5
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        My.Settings.SearchEngine = 6
        My.Settings.CustomSearch = TextBox2.Text.ToString
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If My.Settings.SearchEngine = 6 Then
            If TextBox2.Text = Nothing Then
                MsgBox("Enter a search URL")
            ElseIf TextBox2.Text.Contains("http://www.") Or TextBox2.Text.Contains("https://www.") Or TextBox2.Text.Contains("http://") Or TextBox2.Text.Contains("https://") Then
                My.Settings.CustomSearch = TextBox2.Text.ToString
                MsgBox("Done!!!")
            Else
                MsgBox("Please insert a valid URL. URL must be of the form 'http://www.' or 'https://www.'...")
                TextBox2.Focus()
            End If

        Else
            MsgBox("Please select 'Custom Search' and input the URL first...")
            My.Settings.SearchEngine = 1
            RadioButton1.Checked = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RadioButton1.Checked = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button5.PerformClick()
        Button2.PerformClick()
    End Sub
End Class