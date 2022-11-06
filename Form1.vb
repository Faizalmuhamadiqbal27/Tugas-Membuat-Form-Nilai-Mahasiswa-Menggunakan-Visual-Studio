Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Menghapus semua isi huruf dan angka
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Memberi Inisial pada masing-masing variabel/objek
        Dim npm = TextBox1.Text
        Dim NAMA = TextBox2.Text
        Dim sks = TextBox8.Text
        Dim NILAITUGAS As Double = TextBox3.Text
        Dim Nilaiuas As Double = TextBox5.Text
        Dim nilaiuts As Double = TextBox4.Text
        Dim nilaibobot = TextBox9.Text
        Dim totalsemester = TextBox10.Text
        Dim ips
        Dim ipk

        'Menghitung nilai bobot(nilaitugas*20% + nilaiuts*30% + nilaiuas*50%
        nilaibobot = (NILAITUGAS * 0.2 + Nilaiuas * 0.5 + nilaiuts * 0.3)
        TextBox9.Text = nilaibobot

        'Menghitung nilai IPS (nilai bobot/sks)
        ips = (nilaibobot / sks)
        TextBox6.Text = ips

        'Menghitung nilai ipk(nilai bobot*totalsemester/sks*totalsemester)
        ipk = ((nilaibobot * totalsemester) / (sks * totalsemester))
        TextBox7.Text = ipk
        TextBox6.Text = TextBox6.Text.Substring(0, 3)
        TextBox7.Text = TextBox7.Text.Substring(0, 3)

        'Apabila IPK lebih dari 3, Maka Dinyatakan Lulus
        If TextBox7.Text >= "3" Then
            TextBox11.Text = "SELAMAT ANDA LULUS"
        End If
    End Sub
End Class
