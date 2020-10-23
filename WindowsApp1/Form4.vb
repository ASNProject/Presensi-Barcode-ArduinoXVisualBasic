Public Class Form4



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Koor" And TextBox2.Text = "coba456" Then
            Form5.Show()
            TextBox1.Text = ""
            TextBox2.Text = ""

        Else MsgBox("Username dan Password SALAH!")
            TextBox1.Text = ""
            TextBox2.Text = ""

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class