Public Class App
    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IrisButton1_Click(sender As Object, e As EventArgs) Handles IrisButton1.Click
        IrisVerticalTabControl1.IsEnabled = False
    End Sub
End Class