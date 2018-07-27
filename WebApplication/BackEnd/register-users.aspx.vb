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
        user.Administrator = checkBoxAdmin.Checked

        Dim wrapper As New Simple3Des(user.Password)
        Dim cipherText As String = wrapper.EncryptData(user.UserName)

        user.Password = cipherText

        If (methods.VerifyUser(user).Rows.Count > 0) Then
            'Response.Write("<script>alert('Username already registered!')</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType, "alert", "alert('User has been registered successfully')", True)
        Else
            methods.InsertUser(user)
            methods.InsertPermissions(permission)
            'FIXME: alert not showing
            'Response.Write("<script>alert('Success!')</script>")

            ' ClientScriptManager.RegisterClientScriptBlock(Me.GetType, "alert", "alert('Database updated.')", True)

            ClientScript.RegisterClientScriptBlock(Me.GetType, "alert", "alert('User has been registered successfully')", True)


            Response.Redirect("~/BackEnd/default.aspx")
        End If
    End Sub
End Class