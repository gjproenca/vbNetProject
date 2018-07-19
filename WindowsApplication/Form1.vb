Imports System.Data.SqlClient
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO

Public Class frmplanta

    Dim Camera As VideoCaptureDevice
    Dim bmp As Bitmap
    Dim com As IO.Ports.SerialPort = Nothing

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click

        Dim cnn As New SqlConnection(dbConn)
        Dim dr As SqlDataReader
        Dim ds As DataSet
        Dim da As New OleDb.OleDbDataAdapter
        Dim ssql As String

        cnn.Open()

        ssql = "INSERT INTO DomoSys (utilizador) VALUES ('admin')"

        BDExecute(ssql)

        cnn.Close()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        Dim cnn As New SqlConnection(dbConn)
        Dim dr As SqlDataReader
        Dim ds As DataSet
        Dim da As New OleDb.OleDbDataAdapter
        Dim ssql As String

        cnn.Open()

        ssql = "UPDATE DomoSys SET mensagem = 'teste' WHERE utilizador = 'admin'"

        BDExecute(ssql)

        cnn.Close()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        Dim cnn As New SqlConnection(dbConn)
        Dim dr As SqlDataReader
        Dim ds As DataSet
        Dim da As New OleDb.OleDbDataAdapter
        Dim ssql As String

        cnn.Open()

        ssql = "DELETE FROM DomoSys WHERE id = '2'"

        BDExecute(ssql)

        cnn.Close()
    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click

        Dim cnn As New SqlConnection(dbConn)
        Dim dr As SqlDataReader
        Dim ds As DataSet
        Dim da As New OleDb.OleDbDataAdapter
        Dim ssql As String

        cnn.Open()

        ssql = "SELECT * FROM DomoSys WHERE id = '1'"

        BDExecute(ssql)

        dr = GetDataReader(ssql, cnn)

        Me.tbmensagem.Text = Convert.ToString(dr("mensagem"))

        cnn.Close()
    End Sub
End Class
