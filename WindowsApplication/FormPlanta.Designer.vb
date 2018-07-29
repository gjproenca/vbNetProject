<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmplanta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmplanta))
        Me.pbfire = New System.Windows.Forms.PictureBox()
        Me.pblivingon = New System.Windows.Forms.PictureBox()
        Me.pblivingoff = New System.Windows.Forms.PictureBox()
        Me.pbroom3on = New System.Windows.Forms.PictureBox()
        Me.pbroom3off = New System.Windows.Forms.PictureBox()
        Me.pbroom2on = New System.Windows.Forms.PictureBox()
        Me.pbroom2off = New System.Windows.Forms.PictureBox()
        Me.pbgaron = New System.Windows.Forms.PictureBox()
        Me.pbgaroff = New System.Windows.Forms.PictureBox()
        Me.pbroom1on = New System.Windows.Forms.PictureBox()
        Me.pbroom1off = New System.Windows.Forms.PictureBox()
        Me.pbdiningon = New System.Windows.Forms.PictureBox()
        Me.pbdiningoff = New System.Windows.Forms.PictureBox()
        Me.pbcamvig = New System.Windows.Forms.PictureBox()
        Me.btncomread = New System.Windows.Forms.Button()
        Me.btncomwrite = New System.Windows.Forms.Button()
        Me.chbalarm = New System.Windows.Forms.CheckBox()
        Me.tbstatus = New System.Windows.Forms.TextBox()
        Me.lbstatus = New System.Windows.Forms.Label()
        Me.lbfirealarm = New System.Windows.Forms.Label()
        Me.tbmensagem = New System.Windows.Forms.TextBox()
        Me.lbmessage = New System.Windows.Forms.Label()
        Me.pbplanta = New System.Windows.Forms.PictureBox()
        Me.pblogo = New System.Windows.Forms.PictureBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.chbdining = New System.Windows.Forms.CheckBox()
        Me.chbliving = New System.Windows.Forms.CheckBox()
        Me.chbroom2 = New System.Windows.Forms.CheckBox()
        Me.chbroom3 = New System.Windows.Forms.CheckBox()
        Me.chbroom1 = New System.Windows.Forms.CheckBox()
        Me.chbgarage = New System.Windows.Forms.CheckBox()
        Me.lbcomport3 = New System.Windows.Forms.Label()
        Me.pbcamera = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbfire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pblivingon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pblivingoff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbroom3on, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbroom3off, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbroom2on, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbroom2off, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbgaron, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbgaroff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbroom1on, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbroom1off, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbdiningon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbdiningoff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcamvig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbplanta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pblogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcamera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbfire
        '
        Me.pbfire.Image = CType(resources.GetObject("pbfire.Image"), System.Drawing.Image)
        Me.pbfire.Location = New System.Drawing.Point(607, 71)
        Me.pbfire.Name = "pbfire"
        Me.pbfire.Size = New System.Drawing.Size(31, 34)
        Me.pbfire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbfire.TabIndex = 62
        Me.pbfire.TabStop = False
        '
        'pblivingon
        '
        Me.pblivingon.Image = CType(resources.GetObject("pblivingon.Image"), System.Drawing.Image)
        Me.pblivingon.Location = New System.Drawing.Point(422, 217)
        Me.pblivingon.Name = "pblivingon"
        Me.pblivingon.Size = New System.Drawing.Size(29, 25)
        Me.pblivingon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pblivingon.TabIndex = 61
        Me.pblivingon.TabStop = False
        '
        'pblivingoff
        '
        Me.pblivingoff.Image = CType(resources.GetObject("pblivingoff.Image"), System.Drawing.Image)
        Me.pblivingoff.Location = New System.Drawing.Point(400, 217)
        Me.pblivingoff.Name = "pblivingoff"
        Me.pblivingoff.Size = New System.Drawing.Size(29, 25)
        Me.pblivingoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pblivingoff.TabIndex = 60
        Me.pblivingoff.TabStop = False
        '
        'pbroom3on
        '
        Me.pbroom3on.Image = CType(resources.GetObject("pbroom3on.Image"), System.Drawing.Image)
        Me.pbroom3on.Location = New System.Drawing.Point(500, 227)
        Me.pbroom3on.Name = "pbroom3on"
        Me.pbroom3on.Size = New System.Drawing.Size(29, 25)
        Me.pbroom3on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbroom3on.TabIndex = 59
        Me.pbroom3on.TabStop = False
        '
        'pbroom3off
        '
        Me.pbroom3off.Image = CType(resources.GetObject("pbroom3off.Image"), System.Drawing.Image)
        Me.pbroom3off.Location = New System.Drawing.Point(478, 227)
        Me.pbroom3off.Name = "pbroom3off"
        Me.pbroom3off.Size = New System.Drawing.Size(29, 25)
        Me.pbroom3off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbroom3off.TabIndex = 58
        Me.pbroom3off.TabStop = False
        '
        'pbroom2on
        '
        Me.pbroom2on.Image = CType(resources.GetObject("pbroom2on.Image"), System.Drawing.Image)
        Me.pbroom2on.Location = New System.Drawing.Point(331, 223)
        Me.pbroom2on.Name = "pbroom2on"
        Me.pbroom2on.Size = New System.Drawing.Size(29, 25)
        Me.pbroom2on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbroom2on.TabIndex = 57
        Me.pbroom2on.TabStop = False
        '
        'pbroom2off
        '
        Me.pbroom2off.Image = CType(resources.GetObject("pbroom2off.Image"), System.Drawing.Image)
        Me.pbroom2off.Location = New System.Drawing.Point(309, 223)
        Me.pbroom2off.Name = "pbroom2off"
        Me.pbroom2off.Size = New System.Drawing.Size(29, 25)
        Me.pbroom2off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbroom2off.TabIndex = 56
        Me.pbroom2off.TabStop = False
        '
        'pbgaron
        '
        Me.pbgaron.Image = CType(resources.GetObject("pbgaron.Image"), System.Drawing.Image)
        Me.pbgaron.Location = New System.Drawing.Point(573, 179)
        Me.pbgaron.Name = "pbgaron"
        Me.pbgaron.Size = New System.Drawing.Size(29, 25)
        Me.pbgaron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbgaron.TabIndex = 55
        Me.pbgaron.TabStop = False
        Me.pbgaron.Visible = False
        '
        'pbgaroff
        '
        Me.pbgaroff.Image = CType(resources.GetObject("pbgaroff.Image"), System.Drawing.Image)
        Me.pbgaroff.Location = New System.Drawing.Point(551, 179)
        Me.pbgaroff.Name = "pbgaroff"
        Me.pbgaroff.Size = New System.Drawing.Size(29, 25)
        Me.pbgaroff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbgaroff.TabIndex = 54
        Me.pbgaroff.TabStop = False
        Me.pbgaroff.Visible = False
        '
        'pbroom1on
        '
        Me.pbroom1on.Image = CType(resources.GetObject("pbroom1on.Image"), System.Drawing.Image)
        Me.pbroom1on.Location = New System.Drawing.Point(501, 88)
        Me.pbroom1on.Name = "pbroom1on"
        Me.pbroom1on.Size = New System.Drawing.Size(29, 25)
        Me.pbroom1on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbroom1on.TabIndex = 53
        Me.pbroom1on.TabStop = False
        '
        'pbroom1off
        '
        Me.pbroom1off.Image = CType(resources.GetObject("pbroom1off.Image"), System.Drawing.Image)
        Me.pbroom1off.Location = New System.Drawing.Point(479, 88)
        Me.pbroom1off.Name = "pbroom1off"
        Me.pbroom1off.Size = New System.Drawing.Size(29, 25)
        Me.pbroom1off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbroom1off.TabIndex = 52
        Me.pbroom1off.TabStop = False
        '
        'pbdiningon
        '
        Me.pbdiningon.Image = CType(resources.GetObject("pbdiningon.Image"), System.Drawing.Image)
        Me.pbdiningon.Location = New System.Drawing.Point(403, 89)
        Me.pbdiningon.Name = "pbdiningon"
        Me.pbdiningon.Size = New System.Drawing.Size(29, 25)
        Me.pbdiningon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbdiningon.TabIndex = 51
        Me.pbdiningon.TabStop = False
        '
        'pbdiningoff
        '
        Me.pbdiningoff.Image = CType(resources.GetObject("pbdiningoff.Image"), System.Drawing.Image)
        Me.pbdiningoff.Location = New System.Drawing.Point(379, 89)
        Me.pbdiningoff.Name = "pbdiningoff"
        Me.pbdiningoff.Size = New System.Drawing.Size(31, 25)
        Me.pbdiningoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbdiningoff.TabIndex = 50
        Me.pbdiningoff.TabStop = False
        '
        'pbcamvig
        '
        Me.pbcamvig.Image = CType(resources.GetObject("pbcamvig.Image"), System.Drawing.Image)
        Me.pbcamvig.Location = New System.Drawing.Point(607, 40)
        Me.pbcamvig.Name = "pbcamvig"
        Me.pbcamvig.Size = New System.Drawing.Size(29, 25)
        Me.pbcamvig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcamvig.TabIndex = 49
        Me.pbcamvig.TabStop = False
        '
        'btncomread
        '
        Me.btncomread.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btncomread.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomread.Location = New System.Drawing.Point(79, 207)
        Me.btncomread.Name = "btncomread"
        Me.btncomread.Size = New System.Drawing.Size(76, 23)
        Me.btncomread.TabIndex = 48
        Me.btncomread.Text = "Com Read"
        Me.btncomread.UseVisualStyleBackColor = False
        '
        'btncomwrite
        '
        Me.btncomwrite.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btncomwrite.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomwrite.Location = New System.Drawing.Point(158, 207)
        Me.btncomwrite.Name = "btncomwrite"
        Me.btncomwrite.Size = New System.Drawing.Size(76, 23)
        Me.btncomwrite.TabIndex = 47
        Me.btncomwrite.Text = "Com Write"
        Me.btncomwrite.UseVisualStyleBackColor = False
        '
        'chbalarm
        '
        Me.chbalarm.AutoSize = True
        Me.chbalarm.Location = New System.Drawing.Point(80, 282)
        Me.chbalarm.Name = "chbalarm"
        Me.chbalarm.Size = New System.Drawing.Size(15, 14)
        Me.chbalarm.TabIndex = 44
        Me.chbalarm.UseVisualStyleBackColor = True
        '
        'tbstatus
        '
        Me.tbstatus.Location = New System.Drawing.Point(59, 256)
        Me.tbstatus.Name = "tbstatus"
        Me.tbstatus.Size = New System.Drawing.Size(121, 20)
        Me.tbstatus.TabIndex = 43
        '
        'lbstatus
        '
        Me.lbstatus.AutoSize = True
        Me.lbstatus.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbstatus.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbstatus.Location = New System.Drawing.Point(13, 258)
        Me.lbstatus.Name = "lbstatus"
        Me.lbstatus.Size = New System.Drawing.Size(40, 16)
        Me.lbstatus.TabIndex = 42
        Me.lbstatus.Text = "Status"
        '
        'lbfirealarm
        '
        Me.lbfirealarm.AutoSize = True
        Me.lbfirealarm.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbfirealarm.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbfirealarm.Location = New System.Drawing.Point(13, 281)
        Me.lbfirealarm.Name = "lbfirealarm"
        Me.lbfirealarm.Size = New System.Drawing.Size(61, 16)
        Me.lbfirealarm.TabIndex = 41
        Me.lbfirealarm.Text = "Fire Alarm"
        '
        'tbmensagem
        '
        Me.tbmensagem.Location = New System.Drawing.Point(12, 340)
        Me.tbmensagem.Multiline = True
        Me.tbmensagem.Name = "tbmensagem"
        Me.tbmensagem.Size = New System.Drawing.Size(249, 125)
        Me.tbmensagem.TabIndex = 36
        '
        'lbmessage
        '
        Me.lbmessage.AutoSize = True
        Me.lbmessage.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbmessage.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbmessage.Location = New System.Drawing.Point(13, 318)
        Me.lbmessage.Name = "lbmessage"
        Me.lbmessage.Size = New System.Drawing.Size(53, 16)
        Me.lbmessage.TabIndex = 35
        Me.lbmessage.Text = "Message"
        '
        'pbplanta
        '
        Me.pbplanta.Image = CType(resources.GetObject("pbplanta.Image"), System.Drawing.Image)
        Me.pbplanta.Location = New System.Drawing.Point(263, 12)
        Me.pbplanta.Name = "pbplanta"
        Me.pbplanta.Size = New System.Drawing.Size(387, 312)
        Me.pbplanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbplanta.TabIndex = 34
        Me.pbplanta.TabStop = False
        '
        'pblogo
        '
        Me.pblogo.Image = CType(resources.GetObject("pblogo.Image"), System.Drawing.Image)
        Me.pblogo.Location = New System.Drawing.Point(12, 12)
        Me.pblogo.Name = "pblogo"
        Me.pblogo.Size = New System.Drawing.Size(127, 139)
        Me.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pblogo.TabIndex = 32
        Me.pblogo.TabStop = False
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM2"
        '
        'chbdining
        '
        Me.chbdining.AutoSize = True
        Me.chbdining.Location = New System.Drawing.Point(411, 116)
        Me.chbdining.Name = "chbdining"
        Me.chbdining.Size = New System.Drawing.Size(15, 14)
        Me.chbdining.TabIndex = 64
        Me.chbdining.UseVisualStyleBackColor = True
        '
        'chbliving
        '
        Me.chbliving.AutoSize = True
        Me.chbliving.Location = New System.Drawing.Point(406, 244)
        Me.chbliving.Name = "chbliving"
        Me.chbliving.Size = New System.Drawing.Size(15, 14)
        Me.chbliving.TabIndex = 65
        Me.chbliving.UseVisualStyleBackColor = True
        '
        'chbroom2
        '
        Me.chbroom2.AutoSize = True
        Me.chbroom2.Location = New System.Drawing.Point(315, 250)
        Me.chbroom2.Name = "chbroom2"
        Me.chbroom2.Size = New System.Drawing.Size(15, 14)
        Me.chbroom2.TabIndex = 66
        Me.chbroom2.UseVisualStyleBackColor = True
        '
        'chbroom3
        '
        Me.chbroom3.AutoSize = True
        Me.chbroom3.Location = New System.Drawing.Point(484, 253)
        Me.chbroom3.Name = "chbroom3"
        Me.chbroom3.Size = New System.Drawing.Size(15, 14)
        Me.chbroom3.TabIndex = 67
        Me.chbroom3.UseVisualStyleBackColor = True
        '
        'chbroom1
        '
        Me.chbroom1.AutoSize = True
        Me.chbroom1.Location = New System.Drawing.Point(484, 114)
        Me.chbroom1.Name = "chbroom1"
        Me.chbroom1.Size = New System.Drawing.Size(15, 14)
        Me.chbroom1.TabIndex = 68
        Me.chbroom1.UseVisualStyleBackColor = True
        '
        'chbgarage
        '
        Me.chbgarage.AutoSize = True
        Me.chbgarage.Location = New System.Drawing.Point(581, 205)
        Me.chbgarage.Name = "chbgarage"
        Me.chbgarage.Size = New System.Drawing.Size(15, 14)
        Me.chbgarage.TabIndex = 69
        Me.chbgarage.UseVisualStyleBackColor = True
        '
        'lbcomport3
        '
        Me.lbcomport3.AutoSize = True
        Me.lbcomport3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbcomport3.Location = New System.Drawing.Point(16, 213)
        Me.lbcomport3.Name = "lbcomport3"
        Me.lbcomport3.Size = New System.Drawing.Size(37, 13)
        Me.lbcomport3.TabIndex = 70
        Me.lbcomport3.Text = "Com 3"
        '
        'pbcamera
        '
        Me.pbcamera.Location = New System.Drawing.Point(511, 347)
        Me.pbcamera.Name = "pbcamera"
        Me.pbcamera.Size = New System.Drawing.Size(139, 118)
        Me.pbcamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcamera.TabIndex = 71
        Me.pbcamera.TabStop = False
        Me.pbcamera.Visible = False
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnsubmit.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.Location = New System.Drawing.Point(284, 442)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(76, 23)
        Me.btnsubmit.TabIndex = 72
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = False
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'frmplanta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 477)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.pbcamera)
        Me.Controls.Add(Me.lbcomport3)
        Me.Controls.Add(Me.chbgarage)
        Me.Controls.Add(Me.chbroom1)
        Me.Controls.Add(Me.chbroom3)
        Me.Controls.Add(Me.chbroom2)
        Me.Controls.Add(Me.chbliving)
        Me.Controls.Add(Me.chbdining)
        Me.Controls.Add(Me.pbfire)
        Me.Controls.Add(Me.pblivingon)
        Me.Controls.Add(Me.pblivingoff)
        Me.Controls.Add(Me.pbroom3on)
        Me.Controls.Add(Me.pbroom3off)
        Me.Controls.Add(Me.pbroom2on)
        Me.Controls.Add(Me.pbroom2off)
        Me.Controls.Add(Me.pbgaron)
        Me.Controls.Add(Me.pbgaroff)
        Me.Controls.Add(Me.pbroom1on)
        Me.Controls.Add(Me.pbroom1off)
        Me.Controls.Add(Me.pbdiningon)
        Me.Controls.Add(Me.pbdiningoff)
        Me.Controls.Add(Me.pbcamvig)
        Me.Controls.Add(Me.btncomread)
        Me.Controls.Add(Me.btncomwrite)
        Me.Controls.Add(Me.chbalarm)
        Me.Controls.Add(Me.tbstatus)
        Me.Controls.Add(Me.lbstatus)
        Me.Controls.Add(Me.lbfirealarm)
        Me.Controls.Add(Me.tbmensagem)
        Me.Controls.Add(Me.lbmessage)
        Me.Controls.Add(Me.pbplanta)
        Me.Controls.Add(Me.pblogo)
        Me.Name = "frmplanta"
        Me.Text = "Planta"
        CType(Me.pbfire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pblivingon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pblivingoff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbroom3on, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbroom3off, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbroom2on, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbroom2off, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbgaron, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbgaroff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbroom1on, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbroom1off, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbdiningon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbdiningoff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbcamvig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbplanta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pblogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbcamera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pbfire As PictureBox
    Private WithEvents pblivingon As PictureBox
    Private WithEvents pblivingoff As PictureBox
    Private WithEvents pbroom3on As PictureBox
    Private WithEvents pbroom3off As PictureBox
    Private WithEvents pbroom2on As PictureBox
    Private WithEvents pbroom2off As PictureBox
    Private WithEvents pbgaron As PictureBox
    Private WithEvents pbgaroff As PictureBox
    Private WithEvents pbroom1on As PictureBox
    Private WithEvents pbroom1off As PictureBox
    Private WithEvents pbdiningon As PictureBox
    Private WithEvents pbdiningoff As PictureBox
    Private WithEvents pbcamvig As PictureBox
    Private WithEvents btncomread As Button
    Private WithEvents btncomwrite As Button
    Private WithEvents chbalarm As CheckBox
    Private WithEvents tbstatus As TextBox
    Private WithEvents lbstatus As Label
    Private WithEvents lbfirealarm As Label
    Private WithEvents tbmensagem As TextBox
    Private WithEvents lbmessage As Label
    Private WithEvents pbplanta As PictureBox
    Private WithEvents pblogo As PictureBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents chbdining As CheckBox
    Friend WithEvents chbliving As CheckBox
    Friend WithEvents chbroom2 As CheckBox
    Friend WithEvents chbroom3 As CheckBox
    Friend WithEvents chbroom1 As CheckBox
    Friend WithEvents chbgarage As CheckBox
    Friend WithEvents lbcomport3 As Label
    Private WithEvents pbcamera As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Private WithEvents btnsubmit As Button
    Friend WithEvents timer As Timer
End Class
