Public Class Cancel

    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        Me.Close()
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        Dim Cancel As New frmLogin
        frmLogin.Show()
        Me.Hide()
    End Sub
End Class