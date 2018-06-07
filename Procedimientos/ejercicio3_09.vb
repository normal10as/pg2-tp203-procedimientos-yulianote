Module ejercicio3_09

    Sub main()
        Dim ingresado As Single
        Dim valuno As Single
        Dim valdos As Single
        Dim valtre As Single
        Do
            Console.WriteLine("-------Calcula el area deseada-------")
            Console.WriteLine("1- Calcular el area de un cuadrado")
            Console.WriteLine("2- Calcular el area de un rectangulo")
            Console.WriteLine("3- Calcular el area de un trapecio")
            Console.WriteLine("0- Salir")
            Console.WriteLine("Ingrese el area deseada a calcular: ")
            ingresado = Console.ReadLine()
            Select Case (ingresado)
                Case 0
                    Exit Do
                Case 1
                    Console.WriteLine("Ingrese el lado: ")
                    valuno = Console.ReadLine()
                    Area(valuno)
                    Console.WriteLine("El area de un cuadrado es A = lado * lado =" & Area(valuno))
                Case 2
                    Console.WriteLine("Ingrese el base: ")
                    valuno = Console.ReadLine()
                    Console.WriteLine("Ingrese el altura: ")
                    valdos = Console.ReadLine()

                    Console.WriteLine("El area de un rectangulo es A = base * altura = " & Area(valuno, valdos))
                Case 3
                    Console.WriteLine("Ingrese el base menor: ")
                    valuno = Console.ReadLine()
                    Console.WriteLine("Ingrese el base mayor: ")
                    valdos = Console.ReadLine()
                    Console.WriteLine("Ingrese el altura: ")
                    valtre = Console.ReadLine()
                    Console.WriteLine("El area de un trapecio es A = (base uno + base dos) / 2 * altura = " & Area(valuno, valdos, valtre))
                Case Else
                    Console.WriteLine("----fuera de rango----")
                    Console.WriteLine("Ingrese el area deseada a calcular: ")
                    ingresado = Console.ReadLine()

            End Select
        Loop While (ingresado <> 0)
    End Sub
    Private Function Area(ByRef lado As Single) As Single
        Dim total_area As Single
        total_area = lado * lado
        Return total_area
    End Function
    Private Function Area(ByRef base As Single, ByRef altura As Single) As Single
        Dim total_area As Single
        total_area = base * altura
        Return total_area
    End Function
    Private Function Area(ByRef base_uno As Single, ByRef base_dos As Single, ByRef h As Single) As Single
        Dim total_area As Single
        total_area = ((base_uno + base_uno) / 2) * h
        Return total_area
    End Function
End Module
