Imports DAL

Public Class register
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

        userTypes.Password = cipherText

        userMethods.InsertUser(userTypes)
    End Sub
End Class