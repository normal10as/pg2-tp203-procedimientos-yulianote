Module ejercicio3_04
    'Sub main()
    '    Dim ladoA As Decimal
    '    Dim ladoB As Decimal
    '    Dim resultado As Int16
    '    Console.WriteLine("Ingrese lado A")
    '    ladoA = Console.ReadLine()
    '    Console.WriteLine("Ingrese lado B")
    '    ladoB = Console.ReadLine()
    '    ladoA = Math.Floor(ladoA)
    '    ladoB = Math.Floor(ladoA)
    '    resultado = validar(ladoA, ladoB)
    '    Console.WriteLine("La hipotenusa es =" & resultado)
    'End Sub
    'Private Function validar(ByRef ValA As Int16, ByRef ValB As Int16) As Int16
    '    Dim a As Int16 = 1
    '    Dim h As Int16
    '    While (a = 1)
    '        If ValA > 0 And ValB > 0 Then
    '            h = Math.Sqrt(Math.Pow(ValA, 2) + Math.Pow(ValB, 2))
    '            a = 0
    '        Else
    '            If ValA <= 0 And ValB <= 0 Then
    '                Console.WriteLine("Ningun valor corresponde a un entero positivo")
    '            ElseIf ValB <= 0 Then
    '                Console.WriteLine("El valor B no es entero positivo")
    '            Else
    '                Console.WriteLine("El valor A no es entero positivo")
    '            End If
    '            Console.WriteLine("Ingrese lado A")
    '            ValA = Console.ReadLine()
    '            Console.WriteLine("Ingrese lado B")
    '            ValB = Console.ReadLine()
    '            a = 1
    '        End If
    '    End While
    '    Return h
    'End Function
    Sub main()
        Dim ladoA As Decimal
        Dim ladoB As Decimal
        ingresarValor(ladoA)
        ingresarValor(ladoB)
        Console.WriteLine("su hipotenusa es " & hipotenusa(ladoA, ladoB))
    End Sub
    Private Sub ingresarValor(ByRef valor As Integer)
        Do
            Console.WriteLine("Ingrese lado A")
            valor = Console.ReadLine()
        Loop Until validar(valor)
    End Sub
    Private Function validar(num As Integer) As Boolean
        Return num > 0
    End Function
    Private Function hipotenusa(ByVal a As Integer, ByVal b As Integer) As Double
        Return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))
    End Function
End Module
