Public Class UnlockForm

    Private Sub UnlockForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        TextBox1.Select()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "openup" Then
            If MainForm.UnlockValue = 1 Then
                MainForm.CitBox.Enabled = True
            ElseIf MainForm.UnlockValue = 2 Then
                MainForm.ExpBox.Enabled = True
            ElseIf MainForm.UnlockValue = 3 Then
                MainForm.ExpDBox.Enabled = True
            ElseIf MainForm.UnlockValue = 4 Then
                MainForm.SBox.Enabled = True
            ElseIf MainForm.UnlockValue = 5 Then
                MainForm.GBox.Enabled = True
            ElseIf MainForm.UnlockValue = 6 Then
                MainForm.CBox.Enabled = True
            ElseIf MainForm.UnlockValue = 7 Then
                MainForm.LBox.Enabled = True
            ElseIf MainForm.UnlockValue = 8 Then
                MainForm.XPBox.Enabled = True
            ElseIf MainForm.UnlockValue = 9 Then
                MainForm.SPBox.Enabled = True
            End If
        ElseIf TextBox1.Text = "openall" Then
            MainForm.CitBox.Enabled = True
            MainForm.ExpBox.Enabled = True
            MainForm.ExpDBox.Enabled = True
            MainForm.SBox.Enabled = True
            MainForm.GBox.Enabled = True
            MainForm.CBox.Enabled = True
            MainForm.LBox.Enabled = True
            MainForm.XPBox.Enabled = True
            MainForm.SPBox.Enabled = True
        Else
        MsgBox("Invalid Password", MsgBoxStyle.Exclamation, "Error")
        End If
        TextBox1.Clear()
        Me.Close()
    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then Button1.PerformClick()
    End Sub
End Class