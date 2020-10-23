Public Class Form3
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
        Form2.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("http://localhost/phpmyadmin/db_structure.php?server=1&db=presensipraktikum")
    End Sub
End Class