<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        CuteDepressed = New Button()
        BubbleGum = New Button()
        btnPlay1 = New Button()
        btnPlay2 = New Button()
        picCuteDepressed = New PictureBox()
        lblSong1 = New Label()
        diffName1 = New Label()
        blSong2 = New Label()
        diffName2 = New Label()
        picBubbleGum = New PictureBox()
        CType(picCuteDepressed, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBubbleGum, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CuteDepressed
        ' 
        CuteDepressed.BackColor = SystemColors.ControlDark
        CuteDepressed.Font = New Font("Arial", 18F, FontStyle.Bold)
        CuteDepressed.Location = New Point(257, 152)
        CuteDepressed.Name = "CuteDepressed"
        CuteDepressed.Size = New Size(566, 251)
        CuteDepressed.TabIndex = 0
        CuteDepressed.Text = "Cute Depressed (Short Ver.)"
        CuteDepressed.UseVisualStyleBackColor = False
        ' 
        ' BubbleGum
        ' 
        BubbleGum.BackColor = SystemColors.ControlDark
        BubbleGum.Font = New Font("Arial", 18F, FontStyle.Bold)
        BubbleGum.Location = New Point(257, 400)
        BubbleGum.Name = "BubbleGum"
        BubbleGum.Size = New Size(566, 262)
        BubbleGum.TabIndex = 1
        BubbleGum.Text = "Bubble Gum (short Ver.)"
        BubbleGum.UseVisualStyleBackColor = False
        ' 
        ' btnPlay1
        ' 
        btnPlay1.BackColor = SystemColors.GradientActiveCaption
        btnPlay1.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPlay1.Location = New Point(1096, 715)
        btnPlay1.Name = "btnPlay1"
        btnPlay1.Size = New Size(310, 127)
        btnPlay1.TabIndex = 2
        btnPlay1.Text = "Start!"
        btnPlay1.UseVisualStyleBackColor = False
        ' 
        ' btnPlay2
        ' 
        btnPlay2.BackColor = SystemColors.GradientActiveCaption
        btnPlay2.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPlay2.Location = New Point(1096, 715)
        btnPlay2.Name = "btnPlay2"
        btnPlay2.Size = New Size(310, 127)
        btnPlay2.TabIndex = 4
        btnPlay2.Text = "Start!"
        btnPlay2.UseVisualStyleBackColor = False
        ' 
        ' picCuteDepressed
        ' 
        picCuteDepressed.BackgroundImageLayout = ImageLayout.Center
        picCuteDepressed.Image = My.Resources.Resources.artworks_1XvuG1K218FelIAs_z2urLw_t1080x10801
        picCuteDepressed.Location = New Point(906, 162)
        picCuteDepressed.Name = "picCuteDepressed"
        picCuteDepressed.Size = New Size(500, 500)
        picCuteDepressed.SizeMode = PictureBoxSizeMode.StretchImage
        picCuteDepressed.TabIndex = 5
        picCuteDepressed.TabStop = False
        picCuteDepressed.Visible = False
        ' 
        ' lblSong1
        ' 
        lblSong1.Font = New Font("Arial", 12F)
        lblSong1.Location = New Point(381, 299)
        lblSong1.Name = "lblSong1"
        lblSong1.Size = New Size(182, 23)
        lblSong1.TabIndex = 6
        lblSong1.Text = "Dyan Daddy// vickykong"
        ' 
        ' diffName1
        ' 
        diffName1.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        diffName1.Location = New Point(381, 332)
        diffName1.Name = "diffName1"
        diffName1.Size = New Size(182, 23)
        diffName1.TabIndex = 7
        diffName1.Text = "Hard"
        ' 
        ' blSong2
        ' 
        blSong2.Font = New Font("Arial", 12F)
        blSong2.Location = New Point(381, 558)
        blSong2.Name = "blSong2"
        blSong2.Size = New Size(182, 23)
        blSong2.TabIndex = 8
        blSong2.Text = "NewJeans // vickykong"
        ' 
        ' diffName2
        ' 
        diffName2.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        diffName2.Location = New Point(381, 599)
        diffName2.Name = "diffName2"
        diffName2.Size = New Size(182, 23)
        diffName2.TabIndex = 9
        diffName2.Text = "Normal"
        ' 
        ' picBubbleGum
        ' 
        picBubbleGum.Image = My.Resources.Resources.https___images_genius_com_2f2c553bf84b85ccc17daef3da1a3dbc_1000x1000x1
        picBubbleGum.Location = New Point(906, 162)
        picBubbleGum.Name = "picBubbleGum"
        picBubbleGum.Size = New Size(500, 500)
        picBubbleGum.SizeMode = PictureBoxSizeMode.StretchImage
        picBubbleGum.TabIndex = 10
        picBubbleGum.TabStop = False
        picBubbleGum.Visible = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.images1
        ClientSize = New Size(1470, 878)
        Controls.Add(picBubbleGum)
        Controls.Add(diffName2)
        Controls.Add(blSong2)
        Controls.Add(diffName1)
        Controls.Add(lblSong1)
        Controls.Add(picCuteDepressed)
        Controls.Add(btnPlay2)
        Controls.Add(btnPlay1)
        Controls.Add(BubbleGum)
        Controls.Add(CuteDepressed)
        Margin = New Padding(2)
        Name = "Form2"
        Text = "Form2"
        CType(picCuteDepressed, ComponentModel.ISupportInitialize).EndInit()
        CType(picBubbleGum, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents CuteDepressed As Button
    Friend WithEvents BubbleGum As Button
    Friend WithEvents btnPlay1 As Button
    Friend WithEvents btnPlay2 As Button
    Friend WithEvents picCuteDepressed As PictureBox
    Friend WithEvents lblSong1 As Label
    Friend WithEvents diffName1 As Label
    Friend WithEvents blSong2 As Label
    Friend WithEvents diffName2 As Label
    Friend WithEvents picBubbleGum As PictureBox
End Class
