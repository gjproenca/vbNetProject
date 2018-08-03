Imports System.Data.SqlClient
Imports System.IO.Ports
Imports System.Threading
Imports AForge.Video
Imports AForge.Video.DirectShow


Public Class frmplanta

    Dim camera As VideoCaptureDevice
    Dim bmp As Bitmap
    Dim com As IO.Ports.SerialPort = Nothing
    Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

    Dim methods As New DAL.Methods
    Dim status As New DAL.Types.Status

    Dim tempsoftwarestatus As Boolean
    Dim tempalarm As Boolean
    Dim tempfire As Boolean
    Dim templightbed1 As Boolean
    Dim templightbed2 As Boolean
    Dim templightbed3 As Boolean
    Dim templightliving As Boolean
    Dim templightdining As Boolean
    Dim templightgarage As Boolean

    Dim isOpen As Boolean = False
    Dim isShowing As Boolean = False

    Private Sub frmplanta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dialog camera
        While cameras.ShowDialog() <> DialogResult.OK
            MessageBox.Show("Please choose your camera!", "Error!", MessageBoxButtons.OK)
        End While

        'Load camera
        While isShowing = False
            Try
                pbcamera.Visible = Not pbcamera.Visible

                If camera Is Nothing Then
                    camera = cameras.VideoDevice
                    AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf Captured)
                    camera.Start()
                End If
                isShowing = True
            Catch ex As Exception

            End Try
        End While

        'Initialize temp variables
        tempsoftwarestatus = methods.SelectStatus.Rows(0).Item(2)
        tempalarm = methods.SelectStatus.Rows(0).Item(3)
        tempfire = methods.SelectStatus.Rows(0).Item(4)
        templightbed1 = methods.SelectStatus.Rows(0).Item(6)
        templightbed2 = methods.SelectStatus.Rows(0).Item(7)
        templightbed3 = methods.SelectStatus.Rows(0).Item(8)
        templightliving = methods.SelectStatus.Rows(0).Item(9)
        templightdining = methods.SelectStatus.Rows(0).Item(10)
        templightgarage = methods.SelectStatus.Rows(0).Item(11)

        'com port
        SerialPort1.Close()
        SerialPort1.PortName = "COM3"
        SerialPort1.BaudRate = 9600
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default

        While isOpen = False
            Try
                SerialPort1.Open()
                isOpen = True
            Catch ex As Exception
                MessageBox.Show("Couldn't send the information to arduino, please pair the ports, COM3 for this aplication and another COM Port for the arduino!", "Error!", MessageBoxButtons.OK)
            End Try
        End While

        timer.Enabled = True
        timer.Start()

        LoadFields()
    End Sub

    Private Sub LoadFields()
        pbfire.Visible = methods.SelectStatus.Rows(0).Item(4).ToString()

        If methods.SelectStatus.Rows(0).Item(2) = True Then
            btstatus.Text = "Status OFF"
        Else
            btstatus.Text = "Status ON"
        End If
        '--------------------------------------------------
        If methods.SelectStatus.Rows(0).Item(4) = True Then
            btfire.Text = "Fire OFF"
        Else
            btfire.Text = "Fire ON"
        End If
        '--------------------------------------------------
        '---View Messages
        tbmensagem.Text = ""
        For Each row As DataRow In methods.SelectMessages().Rows
            tbmensagem.Text &= row.Item("TimeStamp") & " - " & row.Item("Message") & "" & Environment.NewLine
        Next row
        '--------------------------------------------------
        If methods.SelectStatus.Rows(0).Item(6) = True Then
            pbroom1on.Visible = True
            pbroom1off.Visible = False
        Else
            pbroom1on.Visible = False
            pbroom1off.Visible = True
        End If
        '--------------------------------------------------
        If methods.SelectStatus.Rows(0).Item(7) = True Then
            pbroom2on.Visible = True
            pbroom2off.Visible = False
        Else
            pbroom2on.Visible = False
            pbroom2off.Visible = True
        End If
        '--------------------------------------------------
        If methods.SelectStatus.Rows(0).Item(8) = True Then
            pbroom3on.Visible = True
            pbroom3off.Visible = False
        Else
            pbroom3on.Visible = False
            pbroom3off.Visible = True
        End If
        '--------------------------------------------------
        If methods.SelectStatus.Rows(0).Item(9) = True Then
            pblivingon.Visible = True
            pblivingoff.Visible = False
        Else
            pblivingon.Visible = False
            pblivingoff.Visible = True
        End If
        '--------------------------------------------------
        If methods.SelectStatus.Rows(0).Item(10) = True Then
            pbdiningon.Visible = True
            pbdiningoff.Visible = False
        Else
            pbdiningon.Visible = False
            pbdiningoff.Visible = True
        End If
        '--------------------------------------------------
        If methods.SelectStatus.Rows(0).Item(11) = True Then
            pbgaron.Visible = True
            pbgaroff.Visible = False
        Else
            pbgaron.Visible = False
            pbgaroff.Visible = True
        End If

        'Load arduino information
        Try
            If SerialPort1.ReadBufferSize > 0 And Me.SerialPort1.IsOpen = True And SerialPort1.BytesToRead > 0 Then
                tbmsgtest.Text = SerialPort1.ReadExisting()
            End If
        Catch ex As Exception
            MessageBox.Show("Couldn't send the information to arduino, please pair the ports, COM3 for this aplication and another COM Port for the arduino!", "Error!", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        LoadFields()
        sendInformationArduino()

        'Camera
        Try
            pbcamera.Image.Save("camera.jpg", Imaging.ImageFormat.Jpeg)
            Console.WriteLine("Saved image to Folder")
        Catch ex As Exception

        End Try

        Try
            Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=DomoSys;Integrated Security=True")
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "UPDATE Camera SET Image = @image"
            cmd.Parameters.AddWithValue("image", SqlDbType.VarBinary).Value = IO.File.ReadAllBytes("camera.jpg")
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            cmd.Parameters.Clear()

            Console.WriteLine("Saved image to DB")
        Catch ex As Exception
            Console.WriteLine("Couldn't save image to DB")
        End Try

        'Insert arduino information
        methods.UpdateArduino(tbmsgtest.Text)
    End Sub

    Private Sub sendInformationArduino()
        Dim sendmessage As Boolean = False

        If tempsoftwarestatus.ToString() Like methods.SelectStatus.Rows(0).Item(2).ToString() = False Then
            tempsoftwarestatus = Not tempsoftwarestatus
            sendmessage = True
        End If

        If tempalarm.ToString() Like methods.SelectStatus.Rows(0).Item(3).ToString() = False Then
            tempalarm = Not tempalarm
            sendmessage = True
        End If

        If tempfire.ToString() Like methods.SelectStatus.Rows(0).Item(4).ToString() = False Then
            tempfire = Not tempfire
            sendmessage = True
        End If

        If templightbed1.ToString() Like methods.SelectStatus.Rows(0).Item(6).ToString() = False Then
            templightbed1 = Not templightbed1
            sendmessage = True
        End If

        If templightbed2.ToString() Like methods.SelectStatus.Rows(0).Item(7).ToString() = False Then
            templightbed2 = Not templightbed2
            sendmessage = True
        End If

        If templightbed3.ToString() Like methods.SelectStatus.Rows(0).Item(8).ToString() = False Then
            templightbed3 = Not templightbed3
            sendmessage = True
        End If

        If templightliving.ToString() Like methods.SelectStatus.Rows(0).Item(9).ToString() = False Then
            templightliving = Not templightliving
            sendmessage = True
        End If

        If templightdining.ToString() Like methods.SelectStatus.Rows(0).Item(10).ToString() = False Then
            templightdining = Not templightdining
            sendmessage = True
        End If

        If templightgarage.ToString() Like methods.SelectStatus.Rows(0).Item(11).ToString() = False Then
            templightgarage = Not templightgarage
            sendmessage = True
        End If

        If sendmessage = True Then
            Try
                SerialPort1.Write("1")
                SerialPort1.Write("2")
                Threading.Thread.Sleep(100)
                SerialPort1.Write("0")

                Console.WriteLine("led")
            Catch ex As Exception
                MessageBox.Show("Couldn't send the information to arduino, please pair the ports, COM3 for this aplication and another COM Port for the arduino!", "Error!", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    'Camera---
    Private Sub Captured(sender As Object, eventargs As NewFrameEventArgs)
        bmp = DirectCast(eventargs.Frame.Clone, Bitmap)
        pbcamera.Image = DirectCast(eventargs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub pbcamera_MouseHover(sender As Object, e As EventArgs)
        pbcamera.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub pbcamera_MouseLeave(sender As Object, e As EventArgs)
        pbcamera.SizeMode = PictureBoxSizeMode.StretchImage
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
        status.IdUser = 2
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

        tbsendmessage.Text = ""

        LoadFields()
    End Sub

    Private Sub frmplanta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        camera = cameras.VideoDevice
        camera.Stop()
    End Sub
End Class
