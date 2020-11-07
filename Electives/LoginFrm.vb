Public Class LoginFrm
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim user As String
        Dim pass As String

        user = usernametxt.Text
        pass = passwordtxt.Text

        If user = "administrator" And pass = "administrator" Then

            Dim main As New MainWindow
            MessageBox.Show("Welcome Admin")
            Me.Hide()
            main.Show()


        ElseIf user = "cashier1" And pass = "cashier1" Then
            Dim act2 As New act1
            MessageBox.Show("Welcome Cashier Point of Sale Page!!!")
            act2.Show()
            Me.Hide()

        ElseIf user = "cashier2" And pass = "cashier2" Then
            Dim act4 As New act4
            MessageBox.Show("Welcome to Cashier Ordering POS Page!!!")
            act4.Show()
            Me.Hide()

        ElseIf user = "accountingstaff" And pass = "accountingstaff" Then
            Dim act3 As New act3
            MessageBox.Show("Welcome to Payroll Page!!!")
            act3.Show()
            Me.Hide()

        Else
            MessageBox.Show("Invalid Username or Password")

        End If

    End Sub
    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Dim user As String
        Dim pass As String

        user = String.Empty
        pass = String.Empty


    End Sub

    Private Sub LoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
