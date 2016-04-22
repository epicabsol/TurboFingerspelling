Public Class QuizWindow
    Public Words As New List(Of String)
    Public CurrentIndex As Integer = 0
    Public CurrentRepeat As Integer = 0
    Public CurrentLetter As Integer = -1
    Public Repeats As Integer = 0
    Public WaitTicks As Integer = 0
    Public Const WaitTime As Integer = 5
    Private Sub QuizWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If QuestionTimer.Enabled Then
            e.Cancel = True ' Don't let the user quit in the middle of a quiz
            Reset()
        Else
            SetupWindow.Show()
        End If
    End Sub

    Private Sub QuizWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        cmdStart.Left = CInt(ClientSize.Width / 2 - cmdStart.Width / 2)
    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        lblInfo.Visible = False
        cmdStart.Visible = False
        cmdAbort.Visible = True
        Picture.Visible = True
        lblQuestionNumber.Visible = True
        ProgressBar.Visible = True
        QuestionTimer.Enabled = True

        WaitTicks = WaitTime
        Advance()
    End Sub

    Private Sub Advance()
        lblQuestionNumber.Text = (CurrentIndex + 1) & " / " & Words.Count
        ProgressBar.Value = CurrentIndex * Repeats + CurrentRepeat
        If WaitTicks > 0 Then
            lblInfo.Visible = True
            Picture.Visible = False

            lblInfo.Text = "Word " & (CurrentIndex + 1) & vbNewLine & vbNewLine & "Repeat " & (CurrentRepeat + 1)
            WaitTicks -= 1
        Else
            lblInfo.Visible = False
            Picture.Visible = True

            Dim bumped As Boolean = False
            CurrentLetter += 1
            If CurrentLetter >= Words(CurrentIndex).Length Then
                CurrentRepeat += 1
                CurrentLetter = -1
                WaitTicks = WaitTime
            Else
                ' Mess with the picturebox position for multi-letter sweeps
                If CurrentLetter > 0 Then
                    If Words(CurrentIndex)(CurrentLetter) = Words(CurrentIndex)(CurrentLetter - 1) Then
                        bumped = True
                    End If
                End If
            End If
            If CurrentRepeat >= Repeats Then
                CurrentIndex += 1
                CurrentRepeat = 0
            End If
            If CurrentIndex >= Words.Count Then
                Reset()
            End If
            If bumped Then
                Picture.Left += 100
            ElseIf CurrentLetter >= 0 ' It will be -1 on the second half of the last letter.
                Picture.Left = 12
            End If
            'If CurrentLetter = -1 Then Exit Sub
            Try
                'Text = Words(CurrentIndex)(CurrentLetter) & "Letter" & CurrentLetter & " Repeat" & CurrentRepeat & " Index" & CurrentIndex
                If SetupWindow.Signs.ContainsKey(Words(CurrentIndex)(CurrentLetter)) Then
                    Picture.Image = SetupWindow.Signs(Words(CurrentIndex)(CurrentLetter))
                Else
                    Picture.Image = Nothing
                End If
            Catch ex As IndexOutOfRangeException

            End Try
        End If
    End Sub

    Private Sub QuizWindow_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        For Each s As String In SetupWindow.WordListBox.Items
            Words.Add(s)
        Next
        Repeats = CInt(SetupWindow.txtRepeatCount.Value)
        QuestionTimer.Interval = CInt(SetupWindow.txtSpeed.Value)
        Reset()
    End Sub

    Public Sub Reset()
        lblInfo.Text = Words.Count & " words" & vbNewLine & vbNewLine & Repeats & " time" & If(Repeats <> 1, "s", "") & " per word" & vbNewLine & vbNewLine & "Press start to begin"
        QuestionTimer.Enabled = False
        lblInfo.Visible = True
        cmdStart.Visible = True
        cmdAbort.Visible = False
        Picture.Visible = False
        lblQuestionNumber.Visible = False
        ProgressBar.Visible = False
        ProgressBar.Maximum = Words.Count * Repeats

        CurrentIndex = 0
        CurrentRepeat = 0
        CurrentLetter = -1
    End Sub

    Private Sub QuestionTimer_Tick(sender As Object, e As EventArgs) Handles QuestionTimer.Tick
        Advance()
    End Sub

    Private Sub cmdAbort_Click(sender As Object, e As EventArgs) Handles cmdAbort.Click
        Reset()
    End Sub
End Class