Imports DAL

Public Class _default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub buttonSubmit_Click(sender As Object, e As EventArgs) Handles buttonSubmit.Click
        Dim methods As New DAL.Methods
        Dim user As New DAL.Types.User

        user.UserName = textBoxUsername.Text
        user.Password = textBoxPassword.Text

        Dim wrapper As New Simple3Des(user.Password)
        Dim cipherText As String = wrapper.EncryptData(user.UserName)

        user.Password = cipherText

        If (methods.UserLogin(user).Rows.Count > 0) Then
            If (methods.UserLogin(user).Rows(0).Item(2) = False) Then
                'Response.Write("User Inactive")
                ClientScript.RegisterStartupScript(Me.GetType(), "myalert", "alert('User Inactive');", True)
            Else
                Session("userId") = methods.SelectID(user).Rows(0).Item(0)
                Response.Redirect("~/FrontEnd/default.aspx")
            End If
        ElseIf (methods.AdminLogin(user).Rows.Count > 0) Then
            If (methods.AdminLogin(user).Rows(0).Item(2) = False) Then
                'Response.Write("Administrator Inactive")
                ClientScript.RegisterStartupScript(Me.GetType(), "myalert", "alert('Administrator Inactive');", True)
            Else
                Session("adminId") = methods.SelectID(user).Rows(0).Item(0)
                Response.Redirect("~/BackEnd/default.aspx")
            End If
        Else
            'Response.Write("Wrong username or password")
            ClientScript.RegisterStartupScript(Me.GetType(), "myalert", "alert('Wrong username or password');", True)
        End If






    End Sub
End Class