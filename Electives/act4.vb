Public Class act4
    Private Sub FBAradio_CheckedChanged(sender As Object, e As EventArgs) Handles Aradio.CheckedChanged
        ListBox1.Items.Add("Console Bundle A" + "    " + "PHP 20000")
        Receipt.recieptbox.Items.Add("Console Bundle A" + "    " + "PHP 20000")

        Dim pricedis1 As Decimal
        Pricetbox.Text = Decimal.Parse(20000)
        pricedis1 = Val(Pricetbox.Text) * 0.05
        discountamt.Text = pricedis1.ToString

        If totalbills.Text & totalquantity.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)

            discountamt2.Text = Decimal.Parse(0.00)

        End If

        choice1A.Checked = True
        choice2a.Checked = True
        choice3a.Checked = True
        choice4a.Checked = True
        choice5a.Checked = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = 2
        Pricetbox.Enabled = False
        discountamt.Enabled = False
        discountamt2.Enabled = False
        changetbox.Enabled = False
        totalbills.Enabled = False
        totalquantity.Enabled = False

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ListBox1.Items.Add("RE 7" + "    " + "PHP 2000")
        Receipt.recieptbox.Items.Add("RE 7" + "    " + "PHP 2000")
        Pricetbox.Text = Decimal.Parse(2000)


        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If




    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        ListBox1.Items.Add("SAO Lycoris" + "    " + "PHP 2300")
        Receipt.recieptbox.Items.Add("SAO Lycoris" + "    " + "PHP 2300")
        Pricetbox.Text = Decimal.Parse(2300)



        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If



    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        ListBox1.Items.Add("4 Goddesses Online" + "    " + "PHP 1600")
        Receipt.recieptbox.Items.Add("4 Goddesses Online" + "    " + "PHP 1600")
        Pricetbox.Text = Decimal.Parse(1600)


        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If
    End Sub

    Private Sub Quantitytbox_TextChanged(sender As Object, e As EventArgs) Handles Quantitytbox.TextChanged
        Dim result, quan As Integer

        Dim bills, pricedis1, result2 As Decimal

        bills = totalbills.Text

        Try
            Integer.Parse(Quantitytbox.Text)
        Catch ex As Exception
            If Quantitytbox.Text <> "" Then

                MessageBox.Show("Enter a Valid Number")
                Quantitytbox.Clear()
            End If



        End Try

        If Aradio.Checked = True Or Bradio.Checked = True Then

            discountamt2.Text = discountamt.Text * Val(Quantitytbox.Text)
            result2 = Val(Pricetbox.Text) * Val(Quantitytbox.Text)
            result = result2 - Val(discountamt2.Text)
            totalbills.Text = result
        Else

            result = Val(Pricetbox.Text) * Val(Quantitytbox.Text)
            totalbills.Text = result
        End If

        If totalbills.Text = 0 Then
            totalbills.Text = result
        Else
            totalbills.Text = result + bills
        End If

        quan = Val(totalquantity.Text)
        totalquantity.Text = Val(Quantitytbox.Text) + quan

    End Sub

    Private Sub terminate_Click(sender As Object, e As EventArgs) Handles terminate.Click
        Me.Close()
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        For Each cc As Control In Me.Controls
            If TypeOf cc Is CheckBox Then
                DirectCast(cc, CheckBox).Checked = False
            End If
        Next

        Aradio.Checked = False
        Bradio.Checked = False

        ListBox1.Items.Clear()
        discountamt.Clear()
        discountamt2.Clear()
        Pricetbox.Clear()
        Quantitytbox.Clear()
        totalbills.Clear()
        totalquantity.Clear()
        changetbox.Clear()
        cashgiven.Clear()

        choice1A.Checked = False
        choice2a.Checked = False
        choice3a.Checked = False
        choice4a.Checked = False
        choice5a.Checked = False

        choice1b.Checked = False
        choice2b.Checked = False
        choice3b.Checked = False
        choice4b.Checked = False
        choice5b.Checked = False

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        ListBox1.Items.Add("God Of War" + "    " + "PHP 2000")
        Receipt.recieptbox.Items.Add("God Of War" + "    " + "PHP 2000")
        Pricetbox.Text = Decimal.Parse(2000)



        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        ListBox1.Items.Add("Skyrim" + "    " + "PHP 1000")
        Receipt.recieptbox.Items.Add("Skyrim" + "    " + "PHP 1000")
        Pricetbox.Text = Decimal.Parse(1000)




        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        ListBox1.Items.Add("Yakuza 6" + "    " + "PHP 1600")
        Receipt.recieptbox.Items.Add("Yakuza 6" + "    " + "PHP 1600")
        Pricetbox.Text = Decimal.Parse(1600)

        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        ListBox1.Items.Add("Neptunia VII" + "    " + "PHP 1300")
        Receipt.recieptbox.Items.Add("Neptunia VII" + "    " + "PHP 1300")
        Pricetbox.Text = Decimal.Parse(1300)


        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If


        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        ListBox1.Items.Add("Sakura Wars" + "    " + "PHP 2500")
        Receipt.recieptbox.Items.Add("Sakura Wars" + "    " + "PHP 2500")
        Pricetbox.Text = Decimal.Parse(2500)



        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        ListBox1.Items.Add("Tales Of Berseria" + "    " + "PHP 1200")
        Receipt.recieptbox.Items.Add("Tales Of Berseria" + "    " + "PHP 1200")
        Pricetbox.Text = Decimal.Parse(1200)



        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        ListBox1.Items.Add("Final Fantasy XIII" + "    " + "PHP 1000")
        Receipt.recieptbox.Items.Add("Final Fantasy XIII" + "    " + "PHP 1000")

        Pricetbox.Text = Decimal.Parse(1000)



        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        ListBox1.Items.Add("Sen no Kiseki 2" + "    " + "PHP 1700")
        Receipt.recieptbox.Items.Add("Sen no Kiseki 2" + "    " + "PHP 1700")
        Pricetbox.Text = Decimal.Parse(1700)



        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        ListBox1.Items.Add("GTA V" + "    " + "PHP 1500")
        Receipt.recieptbox.Items.Add("GTA V" + "    " + "PHP 1500")
        Pricetbox.Text = Decimal.Parse(1500)



        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        ListBox1.Items.Add("Final Fantasy XV" + "    " + "PHP 2000")
        Receipt.recieptbox.Items.Add("Final Fantasy XV" + "    " + "PHP 2000")
        Pricetbox.Text = Decimal.Parse(2000)



        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        ListBox1.Items.Add("Red Dead Redemption 2" + "    " + "PHP 2300")
        Receipt.recieptbox.Items.Add("Red Dead Redemption 2" + "    " + "PHP 2300")
        Pricetbox.Text = Decimal.Parse(2300)



        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If
    End Sub

    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged
        ListBox1.Items.Add("Marvel's Spiderman" + "    " + "PHP 2000")
        Receipt.recieptbox.Items.Add("Marvel's Spiderman" + "    " + "PHP 2000")
        Pricetbox.Text = Decimal.Parse(2000)



        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If
    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged
        ListBox1.Items.Add("Persona 5 Royal" + "    " + "PHP 2500")
        Receipt.recieptbox.Items.Add("Persona 5 Royal" + "    " + "PHP 2500")
        Pricetbox.Text = Decimal.Parse(2500)



        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged
        ListBox1.Items.Add("Final Fantasy XIV" + "    " + "PHP 1400")
        Receipt.recieptbox.Items.Add("Final Fantasy XIV" + "    " + "PHP 1400")
        Pricetbox.Text = Decimal.Parse(1400)



        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
        ListBox1.Items.Add("Atelier Ryza" + "    " + "PHP 1600")
        Receipt.recieptbox.Items.Add("Atelier Ryza" + "    " + "PHP 1600")
        Pricetbox.Text = Decimal.Parse(1600)



        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        ListBox1.Items.Add("Horizon Zero Dawn" + "    " + "PHP 1300")
        Receipt.recieptbox.Items.Add("Horizon Zero Dawn" + "    " + "PHP 1300")
        Pricetbox.Text = Decimal.Parse(1300)



        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        ListBox1.Items.Add("Kingdom Hearts 3" + "    " + "PHP 2000")
        Receipt.recieptbox.Items.Add("Kingdom Hearts 3" + "    " + "PHP 2000")
        Pricetbox.Text = Decimal.Parse(2000)



        If totalbills.Text & totalquantity.Text & discountamt.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)
            discountamt.Text = Decimal.Parse(0.00)
            discountamt2.Text = Decimal.Parse(0.00)

        End If

        If discountamt.Text <> 0 Then
            discountamt.Text = Decimal.Parse(0)
            discountamt2.Text = Decimal.Parse(0)
        End If
    End Sub

    Private Sub Bradio_CheckedChanged(sender As Object, e As EventArgs) Handles Bradio.CheckedChanged
        ListBox1.Items.Add("Console Bundle B" + "    " + "PHP 18000")
        Receipt.recieptbox.Items.Add("Console Bundle B" + "    " + "PHP 18000")

        Dim pricedis1 As Decimal
        Pricetbox.Text = Decimal.Parse(18000)
        pricedis1 = Val(Pricetbox.Text) * 0.05
        discountamt.Text = pricedis1.ToString

        If totalbills.Text & totalquantity.Text & discountamt2.Text = "" Then
            totalbills.Text = Decimal.Parse(0.00)
            totalquantity.Text = Decimal.Parse(0.00)

            discountamt2.Text = Decimal.Parse(0.00)

        End If

        choice1b.Checked = True
        choice2b.Checked = True
        choice3b.Checked = True
        choice4b.Checked = True
        choice5b.Checked = True
    End Sub

    Private Sub CalcChangebtn_Click(sender As Object, e As EventArgs) Handles CalcChangebtn.Click
        changetbox.Text = Val(cashgiven.Text) - Val(totalbills.Text)


        ListBox1.Items.Add("")
        ListBox1.Items.Add("Total Bills" + "     " + "PHP:" + totalbills.Text)
        ListBox1.Items.Add("Cash Given:" + "     " + "PHP:" + cashgiven.Text)
        ListBox1.Items.Add("Change:" + "     " + "PHP:" + changetbox.Text)

    End Sub

    Private Sub changetbox_TextChanged(sender As Object, e As EventArgs) Handles changetbox.TextChanged

    End Sub

    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click
        Receipt.Show()

        Receipt.recieptbox.Items.Add("")
        Receipt.recieptbox.Items.Add("Total Bills" + "     " + "PHP:" + totalbills.Text)
        Receipt.recieptbox.Items.Add("Cash Given:" + "     " + "PHP:" + cashgiven.Text)
        Receipt.recieptbox.Items.Add("Change:" + "     " + "PHP:" + changetbox.Text)

    End Sub

    Private Sub Quantitytbox_Leave(sender As Object, e As EventArgs) Handles Quantitytbox.Leave


    End Sub

    Private Sub cashgiven_TextChanged(sender As Object, e As EventArgs) Handles cashgiven.TextChanged

        Try
            Integer.Parse(cashgiven.Text)
        Catch ex As Exception
            If cashgiven.Text <> "" Then

                MessageBox.Show("Enter a Valid Number")
                cashgiven.Clear()
            End If



        End Try
    End Sub
End Class
