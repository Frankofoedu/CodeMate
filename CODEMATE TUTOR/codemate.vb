Imports System.IO

Module codemate
    Public curruser As String
    Public userpath As String
    Public userinfo As String
    Public pan1X, pan1Y, pan1Height, pan1Width As Integer
    Public txtnewX, txtnewY, txtnewHeight, txtnewWidth As Integer
    Public currentX, currentY As Integer
    Public currheight, currwidth As Integer
    Public panTutX, panTutY, panTutHeight, panTutWidth As Integer
    Public testpath, recentpath, audiopath As String
    Public AI_on As Boolean = False

    Public Sub slideInDown(ctrl As Control, stepp As Integer)

        If ctrl.Tag = Form1.Panel1.Tag Then

            currentX = pan1X
            currentY = pan1Y
            currheight = pan1Height
            currwidth = pan1Width

        ElseIf ctrl.Tag = Form1.txtNEWUSER.Tag Then

            currentX = txtnewX
            currentY = txtnewY
            currheight = txtnewHeight
            currwidth = txtnewWidth

        ElseIf ctrl.Tag = Form2.mainTUTpanel.Tag Then

            currentX = panTutX
            currentY = panTutY
            currheight = panTutHeight
            currwidth = panTutWidth

        Else

            currentX = ctrl.Top
            currentY = ctrl.Left
            currheight = ctrl.Height
            currwidth = ctrl.Width

        End If

        For x As Integer = 1 To currheight Step stepp
            ctrl.Height = x
            Threading.Thread.Sleep(1)
        Next
    End Sub

    Public Sub slideOutUp(ctrl As Control, stepp As Integer)

        If ctrl.Tag = Form1.Panel1.Tag Then

            currentX = pan1X
            currentY = pan1Y
            currheight = pan1Height
            currwidth = pan1Width

        ElseIf ctrl.Tag = Form1.txtNEWUSER.Tag Then

            currentX = txtnewX
            currentY = txtnewY
            currheight = txtnewHeight
            currwidth = txtnewWidth

        ElseIf ctrl.Tag = Form2.mainTUTpanel.Tag Then

            currentX = panTutX
            currentY = panTutY
            currheight = panTutHeight
            currwidth = panTutWidth

        Else

            currentX = ctrl.Top
            currentY = ctrl.Left
            currheight = ctrl.Height
            currwidth = ctrl.Width

        End If

        For x As Integer = 1 To currheight Step stepp
            ctrl.Height = currheight - x
            Threading.Thread.Sleep(1)
        Next
    End Sub


    Public Sub slideInRight(ctrl As Control, stepp As Integer)

        If ctrl.Tag = Form1.Panel1.Tag Then

            currentX = pan1X
            currentY = pan1Y
            currheight = pan1Height
            currwidth = pan1Width

        ElseIf ctrl.Tag = Form1.txtNEWUSER.Tag Then

            currentX = txtnewX
            currentY = txtnewY
            currheight = txtnewHeight
            currwidth = txtnewWidth

        ElseIf ctrl.Tag = Form2.mainTUTpanel.Tag Then

            currentX = panTutX
            currentY = panTutY
            currheight = panTutHeight
            currwidth = panTutWidth

        Else

            currentX = ctrl.Top
            currentY = ctrl.Left
            currheight = ctrl.Height
            currwidth = ctrl.Width

        End If

        ctrl.Height = currheight

        For y As Integer = 1 To currwidth Step stepp
            ctrl.Refresh()
            ctrl.Width = y
            Threading.Thread.Sleep(1)
        Next
    End Sub

    Public Sub slideoutright(ctrl As Control, stepp As Integer)

        If ctrl.Tag = Form1.Panel1.Tag Then

            currentX = pan1X
            currentY = pan1Y
            currheight = pan1Height
            currwidth = pan1Width

        ElseIf ctrl.Tag = Form1.txtNEWUSER.Tag Then

            currentX = txtnewX
            currentY = txtnewY
            currheight = txtnewHeight
            currwidth = txtnewWidth

        ElseIf ctrl.Tag = Form2.mainTUTpanel.Tag Then

            currentX = panTutX
            currentY = panTutY
            currheight = panTutHeight
            currwidth = panTutWidth

        Else

            currentX = ctrl.Top
            currentY = ctrl.Left
            currheight = ctrl.Height
            currwidth = ctrl.Width

        End If

        For y As Integer = 1 To currwidth Step stepp
            ctrl.Width = currwidth - y
            Threading.Thread.Sleep(3)
        Next
    End Sub

    Public Sub slideInLeft(ctrl As Control, stepp As Integer)

        If ctrl.Tag = Form1.Panel1.Tag Then

            currentX = pan1X
            currentY = pan1Y
            currheight = pan1Height
            currwidth = pan1Width

        ElseIf ctrl.Tag = Form1.txtNEWUSER.Tag Then

            currentX = txtnewX
            currentY = txtnewY
            currheight = txtnewHeight
            currwidth = txtnewWidth

        ElseIf ctrl.Tag = Form2.mainTUTpanel.Tag Then

            currentX = panTutX
            currentY = panTutY
            currheight = panTutHeight
            currwidth = panTutWidth

        Else

            currentX = ctrl.Top
            currentY = ctrl.Left
            currheight = ctrl.Height
            currwidth = ctrl.Width

        End If

        Dim left As Integer = ctrl.Left + currwidth
        ctrl.Height = currheight

        For y As Integer = 1 To currwidth Step stepp
            ctrl.Width = y
            ctrl.Left = left - y
            ctrl.Refresh()
            Threading.Thread.Sleep(1)
        Next
    End Sub
    Public Sub slideoutleft(ctrl As Control, stepp As Integer)
        If ctrl.Tag = Form1.Panel1.Tag Then

            currentX = pan1X
            currentY = pan1Y
            currheight = pan1Height
            currwidth = pan1Width

        ElseIf ctrl.Tag = Form1.txtNEWUSER.Tag Then

            currentX = txtnewX
            currentY = txtnewY
            currheight = txtnewHeight
            currwidth = txtnewWidth

        ElseIf ctrl.Tag = Form2.mainTUTpanel.Tag Then

            currentX = panTutX
            currentY = panTutY
            currheight = panTutHeight
            currwidth = panTutWidth

        Else

            currentX = ctrl.Top
            currentY = ctrl.Left
            currheight = ctrl.Height
            currwidth = ctrl.Width

        End If

        Dim left As Integer = ctrl.Left
        ctrl.Height = currheight

        For y As Integer = 1 To currwidth Step stepp
            ctrl.Width = currwidth - y
            ctrl.Left = left + y
            Threading.Thread.Sleep(1)
        Next
    End Sub

    Public Sub slideInUp(ctrl As Control, stepp As Integer)

        If ctrl.Tag = Form1.Panel1.Tag Then

            currentX = pan1X
            currentY = pan1Y
            currheight = pan1Height
            currwidth = pan1Width

        ElseIf ctrl.Tag = Form1.txtNEWUSER.Tag Then

            currentX = txtnewX
            currentY = txtnewY
            currheight = txtnewHeight
            currwidth = txtnewWidth

        ElseIf ctrl.Tag = Form2.mainTUTpanel.Tag Then

            currentX = panTutX
            currentY = panTutY
            currheight = panTutHeight
            currwidth = panTutWidth

        Else

            currentX = ctrl.Top
            currentY = ctrl.Left
            currheight = ctrl.Height
            currwidth = ctrl.Width

        End If

        Dim top As Integer = ctrl.Top + currheight

        For x As Integer = 1 To currheight Step stepp
            ctrl.Height = x
            ctrl.Top = top - x
            Threading.Thread.Sleep(1)
        Next
    End Sub

    Public Sub spread(ctrl As Control, stepp As Integer)

        If ctrl.Tag = Form1.Panel1.Tag Then

            currentX = pan1X
            currentY = pan1Y
            currheight = pan1Height
            currwidth = pan1Width

        ElseIf ctrl.Tag = Form1.txtNEWUSER.Tag Then

            currentX = txtnewX
            currentY = txtnewY
            currheight = txtnewHeight
            currwidth = txtnewWidth

        ElseIf ctrl.Tag = Form2.mainTUTpanel.Tag Then

            currentX = panTutX
            currentY = panTutY
            currheight = panTutHeight
            currwidth = panTutWidth

        Else

            currentX = ctrl.Top
            currentY = ctrl.Left
            currheight = ctrl.Height
            currwidth = ctrl.Width

        End If

        Dim mtop As Integer = currentX + CInt(currheight / 2)

        For x As Integer = 1 To currheight Step stepp
            ctrl.Height = x
            ctrl.Top = mtop - x / 2
            Threading.Thread.Sleep(1)
        Next
    End Sub
    Public Sub stretch(ctrl As Control, stepp As Integer)

        If ctrl.Tag = Form1.Panel1.Tag Then

            currentX = pan1X
            currentY = pan1Y
            currheight = pan1Height
            currwidth = pan1Width

        ElseIf ctrl.Tag = Form1.txtNEWUSER.Tag Then

            currentX = txtnewX
            currentY = txtnewY
            currheight = txtnewHeight
            currwidth = txtnewWidth

        ElseIf ctrl.Tag = Form2.mainTUTpanel.Tag Then

            currentX = panTutX
            currentY = panTutY
            currheight = panTutHeight
            currwidth = panTutWidth

        Else

            currentX = ctrl.Top
            currentY = ctrl.Left
            currheight = ctrl.Height
            currwidth = ctrl.Width

        End If

        Dim mleft As Integer = currentY + CInt(currwidth / 2)

        ctrl.Height = currheight

        For y As Integer = 1 To currwidth Step stepp
            ctrl.Width = y
            ctrl.Left = mleft - y / 2
            Threading.Thread.Sleep(1)
        Next
    End Sub

    Public Sub RndSlideIn(ctrl As Control, stepp As Integer)
        If ctrl.Visible = False Then ctrl.Visible = True

10:     Dim rand As Integer = CInt(Rnd() * Rnd() * 12.25)
        If rand < 1 Or rand > 6 Then
            GoTo 10
        ElseIf rand = 1 Then
            slideInDown(ctrl, 2)
        ElseIf rand = 2 Then
            slideInRight(ctrl, 2)
        ElseIf rand = 3 Then
            slideInUp(ctrl, 2)
        ElseIf rand = 4 Then
            slideInLeft(ctrl, 2)
        ElseIf rand = 5 Then
            spread(ctrl, 2)
        ElseIf rand = 6 Then
            stretch(ctrl, 2)
        End If

    End Sub

    Public Sub RndSlideOut(ctrl As Control, stepp As Integer)
        If ctrl.Visible = False Then ctrl.Visible = True

20:     Dim rand As Integer = CInt(Rnd() * Rnd() * 12.25)
        If rand < 1 Or rand > 3 Then
            GoTo 20
        ElseIf rand = 1 Then
            slideoutleft(ctrl, 2)
        ElseIf rand = 2 Then
            slideoutright(ctrl, 2)
        ElseIf rand = 3 Then
            slideOutUp(ctrl, 2)
        End If

    End Sub

    Public Sub loaduserlist()
        Dim path As String = Application.StartupPath & "\users\"

        If Not (Directory.Exists(path)) Then
            Directory.CreateDirectory(path)
        End If

        Dim dir As New DirectoryInfo(path)
        Dim direc As FileInfo() = dir.GetFiles()
        Dim dr As FileInfo

        For Each dr In direc
            Dim x() As String = Split(dr.ToString, ".")
            Form1.listUSERS.Items.Add(x(0))
        Next
    End Sub

    Public Sub DeleteCurUser()
        File.Delete(Application.StartupPath & "/users/" & curruser & ".txt")
        File.Delete(Application.StartupPath & "/users/" & curruser & "/" & curruser & ".html")
        Directory.Delete(Application.StartupPath & "/users/" & curruser)
        Form1.listUSERS.Items.Clear()
        loaduserlist()
    End Sub

    Public Sub center(ctrl As Control)
        ctrl.Left = (ctrl.Parent.Width / 2) - (ctrl.Width / 2)
    End Sub
End Module
