Public Class control_panel_iframe
    Inherits System.Web.UI.Page

    Dim methods As New DAL.Methods
    Dim status As New DAL.Types.Status

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
#Region "Load Fields"
        If methods.SelectStatus().Rows(0).Item(2) = True Then
            buttonStatus.Text = "Status OFF"
            checkBoxStatus.Checked = True
        Else
            buttonStatus.Text = "Status ON"
            checkBoxStatus.Checked = False
        End If

        If methods.SelectStatus().Rows(0).Item(3) = True Then
            buttonAlarm.Text = "Alarm OFF"
            checkBoxAlarm.Checked = True
        Else
            buttonAlarm.Text = "Alarm ON"
            checkBoxAlarm.Checked = False
        End If

        If methods.SelectStatus().Rows(0).Item(4) = True Then
            buttonFire.Text = "Fire OFF"
            checkBoxFire.Checked = True
        Else
            buttonFire.Text = "Fire ON"
            checkBoxFire.Checked = False
        End If

        If methods.SelectStatus().Rows(0).Item(6) = True Then
            buttonLightBedR1.Text = "BedRoom1 OFF"
            checkBoxLightBedR1.Checked = True
        Else
            buttonLightBedR1.Text = "BedRoom1 ON"
            checkBoxLightBedR1.Checked = False
        End If

        If methods.SelectStatus().Rows(0).Item(7) = True Then
            buttonLightBedR2.Text = "BedRoom2 OFF"
            checkBoxLightBedR2.Checked = True
        Else
            buttonLightBedR2.Text = "BedRoom2 ON"
            checkBoxLightBedR2.Checked = False
        End If

        If methods.SelectStatus().Rows(0).Item(8) = True Then
            buttonLightBedR3.Text = "BedRoom3 OFF"
            checkBoxLightBedR3.Checked = True
        Else
            buttonLightBedR3.Text = "BedRoom3 ON"
            checkBoxLightBedR3.Checked = False
        End If

        If methods.SelectStatus().Rows(0).Item(9) = True Then
            buttonLiving.Text = "LivingRoom OFF"
            checkBoxLiving.Checked = True
        Else
            buttonLiving.Text = "LivingRoom ON"
            checkBoxLiving.Checked = False
        End If

        If methods.SelectStatus().Rows(0).Item(10) = True Then
            buttonDining.Text = "DiningRoom OFF"
            checkBoxDining.Checked = True
        Else
            buttonDining.Text = "DiningRoom ON"
            checkBoxDining.Checked = False
        End If

        If methods.SelectStatus().Rows(0).Item(11) = True Then
            buttonGarage.Text = "Garage OFF"
            checkBoxGarage.Checked = True
        Else
            buttonGarage.Text = "Garage ON"
            checkBoxGarage.Checked = False
        End If
#End Region
    End Sub

    Protected Sub buttonStatus_Click(sender As Object, e As EventArgs) Handles buttonStatus.Click
        status.SoftwareStatus = Not methods.SelectStatus().Rows(0).Item(2)

        methods.UpdateSoftwareStatus(status)

        Response.Redirect("~/BackEnd/iframe-control-panel.aspx")
    End Sub

    Protected Sub buttonAlarm_Click(sender As Object, e As EventArgs) Handles buttonAlarm.Click
        status.Alarm = Not methods.SelectStatus().Rows(0).Item(3)

        methods.UpdateAlarm(status)

        Response.Redirect("~/BackEnd/iframe-control-panel.aspx")
    End Sub

    Protected Sub buttonSoftwareStatus_Click(sender As Object, e As EventArgs) Handles buttonFire.Click
        status.Fire = Not methods.SelectStatus().Rows(0).Item(4)

        methods.UpdateStatusFire(status)

        Response.Redirect("~/BackEnd/iframe-control-panel.aspx")
    End Sub

    Protected Sub buttonLightBedR1_Click(sender As Object, e As EventArgs) Handles buttonLightBedR1.Click
        status.LightBedR1 = Not methods.SelectStatus().Rows(0).Item(6)

        methods.UpdateLightBedR1(status)

        Response.Redirect("~/BackEnd/iframe-control-panel.aspx")
    End Sub

    Protected Sub buttonLightBedR2_Click(sender As Object, e As EventArgs) Handles buttonLightBedR2.Click
        status.LightBedR2 = Not methods.SelectStatus().Rows(0).Item(7)

        methods.UpdateLightBedR2(status)

        Response.Redirect("~/BackEnd/iframe-control-panel.aspx")
    End Sub

    Protected Sub buttonLightBedR3_Click(sender As Object, e As EventArgs) Handles buttonLightBedR3.Click
        status.LightBedR3 = Not methods.SelectStatus().Rows(0).Item(8)

        methods.UpdateLightBedR3(status)

        Response.Redirect("~/BackEnd/iframe-control-panel.aspx")
    End Sub

    Protected Sub buttonLiving_Click(sender As Object, e As EventArgs) Handles buttonLiving.Click
        status.LightLiving = Not methods.SelectStatus().Rows(0).Item(9)

        methods.UpdateLightLiving(status)

        Response.Redirect("~/BackEnd/iframe-control-panel.aspx")
    End Sub

    Protected Sub buttonDining_Click(sender As Object, e As EventArgs) Handles buttonDining.Click
        status.LightDining = Not methods.SelectStatus().Rows(0).Item(10)

        methods.UpdateLightDining(status)

        Response.Redirect("~/BackEnd/iframe-control-panel.aspx")
    End Sub

    Protected Sub buttonGarage_Click(sender As Object, e As EventArgs) Handles buttonGarage.Click
        status.LightGarage = Not methods.SelectStatus().Rows(0).Item(11)

        methods.UpdateLightGarage(status)

        Response.Redirect("~/BackEnd/iframe-control-panel.aspx")
    End Sub
End Class