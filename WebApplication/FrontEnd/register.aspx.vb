Public Class register
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub buttonSubmit_Click(sender As Object, e As EventArgs) Handles buttonSubmit.Click
        Dim methods As New DAL.Methods
        Dim user As New DAL.Types.User

        user.UserName = textBoxUsername.Text
        user.Password = textBoxPassword.Text

        methods.InsertUser(user)
    End Sub
End Class