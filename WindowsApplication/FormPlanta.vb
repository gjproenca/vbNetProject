Imports System.Data.SqlClient
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Imports System.IO.Ports

Public Class frmplanta

    Dim camera As VideoCaptureDevice
    Dim bmp As Bitmap
    Dim com As IO.Ports.SerialPort = Nothing
    Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

    Dim methods As New DAL.Methods
    Dim status As New DAL.Types.Status

    Private Sub frmplanta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer.Enabled = True
        timer.Start()

        LoadFields()
    End Sub

    Private Sub LoadFields()
        'chbalarm.Checked = methods.SelectStatus.Rows(0).Item(3).ToString()
        pbfire.Visible = methods.SelectStatus.Rows(0).Item(4).ToString()

        If methods.SelectStatus.Rows(0).Item(11) = True Then
            pbgaron.Visible = True
            pbgaroff.Visible = False
        Else
            pbgaron.Visible = False
            pbgaroff.Visible = True
        End If
        '--------------------------
        If methods.SelectStatus.Rows(0).Item(10) = True Then
            pbdiningon.Visible = True
            pbdiningoff.Visible = False
        Else
            pbdiningon.Visible = False
            pbdiningoff.Visible = True
        End If
        '---------------------------
        If methods.SelectStatus.Rows(0).Item(9) = True Then
            pblivingon.Visible = True
            pblivingoff.Visible = False
        Else
            pblivingon.Visible = False
            pblivingoff.Visible = True
        End If
        '---------------------------
        If methods.SelectStatus.Rows(0).Item(6) = True Then
            pbroom1on.Visible = True
            pbroom1off.Visible = False
        Else
            pbroom1on.Visible = False
            pbroom1off.Visible = True
        End If
        '---------------------------
        If methods.SelectStatus.Rows(0).Item(7) = True Then
            pbroom2on.Visible = True
            pbroom2off.Visible = False
        Else
            pbroom2on.Visible = False
            pbroom2off.Visible = True
        End If
        '----------------------------
        If methods.SelectStatus.Rows(0).Item(8) = True Then
            pbroom3on.Visible = True
            pbroom3off.Visible = False
        Else
            pbroom3on.Visible = False
            pbroom3off.Visible = True
        End If
        '---------------------------
        If methods.SelectStatus.Rows(0).Item(2) = True Then
            btstatus.Text = "Status OFF"
        Else
            btstatus.Text = "Status ON"
        End If
        '----------------------------
        If methods.SelectStatus.Rows(0).Item(4) = True Then
            btfire.Text = "Fire OFF"
        Else
            btfire.Text = "Fire ON"
        End If
        '---View Messages
        tbmensagem.Text = ""
        For Each row As DataRow In methods.SelectMessages().Rows
            tbmensagem.Text &= row.Item("TimeStamp") & " - " & row.Item("Message") & "" & Environment.NewLine
        Next row

    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs)
        SerialPort1.Open()
        SerialPort1.Write("1")
        SerialPort1.Close()

    End Sub

    Private Sub Captured(sender As Object, eventargs As NewFrameEventArgs)
        bmp = DirectCast(eventargs.Frame.Clone, Bitmap)
        pbcamera.Image = DirectCast(eventargs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub pbcamvig_Click(sender As Object, e As EventArgs) Handles pbcamvig.Click
        pbcamera.Visible = Not pbcamera.Visible

        If camera Is Nothing Then
            If cameras.ShowDialog() = DialogResult.OK Then
                camera = cameras.VideoDevice
                AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf Captured)
                camera.Start()
            End If
        ElseIf pbcamera.Visible = False Then
            camera.Stop()
        Else
            camera.Start()
        End If
    End Sub

    Private Sub pbcamera_MouseHover(sender As Object, e As EventArgs)
        pbcamera.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub pbcamera_MouseLeave(sender As Object, e As EventArgs)
        pbcamera.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub btnconnect_Click(sender As Object, e As EventArgs)
        'com port
        SerialPort1.Close()
        SerialPort1.PortName = "COM3"
        SerialPort1.BaudRate = 9600
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default
    End Sub

    Private Sub chbgarage_CheckedChanged(sender As Object, e As EventArgs)
        LoadFields()
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        LoadFields()
    End Sub

    Private Sub pbroom2on_Click(sender As Object, e As EventArgs) Handles pbroom2on.Click
        status.LightBedR2 = Not methods.SelectStatus.Rows(0).Item(7)
        methods.UpdateLightBedR2(status)
        LoadFields()
    End Sub

    Private Sub pbroom2off_Click(sender As Object, e As EventArgs) Handles pbroom2off.Click
        status.LightBedR2 = Not methods.SelectStatus.Rows(0).Item(7)
        methods.UpdateLightBedR2(status)
        LoadFields()
    End Sub

    Private Sub pblivingoff_Click(sender As Object, e As EventArgs) Handles pblivingoff.Click
        status.LightLiving = Not methods.SelectStatus.Rows(0).Item(9)
        methods.UpdateLightLiving(status)
        LoadFields()
    End Sub

    Private Sub pblivingon_Click(sender As Object, e As EventArgs) Handles pblivingon.Click
        status.LightLiving = Not methods.SelectStatus.Rows(0).Item(9)
        methods.UpdateLightLiving(status)
        LoadFields()
    End Sub

    Private Sub pbroom3off_Click(sender As Object, e As EventArgs) Handles pbroom3off.Click
        status.LightBedR3 = Not methods.SelectStatus.Rows(0).Item(8)
        methods.UpdateLightBedR3(status)
        LoadFields()
    End Sub

    Private Sub pbroom3on_Click(sender As Object, e As EventArgs) Handles pbroom3on.Click
        status.LightBedR3 = Not methods.SelectStatus.Rows(0).Item(8)
        methods.UpdateLightBedR3(status)
        LoadFields()
    End Sub

    Private Sub pbdiningoff_Click(sender As Object, e As EventArgs) Handles pbdiningoff.Click
        status.LightDining = Not methods.SelectStatus.Rows(0).Item(10)
        methods.UpdateLightDining(status)
        LoadFields()
    End Sub

    Private Sub pbdiningon_Click(sender As Object, e As EventArgs) Handles pbdiningon.Click
        status.LightDining = Not methods.SelectStatus.Rows(0).Item(10)
        methods.UpdateLightDining(status)
        LoadFields()
    End Sub

    Private Sub pbroom1on_Click(sender As Object, e As EventArgs) Handles pbroom1on.Click
        status.LightBedR1 = Not methods.SelectStatus.Rows(0).Item(6)
        methods.UpdateLightBedR1(status)
        LoadFields()
    End Sub

    Private Sub pbroom1off_Click(sender As Object, e As EventArgs) Handles pbroom1off.Click
        status.LightBedR1 = Not methods.SelectStatus.Rows(0).Item(6)
        methods.UpdateLightBedR1(status)
        LoadFields()
    End Sub

    Private Sub pbgaron_Click(sender As Object, e As EventArgs) Handles pbgaron.Click
        status.LightGarage = Not methods.SelectStatus.Rows(0).Item(11)
        methods.UpdateLightGarage(status)
        LoadFields()
    End Sub

    Private Sub pbgaroff_Click(sender As Object, e As EventArgs) Handles pbgaroff.Click
        status.LightGarage = Not methods.SelectStatus.Rows(0).Item(11)
        methods.UpdateLightGarage(status)
        LoadFields()
    End Sub

    Private Sub btstatus_Click(sender As Object, e As EventArgs) Handles btstatus.Click
        status.SoftwareStatus = Not methods.SelectStatus.Rows(0).Item(2)
        methods.UpdateSoftwareStatus(status)
        LoadFields()
    End Sub

    Private Sub btfire_Click(sender As Object, e As EventArgs) Handles btfire.Click
        status.Fire = Not methods.SelectStatus.Rows(0).Item(4)
        methods.UpdateStatusFire(status)
        LoadFields()
    End Sub

    Private Sub btsendmessage_Click(sender As Object, e As EventArgs) Handles btsendmessage.Click
        status.IdUser = 1
        status.SoftwareStatus = methods.SelectStatus.Rows(0).Item(2)
        status.Alarm = methods.SelectStatus.Rows(0).Item(3)
        status.Fire = methods.SelectStatus.Rows(0).Item(4)
        status.Message = tbsendmessage.Text
        status.LightBedR1 = methods.SelectStatus.Rows(0).Item(6)
        status.LightBedR2 = methods.SelectStatus.Rows(0).Item(7)
        status.LightBedR3 = methods.SelectStatus.Rows(0).Item(8)
        status.LightLiving = methods.SelectStatus.Rows(0).Item(9)
        status.LightDining = methods.SelectStatus.Rows(0).Item(10)
        status.LightGarage = methods.SelectStatus.Rows(0).Item(11)

        methods.InsertStatus(status)

        LoadFields()
    End Sub
End Class
