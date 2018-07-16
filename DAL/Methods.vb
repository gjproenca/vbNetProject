Imports System.Data.SqlClient
Imports DAL.Types
Imports Microsoft.VisualBasic

Public Class Methods

    Private conn As SqlConnection = New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=DomoSys;Integrated Security=True")


    Public Function SelectUsers() As DataTable
        Dim comando As SqlDataAdapter = New SqlDataAdapter("SELECT IdUser, UserName, Password, Administrator FROM Users", conn)
        Dim tabela As DataTable = New DataTable()
        comando.Fill(tabela)
        Return tabela

    End Function

    Public Sub InsertUser(ByVal U As User)
        Dim comm_insert As SqlCommand = New SqlCommand()
        comm_insert.Connection = conn
        comm_insert.CommandType = CommandType.Text
        comm_insert.CommandText = "INSERT INTO [Users]([UserName], [Password], [Administrator]) VALUES(@user, @password, @administrator)"
        comm_insert.Parameters.AddWithValue("@user", U.UserName)
        comm_insert.Parameters.AddWithValue("@password", U.Password)
        comm_insert.Parameters.AddWithValue("@administrator", U.Administrator)
        conn.Open()
        comm_insert.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub UpdateUser(ByVal U As User)
        Dim comm_update As SqlCommand = New SqlCommand()
        comm_update.Connection = conn
        comm_update.CommandType = CommandType.Text
        comm_update.CommandText = "UPDATE INTO [Users]([UserName], [Password], [Administrator]) VALUES(@user, @password, @administrator)"
        comm_update.Parameters.AddWithValue("@user", U.UserName)
        comm_update.Parameters.AddWithValue("@password", U.Password)
        comm_update.Parameters.AddWithValue("@administrator", U.Administrator)
        conn.Open()
        comm_update.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub DeleteUser(ByVal U As User)
        Dim comm_delete As SqlCommand = New SqlCommand()
        comm_delete.Connection = conn
        comm_delete.CommandType = CommandType.Text
        comm_delete.CommandText = "DELETE FROM [Users]  WHERE  [IdUser] = '@IdUser'"
        conn.Open()
        comm_delete.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function SelectStatus() As DataTable
        Dim comando As SqlDataAdapter = New SqlDataAdapter("SELECT IdStatus, IdUser, SoftwareStatus, Alarm, Fire, Message, LightBedR1, LightBedR2, LightBedR3, LightLiving, LightDining, LightGarage, TimeStamp FROM Status", conn)
        Dim tabela As DataTable = New DataTable()
        comando.Fill(tabela)
        Return tabela
    End Function

    'Public Function InsertStatus(ByVal S As Status)
    '    Dim comm_insert As SqlCommand = New SqlCommand()
    '    comm_insert.Connection = conn
    '    comm_insert.CommandType = CommandType.Text
    '    comm_insert.CommandText = "INSERT INTO [Status]([IdUser], [SoftwareStatus], [Alarm], [Fire], [Message], [LightBedR1], [LightBedR2], [LightBedR3], [LightLiving], [LightDining], [LightGarage], [TimeStamp] ) VALUES(@nome, @paisOrigem, @premioNobel, @resumoObra)"
    '    comm_insert.Parameters.AddWithValue("@IdUser", U.UserName)
    '    comm_insert.Parameters.AddWithValue("@password", U.Password)
    '    comm_insert.Parameters.AddWithValue("@administrator", U.Administrator)
    '    conn.Open()
    '    comm_insert.ExecuteNonQuery()
    '    conn.Close()
    'End Function



    'Public Sub InsertStatus(ByVal S As Status)
    '    Dim comm_insert As SqlCommand = New SqlCommand()
    '    comm_insert.Connection = conn
    '    comm_insert.CommandType = CommandType.Text
    '    comm_insert.CommandText = "INSERT INTO [Status]([IdUser], [SoftwareStatus], [Alarm], [Fire], [Message], [LightBedR1], [LightBedR2], [LightBedR3], [LightLiving], [LightDining], [LightGarage], [TimeStamp] ) VALUES(@nome, @paisOrigem, @premioNobel, @resumoObra)"
    '    comm_insert.Parameters.AddWithValue("@nome", A.Nome)
    '    comm_insert.Parameters.AddWithValue("@paisOrigem", A.PaisOrigem)
    '    comm_insert.Parameters.AddWithValue("@premioNobel", A.PremioNobel)
    '    comm_insert.Parameters.AddWithValue("@resumoObra", A.ResumoObra)
    '    conn.Open()
    '    comm_insert.ExecuteNonQuery()
    '    conn.Close()
    'End Sub





End Class
