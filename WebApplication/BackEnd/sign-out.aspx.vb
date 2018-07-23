Public Class sign_out1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("admin") = Nothing
        Response.Redirect("~/default.aspx")
    End Sub

End Class