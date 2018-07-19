Imports System.Data.SqlClient
Imports DAL.Types
Imports Microsoft.VisualBasic

Public Class Methods

    Private conn As SqlConnection = New SqlConnection("Data Source=.\sqlexpress;Initial Catalog=DomoSys;Integrated Security=True")

    Public Function UserLogin(ByVal U As User) As Integer
        Dim comm_count As SqlCommand = New SqlCommand()
        comm_count.Connection = conn
        comm_count.CommandType = CommandType.Text
        comm_count.CommandText = "SELECT UserName, Password FROM Users WHERE UserName=@user AND Password=@password"
        comm_count.Parameters.AddWithValue("@user", U.UserName)
        comm_count.Parameters.AddWithValue("@password", U.Password)

        Dim number As Integer
        conn.Open()
        Dim count As Integer = Integer.TryParse(comm_count.ExecuteScalar(), number)
        conn.Close()

        Return count
    End Function

    Public Function UserLogin1(ByVal U As User) As DataTable
        Dim comando As SqlDataAdapter = New SqlDataAdapter("SELECT UserName, Password FROM Users WHERE UserName LIKE '" + U.UserName + "' AND Password LIKE '" + U.Password + "'", conn)
        Dim tabela As DataTable = New DataTable()
        comando.Fill(tabela)
        Return tabela
    End Function



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

    Public Sub InsertStatus(ByVal S As Status)
        Dim comm_insert As SqlCommand = New SqlCommand()
        comm_insert.Connection = conn
        comm_insert.CommandType = CommandType.Text
        comm_insert.CommandText = "INSERT INTO [Status]([IdUser], [SoftwareStatus], [Alarm], [Fire], [Message], [LightBedR1], [LightBedR2], [LightBedR3], [LightLiving], [LightDining], [LightGarage]) VALUES(@IdUser, @SoftwareStatus, @Alarm, @Fire, @Message, @LightBedR1, @LightBedR2, @LightBedR3, @LightLiving, @LightDining, @LightGarage)"
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

    Public Sub UpdateStatus(ByVal S As Status)
        Dim comm_update As SqlCommand = New SqlCommand()
        comm_update.Connection = conn
        comm_update.CommandType = CommandType.Text
        comm_update.CommandText = "UPDATE INTO [Status]([IdUser], [SoftwareStatus], [Alarm], [Fire], [Message], [LightBedR1], [LightBedR2], [LightBedR3], [LightLiving], [LightDining], [LightGarage], [TimeStamp] ) VALUES(@IdUser, @SoftwareStatus, @Alarm, @Fire, @Message, @LightBedR1, @LightBedR2, @LightBedR3, @LightLiving, @LightDining, @LightGarage, @getdate())"
        comm_update.Parameters.AddWithValue("@IdUser", S.IdUser)
        comm_update.Parameters.AddWithValue("@SoftwareStatus", S.SoftwareStatus)
        comm_update.Parameters.AddWithValue("@Alarm", S.Alarm)
        comm_update.Parameters.AddWithValue("@Fire", S.Fire)
        comm_update.Parameters.AddWithValue("@Message", S.Message)
        comm_update.Parameters.AddWithValue("@LightBedR1", S.LightBedR1)
        comm_update.Parameters.AddWithValue("@LightBedR2", S.LightBedR2)
        comm_update.Parameters.AddWithValue("@LightBedR3", S.LightBedR3)
        comm_update.Parameters.AddWithValue("@LightLiving", S.LightLiving)
        comm_update.Parameters.AddWithValue("@LightDining", S.LightDining)
        comm_update.Parameters.AddWithValue("@LightGarage", S.LightGarage)
        comm_update.Parameters.AddWithValue("@getdate()", S.TimeStamp)
        conn.Open()
        comm_update.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub DeleteStatus(ByVal S As Status)
        Dim comm_delete As SqlCommand = New SqlCommand()
        comm_delete.Connection = conn
        comm_delete.CommandType = CommandType.Text
        comm_delete.CommandText = "DELETE FROM [Status] WHERE ([IdStatus] = '@IdStatus'"
        conn.Open()
        comm_delete.ExecuteNonQuery()
        conn.Close()
    End Sub

End Class
