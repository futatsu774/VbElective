Public Class act1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = 2
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim price1 As Decimal = 2000
        Const item1 As String = "Resident Evil 7"
        item_name.Text = item1
        price.Text = price1



    End Sub



    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles amountpay.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles cashremain.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Dim price2 As Decimal = 2000
        Const item2 As String = "re7"
        item_name.Text = item2
        price.Text = price2
    End Sub

    Private Sub quantity_TextChanged(sender As Object, e As EventArgs) Handles quantity.TextChanged
        Dim product, firstnumber, secondnumber As Decimal
        Try
            Integer.Parse(quantity.Text)
        Catch ex As Exception
            If quantity.Text <> "" Then
                MessageBox.Show("Enter a Valid Number")
                quantity.Clear()

            End If
        End Try

        firstnumber = Integer.Parse(price.Text)

        product = firstnumber * Val(quantity.Text)
        amountpay.Text = product.ToString






    End Sub

    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim amount, cash, difference As Integer

        amount = Integer.Parse(amountpay.Text)
        cash = Integer.Parse(cashgiven.Text)
        difference = cash - amount
        cashremain.Text = difference
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim price1 As Decimal = 2700
        Const item1 As String = "Sword Art Online: Lycoris"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim price1 As Decimal = 1000
        Const item1 As String = "Elder Scrolls 5: Skyrim"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim price1 As Decimal = 1500
        Const item1 As String = "Yakuza 6"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim price1 As Decimal = 2700
        Const item1 As String = "Sakura Wars PS4"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Dim price1 As Decimal = 2000
        Const item1 As String = "Marvel's Spiderman"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim price1 As Decimal = 1500
        Const item1 As String = "Hyper Dimension Neptunia: 4 Goddesses Online"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim price1 As Decimal = 1700
        Const item1 As String = "God Of War PS4"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim price1 As Decimal = 1200
        Const item1 As String = "Tales of Berseria"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim price1 As Decimal = 1000
        Const item1 As String = "Final Fantasy XIII"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Dim price1 As Decimal = 2000
        Const item1 As String = "Red Dead Redemption 2"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Dim price1 As Decimal = 1700
        Const item1 As String = "Sen no Kiseki: Trails of Cold Steel 2"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Dim price1 As Decimal = 1000
        Const item1 As String = "GTA V"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Dim price1 As Decimal = 1500
        Const item1 As String = "Final Fantasy XV"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Dim price1 As Decimal = 2800
        Const item1 As String = "Final Fantasy XIV"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Dim price1 As Decimal = 1600
        Const item1 As String = "Atelier Ryza"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Dim price1 As Decimal = 1500
        Const item1 As String = "Horizon Zero Dawn"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Dim price1 As Decimal = 2000
        Const item1 As String = "Kingdom Hearts 3"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Dim price1 As Decimal = 2000
        Const item1 As String = "Persona 5 Royal"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Dim price1 As Decimal = 1200
        Const item1 As String = "Megadimension Neptunia VII"
        item_name.Text = item1
        price.Text = price1
    End Sub

    Private Sub price_TextChanged(sender As Object, e As EventArgs) Handles price.TextChanged

    End Sub

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        Application.Restart()
    End Sub

    Private Sub cashgiven_TextChanged(sender As Object, e As EventArgs) Handles cashgiven.TextChanged
        Dim cash As Decimal
        Try
            cash = cashgiven.Text
        Catch ex As Exception
            MessageBox.Show("Enter a Valid Number")
            cashgiven.Clear()


        End Try
    End Sub

    Private Sub item_name_TextChanged(sender As Object, e As EventArgs) Handles item_name.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
