<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuizWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuizWindow))
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.cmdAbort = New System.Windows.Forms.Button()
        Me.lblQuestionNumber = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.QuestionTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picture
        '
        Me.Picture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture.Location = New System.Drawing.Point(12, 12)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(691, 461)
        Me.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Picture.TabIndex = 0
        Me.Picture.TabStop = False
        Me.Picture.Visible = False
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(12, 492)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(610, 23)
        Me.ProgressBar.TabIndex = 1
        Me.ProgressBar.Visible = False
        '
        'cmdAbort
        '
        Me.cmdAbort.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAbort.Location = New System.Drawing.Point(628, 492)
        Me.cmdAbort.Name = "cmdAbort"
        Me.cmdAbort.Size = New System.Drawing.Size(75, 23)
        Me.cmdAbort.TabIndex = 2
        Me.cmdAbort.Text = "Abort Quiz"
        Me.cmdAbort.UseVisualStyleBackColor = True
        Me.cmdAbort.Visible = False
        '
        'lblQuestionNumber
        '
        Me.lblQuestionNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuestionNumber.AutoSize = True
        Me.lblQuestionNumber.Location = New System.Drawing.Point(12, 476)
        Me.lblQuestionNumber.Name = "lblQuestionNumber"
        Me.lblQuestionNumber.Size = New System.Drawing.Size(44, 13)
        Me.lblQuestionNumber.TabIndex = 3
        Me.lblQuestionNumber.Text = "0 / Max"
        Me.lblQuestionNumber.Visible = False
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(12, 67)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(691, 88)
        Me.lblInfo.TabIndex = 4
        Me.lblInfo.Text = "# words" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press start to begin"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(214, 169)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(75, 23)
        Me.cmdStart.TabIndex = 5
        Me.cmdStart.Text = "Start"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'QuestionTimer
        '
        '
        'QuizWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(715, 527)
        Me.Controls.Add(Me.lblQuestionNumber)
        Me.Controls.Add(Me.cmdAbort)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.Picture)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "QuizWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turbo Fingerspelling Quiz"
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Picture As PictureBox
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents cmdAbort As Button
    Friend WithEvents lblQuestionNumber As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents cmdStart As Button
    Friend WithEvents QuestionTimer As Timer
End Class
