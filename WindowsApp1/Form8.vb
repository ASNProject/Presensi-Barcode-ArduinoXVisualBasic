Public Class Form8
    Sub ambildastela()
        Try
            Call koneksi()
            Dim str As String
            str = "select * from dastela where NIM = '" & TextBox1.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                TextBox2.Text = rd.Item("NAMA")
                TextBox3.Text = rd.Item("NIM")
                TextBox4.Text = ComboBox1.Text
                TextBox5.Text = rd.Item("KELAS")
                TextBox6.Text = rd.Item("JUMLAH")
                TextBox7.Text = rd.Item("TOTAL")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub ambildastelb()
        Try
            Call koneksi()
            Dim str As String
            str = "select * from dastelb where NIM = '" & TextBox1.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                TextBox2.Text = rd.Item("NAMA")
                TextBox3.Text = rd.Item("NIM")
                TextBox4.Text = ComboBox1.Text
                TextBox5.Text = rd.Item("KELAS")
                TextBox6.Text = rd.Item("JUMLAH")
                TextBox7.Text = rd.Item("TOTAL")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub ambiltkdppa()
        Try
            Call koneksi()
            Dim str As String
            str = "select * from tkdppa where NIM = '" & TextBox1.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                TextBox2.Text = rd.Item("NAMA")
                TextBox3.Text = rd.Item("NIM")
                TextBox4.Text = ComboBox1.Text
                TextBox5.Text = rd.Item("KELAS")
                TextBox6.Text = rd.Item("JUMLAH")
                TextBox7.Text = rd.Item("TOTAL")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub ambiltkdppb()
        Try
            Call koneksi()
            Dim str As String
            str = "select * from tkdppb where NIM = '" & TextBox1.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                TextBox2.Text = rd.Item("NAMA")
                TextBox3.Text = rd.Item("NIM")
                TextBox4.Text = ComboBox1.Text
                TextBox5.Text = rd.Item("KELAS")
                TextBox6.Text = rd.Item("JUMLAH")
                TextBox7.Text = rd.Item("TOTAL")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub ambildkpa()
        Try
            Call koneksi()
            Dim str As String
            str = "select * from dkpa where NIM = '" & TextBox1.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                TextBox2.Text = rd.Item("NAMA")
                TextBox3.Text = rd.Item("NIM")
                TextBox4.Text = ComboBox1.Text
                TextBox5.Text = rd.Item("KELAS")
                TextBox6.Text = rd.Item("JUMLAH")
                TextBox7.Text = rd.Item("TOTAL")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub ambildkpb()
        Try
            Call koneksi()
            Dim str As String
            str = "select * from dkpb where NIM = '" & TextBox1.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                TextBox2.Text = rd.Item("NAMA")
                TextBox3.Text = rd.Item("NIM")
                TextBox4.Text = ComboBox1.Text
                TextBox5.Text = rd.Item("KELAS")
                TextBox6.Text = rd.Item("JUMLAH")
                TextBox7.Text = rd.Item("TOTAL")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Dasar Sistem Telekomunikasi" And TextBox8.Text = "A" Then
            Call ambildastela()
        End If
        If ComboBox1.Text = "Dasar Sistem Telekomunikasi" And TextBox8.Text = "B" Then
            Call ambildastelb()
        End If
        If ComboBox1.Text = "Teknik Klasifikasi dan Pengenalan Pola" And TextBox8.Text = "A" Then
            Call ambiltkdppa()
        End If
        If ComboBox1.Text = "Teknik Klasifikasi dan Pengenalan Pola" And TextBox8.Text = "B" Then
            Call ambiltkdppb()
        End If
        If ComboBox1.Text = "Dasar Komputer Pemrograman" And TextBox8.Text = "A" Then
            Call ambildkpa()
        End If
        If ComboBox1.Text = "Dasar Komputer Pemrograman" And TextBox8.Text = "B" Then
            Call ambildkpb()
        End If
    End Sub
End Class