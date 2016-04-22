<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetupWindow))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WordListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdAddWord = New System.Windows.Forms.Button()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.chkAllowDuplicates = New System.Windows.Forms.CheckBox()
        Me.cmdLoadWords = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGeneratorCount = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdGenerateWords = New System.Windows.Forms.Button()
        Me.cmdSaveWords = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdMegaFast = New System.Windows.Forms.Button()
        Me.cmdVeryFast = New System.Windows.Forms.Button()
        Me.cmdFast = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRepeatCount = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdMedium = New System.Windows.Forms.Button()
        Me.cmdSlow = New System.Windows.Forms.Button()
        Me.cmdVerySlow = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSpeed = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdStartQuiz = New System.Windows.Forms.Button()
        Me.cmdRemoveWord = New System.Windows.Forms.Button()
        Me.cmdClearWords = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtGeneratorCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtRepeatCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Included Words:"
        '
        'WordListBox
        '
        Me.WordListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WordListBox.FormattingEnabled = True
        Me.WordListBox.IntegralHeight = False
        Me.WordListBox.Location = New System.Drawing.Point(12, 25)
        Me.WordListBox.Name = "WordListBox"
        Me.WordListBox.Size = New System.Drawing.Size(433, 113)
        Me.WordListBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdAddWord)
        Me.GroupBox1.Controls.Add(Me.txtWord)
        Me.GroupBox1.Controls.Add(Me.chkAllowDuplicates)
        Me.GroupBox1.Controls.Add(Me.cmdLoadWords)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtGeneratorCount)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdGenerateWords)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 202)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 108)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Words"
        '
        'cmdAddWord
        '
        Me.cmdAddWord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddWord.Location = New System.Drawing.Point(386, 77)
        Me.cmdAddWord.Name = "cmdAddWord"
        Me.cmdAddWord.Size = New System.Drawing.Size(43, 23)
        Me.cmdAddWord.TabIndex = 9
        Me.cmdAddWord.Text = "Add"
        Me.cmdAddWord.UseVisualStyleBackColor = True
        '
        'txtWord
        '
        Me.txtWord.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWord.Location = New System.Drawing.Point(6, 79)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(374, 20)
        Me.txtWord.TabIndex = 8
        '
        'chkAllowDuplicates
        '
        Me.chkAllowDuplicates.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAllowDuplicates.AutoSize = True
        Me.chkAllowDuplicates.Location = New System.Drawing.Point(272, 18)
        Me.chkAllowDuplicates.Name = "chkAllowDuplicates"
        Me.chkAllowDuplicates.Size = New System.Drawing.Size(108, 17)
        Me.chkAllowDuplicates.TabIndex = 7
        Me.chkAllowDuplicates.Text = "Allow duplicates?"
        Me.chkAllowDuplicates.UseVisualStyleBackColor = True
        '
        'cmdLoadWords
        '
        Me.cmdLoadWords.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLoadWords.Location = New System.Drawing.Point(6, 50)
        Me.cmdLoadWords.Name = "cmdLoadWords"
        Me.cmdLoadWords.Size = New System.Drawing.Size(423, 23)
        Me.cmdLoadWords.TabIndex = 6
        Me.cmdLoadWords.Text = "Add words from a file"
        Me.cmdLoadWords.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "words"
        '
        'txtGeneratorCount
        '
        Me.txtGeneratorCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGeneratorCount.Location = New System.Drawing.Point(66, 17)
        Me.txtGeneratorCount.Name = "txtGeneratorCount"
        Me.txtGeneratorCount.Size = New System.Drawing.Size(159, 20)
        Me.txtGeneratorCount.TabIndex = 4
        Me.txtGeneratorCount.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Generate "
        '
        'cmdGenerateWords
        '
        Me.cmdGenerateWords.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGenerateWords.Location = New System.Drawing.Point(386, 14)
        Me.cmdGenerateWords.Name = "cmdGenerateWords"
        Me.cmdGenerateWords.Size = New System.Drawing.Size(43, 23)
        Me.cmdGenerateWords.TabIndex = 0
        Me.cmdGenerateWords.Text = "Go"
        Me.cmdGenerateWords.UseVisualStyleBackColor = True
        '
        'cmdSaveWords
        '
        Me.cmdSaveWords.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSaveWords.Location = New System.Drawing.Point(12, 419)
        Me.cmdSaveWords.Name = "cmdSaveWords"
        Me.cmdSaveWords.Size = New System.Drawing.Size(133, 23)
        Me.cmdSaveWords.TabIndex = 7
        Me.cmdSaveWords.Text = "Save words to a file"
        Me.cmdSaveWords.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cmdMegaFast)
        Me.GroupBox2.Controls.Add(Me.cmdVeryFast)
        Me.GroupBox2.Controls.Add(Me.cmdFast)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtRepeatCount)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmdMedium)
        Me.GroupBox2.Controls.Add(Me.cmdSlow)
        Me.GroupBox2.Controls.Add(Me.cmdVerySlow)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtSpeed)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 316)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(433, 97)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Speed"
        '
        'cmdMegaFast
        '
        Me.cmdMegaFast.Location = New System.Drawing.Point(361, 40)
        Me.cmdMegaFast.Name = "cmdMegaFast"
        Me.cmdMegaFast.Size = New System.Drawing.Size(65, 23)
        Me.cmdMegaFast.TabIndex = 15
        Me.cmdMegaFast.Text = "Mega Fast"
        Me.cmdMegaFast.UseVisualStyleBackColor = True
        '
        'cmdVeryFast
        '
        Me.cmdVeryFast.Location = New System.Drawing.Point(290, 40)
        Me.cmdVeryFast.Name = "cmdVeryFast"
        Me.cmdVeryFast.Size = New System.Drawing.Size(65, 23)
        Me.cmdVeryFast.TabIndex = 14
        Me.cmdVeryFast.Text = "Very Fast"
        Me.cmdVeryFast.UseVisualStyleBackColor = True
        '
        'cmdFast
        '
        Me.cmdFast.Location = New System.Drawing.Point(219, 40)
        Me.cmdFast.Name = "cmdFast"
        Me.cmdFast.Size = New System.Drawing.Size(65, 23)
        Me.cmdFast.TabIndex = 13
        Me.cmdFast.Text = "Fast"
        Me.cmdFast.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(396, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "times"
        '
        'txtRepeatCount
        '
        Me.txtRepeatCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRepeatCount.Location = New System.Drawing.Point(98, 69)
        Me.txtRepeatCount.Name = "txtRepeatCount"
        Me.txtRepeatCount.Size = New System.Drawing.Size(292, 20)
        Me.txtRepeatCount.TabIndex = 11
        Me.txtRepeatCount.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Show each word"
        '
        'cmdMedium
        '
        Me.cmdMedium.Location = New System.Drawing.Point(148, 40)
        Me.cmdMedium.Name = "cmdMedium"
        Me.cmdMedium.Size = New System.Drawing.Size(65, 23)
        Me.cmdMedium.TabIndex = 9
        Me.cmdMedium.Text = "Medium"
        Me.cmdMedium.UseVisualStyleBackColor = True
        '
        'cmdSlow
        '
        Me.cmdSlow.Location = New System.Drawing.Point(77, 40)
        Me.cmdSlow.Name = "cmdSlow"
        Me.cmdSlow.Size = New System.Drawing.Size(65, 23)
        Me.cmdSlow.TabIndex = 8
        Me.cmdSlow.Text = "Slow"
        Me.cmdSlow.UseVisualStyleBackColor = True
        '
        'cmdVerySlow
        '
        Me.cmdVerySlow.Location = New System.Drawing.Point(6, 40)
        Me.cmdVerySlow.Name = "cmdVerySlow"
        Me.cmdVerySlow.Size = New System.Drawing.Size(65, 23)
        Me.cmdVerySlow.TabIndex = 7
        Me.cmdVerySlow.Text = "Very Slow"
        Me.cmdVerySlow.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "milliseconds"
        '
        'txtSpeed
        '
        Me.txtSpeed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSpeed.Location = New System.Drawing.Point(117, 14)
        Me.txtSpeed.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.txtSpeed.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.Size = New System.Drawing.Size(241, 20)
        Me.txtSpeed.TabIndex = 7
        Me.txtSpeed.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Show each letter for "
        '
        'cmdStartQuiz
        '
        Me.cmdStartQuiz.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdStartQuiz.Location = New System.Drawing.Point(380, 419)
        Me.cmdStartQuiz.Name = "cmdStartQuiz"
        Me.cmdStartQuiz.Size = New System.Drawing.Size(65, 23)
        Me.cmdStartQuiz.TabIndex = 10
        Me.cmdStartQuiz.Text = "Start Quiz"
        Me.cmdStartQuiz.UseVisualStyleBackColor = True
        '
        'cmdRemoveWord
        '
        Me.cmdRemoveWord.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRemoveWord.Enabled = False
        Me.cmdRemoveWord.Location = New System.Drawing.Point(12, 144)
        Me.cmdRemoveWord.Name = "cmdRemoveWord"
        Me.cmdRemoveWord.Size = New System.Drawing.Size(433, 23)
        Me.cmdRemoveWord.TabIndex = 10
        Me.cmdRemoveWord.Text = "Remove selected word"
        Me.cmdRemoveWord.UseVisualStyleBackColor = True
        '
        'cmdClearWords
        '
        Me.cmdClearWords.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClearWords.Location = New System.Drawing.Point(12, 173)
        Me.cmdClearWords.Name = "cmdClearWords"
        Me.cmdClearWords.Size = New System.Drawing.Size(433, 23)
        Me.cmdClearWords.TabIndex = 11
        Me.cmdClearWords.Text = "Remove all the words"
        Me.cmdClearWords.UseVisualStyleBackColor = True
        '
        'SetupWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 454)
        Me.Controls.Add(Me.cmdClearWords)
        Me.Controls.Add(Me.cmdRemoveWord)
        Me.Controls.Add(Me.cmdStartQuiz)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdSaveWords)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.WordListBox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(473, 10000000)
        Me.MinimumSize = New System.Drawing.Size(473, 420)
        Me.Name = "SetupWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turbo Fingerspelling Setup"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtGeneratorCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtRepeatCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents WordListBox As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdGenerateWords As Button
    Friend WithEvents cmdLoadWords As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGeneratorCount As NumericUpDown
    Friend WithEvents cmdSaveWords As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSpeed As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdSlow As Button
    Friend WithEvents cmdVerySlow As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRepeatCount As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdMedium As Button
    Friend WithEvents cmdMegaFast As Button
    Friend WithEvents cmdVeryFast As Button
    Friend WithEvents cmdFast As Button
    Friend WithEvents cmdStartQuiz As Button
    Friend WithEvents chkAllowDuplicates As CheckBox
    Friend WithEvents cmdAddWord As Button
    Friend WithEvents txtWord As TextBox
    Friend WithEvents cmdRemoveWord As Button
    Friend WithEvents cmdClearWords As Button
End Class
