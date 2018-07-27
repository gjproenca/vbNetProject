Imports System.Windows.Forms
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
            ClientScript.RegisterStartupScript(Me.GetType(), "myalert", "alert('Username already registered');", True)
        Else
            Try
                methods.InsertUser(user)
                methods.InsertPermissions(permission)
                ClientScript.RegisterStartupScript(Me.GetType(), "myalert", "alert('User has been registered successfully');window.location.href='default.aspx'", True)
            Catch ex As Exception
                ' MsgBox("Can't load Web page" & vbCrLf & ex.Message)
            End Try
        End If
    End Sub
End Class