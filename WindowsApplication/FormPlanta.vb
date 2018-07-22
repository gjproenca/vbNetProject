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

    Private Sub frmplanta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If cameras.ShowDialog() = DialogResult.OK Then
        '    camera = cameras.VideoDevice
        '    AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf Captured)
        'End If

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

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        SerialPort1.Open()
        SerialPort1.Write("1")
        SerialPort1.Close()
        SerialPort1.Open()
        SerialPort1.Write("on")
        SerialPort1.Close()

        'Dim cnn As New SqlConnection(dbConn)
        'Dim dr As SqlDataReader
        'Dim ds As DataSet
        'Dim da As New OleDb.OleDbDataAdapter
        'Dim ssql As String

        'cnn.Open()

        'ssql = "INSERT INTO DomoSys (utilizador) VALUES ('admin')"

        'BDExecute(ssql)

        'cnn.Close()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        'Dim cnn As New SqlConnection(dbConn)
        'Dim dr As SqlDataReader
        'Dim ds As DataSet
        'Dim da As New OleDb.OleDbDataAdapter
        'Dim ssql As String

        'cnn.Open()

        'ssql = "UPDATE DomoSys SET mensagem = 'teste' WHERE utilizador = 'admin'"

        'BDExecute(ssql)

        'cnn.Close()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        'Dim cnn As New SqlConnection(dbConn)
        'Dim dr As SqlDataReader
        'Dim ds As DataSet
        'Dim da As New OleDb.OleDbDataAdapter
        'Dim ssql As String

        'cnn.Open()

        'ssql = "DELETE FROM DomoSys WHERE id = '2'"

        'BDExecute(ssql)

        'cnn.Close()
    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        'Dim cnn As New SqlConnection(dbConn)
        'Dim dr As SqlDataReader
        'Dim ds As DataSet
        'Dim da As New OleDb.OleDbDataAdapter
        'Dim ssql As String

        'cnn.Open()

        'ssql = "SELECT * FROM DomoSys WHERE id = '1'"

        'BDExecute(ssql)

        'dr = GetDataReader(ssql, cnn)

        'Me.tbmensagem.Text = Convert.ToString(dr("mensagem"))

        'cnn.Close()
    End Sub

    Private Sub lbcamera_Click(sender As Object, e As EventArgs) Handles lbcamera.Click
        'Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

        'If cameras.ShowDialog() = DialogResult.OK Then
        '    camera = cameras.VideoDevice
        '    AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf Captured)
        '    camera.Start()
        'End If
    End Sub

    Private Sub Captured(sender As Object, eventargs As NewFrameEventArgs)
        bmp = DirectCast(eventargs.Frame.Clone, Bitmap)
        pbcamera.Image = DirectCast(eventargs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub pbcamvig_Click(sender As Object, e As EventArgs) Handles pbcamvig.Click
        pnlcamera.Visible = Not pnlcamera.Visible

        If pnlcamera.Visible = False Then
            camera.Stop()
        ElseIf camera Is Nothing Then
            If cameras.ShowDialog() = DialogResult.OK Then
                camera = cameras.VideoDevice
                AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf Captured)
                camera.Start()
            End If
        Else
            camera.Start()
        End If
    End Sub

    Private Sub pbcamera_MouseHover(sender As Object, e As EventArgs) Handles pbcamera.MouseHover
        pbcamera.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub pbcamera_MouseLeave(sender As Object, e As EventArgs) Handles pbcamera.MouseLeave
        pbcamera.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub btncomport_Click(sender As Object, e As EventArgs) Handles btncomport.Click
        cbcomport.Items.Clear()

        For Each sp As String In My.Computer.Ports.SerialPortNames
            cbcomport.Items.Add(sp)
        Next

        cbcomport.SelectedIndex = 0
    End Sub

    Private Sub cbcomport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcomport.SelectedIndexChanged
        btncomread.Enabled = True
        btncomwrite.Enabled = True
    End Sub
End Class
