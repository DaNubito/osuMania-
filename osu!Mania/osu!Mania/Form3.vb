Imports System.Windows.Forms
Imports System.Drawing.Imaging
Imports System.Media
Imports System.Security.Cryptography.X509Certificates

Public Class Form3
    Public rectangles(-1) As Rectangle
    Public tick As Integer
    Public scores As Integer
    Public s300 As Integer
    Public s100 As Integer
    Public s50 As Integer
    Public misses As Integer
    Public combo As Integer = 0

    Dim rectanglecount As Integer
    Dim inputhit As Boolean


    Private Function Collide(ByVal ObjA As Object, ByVal ObjB As Object) As Boolean
            If ObjA.bounds.intersectswith(ObjB.bounds) Then
                Collide = True
            Else
                Collide = False

            End If
        End Function

        Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles tile4.Click

        End Sub

        Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        End Sub

        Private Sub tile3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tile3.KeyPress
            If Asc(e.KeyChar) > 1 Then

            End If
        End Sub

        Private Sub tile2_Click(sender As Object, e As EventArgs) Handles tile2.Click

        End Sub

        Private Sub Label1_Click(sender As Object, e As EventArgs) Handles accuracy.Click

        End Sub

        Private Sub percentage_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrGame_Tick.Tick
            tick += 1
            accuracy = Math.Ceiling((((300 * s300) + (100 * s100) + (50 * s50)) / (300 * (s300 + s100 + s50 + misses)) * 100) * 100D / 100D)
            combos.Text = combo.ToString + " x"
            score.Text = score.ToString("D8")
            accuracy.Text = accuracy.ToString + "%"
        End Sub
        Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
            If Collide(tile1, collide1) Then
                If e.KeyCode = Keys.D Then
                    If picPlayer1.Top > 2 Then
                        picPlayer1.Top = picPlayer1.Top - 20
                    End If
                End If
            End If
            If Collide(tile2, collide2) Then
                If e.KeyCode = Keys.F Then
                    If picPlayer1.Top > 20 Then
                        picPlayer1.Top = picPlayer1.Top - 20
                    End If
                End If
                If Collide(tile3, collide3) Then
                    If e.KeyCode = Keys.J Then
                        If picPlayer1.Top > 20 Then
                            picPlayer1.Top = picPlayer1.Top - 20
                        End If
                    End If
                    If Collide(tile4, collide4) Then
                        If e.KeyCode = Keys.K Then
                            If picPlayer1.Top > 20 Then
                                picPlayer1.Top = picPlayer1.Top - 20
                            End If
                        End If
    End Sub

        Private Sub collide1_Click(sender As Object, e As EventArgs) Handles collide1.Click

        End Sub

        Private Sub collide2_Click(sender As Object, e As EventArgs) Handles collide2.Click

        End Sub

        Private Sub collide3_Click(sender As Object, e As EventArgs) Handles collide3.Click

        End Sub

        Private Sub collide4_Click(sender As Object, e As EventArgs) Handles collide4.Click

        End Sub
    End Class