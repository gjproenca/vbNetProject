Imports System.Data.SqlClient

Public Class camera
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cmd As SqlCommand = New SqlCommand("SELECT Image FROM Camera")
        Dim dt As DataTable = GetData(cmd)

        If dt IsNot Nothing Then
            Dim bytes() As Byte = CType(dt.Rows(0)("Image"), Byte())

            Response.Buffer = True
            Response.Charset = ""
            Response.Cache.SetCacheability(HttpCacheability.NoCache)
            Response.BinaryWrite(bytes)
            Response.Flush()
            Response.End()
        End If
    End Sub

    Public Function GetData(ByVal cmd As SqlCommand) As DataTable
        Dim dt As New DataTable
        Dim con As New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=DomoSys;Integrated Security=True")
        Dim sda As New SqlDataAdapter
        cmd.CommandType = CommandType.Text
        cmd.Connection = con

        Try
            con.Open()
            sda.SelectCommand = cmd
            sda.Fill(dt)
            Return dt
        Catch ex As Exception
            Response.Write(ex.Message)
            Return Nothing
        Finally
            con.Close()
            sda.Dispose()
            con.Dispose()
        End Try
    End Function
End Class