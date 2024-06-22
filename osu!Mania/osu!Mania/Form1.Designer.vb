<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnLogo = New Button()
        btnPlay = New Button()
        btnQuit = New Button()
        SuspendLayout()
        ' 
        ' btnLogo
        ' 
        btnLogo.BackColor = Color.Violet
        btnLogo.Font = New Font("Segoe UI", 80F, FontStyle.Bold)
        btnLogo.Location = New Point(260, 113)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(600, 600)
        btnLogo.TabIndex = 0
        btnLogo.Text = "uso!"
        btnLogo.UseVisualStyleBackColor = False
        ' 
        ' btnPlay
        ' 
        btnPlay.BackColor = Color.Plum
        btnPlay.Font = New Font("Segoe UI", 40F, FontStyle.Bold)
        btnPlay.Location = New Point(812, 182)
        btnPlay.Name = "btnPlay"
        btnPlay.Size = New Size(340, 133)
        btnPlay.TabIndex = 1
        btnPlay.Text = "Play"
        btnPlay.UseVisualStyleBackColor = False
        btnPlay.Visible = False
        ' 
        ' btnQuit
        ' 
        btnQuit.BackColor = Color.Plum
        btnQuit.Font = New Font("Segoe UI", 40F, FontStyle.Bold)
        btnQuit.Location = New Point(821, 505)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(331, 134)
        btnQuit.TabIndex = 3
        btnQuit.Text = "Quit"
        btnQuit.UseVisualStyleBackColor = False
        btnQuit.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.images
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1606, 1028)
        Controls.Add(btnLogo)
        Controls.Add(btnPlay)
        Controls.Add(btnQuit)
        Margin = New Padding(2)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnLogo As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnQuit As Button

End Class
