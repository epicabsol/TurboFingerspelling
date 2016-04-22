Public Class SetupWindow
    Public Signs As New Dictionary(Of String, Bitmap)
    Public Dictionary As New List(Of String)
    Private Sub cmdLoadWords_Click(sender As Object, e As EventArgs) Handles cmdLoadWords.Click
        Dim browser As New OpenFileDialog
        browser.Filter = "Text file (*.txt)|*.txt"
        browser.ShowDialog()
        If browser.FileName = "" Then Exit Sub
        Try
            Dim reader As New IO.StreamReader(browser.FileName)

            While reader.EndOfStream = False
                Dim line() As String = reader.ReadLine().Split(" "c)
                For Each s As String In line
                    If s.Length > 0 Then AddWord(s, False)
                Next
            End While

            reader.Dispose()
        Catch ex As Exception
            MsgBox("Error opening file: " & ex.ToString())
        End Try
    End Sub

    Public Function AddWord(s As String, checklength As Boolean) As Boolean
        If checklength AndAlso s.Length < 4 Then Return True
        If chkAllowDuplicates.Checked = False Then
            For Each s2 As String In WordListBox.Items
                If s2 = s Then
                    Return True
                End If
            Next
        End If
        WordListBox.Items.Add(s)
        Return False
    End Function

    Private Sub SetupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("dictionary.txt") Then
            Dim reader As New IO.StreamReader("dictionary.txt")

            While reader.EndOfStream = False
                Dim line() As String = reader.ReadLine().Split(CChar(vbLf))
                For Each s As String In line
                    Dictionary.Add(s)
                Next
            End While

            reader.Dispose()
        End If
        If IO.Directory.Exists("signs\alphabet") Then
            For Each s As String In "abcdefghikjlmnopqrstuvwxyz"
                If IO.File.Exists("signs\alphabet\" & s & ".png") Then
                    Signs.Add(s, New Bitmap("signs\alphabet\" & s & ".png"))
                Else
                    MsgBox("Missing sign: Letter " & s.ToUpper())
                    cmdStartQuiz.Enabled = False
                End If
            Next
            If cmdStartQuiz.Enabled = False Then
                MsgBox("Some sign pictures are missing! The quiz won't work without them.")
            End If
        Else
            MsgBox("The sign pictures are missing! The quiz won't work without them.")
            cmdStartQuiz.Enabled = False
        End If
        LoadSettings()
    End Sub

    Private Sub cmdGenerateWords_Click(sender As Object, e As EventArgs) Handles cmdGenerateWords.Click
        Dim r As New Random
        For i As Integer = 0 To CInt(txtGeneratorCount.Value) - 1
            Dim j As Integer = r.Next(Dictionary.Count)
            Dim s As String = Dictionary(j)
            If AddWord(s, True) Then i -= 1
        Next
    End Sub

    Private Sub cmdAddWord_Click(sender As Object, e As EventArgs) Handles cmdAddWord.Click
        AddWord(txtWord.Text, False)
        txtWord.Text = ""
    End Sub

    Private Sub WordListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WordListBox.SelectedIndexChanged
        If WordListBox.SelectedIndex >= 0 Then
            cmdRemoveWord.Enabled = True
        Else
            cmdRemoveWord.Enabled = False
        End If
    End Sub

    Private Sub cmdRemoveWord_Click(sender As Object, e As EventArgs) Handles cmdRemoveWord.Click
        If WordListBox.SelectedIndex >= 0 Then
            WordListBox.Items.RemoveAt(WordListBox.SelectedIndex)
        End If

    End Sub

    Private Sub cmdSaveWords_Click(sender As Object, e As EventArgs) Handles cmdSaveWords.Click
        Dim browser As New SaveFileDialog
        browser.Filter = "Text file (*.txt)|*.txt"
        browser.ShowDialog()
        If browser.FileName = "" Then Exit Sub
        Try
            Dim writer As New IO.StreamWriter(browser.FileName)

            For Each s As String In WordListBox.Items
                writer.WriteLine(s)
            Next

            writer.Dispose()
        Catch ex As Exception
            MsgBox("Error saving word list: " & ex.ToString())
        End Try
    End Sub

    Private Sub SetupForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveSettings()
    End Sub

    Private Sub LoadSettings()
        chkAllowDuplicates.Checked = My.Settings.AllowDuplicates
        txtGeneratorCount.Value = My.Settings.GenerateCount
        txtSpeed.Value = My.Settings.LetterSpeed
        txtRepeatCount.Value = My.Settings.WordRepeat
        WordListBox.Items.Clear()
        If IsNothing(My.Settings.Words) = False Then
            For Each s As String In My.Settings.Words
                WordListBox.Items.Add(s)
            Next
        Else
            Dim r As New Random
            For i As Integer = 0 To CInt(txtGeneratorCount.Value) - 1
                Dim j As Integer = r.Next(Dictionary.Count)
                Dim s As String = Dictionary(j)
                If AddWord(s, True) Then i -= 1
            Next
        End If
    End Sub

    Private Sub SaveSettings()
        My.Settings.AllowDuplicates = chkAllowDuplicates.Checked
        My.Settings.GenerateCount = CInt(txtGeneratorCount.Value)
        My.Settings.LetterSpeed = CInt(txtSpeed.Value)
        My.Settings.WordRepeat = CInt(txtRepeatCount.Value)
        'My.Settings.Words.Clear()
        My.Settings.Words = New Specialized.StringCollection()
        For Each s As String In WordListBox.Items
            My.Settings.Words.Add(s)
        Next
        My.Settings.Save() ' Even though it happens automatically, it's only automatic if the form closes without error and only when the form closes.
    End Sub

    Private Sub cmdStartQuiz_Click(sender As Object, e As EventArgs) Handles cmdStartQuiz.Click
        SaveSettings()
        If WordListBox.Items.Count < 1 Then
            MsgBox("You need at least one word to have a quiz!")
            Exit Sub
        End If
        Hide()
        QuizWindow.Show()
    End Sub

    Private Sub cmdClearWords_Click(sender As Object, e As EventArgs) Handles cmdClearWords.Click
        WordListBox.Items.Clear()
        cmdRemoveWord.Enabled = False
    End Sub

    Private Sub cmdVerySlow_Click(sender As Object, e As EventArgs) Handles cmdVerySlow.Click
        txtSpeed.Value = 1000
    End Sub

    Private Sub cmdSlow_Click(sender As Object, e As EventArgs) Handles cmdSlow.Click
        txtSpeed.Value = 700
    End Sub

    Private Sub cmdMedium_Click(sender As Object, e As EventArgs) Handles cmdMedium.Click
        txtSpeed.Value = 500
    End Sub

    Private Sub cmdFast_Click(sender As Object, e As EventArgs) Handles cmdFast.Click
        txtSpeed.Value = 300
    End Sub

    Private Sub cmdVeryFast_Click(sender As Object, e As EventArgs) Handles cmdVeryFast.Click
        txtSpeed.Value = 150
    End Sub

    Private Sub cmdMegaFast_Click(sender As Object, e As EventArgs) Handles cmdMegaFast.Click
        txtSpeed.Value = 100
    End Sub
End Class
