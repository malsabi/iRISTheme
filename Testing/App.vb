Public Class App
    Private Sub IrisButton1_Click(sender As Object, e As EventArgs) Handles IrisButton1.Click
        MessageBox.Show("Email: " + IrisInputBox1.Text + " Password: " + IrisInputBox2.Text)
    End Sub
End Class