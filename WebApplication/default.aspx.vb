Imports DAL

Public Class _default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub buttonSubmit_Click(sender As Object, e As EventArgs) Handles buttonSubmit.Click
        Dim userMethods As New DAL.Methods
        Dim userTypes As New DAL.Types.User

        userTypes.UserName = textBoxUsername.Text
        userTypes.Password = textBoxPassword.Text

        Dim wrapper As New Simple3Des(userTypes.Password)
        Dim cipherText As String = wrapper.EncryptData(userTypes.UserName)

        userTypes.UserName = textBoxUsername.Text
        userTypes.Password = cipherText

        If (userMethods.UserLogin1(userTypes).Rows.Count > 0) Then
            System.Console.WriteLine("Looged in")
            Response.Write("Logged IN")
        End If
    End Sub
End Class