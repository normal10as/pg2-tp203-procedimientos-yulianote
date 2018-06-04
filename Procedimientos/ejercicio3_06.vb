Module ejercicio3_06
    Sub main()
        Dim ingresado As Single
        Console.WriteLine("ingrese un valor")
        ingresado = Console.ReadLine()
        ingresado = Math.Floor(ingresado)
        Console.WriteLine("La sumatoria Total es " & Validar(ingresado))
    End Sub
    Private Function Validar(ByRef valor As ULong) As ULong
        Dim a As Byte = 1
        Dim v As ULong
        Dim acumulador As ULong = 0
        While (a = 1)
            If valor >= 0 Then
                For cantidad As UShort = 1 To valor Step cantidad + 1

                    v = Math.Pow(cantidad, 2)
                    acumulador = acumulador + v
                    Console.WriteLine("v = " & cantidad & " ^ 2 =  " & v & " ---> Acumulador = " & acumulador)
                    v = 0
                Next
                a = 0
            Else
                Console.WriteLine("Solo podes ingresar valores positivos")
                Console.WriteLine("ingrese un valor")
                valor = Console.ReadLine()
                a = 1
            End If
        End While
        Return acumulador
    End Function
End Module
