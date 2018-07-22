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
        Me.pnlcamera = New System.Windows.Forms.Panel()
        Me.pbcamera = New System.Windows.Forms.PictureBox()
        Me.lbcamera = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.cbcomport = New System.Windows.Forms.ComboBox()
        Me.lbcomport = New System.Windows.Forms.Label()
        Me.chbalarm = New System.Windows.Forms.CheckBox()
        Me.tbstatus = New System.Windows.Forms.TextBox()
        Me.lbstatus = New System.Windows.Forms.Label()
        Me.lbalarm = New System.Windows.Forms.Label()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnselect = New System.Windows.Forms.Button()
        Me.tbmensagem = New System.Windows.Forms.TextBox()
        Me.lbmessage = New System.Windows.Forms.Label()
        Me.pbplanta = New System.Windows.Forms.PictureBox()
        Me.btncomport = New System.Windows.Forms.Button()
        Me.pblogo = New System.Windows.Forms.PictureBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.pnlcamera.SuspendLayout()
        CType(Me.pbcamera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuspendLayout()
        '
        'pnlcamera
        '
        Me.pnlcamera.Controls.Add(Me.pbcamera)
        Me.pnlcamera.Controls.Add(Me.lbcamera)
        Me.pnlcamera.Location = New System.Drawing.Point(318, 69)
        Me.pnlcamera.Name = "pnlcamera"
        Me.pnlcamera.Size = New System.Drawing.Size(262, 205)
        Me.pnlcamera.TabIndex = 63
        Me.pnlcamera.Visible = False
        '
        'pbcamera
        '
        Me.pbcamera.Location = New System.Drawing.Point(0, 24)
        Me.pbcamera.Name = "pbcamera"
        Me.pbcamera.Size = New System.Drawing.Size(262, 181)
        Me.pbcamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcamera.TabIndex = 1
        Me.pbcamera.TabStop = False
        '
        'lbcamera
        '
        Me.lbcamera.AutoSize = True
        Me.lbcamera.Location = New System.Drawing.Point(111, 6)
        Me.lbcamera.Name = "lbcamera"
        Me.lbcamera.Size = New System.Drawing.Size(42, 13)
        Me.lbcamera.TabIndex = 0
        Me.lbcamera.Text = "camera"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(584, 89)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(31, 34)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 62
        Me.pictureBox1.TabStop = False
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
        Me.pbroom3on.Location = New System.Drawing.Point(495, 236)
        Me.pbroom3on.Name = "pbroom3on"
        Me.pbroom3on.Size = New System.Drawing.Size(29, 25)
        Me.pbroom3on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbroom3on.TabIndex = 59
        Me.pbroom3on.TabStop = False
        '
        'pbroom3off
        '
        Me.pbroom3off.Image = CType(resources.GetObject("pbroom3off.Image"), System.Drawing.Image)
        Me.pbroom3off.Location = New System.Drawing.Point(473, 236)
        Me.pbroom3off.Name = "pbroom3off"
        Me.pbroom3off.Size = New System.Drawing.Size(29, 25)
        Me.pbroom3off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbroom3off.TabIndex = 58
        Me.pbroom3off.TabStop = False
        '
        'pbroom2on
        '
        Me.pbroom2on.Image = CType(resources.GetObject("pbroom2on.Image"), System.Drawing.Image)
        Me.pbroom2on.Location = New System.Drawing.Point(339, 236)
        Me.pbroom2on.Name = "pbroom2on"
        Me.pbroom2on.Size = New System.Drawing.Size(29, 25)
        Me.pbroom2on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbroom2on.TabIndex = 57
        Me.pbroom2on.TabStop = False
        '
        'pbroom2off
        '
        Me.pbroom2off.Image = CType(resources.GetObject("pbroom2off.Image"), System.Drawing.Image)
        Me.pbroom2off.Location = New System.Drawing.Point(317, 236)
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
        '
        'pbroom1on
        '
        Me.pbroom1on.Image = CType(resources.GetObject("pbroom1on.Image"), System.Drawing.Image)
        Me.pbroom1on.Location = New System.Drawing.Point(495, 107)
        Me.pbroom1on.Name = "pbroom1on"
        Me.pbroom1on.Size = New System.Drawing.Size(29, 25)
        Me.pbroom1on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbroom1on.TabIndex = 53
        Me.pbroom1on.TabStop = False
        '
        'pbroom1off
        '
        Me.pbroom1off.Image = CType(resources.GetObject("pbroom1off.Image"), System.Drawing.Image)
        Me.pbroom1off.Location = New System.Drawing.Point(473, 107)
        Me.pbroom1off.Name = "pbroom1off"
        Me.pbroom1off.Size = New System.Drawing.Size(29, 25)
        Me.pbroom1off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbroom1off.TabIndex = 52
        Me.pbroom1off.TabStop = False
        '
        'pbdiningon
        '
        Me.pbdiningon.Image = CType(resources.GetObject("pbdiningon.Image"), System.Drawing.Image)
        Me.pbdiningon.Location = New System.Drawing.Point(403, 125)
        Me.pbdiningon.Name = "pbdiningon"
        Me.pbdiningon.Size = New System.Drawing.Size(29, 25)
        Me.pbdiningon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbdiningon.TabIndex = 51
        Me.pbdiningon.TabStop = False
        '
        'pbdiningoff
        '
        Me.pbdiningoff.Image = CType(resources.GetObject("pbdiningoff.Image"), System.Drawing.Image)
        Me.pbdiningoff.Location = New System.Drawing.Point(381, 125)
        Me.pbdiningoff.Name = "pbdiningoff"
        Me.pbdiningoff.Size = New System.Drawing.Size(29, 25)
        Me.pbdiningoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbdiningoff.TabIndex = 50
        Me.pbdiningoff.TabStop = False
        '
        'pbcamvig
        '
        Me.pbcamvig.Image = CType(resources.GetObject("pbcamvig.Image"), System.Drawing.Image)
        Me.pbcamvig.Location = New System.Drawing.Point(586, 58)
        Me.pbcamvig.Name = "pbcamvig"
        Me.pbcamvig.Size = New System.Drawing.Size(29, 25)
        Me.pbcamvig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcamvig.TabIndex = 49
        Me.pbcamvig.TabStop = False
        '
        'btncomread
        '
        Me.btncomread.BackColor = System.Drawing.SystemColors.Highlight
        Me.btncomread.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomread.Location = New System.Drawing.Point(12, 194)
        Me.btncomread.Name = "btncomread"
        Me.btncomread.Size = New System.Drawing.Size(76, 23)
        Me.btncomread.TabIndex = 48
        Me.btncomread.Text = "Com Read"
        Me.btncomread.UseVisualStyleBackColor = False
        '
        'btncomwrite
        '
        Me.btncomwrite.BackColor = System.Drawing.SystemColors.Highlight
        Me.btncomwrite.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomwrite.Location = New System.Drawing.Point(91, 194)
        Me.btncomwrite.Name = "btncomwrite"
        Me.btncomwrite.Size = New System.Drawing.Size(76, 23)
        Me.btncomwrite.TabIndex = 47
        Me.btncomwrite.Text = "Com Write"
        Me.btncomwrite.UseVisualStyleBackColor = False
        '
        'cbcomport
        '
        Me.cbcomport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcomport.FormattingEnabled = True
        Me.cbcomport.Location = New System.Drawing.Point(78, 229)
        Me.cbcomport.Name = "cbcomport"
        Me.cbcomport.Size = New System.Drawing.Size(102, 21)
        Me.cbcomport.TabIndex = 46
        '
        'lbcomport
        '
        Me.lbcomport.AutoSize = True
        Me.lbcomport.BackColor = System.Drawing.SystemColors.Highlight
        Me.lbcomport.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcomport.Location = New System.Drawing.Point(13, 232)
        Me.lbcomport.Name = "lbcomport"
        Me.lbcomport.Size = New System.Drawing.Size(59, 16)
        Me.lbcomport.TabIndex = 45
        Me.lbcomport.Text = "Com_Port"
        '
        'chbalarm
        '
        Me.chbalarm.AutoSize = True
        Me.chbalarm.Location = New System.Drawing.Point(59, 282)
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
        Me.lbstatus.BackColor = System.Drawing.SystemColors.Highlight
        Me.lbstatus.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbstatus.Location = New System.Drawing.Point(13, 258)
        Me.lbstatus.Name = "lbstatus"
        Me.lbstatus.Size = New System.Drawing.Size(40, 16)
        Me.lbstatus.TabIndex = 42
        Me.lbstatus.Text = "Status"
        '
        'lbalarm
        '
        Me.lbalarm.AutoSize = True
        Me.lbalarm.BackColor = System.Drawing.SystemColors.Highlight
        Me.lbalarm.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbalarm.Location = New System.Drawing.Point(13, 281)
        Me.lbalarm.Name = "lbalarm"
        Me.lbalarm.Size = New System.Drawing.Size(39, 16)
        Me.lbalarm.TabIndex = 41
        Me.lbalarm.Text = "Alarm"
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.Highlight
        Me.btndelete.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(551, 442)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 40
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btninsert
        '
        Me.btninsert.BackColor = System.Drawing.SystemColors.Highlight
        Me.btninsert.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.Location = New System.Drawing.Point(470, 442)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(75, 23)
        Me.btninsert.TabIndex = 39
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnupdate.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(389, 442)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 38
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnselect
        '
        Me.btnselect.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnselect.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselect.Location = New System.Drawing.Point(308, 442)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(75, 23)
        Me.btnselect.TabIndex = 37
        Me.btnselect.Text = "Select"
        Me.btnselect.UseVisualStyleBackColor = False
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
        Me.lbmessage.BackColor = System.Drawing.SystemColors.Highlight
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
        'btncomport
        '
        Me.btncomport.BackColor = System.Drawing.SystemColors.Highlight
        Me.btncomport.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncomport.Location = New System.Drawing.Point(12, 168)
        Me.btncomport.Name = "btncomport"
        Me.btncomport.Size = New System.Drawing.Size(99, 23)
        Me.btncomport.TabIndex = 33
        Me.btncomport.Text = "ComPort Scan"
        Me.btncomport.UseVisualStyleBackColor = False
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
        Me.SerialPort1.PortName = "COM3"
        '
        'frmplanta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 477)
        Me.Controls.Add(Me.pnlcamera)
        Me.Controls.Add(Me.pictureBox1)
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
        Me.Controls.Add(Me.cbcomport)
        Me.Controls.Add(Me.lbcomport)
        Me.Controls.Add(Me.chbalarm)
        Me.Controls.Add(Me.tbstatus)
        Me.Controls.Add(Me.lbstatus)
        Me.Controls.Add(Me.lbalarm)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnselect)
        Me.Controls.Add(Me.tbmensagem)
        Me.Controls.Add(Me.lbmessage)
        Me.Controls.Add(Me.pbplanta)
        Me.Controls.Add(Me.btncomport)
        Me.Controls.Add(Me.pblogo)
        Me.Name = "frmplanta"
        Me.Text = "Planta"
        Me.pnlcamera.ResumeLayout(False)
        Me.pnlcamera.PerformLayout()
        CType(Me.pbcamera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pnlcamera As Panel
    Private WithEvents pbcamera As PictureBox
    Private WithEvents lbcamera As Label
    Private WithEvents pictureBox1 As PictureBox
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
    Private WithEvents cbcomport As ComboBox
    Private WithEvents lbcomport As Label
    Private WithEvents chbalarm As CheckBox
    Private WithEvents tbstatus As TextBox
    Private WithEvents lbstatus As Label
    Private WithEvents lbalarm As Label
    Private WithEvents btndelete As Button
    Private WithEvents btninsert As Button
    Private WithEvents btnupdate As Button
    Private WithEvents btnselect As Button
    Private WithEvents tbmensagem As TextBox
    Private WithEvents lbmessage As Label
    Private WithEvents pbplanta As PictureBox
    Private WithEvents btncomport As Button
    Private WithEvents pblogo As PictureBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
