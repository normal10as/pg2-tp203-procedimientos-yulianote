Module ejercicio3_02
    Private diasa As Int32
    Dim fecha As Date
    Sub main()
        Console.WriteLine("ingrese la fecha ( dd/mm/aa ) ")
        fecha = Console.ReadLine()
        Console.WriteLine("ingrese la cantidad de dias a sumar ")
        diasa = Console.ReadLine()
        sumadedias(fecha, diasa)
    End Sub
    Private Function sumadedias(ByRef fec As Date, ByRef dia As Int32) As Date
        Dim nuevafecha As Date
        nuevafecha = fec.AddDays(dia)
        Console.WriteLine("la fecha sumada es " & nuevafecha)
        Return nuevafecha
    End Function

End Module
