Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tgl As Integer
        For tgl = 1 To 31
            If tgl < 10 Then
                ComboBox1.Items.Add("0" & tgl)
            Else
                ComboBox1.Items.Add(tgl)
            End If
        Next
        Dim bln As Integer
        For bln = 1 To 12
            Dim a As String
            a = MonthName(bln)
            ComboBox2.Items.Add(a)
        Next
        Dim thn As Integer
        For thn = 1999 To 2006
            ComboBox3.Items.Add(thn)
        Next
        Dim rmbl As Integer
        For rmbl = 10 To 11
            If rmbl Then
                ComboBox4.Items.Add("RPL 1 -" & rmbl)
                ComboBox4.Items.Add("RPL 2 -" & rmbl)
                ComboBox4.Items.Add("RPL 3 -" & rmbl)
                ComboBox4.Items.Add("RPL 4 -" & rmbl)

                ComboBox4.Items.Add("TKJ 1 -" & rmbl)
                ComboBox4.Items.Add("TKJ 2 -" & rmbl)
                ComboBox4.Items.Add("TKJ 3 -" & rmbl)
                ComboBox4.Items.Add("TKJ 4 -" & rmbl)

                ComboBox4.Items.Add("OTKP 1 -" & rmbl)
                ComboBox4.Items.Add("OTKP 2 -" & rmbl)
                ComboBox4.Items.Add("OTKP 3 -" & rmbl)
                ComboBox4.Items.Add("OTKP 4 -" & rmbl)

                ComboBox4.Items.Add("MMD 1 -" & rmbl)
                ComboBox4.Items.Add("MMD 2 -" & rmbl)
                ComboBox4.Items.Add("MMD 3 -" & rmbl)
                ComboBox4.Items.Add("MMD 4 -" & rmbl)

                ComboBox4.Items.Add("BDP 1 -" & rmbl)
                ComboBox4.Items.Add("BDP 2 -" & rmbl)
                ComboBox4.Items.Add("BDP 3 -" & rmbl)
                ComboBox4.Items.Add("BDP 4 -" & rmbl)
            End If
        Next

        ComboBox5.Items.Add("Cicurug1")
        ComboBox5.Items.Add("Cicurug2")
        ComboBox5.Items.Add("Cicurug3")
        ComboBox5.Items.Add("Cicurug4")
        ComboBox5.Items.Add("Cicurug5")
        ComboBox5.Items.Add("Cicurug6")
        ComboBox5.Items.Add("Cicurug7")

        ComboBox5.Items.Add("Ciawi1")
        ComboBox5.Items.Add("Ciawi2")
        ComboBox5.Items.Add("Ciawi3")
        ComboBox5.Items.Add("Ciawi4")
        ComboBox5.Items.Add("Ciawi5")

        ComboBox5.Items.Add("Cisarua1")
        ComboBox5.Items.Add("Cisarua2")
        ComboBox5.Items.Add("Cisarua3")
        ComboBox5.Items.Add("Cisarua4")
        ComboBox5.Items.Add("Cisarua5")

        ComboBox6.Items.Add("Pencaksilat")
        ComboBox6.Items.Add("Tekondo")
        ComboBox6.Items.Add("Sepak Bola")
        ComboBox6.Items.Add("Futsal")
        ComboBox6.Items.Add("Batminton")
        ComboBox6.Items.Add("Voli")
        ComboBox6.Items.Add("Cyber Club")
        ComboBox6.Items.Add("Englis Club")
        ComboBox6.Items.Add("Basket")
        ComboBox6.Items.Add("Robotik")
        ComboBox6.Items.Add("Paskib")
        ComboBox6.Items.Add("Linux")
        ComboBox6.Items.Add("MR")

        ComboBox9.Items.Add("Seni Rupa")
        ComboBox9.Items.Add("Musik Moderen")
        ComboBox9.Items.Add("Musik Tradisinoal")
        ComboBox9.Items.Add("Seni Suara")
        ComboBox9.Items.Add("Seni Teater")
        ComboBox9.Items.Add("Gitar")
        ComboBox9.Items.Add("Perpusi")

        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
    End Sub

    Private Sub ComboBox6_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.SelectedItem = "Pencaksilat" Then
            TextBox6.Text = "Senin"
            TextBox7.Text = "Pak Doni"
        ElseIf ComboBox6.SelectedItem = "Tekondo" Then
            TextBox6.Text = "Senin"
            TextBox7.Text = "Pak Didi"
        ElseIf ComboBox6.SelectedItem = "Sepak Bola" Then
            TextBox6.Text = "Selasa"
            TextBox7.Text = "Pak Daus"
        ElseIf ComboBox6.SelectedItem = "Futsal" Then
            TextBox6.Text = "Selasa"
            TextBox7.Text = "Pak Ardi"
        ElseIf ComboBox6.SelectedItem = "Batminton" Then
            TextBox6.Text = "Rabu"
            TextBox7.Text = "Pak Feri"
        ElseIf ComboBox6.SelectedItem = "Voli" Then
            TextBox6.Text = "Rabu"
            TextBox7.Text = "Pak jalil"
        ElseIf ComboBox6.SelectedItem = "Cyber Club" Then
            TextBox6.Text = "Kamis"
            TextBox7.Text = "Pak Imam"
        ElseIf ComboBox6.SelectedItem = "Englis Club" Then
            TextBox6.Text = "Kamis"
            TextBox7.Text = "Pak Endang"
        ElseIf ComboBox6.SelectedItem = "Basket" Then
            TextBox6.Text = "Sabtu"
            TextBox7.Text = "Pak Feri"
        ElseIf ComboBox6.SelectedItem = "Robotik" Then
            TextBox6.Text = "Rabu"
            TextBox7.Text = "Pak Dedek"
        ElseIf ComboBox6.SelectedItem = "Paskib" Then
            TextBox6.Text = "Sabtu"
            TextBox7.Text = "Pak Sandi"
        ElseIf ComboBox6.SelectedItem = "Linux" Then
            TextBox6.Text = "Juumat"
            TextBox7.Text = "Pak Didil"
        ElseIf ComboBox6.SelectedItem = "MR" Then
            TextBox6.Text = "Rabu"
            TextBox7.Text = "Pak Didik"
        End If
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedIndexChanged
        If ComboBox9.SelectedItem = "Seni Rupa" Then
            TextBox8.Text = "Senin"
            TextBox9.Text = "Pak Firman"
        ElseIf ComboBox9.SelectedItem = "Musik Moderen" Then
            TextBox8.Text = "Selasa"
            TextBox9.Text = "Pak Hendri"
        ElseIf ComboBox9.SelectedItem = "Musik Tradisional" Then
            TextBox8.Text = "Rabu"
            TextBox9.Text = "BU Jubaidah"
        ElseIf ComboBox9.SelectedItem = "Seni Suara" Then
            TextBox8.Text = "Kamis"
            TextBox9.Text = "Bu cici"
        ElseIf ComboBox9.SelectedItem = "Seni Teater" Then
            TextBox8.Text = "Jumat"
            TextBox9.Text = "Pak Alex"
        ElseIf ComboBox6.SelectedItem = "Seni Pepusi" Then
            TextBox6.Text = "Sabtu"
            TextBox9.Text = "Pak Wawi"
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or RadioButton1.Checked = False And RadioButton2.Checked = False Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Or ComboBox4.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox6.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or ComboBox9.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Then
            MsgBox("Semua data harus diisi!", vbInformation, "Peringatan")
        ElseIf TextBox6.Text = TextBox8.Text Or TextBox7.Text = TextBox9.Text Then
            MsgBox("HARI TIDAK BOLEH SAMA!", vbInformation)
        Else
            DataGridView2.Rows.Add(1)
            DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(0).Value = TextBox1.Text
            DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(1).Value = TextBox2.Text
            Dim kel As Char
            If RadioButton1.Checked = True And RadioButton2.Checked = False Then
                kel = "Pria"
                DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(2).Value = RadioButton1.Text
            ElseIf RadioButton2.Checked = False And RadioButton2.Checked = True Then
                kel = "Wanita"
                DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(2).Value = RadioButton2.Text
            End If
            DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(3).Value = TextBox3.Text
            DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(4).Value = ComboBox1.Text & "-" & ComboBox2.Text & "-" & ComboBox3.Text
            DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(5).Value = ComboBox4.Text
            DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(6).Value = ComboBox5.Text
            DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(7).Value = TextBox4.Text
            DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(8).Value = TextBox4.Text
            DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(9).Value = ComboBox6.Text
            DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(10).Value = TextBox6.Text
            DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(11).Value = TextBox7.Text
            DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(12).Value = ComboBox9.Text
            DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(13).Value = TextBox8.Text
            DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(14).Value = TextBox9.Text
            DataGridView2.Update()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Environment.Exit(0)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim hapus As String
        hapus = MsgBox("Hapus Data", vbYesNo)
        If hapus = vbYes Then
            DataGridView2.Rows.RemoveAt(DataGridView2.CurrentRow.Index)
            MsgBox("Anda telah mengahapus data")
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.RowHeaderMouseClick
        TextBox3.Text = DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(0).Value
        TextBox1.Text = DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(1).Value
        Dim kel As Char
        If RadioButton1.Checked = True And RadioButton2.Checked = False Then
            kel = "Pria"
            RadioButton1.Text = DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(2).Value
        ElseIf RadioButton2.Checked = False And RadioButton2.Checked = True Then
            kel = "Wanita"
            RadioButton2.Text = DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(2).Value
        End If
        TextBox5.Text = DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(3).Value
        ComboBox1.Text = DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(4).Value


    End Sub
End Class
