Imports System.Data.SqlClient
Imports DAL.Types
Imports Microsoft.VisualBasic

Public Class Methods

    Private conn As SqlConnection = New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=DomoSys;Integrated Security=True")

    Public Function UserLogin(ByVal U As User) As DataTable
        Dim comando As SqlDataAdapter = New SqlDataAdapter("SELECT UserName, Password, Active FROM Users WHERE UserName LIKE '" + U.UserName + "' AND Password LIKE '" + U.Password + "' AND Administrator = 0", conn)
        Dim tabela As DataTable = New DataTable()
        comando.Fill(tabela)
        Return tabela
    End Function

    Public Function AdminLogin(ByVal U As User) As DataTable
        Dim comando As SqlDataAdapter = New SqlDataAdapter("SELECT UserName, Password, Active FROM Users WHERE UserName LIKE '" + U.UserName + "' AND Password LIKE '" + U.Password + "' AND Administrator = 1", conn)
        Dim tabela As DataTable = New DataTable()
        comando.Fill(tabela)
        Return tabela
    End Function

    Public Function SelectMessages() As DataTable
        Dim comando As SqlDataAdapter = New SqlDataAdapter("SELECT Message, TimeStamp FROM Status ORDER BY IdStatus DESC", conn)
        Dim tabela As DataTable = New DataTable()
        comando.Fill(tabela)
        Return tabela
    End Function

#Region "User"

    Public Function VerifyUser(ByVal U As User) As DataTable
        Dim comando As SqlDataAdapter = New SqlDataAdapter("SELECT UserName, Password FROM Users WHERE UserName LIKE '" + U.UserName + "'", conn)
        Dim tabela As DataTable = New DataTable()
        comando.Fill(tabela)
        Return tabela
    End Function

    Public Function SelectUsers() As DataTable
        Dim comando As SqlDataAdapter = New SqlDataAdapter("SELECT IdUser, UserName, Password, Administrator, Active FROM Users", conn)
        Dim tabela As DataTable = New DataTable()
        comando.Fill(tabela)
        Return tabela
    End Function

    Public Sub InsertUser(ByVal U As User)
        Dim comm_insert As SqlCommand = New SqlCommand()
        comm_insert.Connection = conn
        comm_insert.CommandType = CommandType.Text
        comm_insert.CommandText = "INSERT INTO Users(UserName, Password, Administrator) VALUES(@user, @password, @administrator)"
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
        'TODO: finish query
        comm_update.CommandText = "UPDATE Users SET UserName = @UserName, Password = @Password, Administrator = @Administrator WHERE IdUser = @IdUser"
        comm_update.Parameters.AddWithValue("@UserName", U.UserName)
        comm_update.Parameters.AddWithValue("@Password", U.Password)
        comm_update.Parameters.AddWithValue("@Administrator", U.Administrator)
        comm_update.Parameters.AddWithValue("@IdUser", U.IdUser)
        conn.Open()
        comm_update.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub DeleteUser(ByVal U As User)
        Dim comm_delete As SqlCommand = New SqlCommand()
        comm_delete.Connection = conn
        comm_delete.CommandType = CommandType.Text
        comm_delete.CommandText = "DELETE FROM Users WHERE IdUser = @IdUser"
        comm_delete.Parameters.AddWithValue("@IdUser", U.IdUser)
        conn.Open()
        comm_delete.ExecuteNonQuery()
        conn.Close()
    End Sub

#End Region

#Region "Status"
    Public Function SelectStatus() As DataTable
        Dim comando As SqlDataAdapter = New SqlDataAdapter("SELECT IdStatus, IdUser, SoftwareStatus, Alarm, Fire, Message, LightBedR1, LightBedR2, LightBedR3, LightLiving, LightDining, LightGarage, TimeStamp FROM Status", conn)
        Dim tabela As DataTable = New DataTable()
        comando.Fill(tabela)
        Return tabela
    End Function

    Public Sub InsertStatus(ByVal S As Status)
        Dim comm_insert As SqlCommand = New SqlCommand()
        comm_insert.Connection = conn
        comm_insert.CommandType = CommandType.Text
        comm_insert.CommandText = "INSERT INTO Status(IdUser, SoftwareStatus, Alarm, Fire, Message, LightBedR1, LightBedR2, LightBedR3, LightLiving, LightDining, LightGarage) VALUES(@IdUser, @SoftwareStatus, @Alarm, @Fire, @Message, @LightBedR1, @LightBedR2, @LightBedR3, @LightLiving, @LightDining, @LightGarage)"
        comm_insert.Parameters.AddWithValue("@IdUser", S.IdUser)
        comm_insert.Parameters.AddWithValue("@SoftwareStatus", S.SoftwareStatus)
        comm_insert.Parameters.AddWithValue("@Alarm", S.Alarm)
        comm_insert.Parameters.AddWithValue("@Fire", S.Fire)
        comm_insert.Parameters.AddWithValue("@Message", S.Message)
        comm_insert.Parameters.AddWithValue("@LightBedR1", S.LightBedR1)
        comm_insert.Parameters.AddWithValue("@LightBedR2", S.LightBedR2)
        comm_insert.Parameters.AddWithValue("@LightBedR3", S.LightBedR3)
        comm_insert.Parameters.AddWithValue("@LightLiving", S.LightLiving)
        comm_insert.Parameters.AddWithValue("@LightDining", S.LightDining)
        comm_insert.Parameters.AddWithValue("@LightGarage", S.LightGarage)
        conn.Open()
        comm_insert.ExecuteNonQuery()
        conn.Close()
    End Sub

    'Public Sub UpdateStatus(ByVal S As Status)
    '    Dim comm_update As SqlCommand = New SqlCommand()
    '    comm_update.Connection = conn
    '    comm_update.CommandType = CommandType.Text
    '    comm_update.CommandText = "UPDATE Status SET IdUser = @IdUser, SoftwareStatus = @SoftwareStatus, Alarm = @Alarm, Fire = @Fire, Message = @Message, LightBedR1 = @LightBedR1, LightBedR2 = @LightBedR2, LightBedR3 = @LightBedR3, LightLiving = @LightLiving, LightDining = @LightDining, LightGarage = @LightGarage, TimeStamp = @getdate"
    '    comm_update.Parameters.AddWithValue("@IdUser", S.IdUser)
    '    comm_update.Parameters.AddWithValue("@SoftwareStatus", S.SoftwareStatus)
    '    comm_update.Parameters.AddWithValue("@Alarm", S.Alarm)
    '    comm_update.Parameters.AddWithValue("@Fire", S.Fire)
    '    comm_update.Parameters.AddWithValue("@Message", S.Message)
    '    comm_update.Parameters.AddWithValue("@LightBedR1", S.LightBedR1)
    '    comm_update.Parameters.AddWithValue("@LightBedR2", S.LightBedR2)
    '    comm_update.Parameters.AddWithValue("@LightBedR3", S.LightBedR3)
    '    comm_update.Parameters.AddWithValue("@LightLiving", S.LightLiving)
    '    comm_update.Parameters.AddWithValue("@LightDining", S.LightDining)
    '    comm_update.Parameters.AddWithValue("@LightGarage", S.LightGarage)
    '    comm_update.Parameters.AddWithValue("@getdate", S.TimeStamp)
    '    comm_update.Parameters.AddWithValue("@IdStatus", S.IdStatus)
    '    conn.Open()
    '    comm_update.ExecuteNonQuery()
    '    conn.Close()
    'End Sub

#Region "Update Status"

    Public Sub UpdateSoftwareStatus(ByVal S As Status)
        Dim comm_update As SqlCommand = New SqlCommand()
        comm_update.Connection = conn
        comm_update.CommandType = CommandType.Text
        comm_update.CommandText = "UPDATE Status SET SoftwareStatus = @SoftwareStatus"

        comm_update.Parameters.AddWithValue("@SoftwareStatus", S.SoftwareStatus)

        conn.Open()
        comm_update.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub UpdateAlarm(ByVal S As Status)
        Dim comm_update As SqlCommand = New SqlCommand()
        comm_update.Connection = conn
        comm_update.CommandType = CommandType.Text
        comm_update.CommandText = "UPDATE Status SET Alarm = @Alarm"

        comm_update.Parameters.AddWithValue("@Alarm", S.Alarm)

        conn.Open()
        comm_update.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub UpdateStatusFire(ByVal S As Status)
        Dim comm_update As SqlCommand = New SqlCommand()
        comm_update.Connection = conn
        comm_update.CommandType = CommandType.Text
        comm_update.CommandText = "UPDATE Status SET Fire = @Fire"

        comm_update.Parameters.AddWithValue("@Fire", S.Fire)

        conn.Open()
        comm_update.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub UpdateLightBedR1(ByVal S As Status)
        Dim comm_update As SqlCommand = New SqlCommand()
        comm_update.Connection = conn
        comm_update.CommandType = CommandType.Text
        comm_update.CommandText = "UPDATE Status SET LightBedR1 = @LightBedR1"

        comm_update.Parameters.AddWithValue("@LightBedR1", S.LightBedR1)

        conn.Open()
        comm_update.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub UpdateLightBedR2(ByVal S As Status)
        Dim comm_update As SqlCommand = New SqlCommand()
        comm_update.Connection = conn
        comm_update.CommandType = CommandType.Text
        comm_update.CommandText = "UPDATE Status SET LightBedR2 = @LightBedR2"

        comm_update.Parameters.AddWithValue("@LightBedR2", S.LightBedR2)

        conn.Open()
        comm_update.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub UpdateLightBedR3(ByVal S As Status)
        Dim comm_update As SqlCommand = New SqlCommand()
        comm_update.Connection = conn
        comm_update.CommandType = CommandType.Text
        comm_update.CommandText = "UPDATE Status SET LightBedR3 = @LightBedR3"

        comm_update.Parameters.AddWithValue("@LightBedR3", S.LightBedR3)

        conn.Open()
        comm_update.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub UpdateLightLiving(ByVal S As Status)
        Dim comm_update As SqlCommand = New SqlCommand()
        comm_update.Connection = conn
        comm_update.CommandType = CommandType.Text
        comm_update.CommandText = "UPDATE Status SET LightLiving = @LightLiving"

        comm_update.Parameters.AddWithValue("@LightLiving", S.LightLiving)

        conn.Open()
        comm_update.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub UpdateLightDining(ByVal S As Status)
        Dim comm_update As SqlCommand = New SqlCommand()
        comm_update.Connection = conn
        comm_update.CommandType = CommandType.Text
        comm_update.CommandText = "UPDATE Status SET LightDining = @LightDining"

        comm_update.Parameters.AddWithValue("@LightDining", S.LightDining)

        conn.Open()
        comm_update.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub UpdateLightGarage(ByVal S As Status)
        Dim comm_update As SqlCommand = New SqlCommand()
        comm_update.Connection = conn
        comm_update.CommandType = CommandType.Text
        comm_update.CommandText = "UPDATE Status SET LightGarage = @LightGarage"

        comm_update.Parameters.AddWithValue("@LightGarage", S.LightGarage)

        conn.Open()
        comm_update.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub DeleteStatus(ByVal S As Status)
        Dim comm_delete As SqlCommand = New SqlCommand()
        comm_delete.Connection = conn
        comm_delete.CommandType = CommandType.Text
        comm_delete.CommandText = "DELETE FROM Status WHERE IdStatus = @IdStatus"
        comm_delete.Parameters.AddWithValue("@IdStatus", S.IdStatus)
        conn.Open()
        comm_delete.ExecuteNonQuery()
        conn.Close()
    End Sub

#End Region

#End Region

#Region "Premissions"


    Public Sub InsertPermissions(ByVal P As Permission)
        Dim comm_insert As SqlCommand = New SqlCommand()
        comm_insert.Connection = conn
        comm_insert.CommandType = CommandType.Text
        comm_insert.CommandText = "INSERT INTO Permissions(IdUser, SoftwareStatus, Alarm, Fire, Message, LightBedR1, LightBedR2, LightBedR3, LightLiving, LightDining, LightGarage) VALUES((SELECT IDENT_CURRENT('Users')), @SoftwareStatus, @Alarm, @Fire, @Message, @LightBedR1, @LightBedR2, @LightBedR3, @LightLiving, @LightDining, @LightGarage)"
        comm_insert.Parameters.AddWithValue("@SoftwareStatus", P.SoftwareStatus)
        comm_insert.Parameters.AddWithValue("@Alarm", P.Alarm)
        comm_insert.Parameters.AddWithValue("@Fire", P.Fire)
        comm_insert.Parameters.AddWithValue("@Message", P.Message)
        comm_insert.Parameters.AddWithValue("@LightBedR1", P.LightBedR1)
        comm_insert.Parameters.AddWithValue("@LightBedR2", P.LightBedR2)
        comm_insert.Parameters.AddWithValue("@LightBedR3", P.LightBedR3)
        comm_insert.Parameters.AddWithValue("@LightLiving", P.LightLiving)
        comm_insert.Parameters.AddWithValue("@LightDining", P.LightDining)
        comm_insert.Parameters.AddWithValue("@LightGarage", P.LightGarage)
        conn.Open()
        comm_insert.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function SelectID(ByVal U As User) As DataTable
        Dim comando As SqlDataAdapter = New SqlDataAdapter("SELECT IdUser FROM Users WHERE UserName LIKE '" + U.UserName + "' AND Password LIKE '" + U.Password + "'", conn)
        Dim tabela As DataTable = New DataTable()
        comando.Fill(tabela)
        Return tabela
    End Function

    Public Function SelectPermissionsByUserId(ByVal U As User) As DataTable
        Dim comando As SqlDataAdapter = New SqlDataAdapter("SELECT IdPermission ,IdUser, SoftwareStatus, Alarm, Fire, Message, LightBedR1, LightBedR2, LightBedR3, LightLiving, LightDining, LightGarage, TimeStamp FROM Permissions WHERE IdUser = " + U.IdUser.ToString(), conn)
        Dim tabela As DataTable = New DataTable()
        comando.Fill(tabela)
        Return tabela
    End Function

End Class

#End Region
