Public Class MainWindow
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = 2
    End Sub

    Private Sub activity1_Click(sender As Object, e As EventArgs) Handles activity1.Click
        Dim act1 As New act1
        act1.MdiParent = Me
        act1.Show()


    End Sub

    Private Sub activity2_Click(sender As Object, e As EventArgs) Handles activity2.Click
        Dim act2 As New act3
        act2.MdiParent = Me
        act2.Show()

    End Sub

    Private Sub activity4_Click(sender As Object, e As EventArgs) Handles activity4.Click
        Dim act4 As New act4
        act4.MdiParent = Me
        act4.Show()

    End Sub

    Private Sub accountingstaff_Click(sender As Object, e As EventArgs) Handles accountingstaff.Click
        Dim act4 As New act4
        act4.MdiParent = Me
        act4.Show()
    End Sub

    Private Sub horizontal_Click(sender As Object, e As EventArgs) Handles horizontal.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal)
    End Sub

    Private Sub cascade_Click(sender As Object, e As EventArgs) Handles cascade.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
    End Sub

    Private Sub vertical_Click(sender As Object, e As EventArgs) Handles vertical.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical)
    End Sub
End Class
