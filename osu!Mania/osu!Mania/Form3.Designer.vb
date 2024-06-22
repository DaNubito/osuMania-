<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        tile2 = New PictureBox()
        tile3 = New PictureBox()
        tile1 = New PictureBox()
        tile4 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        tmrGame_Tick = New Timer(components)
        accuracy = New Label()
        score = New Label()
        combos = New Label()
        collide1 = New PictureBox()
        collide2 = New PictureBox()
        collide3 = New PictureBox()
        collide4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        CType(tile2, ComponentModel.ISupportInitialize).BeginInit()
        CType(tile3, ComponentModel.ISupportInitialize).BeginInit()
        CType(tile1, ComponentModel.ISupportInitialize).BeginInit()
        CType(tile4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(collide1, ComponentModel.ISupportInitialize).BeginInit()
        CType(collide2, ComponentModel.ISupportInitialize).BeginInit()
        CType(collide3, ComponentModel.ISupportInitialize).BeginInit()
        CType(collide4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tile2
        ' 
        tile2.Image = My.Resources.Resources.blue0517_4dfc85cb0200460ab717b101ac07888f
        tile2.Location = New Point(360, 55)
        tile2.Name = "tile2"
        tile2.Size = New Size(100, 30)
        tile2.TabIndex = 0
        tile2.TabStop = False
        ' 
        ' tile3
        ' 
        tile3.Image = My.Resources.Resources.images__1_
        tile3.Location = New Point(466, 55)
        tile3.Name = "tile3"
        tile3.Size = New Size(100, 30)
        tile3.TabIndex = 1
        tile3.TabStop = False
        ' 
        ' tile1
        ' 
        tile1.Image = My.Resources.Resources._360_F_146911624_MpozeTIQOoTUUURHWbhFc3Gleql65npI
        tile1.Location = New Point(252, 55)
        tile1.Name = "tile1"
        tile1.Size = New Size(100, 30)
        tile1.TabIndex = 2
        tile1.TabStop = False
        ' 
        ' tile4
        ' 
        tile4.Image = My.Resources.Resources.plain_black_background_02fh7564l8qq4m6d
        tile4.Location = New Point(572, 55)
        tile4.Name = "tile4"
        tile4.Size = New Size(100, 30)
        tile4.TabIndex = 3
        tile4.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(11, 50)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources._6257_Dark_Grey_Metallic_2
        PictureBox2.Location = New Point(560, 55)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(15, 726)
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources._6257_Dark_Grey_Metallic_2
        PictureBox3.Location = New Point(455, 55)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(15, 726)
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = My.Resources.Resources._6257_Dark_Grey_Metallic_2
        PictureBox4.Location = New Point(349, 55)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(15, 726)
        PictureBox4.TabIndex = 8
        PictureBox4.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackgroundImage = My.Resources.Resources._6257_Dark_Grey_Metallic_2
        PictureBox6.Location = New Point(667, 55)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(15, 759)
        PictureBox6.TabIndex = 9
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackgroundImage = My.Resources.Resources._6257_Dark_Grey_Metallic_2
        PictureBox7.Location = New Point(240, 55)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(15, 759)
        PictureBox7.TabIndex = 10
        PictureBox7.TabStop = False
        ' 
        ' tmrGame_Tick
        ' 
        ' 
        ' accuracy
        ' 
        accuracy.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        accuracy.Location = New Point(1327, 65)
        accuracy.Name = "accuracy"
        accuracy.Size = New Size(107, 35)
        accuracy.TabIndex = 11
        accuracy.Text = "00.00%"
        ' 
        ' score
        ' 
        score.Font = New Font("Calibri", 40F, FontStyle.Bold)
        score.Location = New Point(1261, 0)
        score.Name = "score"
        score.Size = New Size(190, 56)
        score.TabIndex = 12
        score.Text = "000000"
        ' 
        ' combos
        ' 
        combos.Font = New Font("Calibri", 42F, FontStyle.Bold Or FontStyle.Italic)
        combos.Location = New Point(700, 738)
        combos.Name = "combos"
        combos.Size = New Size(187, 75)
        combos.TabIndex = 13
        combos.Text = "0"
        ' 
        ' collide1
        ' 
        collide1.Image = My.Resources.Resources.plain_black_background_02fh7564l8qq4m6d
        collide1.Location = New Point(252, 783)
        collide1.Name = "collide1"
        collide1.Size = New Size(100, 30)
        collide1.TabIndex = 14
        collide1.TabStop = False
        ' 
        ' collide2
        ' 
        collide2.Image = My.Resources.Resources.plain_black_background_02fh7564l8qq4m6d
        collide2.Location = New Point(360, 783)
        collide2.Name = "collide2"
        collide2.Size = New Size(100, 30)
        collide2.TabIndex = 15
        collide2.TabStop = False
        ' 
        ' collide3
        ' 
        collide3.Image = My.Resources.Resources.plain_black_background_02fh7564l8qq4m6d
        collide3.Location = New Point(466, 783)
        collide3.Name = "collide3"
        collide3.Size = New Size(100, 30)
        collide3.TabIndex = 16
        collide3.TabStop = False
        ' 
        ' collide4
        ' 
        collide4.Image = My.Resources.Resources.plain_black_background_02fh7564l8qq4m6d
        collide4.Location = New Point(572, 783)
        collide4.Name = "collide4"
        collide4.Size = New Size(100, 30)
        collide4.TabIndex = 17
        collide4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.plain_black_background_02fh7564l8qq4m6d
        PictureBox5.Location = New Point(347, 783)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(17, 30)
        PictureBox5.TabIndex = 18
        PictureBox5.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.plain_black_background_02fh7564l8qq4m6d
        PictureBox8.Location = New Point(455, 783)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(17, 30)
        PictureBox8.TabIndex = 19
        PictureBox8.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Image = My.Resources.Resources.plain_black_background_02fh7564l8qq4m6d
        PictureBox9.Location = New Point(560, 783)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(17, 30)
        PictureBox9.TabIndex = 20
        PictureBox9.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(1672, 984)
        Controls.Add(PictureBox9)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox5)
        Controls.Add(collide4)
        Controls.Add(collide3)
        Controls.Add(collide2)
        Controls.Add(collide1)
        Controls.Add(combos)
        Controls.Add(score)
        Controls.Add(accuracy)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(tile4)
        Controls.Add(tile1)
        Controls.Add(tile3)
        Controls.Add(tile2)
        Name = "Form3"
        Text = "Form3"
        CType(tile2, ComponentModel.ISupportInitialize).EndInit()
        CType(tile3, ComponentModel.ISupportInitialize).EndInit()
        CType(tile1, ComponentModel.ISupportInitialize).EndInit()
        CType(tile4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(collide1, ComponentModel.ISupportInitialize).EndInit()
        CType(collide2, ComponentModel.ISupportInitialize).EndInit()
        CType(collide3, ComponentModel.ISupportInitialize).EndInit()
        CType(collide4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tile2 As PictureBox
    Friend WithEvents tile3 As PictureBox
    Friend WithEvents tile1 As PictureBox
    Friend WithEvents tile4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents tmrGame_Tick As Timer
    Friend WithEvents accuracy As Label
    Friend WithEvents score As Label
    Friend WithEvents combos As Label
    Friend WithEvents collide1 As PictureBox
    Friend WithEvents collide2 As PictureBox
    Friend WithEvents collide3 As PictureBox
    Friend WithEvents collide4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
End Class
