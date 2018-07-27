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

    Private Sub frmplanta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFields()
    End Sub

    Private Sub LoadFields()
        tbstatus.Text = methods.SelectStatus.Rows(0).Item(2).ToString()
        chbalarm.Checked = methods.SelectStatus.Rows(0).Item(3).ToString()
        pbfire.Visible = methods.SelectStatus.Rows(0).Item(4).ToString()
        tbmensagem.Text = methods.SelectStatus.Rows(0).Item(5).ToString()
        chbroom1.Checked = methods.SelectStatus.Rows(0).Item(6).ToString()
        chbroom2.Checked = methods.SelectStatus.Rows(0).Item(7).ToString()
        chbroom3.Checked = methods.SelectStatus.Rows(0).Item(8).ToString()
        chbliving.Checked = methods.SelectStatus.Rows(0).Item(9).ToString()
        chbdining.Checked = methods.SelectStatus.Rows(0).Item(10).ToString()
        chbgarage.Checked = methods.SelectStatus.Rows(0).Item(11).ToString()

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

    Private Sub cbcomport_SelectedIndexChanged(sender As Object, e As EventArgs)
        btncomread.Enabled = True
        btncomwrite.Enabled = True
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

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click


    End Sub

    Private Sub tbstatus_TextChanged(sender As Object, e As EventArgs) Handles tbstatus.TextChanged

    End Sub
End Class
