Imports MySql.Data.MySqlClient

Public Class Form5
    Sub dastelaa()
        Call koneksi()
        Dim str1 As String
        str1 = "Update dastela set TOTAL = '" & TextBox1.Text & "'"
        cmd = New MySqlCommand(str1, conn)
        cmd.ExecuteNonQuery()
    End Sub
    Sub dastelbb()
        Call koneksi()
        Dim str1 As String
        str1 = "Update dastelb set TOTAL = '" & TextBox1.Text & "'"
        cmd = New MySqlCommand(str1, conn)
        cmd.ExecuteNonQuery()
    End Sub
    Sub tkdppaa()
        Call koneksi()
        Dim str1 As String
        str1 = "Update tkdppa set TOTAL = '" & TextBox1.Text & "'"
        cmd = New MySqlCommand(str1, conn)
        cmd.ExecuteNonQuery()
    End Sub
    Sub tkdppbb()
        Call koneksi()
        Dim str1 As String
        str1 = "Update tkdppb set TOTAL = '" & TextBox1.Text & "'"
        cmd = New MySqlCommand(str1, conn)
        cmd.ExecuteNonQuery()
    End Sub
    Sub dkpaa()
        Call koneksi()
        Dim str1 As String
        str1 = "Update dkpa set TOTAL = '" & TextBox1.Text & "'"
        cmd = New MySqlCommand(str1, conn)
        cmd.ExecuteNonQuery()
    End Sub
    Sub dkpbb()
        Call koneksi()
        Dim str1 As String
        str1 = "Update dkpb set TOTAL = '" & TextBox1.Text & "'"
        cmd = New MySqlCommand(str1, conn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Dasar Sistem Telekomunikasi" And ComboBox2.Text = "A" Then
            Call dastelaa()
        End If
        If ComboBox1.Text = "Dasar Sistem Telekomunikasi" And ComboBox2.Text = "B" Then
            Call dastelbb()
        End If
        If ComboBox1.Text = "Teknik Klasifikasi dan Pengenalan Pola" And ComboBox2.Text = "A" Then
            Call tkdppaa()
        End If
        If ComboBox1.Text = "Teknik Klasifikasi dan Pengenalan Pola" And ComboBox2.Text = "B" Then
            Call tkdppbb()
        End If
        If ComboBox1.Text = "Dasar Komputer Pemrograman" And ComboBox2.Text = "A" Then
            Call dkpaa()
        End If
        If ComboBox1.Text = "Dasar Komputer Pemrograman" And ComboBox2.Text = "B" Then
            Call dkpbb()
        End If

        If ComboBox1.Text = "" Then
            MsgBox("Silahkan Isi Matapraktikum Dulu")

        ElseIf ComboBox2.Text = " " Then
            MsgBox("Silahkan isi Kelas Dulu")
        ElseIf TextBox1.Text = " " Then
            MsgBox("Silahkan isi Pertemuan Ke-")
        Else
            Form6.Show()
            Form6.TextBox1.Text = ComboBox1.Text
            Form6.TextBox2.Text = ComboBox2.Text
            SerialPort1.BaudRate = 9600
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        Form4.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

    End Sub
End Class