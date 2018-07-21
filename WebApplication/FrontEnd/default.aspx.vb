Public Class _default1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Session("admin") IsNot Nothing) Then
            Response.Write("Admin")
        ElseIf (Session("user") IsNot Nothing) Then
            Response.Write("User")
        Else
            Response.Redirect("~/default.aspx")
        End If
    End Sub

End Class