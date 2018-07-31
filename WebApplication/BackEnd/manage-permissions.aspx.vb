Public Class manage_users
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("adminId") Is Nothing Then
            Session("restricted") = True
            Response.Redirect("~/default.aspx")
        End If
    End Sub

End Class