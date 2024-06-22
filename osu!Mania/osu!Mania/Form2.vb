Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnPlay1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub BubbleGum_Click(sender As Object, e As EventArgs) Handles BubbleGum.Click
        btnPlay1.Visible = False
        btnPlay2.Visible = True
        picCuteDepressed.Visible = False
        picBubbleGum.Visible = True
    End Sub

    Private Sub CuteDepressed_Click(sender As Object, e As EventArgs) Handles CuteDepressed.Click
        btnPlay1.Visible = True
        btnPlay2.Visible = False
        picCuteDepressed.Visible = True
        picBubbleGum.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnPlay2.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub picBubbleGum_Click(sender As Object, e As EventArgs) Handles picBubbleGum.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub picCuteDepressed_Click(sender As Object, e As EventArgs) Handles picCuteDepressed.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class