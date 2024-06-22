Imports System.Windows.Forms
Imports System.Drawing.Imaging
Imports System.Media
Imports System.Security.Cryptography.X509Certificates
Public Class Form1

    Public rectangles As Rectangle
    Public tick As Integer
    Public score As Integer
    Public s300 As Integer
    Public s100 As Integer
    Public s50 As Integer
    Public misses As Integer
    Public combo As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'make some music play

    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        btnPlay.Visible = True
        btnQuit.Visible = True
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
