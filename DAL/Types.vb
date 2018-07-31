Public Class Types

    Partial Public Class User
        Public Property IdUser As Integer
        Public Property UserName As String
        Public Property Password As String
        Public Property Administrator As Boolean
    End Class

    Partial Public Class Status
        Public Property IdStatus As Integer
        Public Property IdUser As Integer
        Public Property SoftwareStatus As Integer
        Public Property Alarm As Integer
        Public Property Fire As Integer
        Public Property Message As String
        Public Property LightBedR1 As Integer
        Public Property LightBedR2 As Integer
        Public Property LightBedR3 As Integer
        Public Property LightLiving As Integer
        Public Property LightDining As Integer
        Public Property LightGarage As Integer
        Public Property TimeStamp As Date
    End Class

    Partial Public Class Permission
        Public Property IdStatus As Integer
        Public Property IdUser As Integer
        Public Property SoftwareStatus As Integer
        Public Property Alarm As Integer
        Public Property Fire As Integer
        Public Property Message As Integer
        Public Property LightBedR1 As Integer
        Public Property LightBedR2 As Integer
        Public Property LightBedR3 As Integer
        Public Property LightLiving As Integer
        Public Property LightDining As Integer
        Public Property LightGarage As Integer
        Public Property TimeStamp As Date
    End Class

End Class