Public Class browsemain

    Private Sub browsemain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim tab As New TabPage
        Dim newtab As New browsetab
        newtab.Show()
        newtab.Dock = DockStyle.Fill
        newtab.TopLevel = False
        tab.Controls.Add(newtab)
        TabControl1.TabPages.Add(tab)
    End Sub
End Class