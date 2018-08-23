<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tab1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEASToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CLOSETABToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UNDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FORMATToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FONTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COLORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pad = New ScintillaNET.Scintilla()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 47)
        Me.Panel1.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.EDITToolStripMenuItem, Me.FORMATToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(158, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NEWToolStripMenuItem, Me.OPENToolStripMenuItem, Me.SAVEToolStripMenuItem, Me.SAVEASToolStripMenuItem1, Me.ToolStripSeparator1, Me.CLOSETABToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'NEWToolStripMenuItem
        '
        Me.NEWToolStripMenuItem.Name = "NEWToolStripMenuItem"
        Me.NEWToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.NEWToolStripMenuItem.Text = "NEW TAB"
        '
        'OPENToolStripMenuItem
        '
        Me.OPENToolStripMenuItem.Name = "OPENToolStripMenuItem"
        Me.OPENToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.OPENToolStripMenuItem.Text = "OPEN"
        '
        'SAVEToolStripMenuItem
        '
        Me.SAVEToolStripMenuItem.Name = "SAVEToolStripMenuItem"
        Me.SAVEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SAVEToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.SAVEToolStripMenuItem.Text = "SAVE"
        '
        'SAVEASToolStripMenuItem1
        '
        Me.SAVEASToolStripMenuItem1.Name = "SAVEASToolStripMenuItem1"
        Me.SAVEASToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SAVEASToolStripMenuItem1.Size = New System.Drawing.Size(199, 22)
        Me.SAVEASToolStripMenuItem1.Text = "SAVE AS..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(196, 6)
        '
        'CLOSETABToolStripMenuItem
        '
        Me.CLOSETABToolStripMenuItem.Name = "CLOSETABToolStripMenuItem"
        Me.CLOSETABToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CLOSETABToolStripMenuItem.Text = "CLOSE TAB"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UNDOToolStripMenuItem, Me.REDOToolStripMenuItem, Me.ToolStripSeparator2})
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.EDITToolStripMenuItem.Text = "EDIT"
        '
        'UNDOToolStripMenuItem
        '
        Me.UNDOToolStripMenuItem.Name = "UNDOToolStripMenuItem"
        Me.UNDOToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.UNDOToolStripMenuItem.Text = "UNDO"
        '
        'REDOToolStripMenuItem
        '
        Me.REDOToolStripMenuItem.Name = "REDOToolStripMenuItem"
        Me.REDOToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.REDOToolStripMenuItem.Text = "REDO"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(105, 6)
        '
        'FORMATToolStripMenuItem
        '
        Me.FORMATToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FONTToolStripMenuItem, Me.COLORToolStripMenuItem})
        Me.FORMATToolStripMenuItem.Name = "FORMATToolStripMenuItem"
        Me.FORMATToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.FORMATToolStripMenuItem.Text = "FORMAT"
        '
        'FONTToolStripMenuItem
        '
        Me.FONTToolStripMenuItem.Name = "FONTToolStripMenuItem"
        Me.FONTToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.FONTToolStripMenuItem.Text = "FONT"
        '
        'COLORToolStripMenuItem
        '
        Me.COLORToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundToolStripMenuItem, Me.FontToolStripMenuItem1})
        Me.COLORToolStripMenuItem.Name = "COLORToolStripMenuItem"
        Me.COLORToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.COLORToolStripMenuItem.Text = "COLOR"
        '
        'BackgroundToolStripMenuItem
        '
        Me.BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem"
        Me.BackgroundToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.BackgroundToolStripMenuItem.Text = "Background"
        '
        'FontToolStripMenuItem1
        '
        Me.FontToolStripMenuItem1.Name = "FontToolStripMenuItem1"
        Me.FontToolStripMenuItem1.Size = New System.Drawing.Size(138, 22)
        Me.FontToolStripMenuItem1.Text = "Font"
        '
        'pad
        '
        Me.pad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pad.Lexer = ScintillaNET.Lexer.Html
        Me.pad.Location = New System.Drawing.Point(0, 47)
        Me.pad.Name = "pad"
        Me.pad.Size = New System.Drawing.Size(804, 455)
        Me.pad.TabIndex = 5
        Me.pad.Text = "Scintilla1"
        '
        'tab1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 502)
        Me.Controls.Add(Me.pad)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tab1"
        Me.Text = "tab1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OPENToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAVEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAVEASToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CLOSETABToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EDITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UNDOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REDOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FORMATToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FONTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COLORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pad As ScintillaNET.Scintilla
End Class
