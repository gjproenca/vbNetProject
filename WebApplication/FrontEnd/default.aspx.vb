Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Ports
Imports System.Drawing
Imports System.Windows.Forms.VisualStyles

Public Class _Default2
    Inherits System.Web.UI.Page

    Dim methods As New DAL.Methods
    Dim status As New DAL.Types.Status
    Dim user As New DAL.Types.User

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("userId") Is Nothing Then
            Session("restricted") = True
            Response.Redirect("~/default.aspx")
        End If
    End Sub

    Protected Sub buttonMessage_Click(sender As Object, e As EventArgs) Handles buttonMessage.Click
        status.IdUser = Session("userId")
        status.SoftwareStatus = methods.SelectStatus().Rows(0).Item(2)
        status.Alarm = methods.SelectStatus().Rows(0).Item(3)
        status.Fire = methods.SelectStatus().Rows(0).Item(4)
        status.Message = textBoxSendMessage.Text
        status.LightBedR1 = methods.SelectStatus().Rows(0).Item(6)
        status.LightBedR2 = methods.SelectStatus().Rows(0).Item(7)
        status.LightBedR3 = methods.SelectStatus().Rows(0).Item(8)
        status.LightLiving = methods.SelectStatus().Rows(0).Item(9)
        status.LightDining = methods.SelectStatus().Rows(0).Item(10)
        status.LightGarage = methods.SelectStatus().Rows(0).Item(11)

        methods.InsertStatus(status)

        textBoxSendMessage.Text = ""
    End Sub

End Class