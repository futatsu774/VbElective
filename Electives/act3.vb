Public Class act3
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = 2

        grp3honorarium.Enabled = False
        grp4otherincome.Enabled = False
        grp2income_cutoff.Enabled = False
        gross_income.Enabled = False
        totaldeduction.Enabled = False



    End Sub

    Private Sub grp2cutoff_TextChanged(sender As Object, e As EventArgs) Handles grp2cutoff.Leave
        Dim firstnum, secondnum As Integer
        Dim result As Decimal

        firstnum = Val(grp2rate.Text)
        secondnum = Val(grp2cutoff.Text)

        result = firstnum / secondnum
        grp2income_cutoff.Text = result.ToString("N")


    End Sub

    Private Sub grp3cutoff_TextChanged(sender As Object, e As EventArgs) Handles grp3cutoff.TextChanged
        Dim firstnum, secondnum As Integer

        firstnum = Val(grp3rate.Text)
        secondnum = Val(grp3cutoff.Text)

        grp3honorarium.Text = (firstnum / secondnum).ToString("N")
    End Sub

    Private Sub grp4cutoff_TextChanged(sender As Object, e As EventArgs) Handles grp4cutoff.TextChanged
        Dim firstnum, secondnum As Integer
        Dim resultgrossincome As Decimal


        firstnum = Val(grp4rate.Text)
        secondnum = Val(grp4cutoff.Text)






        grp4otherincome.Text = (firstnum / secondnum).ToString("N")

        resultgrossincome = Val(grp2income_cutoff.Text) + Val(grp3honorarium.Text) + Val(grp4otherincome.Text)
        gross_income.Text = resultgrossincome.ToString("N")



    End Sub

    Public Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub


    Private Sub newform_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newform.Click
        ClearTextBox(Me)
        gross_income.Clear()
        grp2income_cutoff.Clear()
        grp3honorarium.Clear()
        grp4otherincome.Clear()
        ListBox1.Items.Clear()

        If (String.IsNullOrEmpty(sss_contribution.Text)) Then

            sss_contribution.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(philhealth_contribution.Text)) Then

            philhealth_contribution.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(pagibig_contribution.Text)) Then

            pagibig_contribution.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(tax_textbox.Text)) Then

            tax_textbox.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(sss_loan.Text)) Then

            sss_loan.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(pagibig_loan.Text)) Then

            pagibig_loan.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(family_deposit.Text)) Then

            family_deposit.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(family_loan.Text)) Then

            family_loan.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(sss_contribution.Text)) Then

            sss_contribution.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(salary_loan.Text)) Then

            salary_loan.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(others_textbox.Text)) Then

            others_textbox.Text = "0.00"
        End If

    End Sub





    Private Sub grp4otherincome_TextChanged(sender As Object, e As EventArgs) Handles grp4otherincome.TextChanged

    End Sub

    Private Sub sss_contribution_TextChanged(sender As Object, e As EventArgs) Handles sss_contribution.Click
        sss_contribution.Text = String.Empty


    End Sub



    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub


    Private Sub philhealth_contribution_TextChanged(sender As Object, e As EventArgs) Handles philhealth_contribution.Click
        philhealth_contribution.Text = String.Empty
    End Sub

    Private Sub pagibig_contribution_TextChanged(sender As Object, e As EventArgs) Handles pagibig_contribution.Click
        pagibig_contribution.Text = String.Empty
    End Sub

    Private Sub tax_textbox_TextChanged(sender As Object, e As EventArgs) Handles tax_textbox.Click
        tax_textbox.Text = String.Empty
    End Sub

    Private Sub sss_loan_TextChanged(sender As Object, e As EventArgs) Handles sss_loan.Click
        sss_loan.Text = String.Empty
    End Sub

    Private Sub pagibig_loan_TextChanged(sender As Object, e As EventArgs) Handles pagibig_loan.Click
        pagibig_loan.Text = String.Empty
    End Sub

    Private Sub family_deposit_TextChanged(sender As Object, e As EventArgs) Handles family_deposit.Click
        family_deposit.Text = String.Empty
    End Sub

    Private Sub family_loan_TextChanged(sender As Object, e As EventArgs) Handles family_loan.Click
        family_loan.Text = String.Empty
    End Sub

    Private Sub salary_loan_TextChanged(sender As Object, e As EventArgs) Handles salary_loan.Click
        salary_loan.Text = String.Empty
    End Sub

    Private Sub others_textbox_TextChanged(sender As Object, e As EventArgs) Handles others_textbox.Click
        others_textbox.Text = String.Empty
    End Sub

    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim first, second, third, fourth, fifth, sixth, seventh, eight, ninth, tenth As Decimal
        first = Decimal.Parse(sss_contribution.Text)
        second = Decimal.Parse(pagibig_contribution.Text)
        third = Decimal.Parse(philhealth_contribution.Text)
        fourth = Decimal.Parse(sss_loan.Text)
        fifth = Decimal.Parse(pagibig_loan.Text)
        sixth = Decimal.Parse(family_deposit.Text)
        seventh = Decimal.Parse(family_loan.Text)
        eight = Decimal.Parse(tax_textbox.Text)
        ninth = Decimal.Parse(salary_loan.Text)
        tenth = Decimal.Parse(others_textbox.Text)


        totaldeduction.Text = (first + second + third + fourth + fifth + sixth + seventh + eight + ninth + tenth).ToString("N")

        Dim grossincome As Decimal = Decimal.Parse(gross_income.Text)
        Dim totaldeduc As Decimal = Decimal.Parse(totaldeduction.Text)

        net_income.Text = (grossincome - totaldeduc).ToString("N")

    End Sub

    Private Sub terminate_Click(sender As Object, e As EventArgs) Handles terminate.Click
        Me.Close()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ListBox1.Items.Add("Employee Number: " + employee_number.Text)
        ListBox1.Items.Add("Name: " + firstname.Text + " " + middlename.Text + " " + surname.Text)
        ListBox1.Items.Add("Pay Date: " + paydate.Value)
        ListBox1.Items.Add("Income Per Cutoff: PHP" + grp2income_cutoff.Text)
        ListBox1.Items.Add("Honorarium: PHP" + grp3honorarium.Text)
        ListBox1.Items.Add("Total Other Income Pay: PHP" + grp4otherincome.Text)
        ListBox1.Items.Add("SSS Contribution: PHP" + sss_contribution.Text)
        ListBox1.Items.Add("Pagibig Contribution: PHP"+ pagibig_contribution.Text)
        ListBox1.Items.Add("PhilHealth Contribution: PHP"+philhealth_contribution.Text)
        ListBox1.Items.Add("TAX: PHP"+tax_textbox.Text)
        ListBox1.Items.Add("SSS Loan: PHP" + sss_loan.Text)
        ListBox1.Items.Add("Pagibig Loan: PHP" + pagibig_loan.Text)
        ListBox1.Items.Add("Faculty Savings Deposit: PHP" + family_deposit.Text)
        ListBox1.Items.Add("Faculty Savings Loan: PHP" + family_loan.Text)
        ListBox1.Items.Add("Salary Loan: PHP" + salary_loan.Text)
        ListBox1.Items.Add("Other Deductions: PHP" + others_textbox.Text)
        ListBox1.Items.Add("Gross Income: PHP" + gross_income.Text)
        ListBox1.Items.Add("Total Deductions PHP" + totaldeduction.Text)
        ListBox1.Items.Add("Net Income: PHP" + net_income.Text)




    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles printpayslip.Click
        PayslipFrm.Visible = True
        'PayslipFrm.recieptpayslip.Text = Me.pagibig_loan.Text

        PayslipFrm.name2.Text = Me.firstname.Text + " " + Me.middlename.Text + " " + Me.surname.Text
        PayslipFrm.employeenum2.Text = Me.employee_number.Text
        PayslipFrm.paydate2.Text = Me.paydate.Value
        PayslipFrm.income2.Text = Me.grp2income_cutoff.Text
        PayslipFrm.honor2.Text = Me.grp3honorarium.Text
        PayslipFrm.totalotherincome2.Text = Me.grp4otherincome.Text
        PayslipFrm.ssscontrib2.Text = Me.sss_contribution.Text
        PayslipFrm.pagibigcontrib2.Text = Me.pagibig_contribution.Text
        PayslipFrm.philhealth2.Text = Me.philhealth_contribution.Text
        PayslipFrm.sssloan2.Text = Me.sss_loan.Text
        PayslipFrm.pagibigloan2.Text = Me.pagibig_loan.Text
        PayslipFrm.fsd2.Text = Me.family_deposit.Text
        PayslipFrm.fsl2.Text = Me.family_loan.Text
        PayslipFrm.salaryloan2.Text = Me.salary_loan.Text
        PayslipFrm.otherdeduction2.Text = Me.others_textbox.Text
        PayslipFrm.grossincome2.Text = Me.gross_income.Text
        PayslipFrm.totaldeduction2.Text = Me.totaldeduction.Text
        PayslipFrm.netincome2.Text = Me.net_income.Text
        PayslipFrm.tax2.Text = Me.tax_textbox.Text
        PayslipFrm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles cancel.Click
        ClearTextBox(Me)
        gross_income.Clear()
        grp2income_cutoff.Clear()
        grp3honorarium.Clear()
        grp4otherincome.Clear()
        ListBox1.Items.Clear()

        If (String.IsNullOrEmpty(sss_contribution.Text)) Then

            sss_contribution.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(philhealth_contribution.Text)) Then

            philhealth_contribution.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(pagibig_contribution.Text)) Then

            pagibig_contribution.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(tax_textbox.Text)) Then

            tax_textbox.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(sss_loan.Text)) Then

            sss_loan.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(pagibig_loan.Text)) Then

            pagibig_loan.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(family_deposit.Text)) Then

            family_deposit.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(family_loan.Text)) Then

            family_loan.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(sss_contribution.Text)) Then

            sss_contribution.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(salary_loan.Text)) Then

            salary_loan.Text = "0.00"
        End If

        If (String.IsNullOrEmpty(others_textbox.Text)) Then

            others_textbox.Text = "0.00"
        End If

    End Sub
End Class
