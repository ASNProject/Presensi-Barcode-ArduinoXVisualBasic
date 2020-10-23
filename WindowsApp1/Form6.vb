Imports MySql.Data.MySqlClient
Imports iTextSharp
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.Data.Odbc
Imports System.IO



Public Class Form6
    Dim receivedData As String = ""

    Dim miliseconds, seconds, minutes, hours As Integer
    Private dgvTabel As Object

    'Catatan :
    '1. Buatalah "Sub" baru jika ingin menambah database yang akan dipanggil.
    '2. Buatlah 2 Sub yaitu sub database dan sub untuk update database

    '1. Database Matakuliah Dasar Telekomunikasi kelas A
    Sub dastela()
        Try
            Call koneksi()
            Dim str As String
            str = "select * from dastela where NIM = '" & TextBox3.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                TextBox4.Text = rd.Item("NAMA")
                TextBox5.Text = rd.Item("KELAS")
                TextBox6.Text = rd.Item("JUMLAH")
                TextBox7.Text = rd.Item("TOTAL")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub dastelaupdate()
        Try
            Call koneksi()
            Dim str As String
            str = "Update dastela set JUMLAH = '" & TextBox6.Text + 1 & "' where NIM = '" & TextBox3.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            DataGridView1.Rows.Add(1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = TextBox4.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = TextBox3.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = TextBox5.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = Format(Now, "dd/MM/yyyy")
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(4).Value = Format(Now, "hh/mm/sss")
            If minutes >= 15 Then
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = "Terlambat"
                MessageBox.Show("Maaf Anda Terlambat")
            Else
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = "Tepat Waktu"
            End If
            DataGridView1.Update()
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            'MessageBox.Show("Absensi Berhasil" & vbNewLine & "    Terimakasih!")
        Catch ex As Exception
            MessageBox.Show("         Absensi Gagal" & vbNewLine & "Maaf Ini Bukan Sift Anda!")
        End Try

    End Sub

    '2. Database Praktikum Dasar Sistem Telekomunikasi Kelas B
    Sub dastelb()
        Try
            Call koneksi()
            Dim str As String
            str = "select * from dastelb where NIM = '" & TextBox3.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                TextBox4.Text = rd.Item("NAMA")
                TextBox5.Text = rd.Item("KELAS")
                TextBox6.Text = rd.Item("JUMLAH")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Sub dastelbupdate()
        Try
            Call koneksi()
            Dim str As String
            str = "Update dastelb set JUMLAH = '" & TextBox6.Text + 1 & "' where NIM = '" & TextBox3.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            DataGridView1.Rows.Add(1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = TextBox4.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = TextBox3.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = TextBox5.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = Format(Now, "dd/MM/yyyy")
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(4).Value = Format(Now, "hh/mm/sss")

            If minutes >= 15 Then
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = "Terlambat"
                MessageBox.Show("Maaf Anda Terlambat")
            Else
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = "Tepat Waktu"
            End If
            DataGridView1.Update()
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            'MessageBox.Show("Absensi Berhasil" & vbNewLine & "    Terimakasih!")
        Catch ex As Exception
            MessageBox.Show("         Absensi Gagal" & vbNewLine & "Maaf Ini Bukan Sift Anda!")
        End Try

    End Sub

    '3. Database Praktikum Teknik Klasifikasi dan Pengenalan Pola Kelas A
    Sub tkdppa()
        Try
            Call koneksi()
            Dim str As String
            str = "select * from tkdppa where NIM = '" & TextBox3.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                TextBox4.Text = rd.Item("NAMA")
                TextBox5.Text = rd.Item("KELAS")
                TextBox6.Text = rd.Item("JUMLAH")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Sub tkdppaupdate()
        Try
            Call koneksi()
            Dim str As String
            str = "Update tkdppa set JUMLAH = '" & TextBox6.Text + 1 & "'where NIM = '" & TextBox3.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            DataGridView1.Rows.Add(1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = TextBox4.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = TextBox3.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = TextBox5.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = Format(Now, "dd/MM/yyyy")
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(4).Value = Format(Now, "hh/mm/sss")

            If minutes >= 15 Then
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = "Terlambat"
                MessageBox.Show("Maaf Anda Terlambat")
            Else
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = "Tepat Waktu"
            End If
            DataGridView1.Update()
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            'MessageBox.Show("Absensi Berhasil" & vbNewLine & "    Terimakasih!")
        Catch ex As Exception
            MessageBox.Show("         Absensi Gagal" & vbNewLine & "Maaf Ini Bukan Sift Anda!")
        End Try
    End Sub

    '4. Database Praktikum Teknik Klasifikasi dan Pengolahan Pola Kelas B
    Sub tkdppb()
        Try
            Call koneksi()
            Dim str As String
            str = "select * from tkdppb where NIM = '" & TextBox3.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                TextBox4.Text = rd.Item("NAMA")
                TextBox5.Text = rd.Item("KELAS")
                TextBox6.Text = rd.Item("JUMLAH")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Sub tkdppbupdate()
        Try
            Call koneksi()
            Dim str As String
            str = "Update tkdppb set JUMLAH = '" & TextBox6.Text + 1 & "' where NIM = '" & TextBox3.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            DataGridView1.Rows.Add(1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = TextBox4.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = TextBox3.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = TextBox5.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = Format(Now, "dd/MM/yyyy")
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(4).Value = Format(Now, "hh/mm/sss")

            If minutes >= 15 Then
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = "Terlambat"
                MessageBox.Show("Maaf Anda Terlambat")
            Else
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = "Tepat Waktu"
            End If
            DataGridView1.Update()
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            'MessageBox.Show("Absensi Berhasil" & vbNewLine & "    Terimakasih!")
        Catch ex As Exception
            MessageBox.Show("         Absensi Gagal" & vbNewLine & "Maaf Ini Bukan Sift Anda!")
        End Try
    End Sub

    '5. Database Matakuliah Dasar Komputer Pemrograman kelas A
    Sub dkpa()
        Try
            Call koneksi()
            Dim str As String
            str = "select * from dkpa where NIM = '" & TextBox3.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                TextBox4.Text = rd.Item("NAMA")
                TextBox5.Text = rd.Item("KELAS")
                TextBox6.Text = rd.Item("JUMLAH")
                TextBox7.Text = rd.Item("TOTAL")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub dkpaupdate()
        Try
            Call koneksi()
            Dim str As String
            str = "Update dkpa set JUMLAH = '" & TextBox6.Text + 1 & "' where NIM = '" & TextBox3.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            DataGridView1.Rows.Add(1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = TextBox4.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = TextBox3.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = TextBox5.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = Format(Now, "dd/MM/yyyy")
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(4).Value = Format(Now, "hh/mm/sss")
            If minutes >= 15 Then
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = "Terlambat"
                MessageBox.Show("Maaf Anda Terlambat")
            Else
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = "Tepat Waktu"
            End If
            DataGridView1.Update()
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            'MessageBox.Show("Absensi Berhasil" & vbNewLine & "    Terimakasih!")
        Catch ex As Exception
            MessageBox.Show("         Absensi Gagal" & vbNewLine & "Maaf Ini Bukan Sift Anda!")
        End Try
    End Sub

    '6. Database Matakuliah Dasar Komputer Pemrograman kelas B
    Sub dkpb()
        Try
            Call koneksi()
            Dim str As String
            str = "select * from dkpb where NIM = '" & TextBox3.Text & "'"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                TextBox4.Text = rd.Item("NAMA")
                TextBox5.Text = rd.Item("KELAS")
                TextBox6.Text = rd.Item("JUMLAH")
                TextBox7.Text = rd.Item("TOTAL")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub dkpbupdate()
        Try
            Call koneksi()
            Dim str As String
            str = "Update dkpb set JUMLAH = '" & TextBox6.Text + 1 & "' where NIM = '" & TextBox3.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            DataGridView1.Rows.Add(1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = TextBox4.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = TextBox3.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = TextBox5.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = Format(Now, "dd/MM/yyyy")
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(4).Value = Format(Now, "hh/mm/sss")
            If minutes >= 15 Then
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = "Terlambat"
                MessageBox.Show("Maaf Anda Terlambat")
            Else
                DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(5).Value = "Tepat Waktu"
            End If
            DataGridView1.Update()
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            'MessageBox.Show("Absensi Berhasil" & vbNewLine & "    Terimakasih!")
        Catch ex As Exception
            MessageBox.Show("         Absensi Gagal" & vbNewLine & "Maaf Ini Bukan Sift Anda!")
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try
        'TextBox3.Text = SerialPort1.ReadExisting
        'Dim Sensor As String
        'Sensor = (TextBox3.Lines(1).ToString)
        'Catch ex As Exception

        'End Try

        'Catatan :
        'Buatlah Suatu permisalan disini untuk memanggil setiap database matakulian

        '1. Memanggil database matakuliah Dasar Sistem Telekomunikasi Kelas A
        If TextBox1.Text = "Dasar Sistem Telekomunikasi" And TextBox2.Text = "A" Then
            Call dastelaupdate()
        End If
        '2. Memanggil database matakuliah ...
        ' Isi disini
        If TextBox1.Text = "Dasar Sistem Telekomunikasi" And TextBox2.Text = "B" Then
            Call dastelbupdate()
        End If
        '3. Memanggil database matakuliah ...
        If TextBox1.Text = "Teknik Klasifikasi dan Pengenalan Pola" And TextBox2.Text = "A" Then
            Call tkdppaupdate()
        End If
        '4. Memanggil database matakuliah ...
        If TextBox1.Text = "Teknik Klasifikasi dan Pengenalan Pola" And TextBox2.Text = "B" Then
            Call tkdppbupdate()
        End If
        '5. Memanggil database matakuliah ...
        If TextBox1.Text = "Dasar Komputer Pemrograman" And TextBox2.Text = "A" Then
            Call dkpaupdate()
        End If
        '6. Memanggil database matakuliah ...
        If TextBox1.Text = "Dasar Komputer Pemrograman" And TextBox2.Text = "B" Then
            Call dkpbupdate()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Form7.Show()
        'Form7.Label7.Text = TextBox1.Text
        'Form7.Label8.Text = TextBox2.Text
        'Form7.Label9.Text = waktu.Text
        'Form7.DataGridView1 = DataGridView1
        'Close()
        'Form5.Close()
        'Form4.Close()
        Dim ExcelApp As Object, ExcelBook As Object
        Dim ExcelSheet As Object

        Dim i As Integer
        Dim j As Integer
        ExcelApp = CreateObject("Excel.Application")
        ExcelBook = ExcelApp.WorkBooks.Add
        ExcelSheet = ExcelBook.WorkSheets(1)
        With ExcelSheet
            ExcelSheet.Cells(1, 1).Value = "Daftar Presensi Praktikum" + " " + TextBox1.Text
            ExcelSheet.Cells(2, 1).Value = "Program Studi Teknik Elektro"
            ExcelSheet.Cells(3, 1).Value = "Fakultas Teknologi Industri"
            ExcelSheet.Cells(4, 1).Value = "Universitas Ahmad Dahlan"
            ExcelSheet.Cells(6, 1).Value = "Nama"
            ExcelSheet.Cells(6, 2).Value = "NIM"
            ExcelSheet.Cells(6, 3).Value = "Kelas"
            ExcelSheet.Cells(6, 4).Value = "Tanggal"
            ExcelSheet.Cells(6, 5).Value = "Waktu"
            ExcelSheet.Cells(6, 6).Value = "Keterangan"

            For i = 1 To Me.DataGridView1.RowCount
                .cells(i + 6, 1) = Me.DataGridView1.Rows(i - 1).Cells(0).Value
                For j = 1 To DataGridView1.Columns.Count - 1
                    .cells(i + 6, j + 1) = DataGridView1.Rows(i - 1).Cells(j).Value
                Next
            Next
        End With

        ExcelApp.Visible = True
        ExcelSheet = Nothing
        ExcelBook = Nothing
        ExcelApp = Nothing

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Form5.Close()
        Form4.Close()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        receivedData = RecieveSerialData()
        TextBox3.Text &= receivedData
    End Sub

    Function RecieveSerialData() As Object
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As Exception
            Return "Error: Serial Port read timed out."
        End Try
    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Open()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        'Dim i As Single = SerialPort1.ReadExisting
        'TextBox3.Text = "Scan " & i.ToString
        'Timer1.Stop()


        'Catatan;
        'Buat suatu permisalan untuk memanggail database sesuai dengan matakuliah dan kelas

        '1. Matakuliah dastel kelas A
        If TextBox1.Text = "Dasar Sistem Telekomunikasi" And TextBox2.Text = "A" Then
            Call dastela()
        End If
        '2. Matakuliah Dastel kelas B
        'Buat disini
        If TextBox1.Text = "Dasar Sistem Telekomunikasi" And TextBox2.Text = "B" Then
            Call dastelb()
        End If
        '3. Matakuliah TKPP kelas A
        If TextBox1.Text = "Teknik Klasifikasi dan Pengenalan Pola" And TextBox2.Text = "A" Then
            Call tkdppa()
        End If
        '4. Matakuliah TKPP kelas B
        If TextBox1.Text = "Teknik Klasifikasi dan Pengenalan Pola" And TextBox2.Text = "B" Then
            Call tkdppb()
        End If
        '5. Matakuliah DKP kelas A
        If TextBox1.Text = "Dasar Komputer Pemrograman" And TextBox2.Text = "A" Then
            Call dkpa()
        End If
        '6. Matakuliah DKP kelas B
        If TextBox1.Text = "Dasar Komputer Pemrograman" And TextBox2.Text = "B" Then
            Call dkpb()
        End If

    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If miliseconds = 60 Then
            miliseconds = 0
            seconds = seconds + 1
        End If
        If seconds = 60 Then
            If miliseconds = 0 Then
                miliseconds = 0
                seconds = 0
                minutes = minutes + 1
            End If
        End If
        If minutes = 60 Then
            If miliseconds = 60 Then
                miliseconds = 0
                seconds = 0
                minutes = 0
                hours = hours + 1
            End If
        End If
        miliseconds = miliseconds + 1
        Label8.Text = Format(hours, "00") & ":" & Format(minutes, "00") & ":" & Format(seconds, "00") & ":" & Format(miliseconds, "00")
    End Sub
End Class