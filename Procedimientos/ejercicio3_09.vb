Module ejercicio3_09

    Sub main()
        Dim ingresado As Decimal
        Dim ingresado_dos As Decimal
        Dim ingresado_tres As Decimal
        Console.WriteLine("Ingrese el valor del lado: ")
        ingresado = Console.ReadLine
        Console.WriteLine("El area de un cuadrado es A = lado * lado =" & Area(ingresado))
        Console.WriteLine("Ingrese el  segundo valor: ")
        ingresado_dos = Console.ReadLine
        Console.WriteLine("El area de un rectangulo es A = base * altura = " & Area(ingresado, ingresado_dos))
        Console.WriteLine("Ingrese el  tercer valor: ")
        ingresado_tres = Console.ReadLine
        Console.WriteLine("El area de un trapecio es A = (base uno + base dos) / 2 * altura = " & Area(ingresado, ingresado_dos, ingresado_tres))
    End Sub
    Private Function Area(ByRef lado As Decimal) As Decimal
        Dim total_area As Decimal
        total_area = lado * lado
        Return total_area
    End Function
    Private Function Area(ByRef base As Decimal, ByRef altura As Decimal) As Decimal
        Dim total_area As Decimal
        total_area = base * altura
        Return total_area
    End Function
    Private Function Area(ByRef base_uno As Decimal, ByRef base_dos As Decimal, ByRef h As Decimal) As Decimal
        Dim total_area As Decimal
        total_area = (base_uno + base_uno) / 2 * h
        Return total_area
    End Function
End Module
