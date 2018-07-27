Public Class _default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim methods As New DAL.Methods
        Dim user As New DAL.Types.User

        user.IdUser = Session("userId")

        GridViewStatus.Columns.Item(3).Visible = methods.SelectPermissionsByUserId(user).Rows(0).Item(2)
        GridViewStatus.Columns.Item(4).Visible = methods.SelectPermissionsByUserId(user).Rows(0).Item(3)
        GridViewStatus.Columns.Item(5).Visible = methods.SelectPermissionsByUserId(user).Rows(0).Item(4)
        GridViewStatus.Columns.Item(6).Visible = methods.SelectPermissionsByUserId(user).Rows(0).Item(5)
        GridViewStatus.Columns.Item(7).Visible = methods.SelectPermissionsByUserId(user).Rows(0).Item(6)
        GridViewStatus.Columns.Item(8).Visible = methods.SelectPermissionsByUserId(user).Rows(0).Item(7)
        GridViewStatus.Columns.Item(9).Visible = methods.SelectPermissionsByUserId(user).Rows(0).Item(8)
        GridViewStatus.Columns.Item(10).Visible = methods.SelectPermissionsByUserId(user).Rows(0).Item(9)
        GridViewStatus.Columns.Item(11).Visible = methods.SelectPermissionsByUserId(user).Rows(0).Item(10)
        GridViewStatus.Columns.Item(12).Visible = methods.SelectPermissionsByUserId(user).Rows(0).Item(11)


    End Sub

End Class