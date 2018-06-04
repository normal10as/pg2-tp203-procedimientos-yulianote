Module ejercicio3_01
    Private hoy As Date
    Sub Main()
        hoy = Now
        fecha()
        hora()
    End Sub
    Friend Sub fecha()
        Console.WriteLine(hoy.Day & "/" & hoy.Month & "/" & hoy.Year)
    End Sub
    Friend Function hora() As Byte
        Console.WriteLine(hoy.Hour & ":" & hoy.Minute & ":" & hoy.Second)
        Return 0
    End Function
End Module
