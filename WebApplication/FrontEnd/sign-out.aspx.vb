Public Class sign_out
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("userId") = Nothing
        Response.Redirect("~/default.aspx")
    End Sub

End Class