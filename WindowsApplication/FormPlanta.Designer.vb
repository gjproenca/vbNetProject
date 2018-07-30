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
        Me.tbmensagem = New System.Windows.Forms.TextBox()
        Me.lbmessage = New System.Windows.Forms.Label()
        Me.pbplanta = New System.Windows.Forms.PictureBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.pbcamera = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.tbsendmessage = New System.Windows.Forms.TextBox()
        Me.btsendmessage = New System.Windows.Forms.Button()
        Me.btfire = New System.Windows.Forms.Button()
        Me.btstatus = New System.Windows.Forms.Button()
        Me.tbmsgtest = New System.Windows.Forms.TextBox()
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
        Me.pblivingon.Location = New System.Drawing.Point(407, 205)
        Me.pblivingon.Name = "pblivingon"
        Me.pblivingon.Size = New System.Drawing.Size(25, 35)
        Me.pblivingon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pblivingon.TabIndex = 61
        Me.pblivingon.TabStop = False
        '
        'pblivingoff
        '
        Me.pblivingoff.Image = CType(resources.GetObject("pblivingoff.Image"), System.Drawing.Image)
        Me.pblivingoff.Location = New System.Drawing.Point(407, 205)
        Me.pblivingoff.Name = "pblivingoff"
        Me.pblivingoff.Size = New System.Drawing.Size(25, 35)
        Me.pblivingoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pblivingoff.TabIndex = 60
        Me.pblivingoff.TabStop = False
        '
        'pbroom3on
        '
        Me.pbroom3on.Image = CType(resources.GetObject("pbroom3on.Image"), System.Drawing.Image)
        Me.pbroom3on.Location = New System.Drawing.Point(494, 227)
        Me.pbroom3on.Name = "pbroom3on"
        Me.pbroom3on.Size = New System.Drawing.Size(25, 35)
        Me.pbroom3on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbroom3on.TabIndex = 59
        Me.pbroom3on.TabStop = False
        '
        'pbroom3off
        '
        Me.pbroom3off.Image = CType(resources.GetObject("pbroom3off.Image"), System.Drawing.Image)
        Me.pbroom3off.Location = New System.Drawing.Point(494, 227)
        Me.pbroom3off.Name = "pbroom3off"
        Me.pbroom3off.Size = New System.Drawing.Size(25, 35)
        Me.pbroom3off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbroom3off.TabIndex = 58
        Me.pbroom3off.TabStop = False
        '
        'pbroom2on
        '
        Me.pbroom2on.Image = CType(resources.GetObject("pbroom2on.Image"), System.Drawing.Image)
        Me.pbroom2on.Location = New System.Drawing.Point(319, 227)
        Me.pbroom2on.Name = "pbroom2on"
        Me.pbroom2on.Size = New System.Drawing.Size(25, 35)
        Me.pbroom2on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbroom2on.TabIndex = 57
        Me.pbroom2on.TabStop = False
        '
        'pbroom2off
        '
        Me.pbroom2off.Image = CType(resources.GetObject("pbroom2off.Image"), System.Drawing.Image)
        Me.pbroom2off.Location = New System.Drawing.Point(319, 227)
        Me.pbroom2off.Name = "pbroom2off"
        Me.pbroom2off.Size = New System.Drawing.Size(25, 35)
        Me.pbroom2off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbroom2off.TabIndex = 56
        Me.pbroom2off.TabStop = False
        '
        'pbgaron
        '
        Me.pbgaron.Image = CType(resources.GetObject("pbgaron.Image"), System.Drawing.Image)
        Me.pbgaron.Location = New System.Drawing.Point(577, 179)
        Me.pbgaron.Name = "pbgaron"
        Me.pbgaron.Size = New System.Drawing.Size(25, 35)
        Me.pbgaron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbgaron.TabIndex = 55
        Me.pbgaron.TabStop = False
        Me.pbgaron.Visible = False
        '
        'pbgaroff
        '
        Me.pbgaroff.Image = CType(resources.GetObject("pbgaroff.Image"), System.Drawing.Image)
        Me.pbgaroff.Location = New System.Drawing.Point(577, 179)
        Me.pbgaroff.Name = "pbgaroff"
        Me.pbgaroff.Size = New System.Drawing.Size(25, 35)
        Me.pbgaroff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbgaroff.TabIndex = 54
        Me.pbgaroff.TabStop = False
        Me.pbgaroff.Visible = False
        '
        'pbroom1on
        '
        Me.pbroom1on.Image = CType(resources.GetObject("pbroom1on.Image"), System.Drawing.Image)
        Me.pbroom1on.Location = New System.Drawing.Point(494, 82)
        Me.pbroom1on.Name = "pbroom1on"
        Me.pbroom1on.Size = New System.Drawing.Size(25, 35)
        Me.pbroom1on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbroom1on.TabIndex = 53
        Me.pbroom1on.TabStop = False
        '
        'pbroom1off
        '
        Me.pbroom1off.Image = CType(resources.GetObject("pbroom1off.Image"), System.Drawing.Image)
        Me.pbroom1off.Location = New System.Drawing.Point(494, 82)
        Me.pbroom1off.Name = "pbroom1off"
        Me.pbroom1off.Size = New System.Drawing.Size(25, 35)
        Me.pbroom1off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbroom1off.TabIndex = 52
        Me.pbroom1off.TabStop = False
        '
        'pbdiningon
        '
        Me.pbdiningon.Image = CType(resources.GetObject("pbdiningon.Image"), System.Drawing.Image)
        Me.pbdiningon.Location = New System.Drawing.Point(379, 89)
        Me.pbdiningon.Name = "pbdiningon"
        Me.pbdiningon.Size = New System.Drawing.Size(25, 35)
        Me.pbdiningon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbdiningon.TabIndex = 51
        Me.pbdiningon.TabStop = False
        '
        'pbdiningoff
        '
        Me.pbdiningoff.Image = CType(resources.GetObject("pbdiningoff.Image"), System.Drawing.Image)
        Me.pbdiningoff.Location = New System.Drawing.Point(379, 89)
        Me.pbdiningoff.Name = "pbdiningoff"
        Me.pbdiningoff.Size = New System.Drawing.Size(25, 35)
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
        'tbmensagem
        '
        Me.tbmensagem.Location = New System.Drawing.Point(12, 199)
        Me.tbmensagem.Multiline = True
        Me.tbmensagem.Name = "tbmensagem"
        Me.tbmensagem.ReadOnly = True
        Me.tbmensagem.Size = New System.Drawing.Size(245, 125)
        Me.tbmensagem.TabIndex = 36
        '
        'lbmessage
        '
        Me.lbmessage.AutoSize = True
        Me.lbmessage.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbmessage.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbmessage.Location = New System.Drawing.Point(13, 177)
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
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM2"
        '
        'pbcamera
        '
        Me.pbcamera.Location = New System.Drawing.Point(387, 109)
        Me.pbcamera.Name = "pbcamera"
        Me.pbcamera.Size = New System.Drawing.Size(139, 118)
        Me.pbcamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcamera.TabIndex = 71
        Me.pbcamera.TabStop = False
        Me.pbcamera.Visible = False
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'tbsendmessage
        '
        Me.tbsendmessage.Location = New System.Drawing.Point(12, 41)
        Me.tbsendmessage.Multiline = True
        Me.tbsendmessage.Name = "tbsendmessage"
        Me.tbsendmessage.Size = New System.Drawing.Size(245, 101)
        Me.tbsendmessage.TabIndex = 74
        '
        'btsendmessage
        '
        Me.btsendmessage.BackColor = System.Drawing.Color.White
        Me.btsendmessage.Location = New System.Drawing.Point(141, 148)
        Me.btsendmessage.Name = "btsendmessage"
        Me.btsendmessage.Size = New System.Drawing.Size(116, 23)
        Me.btsendmessage.TabIndex = 75
        Me.btsendmessage.Text = "Send"
        Me.btsendmessage.UseVisualStyleBackColor = False
        '
        'btfire
        '
        Me.btfire.BackColor = System.Drawing.Color.White
        Me.btfire.Location = New System.Drawing.Point(141, 12)
        Me.btfire.Name = "btfire"
        Me.btfire.Size = New System.Drawing.Size(116, 23)
        Me.btfire.TabIndex = 76
        Me.btfire.UseVisualStyleBackColor = False
        '
        'btstatus
        '
        Me.btstatus.BackColor = System.Drawing.Color.White
        Me.btstatus.Location = New System.Drawing.Point(12, 12)
        Me.btstatus.Name = "btstatus"
        Me.btstatus.Size = New System.Drawing.Size(116, 23)
        Me.btstatus.TabIndex = 77
        Me.btstatus.UseVisualStyleBackColor = False
        '
        'tbmsgtest
        '
        Me.tbmsgtest.Location = New System.Drawing.Point(35, 150)
        Me.tbmsgtest.Name = "tbmsgtest"
        Me.tbmsgtest.Size = New System.Drawing.Size(100, 20)
        Me.tbmsgtest.TabIndex = 78
        '
        'frmplanta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 334)
        Me.Controls.Add(Me.tbmsgtest)
        Me.Controls.Add(Me.btstatus)
        Me.Controls.Add(Me.btfire)
        Me.Controls.Add(Me.btsendmessage)
        Me.Controls.Add(Me.tbsendmessage)
        Me.Controls.Add(Me.pbcamera)
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
        Me.Controls.Add(Me.tbmensagem)
        Me.Controls.Add(Me.lbmessage)
        Me.Controls.Add(Me.pbplanta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmplanta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planta (Com Port 3)"
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
    Private WithEvents tbmensagem As TextBox
    Private WithEvents lbmessage As Label
    Private WithEvents pbplanta As PictureBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Private WithEvents pbcamera As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents timer As Timer
    Friend WithEvents tbsendmessage As TextBox
    Friend WithEvents btsendmessage As Button
    Friend WithEvents btfire As Button
    Friend WithEvents btstatus As Button
    Friend WithEvents tbmsgtest As TextBox
End Class
