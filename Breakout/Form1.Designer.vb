<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form
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
        Me.components = New System.ComponentModel.Container()
        Me.PicBall = New System.Windows.Forms.PictureBox()
        Me.game_ticker = New System.Windows.Forms.Timer(Me.components)
        Me.picBat = New System.Windows.Forms.PictureBox()
        Me.Brick = New System.Windows.Forms.PictureBox()
        Me.Brick1 = New System.Windows.Forms.PictureBox()
        Me.Brick2 = New System.Windows.Forms.PictureBox()
        Me.Brick3 = New System.Windows.Forms.PictureBox()
        Me.txt_score = New System.Windows.Forms.Label()
        Me.txt_equal = New System.Windows.Forms.Label()
        Me.lbl_score = New System.Windows.Forms.Label()
        Me.game_time = New System.Windows.Forms.Timer(Me.components)
        Me.txt_lives = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_lives = New System.Windows.Forms.Label()
        CType(Me.PicBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Brick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Brick1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Brick2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Brick3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicBall
        '
        Me.PicBall.BackColor = System.Drawing.Color.White
        Me.PicBall.Location = New System.Drawing.Point(363, 155)
        Me.PicBall.Name = "PicBall"
        Me.PicBall.Size = New System.Drawing.Size(18, 19)
        Me.PicBall.TabIndex = 0
        Me.PicBall.TabStop = False
        '
        'game_ticker
        '
        Me.game_ticker.Enabled = True
        Me.game_ticker.Interval = 30
        '
        'picBat
        '
        Me.picBat.BackColor = System.Drawing.SystemColors.ControlText
        Me.picBat.Enabled = False
        Me.picBat.Location = New System.Drawing.Point(301, 582)
        Me.picBat.Name = "picBat"
        Me.picBat.Size = New System.Drawing.Size(143, 19)
        Me.picBat.TabIndex = 1
        Me.picBat.TabStop = False
        '
        'Brick
        '
        Me.Brick.BackColor = System.Drawing.Color.Red
        Me.Brick.Location = New System.Drawing.Point(22, 32)
        Me.Brick.Name = "Brick"
        Me.Brick.Size = New System.Drawing.Size(81, 15)
        Me.Brick.TabIndex = 2
        Me.Brick.TabStop = False
        '
        'Brick1
        '
        Me.Brick1.BackColor = System.Drawing.Color.Red
        Me.Brick1.Location = New System.Drawing.Point(166, 32)
        Me.Brick1.Name = "Brick1"
        Me.Brick1.Size = New System.Drawing.Size(81, 15)
        Me.Brick1.TabIndex = 2
        Me.Brick1.TabStop = False
        '
        'Brick2
        '
        Me.Brick2.BackColor = System.Drawing.Color.Red
        Me.Brick2.Location = New System.Drawing.Point(363, 32)
        Me.Brick2.Name = "Brick2"
        Me.Brick2.Size = New System.Drawing.Size(81, 15)
        Me.Brick2.TabIndex = 2
        Me.Brick2.TabStop = False
        '
        'Brick3
        '
        Me.Brick3.BackColor = System.Drawing.Color.Red
        Me.Brick3.Location = New System.Drawing.Point(586, 32)
        Me.Brick3.Name = "Brick3"
        Me.Brick3.Size = New System.Drawing.Size(81, 15)
        Me.Brick3.TabIndex = 2
        Me.Brick3.TabStop = False
        '
        'txt_score
        '
        Me.txt_score.AutoSize = True
        Me.txt_score.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_score.Location = New System.Drawing.Point(766, 624)
        Me.txt_score.Name = "txt_score"
        Me.txt_score.Size = New System.Drawing.Size(60, 25)
        Me.txt_score.TabIndex = 3
        Me.txt_score.Text = "score"
        '
        'txt_equal
        '
        Me.txt_equal.AutoSize = True
        Me.txt_equal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_equal.Location = New System.Drawing.Point(832, 624)
        Me.txt_equal.Name = "txt_equal"
        Me.txt_equal.Size = New System.Drawing.Size(24, 25)
        Me.txt_equal.TabIndex = 3
        Me.txt_equal.Text = "="
        '
        'lbl_score
        '
        Me.lbl_score.AutoSize = True
        Me.lbl_score.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_score.Location = New System.Drawing.Point(871, 624)
        Me.lbl_score.Name = "lbl_score"
        Me.lbl_score.Size = New System.Drawing.Size(23, 25)
        Me.lbl_score.TabIndex = 3
        Me.lbl_score.Text = "0"
        '
        'txt_lives
        '
        Me.txt_lives.AutoSize = True
        Me.txt_lives.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lives.Location = New System.Drawing.Point(766, 599)
        Me.txt_lives.Name = "txt_lives"
        Me.txt_lives.Size = New System.Drawing.Size(51, 25)
        Me.txt_lives.TabIndex = 3
        Me.txt_lives.Text = "lives"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(832, 599)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "="
        '
        'lbl_lives
        '
        Me.lbl_lives.AutoSize = True
        Me.lbl_lives.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lives.Location = New System.Drawing.Point(871, 599)
        Me.lbl_lives.Name = "lbl_lives"
        Me.lbl_lives.Size = New System.Drawing.Size(23, 25)
        Me.lbl_lives.TabIndex = 3
        Me.lbl_lives.Text = "5"
        '
        'form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(934, 658)
        Me.Controls.Add(Me.lbl_lives)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_score)
        Me.Controls.Add(Me.txt_lives)
        Me.Controls.Add(Me.txt_equal)
        Me.Controls.Add(Me.txt_score)
        Me.Controls.Add(Me.Brick3)
        Me.Controls.Add(Me.Brick2)
        Me.Controls.Add(Me.Brick1)
        Me.Controls.Add(Me.Brick)
        Me.Controls.Add(Me.picBat)
        Me.Controls.Add(Me.PicBall)
        Me.Name = "form"
        Me.Text = "Form1"
        CType(Me.PicBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Brick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Brick1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Brick2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Brick3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicBall As System.Windows.Forms.PictureBox
    Friend WithEvents game_ticker As System.Windows.Forms.Timer
    Friend WithEvents picBat As System.Windows.Forms.PictureBox
    Friend WithEvents Brick As System.Windows.Forms.PictureBox
    Friend WithEvents Brick1 As System.Windows.Forms.PictureBox
    Friend WithEvents Brick2 As System.Windows.Forms.PictureBox
    Friend WithEvents Brick3 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_score As System.Windows.Forms.Label
    Friend WithEvents txt_equal As System.Windows.Forms.Label
    Friend WithEvents lbl_score As System.Windows.Forms.Label
    Friend WithEvents game_time As System.Windows.Forms.Timer
    Friend WithEvents txt_lives As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_lives As System.Windows.Forms.Label

End Class
