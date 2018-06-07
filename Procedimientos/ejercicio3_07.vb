Module ejercicio3_07
    Enum operacion As Byte
        suma = 1
        resta
        multiplicacion
        division
    End Enum
    Sub main()
        Console.WriteLine(calcular(5, 3))
        Console.WriteLine(Calcular(operacion.suma, 10, 2))
        Console.WriteLine(calcular(operacion.suma, 10, 2, 5))
        Console.WriteLine(Calcular(operacion.suma, 10, 2, 5, 7))

        Console.WriteLine(Calcular(operacion.resta, 10, 2))
        Console.WriteLine(Calcular(operacion.resta, 10, 2, 5))
        Console.WriteLine(Calcular(operacion.resta, 10, 2, 5, 7))

        Console.WriteLine(Calcular(operacion.multiplicacion, 10, 2))
        Console.WriteLine(Calcular(operacion.multiplicacion, 10, 2, 5))
        Console.WriteLine(Calcular(operacion.multiplicacion, 10, 2, 5, 7))

        Console.WriteLine(Calcular(operacion.division, 10, 2))
        Console.WriteLine(Calcular(operacion.division, 10, 2, 5))
        Console.WriteLine(Calcular(operacion.division, 10, 2, 5, 7))
    End Sub

    Private Function Calcular(op As operacion, ByRef valuno As Decimal, ByRef valdos As Decimal) As Decimal

        Select Case op
            Case 1
                Return valuno + valdos
            Case 2
                Return valuno - valdos
            Case 3
                Return valuno / valdos
            Case Else
                Return valuno * valdos
        End Select

    End Function

    Private Function calcular(ByRef valuno As Decimal, ByRef valdos As Decimal) As Decimal
        Return Calcular(operacion.suma, valuno, valdos)
    End Function

    Private Function Calcular(op As operacion, ByRef valuno As Decimal, ByRef valdos As Decimal, ByRef valtres As Decimal) As Decimal
        Return Calcular(op, Calcular(op, valuno, valdos), valtres)
    End Function

    Private Function Calcular(op As operacion, ByRef valuno As Decimal, ByRef valdos As Decimal, ByRef valtres As Decimal, ByRef valcua As Decimal) As Decimal
        Return Calcular(op, Calcular(op, valuno, valdos), Calcular(op, valtres, valcua))
    End Function

End Module
