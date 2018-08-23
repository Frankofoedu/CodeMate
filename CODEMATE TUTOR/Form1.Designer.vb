<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.picMMize = New System.Windows.Forms.PictureBox()
        Me.picRestoreDown = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnNEW = New System.Windows.Forms.Button()
        Me.listUSERS = New System.Windows.Forms.ListBox()
        Me.txtNEWUSER = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.secpanel = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.BtnTUT = New System.Windows.Forms.Button()
        Me.btnWork = New System.Windows.Forms.Button()
        Me.slideinanimationtimer = New System.Windows.Forms.Timer(Me.components)
        Me.slideoutanimationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMMize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRestoreDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.secpanel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 697)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1028, 39)
        Me.Panel2.TabIndex = 22
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(801, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(226, 25)
        Me.TextBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(698, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "What I Heard>>"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Perpetua Titling MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(14, 10)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(275, 21)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CODEMATE VOICE RECOGNITION"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.picClose)
        Me.Panel5.Controls.Add(Me.picMMize)
        Me.Panel5.Controls.Add(Me.picRestoreDown)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1028, 80)
        Me.Panel5.TabIndex = 41
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
        '
        'picMMize
        '
        Me.picMMize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picMMize.BackColor = System.Drawing.Color.DarkSlateGray
        Me.picMMize.Image = Global.CODEMATE_TUTOR.My.Resources.Resources.minimise
        Me.picMMize.Location = New System.Drawing.Point(951, 4)
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
        Me.picRestoreDown.Location = New System.Drawing.Point(979, 4)
        Me.picRestoreDown.Name = "picRestoreDown"
        Me.picRestoreDown.Size = New System.Drawing.Size(22, 19)
        Me.picRestoreDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRestoreDown.TabIndex = 37
        Me.picRestoreDown.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(317, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(556, 100)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.CODEMATE_TUTOR.My.Resources.Resources.new_DROID
        Me.PictureBox2.Location = New System.Drawing.Point(7, 118)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(337, 498)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.CODEMATE_TUTOR.My.Resources.Resources.board1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(485, 132)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 454)
        Me.Panel1.TabIndex = 9
        Me.Panel1.Tag = "1"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btnDELETE)
        Me.Panel3.Controls.Add(Me.btnNEW)
        Me.Panel3.Controls.Add(Me.listUSERS)
        Me.Panel3.Controls.Add(Me.txtNEWUSER)
        Me.Panel3.Controls.Add(Me.btnOK)
        Me.Panel3.Location = New System.Drawing.Point(48, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(425, 369)
        Me.Panel3.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SELECT USER"
        '
        'btnDELETE
        '
        Me.btnDELETE.Enabled = False
        Me.btnDELETE.Location = New System.Drawing.Point(281, 343)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(75, 23)
        Me.btnDELETE.TabIndex = 4
        Me.btnDELETE.Text = "DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = True
        '
        'btnNEW
        '
        Me.btnNEW.Location = New System.Drawing.Point(174, 343)
        Me.btnNEW.Name = "btnNEW"
        Me.btnNEW.Size = New System.Drawing.Size(75, 23)
        Me.btnNEW.TabIndex = 6
        Me.btnNEW.Text = "NEW"
        Me.btnNEW.UseVisualStyleBackColor = True
        '
        'listUSERS
        '
        Me.listUSERS.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listUSERS.FormattingEnabled = True
        Me.listUSERS.ItemHeight = 20
        Me.listUSERS.Location = New System.Drawing.Point(58, 56)
        Me.listUSERS.Name = "listUSERS"
        Me.listUSERS.Size = New System.Drawing.Size(309, 204)
        Me.listUSERS.TabIndex = 1
        '
        'txtNEWUSER
        '
        Me.txtNEWUSER.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNEWUSER.ForeColor = System.Drawing.Color.LightGray
        Me.txtNEWUSER.Location = New System.Drawing.Point(58, 289)
        Me.txtNEWUSER.Name = "txtNEWUSER"
        Me.txtNEWUSER.Size = New System.Drawing.Size(309, 27)
        Me.txtNEWUSER.TabIndex = 5
        Me.txtNEWUSER.Tag = "2"
        Me.txtNEWUSER.Text = "INPUT YOUR USERNAME HERE (NEW USERS)"
        Me.txtNEWUSER.Visible = False
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(71, 343)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'secpanel
        '
        Me.secpanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.secpanel.BackColor = System.Drawing.Color.White
        Me.secpanel.BackgroundImage = Global.CODEMATE_TUTOR.My.Resources.Resources.board1
        Me.secpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.secpanel.Controls.Add(Me.Panel4)
        Me.secpanel.Location = New System.Drawing.Point(480, 129)
        Me.secpanel.Name = "secpanel"
        Me.secpanel.Size = New System.Drawing.Size(535, 454)
        Me.secpanel.TabIndex = 20
        Me.secpanel.Tag = "3"
        Me.secpanel.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.btnBrowse)
        Me.Panel4.Controls.Add(Me.BtnTUT)
        Me.Panel4.Controls.Add(Me.btnWork)
        Me.Panel4.Location = New System.Drawing.Point(120, 49)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(326, 347)
        Me.Panel4.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(57, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "PLAY GAMES"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(57, 227)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(193, 34)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "SURF THE WEB"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'BtnTUT
        '
        Me.BtnTUT.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.BtnTUT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.BtnTUT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnTUT.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnTUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTUT.Location = New System.Drawing.Point(57, 107)
        Me.BtnTUT.Name = "BtnTUT"
        Me.BtnTUT.Size = New System.Drawing.Size(193, 34)
        Me.BtnTUT.TabIndex = 2
        Me.BtnTUT.Text = "TAKE WEB DESIGN CLASSES"
        Me.BtnTUT.UseVisualStyleBackColor = True
        '
        'btnWork
        '
        Me.btnWork.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWork.Location = New System.Drawing.Point(57, 147)
        Me.btnWork.Name = "btnWork"
        Me.btnWork.Size = New System.Drawing.Size(193, 34)
        Me.btnWork.TabIndex = 3
        Me.btnWork.Text = "DESIGN WEB PAGES"
        Me.btnWork.UseVisualStyleBackColor = True
        '
        'slideinanimationtimer
        '
        Me.slideinanimationtimer.Interval = 10
        '
        'slideoutanimationTimer
        '
        Me.slideoutanimationTimer.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.CODEMATE_TUTOR.My.Resources.Resources.codemate1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1028, 736)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.secpanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMMize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRestoreDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.secpanel.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNEWUSER As System.Windows.Forms.TextBox
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents listUSERS As System.Windows.Forms.ListBox
    Friend WithEvents btnNEW As System.Windows.Forms.Button
    Friend WithEvents secpanel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnWork As System.Windows.Forms.Button
    Friend WithEvents BtnTUT As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents picMMize As System.Windows.Forms.PictureBox
    Friend WithEvents picRestoreDown As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents slideinanimationtimer As System.Windows.Forms.Timer
    Friend WithEvents slideoutanimationTimer As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
