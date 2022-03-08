Public Class Form1
    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim var As String
        var = TextBox1.Text
        MsgBox(var)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
    End Sub
End Class
