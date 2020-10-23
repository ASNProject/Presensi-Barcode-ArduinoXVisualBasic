Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "ADMIN" And TextBox2.Text = "coba123" Then
            Form3.Show()
            TextBox1.Text = ""
            TextBox2.Text = ""
        Else MsgBox("Username dan Password SALAH!")
            TextBox1.Text = ""
            TextBox2.Text = ""

        End If

    End Sub
End Class