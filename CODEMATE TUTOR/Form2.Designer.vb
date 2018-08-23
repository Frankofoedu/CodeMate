<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pad = New ScintillaNET.Scintilla()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLoadHTML = New System.Windows.Forms.Button()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.listChapters = New System.Windows.Forms.ListBox()
        Me.mainTUTpanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LearnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picMMize = New System.Windows.Forms.PictureBox()
        Me.picRestoreDown = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnpause = New System.Windows.Forms.Button()
        Me.btnread = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnPrev = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.mainTUTpanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picMMize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRestoreDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.WebBrowser2)
        Me.GroupBox2.Controls.Add(Me.pad)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnLoadHTML)
        Me.GroupBox2.Controls.Add(Me.Splitter2)
        Me.GroupBox2.Controls.Add(Me.Splitter1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(677, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 678)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DO IT YOURSELF"
        Me.GroupBox2.Visible = False
        '
        'pad
        '
        Me.pad.Location = New System.Drawing.Point(6, 17)
        Me.pad.Name = "pad"
        Me.pad.Size = New System.Drawing.Size(338, 307)
        Me.pad.TabIndex = 44
        Me.pad.Text = "Scintilla1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'btnLoadHTML
        '
        Me.btnLoadHTML.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadHTML.Location = New System.Drawing.Point(23, 323)
        Me.btnLoadHTML.Name = "btnLoadHTML"
        Me.btnLoadHTML.Size = New System.Drawing.Size(76, 24)
        Me.btnLoadHTML.TabIndex = 3
        Me.btnLoadHTML.Text = "REFRESH"
        Me.btnLoadHTML.UseVisualStyleBackColor = True
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter2.Location = New System.Drawing.Point(3, 17)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(344, 333)
        Me.Splitter2.TabIndex = 1
        Me.Splitter2.TabStop = False
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(3, 350)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(344, 325)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.listChapters)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 555)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CHAPTERS"
        Me.GroupBox1.Visible = False
        '
        'listChapters
        '
        Me.listChapters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listChapters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listChapters.FormattingEnabled = True
        Me.listChapters.ItemHeight = 20
        Me.listChapters.Location = New System.Drawing.Point(3, 22)
        Me.listChapters.Name = "listChapters"
        Me.listChapters.Size = New System.Drawing.Size(206, 530)
        Me.listChapters.TabIndex = 1
        '
        'mainTUTpanel
        '
        Me.mainTUTpanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mainTUTpanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.mainTUTpanel.Controls.Add(Me.WebBrowser1)
        Me.mainTUTpanel.Location = New System.Drawing.Point(58, 106)
        Me.mainTUTpanel.Name = "mainTUTpanel"
        Me.mainTUTpanel.Size = New System.Drawing.Size(730, 560)
        Me.mainTUTpanel.TabIndex = 27
        Me.mainTUTpanel.Tag = "4"
        Me.mainTUTpanel.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(887, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Log out"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 737)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1028, 35)
        Me.Panel2.TabIndex = 36
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(767, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(226, 25)
        Me.TextBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(664, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "What I Heard>>"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("MV Boli", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(14, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(277, 22)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CODEMATE VOICE RECOGNITION"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'picClose
        '
        Me.picClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picClose.BackColor = System.Drawing.Color.DarkSlateGray
        Me.picClose.Image = Global.CODEMATE_TUTOR.My.Resources.Resources.close1
        Me.picClose.Location = New System.Drawing.Point(1007, 4)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(21, 19)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClose.TabIndex = 39
        Me.picClose.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picClose, "Exit CodeMate")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.picClose)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.picMMize)
        Me.Panel1.Controls.Add(Me.picRestoreDown)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 72)
        Me.Panel1.TabIndex = 40
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 1)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(68, 64)
        Me.MenuStrip1.TabIndex = 40
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.AutoSize = False
        Me.OptionsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LearnToolStripMenuItem, Me.WorkToolStripMenuItem, Me.PlayToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Image = Global.CODEMATE_TUTOR.My.Resources.Resources.new_DROID1
        Me.OptionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(60, 60)
        '
        'LearnToolStripMenuItem
        '
        Me.LearnToolStripMenuItem.Enabled = False
        Me.LearnToolStripMenuItem.Name = "LearnToolStripMenuItem"
        Me.LearnToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.LearnToolStripMenuItem.Text = "LEARNING AREA"
        '
        'WorkToolStripMenuItem
        '
        Me.WorkToolStripMenuItem.Name = "WorkToolStripMenuItem"
        Me.WorkToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.WorkToolStripMenuItem.Text = "WORK AREA"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.PlayToolStripMenuItem.Text = "PLAY AREA"
        '
        'picMMize
        '
        Me.picMMize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picMMize.BackColor = System.Drawing.Color.DarkSlateGray
        Me.picMMize.Image = Global.CODEMATE_TUTOR.My.Resources.Resources.minimise
        Me.picMMize.Location = New System.Drawing.Point(957, 4)
        Me.picMMize.Name = "picMMize"
        Me.picMMize.Size = New System.Drawing.Size(22, 19)
        Me.picMMize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMMize.TabIndex = 38
        Me.picMMize.TabStop = False
        '
        'picRestoreDown
        '
        Me.picRestoreDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picRestoreDown.BackColor = System.Drawing.Color.DarkSlateGray
        Me.picRestoreDown.Image = Global.CODEMATE_TUTOR.My.Resources.Resources.retoredown1
        Me.picRestoreDown.Location = New System.Drawing.Point(982, 4)
        Me.picRestoreDown.Name = "picRestoreDown"
        Me.picRestoreDown.Size = New System.Drawing.Size(22, 19)
        Me.picRestoreDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRestoreDown.TabIndex = 37
        Me.picRestoreDown.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnpause)
        Me.Panel3.Controls.Add(Me.btnread)
        Me.Panel3.Controls.Add(Me.BtnNext)
        Me.Panel3.Controls.Add(Me.BtnPrev)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 681)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1028, 56)
        Me.Panel3.TabIndex = 43
        '
        'btnpause
        '
        Me.btnpause.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnpause.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpause.Location = New System.Drawing.Point(606, 28)
        Me.btnpause.Name = "btnpause"
        Me.btnpause.Size = New System.Drawing.Size(75, 23)
        Me.btnpause.TabIndex = 46
        Me.btnpause.Text = "PAUSE"
        Me.btnpause.UseVisualStyleBackColor = True
        Me.btnpause.Visible = False
        '
        'btnread
        '
        Me.btnread.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnread.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnread.Location = New System.Drawing.Point(606, 6)
        Me.btnread.Name = "btnread"
        Me.btnread.Size = New System.Drawing.Size(75, 23)
        Me.btnread.TabIndex = 45
        Me.btnread.Text = "READ"
        Me.btnread.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(726, 6)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 23)
        Me.BtnNext.TabIndex = 44
        Me.BtnNext.Text = "NEXT"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(460, 6)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(80, 23)
        Me.BtnPrev.TabIndex = 43
        Me.BtnPrev.Text = "PREVIOUS"
        Me.BtnPrev.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(300, 1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(556, 100)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(730, 560)
        Me.WebBrowser1.TabIndex = 0
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(9, 372)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(338, 300)
        Me.WebBrowser2.TabIndex = 45
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 772)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.mainTUTpanel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.mainTUTpanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picMMize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRestoreDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLoadHTML As System.Windows.Forms.Button
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents listChapters As System.Windows.Forms.ListBox
    Friend WithEvents mainTUTpanel As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents picMMize As System.Windows.Forms.PictureBox
    Friend WithEvents picRestoreDown As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnpause As System.Windows.Forms.Button
    Friend WithEvents btnread As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LearnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WorkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pad As ScintillaNET.Scintilla
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
End Class
