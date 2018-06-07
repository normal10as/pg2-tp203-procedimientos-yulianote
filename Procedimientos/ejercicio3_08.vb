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
        calcular(10, 2)
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

    Private Function calcular(ByRef valuno As Decimal, ByRef valdos As Decimal) As Decimal
        Return Resultado(operacion.suma, valuno, valdos)
    End Function

    Private Function Calcular(op As operacion, ByRef valuno As Decimal, ByRef valdos As Decimal, ByRef valtres As Decimal) As Decimal
        Return Resultado(op, valuno, valdos, valtres)
    End Function

    Private Function Calcular(op As operacion, ByRef valuno As Decimal, ByRef valdos As Decimal, ByRef valtres As Decimal, ByRef valcua As Decimal) As Decimal
        Return Resultado(op, valuno, valdos, valtres, valcua)
    End Function

    Private Function Resultado(ByRef op As Byte, ByRef valuno As Single, ByRef valdos As Single) As Single
        Dim final As Single = 0
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

    Private Function Resultado(ByRef op As Byte, ByRef valuno As Single, ByRef valdos As Single, ByRef valtres As Single) As Single
        Dim final As Decimal = 0
        Select Case op
            Case 1
                final = valuno + valdos + valtres
                Console.WriteLine(valuno & " + " & valdos & " + " & valtres & " = " & final)
            Case 2
                final = valuno - valdos - valtres
                Console.WriteLine(valuno & " - " & valdos & " - " & valtres & " = " & final)
            Case 3
                final = valuno / valdos / valtres
                Console.WriteLine(valuno & " / " & valdos & " / " & valtres & " = " & final)
            Case 4
                final = valuno * valdos * valtres
                Console.WriteLine(valuno & " * " & valdos & " * " & valtres & " = " & final)
        End Select
        Return final
    End Function

    Private Function Resultado(ByRef op As Byte, ByRef valuno As Single, ByRef valdos As Single, ByRef valtres As Single, ByRef valcu As Single) As Single
        Dim final As Single = 0
        Select Case op
            Case 1
                final = valuno + valdos + valtres + valcu
                Console.WriteLine(valuno & " + " & valdos & " + " & valtres & " + " & valcu & " = " & final)
            Case 2
                final = valuno - valdos - valtres - valcu
                Console.WriteLine(valuno & " - " & valdos & " - " & valtres & " - " & valcu & " = " & final)
            Case 3
                final = valuno / valdos / valtres / valcu
                Console.WriteLine(valuno & " / " & valdos & " / " & valtres & " / " & valcu & " = " & final)
            Case 4
                final = valuno * valdos * valtres * valcu
                Console.WriteLine(valuno & " * " & valdos & " * " & valtres & " * " & valcu & " = " & final)
        End Select
        Return final
    End Function
End Module
