Imports System.Data.SqlClient
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO

Public Class frmplanta

    Dim camera As VideoCaptureDevice
    Dim bmp As Bitmap
    Dim com As IO.Ports.SerialPort = Nothing

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
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
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

        If cameras.ShowDialog() = DialogResult.OK Then
            camera = cameras.VideoDevice
            AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            camera.Start()
        End If
    End Sub

    Private Sub Captured(sender As Object, eventargs As NewFrameEventArgs)
        bmp = DirectCast(eventargs.Frame.Clone, Bitmap)
        pbcamera.Image = DirectCast(eventargs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub pbcamvig_Click(sender As Object, e As EventArgs) Handles pbcamvig.Click
        pnlcamera.Visible = Not pnlcamera.Visible
    End Sub

    Private Sub pbcamera_MouseHover(sender As Object, e As EventArgs) Handles pbcamera.MouseHover
        pbcamera.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub pbcamera_MouseLeave(sender As Object, e As EventArgs) Handles pbcamera.MouseLeave
        pbcamera.SizeMode = PictureBoxSizeMode.Normal

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
