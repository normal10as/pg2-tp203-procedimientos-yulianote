Module ejercicio3_08
    Enum operacion As Byte
        suma = 1
        resta
        multiplicacion
        division
    End Enum
    Sub main()
        Console.WriteLine("     SUMA     ")
        Console.WriteLine("Dos parametros")
        Resultado(10, 2)
        Console.WriteLine("Tres parametros")
        Resultado(operacion.suma, 10, 2, 5)
        Console.WriteLine("Cuatro parametros")
        Resultado(operacion.suma, 10, 2, 5, 7)

        Console.WriteLine("     RESTA     ")
        Console.WriteLine("Dos parametros")
        Resultado(operacion.resta, 10, 2)
        Console.WriteLine("Tres parametros")
        Resultado(operacion.resta, 10, 2, 5)
        Console.WriteLine("Cuatro parametros")
        Resultado(operacion.resta, 10, 2, 5, 7)

        Console.WriteLine("     MULTIPLICACION     ")
        Console.WriteLine("Dos parametros")
        Resultado(operacion.multiplicacion, 10, 2)
        Console.WriteLine("Tres parametros")
        Resultado(operacion.multiplicacion, 10, 2, 5)
        Console.WriteLine("Cuatro parametros")
        Resultado(operacion.multiplicacion, 10, 2, 5, 7)

        Console.WriteLine("     DIVISION     ")
        Console.WriteLine("Dos parametros")
        Resultado(operacion.division, 10, 2)
        Console.WriteLine("Tres parametros")
        Resultado(operacion.division, 10, 2, 5)
        Console.WriteLine("Cuatro parametros")
        Resultado(operacion.division, 10, 2, 5, 7)
    End Sub


    Private Function Resultado(ByRef valuno As Decimal, ByRef valdos As Decimal) As Decimal
        Return Resultado(operacion.suma, valuno, valdos)
    End Function

    Private Function Resultado(ByRef op As Byte, ByRef valuno As Decimal, ByRef valdos As Decimal, ByRef valtres As Decimal) As Decimal
        Return Resultado(op, Resultado(op, valuno, valdos), valtres)
    End Function

    Private Function Resultado(ByRef op As Byte, ByRef valuno As Decimal, ByRef valdos As Decimal, ByRef valtres As Decimal, ByRef valcua As Decimal) As Decimal
        Return Resultado(op, Resultado(op, Resultado(op, valuno, valdos), valtres), valcua)
    End Function

    Private Function Resultado(ByRef op As Byte, ByRef valuno As Decimal, ByRef valdos As Decimal) As Decimal
        Dim final As Decimal = 0
        Select Case op
            Case 1
                final = valuno + valdos
                Console.WriteLine(valuno & " + " & valdos & " = " & final)
            Case 2
                final = valuno - valdos
                Console.WriteLine(valuno & " - " & valdos & " = " & final)
            Case 3
                final = valuno / valdos
                Console.WriteLine(valuno & " / " & valdos & " = " & final)
            Case 4
                final = valuno * valdos
                Console.WriteLine(valuno & " * " & valdos & " = " & final)
        End Select
        Return final
    End Function
End Module
