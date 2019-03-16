Public Class MainForm

    '<Load>'

    Public UnlockValue As Integer

    Private Sub MainForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        GBox.SelectedItem = "Supremacy"
        LBox.Value = 10
        XPBox.Value = 150000
        SPBox.Value = 12
        GButton.Select()
    End Sub

    '<Code/Script>'

    Private Sub CitLabel_DoubleClick(sender As Object, e As System.EventArgs) Handles CitLabel.DoubleClick
        If CitBox.Enabled = False Then
            UnlockValue = 1
            UnlockForm.ShowDialog()
        End If
    End Sub

    Private Sub ExpLabel_DoubleClick(sender As Object, e As System.EventArgs) Handles ExpLabel.DoubleClick
        If ExpBox.Enabled = False Then
            UnlockValue = 2
            UnlockForm.ShowDialog()
        End If
    End Sub

    Private Sub ExpDLabel_DoubleClick(sender As Object, e As System.EventArgs) Handles ExpDLabel.DoubleClick
        If ExpDBox.Enabled = False Then
            UnlockValue = 3
            UnlockForm.ShowDialog()
        End If
    End Sub

    Private Sub SLabel_DoubleClick(sender As Object, e As System.EventArgs) Handles SLabel.DoubleClick
        If SBox.Enabled = False Then
            UnlockValue = 4
            UnlockForm.ShowDialog()
        End If
    End Sub

    Private Sub GLabel_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles GLabel.MouseDoubleClick
        If GBox.Enabled = False Then
            UnlockValue = 5
            UnlockForm.ShowDialog()
        End If
    End Sub

    Private Sub CLabel_DoubleClick(sender As Object, e As System.EventArgs) Handles CLabel.DoubleClick
        If CBox.Enabled = False Then
            UnlockValue = 6
            UnlockForm.ShowDialog()
        End If
    End Sub

    Private Sub LBox_DoubleClick(sender As Object, e As System.EventArgs) Handles LLabel.DoubleClick
        If LBox.Enabled = False Then
            UnlockValue = 7
            UnlockForm.ShowDialog()
        End If
    End Sub

    Private Sub XPLabel_DoubleClick(sender As Object, e As System.EventArgs) Handles XPLabel.DoubleClick
        If XPBox.Enabled = False Then
            UnlockValue = 8
            UnlockForm.ShowDialog()
        End If
    End Sub

    Private Sub SPLabel_DoubleClick(sender As Object, e As System.EventArgs) Handles SPLabel.DoubleClick
        If SPBox.Enabled = False Then
            UnlockValue = 9
            UnlockForm.ShowDialog()
        End If
    End Sub

    Private Sub FlagBox_Click(sender As System.Object, e As System.EventArgs) Handles FlagBox.Click
        Try
            System.Diagnostics.Process.Start("http://www.ageofempires3.com/age3/Civilizations/Default.aspx")
        Catch
            MsgBox("Failed to open link.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CBox_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles CBox.SelectedIndexChanged
        FlagChange()
    End Sub

    Private Sub AButton_Click(sender As System.Object, e As System.EventArgs) Handles AButton.Click
        MsgBox("Made by Johannes Brittain for Age of Empires III LAN Version" & vbNewLine & "(XP editing not fully supported)" & vbNewLine & "Program Version: " & Me.ProductVersion, , "About")
    End Sub

    Private Sub GButton_Click(sender As System.Object, e As System.EventArgs) Handles GButton.Click
        If CitBox.Text.ToLower.Contains("joel") Or ExpBox.Text.ToLower.Contains("joel") Or ExpDBox.Text.ToLower.Contains("joel") Or SBox.Text.ToLower.Contains("joel") Then
            MsgBox("Please don't tease Joel!" & vbNewLine & "(it's not very nice)", MsgBoxStyle.Exclamation, "No")
        ElseIf CitBox.Text = "" Or ExpBox.Text = "" Or ExpDBox.Text = "" Or SBox.Text = "" Or CBox.Text = "" Then
            MsgBox("Please fill in all of the fields.", MsgBoxStyle.Exclamation, "Message")
        Else
            WriteXML.Main()
        End If
    End Sub

    Private Sub EButton_Click(sender As System.Object, e As System.EventArgs) Handles EButton.Click
        Application.Exit()
    End Sub

    '<Functions>'

    Sub FlagChange()
        If CBox.Text = "British" Then
            FlagBox.Image = My.Resources.britain
        ElseIf CBox.Text = "German" Then
            FlagBox.Image = My.Resources.germany
        ElseIf CBox.Text = "Spanish" Then
            FlagBox.Image = My.Resources.spain
        ElseIf CBox.Text = "French" Then
            FlagBox.Image = My.Resources.france
        ElseIf CBox.Text = "Portuguese" Then
            FlagBox.Image = My.Resources.portugal
        ElseIf CBox.Text = "Dutch" Then
            FlagBox.Image = My.Resources.netherlands
        ElseIf CBox.Text = "Ottomans" Then
            FlagBox.Image = My.Resources.ottomanland
        ElseIf CBox.Text = "Russians" Then
            FlagBox.Image = My.Resources.russia
        ElseIf CBox.Text = "" Then
            FlagBox.Image = My.Resources.none
        End If
    End Sub


End Class
