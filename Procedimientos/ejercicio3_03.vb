Module ejercicio3_03
    Private a As Double
    Sub main()
        Console.WriteLine("ingrese el valor ")
        a = Console.ReadLine()
        For contcinco As Single = 0 To 5 Step 1
            Dim final As Double
            final = potencia(a)

        Next
    End Sub
    Private Function potencia(ByRef a As Double) As Double
        a = Math.Pow(a, 2)
        Console.WriteLine(a)
        Return a
    End Function


End Module
