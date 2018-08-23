<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class openfile
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkOTHERS = New System.Windows.Forms.RadioButton()
        Me.ChkJS = New System.Windows.Forms.RadioButton()
        Me.ChkCSS = New System.Windows.Forms.RadioButton()
        Me.ChkPHP = New System.Windows.Forms.RadioButton()
        Me.ChkHTML = New System.Windows.Forms.RadioButton()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.ForeColor = System.Drawing.Color.White
        Me.btnOpen.Location = New System.Drawing.Point(509, 381)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(87, 23)
        Me.btnOpen.TabIndex = 10
        Me.btnOpen.Text = "OPEN"
        Me.ToolTip1.SetToolTip(Me.btnOpen, "Open selected file")
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(514, 23)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(74, 23)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "BROWSE"
        Me.ToolTip1.SetToolTip(Me.btnBrowse, "Browse for file")
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(44, 25)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(472, 20)
        Me.TextBox3.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TextBox3, "Last opened file")
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(602, 381)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "CANCEL"
        Me.ToolTip1.SetToolTip(Me.btnCancel, "Cancel 'Open File'")
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(146, 436)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnBrowse)
        Me.GroupBox4.Controls.Add(Me.TextBox3)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(145, 292)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(588, 62)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "SELECT FILE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "PATH:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ChkOTHERS)
        Me.GroupBox1.Controls.Add(Me.ChkJS)
        Me.GroupBox1.Controls.Add(Me.ChkCSS)
        Me.GroupBox1.Controls.Add(Me.ChkPHP)
        Me.GroupBox1.Controls.Add(Me.ChkHTML)
        Me.GroupBox1.Location = New System.Drawing.Point(145, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 144)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILE TYPE"
        '
        'ChkOTHERS
        '
        Me.ChkOTHERS.AutoSize = True
        Me.ChkOTHERS.Location = New System.Drawing.Point(32, 116)
        Me.ChkOTHERS.Name = "ChkOTHERS"
        Me.ChkOTHERS.Size = New System.Drawing.Size(72, 17)
        Me.ChkOTHERS.TabIndex = 4
        Me.ChkOTHERS.TabStop = True
        Me.ChkOTHERS.Text = "OTHER..."
        Me.ToolTip1.SetToolTip(Me.ChkOTHERS, "Select option 5")
        Me.ChkOTHERS.UseVisualStyleBackColor = True
        '
        'ChkJS
        '
        Me.ChkJS.AutoSize = True
        Me.ChkJS.Location = New System.Drawing.Point(32, 92)
        Me.ChkJS.Name = "ChkJS"
        Me.ChkJS.Size = New System.Drawing.Size(90, 17)
        Me.ChkJS.TabIndex = 3
        Me.ChkJS.TabStop = True
        Me.ChkJS.Text = "JAVASCRIPT"
        Me.ToolTip1.SetToolTip(Me.ChkJS, "Select option 4")
        Me.ChkJS.UseVisualStyleBackColor = True
        '
        'ChkCSS
        '
        Me.ChkCSS.AutoSize = True
        Me.ChkCSS.Location = New System.Drawing.Point(32, 68)
        Me.ChkCSS.Name = "ChkCSS"
        Me.ChkCSS.Size = New System.Drawing.Size(46, 17)
        Me.ChkCSS.TabIndex = 2
        Me.ChkCSS.TabStop = True
        Me.ChkCSS.Text = "CSS"
        Me.ToolTip1.SetToolTip(Me.ChkCSS, "Select option three")
        Me.ChkCSS.UseVisualStyleBackColor = True
        '
        'ChkPHP
        '
        Me.ChkPHP.AutoSize = True
        Me.ChkPHP.Location = New System.Drawing.Point(32, 44)
        Me.ChkPHP.Name = "ChkPHP"
        Me.ChkPHP.Size = New System.Drawing.Size(47, 17)
        Me.ChkPHP.TabIndex = 1
        Me.ChkPHP.TabStop = True
        Me.ChkPHP.Text = "PHP"
        Me.ToolTip1.SetToolTip(Me.ChkPHP, "Select option two")
        Me.ChkPHP.UseVisualStyleBackColor = True
        '
        'ChkHTML
        '
        Me.ChkHTML.AutoSize = True
        Me.ChkHTML.Location = New System.Drawing.Point(32, 20)
        Me.ChkHTML.Name = "ChkHTML"
        Me.ChkHTML.Size = New System.Drawing.Size(55, 17)
        Me.ChkHTML.TabIndex = 0
        Me.ChkHTML.TabStop = True
        Me.ChkHTML.Text = "HTML"
        Me.ToolTip1.SetToolTip(Me.ChkHTML, "Select option one")
        Me.ChkHTML.UseVisualStyleBackColor = True
        '
        'openfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 436)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "openfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "openfile"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkOTHERS As System.Windows.Forms.RadioButton
    Friend WithEvents ChkJS As System.Windows.Forms.RadioButton
    Friend WithEvents ChkCSS As System.Windows.Forms.RadioButton
    Friend WithEvents ChkPHP As System.Windows.Forms.RadioButton
    Friend WithEvents ChkHTML As System.Windows.Forms.RadioButton
End Class
