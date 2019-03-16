<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.GButton = New System.Windows.Forms.Button()
        Me.EButton = New System.Windows.Forms.Button()
        Me.AButton = New System.Windows.Forms.Button()
        Me.CBox = New System.Windows.Forms.ComboBox()
        Me.CitBox = New System.Windows.Forms.TextBox()
        Me.CitLabel = New System.Windows.Forms.Label()
        Me.CLabel = New System.Windows.Forms.Label()
        Me.ExpBox = New System.Windows.Forms.TextBox()
        Me.ExpLabel = New System.Windows.Forms.Label()
        Me.GBox = New System.Windows.Forms.ComboBox()
        Me.GLabel = New System.Windows.Forms.Label()
        Me.SPBox = New System.Windows.Forms.NumericUpDown()
        Me.SPLabel = New System.Windows.Forms.Label()
        Me.ExpDBox = New System.Windows.Forms.TextBox()
        Me.ExpDLabel = New System.Windows.Forms.Label()
        Me.LBox = New System.Windows.Forms.NumericUpDown()
        Me.XPBox = New System.Windows.Forms.NumericUpDown()
        Me.LLabel = New System.Windows.Forms.Label()
        Me.XPLabel = New System.Windows.Forms.Label()
        Me.SBox = New System.Windows.Forms.TextBox()
        Me.SLabel = New System.Windows.Forms.Label()
        Me.FlagBox = New System.Windows.Forms.PictureBox()
        CType(Me.SPBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XPBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlagBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GButton
        '
        Me.GButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GButton.Location = New System.Drawing.Point(93, 261)
        Me.GButton.Name = "GButton"
        Me.GButton.Size = New System.Drawing.Size(111, 23)
        Me.GButton.TabIndex = 12
        Me.GButton.Text = "Generate Profile"
        Me.GButton.UseVisualStyleBackColor = True
        '
        'EButton
        '
        Me.EButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EButton.Location = New System.Drawing.Point(210, 261)
        Me.EButton.Name = "EButton"
        Me.EButton.Size = New System.Drawing.Size(75, 23)
        Me.EButton.TabIndex = 13
        Me.EButton.Text = "Exit"
        Me.EButton.UseVisualStyleBackColor = True
        '
        'AButton
        '
        Me.AButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AButton.Location = New System.Drawing.Point(12, 261)
        Me.AButton.Name = "AButton"
        Me.AButton.Size = New System.Drawing.Size(75, 23)
        Me.AButton.TabIndex = 11
        Me.AButton.Text = "About"
        Me.AButton.UseVisualStyleBackColor = True
        '
        'CBox
        '
        Me.CBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBox.FormattingEnabled = True
        Me.CBox.Items.AddRange(New Object() {"British", "German", "Spanish", "French", "Portuguese", "Dutch", "Ottomans", "Russians"})
        Me.CBox.Location = New System.Drawing.Point(158, 113)
        Me.CBox.Name = "CBox"
        Me.CBox.Size = New System.Drawing.Size(121, 21)
        Me.CBox.TabIndex = 6
        '
        'CitBox
        '
        Me.CitBox.Location = New System.Drawing.Point(12, 33)
        Me.CitBox.Name = "CitBox"
        Me.CitBox.Size = New System.Drawing.Size(121, 20)
        Me.CitBox.TabIndex = 1
        '
        'CitLabel
        '
        Me.CitLabel.AutoSize = True
        Me.CitLabel.Location = New System.Drawing.Point(12, 17)
        Me.CitLabel.Name = "CitLabel"
        Me.CitLabel.Size = New System.Drawing.Size(58, 13)
        Me.CitLabel.TabIndex = 0
        Me.CitLabel.Text = " City Name"
        '
        'CLabel
        '
        Me.CLabel.AutoSize = True
        Me.CLabel.Location = New System.Drawing.Point(158, 97)
        Me.CLabel.Name = "CLabel"
        Me.CLabel.Size = New System.Drawing.Size(56, 13)
        Me.CLabel.TabIndex = 6
        Me.CLabel.Text = "Civilization"
        '
        'ExpBox
        '
        Me.ExpBox.Location = New System.Drawing.Point(12, 85)
        Me.ExpBox.Name = "ExpBox"
        Me.ExpBox.Size = New System.Drawing.Size(121, 20)
        Me.ExpBox.TabIndex = 2
        '
        'ExpLabel
        '
        Me.ExpLabel.AutoSize = True
        Me.ExpLabel.Location = New System.Drawing.Point(12, 69)
        Me.ExpLabel.Name = "ExpLabel"
        Me.ExpLabel.Size = New System.Drawing.Size(76, 13)
        Me.ExpLabel.TabIndex = 8
        Me.ExpLabel.Text = "Explorer Name"
        '
        'GBox
        '
        Me.GBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GBox.Enabled = False
        Me.GBox.FormattingEnabled = True
        Me.GBox.Items.AddRange(New Object() {"Supremacy", "Deathmatch"})
        Me.GBox.Location = New System.Drawing.Point(12, 218)
        Me.GBox.Name = "GBox"
        Me.GBox.Size = New System.Drawing.Size(121, 21)
        Me.GBox.TabIndex = 5
        '
        'GLabel
        '
        Me.GLabel.AutoSize = True
        Me.GLabel.Location = New System.Drawing.Point(12, 202)
        Me.GLabel.Name = "GLabel"
        Me.GLabel.Size = New System.Drawing.Size(62, 13)
        Me.GLabel.TabIndex = 10
        Me.GLabel.Text = "Game Type"
        '
        'SPBox
        '
        Me.SPBox.Enabled = False
        Me.SPBox.Location = New System.Drawing.Point(244, 219)
        Me.SPBox.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.SPBox.Name = "SPBox"
        Me.SPBox.Size = New System.Drawing.Size(35, 20)
        Me.SPBox.TabIndex = 9
        '
        'SPLabel
        '
        Me.SPLabel.AutoSize = True
        Me.SPLabel.Location = New System.Drawing.Point(155, 213)
        Me.SPLabel.Name = "SPLabel"
        Me.SPLabel.Size = New System.Drawing.Size(88, 26)
        Me.SPLabel.TabIndex = 13
        Me.SPLabel.Text = "Skill Points" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/ Cards Available" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ExpDBox
        '
        Me.ExpDBox.Location = New System.Drawing.Point(12, 127)
        Me.ExpDBox.Name = "ExpDBox"
        Me.ExpDBox.Size = New System.Drawing.Size(121, 20)
        Me.ExpDBox.TabIndex = 3
        '
        'ExpDLabel
        '
        Me.ExpDLabel.AutoSize = True
        Me.ExpDLabel.Location = New System.Drawing.Point(12, 111)
        Me.ExpDLabel.Name = "ExpDLabel"
        Me.ExpDLabel.Size = New System.Drawing.Size(99, 13)
        Me.ExpDLabel.TabIndex = 16
        Me.ExpDLabel.Text = "Explorer Dog Name"
        '
        'LBox
        '
        Me.LBox.Enabled = False
        Me.LBox.Location = New System.Drawing.Point(161, 167)
        Me.LBox.Name = "LBox"
        Me.LBox.Size = New System.Drawing.Size(45, 20)
        Me.LBox.TabIndex = 7
        '
        'XPBox
        '
        Me.XPBox.Enabled = False
        Me.XPBox.Location = New System.Drawing.Point(212, 167)
        Me.XPBox.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.XPBox.Name = "XPBox"
        Me.XPBox.Size = New System.Drawing.Size(67, 20)
        Me.XPBox.TabIndex = 8
        '
        'LLabel
        '
        Me.LLabel.AutoSize = True
        Me.LLabel.Location = New System.Drawing.Point(158, 151)
        Me.LLabel.Name = "LLabel"
        Me.LLabel.Size = New System.Drawing.Size(33, 13)
        Me.LLabel.TabIndex = 19
        Me.LLabel.Text = "Level"
        '
        'XPLabel
        '
        Me.XPLabel.AutoSize = True
        Me.XPLabel.Location = New System.Drawing.Point(209, 151)
        Me.XPLabel.Name = "XPLabel"
        Me.XPLabel.Size = New System.Drawing.Size(21, 13)
        Me.XPLabel.TabIndex = 20
        Me.XPLabel.Text = "XP"
        '
        'SBox
        '
        Me.SBox.Location = New System.Drawing.Point(12, 167)
        Me.SBox.Name = "SBox"
        Me.SBox.Size = New System.Drawing.Size(121, 20)
        Me.SBox.TabIndex = 4
        '
        'SLabel
        '
        Me.SLabel.AutoSize = True
        Me.SLabel.Location = New System.Drawing.Point(12, 151)
        Me.SLabel.Name = "SLabel"
        Me.SLabel.Size = New System.Drawing.Size(85, 13)
        Me.SLabel.TabIndex = 22
        Me.SLabel.Text = "Main Ship Name"
        '
        'FlagBox
        '
        Me.FlagBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlagBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlagBox.Image = Global.AOEIII_ProfileGenerator.My.Resources.Resources.none
        Me.FlagBox.Location = New System.Drawing.Point(158, 17)
        Me.FlagBox.Name = "FlagBox"
        Me.FlagBox.Size = New System.Drawing.Size(121, 68)
        Me.FlagBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FlagBox.TabIndex = 14
        Me.FlagBox.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 301)
        Me.Controls.Add(Me.SLabel)
        Me.Controls.Add(Me.SBox)
        Me.Controls.Add(Me.XPLabel)
        Me.Controls.Add(Me.LLabel)
        Me.Controls.Add(Me.XPBox)
        Me.Controls.Add(Me.LBox)
        Me.Controls.Add(Me.ExpDLabel)
        Me.Controls.Add(Me.ExpDBox)
        Me.Controls.Add(Me.FlagBox)
        Me.Controls.Add(Me.SPLabel)
        Me.Controls.Add(Me.SPBox)
        Me.Controls.Add(Me.GLabel)
        Me.Controls.Add(Me.GBox)
        Me.Controls.Add(Me.ExpLabel)
        Me.Controls.Add(Me.ExpBox)
        Me.Controls.Add(Me.CLabel)
        Me.Controls.Add(Me.CitLabel)
        Me.Controls.Add(Me.CitBox)
        Me.Controls.Add(Me.CBox)
        Me.Controls.Add(Me.AButton)
        Me.Controls.Add(Me.EButton)
        Me.Controls.Add(Me.GButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Age of Empires III - Profile Generator"
        CType(Me.SPBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XPBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlagBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GButton As System.Windows.Forms.Button
    Friend WithEvents EButton As System.Windows.Forms.Button
    Friend WithEvents AButton As System.Windows.Forms.Button
    Friend WithEvents CBox As System.Windows.Forms.ComboBox
    Friend WithEvents CitBox As System.Windows.Forms.TextBox
    Friend WithEvents CitLabel As System.Windows.Forms.Label
    Friend WithEvents CLabel As System.Windows.Forms.Label
    Friend WithEvents ExpBox As System.Windows.Forms.TextBox
    Friend WithEvents ExpLabel As System.Windows.Forms.Label
    Friend WithEvents GBox As System.Windows.Forms.ComboBox
    Friend WithEvents GLabel As System.Windows.Forms.Label
    Friend WithEvents SPBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents SPLabel As System.Windows.Forms.Label
    Friend WithEvents FlagBox As System.Windows.Forms.PictureBox
    Friend WithEvents ExpDBox As System.Windows.Forms.TextBox
    Friend WithEvents ExpDLabel As System.Windows.Forms.Label
    Friend WithEvents LBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents XPBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents LLabel As System.Windows.Forms.Label
    Friend WithEvents XPLabel As System.Windows.Forms.Label
    Friend WithEvents SBox As System.Windows.Forms.TextBox
    Friend WithEvents SLabel As System.Windows.Forms.Label

End Class
