Module ejercicio3_03
    Sub main()
        Dim a As Integer
        Console.WriteLine("ingrese el valor ")
        a = Console.ReadLine()
        For contador As Single = 2 To 6 Step 1
            Console.WriteLine(a & "^" & contador & " = " & potencia(a, contador))
        Next
    End Sub
    Private Function potencia(ByRef numero As Integer, ByRef contador As Integer) As Integer
        Return Math.Pow(numero, contador)
    End Function


End Module
