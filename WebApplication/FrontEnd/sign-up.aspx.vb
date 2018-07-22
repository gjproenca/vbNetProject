Imports DAL

Public Class register
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub buttonSubmit_Click(sender As Object, e As EventArgs) Handles buttonSubmit.Click
        Dim methods As New DAL.Methods
        Dim user As New DAL.Types.User
        Dim permission As New DAL.Types.Permission

        user.UserName = textBoxUsername.Text
        user.Password = textBoxPassword.Text

        Dim wrapper As New Simple3Des(user.Password)
        Dim cipherText As String = wrapper.EncryptData(user.UserName)

        user.Password = cipherText

        methods.InsertUser(user)
        methods.InsertPermissions(permission)

        Response.Redirect("~/FrontEnd/default.aspx")
    End Sub
End Class