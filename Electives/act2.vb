Public Class act2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = 2
        Dim discountamttextbox As Decimal
        Dim pricetextbox As Decimal
        Dim quantitytextbox As Decimal
        Dim pricequan As Integer
        Dim itemprice As Integer
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim itemname As String
        Dim itemprice As Integer


        itemname = "Resident evil"
        nametextbox.Text = itemname
        pricetextbox.Text = Decimal.Parse(2000)


    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        nametextbox.Clear()
        pricetextbox.Clear()

        quantitytextbox.Clear()
        cashrenderedtext.Clear()
        changetext.Clear()
        tquantitytextbox.Clear()
        tdiscountamttextbox.Clear()
        tdiscounttextbox.Clear()
        discounttextbox.Clear()
        discountamttextbox.Clear()



        seniorradio.Checked = False
        wdcradio.Checked = False
        edradio.Checked = False
        nodiscountradio.Checked = False
    End Sub

    Private Sub seniorradio_CheckedChanged(sender As Object, e As EventArgs) Handles seniorradio.CheckedChanged
        Dim secondnum, discount, discounttotal, quandiscount, totalquan1 As Decimal
        Dim pricequan As Integer

        secondnum = 0.3


        pricequan = Val(pricetextbox.Text) * Val(quantitytextbox.Text)
        discount = Val(pricetextbox.Text) * secondnum
        quandiscount = discount * Val(quantitytextbox.Text)
        discounttotal = pricequan - quandiscount

        discounttextbox.Text = quandiscount
        discountamttextbox.Text = discounttotal.ToString



    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Me.Close()
    End Sub

    Private Sub wdcradio_CheckedChanged(sender As Object, e As EventArgs) Handles wdcradio.CheckedChanged
        Dim firstnum, secondnum, thirdnum, discount, discounttotal, quandiscount, pricequan, totalquan1 As Decimal


        firstnum = Val(pricetextbox.Text)
        secondnum = 0.1
        thirdnum = Val(quantitytextbox.Text)

        pricequan = firstnum * thirdnum
        discount = firstnum * secondnum
        quandiscount = discount * thirdnum
        discounttotal = pricequan - quandiscount

        discounttextbox.Text = quandiscount
        discountamttextbox.Text = discounttotal





    End Sub

    Private Sub edradio_CheckedChanged(sender As Object, e As EventArgs) Handles edradio.CheckedChanged
        Dim firstnum, secondnum, thirdnum, discount, discounttotal, quandiscount, pricequan, totalquan1 As Decimal


        firstnum = Val(pricetextbox.Text)
        secondnum = 0.15
        thirdnum = Val(quantitytextbox.Text)

        pricequan = firstnum * thirdnum
        discount = firstnum * secondnum
        quandiscount = discount * thirdnum
        discounttotal = pricequan - quandiscount

        discounttextbox.Text = quandiscount
        discountamttextbox.Text = discounttotal




    End Sub

    Private Sub nodiscountradio_CheckedChanged(sender As Object, e As EventArgs) Handles nodiscountradio.CheckedChanged
        Dim firstnum, secondnum, discounttotal, totalquan1 As Decimal

        firstnum = Val(pricetextbox.Text)
        secondnum = Val(quantitytextbox.Text)

        discounttotal = firstnum * secondnum
        discounttextbox.Text = 0.0
        discountamttextbox.Text = discounttotal.ToString



    End Sub

    Private Sub calcbtn_Click(sender As Object, e As EventArgs) Handles calcbtn.Click
        Dim firstnum, secondnum, totalquan1, totaldiscount1, totaldiscountamt1, result As Decimal



        firstnum = discountamttextbox.Text
        secondnum = Val(cashrenderedtext.Text)
        result = secondnum - firstnum

        changetext.Text = result

        totalquan1 = Val(tquantitytextbox.Text)
        tquantitytextbox.Text = Val(quantitytextbox.Text) + totalquan1

        totaldiscount1 = Val(tdiscounttextbox.Text)
        tdiscounttextbox.Text = Val(discounttextbox.Text) + totaldiscount1

        totaldiscountamt1 = Val(tdiscountamttextbox.Text)
        tdiscountamttextbox.Text = Val(discountamttextbox.Text) + totaldiscountamt1



    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "Kingdom Hearts 3"
        nametextbox.Text = itemname
        pricetextbox.Text = 2000
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "Sword Art Online: Lycoris"
        nametextbox.Text = itemname
        pricetextbox.Text = 2300
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "4 Goddesses Online"
        nametextbox.Text = itemname
        pricetextbox.Text = 1600
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "God of War PS4"
        nametextbox.Text = itemname
        pricetextbox.Text = 2000
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "Elder Scrolls 5: Skyrim"
        nametextbox.Text = itemname
        pricetextbox.Text = 1000
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "Yakuza 6"
        nametextbox.Text = itemname
        pricetextbox.Text = 1500
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "Sakura Wars"
        nametextbox.Text = itemname
        pricetextbox.Text = 2500
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "Tales of Berseria"
        nametextbox.Text = itemname
        pricetextbox.Text = 1200
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "Final Fantaasy XIII"
        nametextbox.Text = itemname
        pricetextbox.Text = 1000
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "Sen no Kiseki II: Trails of Cold Steel 2"
        nametextbox.Text = itemname
        pricetextbox.Text = 1700
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "Grand Theft Auto 5"
        nametextbox.Text = itemname
        pricetextbox.Text = 1500
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "Final Fantasy XV"
        nametextbox.Text = itemname
        pricetextbox.Text = 1500
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "Spiderman PS4"
        nametextbox.Text = itemname
        pricetextbox.Text = 2000
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "Shin Megami Tensei: Persona 5 Royal"
        nametextbox.Text = itemname
        pricetextbox.Text = 2500
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "Final Fantasy XIV"
        nametextbox.Text = itemname
        pricetextbox.Text = 1500
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "Atelier Ryza"
        nametextbox.Text = itemname
        pricetextbox.Text = 1400
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "Horizon Zero Dawn"
        nametextbox.Text = itemname
        pricetextbox.Text = 1200
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "Red Dead Redemption 2"
        nametextbox.Text = itemname
        pricetextbox.Text = 2000
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Dim itemname As String
        Dim itemprice As Integer

        itemname = "Megadimension Neptunia VII"
        nametextbox.Text = itemname
        pricetextbox.Text = 1100
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs) Handles Label37.Click

    End Sub

    Private Sub Label53_Click(sender As Object, e As EventArgs) Handles Label53.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub pricetextbox_TextChanged(sender As Object, e As EventArgs) Handles pricetextbox.TextChanged

    End Sub

    Private Sub tquantitytextbox_TextChanged(sender As Object, e As EventArgs) Handles tquantitytextbox.TextChanged
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        Application.Restart()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub

    Private Sub quantitytextbox_TextChanged(sender As Object, e As EventArgs) Handles quantitytextbox.TextChanged
        Try
            Integer.Parse(quantitytextbox.Text)
        Catch ex As Exception
            If quantitytextbox.Text <> "" Then

                MessageBox.Show("Enter a Valid Number")
                quantitytextbox.Clear()
            End If
        End Try
    End Sub

    Private Sub discounttextbox_TextChanged(sender As Object, e As EventArgs) Handles discounttextbox.TextChanged

    End Sub

    Private Sub cashrenderedtext_TextChanged(sender As Object, e As EventArgs) Handles cashrenderedtext.TextChanged
        Try
            Integer.Parse(cashrenderedtext.Text)
        Catch ex As Exception
            If quantitytextbox.Text <> "" Then

                MessageBox.Show("Enter a Valid Number")
                cashrenderedtext.Clear()
            End If
        End Try
    End Sub

    Private Sub cashrenderedtext_Leave(sender As Object, e As EventArgs) Handles cashrenderedtext.Leave

    End Sub
End Class
