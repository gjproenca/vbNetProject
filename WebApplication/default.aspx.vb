Imports DAL

Public Class _default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub buttonSubmit_Click(sender As Object, e As EventArgs) Handles buttonSubmit.Click
        Dim userMethods As New DAL.Methods
        Dim user As New DAL.Types.User

        user.UserName = textBoxUsername.Text
        user.Password = textBoxPassword.Text

        Dim wrapper As New Simple3Des(user.Password)
        Dim cipherText As String = wrapper.EncryptData(user.UserName)

        user.Password = cipherText

        If (userMethods.UserLogin(user).Rows.Count > 0) Then
            Session("userId") = userMethods.SelectID(user).Rows(0).Item(0)
            Response.Redirect("~/FrontEnd/default.aspx")
        ElseIf (userMethods.AdminLogin(user).Rows.Count > 0) Then
            Session("adminId") = userMethods.SelectID(user).Rows(0).Item(0)
            Response.Redirect("~/BackEnd/default.aspx")
        Else
            Response.Write("Wrong username or password")
        End If





    End Sub
End Class